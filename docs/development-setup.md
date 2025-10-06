# Development Setup

This guide helps new developers set up the DevElf project for development.

## Prerequisites

- .NET SDK 10.0 or later
- Git
- Visual Studio 2022 or VS Code (recommended)

## Initial Setup

### 1. Clone the Repository
```bash
git clone https://github.com/jlbarreda/dev-elf.git
cd dev-elf
```

### 2. Install .NET Tools
```bash
dotnet tool restore
```

This installs the required tools:
- `versionize` (v2.3.1) - For automatic versioning
- `husky` (v0.7.2) - For git hooks

### 3. Install Git Hooks
```bash
dotnet husky install
```

### 4. Restore Dependencies
```bash
dotnet restore
```

### 5. Build the Project
```bash
dotnet build
```

### 6. Run Tests
```bash
dotnet test
```

## Development Workflow

### Making Changes
1. Create a feature branch: `git checkout -b feature/your-feature-name`
2. Make your changes
3. Write tests for new functionality
4. Commit with conventional commit format:
   ```bash
   git commit -m "feat: add new validation method"
   ```

### Pushing Changes
1. Push your changes: `git push origin feature/your-feature-name`
2. The pre-push hook will automatically run `dotnet versionize`
3. If versioning is needed, new commits and tags will be created
4. All changes will be pushed together

### Creating Pull Requests
1. Push your feature branch
2. Create a pull request to `main` branch
3. The CI/CD pipeline will run tests and security scans
4. Review and merge when ready

## Versioning

### Automatic Versioning
The project uses automatic versioning based on conventional commits:

- `feat:` - New features (minor version bump)
- `fix:` - Bug fixes (patch version bump)
- `BREAKING CHANGE:` - Breaking changes (major version bump)

### Pre-push Hooks
Husky pre-push hooks ensure versioning happens automatically:
- Runs `dotnet versionize` before every push
- Analyzes commits since last version
- Updates version and changelog
- Creates git tags

### Manual Versioning
If you need to manually trigger versioning:
```bash
dotnet versionize
```

## Testing

### Running Tests
```bash
# Run all tests
dotnet test

# Run tests for specific project
dotnet test tests/DevElf.Tests

# Run tests with coverage
dotnet test --collect:"XPlat Code Coverage"
```

### Test Structure
- `tests/DevElf.Tests` - Tests for core DevElf library
- `tests/DevElf.Logging.Tests` - Tests for DevElf.Logging library
- `tests/DevElf.Benchmarks` - Performance benchmarks

## Building and Packaging

### Build
```bash
# Build all projects
dotnet build

# Build in Release mode
dotnet build --configuration Release
```

### Pack NuGet Packages
```bash
# Pack all projects
dotnet pack --configuration Release --output ./nupkg
```

## CI/CD Pipeline

### Automated Checks
The CI/CD pipeline runs on:
- All pull requests
- Pushes to `main` branch
- Daily security scans

### Checks Include
- Code formatting validation
- Build verification
- Test execution
- Security scanning (CodeQL)
- Package vulnerability checks
- Outdated package detection

## Release Process

### Alpha Releases
Alpha releases are automatic:
1. Make changes with conventional commits
2. Push to main branch
3. Pre-push hook runs versioning
4. CI/CD pipeline publishes packages

### Stable Releases
Stable releases are manual:
1. Create a stable release tag: `git tag v1.0.0`
2. Push the tag: `git push origin v1.0.0`
3. GitHub Actions handles the release

## Troubleshooting

### Common Issues

#### Pre-push Hook Failing
```bash
# Reinstall Husky
dotnet husky install

# Check if versionize is installed
dotnet tool list
```

#### Version Not Updating
- Check commit message format (use conventional commits)
- Verify versionize configuration
- Check git tags are properly formatted

#### Build Failures
```bash
# Clean and restore
dotnet clean
dotnet restore
dotnet build
```

#### Test Failures
```bash
# Run tests with verbose output
dotnet test --verbosity normal

# Check test results
dotnet test --logger trx --results-directory TestResults
```

## Development Tips

### Code Style
- Follow the existing code style
- Use meaningful variable names
- Add XML documentation for public APIs
- Write unit tests for new functionality

### Commit Messages
Use conventional commit format:
```bash
feat: add new validation method
fix: resolve null reference exception
docs: update API documentation
chore: update dependencies
```

### Branch Naming
Use descriptive branch names:
- `feature/add-validation-methods`
- `fix/resolve-null-reference`
- `docs/update-api-documentation`

## Getting Help

- Check the [versioning guide](versioning-guide.md)
- Review existing issues on GitHub
- Ask questions in discussions
- Check CI/CD pipeline logs for build issues

## Useful Commands

```bash
# Check current version
dotnet versionize inspect

# Run versionize manually
dotnet versionize

# Check outdated packages
dotnet list package --outdated

# Check for vulnerabilities
dotnet list package --vulnerable

# Format code
dotnet format

# Run benchmarks
dotnet run --project benchmarks/DevElf.Benchmarks
```
