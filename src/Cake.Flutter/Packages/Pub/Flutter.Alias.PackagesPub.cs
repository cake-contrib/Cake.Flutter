using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
	partial class FlutterAliases
	{
         /// <summary>
	    /// Pass the remaining arguments to Dart's "pub" tool.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void FlutterPackagesPub(this ICakeContext context, FlutterPackagesPubSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterPackagesPubSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("packages pub", settings ?? new FlutterPackagesPubSettings());
		}


         /// <summary>
	    /// Pass the remaining arguments to Dart's "pub" tool.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> FlutterPackagesPubWithResult(this ICakeContext context, FlutterPackagesPubSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterPackagesPubSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("packages pub", settings ?? new FlutterPackagesPubSettings());
		}

	}
}
