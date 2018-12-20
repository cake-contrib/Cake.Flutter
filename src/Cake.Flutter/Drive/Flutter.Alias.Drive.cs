using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
	partial class FlutterAliases
	{
         /// <summary>
	    /// Runs Flutter Driver tests for the current project.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void FlutterDrive(this ICakeContext context, FlutterDriveSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterDriveSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("drive", settings ?? new FlutterDriveSettings());
		}


         /// <summary>
	    /// Runs Flutter Driver tests for the current project.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> FlutterDriveWithResult(this ICakeContext context, FlutterDriveSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterDriveSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("drive", settings ?? new FlutterDriveSettings());
		}

	}
}
