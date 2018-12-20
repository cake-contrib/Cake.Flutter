using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
	partial class FlutterAliases
	{
         /// <summary>
	    /// Populates the Flutter tool's cache of binary artifacts.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void FlutterPrecache(this ICakeContext context, FlutterPrecacheSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterPrecacheSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("precache", settings ?? new FlutterPrecacheSettings());
		}


         /// <summary>
	    /// Populates the Flutter tool's cache of binary artifacts.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> FlutterPrecacheWithResult(this ICakeContext context, FlutterPrecacheSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterPrecacheSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("precache", settings ?? new FlutterPrecacheSettings());
		}

	}
}
