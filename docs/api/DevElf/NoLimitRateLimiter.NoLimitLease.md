#### [DevElf](README.md 'README')
### [DevElf\.Threading\.RateLimiting](DevElf.Threading.RateLimiting.md 'DevElf\.Threading\.RateLimiting').[NoLimitRateLimiter](NoLimitRateLimiter.md 'DevElf\.Threading\.RateLimiting\.NoLimitRateLimiter')

## NoLimitRateLimiter\.NoLimitLease Class

Represents a lease from [NoLimitRateLimiter](NoLimitRateLimiter.md 'DevElf\.Threading\.RateLimiting\.NoLimitRateLimiter') that is always acquired
and contains no metadata\.

```csharp
protected sealed class NoLimitRateLimiter.NoLimitLease : System.Threading.RateLimiting.RateLimitLease
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; [System\.Threading\.RateLimiting\.RateLimitLease](https://learn.microsoft.com/en-us/dotnet/api/system.threading.ratelimiting.ratelimitlease 'System\.Threading\.RateLimiting\.RateLimitLease') &#129106; NoLimitLease

| Fields | |
| :--- | :--- |
| [LeaseInstance](NoLimitRateLimiter.NoLimitLease.LeaseInstance.md 'DevElf\.Threading\.RateLimiting\.NoLimitRateLimiter\.NoLimitLease\.LeaseInstance') | Gets the singleton instance of [NoLimitLease](NoLimitRateLimiter.NoLimitLease.md 'DevElf\.Threading\.RateLimiting\.NoLimitRateLimiter\.NoLimitLease')\. |

| Properties | |
| :--- | :--- |
| [IsAcquired](NoLimitRateLimiter.NoLimitLease.IsAcquired.md 'DevElf\.Threading\.RateLimiting\.NoLimitRateLimiter\.NoLimitLease\.IsAcquired') | Gets a value indicating whether the lease was acquired\. Always returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\. |
| [MetadataNames](NoLimitRateLimiter.NoLimitLease.MetadataNames.md 'DevElf\.Threading\.RateLimiting\.NoLimitRateLimiter\.NoLimitLease\.MetadataNames') | Gets the metadata names associated with this lease\. Always returns an empty collection since this lease contains no metadata\. |

| Methods | |
| :--- | :--- |
| [TryGetMetadata\(string, object\)](NoLimitRateLimiter.NoLimitLease.TryGetMetadata.1WY8B7NIF29S1MB3QC5ZQMBU7.md 'DevElf\.Threading\.RateLimiting\.NoLimitRateLimiter\.NoLimitLease\.TryGetMetadata\(string, object\)') | Attempts to retrieve metadata by name\. Always returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') since this lease contains no metadata\. |
