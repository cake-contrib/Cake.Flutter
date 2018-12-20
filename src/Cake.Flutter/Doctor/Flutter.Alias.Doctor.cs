using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
	partial class FlutterAliases
	{
         /// <summary>
	    /// Show information about the installed tooling.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void FlutterDoctor(this ICakeContext context, FlutterDoctorSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterDoctorSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("doctor", settings ?? new FlutterDoctorSettings());
		}


         /// <summary>
	    /// Show information about the installed tooling.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> FlutterDoctorWithResult(this ICakeContext context, FlutterDoctorSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterDoctorSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("doctor", settings ?? new FlutterDoctorSettings());
		}

	}
}
