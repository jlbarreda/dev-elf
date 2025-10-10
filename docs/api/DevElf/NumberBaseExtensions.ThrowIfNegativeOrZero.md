#### [DevElf](README.md 'README')
### [DevElf\.ArgumentValidation](DevElf.ArgumentValidation.md 'DevElf\.ArgumentValidation').[NumberBaseExtensions](NumberBaseExtensions.md 'DevElf\.ArgumentValidation\.NumberBaseExtensions')

## NumberBaseExtensions\.ThrowIfNegativeOrZero Method

| Overloads | |
| :--- | :--- |
| [ThrowIfNegativeOrZero&lt;T&gt;\(this Nullable&lt;T&gt;, string\)](NumberBaseExtensions.ThrowIfNegativeOrZero.md#DevElf.ArgumentValidation.NumberBaseExtensions.ThrowIfNegativeOrZero_T_(thisSystem.Nullable_T_,string) 'DevElf\.ArgumentValidation\.NumberBaseExtensions\.ThrowIfNegativeOrZero\<T\>\(this System\.Nullable\<T\>, string\)') | Throws an [System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException') if the specified value is negative or zero\. |
| [ThrowIfNegativeOrZero&lt;T&gt;\(this T, string\)](NumberBaseExtensions.ThrowIfNegativeOrZero.md#DevElf.ArgumentValidation.NumberBaseExtensions.ThrowIfNegativeOrZero_T_(thisT,string) 'DevElf\.ArgumentValidation\.NumberBaseExtensions\.ThrowIfNegativeOrZero\<T\>\(this T, string\)') | Throws an [System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException') if the specified value is negative or zero\. |

<a name='DevElf.ArgumentValidation.NumberBaseExtensions.ThrowIfNegativeOrZero_T_(thisSystem.Nullable_T_,string)'></a>

## NumberBaseExtensions\.ThrowIfNegativeOrZero\<T\>\(this Nullable\<T\>, string\) Method

Throws an [System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException') if the specified value is negative or zero\.

```csharp
public static void ThrowIfNegativeOrZero<T>(this System.Nullable<T> value, string parameterName=null)
    where T : struct, System.Numerics.INumberBase<T>, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='DevElf.ArgumentValidation.NumberBaseExtensions.ThrowIfNegativeOrZero_T_(thisSystem.Nullable_T_,string).T'></a>

`T`

The type of the value to check, which must be a struct and implement [System\.Numerics\.INumberBase&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.inumberbase-1 'System\.Numerics\.INumberBase\`1')\.
#### Parameters

<a name='DevElf.ArgumentValidation.NumberBaseExtensions.ThrowIfNegativeOrZero_T_(thisSystem.Nullable_T_,string).value'></a>

`value` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[T](NumberBaseExtensions.md#DevElf.ArgumentValidation.NumberBaseExtensions.ThrowIfNegativeOrZero_T_(thisSystem.Nullable_T_,string).T 'DevElf\.ArgumentValidation\.NumberBaseExtensions\.ThrowIfNegativeOrZero\<T\>\(this System\.Nullable\<T\>, string\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The value to check\.

<a name='DevElf.ArgumentValidation.NumberBaseExtensions.ThrowIfNegativeOrZero_T_(thisSystem.Nullable_T_,string).parameterName'></a>

`parameterName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter being checked\. This is automatically captured from the expression
passed as the [value](NumberBaseExtensions.md#DevElf.ArgumentValidation.NumberBaseExtensions.ThrowIfNegativeOrZero_T_(thisSystem.Nullable_T_,string).value 'DevElf\.ArgumentValidation\.NumberBaseExtensions\.ThrowIfNegativeOrZero\<T\>\(this System\.Nullable\<T\>, string\)\.value')\.

#### Exceptions

[System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException')  
Thrown when the [value](NumberBaseExtensions.md#DevElf.ArgumentValidation.NumberBaseExtensions.ThrowIfNegativeOrZero_T_(thisSystem.Nullable_T_,string).value 'DevElf\.ArgumentValidation\.NumberBaseExtensions\.ThrowIfNegativeOrZero\<T\>\(this System\.Nullable\<T\>, string\)\.value') is negative or zero\.

<a name='DevElf.ArgumentValidation.NumberBaseExtensions.ThrowIfNegativeOrZero_T_(thisT,string)'></a>

## NumberBaseExtensions\.ThrowIfNegativeOrZero\<T\>\(this T, string\) Method

Throws an [System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException') if the specified value is negative or zero\.

```csharp
public static void ThrowIfNegativeOrZero<T>(this T? value, string parameterName=null)
    where T : System.Numerics.INumberBase<T>;
```
#### Type parameters

<a name='DevElf.ArgumentValidation.NumberBaseExtensions.ThrowIfNegativeOrZero_T_(thisT,string).T'></a>

`T`

The type of the value to check, which must implement [System\.Numerics\.INumberBase&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.inumberbase-1 'System\.Numerics\.INumberBase\`1')\.
#### Parameters

<a name='DevElf.ArgumentValidation.NumberBaseExtensions.ThrowIfNegativeOrZero_T_(thisT,string).value'></a>

`value` [T](NumberBaseExtensions.md#DevElf.ArgumentValidation.NumberBaseExtensions.ThrowIfNegativeOrZero_T_(thisT,string).T 'DevElf\.ArgumentValidation\.NumberBaseExtensions\.ThrowIfNegativeOrZero\<T\>\(this T, string\)\.T')

The value to check\.

<a name='DevElf.ArgumentValidation.NumberBaseExtensions.ThrowIfNegativeOrZero_T_(thisT,string).parameterName'></a>

`parameterName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter being checked\. This is automatically captured from the expression
passed as the [value](NumberBaseExtensions.md#DevElf.ArgumentValidation.NumberBaseExtensions.ThrowIfNegativeOrZero_T_(thisT,string).value 'DevElf\.ArgumentValidation\.NumberBaseExtensions\.ThrowIfNegativeOrZero\<T\>\(this T, string\)\.value')\.

#### Exceptions

[System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException')  
Thrown when the [value](NumberBaseExtensions.md#DevElf.ArgumentValidation.NumberBaseExtensions.ThrowIfNegativeOrZero_T_(thisT,string).value 'DevElf\.ArgumentValidation\.NumberBaseExtensions\.ThrowIfNegativeOrZero\<T\>\(this T, string\)\.value') is negative or zero\.