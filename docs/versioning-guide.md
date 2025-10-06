# Versioning Guide

This document explains the versioning strategy and automation for the DevElf project.

## Versioning Strategy

### Semantic Versioning
We follow [Semantic Versioning (SemVer)](https://semver.org/) with the format `MAJOR.MINOR.PATCH`:

- **MAJOR**: Breaking changes that are not backward compatible
- **MINOR**: New features that are backward compatible
- **PATCH**: Bug fixes that are backward compatible

### Pre-release Versions
During development, we use alpha pre-releases with the format `MAJOR.MINOR.PATCH-alpha.N`:

- `0.4.0-alpha.7` - Alpha version 7 of the 0.4.0 release
- `1.0.0-alpha.1` - First alpha of the 1.0.0 release

### Stable Releases
Stable releases follow the standard SemVer format:
- `1.0.0` - First stable release
- `1.1.0` - Minor feature release
- `1.1.1` - Patch release

## Automated Versioning

### Conventional Commits
We use [Conventional Commits](https://www.conventionalcommits.org/) to automatically determine version bumps:

- `feat:` - Triggers a MINOR version bump
- `fix:` - Triggers a PATCH version bump
- `BREAKING CHANGE:` - Triggers a MAJOR version bump

### Version Detection
We use [Versionize](https://github.com/versionize/versionize) for automatic versioning based on conventional commits:

- Version is automatically determined from conventional commit messages
- No manual version management required
- Consistent versioning across all projects

### Pre-push Hooks
Husky pre-push hooks ensure versioning happens automatically:

- `dotnet versionize` runs before every push
- Analyzes commits since last version
- Updates version and changelog automatically
- Creates git tags for new versions

## Workflow

### Development Workflow
1. Make changes with conventional commit messages
2. Commit changes: `git commit -m "feat: add new feature"`
3. Push changes: `git push`
4. Pre-push hook automatically runs `dotnet versionize`
5. New version commit and tag are created
6. Changes are pushed with version updates

### Release Workflow
1. **Alpha Releases**: Automatic via pre-push hooks
2. **Stable Releases**: Manual via GitHub Actions workflow
3. **Package Publishing**: Automatic via CI/CD pipeline

## Configuration

### Versionize Configuration
The project uses the following versionize configuration in `.versionize`:
```json
{
  "workingDir": ".",
  "preRelease": "alpha"
}
```

## CI/CD Pipeline

### Feature Branch Testing
- Tests run on all pull requests
- Security scanning with CodeQL
- Package vulnerability checks
- Outdated package detection

### Main Branch
- Full CI/CD pipeline
- Automatic NuGet package publishing
- Release workflow triggers

### Release Workflow
- Triggered by git tags (e.g., `v1.0.0`)
- Creates GitHub releases
- Publishes to NuGet
- Updates documentation

## Best Practices

### Commit Messages
Use conventional commit format:
```bash
feat: add new validation method
fix: resolve null reference exception
docs: update API documentation
chore: update dependencies
```

### Version Management
- Never manually edit version numbers
- Let Versionize handle version detection and tagging
- Use conventional commits for automatic versioning
- Tag releases with `v` prefix (e.g., `v1.0.0`)

### Release Process
1. Ensure all features are merged to main
2. Create a stable release tag: `git tag v1.0.0`
3. Push the tag: `git push origin v1.0.0`
4. GitHub Actions will handle the release

## Troubleshooting

### Version Not Updating
- Check if commits follow conventional commit format
- Verify Versionize is properly configured
- Ensure git tags are properly formatted

### Pre-push Hook Failing
- Check if `dotnet versionize` is installed
- Verify Husky is properly configured
- Check for git repository issues

### Package Publishing Issues
- Verify NuGet credentials are configured
- Check CI/CD pipeline logs
- Ensure version is properly formatted

## Tools Used

- **Versionize**: Conventional commit-based versioning and git tagging
- **Husky**: Git hooks for automation
- **GitHub Actions**: CI/CD pipeline
- **NuGet**: Package publishing

## References

- [Semantic Versioning](https://semver.org/)
- [Conventional Commits](https://www.conventionalcommits.org/)
- [Versionize Documentation](https://github.com/versionize/versionize)
