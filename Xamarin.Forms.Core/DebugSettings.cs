using System;
using System.Diagnostics;

namespace Xamarin.Forms.Core
{
	public static class DebugSettings
	{
		internal const string PropertyNotFoundErrorMessage = "'{0}' property not found on '{1}', target property: '{2}.{3}'";

		public static bool IsBindingTracingEnabled { get; set; }

		public delegate void BindingFailedEventHandler (Object sender, BindingFailedEventArgs e);

		public static event BindingFailedEventHandler BindingFailed;

		internal static void OnBindingFailed (object sourceObject, string bindingName, string bindingContext, Type targetType, string propertyName)
		{
			if (!IsBindingTracingEnabled)
				return;

			var composedPropertyNotFoundMessage = string.Format (PropertyNotFoundErrorMessage, bindingName, bindingContext,targetType, propertyName);
			Debug.WriteLine (composedPropertyNotFoundMessage);

			BindingFailed?.Invoke (sourceObject, new BindingFailedEventArgs(bindingName, bindingContext, targetType, propertyName));
		}
	}
}