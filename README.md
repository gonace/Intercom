# Intercom API client library for .NET
![Nuget](https://img.shields.io/nuget/v/intercom-net)
![Nuget](https://img.shields.io/nuget/dt/intercom-net)

## Supported APIs

## Install
You can download the intercom client nuget.
[https://www.nuget.org/packages/Intercom](https://www.nuget.org/packages/intercom-net)

## Usage
> For the full documentation please read our [wiki](https://github.com/gonace/intercom/wiki)!

```c#
Intercom.Configure("baseUri", "bearerToken")

Intercom.Companies...
Intercom.Me...
```

```c#
public class SomeClass
{
    private readonly ICompaniesClient _client;

    public SomeClass()
    {
        _client = new CompaniesClient("baseUri", "bearerToken")
    }
}
```

```c#
```

## Development
### TODO

## Contributing
Pull requests and features are happily considered! By participating in this project you agree to abide by the [Code of Conduct](http://contributor-covenant.org/version/2/0).

### To contribute

Fork, then clone the repo:
```
git clone git@github.com:your-username/intercom.git
```
Push to your fork and [submit a pull request](https://github.com/gonace/intercom/compare/)
