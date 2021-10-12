using NUnit.Framework;

namespace Cake.Flutter.Tests.Build.Ios
{
    partial class Flutter
    {
        partial class Build
        {
            [TestFixture]
            public class Ipa
            {
                [Test]
                public void WithoutSettings_CommandIsCorrect()
                {
                    var fixture = new FlutterBuildIpaFixture
                    {
                        Settings = new FlutterBuildIpaSettings()
                    };

                    var actual = fixture.Run();
                    Assert.That(actual.Args, Is.EqualTo("build ipa"));
                }
                [Test]
                public void WithDevReleaseSettingsTypes_CommandIsCorrect()
                {
                    var fixture = new FlutterBuildIpaFixture
                    {
                        Settings = new FlutterBuildIpaSettings
                        {
                            Flavor = "dev",
                            Release = true,
                        }
                    };

                    var actual = fixture.Run();
                    Assert.That(actual.Args, Is.EqualTo(
                        "build ipa --flavor=\"dev\" --release"));
                }
                [Test]
                public void WithProductionReleaseSettingsTypes_CommandIsCorrect()
                {
                    var fixture = new FlutterBuildIpaFixture
                    {
                        Settings = new FlutterBuildIpaSettings
                        {
                            Flavor = "production",
                            Release = true,
                        }
                    };

                    var actual = fixture.Run();
                    Assert.That(actual.Args, Is.EqualTo(
                        "build ipa --flavor=\"production\" --release"));
                }
                [Test]
                public void WithDartDefine_CommandIsCorrect()
                {
                    var fixture = new FlutterBuildIpaFixture
                    {
                        Settings = new FlutterBuildIpaSettings
                        {
                            DartDefine = "test=xxx"
                        }
                    };

                    var actual = fixture.Run();
                    Assert.That(actual.Args, Is.EqualTo(
                        "build ipa --dart-define=\"test=xxx\""));
                }
            }
        }
    }
}
