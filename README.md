<img src="https://raw.githubusercontent.com/michielpost/TreintijdenApi/master/logo.png" height="150"> [![Build status](https://ci.appveyor.com/api/projects/status/k209wg02y7adyp1j/branch/master?svg=true)](https://ci.appveyor.com/project/michielpost/treintijdenapi/branch/master)
# TreintijdenApi
Treintijden API voor de NS API - Nederlandse Spoorwegen

C# .Net Core client voor de nieuwe NS API

## How To install?
Download the source from GitHub or get the compiled assembly from NuGet [TreintijdenApi on NuGet](https://nuget.org/packages/TreintijdenApi).

## Example Usage
Check the sample app for sample usage of all API methods.

```cs
var client = TreintijdenClient.GetClient("YOUR_API_KEY");

var delftArrivals = await _client.GetArrivals("Dt");
```

## License

TreintijdenAPI is licensed under [MIT](http://www.opensource.org/licenses/mit-license.php "Read more about the MIT license form"). Refer to [LICENSE](https://github.com/michielpost/TreintijdenAPI/blob/master/LICENSE) for more information.

## Contributions

Contributions are welcome. Fork this repository and send a pull request if you have something useful to add.

### Open Source Project Credits
This library uses RestEase https://github.com/canton7/RestEase

