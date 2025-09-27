#!/bin/bash

# IMPORTANT: If you modify this file, run this command to keep execution permissions:
# git add --chmod=+x .ci-cd/versionize-and-push.sh

set -e

branch=$(git rev-parse --abbrev-ref HEAD)

echo "🚀 Pre-push: Checking for versioning needs..."

GIT_USER_NAME=$(git config user.name)
GIT_USER_EMAIL=$(git config user.email)

if [[ -z "$GIT_USER_NAME" || -z "$GIT_USER_EMAIL" ]]; then
  echo "❌ Git user.name or user.email not set. Please configure them:"
  echo "  git config user.name 'Your Name'"
  echo "  git config user.email 'your.email@example.com'"
  exit 1
fi

# Skip versionize on main branch
if [[ "$branch" == "main" ]]; then
  echo "✅ On main branch, skipping versionize."
  exit 0
fi

# Skip versionize if the HEAD commit is already a release commit
head_commit_message=$(git log -1 --pretty=%s)
if [[ "$head_commit_message" =~ ^chore\(release\): ]]; then
  echo "✅ HEAD commit is already a release commit, skipping versionize."
  exit 0
fi

# Capture the current commit hash before running versionize
current_commit=$(git rev-parse HEAD)

echo "🔄 Running versionize before push..."

if ! dotnet versionize; then
  echo "❌ Versionize failed. Check your commit history."
  exit 1
fi

# Check if versionize created new commits
new_commit=$(git rev-parse HEAD)

if [[ "$current_commit" != "$new_commit" ]]; then
  echo "✅ Versionize completed and created new version commits!"
  echo "🚫 Aborting current push to include version commits. Please run 'git push' again."
  exit 1
fi

echo "✅ Versionize completed with no new commits needed!"
