#### [DevElf](README.md 'README')
### [DevElf\.Extensions](DevElf.Extensions.md 'DevElf\.Extensions')

## LambdaExtensions Class

Provides extension methods for delegates\.

```csharp
public static class LambdaExtensions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; LambdaExtensions

| Methods | |
| :--- | :--- |
| [UnwrapAndReThrow\(this Action\)](LambdaExtensions.UnwrapAndReThrow.md#DevElf.Extensions.LambdaExtensions.UnwrapAndReThrow(thisSystem.Action) 'DevElf\.Extensions\.LambdaExtensions\.UnwrapAndReThrow\(this System\.Action\)') | Wraps an [System\.Action](https://learn.microsoft.com/en-us/dotnet/api/system.action 'System\.Action') so that if it throws an exception that contains inner exceptions, the innermost exception is re\-thrown while preserving the original stack trace\. |
| [UnwrapAndReThrow&lt;T&gt;\(this Func&lt;T&gt;\)](LambdaExtensions.UnwrapAndReThrow.md#DevElf.Extensions.LambdaExtensions.UnwrapAndReThrow_T_(thisSystem.Func_T_) 'DevElf\.Extensions\.LambdaExtensions\.UnwrapAndReThrow\<T\>\(this System\.Func\<T\>\)') | Wraps a [System\.Func&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1') so that if it throws an exception that contains inner exceptions, the innermost exception is re\-thrown while preserving the original stack trace\. |
