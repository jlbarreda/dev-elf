#### [DevElf](README.md 'README')
### [DevElf](DevElf.md 'DevElf').[EnterCatch](EnterCatch.md 'DevElf\.EnterCatch')

## EnterCatch\.AfterAction\(Action\) Method

Executes an action and always returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), causing the
catch block to be entered\.

```csharp
public static bool AfterAction(System.Action action);
```
#### Parameters

<a name='DevElf.EnterCatch.AfterAction(System.Action).action'></a>

`action` [System\.Action](https://learn.microsoft.com/en-us/dotnet/api/system.action 'System\.Action')

The action to execute in the filter condition\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
Always returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), causing the catch block to be
entered\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
If [action](EnterCatch.AfterAction.BJVVNWQM01735O03T92W9JJ32.md#DevElf.EnterCatch.AfterAction(System.Action).action 'DevElf\.EnterCatch\.AfterAction\(System\.Action\)\.action') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

### Example

```csharp
try
{
    // Code that might throw
}
catch (Exception ex) when (EnterCatch.AfterAction(() => logger.LogError(ex)))
{
    // Handle the exception
    return fallbackValue;
}
```

### Remarks
This method allows you to execute an action \(such as logging\) in the
exception filter before entering the catch block, preserving the original
exception context\.