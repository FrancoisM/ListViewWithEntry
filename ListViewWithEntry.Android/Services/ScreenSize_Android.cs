using System;

using Android.Util;

using ListViewWithEntry.Droid;

using Plugin.CurrentActivity;

using Xamarin.Forms;

[assembly: Dependency(typeof(ScreenSize_Android))]
namespace ListViewWithEntry.Droid
{
	public class ScreenSize_Android : IScreenSize
	{
		#region Constnat Fields
		readonly Lazy<DisplayMetrics> _displayMetricsHolder = new Lazy<DisplayMetrics>(() =>
		{
			var displayMetrics = new DisplayMetrics();
			CrossCurrentActivity.Current.Activity.WindowManager.DefaultDisplay.GetMetrics(displayMetrics);

			return displayMetrics;
		});
		#endregion

		#region Properties
		DisplayMetrics DisplayMetrics => _displayMetricsHolder.Value;
		#endregion

		#region Methods
		public double GetScreenHeight() => DisplayMetrics.HeightPixels;
		public double GetScreenWidth() => DisplayMetrics.WidthPixels;
		#endregion
	}
}
