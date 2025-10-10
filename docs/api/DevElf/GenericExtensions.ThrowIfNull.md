#### [DevElf](README.md 'README')
### [DevElf\.ArgumentValidation](DevElf.ArgumentValidation.md 'DevElf\.ArgumentValidation').[GenericExtensions](GenericExtensions.md 'DevElf\.ArgumentValidation\.GenericExtensions')

## GenericExtensions\.ThrowIfNull Method

| Overloads | |
| :--- | :--- |
| [ThrowIfNull&lt;T&gt;\(this Nullable&lt;T&gt;, string\)](GenericExtensions.ThrowIfNull.md#DevElf.ArgumentValidation.GenericExtensions.ThrowIfNull_T_(thisSystem.Nullable_T_,string) 'DevElf\.ArgumentValidation\.GenericExtensions\.ThrowIfNull\<T\>\(this System\.Nullable\<T\>, string\)') | Throws an [System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException') when [argument](GenericExtensions.md#DevElf.ArgumentValidation.GenericExtensions.ThrowIfNull_T_(thisSystem.Nullable_T_,string).argument 'DevElf\.ArgumentValidation\.GenericExtensions\.ThrowIfNull\<T\>\(this System\.Nullable\<T\>, string\)\.argument') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\. Applies to nullable value types\. |
| [ThrowIfNull&lt;T&gt;\(this T, string\)](GenericExtensions.ThrowIfNull.md#DevElf.ArgumentValidation.GenericExtensions.ThrowIfNull_T_(thisT,string) 'DevElf\.ArgumentValidation\.GenericExtensions\.ThrowIfNull\<T\>\(this T, string\)') | Throws an [System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException') when [argument](GenericExtensions.md#DevElf.ArgumentValidation.GenericExtensions.ThrowIfNull_T_(thisT,string).argument 'DevElf\.ArgumentValidation\.GenericExtensions\.ThrowIfNull\<T\>\(this T, string\)\.argument') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\. Applies to reference types\. |

<a name='DevElf.ArgumentValidation.GenericExtensions.ThrowIfNull_T_(thisSystem.Nullable_T_,string)'></a>

## GenericExtensions\.ThrowIfNull\<T\>\(this Nullable\<T\>, string\) Method

Throws an [System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException') when [argument](GenericExtensions.md#DevElf.ArgumentValidation.GenericExtensions.ThrowIfNull_T_(thisSystem.Nullable_T_,string).argument 'DevElf\.ArgumentValidation\.GenericExtensions\.ThrowIfNull\<T\>\(this System\.Nullable\<T\>, string\)\.argument') is
[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\. Applies to nullable value types\.

```csharp
public static void ThrowIfNull<T>(this System.Nullable<T> argument, string parameterName=null)
    where T : struct, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='DevElf.ArgumentValidation.GenericExtensions.ThrowIfNull_T_(thisSystem.Nullable_T_,string).T'></a>

`T`

The value type of the argument to validate\.
#### Parameters

<a name='DevElf.ArgumentValidation.GenericExtensions.ThrowIfNull_T_(thisSystem.Nullable_T_,string).argument'></a>

`argument` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[T](GenericExtensions.md#DevElf.ArgumentValidation.GenericExtensions.ThrowIfNull_T_(thisSystem.Nullable_T_,string).T 'DevElf\.ArgumentValidation\.GenericExtensions\.ThrowIfNull\<T\>\(this System\.Nullable\<T\>, string\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The argument to validate\.

<a name='DevElf.ArgumentValidation.GenericExtensions.ThrowIfNull_T_(thisSystem.Nullable_T_,string).parameterName'></a>

`parameterName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\. This is supplied automatically by the compiler when the method
is used as an extension method because of the [System\.Runtime\.CompilerServices\.CallerArgumentExpressionAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.callerargumentexpressionattribute 'System\.Runtime\.CompilerServices\.CallerArgumentExpressionAttribute')
on this parameter\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
Thrown when [argument](GenericExtensions.md#DevElf.ArgumentValidation.GenericExtensions.ThrowIfNull_T_(thisSystem.Nullable_T_,string).argument 'DevElf\.ArgumentValidation\.GenericExtensions\.ThrowIfNull\<T\>\(this System\.Nullable\<T\>, string\)\.argument') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DevElf.ArgumentValidation.GenericExtensions.ThrowIfNull_T_(thisT,string)'></a>

## GenericExtensions\.ThrowIfNull\<T\>\(this T, string\) Method

Throws an [System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException') when [argument](GenericExtensions.md#DevElf.ArgumentValidation.GenericExtensions.ThrowIfNull_T_(thisT,string).argument 'DevElf\.ArgumentValidation\.GenericExtensions\.ThrowIfNull\<T\>\(this T, string\)\.argument') is
[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\. Applies to reference types\.

```csharp
public static void ThrowIfNull<T>(this T? argument, string parameterName=null)
    where T : class;
```
#### Type parameters

<a name='DevElf.ArgumentValidation.GenericExtensions.ThrowIfNull_T_(thisT,string).T'></a>

`T`

The reference type of the argument to validate\.
#### Parameters

<a name='DevElf.ArgumentValidation.GenericExtensions.ThrowIfNull_T_(thisT,string).argument'></a>

`argument` [T](GenericExtensions.md#DevElf.ArgumentValidation.GenericExtensions.ThrowIfNull_T_(thisT,string).T 'DevElf\.ArgumentValidation\.GenericExtensions\.ThrowIfNull\<T\>\(this T, string\)\.T')

The argument to validate\.

<a name='DevElf.ArgumentValidation.GenericExtensions.ThrowIfNull_T_(thisT,string).parameterName'></a>

`parameterName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\. This is supplied automatically by the compiler when the method
is used as an extension method because of the [System\.Runtime\.CompilerServices\.CallerArgumentExpressionAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.callerargumentexpressionattribute 'System\.Runtime\.CompilerServices\.CallerArgumentExpressionAttribute')
on this parameter\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
Thrown when [argument](GenericExtensions.md#DevElf.ArgumentValidation.GenericExtensions.ThrowIfNull_T_(thisT,string).argument 'DevElf\.ArgumentValidation\.GenericExtensions\.ThrowIfNull\<T\>\(this T, string\)\.argument') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.