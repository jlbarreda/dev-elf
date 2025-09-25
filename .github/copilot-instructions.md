# GitHub Copilot Repository Instructions

## General Formatting Preferences
- Use UTF-8 encoding for all files.
- Use spaces for indentation (size 4) unless overridden.
- Use CRLF line endings by default.
- Trim trailing whitespace and ensure files end with exactly one empty line.

## General Conventions
- Use consistent naming conventions and severity levels for analyzers.
- Follow .NET and StyleCop guidelines.
- Avoid unnecessary code; prefer simplified expressions.
- Maintain consistent spacing, indentation, and brace styles.
- Use PascalCase for types and members; camelCase for locals and parameters.
- Prefer language keywords over framework type names.
- Use accessibility modifiers consistently.
- Use expression-bodied members and pattern matching.
- Use object and collection initializers.
- Use inferred names and auto-properties.
- Use conditional expressions and compound assignments.
- Use null propagation and coalesce expressions.
- Use top-level statements and file-scoped namespaces.
- Maintain consistent formatting for newlines, spacing, and wrapping.
- Maintain consistent ordering of elements and modifiers.
- Use documentation comments with summaries and parameter descriptions.
- Use consistent naming rules for interfaces, type parameters, and fields.
- Use static local functions and simplified `new` expressions.

---

## C# Style Preferences
- Never add more than one class/interface/enum/struct per file.
- Use PascalCase for public constants and static readonly fields.
- Use camelCase with and underscore prefix for private fields and local variables.
- Prefix interfaces with `I` and type parameters with `T`.
- Use explicit types for built-in types (`string`, `int`, `bool`, etc.)
- Use `var` for complex types when the type is obvious from the right side
- Use `var` for anonymous types and LINQ queries
- Prefer expression-bodied members, pattern matching, and switch expressions.
- Use object and collection initializers.
- Use inferred tuple and anonymous type member names.
- Use auto-properties and simplified boolean expressions.
- Use coalesce and null propagation expressions.
- Use simplified interpolation and conditional expressions.
- Use index and range operators.
- Use top-level statements and UTF-8 string literals.
- Use file-scoped namespaces and place `using` directives outside the namespace.
- Always use braces for control blocks.
- Maintain consistent spacing and indentation.
- Use trailing commas in multi-line initializers.
- Add documentation comments for public members.
- Maintain consistent ordering of modifiers and members.
- Use simplified `new` expressions when type is apparent.
- Prefer `nameof` over `typeof` where applicable.
- Use tuple swap syntax for swapping values.
- Use static local functions where possible.
- Add an empty line before `return`, `throw`, `break`, `yield`, and `continue`.
- Place a blank line between method declarations.
- Avoid multiple statements on a single line.
- Align parameters and arguments vertically with one level of indentation.
- Prefer multiline `if` statements over single-line ones.
- Use consistent spacing around operators.
- Use a single space after `//` in comments.
- Use discard `_` to comply with IDE0058.
- Don't add unnecessary using statements.
- Always add an empty line between lines of code and statement blocks.

### Documentation Preferences
- Use XML documentation comments for public members.
- Keep the XML documentation comment lines length under 100 characters.
- Don't modify auto-generated files (all files inside the ".\docs\api\" folder are auto-generated).

### Best Practices
- Use static classes for shared constants.
- Use enums for fixed sets of related values.
- Use `private const` or `private static readonly` for scoped constants.
- Use `static readonly` for runtime or non-primitive values.
- Organize constants by domain in logical namespaces.
- Avoid magic strings and numbers; use named constants.
- Prefer meaningful names over abbreviations.
- Avoid deeply nested control structures; refactor into smaller methods.
- Use early returns to reduce nesting.
- Keep methods short and focused.
- Use `readonly` for fields not reassigned.
- Prefer `TryParse` over `Parse`.
- Use `StringBuilder` for string concatenation in loops.
- Always check for `null` before accessing members.
- Use `using` or `await using` for disposable resources.
- Avoid catching general exceptions; be specific.
- Use dependency injection for testability.
- Avoid static dependencies in testable components.
- Prefer `TimeProvider` over `DateTime`, `DateTimeOffset`, and `Stopwatch`.
- Use `Task.Delay` (and any other time related method) overloads with `TimeProvider`.
- Prefer `TimeSpan` over raw time units.
- Fix all compiler warnings.
- Use existing code as reference.
- Keep it simple.

### Avoid
- `dynamic`
- `unsafe`

---

## JSON Formatting Preferences
- Use 2 spaces for indentation.
- Use UTF-8 encoding.
- Trim trailing whitespace.
- Insert final newline.

---

## YAML Formatting Preferences
- Use 2 spaces for indentation.
- Use UTF-8 encoding.
- Trim trailing whitespace.
- Insert final newline.

---

## Markdown Formatting Preferences
- Do not trim trailing whitespace.
- Use UTF-8 encoding.
- Insert final newline.

---

## Testing Guidelines
- Never add more than one class/interface/enum/struct per file.
- Use MSTest with `AutoFixture` and `NSubstitute` when they are needed.
- Use `AwesomeAssertions` for assertions.
- Create a new `Fixture` instance in each test method when test data generation is needed.
- Use `AutoNSubstituteCustomization` for auto-mocking when mocking dependencies.
- Use `fixture.Freeze` or `fixture.Inject` for dependencies.
- Add `// Arrange`, `// Act`, and `// Assert` comments to structure tests.
- Start comments other than `// Arrange`, `// Act`, and `// Assert` with lowercase.
- Name test methods using: `MethodName_expected_behavior_when_condition`.
- Use `snake_case` in test method names except for `MethodName`.
- Use `sut` for the system under test, except for delegates. When using a delegate to execute the code under test, it should be named `act`.
- Use `act` for delegates that execute the code under test. 
- Place test classes in a project named after the source project with `.Tests` suffix.
- Match the folder structure of the source file.
- Name the test file after the source file, appending `Tests`.
- Never use TestCleanup, ClassCleanup, AssemblyCleanup, TestInitialize, ClassInitialize, or AssemblyInitialize methods.
- Don't use shared state between tests.
- Ensure tests don't give false positives or negatives.
- Avoid pointless tests.
- Don't test property getters and setters.
- Don't test objects that only have properties (DTOs).
- Use `<see langword=""/>` for language keywords in XML comments (e.g. `<see langword="true"/>`, `<see langword="false"/>`).

---

## Rule Precedence
1. Compilation and functionality first.
2. Analyzer and compiler warnings.
3. .editorconfig rules.
4. Repository-specific conventions (this file).
5. .NET Best Practices.
6. General best practices.

---

## **Tool-Specific Guidance**
- When in doubt about rule conflicts, ask for clarification.
- When in doubt, ask for clarification.
- Apply rules consistently across all files in a change set.
- Don't modify any auto-generated files.
- The solution file has an slnx extension.
