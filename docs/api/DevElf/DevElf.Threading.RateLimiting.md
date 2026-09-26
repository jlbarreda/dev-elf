#### [DevElf](README.md 'README')

## DevElf\.Threading\.RateLimiting Namespace

| Classes | |
| :--- | :--- |
| [NoLimitRateLimiter](NoLimitRateLimiter.md 'DevElf\.Threading\.RateLimiting\.NoLimitRateLimiter') | A [System\.Threading\.RateLimiting\.RateLimiter](https://learn.microsoft.com/en-us/dotnet/api/system.threading.ratelimiting.ratelimiter 'System\.Threading\.RateLimiting\.RateLimiter') implementation that imposes no limits on permit acquisition\. All requests for permits are immediately granted without any restrictions\. |
| [NoLimitRateLimiter\.NoLimitLease](NoLimitRateLimiter.NoLimitLease.md 'DevElf\.Threading\.RateLimiting\.NoLimitRateLimiter\.NoLimitLease') | Represents a lease from [NoLimitRateLimiter](NoLimitRateLimiter.md 'DevElf\.Threading\.RateLimiting\.NoLimitRateLimiter') that is always acquired and contains no metadata\. |
| [RateLimiterExtensions](RateLimiterExtensions.md 'DevElf\.Threading\.RateLimiting\.RateLimiterExtensions') | Provides extension methods for [System\.Threading\.RateLimiting\.RateLimiter](https://learn.microsoft.com/en-us/dotnet/api/system.threading.ratelimiting.ratelimiter 'System\.Threading\.RateLimiting\.RateLimiter') to simplify applying rate limiting to actions and requests\. |
