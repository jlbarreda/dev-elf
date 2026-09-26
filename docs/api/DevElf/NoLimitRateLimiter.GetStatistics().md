#### [DevElf](README.md 'README')
### [DevElf\.Threading\.RateLimiting](DevElf.Threading.RateLimiting.md 'DevElf\.Threading\.RateLimiting').[NoLimitRateLimiter](NoLimitRateLimiter.md 'DevElf\.Threading\.RateLimiting\.NoLimitRateLimiter')

## NoLimitRateLimiter\.GetStatistics\(\) Method

Gets the rate limiter statistics\. Always returns [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') since
this limiter does not track any statistics\.

```csharp
public override System.Threading.RateLimiting.RateLimiterStatistics? GetStatistics();
```

#### Returns
[System\.Threading\.RateLimiting\.RateLimiterStatistics](https://learn.microsoft.com/en-us/dotnet/api/system.threading.ratelimiting.ratelimiterstatistics 'System\.Threading\.RateLimiting\.RateLimiterStatistics')  
Always [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.