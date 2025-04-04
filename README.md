﻿# Intercom API client library for .NET
![Nuget](https://img.shields.io/nuget/v/intercom-net)
![Nuget](https://img.shields.io/nuget/dt/intercom-net)

## Supported APIs

## Install
[https://www.nuget.org/packages/Intercom](https://www.nuget.org/packages/intercom-net)

## Usage
> For the full documentation please read our [wiki](https://github.com/gonace/intercom/wiki)!

### Simple
> If you're using .NET (former .NET Core) and utilizing the default hosting and startup pattern (`Microsoft.Extensions.Hosting`) you use [`Intercom.Extensions.Hosting`](https://github.com/gonace/Intercom.Extensions.Hosting).

The easiest way to use the client is to run `.Configure()`, this will create a static instance (`Intercom`) of the client that can be used throughout your application.

The `Configure()` method can be initiated in two ways,
* `Intercom.Configure("baseUri", "bearerToken")`
* `Intercom.Configure("baseUri", "bearerToken", apiVersion)`

#### Examples
```c#
using Intercom.Constants;
using Intercom.Models;
using Intercom.Request.Companies;

Intercom.Configure(Url.Production, "bearerToken");

var company = new Company
{
    Name = "Obscured",
    CompanyId = "Obscured_1",
    Plan = new Plan
    {
        Name = "Enterprise"
    },
    Size = 10,
    Attributes = new Dictionary<string, object>
    {
        {"foo", "bar"},
        {"bar", "foo"}
    }
};
var request = new UpsertRequest(company);
var response = Intercom.Companies.Upsert(request)

```
```c#
using Intercom.Constants;
using Intercom.Models;
using Intercom.Request.Companies;

Intercom.Configure(Url.Production, "bearerToken", Version.Latest)

var company = new Company
{
    Name = "Obscured",
    CompanyId = "Obscured_1",
    Plan = new Plan
    {
        Name = "Enterprise"
    },
    Size = 10,
    Attributes = new Dictionary<string, object>
    {
        {"foo", "bar"},
        {"bar", "foo"}
    }
};
var request = new UpsertRequest(company);
var response = Intercom.Companies.Upsert(request)
```

### Advanced
If you only need access to one (or a few) clients you're able to configure each client individually.

#### Examples
```c#
using Intercom.Constants;
using Intercom.Models;
using Intercom.Request.Companies;

public class SomeClass
{
    private readonly ICompaniesClient _client;

    public SomeClass()
    {
        _client = new CompaniesClient(Url.Production, "bearerToken")
    }

    public Company Upsert()
    {
        var company = new Company
        {
            Name = "Obscured",
            CompanyId = "Obscured_1",
            Plan = new Plan
            {
                Name = "Enterprise"
            },
            Size = 10,
            Attributes = new Dictionary<string, object>
            {
                {"foo", "bar"},
                {"bar", "foo"}
            }
        };
        var request = new UpsertRequest(company);
        var response = Intercom.Companies.Upsert(request)

        return response;
    }

    public async Task<Company> UpsertAsync()
    {
        var company = new Company
        {
            Name = "Obscured",
            CompanyId = "Obscured_1",
            Plan = new Plan
            {
                Name = "Enterprise"
            },
            Size = 10,
            Attributes = new Dictionary<string, object>
            {
                {"foo", "bar"},
                {"bar", "foo"}
            }
        };
        var request = new UpsertRequest(company);
        var response = await Intercom.Companies.UpsertAsync(request)

        return response;
    }
}
```

```c#
using Intercom.Constants;
using Intercom.Models;
using Intercom.Request.Companies;

public class SomeClass
{
    private readonly ICompaniesClient _client;

    public SomeClass()
    {
        _client = new CompaniesClient(Url.Production, "bearerToken", Version.Latest)
    }
    
    public Company Upsert()
    {
        var company = new Company
        {
            Name = "Obscured",
            CompanyId = "Obscured_1",
            Plan = new Plan
            {
                Name = "Enterprise"
            },
            Size = 10,
            Attributes = new Dictionary<string, object>
            {
                {"foo", "bar"},
                {"bar", "foo"}
            }
        };
        var request = new UpsertRequest(company);
        var response = Intercom.Companies.Upsert(request)

        return response;
    }

    public async Task<Company> UpsertAsync()
    {
        var company = new Company
        {
            Name = "Obscured",
            CompanyId = "Obscured_1",
            Plan = new Plan
            {
                Name = "Enterprise"
            },
            Size = 10,
            Attributes = new Dictionary<string, object>
            {
                {"foo", "bar"},
                {"bar", "foo"}
            }
        };
        var request = new UpsertRequest(company);
        var response = await Intercom.Companies.UpsertAsync(request)

        return response;
    }
}
```

### Constants
#### Url
The url constant is used to identify what production environment that will be used.

* `Production => "https://api.intercom.io/"`
* `ProductionAustralia => "https://api.au.intercom.io/"`
* `ProductionEurope => "https://api.eu.intercom.io/"` 


#### Version
The version constant is used to identify what Intercom API version (Intercom-Version header) will be used, `Latest` always points to the highest available.

 * `Latest`
 * `Version_2_9`
 * `Version_2_8`
 * `Version_2_7`

## Development
### TODO

## Contributing
Pull requests and features are happily considered! By participating in this project you agree to abide by the [Code of Conduct](http://contributor-covenant.org/version/2/0).

### To contribute

Fork, then clone the repo:
```
git clone git@github.com:your-username/Intercom.git
```
Push to your fork and [submit a pull request](https://github.com/gonace/Intercom/compare/)
