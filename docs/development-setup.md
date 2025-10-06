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

### 2. Restore Dependencies
```bash
dotnet restore
```

### 3. Build the Project
```bash
dotnet build
```

### 4. Run Tests
```bash
dotnet test
```

## Development Workflow

### Making Changes
1. Create a feature branch: `git checkout -b feature/your-feature-name`
2. Make your changes.
3. Write tests for new functionality.
4. Commit with a descriptive message. Using the [conventional commit format](https://www.conventionalcommits.org/) is recommended for a clean history.
   ```bash
   git commit -m "feat: add new validation method"
   ```

### Creating Pull Requests
1. Push your feature branch to the remote repository.
2. Create a pull request targeting the `main` branch.
3. The CI/CD pipeline will automatically run tests and security scans.
4. Once the PR is reviewed and approved, it can be merged into `main`.

## Versioning

This project follows a manual release process based on Git tags. For more details, please see the [Versioning Guide](versioning-guide.md).

## Testing

### Running Tests
```bash
# Run all tests
dotnet test

# Run tests for a specific project
dotnet test tests/DevElf.Tests

# Run tests with code coverage
dotnet test --collect:"XPlat Code Coverage"
```

### Test Structure
- `tests/DevElf.Tests` - Tests for the core DevElf library.
- `tests/DevElf.Logging.Tests` - Tests for the DevElf.Logging library.
- `benchmarks/DevElf.Benchmarks` - Performance benchmarks.

## Building and Packaging

### Build
```bash
# Build all projects
dotnet build

# Build in Release mode
dotnet build --configuration Release
```

### Pack NuGet Packages
To create NuGet packages locally for testing:
```bash
# Pack all projects
dotnet pack --configuration Release --output ./nupkg
```

## CI/CD Pipeline

### Automated Checks
The CI/CD pipeline runs on:
- All pull requests to `main`.
- Pushes to the `main` branch.
- A daily schedule for security scans.

### Checks Include
- Code formatting validation.
- Build verification.
- Test execution.
- Security scanning with CodeQL.
- A security audit for vulnerable packages.

## Release Process

Releases are handled manually by creating and pushing a Git tag. Refer to the [Versioning Guide](versioning-guide.md) for detailed instructions on how to create a release.

## Development Tips

### Code Style
- Follow the existing code style.
- Use meaningful variable names.
- Add XML documentation for all public APIs.
- Write unit tests for new functionality.

### Branch Naming
Use descriptive branch names to clearly indicate the purpose of the branch:
- `feature/add-validation-methods`
- `fix/resolve-null-reference`
- `docs/update-api-documentation`

## Getting Help

- Check the [Versioning Guide](versioning-guide.md).
- Review existing issues on GitHub.
- Ask questions in the project's discussions.
- Check CI/CD pipeline logs for build issues.

## Useful Commands

```bash
# Check for outdated packages
dotnet list package --outdated

# Check for vulnerabilities
dotnet list package --vulnerable

# Format code
dotnet format

# Run benchmarks
dotnet run --project benchmarks/DevElf.Benchmarks
```
