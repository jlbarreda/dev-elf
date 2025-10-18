#### [DevElf](README.md 'README')
### [DevElf\.Threading\.RateLimiting](DevElf.Threading.RateLimiting.md 'DevElf\.Threading\.RateLimiting')

## RateLimiterExtensions Class

Provides extension methods for [System\.Threading\.RateLimiting\.RateLimiter](https://learn.microsoft.com/en-us/dotnet/api/system.threading.ratelimiting.ratelimiter 'System\.Threading\.RateLimiting\.RateLimiter') to simplify applying
rate limiting to actions and requests\.

```csharp
public static class RateLimiterExtensions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; RateLimiterExtensions

| Methods | |
| :--- | :--- |
| [ApplyToAsync\(this RateLimiter, Func&lt;CancellationToken,Task&gt;, int, Nullable&lt;TimeSpan&gt;, TimeProvider, CancellationToken\)](RateLimiterExtensions.ApplyToAsync.md#DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken) 'DevElf\.Threading\.RateLimiting\.RateLimiterExtensions\.ApplyToAsync\(this System\.Threading\.RateLimiting\.RateLimiter, System\.Func\<System\.Threading\.CancellationToken,System\.Threading\.Tasks\.Task\>, int, System\.Nullable\<System\.TimeSpan\>, System\.TimeProvider, System\.Threading\.CancellationToken\)') | Applies rate limiting to an asynchronous action, automatically acquiring and releasing permits\. |
| [ApplyToAsync&lt;T&gt;\(this RateLimiter, Func&lt;CancellationToken,Task&lt;T&gt;&gt;, int, Nullable&lt;TimeSpan&gt;, TimeProvider, CancellationToken\)](RateLimiterExtensions.ApplyToAsync.md#DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync_T_(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken) 'DevElf\.Threading\.RateLimiting\.RateLimiterExtensions\.ApplyToAsync\<T\>\(this System\.Threading\.RateLimiting\.RateLimiter, System\.Func\<System\.Threading\.CancellationToken,System\.Threading\.Tasks\.Task\<T\>\>, int, System\.Nullable\<System\.TimeSpan\>, System\.TimeProvider, System\.Threading\.CancellationToken\)') | Applies rate limiting to an asynchronous request, automatically acquiring and releasing permits, and returns the result\. |
