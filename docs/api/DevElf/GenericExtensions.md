#### [DevElf](README.md 'README')
### [DevElf\.ArgumentValidation](DevElf.ArgumentValidation.md 'DevElf\.ArgumentValidation')

## GenericExtensions Class

Provides argument validation helpers for reference types and nullable value types\.

```csharp
public static class GenericExtensions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; GenericExtensions

| Methods | |
| :--- | :--- |
| [ThrowIfNull&lt;T&gt;\(this Nullable&lt;T&gt;, string\)](GenericExtensions.ThrowIfNull.md#DevElf.ArgumentValidation.GenericExtensions.ThrowIfNull_T_(thisSystem.Nullable_T_,string) 'DevElf\.ArgumentValidation\.GenericExtensions\.ThrowIfNull\<T\>\(this System\.Nullable\<T\>, string\)') | Throws an [System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException') when [argument](GenericExtensions.md#DevElf.ArgumentValidation.GenericExtensions.ThrowIfNull_T_(thisSystem.Nullable_T_,string).argument 'DevElf\.ArgumentValidation\.GenericExtensions\.ThrowIfNull\<T\>\(this System\.Nullable\<T\>, string\)\.argument') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\. Applies to nullable value types\. |
| [ThrowIfNull&lt;T&gt;\(this T, string\)](GenericExtensions.ThrowIfNull.md#DevElf.ArgumentValidation.GenericExtensions.ThrowIfNull_T_(thisT,string) 'DevElf\.ArgumentValidation\.GenericExtensions\.ThrowIfNull\<T\>\(this T, string\)') | Throws an [System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException') when [argument](GenericExtensions.md#DevElf.ArgumentValidation.GenericExtensions.ThrowIfNull_T_(thisT,string).argument 'DevElf\.ArgumentValidation\.GenericExtensions\.ThrowIfNull\<T\>\(this T, string\)\.argument') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\. Applies to reference types\. |
