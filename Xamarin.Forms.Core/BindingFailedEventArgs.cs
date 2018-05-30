using System;

namespace Xamarin.Forms.Core
{
	public class BindingFailedEventArgs : EventArgs
	{
		public BindingFailedEventArgs(string message)
		{
			Message = message;
		}

		public string Message { get; set; }
	}
}