#### [DevElf](README.md 'README')
### [DevElf](DevElf.md 'DevElf')

## EnterCatch Class

Provides helper methods for executing actions in catch block filter conditions\.
Allows running actions \(such as logging\) while preserving the original exception
context and controlling whether to enter the catch block\.

```csharp
public static class EnterCatch
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; EnterCatch

### Example

```csharp
try
{
    // Code that might throw
}
catch (Exception ex) when (EnterCatch.AfterAction(() => logger.LogError(ex)))
{
    // Handle exception with full context preserved
}
```

### Remarks

These methods are designed to be used in catch block `when` clauses to
execute side-effect actions (typically logging) at the point where the exception
occurs, before the stack unwinds further. The return value determines whether
the catch block should be entered.

<strong>Important:</strong> These methods do not work well with async code.
            When an exception is thrown in an async method, it is caught by the async
            state machine and re-thrown at the point of the `await`. This causes
            the exception filter to run at the await location rather than where the
            exception was originally thrown, losing the original exception context and
            stack trace information that these methods are designed to preserve.

This implementation is based on the concept described by Stephen Cleary in
"A New Pattern for Exception Logging":
https://blog.stephencleary.com/2020/06/a-new-pattern-for-exception-logging.html

| Methods | |
| :--- | :--- |
| [AfterAction\(Action\)](EnterCatch.AfterAction.BJVVNWQM01735O03T92W9JJ32.md 'DevElf\.EnterCatch\.AfterAction\(System\.Action\)') | Executes an action and always returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), causing the catch block to be entered\. |
| [AfterActionIf\(Action, Func&lt;bool&gt;\)](EnterCatch.AfterActionIf.RF5K4LN2HEZ7HARW4VD30YTB2.md 'DevElf\.EnterCatch\.AfterActionIf\(System\.Action, System\.Func\<bool\>\)') | Executes an action and then evaluates a condition to determine whether the catch block should be entered\. |
| [Never\(Action\)](EnterCatch.Never.TDCCB41YVHYEQW8AZPJI45OC5.md 'DevElf\.EnterCatch\.Never\(System\.Action\)') | Executes an action and always returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), preventing the catch block from being entered\. |
