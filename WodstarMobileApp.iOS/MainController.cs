using System;
using System.Linq;
using System.Collections.Generic;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using FlyoutNavigation;

namespace WodstarMobileApp.iOS
{
	public class Controller : UIViewController
	{
		FlyoutNavigationController navigation;

		// Data we'll use to create our flyout menu and views:
		string[] Tasks = {
			"Get Xamarin",
			"Learn C#",
			"Write Killer App",
			"Add Platforms",
			"Profit",
			"Meet Obama",
		} ;

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			var navigation = new FlyoutNavigationController {
				// Create the navigation menu
				NavigationRoot = new RootElement ("Navigation") {
					new Section ("Pages") {
						new StringElement ("WODS"),
						new StringElement ("Leaderboard"),
						new StringElement ("My Profile"),
					}
				} ,
				// Supply view controllers corresponding to menu items:
				ViewControllers = new [] {
					new UIViewController { View },
					new UIViewController { View },
					new UIViewController { View  },
				} ,
			} ;
			// Specify navigation position
			navigation.Position = FlyOutNavigationPosition.Left;
			// Show the navigation view
			navigation.ToggleMenu ();
			View.AddSubview (navigation.View);
		}
		static T CreateViewController<T>(string storyboardName, string viewControllerStoryBoardId = "") where T : UIViewController
		{
			var storyboard = UIStoryboard.FromName (storyboardName,null);
			return string.IsNullOrEmpty(viewControllerStoryBoardId) ? (T)storyboard.InstantiateInitialViewController () : (T) storyboard.InstantiateViewController(viewControllerStoryBoardId);
		}
		class TaskPageController : DialogViewController
		{
			public TaskPageController (FlyoutNavigationController navigation, string title) : base (null)
			{
				Root = new RootElement (title) {
					new Section {
						new CheckboxElement (title)
					}
				} ;
				NavigationItem.LeftBarButtonItem = new UIBarButtonItem (UIBarButtonSystemItem.Action, delegate {
					navigation.ToggleMenu ();
				} );
			}
		}
	}
}




