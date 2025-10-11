#### [DevElf\.Logging](README.md 'README')
### [DevElf\.Logging](DevElf.Logging.md 'DevElf\.Logging').[ServiceCollectionExtensions](ServiceCollectionExtensions.md 'DevElf\.Logging\.ServiceCollectionExtensions')

## ServiceCollectionExtensions\.AddLogMessageScopes\(this IServiceCollection\) Method

Adds the [ILogMessageScopeAccessor](ILogMessageScopeAccessor.md 'DevElf\.Logging\.ILogMessageScopeAccessor') service to the DI container, if not already registered\.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddLogMessageScopes(this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
```
#### Parameters

<a name='DevElf.Logging.ServiceCollectionExtensions.AddLogMessageScopes(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection).services'></a>

`services` [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection')

The service collection\.

#### Returns
[Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection')  
The same [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection') for chaining\.