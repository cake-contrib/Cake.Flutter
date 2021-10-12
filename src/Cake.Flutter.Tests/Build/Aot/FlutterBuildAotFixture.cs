namespace Cake.Flutter.Tests.Build.Aot
{
    public class FlutterBuildAotFixture : DefaultFixture<FlutterBuildAotSettings>
    {
        protected override void RunTool()
        {
            this.FlutterBuildAot(Settings);
        }
    }
}
