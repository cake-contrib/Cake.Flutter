using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TSettings"></typeparam>
    public class GenericRunner<TSettings> : FlutterTool<TSettings>
        where TSettings : AutoToolSettings, new()
    {
        readonly ICakeEnvironment cakeEnvironment;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileSystem"></param>
        /// <param name="environment"></param>
        /// <param name="processRunner"></param>
        /// <param name="tools"></param>
        public GenericRunner(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner, IToolLocator tools)
            : base(fileSystem, environment, processRunner, tools)
        {
            cakeEnvironment = environment;
        }

        /// <summary>
        /// Runs given <paramref name="command"/> using given <paramref name=" settings"/>.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="settings">The settings.</param>
        public void Run(string command, TSettings settings)
        {
            if (string.IsNullOrEmpty(command))
            {
                throw new ArgumentNullException(nameof(command));
            }
            if (settings == null)
            {
                throw new ArgumentNullException(nameof(settings));
            }
            Run(settings, GetArguments(cakeEnvironment, command, settings));
        }
        /// <summary>
        /// Runs given <paramref name="command"/> using given <paramref name=" settings"/> and returns the exit code and output.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="settings">The settings.</param>
        /// <returns>A output lines.</returns>
        public IEnumerable<string> RunWithResult(string command, TSettings settings)
        {
            if (string.IsNullOrEmpty(command))
            {
                throw new ArgumentNullException(nameof(command));
            }
            if (settings == null)
            {
                throw new ArgumentNullException(nameof(settings));
            }
            var process = RunProcess(settings, GetArguments(cakeEnvironment, command, settings), new ProcessSettings { RedirectStandardError = false, RedirectStandardOutput = true });
            process.WaitForExit();
            ProcessExitCode(process.GetExitCode());
            return process.GetStandardOutput(); ;
        }

        private ProcessArgumentBuilder GetArguments(ICakeEnvironment cakeEnvironment, string command, TSettings settings)
        {
            var builder = new ProcessArgumentBuilder();
            builder.AppendAll(cakeEnvironment, command, settings);
            return builder;
        }
    }
}
