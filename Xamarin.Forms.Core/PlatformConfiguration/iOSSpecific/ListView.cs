﻿namespace Xamarin.Forms.PlatformConfiguration.iOSSpecific
{
	using FormsElement = Forms.ListView;

	public static class ListView
	{
		public static readonly BindableProperty SeparatorStyleProperty = BindableProperty.Create(nameof(SeparatorStyle), typeof(SeparatorStyle), typeof(FormsElement), SeparatorStyle.Default);

		public static SeparatorStyle GetSeparatorStyle(BindableObject element)
		{
			return (SeparatorStyle)element.GetValue(SeparatorStyleProperty);
		}

		public static void SetSeparatorStyle(BindableObject element, SeparatorStyle value)
		{
			element.SetValue(SeparatorStyleProperty, value);
		}

		public static SeparatorStyle GetSeparatorStyle(this IPlatformElementConfiguration<iOS, FormsElement> config)
		{
			return GetSeparatorStyle(config.Element);
		}

		public static IPlatformElementConfiguration<iOS, FormsElement> SetSeparatorStyle(this IPlatformElementConfiguration<iOS, FormsElement> config, SeparatorStyle value)
		{
			SetSeparatorStyle(config.Element, value);
			return config;
		}

		public static readonly BindableProperty GroupHeaderStyleProperty = BindableProperty.Create(nameof(GroupHeaderStyle), typeof(GroupHeaderStyle), typeof(FormsElement), GroupHeaderStyle.Plain);

		public static GroupHeaderStyle GetGroupHeaderStyle(BindableObject element)
		{
			return (GroupHeaderStyle)element.GetValue(GroupHeaderStyleProperty);
		}

		public static void SetGroupHeaderStyle(BindableObject element, GroupHeaderStyle value)
		{
			element.SetValue(GroupHeaderStyleProperty, value);
		}

		public static GroupHeaderStyle GetGroupHeaderStyle(this IPlatformElementConfiguration<iOS, FormsElement> config)
		{
			return GetGroupHeaderStyle(config.Element);
		}

		public static IPlatformElementConfiguration<iOS, FormsElement> SetGroupHeaderStyle(this IPlatformElementConfiguration<iOS, FormsElement> config, GroupHeaderStyle value)
		{
			SetGroupHeaderStyle(config.Element, value);
			return config;
		}
	}
}