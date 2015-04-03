
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.FacebookConnect;

namespace WodstarMobileApp.iOS
{
	public partial class Login : UIViewController
	{
		private string [] ExtendedPermissions = new [] { "user_about_me", "read_stream"};

		FBLoginView loginView;
		FBProfilePictureView pictureView;
		IFBGraphUser user;
		UILabel nameLabel;

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Create the Facebook LogIn View with the needed Permissions
			// https://developers.facebook.com/ios/login-ui-control/
			loginView = new FBLoginView (ExtendedPermissions) {
				Frame = new RectangleF (85, 20, 151, 43)
			};

			// Hook up to FetchedUserInfo event, so you know when
			// you have the user information available
			loginView.FetchedUserInfo += (sender, e) => {
				user = e.User;
				pictureView.ProfileID = user.GetId ();
				nameLabel.Text = user.GetName ();
			};

			// Clean user Picture and label when Logged Out
			loginView.ShowingLoggedOutUser += (sender, e) => {
				pictureView.ProfileID = null;
				nameLabel.Text = string.Empty;
			};

			// Create view that will display user's profile picture
			// https://developers.facebook.com/ios/profilepicture-ui-control/
			pictureView = new FBProfilePictureView () {
				Frame = new RectangleF (40, 71, 240, 240)
			};

			// Create the label that will hold user's facebook name
			nameLabel = new UILabel (new RectangleF (20, 319, 280, 21)) {
				TextAlignment = UITextAlignment.Center,
				BackgroundColor = UIColor.Clear
			};

			// Add views to main view
			View.AddSubview (loginView);
			View.AddSubview (pictureView);
			View.AddSubview (nameLabel);
		}
	}
}

