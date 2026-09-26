#### [DevElf](README.md 'README')
### [DevElf\.ArgumentValidation](DevElf.ArgumentValidation.md 'DevElf\.ArgumentValidation').[ComparableExtensions](ComparableExtensions.md 'DevElf\.ArgumentValidation\.ComparableExtensions')

## ComparableExtensions\.ThrowIfGreaterThan Method

| Overloads | |
| :--- | :--- |
| [ThrowIfGreaterThan&lt;T&gt;\(this Nullable&lt;T&gt;, Nullable&lt;T&gt;, string\)](ComparableExtensions.ThrowIfGreaterThan.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,System.Nullable_T_,string) 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this System\.Nullable\<T\>, System\.Nullable\<T\>, string\)') | Throws an [System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException') if [value](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,System.Nullable_T_,string).value 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this System\.Nullable\<T\>, System\.Nullable\<T\>, string\)\.value') is greater than [other](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,System.Nullable_T_,string).other 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this System\.Nullable\<T\>, System\.Nullable\<T\>, string\)\.other')\. |
| [ThrowIfGreaterThan&lt;T&gt;\(this Nullable&lt;T&gt;, T, string\)](ComparableExtensions.ThrowIfGreaterThan.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,T,string) 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this System\.Nullable\<T\>, T, string\)') | Throws an [System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException') if [value](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,T,string).value 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this System\.Nullable\<T\>, T, string\)\.value') is greater than [other](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,T,string).other 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this System\.Nullable\<T\>, T, string\)\.other')\. |
| [ThrowIfGreaterThan&lt;T&gt;\(this T, Nullable&lt;T&gt;, string\)](ComparableExtensions.ThrowIfGreaterThan.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,System.Nullable_T_,string) 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this T, System\.Nullable\<T\>, string\)') | Throws an [System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException') if [value](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,System.Nullable_T_,string).value 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this T, System\.Nullable\<T\>, string\)\.value') is greater than [other](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,System.Nullable_T_,string).other 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this T, System\.Nullable\<T\>, string\)\.other')\. |
| [ThrowIfGreaterThan&lt;T&gt;\(this T, T, string\)](ComparableExtensions.ThrowIfGreaterThan.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,T,string) 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this T, T, string\)') | Throws an [System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException') if [value](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,T,string).value 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this T, T, string\)\.value') is greater than [other](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,T,string).other 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this T, T, string\)\.other')\. |

<a name='DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,System.Nullable_T_,string)'></a>

## ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this Nullable\<T\>, Nullable\<T\>, string\) Method

Throws an [System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException') if [value](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,System.Nullable_T_,string).value 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this System\.Nullable\<T\>, System\.Nullable\<T\>, string\)\.value') is greater than [other](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,System.Nullable_T_,string).other 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this System\.Nullable\<T\>, System\.Nullable\<T\>, string\)\.other')\.

```csharp
public static void ThrowIfGreaterThan<T>(this System.Nullable<T> value, System.Nullable<T> other, string parameterName=null)
    where T : struct, System.IComparable<T>, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,System.Nullable_T_,string).T'></a>

`T`

The type of the arguments, which must implement [System\.IComparable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1 'System\.IComparable\`1')\.
#### Parameters

<a name='DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,System.Nullable_T_,string).value'></a>

`value` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[T](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,System.Nullable_T_,string).T 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this System\.Nullable\<T\>, System\.Nullable\<T\>, string\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The value to validate\.

<a name='DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,System.Nullable_T_,string).other'></a>

`other` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[T](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,System.Nullable_T_,string).T 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this System\.Nullable\<T\>, System\.Nullable\<T\>, string\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The value to compare against\.

<a name='DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,System.Nullable_T_,string).parameterName'></a>

`parameterName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the [value](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,System.Nullable_T_,string).value 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this System\.Nullable\<T\>, System\.Nullable\<T\>, string\)\.value') parameter \(automatically provided\)\.

#### Exceptions

[System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException')  
Thrown when [value](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,System.Nullable_T_,string).value 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this System\.Nullable\<T\>, System\.Nullable\<T\>, string\)\.value') is greater than [other](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,System.Nullable_T_,string).other 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this System\.Nullable\<T\>, System\.Nullable\<T\>, string\)\.other')\.

<a name='DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,T,string)'></a>

## ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this Nullable\<T\>, T, string\) Method

