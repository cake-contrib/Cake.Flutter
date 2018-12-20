using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
	partial class FlutterAliases
	{
         /// <summary>
	    /// Moves host apps from generated directories to non-generated directories so that they can be edited by developers.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void FlutterMakeHostAppEditable(this ICakeContext context, FlutterMakeHostAppEditableSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterMakeHostAppEditableSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("make-host-app-editable", settings ?? new FlutterMakeHostAppEditableSettings());
		}


         /// <summary>
	    /// Moves host apps from generated directories to non-generated directories so that they can be edited by developers.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> FlutterMakeHostAppEditableWithResult(this ICakeContext context, FlutterMakeHostAppEditableSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterMakeHostAppEditableSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("make-host-app-editable", settings ?? new FlutterMakeHostAppEditableSettings());
		}

	}
}
