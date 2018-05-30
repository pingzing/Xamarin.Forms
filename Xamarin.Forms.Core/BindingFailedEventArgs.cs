using System;

namespace Xamarin.Forms.Core
{
	public class BindingFailedEventArgs : EventArgs
	{
		public BindingFailedEventArgs(string bindingName, string bindingContext, Type targetType, string propertyName)
		{
			BindingName = bindingName;
			BindingContext = bindingContext;
			TargetType = targetType;
			PropertyName = propertyName;
		}

		public string BindingName { get; }
		public string BindingContext { get; }
		public Type TargetType { get; }
		public string PropertyName { get; }
	}
}