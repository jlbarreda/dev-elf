#### [DevElf](README.md 'README')
### [DevElf\.Threading\.RateLimiting](DevElf.Threading.RateLimiting.md 'DevElf\.Threading\.RateLimiting').[NoLimitRateLimiter](NoLimitRateLimiter.md 'DevElf\.Threading\.RateLimiting\.NoLimitRateLimiter')

## NoLimitRateLimiter\.AttemptAcquireCore\(int\) Method

Attempts to acquire permits synchronously\. Always succeeds immediately
regardless of the permit count\.

```csharp
protected override System.Threading.RateLimiting.RateLimitLease AttemptAcquireCore(int permitCount);
```
#### Parameters

<a name='DevElf.Threading.RateLimiting.NoLimitRateLimiter.AttemptAcquireCore(int).permitCount'></a>

`permitCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of permits to acquire\. This parameter is ignored since all
acquisitions succeed\.

#### Returns
[System\.Threading\.RateLimiting\.RateLimitLease](https://learn.microsoft.com/en-us/dotnet/api/system.threading.ratelimiting.ratelimitlease 'System\.Threading\.RateLimiting\.RateLimitLease')  
An acquired [System\.Threading\.RateLimiting\.RateLimitLease](https://learn.microsoft.com/en-us/dotnet/api/system.threading.ratelimiting.ratelimitlease 'System\.Threading\.RateLimiting\.RateLimitLease')\.