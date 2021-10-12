namespace Cake.Flutter.Tests.Build.Ios
{
    public class FlutterBuildIpaFixture : DefaultFixture<FlutterBuildIpaSettings>
    { 
        protected override void RunTool()
        {
            this.FlutterBuildIpa(Settings);
        }
    }
}
