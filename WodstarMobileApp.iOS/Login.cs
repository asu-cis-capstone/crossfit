using System;
using MonoTouch;


namespace WodstarMobileApp.iOS
{
	[Register ("Login")]
	partial class Login
	{
		public Lgoin (IntPtr h): base(h)
		{
		}

		public Login ()
		{
			var arr = NSBundle.MainBundle.LoadNib ("Login", Login, null);			
			var v = Runtime.GetNSObject(arr.ValueAt(0)) as UIView;
			v.Frame = new RectangleF(0, 0, Frame.Width, Frame.Height);
			AddSubview(v);

			MyLabel.Text = "hello from the SomeView class";
		}
	}
}
