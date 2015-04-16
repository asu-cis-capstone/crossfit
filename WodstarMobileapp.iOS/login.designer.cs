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
	partial class login
	{
		[Outlet]
		MonoTouch.UIKit.UILabel helloWorldLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton heresAButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (heresAButton != null) {
				heresAButton.Dispose ();
				heresAButton = null;
			}

			if (helloWorldLabel != null) {
				helloWorldLabel.Dispose ();
				helloWorldLabel = null;
			}
		}
	}
}
