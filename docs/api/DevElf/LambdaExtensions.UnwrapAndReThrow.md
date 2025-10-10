#### [DevElf](README.md 'README')
### [DevElf\.Extensions](DevElf.Extensions.md 'DevElf\.Extensions').[LambdaExtensions](LambdaExtensions.md 'DevElf\.Extensions\.LambdaExtensions')

## LambdaExtensions\.UnwrapAndReThrow Method

| Overloads | |
| :--- | :--- |
| [UnwrapAndReThrow\(this Action\)](LambdaExtensions.UnwrapAndReThrow.md#DevElf.Extensions.LambdaExtensions.UnwrapAndReThrow(thisSystem.Action) 'DevElf\.Extensions\.LambdaExtensions\.UnwrapAndReThrow\(this System\.Action\)') | Wraps an [System\.Action](https://learn.microsoft.com/en-us/dotnet/api/system.action 'System\.Action') so that if it throws an exception that contains inner exceptions, the innermost exception is re\-thrown while preserving the original stack trace\. |
| [UnwrapAndReThrow&lt;T&gt;\(this Func&lt;T&gt;\)](LambdaExtensions.UnwrapAndReThrow.md#DevElf.Extensions.LambdaExtensions.UnwrapAndReThrow_T_(thisSystem.Func_T_) 'DevElf\.Extensions\.LambdaExtensions\.UnwrapAndReThrow\<T\>\(this System\.Func\<T\>\)') | Wraps a [System\.Func&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1') so that if it throws an exception that contains inner exceptions, the innermost exception is re\-thrown while preserving the original stack trace\. |

<a name='DevElf.Extensions.LambdaExtensions.UnwrapAndReThrow(thisSystem.Action)'></a>

## LambdaExtensions\.UnwrapAndReThrow\(this Action\) Method

Wraps an [System\.Action](https://learn.microsoft.com/en-us/dotnet/api/system.action 'System\.Action') so that if it throws an exception that contains
inner exceptions, the innermost exception is re\-thrown while preserving the
original stack trace\.

```csharp
public static System.Action UnwrapAndReThrow(this System.Action action);
```
#### Parameters

<a name='DevElf.Extensions.LambdaExtensions.UnwrapAndReThrow(thisSystem.Action).action'></a>

`action` [System\.Action](https://learn.microsoft.com/en-us/dotnet/api/system.action 'System\.Action')

The action to execute\.

#### Returns
[System\.Action](https://learn.microsoft.com/en-us/dotnet/api/system.action 'System\.Action')  
A new [System\.Action](https://learn.microsoft.com/en-us/dotnet/api/system.action 'System\.Action') that executes [action](LambdaExtensions.md#DevElf.Extensions.LambdaExtensions.UnwrapAndReThrow(thisSystem.Action).action 'DevElf\.Extensions\.LambdaExtensions\.UnwrapAndReThrow\(this System\.Action\)\.action') and, when an
exception occurs, re\-throws the innermost exception\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
Thrown when [action](LambdaExtensions.md#DevElf.Extensions.LambdaExtensions.UnwrapAndReThrow(thisSystem.Action).action 'DevElf\.Extensions\.LambdaExtensions\.UnwrapAndReThrow\(this System\.Action\)\.action') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DevElf.Extensions.LambdaExtensions.UnwrapAndReThrow_T_(thisSystem.Func_T_)'></a>

## LambdaExtensions\.UnwrapAndReThrow\<T\>\(this Func\<T\>\) Method

Wraps a [System\.Func&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1') so that if it throws an exception that
contains inner exceptions, the innermost exception is re\-thrown while preserving
the original stack trace\.

```csharp
public static System.Func<T> UnwrapAndReThrow<T>(this System.Func<T> function);
```
#### Type parameters

<a name='DevElf.Extensions.LambdaExtensions.UnwrapAndReThrow_T_(thisSystem.Func_T_).T'></a>

`T`

The result type of the function\.
#### Parameters

<a name='DevElf.Extensions.LambdaExtensions.UnwrapAndReThrow_T_(thisSystem.Func_T_).function'></a>

`function` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')[T](LambdaExtensions.md#DevElf.Extensions.LambdaExtensions.UnwrapAndReThrow_T_(thisSystem.Func_T_).T 'DevElf\.Extensions\.LambdaExtensions\.UnwrapAndReThrow\<T\>\(this System\.Func\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')

The function to execute\.

#### Returns
[System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')[T](LambdaExtensions.md#DevElf.Extensions.LambdaExtensions.UnwrapAndReThrow_T_(thisSystem.Func_T_).T 'DevElf\.Extensions\.LambdaExtensions\.UnwrapAndReThrow\<T\>\(this System\.Func\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')  
A new [System\.Func&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1') that executes [function](LambdaExtensions.md#DevElf.Extensions.LambdaExtensions.UnwrapAndReThrow_T_(thisSystem.Func_T_).function 'DevElf\.Extensions\.LambdaExtensions\.UnwrapAndReThrow\<T\>\(this System\.Func\<T\>\)\.function') and, when an
exception occurs, re\-throws the innermost exception\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
Thrown when [function](LambdaExtensions.md#DevElf.Extensions.LambdaExtensions.UnwrapAndReThrow_T_(thisSystem.Func_T_).function 'DevElf\.Extensions\.LambdaExtensions\.UnwrapAndReThrow\<T\>\(this System\.Func\<T\>\)\.function') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.