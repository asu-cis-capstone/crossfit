using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using System.Drawing;
using MonoTouch.ObjCRuntime;

namespace WodstarMobileapp.iOS
{
	[Register("login")]
	public partial class login : UIView
	{
		public login() {
			var loginLayout = NSBundle.MainBundle.LoadNib("login", this, null);
			var layout = Runtime.GetNSObject (loginLayout.ValueAt (0)) as UIView;
			layout.Frame = new System.Drawing.RectangleF(0,0, Frame.Width, Frame.Height);
			AddSubview(layout);
			helloWorldLabel.Text = "Edited text worked";
	}
}

}

