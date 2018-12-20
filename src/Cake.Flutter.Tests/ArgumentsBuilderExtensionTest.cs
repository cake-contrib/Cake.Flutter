using NUnit.Framework;

namespace Cake.Flutter.Tests
{
    public class ArgumentsBuilderExtensionTest
    {
        [TestFixture]
        public class GetArgumentForEnumValue
        {
            [TestCase(Template.App, ExpectedResult = "app")]
            [TestCase(Template.Package, ExpectedResult = "package")]
            [TestCase(Template.Plugin, ExpectedResult = "plugin")]
            public string TestTemplateValues(Template value)
            {
                return ArgumentsBuilderExtension.GetArgumentForEnumValue(value);
            }
            [TestCase(TargetPlatform.AndroidArm, ExpectedResult = "android-arm")]
            [TestCase(TargetPlatform.AndroidArm64, ExpectedResult = "android-arm64")]
            [TestCase(TargetPlatform.Ios, ExpectedResult = "ios")]
            public string TestTestPlatformValues(TargetPlatform value)
            {
                return ArgumentsBuilderExtension.GetArgumentForEnumValue(value);
            }
        }
    }
}
