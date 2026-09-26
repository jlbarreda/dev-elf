#### [DevElf](README.md 'README')
### [DevElf](DevElf.md 'DevElf')

## SerializableExceptionWrapper Class

Wraps an [System\.Exception](https://learn.microsoft.com/en-us/dotnet/api/system.exception 'System\.Exception') for serialization, including its properties and inner exception\.

```csharp
public class SerializableExceptionWrapper
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; SerializableExceptionWrapper

| Constructors | |
| :--- | :--- |
| [SerializableExceptionWrapper\(Exception\)](SerializableExceptionWrapper..ctor.LZH9UCLTN28N35I70OCL3GM65.md 'DevElf\.SerializableExceptionWrapper\.SerializableExceptionWrapper\(System\.Exception\)') | Initializes a new instance of the [SerializableExceptionWrapper](SerializableExceptionWrapper.md 'DevElf\.SerializableExceptionWrapper') class\. |

| Properties | |
| :--- | :--- |
| [Data](SerializableExceptionWrapper.Data.md 'DevElf\.SerializableExceptionWrapper\.Data') | Gets the data associated with the exception\. |
| [HelpLink](SerializableExceptionWrapper.HelpLink.md 'DevElf\.SerializableExceptionWrapper\.HelpLink') | Gets the help link for the exception\. |
| [HResult](SerializableExceptionWrapper.HResult.md 'DevElf\.SerializableExceptionWrapper\.HResult') | Gets the HRESULT value for the exception\. |
| [InnerException](SerializableExceptionWrapper.InnerException.md 'DevElf\.SerializableExceptionWrapper\.InnerException') | Gets the wrapped inner exception, if any\. |
| [Message](SerializableExceptionWrapper.Message.md 'DevElf\.SerializableExceptionWrapper\.Message') | Gets the message describing the exception\. |
| [Source](SerializableExceptionWrapper.Source.md 'DevElf\.SerializableExceptionWrapper\.Source') | Gets the source of the exception\. |
| [StackTrace](SerializableExceptionWrapper.StackTrace.md 'DevElf\.SerializableExceptionWrapper\.StackTrace') | Gets the stack trace for the exception\. |

| Methods | |
| :--- | :--- |
| [ToString\(\)](SerializableExceptionWrapper.ToString().md 'DevElf\.SerializableExceptionWrapper\.ToString\(\)') | Returns a string representation of the wrapped exception, serialized as JSON if possible\. |
