#### [DevElf](README.md 'README')
### [DevElf](DevElf.md 'DevElf').[SerializableExceptionWrapper](SerializableExceptionWrapper.md 'DevElf\.SerializableExceptionWrapper')

## SerializableExceptionWrapper\.ToString\(\) Method

Returns a string representation of the wrapped exception, serialized as JSON if possible\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A JSON string if serialization succeeds; otherwise, the original [System\.Exception\.ToString](https://learn.microsoft.com/en-us/dotnet/api/system.exception.tostring 'System\.Exception\.ToString') value\.