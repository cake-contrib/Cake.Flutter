using Cake.Core.IO;
using NUnit.Framework;

namespace Cake.Flutter.Tests.Build.Apk
{
    partial class Flutter
    {
        partial class Build
        {
            [TestFixture]
            public class Apk
            {
                [Test]
                public void WithoutSettings_CommandIsCorrect()
                {
                    var fixture = new FlutterBuildApkFixture
                    {
                        Settings = new FlutterBuildApkSettings()
                    };

                    var actual = fixture.Run();
                    Assert.That(actual.Args, Is.EqualTo("build apk"));
                }
                [Test]
                public void WithDifferentSettingsTypes_CommandIsCorrect()
                {
                    var fixture = new FlutterBuildApkFixture
                    {
                        Settings = new FlutterBuildApkSettings
                        {
                            Flavor = "dev",
                            Release = true,
                        }
                    };

                    var actual = fixture.Run();
                    Assert.That(actual.Args, Is.EqualTo(
                        "build apk --release --flavor=\"dev\""));
                }
            }
        }
    }
}
