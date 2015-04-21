// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace WodstarMobileapp.iOS
{
	[Register ("login")]
	partial class login 
	{
		[Outlet]
		MonoTouch.UIKit.UIButton facebook { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton skipLogin { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (facebook != null) {
				facebook.Dispose ();
				facebook = null;
			}

			if (skipLogin != null) {
				skipLogin.Dispose ();
				skipLogin = null;
			}
		}
	}
}
