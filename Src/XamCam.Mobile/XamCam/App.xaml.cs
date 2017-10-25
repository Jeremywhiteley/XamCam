﻿using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Crashes;
using Microsoft.Azure.Mobile.Analytics;

using Plugin.MediaManager.Forms;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamCam
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class App : Application
	{
		public static double ScreenHeight;
		public static double ScreenWidth;

		public App()
		{
			var workaround = typeof(VideoView);

			InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
		}

		protected override void OnStart()
		{
			MobileCenter.Start("ios=396c3eac-7bc8-44de-b507-41a7e87707b3;" +
				   "uwp={Your UWP App secret here};" +
				   "android={android=a86ad258-90d3-4c91-b091-bd739613e6e7;}",
				   typeof(Analytics), typeof(Crashes));
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}