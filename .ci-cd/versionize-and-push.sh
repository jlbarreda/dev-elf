#!/bin/bash

# IMPORTANT: If you modify this file, run this command to keep execution permissions:
# git add --chmod=+x .ci-cd/versionize-and-push.sh

set -e

# Just do basic validation - the smart-push script handles versionize logic
GIT_USER_NAME=$(git config user.name)
GIT_USER_EMAIL=$(git config user.email)

if [[ -z "$GIT_USER_NAME" || -z "$GIT_USER_EMAIL" ]]; then
  echo "❌ Git user.name or user.email not set. Please configure them:"
  echo "  git config user.name 'Your Name'"
  echo "  git config user.email 'your.email@example.com'"
  exit 1
fi

echo "✅ Pre-push validation passed."
