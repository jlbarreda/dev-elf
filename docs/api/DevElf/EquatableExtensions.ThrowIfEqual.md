#### [DevElf](README.md 'README')
### [DevElf\.ArgumentValidation](DevElf.ArgumentValidation.md 'DevElf\.ArgumentValidation').[EquatableExtensions](EquatableExtensions.md 'DevElf\.ArgumentValidation\.EquatableExtensions')

## EquatableExtensions\.ThrowIfEqual Method

| Overloads | |
| :--- | :--- |
| [ThrowIfEqual&lt;T&gt;\(this Nullable&lt;T&gt;, Nullable&lt;T&gt;, string\)](EquatableExtensions.ThrowIfEqual.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,System.Nullable_T_,string) 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this System\.Nullable\<T\>, System\.Nullable\<T\>, string\)') | Throws an [System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException') if the specified [value](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,System.Nullable_T_,string).value 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this System\.Nullable\<T\>, System\.Nullable\<T\>, string\)\.value') is equal to [other](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,System.Nullable_T_,string).other 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this System\.Nullable\<T\>, System\.Nullable\<T\>, string\)\.other')\. |
| [ThrowIfEqual&lt;T&gt;\(this Nullable&lt;T&gt;, T, string\)](EquatableExtensions.ThrowIfEqual.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,T,string) 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this System\.Nullable\<T\>, T, string\)') | Throws an [System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException') if the specified [value](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,T,string).value 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this System\.Nullable\<T\>, T, string\)\.value') is equal to [other](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,T,string).other 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this System\.Nullable\<T\>, T, string\)\.other')\. |
| [ThrowIfEqual&lt;T&gt;\(this T, Nullable&lt;T&gt;, string\)](EquatableExtensions.ThrowIfEqual.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,System.Nullable_T_,string) 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this T, System\.Nullable\<T\>, string\)') | Throws an [System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException') if the specified [value](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,System.Nullable_T_,string).value 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this T, System\.Nullable\<T\>, string\)\.value') is equal to [other](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,System.Nullable_T_,string).other 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this T, System\.Nullable\<T\>, string\)\.other')\. |
| [ThrowIfEqual&lt;T&gt;\(this T, T, string\)](EquatableExtensions.ThrowIfEqual.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,T,string) 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this T, T, string\)') | Throws an [System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException') if the specified [value](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,T,string).value 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this T, T, string\)\.value') is equal to [other](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,T,string).other 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this T, T, string\)\.other')\. |

<a name='DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,System.Nullable_T_,string)'></a>

## EquatableExtensions\.ThrowIfEqual\<T\>\(this Nullable\<T\>, Nullable\<T\>, string\) Method

Throws an [System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException') if the specified [value](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,System.Nullable_T_,string).value 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this System\.Nullable\<T\>, System\.Nullable\<T\>, string\)\.value') is
equal to [other](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,System.Nullable_T_,string).other 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this System\.Nullable\<T\>, System\.Nullable\<T\>, string\)\.other')\.

```csharp
public static void ThrowIfEqual<T>(this System.Nullable<T> value, System.Nullable<T> other, string parameterName=null)
    where T : struct, System.IEquatable<T>, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,System.Nullable_T_,string).T'></a>

`T`

The type of the objects to compare\.
#### Parameters

<a name='DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,System.Nullable_T_,string).value'></a>

`value` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[T](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,System.Nullable_T_,string).T 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this System\.Nullable\<T\>, System\.Nullable\<T\>, string\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The value to check\.

<a name='DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,System.Nullable_T_,string).other'></a>

`other` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[T](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,System.Nullable_T_,string).T 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this System\.Nullable\<T\>, System\.Nullable\<T\>, string\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The value to compare against\.

<a name='DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,System.Nullable_T_,string).parameterName'></a>

`parameterName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter being checked\.

#### Exceptions

[System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException')  
Thrown when [value](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,System.Nullable_T_,string).value 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this System\.Nullable\<T\>, System\.Nullable\<T\>, string\)\.value') is equal to [other](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,System.Nullable_T_,string).other 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this System\.Nullable\<T\>, System\.Nullable\<T\>, string\)\.other')\.

