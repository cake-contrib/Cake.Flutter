using NUnit.Framework;

namespace Cake.Flutter.Tests.Build.Ios
{
    partial class Flutter
    {
        partial class Build
        {
            [TestFixture]
            public class Ios
            {
                [Test]
                public void WithoutSettings_CommandIsCorrect()
                {
                    var fixture = new FlutterBuildIosFixture
                    {
                        Settings = new FlutterBuildIosSettings()
                    };

                    var actual = fixture.Run();
                    Assert.That(actual.Args, Is.EqualTo("build ios"));
                }
                [Test]
                public void WithDifferentSettingsTypes_CommandIsCorrect()
                {
                    var fixture = new FlutterBuildIosFixture
                    {
                        Settings = new FlutterBuildIosSettings
                        {
                            Flavor = "dev",
                            Release = true,
                        }
                    };

                    var actual = fixture.Run();
                    Assert.That(actual.Args, Is.EqualTo(
                        "build ios --flavor=\"dev\" --release"));
                }
            }
        }
    }
}
