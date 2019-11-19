<img src="https://raw.githubusercontent.com/michielpost/TreintijdenApi/master/logo.png" height="150"> [![Build status](https://ci.appveyor.com/api/projects/status/8hgow8ouixxx0n4h/branch/master?svg=true)](https://ci.appveyor.com/project/michielpost/treintijdenapi/branch/master)
# TreintijdenApi
Treintijden API voor de NS API - Nederlandse Spoorwegen

C# .Net Core client voor de nieuwe NS API 
https://apiportal.ns.nl/

Partial support for internal API:
https://developer.ns.nl/

## How To install?
Download the source from GitHub or get the compiled assembly from NuGet [TreintijdenApi on NuGet](https://nuget.org/packages/TreintijdenApi).

## Example Usage
Check the sample app for sample usage of all API methods.

```cs
var client = TreintijdenClient<ITreinAPi>.GetClient("YOUR_API_KEY"); //Available: ITreinApi, IPriceApi, IVirtualTrainApi

var delftArrivals = await _client.GetArrivals("Dt");
```

## License

TreintijdenAPI is licensed under [MIT](http://www.opensource.org/licenses/mit-license.php "Read more about the MIT license form"). Refer to [LICENSE](https://github.com/michielpost/TreintijdenAPI/blob/master/LICENSE) for more information.

## Contributions

Contributions are welcome. Fork this repository and send a pull request if you have something useful to add.

### Open Source Project Credits
This library uses RestEase https://github.com/canton7/RestEase

