using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
	partial class FlutterAliases
	{
         /// <summary>
	    /// Output command line shell completion setup scripts.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void FlutterBashCompletion(this ICakeContext context, FlutterBashCompletionSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterBashCompletionSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("bash-completion", settings ?? new FlutterBashCompletionSettings());
		}


         /// <summary>
	    /// Output command line shell completion setup scripts.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> FlutterBashCompletionWithResult(this ICakeContext context, FlutterBashCompletionSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterBashCompletionSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("bash-completion", settings ?? new FlutterBashCompletionSettings());
		}

	}
}
