
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace WodstarMobileapp.iOS
{
	public partial class loginViewController : UIViewController
	{
		login l; 

		public loginViewController () : base ("login", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			l = new login(){Frame = View.Frame};
			View.AddSubview(l);
			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}

