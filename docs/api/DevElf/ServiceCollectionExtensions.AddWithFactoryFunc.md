#### [DevElf](README.md 'README')
### [DevElf\.DependencyInjection](DevElf.DependencyInjection.md 'DevElf\.DependencyInjection').[ServiceCollectionExtensions](ServiceCollectionExtensions.md 'DevElf\.DependencyInjection\.ServiceCollectionExtensions')

## ServiceCollectionExtensions\.AddWithFactoryFunc Method

| Overloads | |
| :--- | :--- |
| [AddWithFactoryFunc&lt;TService,TImplementation&gt;\(this IServiceCollection, ServiceLifetime\)](ServiceCollectionExtensions.AddWithFactoryFunc.md#DevElf.DependencyInjection.ServiceCollectionExtensions.AddWithFactoryFunc_TService,TImplementation_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime) 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.AddWithFactoryFunc\<TService,TImplementation\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)') | Registers a service with its implementation type using the specified lifetime and also registers  a factory function \([System\.Func&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')\) that can be injected to create instances on demand\. |
| [AddWithFactoryFunc&lt;TService&gt;\(this IServiceCollection, ServiceLifetime\)](ServiceCollectionExtensions.AddWithFactoryFunc.md#DevElf.DependencyInjection.ServiceCollectionExtensions.AddWithFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime) 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.AddWithFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)') | Registers a service with the specified lifetime and also registers a factory function \([System\.Func&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')\) that can be injected to create instances on demand\. |
| [AddWithFactoryFunc&lt;TService&gt;\(this IServiceCollection, Func&lt;IServiceProvider,TService&gt;, ServiceLifetime\)](ServiceCollectionExtensions.AddWithFactoryFunc.md#DevElf.DependencyInjection.ServiceCollectionExtensions.AddWithFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime) 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.AddWithFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, System\.Func\<System\.IServiceProvider,TService\>, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)') | Registers a service using a factory function with the specified lifetime and also registers  a factory function \([System\.Func&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')\) that can be injected to create instances on demand\. |

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.AddWithFactoryFunc_TService,TImplementation_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime)'></a>

## ServiceCollectionExtensions\.AddWithFactoryFunc\<TService,TImplementation\>\(this IServiceCollection, ServiceLifetime\) Method

Registers a service with its implementation type using the specified lifetime and also registers 
a factory function \([System\.Func&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')\) that can be injected to create instances on demand\.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddWithFactoryFunc<TService,TImplementation>(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.DependencyInjection.ServiceLifetime serviceLifetime)
    where TService : class
    where TImplementation : TService;
```
#### Type parameters

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.AddWithFactoryFunc_TService,TImplementation_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService'></a>

`TService`

The service type to register\. Must be a class\.

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.AddWithFactoryFunc_TService,TImplementation_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TImplementation'></a>

`TImplementation`

The implementation type that implements [TService](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.AddWithFactoryFunc_TService,TImplementation_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.AddWithFactoryFunc\<TService,TImplementation\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.TService')\.
#### Parameters

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.AddWithFactoryFunc_TService,TImplementation_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).services'></a>

`services` [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection')

The [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection') to add the services to\.

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.AddWithFactoryFunc_TService,TImplementation_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).serviceLifetime'></a>

`serviceLifetime` [Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.servicelifetime 'Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime')

The lifetime of the service\.

#### Returns
[Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection')  
The same [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection') for chaining\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
[services](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.AddWithFactoryFunc_TService,TImplementation_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).services 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.AddWithFactoryFunc\<TService,TImplementation\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.services') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

### Example

```csharp
services.AddWithFactoryFunc<IMyService, MyServiceImpl>(ServiceLifetime.Singleton);
```

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.AddWithFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime)'></a>

## ServiceCollectionExtensions\.AddWithFactoryFunc\<TService\>\(this IServiceCollection, ServiceLifetime\) Method

Registers a service with the specified lifetime and also registers a factory function
\([System\.Func&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')\) that can be injected to create instances on demand\.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddWithFactoryFunc<TService>(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.DependencyInjection.ServiceLifetime serviceLifetime)
    where TService : class;
```
#### Type parameters

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.AddWithFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService'></a>

`TService`

The type of service to register\. Must be a class\.
#### Parameters

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.AddWithFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).services'></a>

`services` [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection')

The [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection') to add the services to\.

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.AddWithFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).serviceLifetime'></a>

`serviceLifetime` [Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.servicelifetime 'Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime')

The lifetime of the service\.

#### Returns
[Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection')  
The same [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection') for chaining\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
[services](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.AddWithFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).services 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.AddWithFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.services') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

### Example

```csharp
services.AddWithFactoryFunc<IMyService>(ServiceLifetime.Scoped);

// Later, inject Func<IMyService> to create instances on demand:
public class Consumer(Func<IMyService> serviceFactory)
{
    public void DoWork()
    {
        var service = serviceFactory();
        // use service...
    }
}
```

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.AddWithFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime)'></a>

## ServiceCollectionExtensions\.AddWithFactoryFunc\<TService\>\(this IServiceCollection, Func\<IServiceProvider,TService\>, ServiceLifetime\) Method

Registers a service using a factory function with the specified lifetime and also registers 
a factory function \([System\.Func&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')\) that can be injected to create instances on demand\.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddWithFactoryFunc<TService>(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Func<System.IServiceProvider,TService> serviceFactory, Microsoft.Extensions.DependencyInjection.ServiceLifetime serviceLifetime)
    where TService : class;
```
#### Type parameters

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.AddWithFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService'></a>

`TService`

The type of service to register\. Must be a class\.
#### Parameters

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.AddWithFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).services'></a>

`services` [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection')

The [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection') to add the services to\.

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.AddWithFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).serviceFactory'></a>

`serviceFactory` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.IServiceProvider](https://learn.microsoft.com/en-us/dotnet/api/system.iserviceprovider 'System\.IServiceProvider')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[TService](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.AddWithFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.AddWithFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, System\.Func\<System\.IServiceProvider,TService\>, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.TService')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The factory function that creates instances of the service\.

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.AddWithFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).serviceLifetime'></a>

`serviceLifetime` [Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.servicelifetime 'Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime')

The lifetime of the service\.

#### Returns
[Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection')  
The same [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection') for chaining\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
[services](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.AddWithFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).services 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.AddWithFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, System\.Func\<System\.IServiceProvider,TService\>, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.services') or [serviceFactory](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.AddWithFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).serviceFactory 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.AddWithFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, System\.Func\<System\.IServiceProvider,TService\>, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.serviceFactory') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

### Example

```csharp
services.AddWithFactoryFunc<IMyService>(
    sp => new MyService(sp.GetRequiredService<IDependency>()),
    ServiceLifetime.Transient);
```