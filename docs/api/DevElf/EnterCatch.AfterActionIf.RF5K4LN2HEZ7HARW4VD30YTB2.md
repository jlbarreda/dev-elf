#### [DevElf](README.md 'README')
### [DevElf](DevElf.md 'DevElf').[EnterCatch](EnterCatch.md 'DevElf\.EnterCatch')

## EnterCatch\.AfterActionIf\(Action, Func\<bool\>\) Method

Executes an action and then evaluates a condition to determine whether the
catch block should be entered\.

```csharp
public static bool AfterActionIf(System.Action action, System.Func<bool> condition);
```
#### Parameters

<a name='DevElf.EnterCatch.AfterActionIf(System.Action,System.Func_bool_).action'></a>

`action` [System\.Action](https://learn.microsoft.com/en-us/dotnet/api/system.action 'System\.Action')

The action to execute in the filter condition\.

<a name='DevElf.EnterCatch.AfterActionIf(System.Action,System.Func_bool_).condition'></a>

`condition` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')

The function that determines whether to enter the catch block\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
The result of evaluating [condition](EnterCatch.AfterActionIf.RF5K4LN2HEZ7HARW4VD30YTB2.md#DevElf.EnterCatch.AfterActionIf(System.Action,System.Func_bool_).condition 'DevElf\.EnterCatch\.AfterActionIf\(System\.Action, System\.Func\<bool\>\)\.condition'), which determines
whether the catch block is entered\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
If [action](EnterCatch.AfterActionIf.RF5K4LN2HEZ7HARW4VD30YTB2.md#DevElf.EnterCatch.AfterActionIf(System.Action,System.Func_bool_).action 'DevElf\.EnterCatch\.AfterActionIf\(System\.Action, System\.Func\<bool\>\)\.action') or [condition](EnterCatch.AfterActionIf.RF5K4LN2HEZ7HARW4VD30YTB2.md#DevElf.EnterCatch.AfterActionIf(System.Action,System.Func_bool_).condition 'DevElf\.EnterCatch\.AfterActionIf\(System\.Action, System\.Func\<bool\>\)\.condition') is
[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

### Example

```csharp
try
{
    // Code that might throw
}
catch (Exception ex) when (EnterCatch.AfterActionIf(
    () => logger.LogError(ex),
    () => retryCount < maxRetries))
{
    // Only handle if retryCount is less than maxRetries
    retryCount++;
}
```

### Remarks
This method allows you to execute an action \(such as logging\) and then
conditionally decide whether to handle the exception based on runtime
conditions\.