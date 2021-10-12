using System;
using Cake.Core;
using Cake.Core.Configuration;
using Cake.Core.Diagnostics;
using Cake.Core.IO;
using Cake.Core.Tooling;
using Cake.Testing.Fixtures;

namespace Cake.Flutter.Tests
{
    public abstract class DefaultFixture<T> : ToolFixture<T>, ICakeContext
        where T: ToolSettings, new()
    {
        public string[] Services { get; set; } = new string[0];
        IFileSystem ICakeContext.FileSystem => FileSystem;
        ICakeEnvironment ICakeContext.Environment => Environment;
        public ICakeLog Log => Log;
        ICakeArguments ICakeContext.Arguments => throw new NotImplementedException();
        IProcessRunner ICakeContext.ProcessRunner => ProcessRunner;
        public IRegistry Registry => Registry;
        public ICakeDataResolver Data => throw new NotImplementedException();
        ICakeConfiguration ICakeContext.Configuration => throw new NotImplementedException();
        public DefaultFixture() : base("flutter")
        {
            ProcessRunner.Process.SetStandardOutput(new string[] { });
        }
    }
}
