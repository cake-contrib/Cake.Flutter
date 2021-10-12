using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
	partial class FlutterAliases
	{
         /// <summary>
	    /// Build an iOS application bundle (Mac OS X host only).
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void FlutterBuildIpa(this ICakeContext context, FlutterBuildIpaSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterBuildIpaSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("build ipa", settings ?? new FlutterBuildIpaSettings());
		}


         /// <summary>
	    /// Build an iOS application bundle (Mac OS X host only).
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> FlutterBuildIpaWithResult(this ICakeContext context, FlutterBuildIpaSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterBuildIpaSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("build ipa", settings ?? new FlutterBuildIpaSettings());
		}

	}
}
