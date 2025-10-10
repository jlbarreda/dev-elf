#### [DevElf\.Logging](README.md 'README')
### [DevElf\.Logging](DevElf.Logging.md 'DevElf\.Logging').[ILogMessageScope](ILogMessageScope.md 'DevElf\.Logging\.ILogMessageScope')

## ILogMessageScope\.SetProperty\<T\>\(string, T\) Method

Sets a property on the current scope\.
When multiple scopes are nested, child properties override parent properties with the same key\.

```csharp
T SetProperty<T>(string key, T value);
```
#### Type parameters

<a name='DevElf.Logging.ILogMessageScope.SetProperty_T_(string,T).T'></a>

`T`

The value type\.
#### Parameters

<a name='DevElf.Logging.ILogMessageScope.SetProperty_T_(string,T).key'></a>

`key` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The property key\. Cannot be [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null'), empty, or whitespace\.

<a name='DevElf.Logging.ILogMessageScope.SetProperty_T_(string,T).value'></a>

`value` [T](ILogMessageScope.SetProperty.W33WIH8SSDTY69PIOC9JED2Q2.md#DevElf.Logging.ILogMessageScope.SetProperty_T_(string,T).T 'DevElf\.Logging\.ILogMessageScope\.SetProperty\<T\>\(string, T\)\.T')

The property value\.

#### Returns
[T](ILogMessageScope.SetProperty.W33WIH8SSDTY69PIOC9JED2Q2.md#DevElf.Logging.ILogMessageScope.SetProperty_T_(string,T).T 'DevElf\.Logging\.ILogMessageScope\.SetProperty\<T\>\(string, T\)\.T')  
Returns the provided [value](ILogMessageScope.SetProperty.W33WIH8SSDTY69PIOC9JED2Q2.md#DevElf.Logging.ILogMessageScope.SetProperty_T_(string,T).value 'DevElf\.Logging\.ILogMessageScope\.SetProperty\<T\>\(string, T\)\.value') to enable fluent assignment\.