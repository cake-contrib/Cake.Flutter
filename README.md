# Cake.Flutter

A Cake AddIn that extends Cake with [Flutter](https://flutter.io/) command tools.

[![cakebuild.net](https://img.shields.io/badge/WWW-cakebuild.net-blue.svg)](http://cakebuild.net/)
[![NuGet](https://img.shields.io/nuget/v/Cake.Flutter.svg)](https://www.nuget.org/packages/Cake.Flutter)
[![Build status](https://ci.appveyor.com/api/projects/status/vi07dth3d1gek7ak?svg=true)](https://ci.appveyor.com/project/cakecontrib/cake-flutter)

## Important

0.1.1 Supports Cake 0.33+

0.1.0 Supports Cake 0.28+, .NET Standard 2.0+ and .NET 4.6.1+.

## Including addin
Including addin in cake script is easy.
```
#addin "Cake.Flutter"
```
## Usage

To use the addin just add it to Cake call the aliases and configure any settings you want.

```csharp
#addin "Cake.Flutter"

...

// How to login using a token
Task("BuildAot")
	.Does(() => {
		// or more containers at once
		FlutterBuildAot(new FlutterBuildAotSettings());
	)};
```
Other commands follow same convention.

This version is built against Flutter version 2.1.0.

## Credits

Brought to you by [Miha Markic](https://github.com/MihaMarkic) ([@MihaMarkic](https://twitter.com/MihaMarkic/)) and contributors.