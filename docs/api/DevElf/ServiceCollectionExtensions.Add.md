#### [DevElf](README.md 'README')
### [DevElf\.DependencyInjection](DevElf.DependencyInjection.md 'DevElf\.DependencyInjection').[ServiceCollectionExtensions](ServiceCollectionExtensions.md 'DevElf\.DependencyInjection\.ServiceCollectionExtensions')

## ServiceCollectionExtensions\.Add Method

| Overloads | |
| :--- | :--- |
| [Add&lt;TService,TImplementation&gt;\(this IServiceCollection, ServiceLifetime\)](ServiceCollectionExtensions.Add.md#DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService,TImplementation_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime) 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.Add\<TService,TImplementation\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)') | Registers a service of type [TService](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService,TImplementation_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.Add\<TService,TImplementation\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.TService') with an implementation type  of [TImplementation](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService,TImplementation_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TImplementation 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.Add\<TService,TImplementation\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.TImplementation') using the specified lifetime\. |
| [Add&lt;TService&gt;\(this IServiceCollection, ServiceLifetime\)](ServiceCollectionExtensions.Add.md#DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime) 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.Add\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)') | Registers a service of type [TService](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.Add\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.TService') with itself as the implementation  type using the specified lifetime\. |
| [Add&lt;TService&gt;\(this IServiceCollection, Func&lt;IServiceProvider,TService&gt;, ServiceLifetime\)](ServiceCollectionExtensions.Add.md#DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime) 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.Add\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, System\.Func\<System\.IServiceProvider,TService\>, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)') | Registers a service of type [TService](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.Add\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, System\.Func\<System\.IServiceProvider,TService\>, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.TService') using a factory function  with the specified lifetime\. |

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService,TImplementation_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime)'></a>

## ServiceCollectionExtensions\.Add\<TService,TImplementation\>\(this IServiceCollection, ServiceLifetime\) Method

Registers a service of type [TService](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService,TImplementation_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.Add\<TService,TImplementation\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.TService') with an implementation type 
of [TImplementation](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService,TImplementation_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TImplementation 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.Add\<TService,TImplementation\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.TImplementation') using the specified lifetime\.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection Add<TService,TImplementation>(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.DependencyInjection.ServiceLifetime lifetime)
    where TService : class
    where TImplementation : TService;
```
#### Type parameters

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService,TImplementation_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService'></a>

`TService`

The service type to register\. Must be a class\.

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService,TImplementation_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TImplementation'></a>

`TImplementation`

The implementation type that implements [TService](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService,TImplementation_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.Add\<TService,TImplementation\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.TService')\.
#### Parameters

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService,TImplementation_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).services'></a>

`services` [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection')

The [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection') to add the service to\.

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService,TImplementation_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).lifetime'></a>

`lifetime` [Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.servicelifetime 'Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime')

The lifetime of the service\.

#### Returns
[Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection')  
The same [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection') for chaining\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
[services](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService,TImplementation_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).services 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.Add\<TService,TImplementation\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.services') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

### Example

```csharp
services.Add<IMyService, MyServiceImpl>(ServiceLifetime.Singleton);
```

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime)'></a>

## ServiceCollectionExtensions\.Add\<TService\>\(this IServiceCollection, ServiceLifetime\) Method

Registers a service of type [TService](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.Add\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.TService') with itself as the implementation 
type using the specified lifetime\.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection Add<TService>(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.DependencyInjection.ServiceLifetime lifetime)
    where TService : class;
```
#### Type parameters

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService'></a>

`TService`

The type of service to register\. Must be a class\.
#### Parameters

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).services'></a>

`services` [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection')

The [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection') to add the service to\.

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).lifetime'></a>

`lifetime` [Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.servicelifetime 'Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime')

The lifetime of the service\.

#### Returns
[Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection')  
The same [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection') for chaining\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
[services](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).services 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.Add\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.services') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

### Example

```csharp
services.Add<MyService>(ServiceLifetime.Transient);
```

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime)'></a>

## ServiceCollectionExtensions\.Add\<TService\>\(this IServiceCollection, Func\<IServiceProvider,TService\>, ServiceLifetime\) Method

Registers a service of type [TService](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.Add\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, System\.Func\<System\.IServiceProvider,TService\>, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.TService') using a factory function 
with the specified lifetime\.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection Add<TService>(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Func<System.IServiceProvider,TService> serviceFactory, Microsoft.Extensions.DependencyInjection.ServiceLifetime lifetime)
    where TService : class;
```
#### Type parameters

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService'></a>

`TService`

The type of service to register\. Must be a class\.
#### Parameters

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).services'></a>

`services` [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection')

The [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection') to add the service to\.

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).serviceFactory'></a>

`serviceFactory` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.IServiceProvider](https://learn.microsoft.com/en-us/dotnet/api/system.iserviceprovider 'System\.IServiceProvider')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[TService](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.Add\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, System\.Func\<System\.IServiceProvider,TService\>, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.TService')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The factory function that creates instances of the service\.

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).lifetime'></a>

`lifetime` [Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.servicelifetime 'Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime')

The lifetime of the service\.

#### Returns
[Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection')  
The same [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection') for chaining\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
[services](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).services 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.Add\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, System\.Func\<System\.IServiceProvider,TService\>, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.services') or [serviceFactory](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.Add_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).serviceFactory 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.Add\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, System\.Func\<System\.IServiceProvider,TService\>, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.serviceFactory') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

### Example

```csharp
services.Add<IMyService>(
    sp => new MyService(sp.GetRequiredService<IDependency>()),
    ServiceLifetime.Scoped);
```