<a name='DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,T,string)'></a>

## EquatableExtensions\.ThrowIfEqual\<T\>\(this Nullable\<T\>, T, string\) Method

Throws an [System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException') if the specified [value](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,T,string).value 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this System\.Nullable\<T\>, T, string\)\.value') is
equal to [other](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,T,string).other 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this System\.Nullable\<T\>, T, string\)\.other')\.

```csharp
public static void ThrowIfEqual<T>(this System.Nullable<T> value, T other, string parameterName=null)
    where T : struct, System.IEquatable<T>, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,T,string).T'></a>

`T`

The type of the objects to compare\.
#### Parameters

<a name='DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,T,string).value'></a>

`value` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[T](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,T,string).T 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this System\.Nullable\<T\>, T, string\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The value to check\.

<a name='DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,T,string).other'></a>

`other` [T](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,T,string).T 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this System\.Nullable\<T\>, T, string\)\.T')

The value to compare against\.

<a name='DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,T,string).parameterName'></a>

`parameterName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter being checked\.

#### Exceptions

[System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException')  
Thrown when [value](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,T,string).value 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this System\.Nullable\<T\>, T, string\)\.value') is equal to [other](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisSystem.Nullable_T_,T,string).other 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this System\.Nullable\<T\>, T, string\)\.other')\.

<a name='DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,System.Nullable_T_,string)'></a>

## EquatableExtensions\.ThrowIfEqual\<T\>\(this T, Nullable\<T\>, string\) Method

Throws an [System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException') if the specified [value](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,System.Nullable_T_,string).value 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this T, System\.Nullable\<T\>, string\)\.value') is
equal to [other](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,System.Nullable_T_,string).other 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this T, System\.Nullable\<T\>, string\)\.other')\.

```csharp
public static void ThrowIfEqual<T>(this T value, System.Nullable<T> other, string parameterName=null)
    where T : struct, System.IEquatable<T>, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,System.Nullable_T_,string).T'></a>

`T`

The type of the objects to compare\.
#### Parameters

<a name='DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,System.Nullable_T_,string).value'></a>

`value` [T](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,System.Nullable_T_,string).T 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this T, System\.Nullable\<T\>, string\)\.T')

The value to check\.

<a name='DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,System.Nullable_T_,string).other'></a>

`other` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[T](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,System.Nullable_T_,string).T 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this T, System\.Nullable\<T\>, string\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The value to compare against\.

<a name='DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,System.Nullable_T_,string).parameterName'></a>

`parameterName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter being checked\.

#### Exceptions

[System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException')  
Thrown when [value](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,System.Nullable_T_,string).value 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this T, System\.Nullable\<T\>, string\)\.value') is equal to [other](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,System.Nullable_T_,string).other 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this T, System\.Nullable\<T\>, string\)\.other')\.

<a name='DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,T,string)'></a>

## EquatableExtensions\.ThrowIfEqual\<T\>\(this T, T, string\) Method

Throws an [System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException') if the specified [value](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,T,string).value 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this T, T, string\)\.value') is
equal to [other](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,T,string).other 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this T, T, string\)\.other')\.

```csharp
public static void ThrowIfEqual<T>(this T? value, T? other, string parameterName=null)
    where T : System.IEquatable<T>;
```
#### Type parameters

<a name='DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,T,string).T'></a>

`T`

The type of the objects to compare\.
#### Parameters

<a name='DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,T,string).value'></a>

`value` [T](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,T,string).T 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this T, T, string\)\.T')

The value to check\.

<a name='DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,T,string).other'></a>

`other` [T](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,T,string).T 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this T, T, string\)\.T')

The value to compare against\.

<a name='DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,T,string).parameterName'></a>

`parameterName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter being checked\.

#### Exceptions

[System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException')  
Thrown when [value](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,T,string).value 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this T, T, string\)\.value') is equal to [other](EquatableExtensions.md#DevElf.ArgumentValidation.EquatableExtensions.ThrowIfEqual_T_(thisT,T,string).other 'DevElf\.ArgumentValidation\.EquatableExtensions\.ThrowIfEqual\<T\>\(this T, T, string\)\.other')\.