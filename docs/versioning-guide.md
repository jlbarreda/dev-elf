# Versioning Guide

This document explains the versioning strategy and automated release workflow for the DevElf project.

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

## Release Workflow
Releases are created by pushing a Git tag to the repository. The tag format should be `v` followed by the version number (e.g., `v1.2.3`).

1. **Create a Tag**: Once `main` has all the commits for a release, create an annotated tag.
   ```bash
   # For a stable release
   git tag -a v1.0.0 -m "Release version 1.0.0"

   # For a pre-release
   git tag -a v1.0.0-alpha.1 -m "Release version 1.0.0-alpha.1"
   ```

2. **Push the Tag**: Push the tag to the `origin` remote.
   ```bash
   git push origin v1.0.0
   ```

3. **Automated Release**: Pushing the tag triggers the `release.yml` GitHub Actions workflow, which will:
    - Build and test the code.
    - Pack the NuGet packages with the version from the tag.
    - Create a GitHub Release.
    - Upload the NuGet packages as assets to the release.
    - Publish the packages to NuGet.org.

## Best Practices

### Commit Messages
Use a conventional commit format to maintain a clean and understandable commit history. This helps in tracking changes and understanding the impact of different commits.
```bash
feat: add new validation method
fix: resolve null reference exception
docs: update API documentation
chore: update dependencies
```

### Version Management
- The version for a release is determined by the Git tag.
- The `release.yml` workflow uses the tag name as the single source of truth for the version number.
- Ensure tags are unique and follow the `vMAJOR.MINOR.PATCH` format.

## Tools Used

- **GitHub Actions**: For the CI/CD and release pipeline.
- **NuGet**: For package publishing.

## References

- [Semantic Versioning](https://semver.org/)
- [Conventional Commits](https://www.conventionalcommits.org/)
