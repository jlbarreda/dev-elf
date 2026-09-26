#### [DevElf](README.md 'README')
### [DevElf\.DependencyInjection](DevElf.DependencyInjection.md 'DevElf\.DependencyInjection').[ServiceCollectionExtensions](ServiceCollectionExtensions.md 'DevElf\.DependencyInjection\.ServiceCollectionExtensions')

## ServiceCollectionExtensions\.TryAddFactoryFunc Method

| Overloads | |
| :--- | :--- |
| [TryAddFactoryFunc&lt;TService&gt;\(this IServiceCollection, ServiceLifetime\)](ServiceCollectionExtensions.TryAddFactoryFunc.md#DevElf.DependencyInjection.ServiceCollectionExtensions.TryAddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime) 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.TryAddFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)') | Tries to register a factory function \([System\.Func&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')\) with the specified lifetime  \(if not already registered\) that resolves instances of [TService](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.TryAddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.TryAddFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.TService') from the service provider\. |
| [TryAddFactoryFunc&lt;TService&gt;\(this IServiceCollection, Func&lt;IServiceProvider,TService&gt;, ServiceLifetime\)](ServiceCollectionExtensions.TryAddFactoryFunc.md#DevElf.DependencyInjection.ServiceCollectionExtensions.TryAddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime) 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.TryAddFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, System\.Func\<System\.IServiceProvider,TService\>, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)') | Tries to register a factory function \([System\.Func&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')\) with the specified lifetime  \(if not already registered\) that wraps a custom service factory for creating instances of [TService](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.TryAddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.TryAddFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, System\.Func\<System\.IServiceProvider,TService\>, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.TService')\. |

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.TryAddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime)'></a>

## ServiceCollectionExtensions\.TryAddFactoryFunc\<TService\>\(this IServiceCollection, ServiceLifetime\) Method

Tries to register a factory function \([System\.Func&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')\) with the specified lifetime 
\(if not already registered\) that resolves instances of [TService](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.TryAddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.TryAddFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.TService') from the service provider\.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection TryAddFactoryFunc<TService>(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.DependencyInjection.ServiceLifetime factoryLifetime)
    where TService : class;
```
#### Type parameters

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.TryAddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService'></a>

`TService`

The type of service the factory will create\. Must be a class\.
#### Parameters

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.TryAddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).services'></a>

`services` [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection')

The [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection') to add the factory to\.

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.TryAddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).factoryLifetime'></a>

`factoryLifetime` [Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.servicelifetime 'Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime')

The lifetime of the factory function itself\.

#### Returns
[Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection')  
The same [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection') for chaining\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
[services](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.TryAddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime).services 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.TryAddFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.services') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

### Remarks
This method only registers the factory if no factory of type [System\.Func&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1') 
has been registered yet\.

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.TryAddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime)'></a>

## ServiceCollectionExtensions\.TryAddFactoryFunc\<TService\>\(this IServiceCollection, Func\<IServiceProvider,TService\>, ServiceLifetime\) Method

Tries to register a factory function \([System\.Func&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')\) with the specified lifetime 
\(if not already registered\) that wraps a custom service factory for creating instances of [TService](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.TryAddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.TryAddFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, System\.Func\<System\.IServiceProvider,TService\>, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.TService')\.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection TryAddFactoryFunc<TService>(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Func<System.IServiceProvider,TService> serviceFactory, Microsoft.Extensions.DependencyInjection.ServiceLifetime factoryLifetime)
    where TService : class;
```
#### Type parameters

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.TryAddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService'></a>

`TService`

The type of service the factory will create\. Must be a class\.
#### Parameters

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.TryAddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).services'></a>

`services` [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection')

The [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection') to add the factory to\.

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.TryAddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).serviceFactory'></a>

`serviceFactory` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.IServiceProvider](https://learn.microsoft.com/en-us/dotnet/api/system.iserviceprovider 'System\.IServiceProvider')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[TService](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.TryAddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).TService 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.TryAddFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, System\.Func\<System\.IServiceProvider,TService\>, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.TService')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The factory function that creates instances of the service\.

<a name='DevElf.DependencyInjection.ServiceCollectionExtensions.TryAddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).factoryLifetime'></a>

`factoryLifetime` [Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.servicelifetime 'Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime')

The lifetime of the factory function itself\.

#### Returns
[Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection')  
The same [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection') for chaining\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
[services](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.TryAddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).services 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.TryAddFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, System\.Func\<System\.IServiceProvider,TService\>, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.services') or [serviceFactory](ServiceCollectionExtensions.md#DevElf.DependencyInjection.ServiceCollectionExtensions.TryAddFactoryFunc_TService_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Func_System.IServiceProvider,TService_,Microsoft.Extensions.DependencyInjection.ServiceLifetime).serviceFactory 'DevElf\.DependencyInjection\.ServiceCollectionExtensions\.TryAddFactoryFunc\<TService\>\(this Microsoft\.Extensions\.DependencyInjection\.IServiceCollection, System\.Func\<System\.IServiceProvider,TService\>, Microsoft\.Extensions\.DependencyInjection\.ServiceLifetime\)\.serviceFactory') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

### Remarks
This method only registers the factory if no factory of type [System\.Func&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1') 
has been registered yet\.