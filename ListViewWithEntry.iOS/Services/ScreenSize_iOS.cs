using CoreGraphics;
using UIKit;

using ListViewWithEntry.iOS;

using Xamarin.Forms;

[assembly: Dependency(typeof(ScreenSize_iOS))]
namespace ListViewWithEntry.iOS
{
	public class ScreenSize_iOS : IScreenSize
	{
		#region Fields
		CGRect _screenSize;
		#endregion

		#region Properties
		CGRect ScreenSize => _screenSize.Equals(default(CGRect)) ? _screenSize = UIScreen.MainScreen.Bounds : _screenSize;
		#endregion

		#region Methods
		public double GetScreenHeight() => ScreenSize.Height;

		public double GetScreenWidth() => ScreenSize.Width;
		#endregion
	}
}
