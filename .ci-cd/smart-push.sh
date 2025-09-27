#!/bin/bash

# IMPORTANT: If you modify this file, run this command to keep execution permissions:
# git add --chmod=+x .ci-cd/smart-push.sh

set -e

branch=$(git rev-parse --abbrev-ref HEAD)

echo "🚀 Smart push: Checking for versioning needs..."

GIT_USER_NAME=$(git config user.name)
GIT_USER_EMAIL=$(git config user.email)

if [[ -z "$GIT_USER_NAME" || -z "$GIT_USER_EMAIL" ]]; then
  echo "❌ Git user.name or user.email not set. Please configure them."
  exit 1
fi

# Skip versionize on main branch
if [[ "$branch" == "main" ]]; then
  echo "✅ On main branch, skipping versionize."
  git push "$@"
  exit 0
fi

# Always run versionize - let it handle whether versioning is needed
echo "🔄 Running versionize..."

if ! dotnet versionize; then
  echo "❌ Versionize failed. Check your commit history."
  exit 1
fi

echo "✅ Versionize completed!"

# Now do the actual push with all arguments passed through
echo "📤 Pushing to remote..."
git push "$@"

# Also push tags if not already specified
if [[ ! "$*" =~ --tags ]] && [[ ! "$*" =~ --follow-tags ]]; then
  echo "🏷️ Pushing tags..."
  git push --tags 2>/dev/null || echo "ℹ️ No new tags to push or tags already exist."
fi

echo "✅ Push completed successfully!"
