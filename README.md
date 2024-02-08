# Cake.Flutter

A Cake AddIn that extends Cake with [Flutter](https://flutter.io/) command tools.

[![cakebuild.net](https://img.shields.io/badge/WWW-cakebuild.net-blue.svg)](http://cakebuild.net/)
[![NuGet](https://img.shields.io/nuget/v/Cake.Flutter.svg)](https://www.nuget.org/packages/Cake.Flutter)

|Branch|Status|
|------|------|
|Master|[![Build status](https://ci.appveyor.com/api/projects/status/github/cake-contrib/Cake.Flutter?branch=master&svg=true)](https://ci.appveyor.com/project/cakecontrib/cake-flutter)|
|Develop|[![Build status](https://ci.appveyor.com/api/projects/status/github/cake-contrib/Cake.Flutter?branch=develop&svg=true)](https://ci.appveyor.com/project/cakecontrib/cake-flutter)|

## Important

1.2.0 References Cake 4.0.0, targets .net 6+

1.0.0 References Cake 1.0.0

0.1.1 References Cake 0.33+

0.1.0 References Cake 0.28+, .NET Standard 2.0+ and .NET 4.6.1+.

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

## Discussion

If you have questions, search for an existing one, or create a new discussion on the Cake GitHub repository, using the `extension-q-a` category.

[![Join in the discussion on the Cake repository](https://img.shields.io/badge/GitHub-Discussions-green?logo=github)](https://github.com/cake-build/cake/discussions/categories/extension-q-a)

## Credits

Brought to you by [Miha Markic](https://github.com/MihaMarkic) and contributors. 

![Mastodon Follow](https://img.shields.io/mastodon/follow/001030236)