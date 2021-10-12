namespace Cake.Flutter.Tests.Build.Ios
{
    public class FlutterBuildIosFixture : DefaultFixture<FlutterBuildIosSettings>
    {
        protected override void RunTool()
        {
            this.FlutterBuildIos(Settings);
        }
    }
}
