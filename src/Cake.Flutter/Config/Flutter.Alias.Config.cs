using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
	partial class FlutterAliases
	{
         /// <summary>
	    /// Configure Flutter settings.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void FlutterConfig(this ICakeContext context, FlutterConfigSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterConfigSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("config", settings ?? new FlutterConfigSettings());
		}


         /// <summary>
	    /// Configure Flutter settings.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> FlutterConfigWithResult(this ICakeContext context, FlutterConfigSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterConfigSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("config", settings ?? new FlutterConfigSettings());
		}

	}
}
