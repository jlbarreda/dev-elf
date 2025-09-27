#!/bin/bash

# IMPORTANT: If you modify this file, run this command to keep execution permissions:
# git add --chmod=+x .ci-cd/versionize-and-push.sh

set -e

branch=$(git rev-parse --abbrev-ref HEAD)
if [[ "$branch" == "main" ]]; then
  echo "✅ On main branch, skipping versionize."
  exit 0
fi

echo "🔄 Checking if versionize is needed..."

GIT_USER_NAME=$(git config user.name)
GIT_USER_EMAIL=$(git config user.email)

if [[ -z "$GIT_USER_NAME" || -z "$GIT_USER_EMAIL" ]]; then
  echo "❌ Git user.name or user.email not set. Please configure them."
  exit 1
fi

# Get the remote tracking branch, handle case where it doesn't exist
remote_branch="origin/$branch"
if ! git show-ref --verify --quiet "refs/remotes/$remote_branch"; then
  echo "ℹ️ Remote branch $remote_branch doesn't exist yet. Allowing push."
  exit 0
fi

# Check if there are any unpushed version commits
unpushed_version_commits=$(git log --oneline --grep="chore(release):" "$remote_branch..HEAD" 2>/dev/null | wc -l || echo 0)

if [[ $unpushed_version_commits -gt 0 ]]; then
  echo "✅ Version commits already exist and will be pushed."
  exit 0
fi

# Check if there are conventional commits that need versioning
conventional_commits=$(git log --oneline --grep="^feat" --grep="^fix" --grep="^BREAKING CHANGE" "$remote_branch..HEAD" 2>/dev/null | wc -l || echo 0)

if [[ $conventional_commits -eq 0 ]]; then
  echo "ℹ️ No conventional commits found that require versioning."
  exit 0
fi

echo "🚨 Found conventional commits that need versioning!"
echo "Please run the following commands to version and push:"
echo "  dotnet versionize"
echo "  git push"
echo ""
echo "This will create a version commit and tag, then push everything."
exit 1
