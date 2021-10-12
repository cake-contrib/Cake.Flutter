namespace Cake.Flutter.Tests.Build.Apk
{
    public class FlutterBuildApkFixture : DefaultFixture<FlutterBuildApkSettings>
    { 
        protected override void RunTool()
        {
            this.FlutterBuildApk(Settings);
        }
    }
}
