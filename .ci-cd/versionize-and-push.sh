#!/bin/bash

# IMPORTANT: If you modify this file, run this command to keep execution permissions:
# git add --chmod=+x .ci-cd/versionize-and-push.sh

set -e

branch=$(git rev-parse --abbrev-ref HEAD)
if [[ "$branch" == "main" ]]; then
  echo "Skipping versionize on the main branch."
  exit 0
fi

echo "🔄 Running versionize before push..."

GIT_USER_NAME=$(git config user.name)
GIT_USER_EMAIL=$(git config user.email)

if [[ -z "$GIT_USER_NAME" || -z "$GIT_USER_EMAIL" ]]; then
  echo "❌ Git user.name or user.email not set. Please configure them."
  exit 1
fi

if ! dotnet versionize; then
  echo "❌ Versionize failed. Check your commit history."
  exit 1
fi

if git diff --cached --quiet; then
  echo "ℹ️ Versionize made no staged changes. Nothing to commit."
else
  echo "✅ Versionize committed changes. Ready to push."
fi
