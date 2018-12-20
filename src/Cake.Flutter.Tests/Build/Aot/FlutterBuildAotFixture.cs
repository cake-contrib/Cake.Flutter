using Cake.Core;
using Cake.Core.Diagnostics;
using Cake.Core.IO;
using Cake.Core.Tooling;
using Cake.Testing.Fixtures;
using NSubstitute;
using System;

namespace Cake.Flutter.Tests.Build.Aot
{
    public class FlutterBuildAotFixture : ToolFixture<FlutterBuildAotSettings>, ICakeContext
    {
        public string Path { get; set; }
        IFileSystem fileSystem;
        ICakeEnvironment environment;
        IFileSystem ICakeContext.FileSystem => fileSystem;
        ICakeEnvironment ICakeContext.Environment => environment;
        public ICakeLog Log => Log;
        ICakeArguments ICakeContext.Arguments => throw new NotImplementedException();
        IProcessRunner ICakeContext.ProcessRunner => ProcessRunner;
        public IRegistry Registry => Registry;
        public ICakeDataResolver Data => throw new NotImplementedException();
        public FlutterBuildAotFixture() : base("flutter")
        {
            Tools = Substitute.For<IToolLocator>();
            fileSystem = Substitute.For<IFileSystem>();
            environment = Substitute.For<ICakeEnvironment>();
            var toolPath = new FilePath("flutter");
            var file = Substitute.For<IFile>();
            file.Exists.Returns(true);
            fileSystem.GetFile(toolPath).Returns(file);
            environment.WorkingDirectory.Returns("C:/Temp");
            Tools.Resolve("flutter").Returns(toolPath);
            ProcessRunner.Process.SetStandardOutput(new string[] { });
        }
        protected override void RunTool()
        {
            this.FlutterBuildAot(Settings);
        }
    }
}
