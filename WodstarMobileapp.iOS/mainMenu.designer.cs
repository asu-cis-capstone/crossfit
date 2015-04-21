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
	[Register ("mainMenu")]
	partial class mainMenu
	{
		[Outlet]
		MonoTouch.UIKit.UIButton goToMovements { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton goToProfile { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton goToWODS { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (goToMovements != null) {
				goToMovements.Dispose ();
				goToMovements = null;
			}

			if (goToWODS != null) {
				goToWODS.Dispose ();
				goToWODS = null;
			}

			if (goToProfile != null) {
				goToProfile.Dispose ();
				goToProfile = null;
			}
		}
	}
}