Throws an [System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException') if [value](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,T,string).value 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this System\.Nullable\<T\>, T, string\)\.value') is greater than [other](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,T,string).other 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this System\.Nullable\<T\>, T, string\)\.other')\.

```csharp
public static void ThrowIfGreaterThan<T>(this System.Nullable<T> value, T other, string parameterName=null)
    where T : struct, System.IComparable<T>, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,T,string).T'></a>

`T`

The type of the arguments, which must implement [System\.IComparable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1 'System\.IComparable\`1')\.
#### Parameters

<a name='DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,T,string).value'></a>

`value` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[T](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,T,string).T 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this System\.Nullable\<T\>, T, string\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The value to validate\.

<a name='DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,T,string).other'></a>

`other` [T](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,T,string).T 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this System\.Nullable\<T\>, T, string\)\.T')

The value to compare against\.

<a name='DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,T,string).parameterName'></a>

`parameterName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the [value](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,T,string).value 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this System\.Nullable\<T\>, T, string\)\.value') parameter \(automatically provided\)\.

#### Exceptions

[System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException')  
Thrown when [value](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,T,string).value 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this System\.Nullable\<T\>, T, string\)\.value') is greater than [other](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisSystem.Nullable_T_,T,string).other 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this System\.Nullable\<T\>, T, string\)\.other')\.

<a name='DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,System.Nullable_T_,string)'></a>

## ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this T, Nullable\<T\>, string\) Method

Throws an [System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException') if [value](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,System.Nullable_T_,string).value 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this T, System\.Nullable\<T\>, string\)\.value') is greater than [other](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,System.Nullable_T_,string).other 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this T, System\.Nullable\<T\>, string\)\.other')\.

```csharp
public static void ThrowIfGreaterThan<T>(this T value, System.Nullable<T> other, string parameterName=null)
    where T : struct, System.IComparable<T>, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,System.Nullable_T_,string).T'></a>

`T`

The type of the arguments, which must implement [System\.IComparable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1 'System\.IComparable\`1')\.
#### Parameters

<a name='DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,System.Nullable_T_,string).value'></a>

`value` [T](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,System.Nullable_T_,string).T 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this T, System\.Nullable\<T\>, string\)\.T')

The value to validate\.

<a name='DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,System.Nullable_T_,string).other'></a>

`other` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[T](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,System.Nullable_T_,string).T 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this T, System\.Nullable\<T\>, string\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The value to compare against\.

<a name='DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,System.Nullable_T_,string).parameterName'></a>

`parameterName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the [value](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,System.Nullable_T_,string).value 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this T, System\.Nullable\<T\>, string\)\.value') parameter \(automatically provided\)\.

#### Exceptions

[System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException')  
Thrown when [value](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,System.Nullable_T_,string).value 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this T, System\.Nullable\<T\>, string\)\.value') is greater than [other](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,System.Nullable_T_,string).other 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this T, System\.Nullable\<T\>, string\)\.other')\.

<a name='DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,T,string)'></a>

## ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this T, T, string\) Method

Throws an [System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException') if [value](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,T,string).value 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this T, T, string\)\.value') is greater than [other](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,T,string).other 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this T, T, string\)\.other')\.

```csharp
public static void ThrowIfGreaterThan<T>(this T? value, T? other, string parameterName=null)
    where T : System.IComparable<T>;
```
#### Type parameters

<a name='DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,T,string).T'></a>

`T`

The type of the arguments, which must implement [System\.IComparable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1 'System\.IComparable\`1')\.
#### Parameters

<a name='DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,T,string).value'></a>

`value` [T](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,T,string).T 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this T, T, string\)\.T')

The value to validate\.

<a name='DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,T,string).other'></a>

`other` [T](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,T,string).T 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this T, T, string\)\.T')

The value to compare against\.

<a name='DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,T,string).parameterName'></a>

`parameterName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the [value](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,T,string).value 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this T, T, string\)\.value') parameter \(automatically provided\)\.

#### Exceptions

[System\.ArgumentOutOfRangeException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception 'System\.ArgumentOutOfRangeException')  
Thrown when [value](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,T,string).value 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this T, T, string\)\.value') is greater than [other](ComparableExtensions.md#DevElf.ArgumentValidation.ComparableExtensions.ThrowIfGreaterThan_T_(thisT,T,string).other 'DevElf\.ArgumentValidation\.ComparableExtensions\.ThrowIfGreaterThan\<T\>\(this T, T, string\)\.other')\.