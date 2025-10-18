#### [DevElf](README.md 'README')
### [DevElf\.Threading\.RateLimiting](DevElf.Threading.RateLimiting.md 'DevElf\.Threading\.RateLimiting')

## NoLimitRateLimiter Class

A [System\.Threading\.RateLimiting\.RateLimiter](https://learn.microsoft.com/en-us/dotnet/api/system.threading.ratelimiting.ratelimiter 'System\.Threading\.RateLimiting\.RateLimiter') implementation that imposes no limits on permit acquisition\.
All requests for permits are immediately granted without any restrictions\.

```csharp
public class NoLimitRateLimiter : System.Threading.RateLimiting.RateLimiter
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; [System\.Threading\.RateLimiting\.RateLimiter](https://learn.microsoft.com/en-us/dotnet/api/system.threading.ratelimiting.ratelimiter 'System\.Threading\.RateLimiting\.RateLimiter') &#129106; NoLimitRateLimiter

### Example

```csharp
// Use the singleton instance
RateLimiter limiter = NoLimitRateLimiter.Instance;

// All acquisitions succeed immediately
using var lease = await limiter.AcquireAsync(permitCount: 100);
// lease.IsAcquired will always be true
```

### Remarks

This rate limiter is useful in scenarios where rate limiting needs to be conditionally
disabled or for testing purposes. It always returns acquired leases immediately,
regardless of the number of permits requested.

Use the singleton [Instance](NoLimitRateLimiter.Instance.md 'DevElf\.Threading\.RateLimiting\.NoLimitRateLimiter\.Instance') to avoid unnecessary allocations.

| Fields | |
| :--- | :--- |
| [Instance](NoLimitRateLimiter.Instance.md 'DevElf\.Threading\.RateLimiting\.NoLimitRateLimiter\.Instance') | Gets the singleton instance of [NoLimitRateLimiter](NoLimitRateLimiter.md 'DevElf\.Threading\.RateLimiting\.NoLimitRateLimiter')\. |

| Properties | |
| :--- | :--- |
| [IdleDuration](NoLimitRateLimiter.IdleDuration.md 'DevElf\.Threading\.RateLimiting\.NoLimitRateLimiter\.IdleDuration') | Gets the idle duration, which is always [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') for this limiter since there is never any waiting required\. |

| Methods | |
| :--- | :--- |
| [AcquireAsyncCore\(int, CancellationToken\)](NoLimitRateLimiter.AcquireAsyncCore.9OYNX0BDE4KS06QL3Q6ZAT7E9.md 'DevElf\.Threading\.RateLimiting\.NoLimitRateLimiter\.AcquireAsyncCore\(int, System\.Threading\.CancellationToken\)') | Asynchronously acquires permits\. Always succeeds immediately regardless of the permit count\. |
| [AttemptAcquireCore\(int\)](NoLimitRateLimiter.AttemptAcquireCore.8MGOY3NOUQFYG8WU0SFKW9RS4.md 'DevElf\.Threading\.RateLimiting\.NoLimitRateLimiter\.AttemptAcquireCore\(int\)') | Attempts to acquire permits synchronously\. Always succeeds immediately regardless of the permit count\. |
| [GetStatistics\(\)](NoLimitRateLimiter.GetStatistics().md 'DevElf\.Threading\.RateLimiting\.NoLimitRateLimiter\.GetStatistics\(\)') | Gets the rate limiter statistics\. Always returns [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') since this limiter does not track any statistics\. |
