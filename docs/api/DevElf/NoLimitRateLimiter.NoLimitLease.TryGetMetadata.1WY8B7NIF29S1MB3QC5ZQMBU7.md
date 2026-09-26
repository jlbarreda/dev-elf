#### [DevElf](README.md 'README')
### [DevElf\.Threading\.RateLimiting](DevElf.Threading.RateLimiting.md 'DevElf\.Threading\.RateLimiting').[NoLimitRateLimiter](NoLimitRateLimiter.md 'DevElf\.Threading\.RateLimiting\.NoLimitRateLimiter').[NoLimitLease](NoLimitRateLimiter.NoLimitLease.md 'DevElf\.Threading\.RateLimiting\.NoLimitRateLimiter\.NoLimitLease')

## NoLimitRateLimiter\.NoLimitLease\.TryGetMetadata\(string, object\) Method

Attempts to retrieve metadata by name\. Always returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')
since this lease contains no metadata\.

```csharp
public override bool TryGetMetadata(string metadataName, out object? metadata);
```
#### Parameters

<a name='DevElf.Threading.RateLimiting.NoLimitRateLimiter.NoLimitLease.TryGetMetadata(string,object).metadataName'></a>

`metadataName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the metadata to retrieve\.

<a name='DevElf.Threading.RateLimiting.NoLimitRateLimiter.NoLimitLease.TryGetMetadata(string,object).metadata'></a>

`metadata` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

When this method returns, contains [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
Always [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.