using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
	partial class FlutterAliases
	{
         /// <summary>
	    /// Format one or more dart files.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void FlutterFormat(this ICakeContext context, FlutterFormatSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterFormatSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("format", settings ?? new FlutterFormatSettings());
		}


         /// <summary>
	    /// Format one or more dart files.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> FlutterFormatWithResult(this ICakeContext context, FlutterFormatSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterFormatSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("format", settings ?? new FlutterFormatSettings());
		}

	}
}
