#### [DevElf](README.md 'README')
### [DevElf\.Threading\.RateLimiting](DevElf.Threading.RateLimiting.md 'DevElf\.Threading\.RateLimiting').[NoLimitRateLimiter](NoLimitRateLimiter.md 'DevElf\.Threading\.RateLimiting\.NoLimitRateLimiter')

## NoLimitRateLimiter\.AcquireAsyncCore\(int, CancellationToken\) Method

Asynchronously acquires permits\. Always succeeds immediately regardless of
the permit count\.

```csharp
protected override System.Threading.Tasks.ValueTask<System.Threading.RateLimiting.RateLimitLease> AcquireAsyncCore(int permitCount, System.Threading.CancellationToken cancellationToken);
```
#### Parameters

<a name='DevElf.Threading.RateLimiting.NoLimitRateLimiter.AcquireAsyncCore(int,System.Threading.CancellationToken).permitCount'></a>

`permitCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of permits to acquire\. This parameter is ignored since all
acquisitions succeed\.

<a name='DevElf.Threading.RateLimiting.NoLimitRateLimiter.AcquireAsyncCore(int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A token to monitor for cancellation requests\. This parameter is ignored since
the operation completes synchronously\.

#### Returns
[System\.Threading\.Tasks\.ValueTask&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.valuetask-1 'System\.Threading\.Tasks\.ValueTask\`1')[System\.Threading\.RateLimiting\.RateLimitLease](https://learn.microsoft.com/en-us/dotnet/api/system.threading.ratelimiting.ratelimitlease 'System\.Threading\.RateLimiting\.RateLimitLease')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.valuetask-1 'System\.Threading\.Tasks\.ValueTask\`1')  
A [System\.Threading\.Tasks\.ValueTask&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.valuetask-1 'System\.Threading\.Tasks\.ValueTask\`1') that completes immediately with an acquired lease\.