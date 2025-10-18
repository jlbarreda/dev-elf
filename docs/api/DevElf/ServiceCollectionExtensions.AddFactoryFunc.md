#### [DevElf](README.md 'README')
### [DevElf\.DependencyInjection](DevElf.DependencyInjection.md 'DevElf\.DependencyInjection').[ServiceCollectionExtensions](ServiceCollectionExtensions.md 'DevElf\.DependencyInjection\.ServiceCollectionExtensions')

## ServiceCollectionExtensions\.AddFactoryFunc Method

| Overloads | |
| :--- | :--- |
| [AddFactoryFunc&lt;TService&gt;\(this IServiceCollection, ServiceLifetime\)](ServiceCollectionExtensions.AddFactoryFunc.md#DevElf.DependencyInjection.ServiceCollectionExtensions.AddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime) 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.AddFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)') | Registers a factory function \([System\.Func&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')\) with the specified lifetime  that resolves instances of [TService](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.AddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.AddFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.TService') from the service provider\. |
| [AddFactoryFunc&lt;TService&gt;\(this IServiceCollection, Func&lt;IServiceProvider,TService&gt;, ServiceLifetime\)](ServiceCollectionExtensions.AddFactoryFunc.md#DevElf.DependencyInjection.ServiceCollectionExtensions.AddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime) 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.AddFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, System\.Func\<System\.IServiceProvider,TService\>, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)') | Registers a factory function \([System\.Func&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')\) with the specified lifetime  that wraps a custom service factory for creating instances of [TService](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.AddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.AddFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, System\.Func\<System\.IServiceProvider,TService\>, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.TService')\. |

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.AddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime)'></a>

## ServiceCollectionExtensions\.AddFactoryFunc\<TService\>\(this IServiceCollection, ServiceLifetime\) Method

Registers a factory function \([System\.Func&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')\) with the specified lifetime 
that resolves instances of [TService](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.AddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.AddFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.TService') from the service provider\.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddFactoryFunc<TService>(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.DependencyInjection.ServiceLifetime factoryLifetime)
    where TService : class;
```
#### Type parameters

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.AddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService'></a>

`TService`

The type of service the factory will create\. Must be a class\.
#### Parameters

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.AddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).services'></a>

`services` [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection')

The [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection') to add the factory to\.

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.AddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).factoryLifetime'></a>

`factoryLifetime` [Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.servicelifetime 'Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime')

The lifetime of the factory function itself\.

#### Returns
[Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection')  
The same [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection') for chaining\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
[services](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.AddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).services 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.AddFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.services') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

### Example

```csharp
services.AddScoped<IMyService, MyServiceImpl>();
services.AddFactoryFunc<IMyService>(ServiceLifetime.Singleton);

// Later, inject Func<IMyService> to create instances on demand
```

### Remarks
The factory function calls [Microsoft\.Extensions\.DependencyInjection\.ServiceProviderServiceExtensions\.GetRequiredService&lt;&gt;\.IServiceProvider\)](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.serviceproviderserviceextensions.getrequiredservice--1#microsoft-extensions-dependencyinjection-serviceproviderserviceextensions-getrequiredservice--1(system-iserviceprovider) 'Microsoft\.Extensions\.DependencyInjection\.ServiceProviderServiceExtensions\.GetRequiredService\`\`1\(System\.IServiceProvider\)')
to resolve the service when invoked\. The service itself must be registered separately\.

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.AddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime)'></a>

## ServiceCollectionExtensions\.AddFactoryFunc\<TService\>\(this IServiceCollection, Func\<IServiceProvider,TService\>, ServiceLifetime\) Method

Registers a factory function \([System\.Func&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')\) with the specified lifetime 
that wraps a custom service factory for creating instances of [TService](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.AddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.AddFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, System\.Func\<System\.IServiceProvider,TService\>, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.TService')\.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddFactoryFunc<TService>(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Func<System.IServiceProvider,TService> serviceFactory, Microsoft.Extensions.DependencyInjection.ServiceLifetime factoryLifetime)
    where TService : class;
```
#### Type parameters

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.AddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService'></a>

`TService`

The type of service the factory will create\. Must be a class\.
#### Parameters

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.AddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).services'></a>

`services` [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection')

The [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection') to add the factory to\.

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.AddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).serviceFactory'></a>

`serviceFactory` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.IServiceProvider](https://learn.microsoft.com/en-us/dotnet/api/system.iserviceprovider 'System\.IServiceProvider')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[TService](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.AddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.AddFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, System\.Func\<System\.IServiceProvider,TService\>, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.TService')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The factory function that creates instances of the service\.

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.AddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).factoryLifetime'></a>

`factoryLifetime` [Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.servicelifetime 'Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime')

The lifetime of the factory function itself\.

#### Returns
[Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection')  
The same [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection') for chaining\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
[services](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.AddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).services 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.AddFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, System\.Func\<System\.IServiceProvider,TService\>, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.services') or [serviceFactory](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.AddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).serviceFactory 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.AddFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, System\.Func\<System\.IServiceProvider,TService\>, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.serviceFactory') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

### Example

```csharp
services.AddFactoryFunc<IMyService>(
    sp => new MyService(sp.GetRequiredService<IDependency>()),
    ServiceLifetime.Singleton);
```

### Remarks
This overload wraps the provided [serviceFactory](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.AddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).serviceFactory 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.AddFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, System\.Func\<System\.IServiceProvider,TService\>, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.serviceFactory') in a parameter\-less function
that can be injected as [System\.Func&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')\.