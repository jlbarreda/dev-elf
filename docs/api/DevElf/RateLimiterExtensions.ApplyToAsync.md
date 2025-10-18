#### [DevElf](README.md 'README')
### [DevElf\.Threading\.RateLimiting](DevElf.Threading.RateLimiting.md 'DevElf\.Threading\.RateLimiting').[RateLimiterExtensions](RateLimiterExtensions.md 'DevElf\.Threading\.RateLimiting\.RateLimiterExtensions')

## RateLimiterExtensions\.ApplyToAsync Method

| Overloads | |
| :--- | :--- |
| [ApplyToAsync\(this RateLimiter, Func&lt;CancellationToken,Task&gt;, int, Nullable&lt;TimeSpan&gt;, TimeProvider, CancellationToken\)](RateLimiterExtensions.ApplyToAsync.md#DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken) 'DevElf\.Threading\.RateLimiting\.RateLimiterExtensions\.ApplyToAsync\(this System\.Threading\.RateLimiting\.RateLimiter, System\.Func\<System\.Threading\.CancellationToken,System\.Threading\.Tasks\.Task\>, int, System\.Nullable\<System\.TimeSpan\>, System\.TimeProvider, System\.Threading\.CancellationToken\)') | Applies rate limiting to an asynchronous action, automatically acquiring and releasing permits\. |
| [ApplyToAsync&lt;T&gt;\(this RateLimiter, Func&lt;CancellationToken,Task&lt;T&gt;&gt;, int, Nullable&lt;TimeSpan&gt;, TimeProvider, CancellationToken\)](RateLimiterExtensions.ApplyToAsync.md#DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync_T_(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken) 'DevElf\.Threading\.RateLimiting\.RateLimiterExtensions\.ApplyToAsync\<T\>\(this System\.Threading\.RateLimiting\.RateLimiter, System\.Func\<System\.Threading\.CancellationToken,System\.Threading\.Tasks\.Task\<T\>\>, int, System\.Nullable\<System\.TimeSpan\>, System\.TimeProvider, System\.Threading\.CancellationToken\)') | Applies rate limiting to an asynchronous request, automatically acquiring and releasing permits, and returns the result\. |

<a name='DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken)'></a>

## RateLimiterExtensions\.ApplyToAsync\(this RateLimiter, Func\<CancellationToken,Task\>, int, Nullable\<TimeSpan\>, TimeProvider, CancellationToken\) Method

Applies rate limiting to an asynchronous action, automatically acquiring and
releasing permits\.

```csharp
public static System.Threading.Tasks.Task ApplyToAsync(this System.Threading.RateLimiting.RateLimiter limiter, System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task> action, int permitCount=1, System.Nullable<System.TimeSpan> idleTime=null, System.TimeProvider? timeProvider=null, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken).limiter'></a>

`limiter` [System\.Threading\.RateLimiting\.RateLimiter](https://learn.microsoft.com/en-us/dotnet/api/system.threading.ratelimiting.ratelimiter 'System\.Threading\.RateLimiting\.RateLimiter')

The rate limiter to be used\.

<a name='DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken).action'></a>

`action` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The action to execute once permits are acquired\.

<a name='DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken).permitCount'></a>

`permitCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of permits needed to execute the action\. Must be positive\.
Defaults to 1\.

<a name='DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken).idleTime'></a>

`idleTime` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The time to wait between permit acquisition attempts when permits are not
immediately available\. When [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null'), defaults to 100
microseconds\. This prevents busy\-waiting while allowing responsive permit
acquisition\.

<a name='DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken).timeProvider'></a>

`timeProvider` [System\.TimeProvider](https://learn.microsoft.com/en-us/dotnet/api/system.timeprovider 'System\.TimeProvider')

The [System\.TimeProvider](https://learn.microsoft.com/en-us/dotnet/api/system.timeprovider 'System\.TimeProvider') to use for time\-based operations during idle
waits\. When [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null'), defaults to [System\.TimeProvider\.System](https://learn.microsoft.com/en-us/dotnet/api/system.timeprovider.system 'System\.TimeProvider\.System')\.

<a name='DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A token to monitor for cancellation requests during permit acquisition and
action execution\.

#### Returns
[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')  
A task that completes when the action has been executed\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
If [limiter](RateLimiterExtensions.md#DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken).limiter 'DevElf\.Threading\.RateLimiting\.RateLimiterExtensions\.ApplyToAsync\(this System\.Threading\.RateLimiting\.RateLimiter, System\.Func\<System\.Threading\.CancellationToken,System\.Threading\.Tasks\.Task\>, int, System\.Nullable\<System\.TimeSpan\>, System\.TimeProvider, System\.Threading\.CancellationToken\)\.limiter') or [action](RateLimiterExtensions.md#DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken).action 'DevElf\.Threading\.RateLimiting\.RateLimiterExtensions\.ApplyToAsync\(this System\.Threading\.RateLimiting\.RateLimiter, System\.Func\<System\.Threading\.CancellationToken,System\.Threading\.Tasks\.Task\>, int, System\.Nullable\<System\.TimeSpan\>, System\.TimeProvider, System\.Threading\.CancellationToken\)\.action') is
[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

[System\.OperationCanceledException](https://learn.microsoft.com/en-us/dotnet/api/system.operationcanceledexception 'System\.OperationCanceledException')  
If the [cancellationToken](RateLimiterExtensions.md#DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken).cancellationToken 'DevElf\.Threading\.RateLimiting\.RateLimiterExtensions\.ApplyToAsync\(this System\.Threading\.RateLimiting\.RateLimiter, System\.Func\<System\.Threading\.CancellationToken,System\.Threading\.Tasks\.Task\>, int, System\.Nullable\<System\.TimeSpan\>, System\.TimeProvider, System\.Threading\.CancellationToken\)\.cancellationToken') is canceled before or during
execution\.

### Example

```csharp
var limiter = new TokenBucketRateLimiter(new TokenBucketRateLimiterOptions
{
    TokenLimit = 10,
    ReplenishmentPeriod = TimeSpan.FromSeconds(1),
    TokensPerPeriod = 10
});

await limiter.ApplyToAsync(
    async ct => await SendEmailAsync(ct),
    permitCount: 1,
    cancellationToken: cancellationToken);
```

### Remarks

This method repeatedly attempts to acquire the specified number of permits.
If permits are not immediately available, it waits for the specified
[idleTime](RateLimiterExtensions.md#DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken).idleTime 'DevElf\.Threading\.RateLimiting\.RateLimiterExtensions\.ApplyToAsync\(this System\.Threading\.RateLimiting\.RateLimiter, System\.Func\<System\.Threading\.CancellationToken,System\.Threading\.Tasks\.Task\>, int, System\.Nullable\<System\.TimeSpan\>, System\.TimeProvider, System\.Threading\.CancellationToken\)\.idleTime') before trying again. Once permits are acquired,
the action is executed and the permits are automatically released.

The lease is properly disposed even if the action throws an exception,
ensuring permits are returned to the limiter.

<a name='DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync_T_(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken)'></a>

## RateLimiterExtensions\.ApplyToAsync\<T\>\(this RateLimiter, Func\<CancellationToken,Task\<T\>\>, int, Nullable\<TimeSpan\>, TimeProvider, CancellationToken\) Method

Applies rate limiting to an asynchronous request, automatically acquiring and
releasing permits, and returns the result\.

```csharp
public static System.Threading.Tasks.Task<T> ApplyToAsync<T>(this System.Threading.RateLimiting.RateLimiter limiter, System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>> request, int permitCount=1, System.Nullable<System.TimeSpan> idleTime=null, System.TimeProvider? timeProvider=null, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Type parameters

<a name='DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync_T_(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken).T'></a>

`T`

The type of the result returned by the request\.
#### Parameters

<a name='DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync_T_(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken).limiter'></a>

`limiter` [System\.Threading\.RateLimiting\.RateLimiter](https://learn.microsoft.com/en-us/dotnet/api/system.threading.ratelimiting.ratelimiter 'System\.Threading\.RateLimiting\.RateLimiter')

The rate limiter to be used\.

<a name='DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync_T_(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken).request'></a>

`request` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[T](RateLimiterExtensions.md#DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync_T_(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken).T 'DevElf\.Threading\.RateLimiting\.RateLimiterExtensions\.ApplyToAsync\<T\>\(this System\.Threading\.RateLimiting\.RateLimiter, System\.Func\<System\.Threading\.CancellationToken,System\.Threading\.Tasks\.Task\<T\>\>, int, System\.Nullable\<System\.TimeSpan\>, System\.TimeProvider, System\.Threading\.CancellationToken\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The request function to execute once permits are acquired\.

<a name='DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync_T_(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken).permitCount'></a>

`permitCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of permits needed to execute the request\. Must be positive\.
Defaults to 1\.

<a name='DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync_T_(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken).idleTime'></a>

`idleTime` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The time to wait between permit acquisition attempts when permits are not
immediately available\. When [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null'), defaults to 100
microseconds\. This prevents busy\-waiting while allowing responsive permit
acquisition\.

<a name='DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync_T_(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken).timeProvider'></a>

`timeProvider` [System\.TimeProvider](https://learn.microsoft.com/en-us/dotnet/api/system.timeprovider 'System\.TimeProvider')

The [System\.TimeProvider](https://learn.microsoft.com/en-us/dotnet/api/system.timeprovider 'System\.TimeProvider') to use for time\-based operations during idle
waits\. When [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null'), defaults to [System\.TimeProvider\.System](https://learn.microsoft.com/en-us/dotnet/api/system.timeprovider.system 'System\.TimeProvider\.System')\.

<a name='DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync_T_(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A token to monitor for cancellation requests during permit acquisition and
request execution\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[T](RateLimiterExtensions.md#DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync_T_(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken).T 'DevElf\.Threading\.RateLimiting\.RateLimiterExtensions\.ApplyToAsync\<T\>\(this System\.Threading\.RateLimiting\.RateLimiter, System\.Func\<System\.Threading\.CancellationToken,System\.Threading\.Tasks\.Task\<T\>\>, int, System\.Nullable\<System\.TimeSpan\>, System\.TimeProvider, System\.Threading\.CancellationToken\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result contains
the value returned by the request function\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
If [limiter](RateLimiterExtensions.md#DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync_T_(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken).limiter 'DevElf\.Threading\.RateLimiting\.RateLimiterExtensions\.ApplyToAsync\<T\>\(this System\.Threading\.RateLimiting\.RateLimiter, System\.Func\<System\.Threading\.CancellationToken,System\.Threading\.Tasks\.Task\<T\>\>, int, System\.Nullable\<System\.TimeSpan\>, System\.TimeProvider, System\.Threading\.CancellationToken\)\.limiter') or [request](RateLimiterExtensions.md#DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync_T_(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken).request 'DevElf\.Threading\.RateLimiting\.RateLimiterExtensions\.ApplyToAsync\<T\>\(this System\.Threading\.RateLimiting\.RateLimiter, System\.Func\<System\.Threading\.CancellationToken,System\.Threading\.Tasks\.Task\<T\>\>, int, System\.Nullable\<System\.TimeSpan\>, System\.TimeProvider, System\.Threading\.CancellationToken\)\.request') is
[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

[System\.OperationCanceledException](https://learn.microsoft.com/en-us/dotnet/api/system.operationcanceledexception 'System\.OperationCanceledException')  
If the [cancellationToken](RateLimiterExtensions.md#DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync_T_(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken).cancellationToken 'DevElf\.Threading\.RateLimiting\.RateLimiterExtensions\.ApplyToAsync\<T\>\(this System\.Threading\.RateLimiting\.RateLimiter, System\.Func\<System\.Threading\.CancellationToken,System\.Threading\.Tasks\.Task\<T\>\>, int, System\.Nullable\<System\.TimeSpan\>, System\.TimeProvider, System\.Threading\.CancellationToken\)\.cancellationToken') is canceled before or during
execution\.

### Example

```csharp
var limiter = new ConcurrencyLimiter(new ConcurrencyLimiterOptions
{
    PermitLimit = 5,
    QueueLimit = 10
});

var response = await limiter.ApplyToAsync(
    async ct => await httpClient.GetAsync(url, ct),
    permitCount: 1,
    cancellationToken: cancellationToken);
```

### Remarks

This method repeatedly attempts to acquire the specified number of permits.
If permits are not immediately available, it waits for the specified
[idleTime](RateLimiterExtensions.md#DevElf.Threading.RateLimiting.RateLimiterExtensions.ApplyToAsync_T_(thisSystem.Threading.RateLimiting.RateLimiter,System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,int,System.Nullable_System.TimeSpan_,System.TimeProvider,System.Threading.CancellationToken).idleTime 'DevElf\.Threading\.RateLimiting\.RateLimiterExtensions\.ApplyToAsync\<T\>\(this System\.Threading\.RateLimiting\.RateLimiter, System\.Func\<System\.Threading\.CancellationToken,System\.Threading\.Tasks\.Task\<T\>\>, int, System\.Nullable\<System\.TimeSpan\>, System\.TimeProvider, System\.Threading\.CancellationToken\)\.idleTime') before trying again. Once permits are acquired,
the request is executed and the permits are automatically released.

The lease is properly disposed even if the request throws an exception,
ensuring permits are returned to the limiter.