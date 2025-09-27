# Smart Push Workflow

This repository includes an automated versioning and push workflow using `versionize` and a custom smart-push script.

## How It Works

### Automatic Versioning with Smart Push

Use `git vpush` instead of `git push` for automatic versioning:

```bash
git vpush
```

This command will:
1. Check if you have conventional commits (feat:, fix:, BREAKING CHANGE:) that need versioning
2. Automatically run `dotnet versionize` if needed
3. Push all commits including the new version commits and tags
4. Handle everything in one seamless operation

### Manual Push

Regular `git push` still works but only does basic validation (git user config check).

### Supported Commit Types

The following conventional commit prefixes trigger automatic versioning:
- `feat:` - New features (minor version bump)
- `fix:` - Bug fixes (patch version bump)
- `BREAKING CHANGE:` - Breaking changes (major version bump)

### Branch Behavior

- **Feature branches**: Automatic versioning with `git vpush`
- **Main branch**: Versioning is skipped (versions should be created from feature branches)

## Examples

```bash
# Make some changes
git add .
git commit -m "feat: add new awesome feature"

# Push with automatic versioning
git vpush
# ✅ This will create version 0.3.0, commit it, tag it, and push everything

# Make a bug fix
git commit -m "fix: resolve issue with validation"

# Push with automatic versioning  
git vpush
# ✅ This will create version 0.3.1, commit it, tag it, and push everything

# Regular commits don't trigger versioning
git commit -m "docs: update README"
git vpush
# ✅ This will just push the documentation change without versioning
```

## Files

- `.ci-cd/smart-push.sh` - The main script that handles versionize + push
- `.ci-cd/versionize-and-push.sh` - Pre-push hook for basic validation  
- `.husky/pre-push` - Husky configuration that runs the pre-push validation

## Git Alias

The `git vpush` alias is automatically configured to run the smart-push script:

```bash
git config alias.vpush '!bash .ci-cd/smart-push.sh'
```

You can also run the script directly:
```bash
bash .ci-cd/smart-push.sh
```
