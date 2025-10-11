#### [DevElf](README.md 'README')
### [DevElf](DevElf.md 'DevElf').[EnterCatch](EnterCatch.md 'DevElf\.EnterCatch')

## EnterCatch\.Never\(Action\) Method

Executes an action and always returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), preventing
the catch block from being entered\.

```csharp
public static bool Never(System.Action action);
```
#### Parameters

<a name='DevElf.EnterCatch.Never(System.Action).action'></a>

`action` [System\.Action](https://learn.microsoft.com/en-us/dotnet/api/system.action 'System\.Action')

The action to execute in the filter condition\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
Always returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), causing the exception to continue
propagating\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
If [action](EnterCatch.Never.TDCCB41YVHYEQW8AZPJI45OC5.md#DevElf.EnterCatch.Never(System.Action).action 'DevElf\.EnterCatch\.Never\(System\.Action\)\.action') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

### Example

```csharp
try
{
    // Code that might throw
}
catch (Exception ex) when (EnterCatch.Never(() => logger.LogWarning(ex)))
{
    // This block will never execute
}
```

### Remarks
This method is useful when you want to perform an action \(such as logging\)
in the exception filter but do not want to handle the exception\. The
exception will continue to propagate up the call stack\.