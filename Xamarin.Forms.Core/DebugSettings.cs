using System;

namespace Xamarin.Forms.Core
{
	public static class DebugSettings
	{
		public static bool IsBindingTracingEnabled { get; set; }

		public delegate void BindingFailedEventHandler(Object sender, BindingFailedEventArgs e);

		public static event BindingFailedEventHandler BindingFailed;

		internal static void OnBindingFailed(Object sourceObject, string message)
		{
			if (!IsBindingTracingEnabled)
				return;

			BindingFailed?.Invoke(sourceObject, new BindingFailedEventArgs(message));
		}
	}
}