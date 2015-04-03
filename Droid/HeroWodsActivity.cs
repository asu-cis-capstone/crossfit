
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Content.PM;

namespace WodstarMobileApp.Droid
{
	[Activity (Label = "HeroWodsActivity", Theme="@android:style/Theme.Black.NoTitleBar", Icon = "@drawable/icon", ScreenOrientation = ScreenOrientation.Portrait)]			
	public class HeroWodsActivity : Activity
	{
		private LinearLayout workoutLayout;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.HeroWods);

			workoutLayout = FindViewById<LinearLayout> (Resource.Id.wodLibraryLayout);

			//Get all the image buttons, add click events
			ImageButton johnsonButton = FindViewById<ImageButton> (Resource.Id.johnsonButton);
			ImageButton royButton = FindViewById<ImageButton> (Resource.Id.royButton);
			ImageButton rjButton = FindViewById<ImageButton> (Resource.Id.rjButton);
			ImageButton luceButton = FindViewById<ImageButton> (Resource.Id.luceButton);
			ImageButton abbateButton = FindViewById<ImageButton> (Resource.Id.abbateButton);
			ImageButton theSevenButton = FindViewById<ImageButton> (Resource.Id.theSevenButton);
			ImageButton mcCluskeyButton = FindViewById<ImageButton> (Resource.Id.mcCluskeyButton);
			ImageButton weaverButton = FindViewById<ImageButton> (Resource.Id.weaverButton);
			ImageButton ledesmaButton = FindViewById<ImageButton> (Resource.Id.ledesmaButton);
			ImageButton wittmanButton = FindViewById<ImageButton> (Resource.Id.wittmanButton);
			ImageButton rankelButton = FindViewById<ImageButton> (Resource.Id.rankelButton);
			ImageButton holbrookButton = FindViewById<ImageButton> (Resource.Id.holbrookButton);
			ImageButton whittenButton = FindViewById<ImageButton> (Resource.Id.whittenButton);
			ImageButton bullButton = FindViewById<ImageButton> (Resource.Id.bullButton);
			ImageButton collinButton = FindViewById<ImageButton> (Resource.Id.collinButton);
			ImageButton thompsonButton = FindViewById<ImageButton> (Resource.Id.thompsonButton);
			ImageButton santoraButton = FindViewById<ImageButton> (Resource.Id.santoraButton);
			ImageButton bradshawButton = FindViewById<ImageButton> (Resource.Id.bradshawButton);
			ImageButton santiagoButton = FindViewById<ImageButton> (Resource.Id.santiagoButton);
			ImageButton carseButton = FindViewById<ImageButton> (Resource.Id.carseButton);
			ImageButton bradleyButton = FindViewById<ImageButton> (Resource.Id.bradleyButton);
			ImageButton meadowsButton = FindViewById<ImageButton> (Resource.Id.meadowsButton);
			ImageButton gatorButton = FindViewById<ImageButton> (Resource.Id.gatorButton);
			ImageButton smallButton = FindViewById<ImageButton> (Resource.Id.smallButton);
			ImageButton moonButton = FindViewById<ImageButton> (Resource.Id.moonButton);
			ImageButton wilmotButton = FindViewById<ImageButton> (Resource.Id.wilmotButton);
			ImageButton lumberjack20Button = FindViewById<ImageButton> (Resource.Id.lumberjack20Button);
			ImageButton strangeButton = FindViewById<ImageButton> (Resource.Id.strangeButton);
			ImageButton nickButton = FindViewById<ImageButton> (Resource.Id.nickButton);
			ImageButton brianButton = FindViewById<ImageButton> (Resource.Id.brianButton);
			ImageButton jag28Button = FindViewById<ImageButton> (Resource.Id.jag28Button);
			ImageButton pheezyButton = FindViewById<ImageButton> (Resource.Id.pheezyButton);
			ImageButton rahojButton = FindViewById<ImageButton> (Resource.Id.rahojButton);
			ImageButton desforgesButton = FindViewById<ImageButton> (Resource.Id.desforgesButton);
			ImageButton paulButton = FindViewById<ImageButton> (Resource.Id.paulButton);
			ImageButton mcGheeButton = FindViewById<ImageButton> (Resource.Id.mcGheeButton);
			ImageButton tylerButton = FindViewById<ImageButton> (Resource.Id.tylerButton);
			ImageButton hansenButton = FindViewById<ImageButton> (Resource.Id.hansenButton);
			ImageButton dannyButton = FindViewById<ImageButton> (Resource.Id.dannyButton);
			ImageButton dtButton = FindViewById<ImageButton> (Resource.Id.dtButton);
			ImageButton ryanButton = FindViewById<ImageButton> (Resource.Id.ryanButton);
			ImageButton tommyVButton = FindViewById<ImageButton> (Resource.Id.tommyVButton);
			ImageButton garrettButton = FindViewById<ImageButton> (Resource.Id.garrettButton);
			ImageButton mrJoshuaButton = FindViewById<ImageButton> (Resource.Id.mrJoshuaButton);
			ImageButton jtButton = FindViewById<ImageButton> (Resource.Id.jtButton);
			ImageButton blakeButton = FindViewById<ImageButton> (Resource.Id.blakeButton);
			ImageButton mooreButton = FindViewById<ImageButton> (Resource.Id.mooreButton);
			ImageButton brentonButton = FindViewById<ImageButton> (Resource.Id.brentonButton);
			ImageButton murphButton = FindViewById<ImageButton> (Resource.Id.murphButton);
			ImageButton michaelButton = FindViewById<ImageButton> (Resource.Id.michaelButton);
			ImageButton danielButton = FindViewById<ImageButton> (Resource.Id.danielButton);
			ImageButton joshButton = FindViewById<ImageButton> (Resource.Id.joshButton);
			ImageButton jasonButton = FindViewById<ImageButton> (Resource.Id.jasonButton);
			ImageButton badgerButton = FindViewById<ImageButton> (Resource.Id.badgerButton);
			ImageButton joshieButton = FindViewById<ImageButton> (Resource.Id.joshieButton);
			ImageButton randyButton = FindViewById<ImageButton> (Resource.Id.randyButton);
			ImageButton griffButton = FindViewById<ImageButton> (Resource.Id.griffButton);
			ImageButton warFrankButton = FindViewById<ImageButton> (Resource.Id.warFrankButton);
			ImageButton jerryButton = FindViewById<ImageButton> (Resource.Id.jerryButton);
			ImageButton nateButton = FindViewById<ImageButton> (Resource.Id.nateButton);
			ImageButton joshuaButton = FindViewById<ImageButton> (Resource.Id.joshuaButton);
			ImageButton stephenButton = FindViewById<ImageButton> (Resource.Id.stephenButton);
			ImageButton nuttsButton = FindViewById<ImageButton> (Resource.Id.nuttsButton);
			ImageButton erinButton = FindViewById<ImageButton> (Resource.Id.erinButton);
			ImageButton woodButton = FindViewById<ImageButton> (Resource.Id.woodButton);

			//NAVIGATION
			var menu = FindViewById<FlyOutContainer> (Resource.Id.FlyOutContainer);
			var hamburgerButton = FindViewById (Resource.Id.hamburgerButton);
			hamburgerButton.Click += (sender, e) => {
				menu.AnimatedOpened = !menu.AnimatedOpened;
			};

			var titleButton = FindViewById (Resource.Id.titleTextView);
			var homeButton = FindViewById (Resource.Id.homeTextView);
			var profileButton = FindViewById (Resource.Id.profileTextView);
			var wodLibraryButton = FindViewById (Resource.Id.wodLibraryTextView);
			var movementLibraryButton = FindViewById (Resource.Id.movementLibraryTextView);
			var logoutButton = FindViewById (Resource.Id.logoutTextView);

			titleButton.Click += goToHomeScreen;
			homeButton.Click += goToHomeScreen;
			profileButton.Click += goToUserProfile;
			wodLibraryButton.Click += goToWodLibrary;
			movementLibraryButton.Click += goToMovementLibrary;
			logoutButton.Click += goToLogin;
			//END NAVIGATION
		}

		/* DO NOT DELTE

		private void initializeHeroWods() {
			Console.WriteLine ("InitializeHeroWods");
			for(int i=0; i < WorkoutUtil.heroWods.Length; i++) {
				//Create relative layout, image button, and text
				RelativeLayout rLayout = new RelativeLayout(this);
				ImageButton heroButton = (ImageButton)LayoutInflater.Inflate (Resource.Layout.WodImageButtonTemplate, null);
				TextView heroText = (TextView)LayoutInflater.Inflate(Resource.Layout.WodTextViewTemplate, null);

				heroText.Text = WorkoutUtil.heroWods [i];
				heroText.Gravity = GravityFlags.Center;
				heroText.SetTextSize(Android.Util.ComplexUnitType.Sp, 44);

				heroButton.SetImageDrawable(GetDrawable(Resource.Drawable.american));
				rLayout.SetHorizontalGravity(Android.Views.GravityFlags.CenterHorizontal);

				rLayout.AddView(heroButton);
				rLayout.AddView(heroText);
				workoutLayout.AddView(rLayout);
			}
			for (int i = 0; i <WorkoutUtil.canadaHeroWods.Length; i++) {
				
			}
			for (int i = 0; i <WorkoutUtil.australiaHeroWods.Length; i++) {
				
			}
		} */

		//NAVIGATION METHODS
		void goToUserProfile(object sender, EventArgs e) {
			//Start a new Activity for the UserProfile layout
			if (this.LocalClassName != "wodstarmobileapp.droid.UserProfileActivity") {
				StartActivity (typeof(UserProfileActivity));
			}
		}

		void goToHomeScreen(object sender, EventArgs e) {
			if (this.LocalClassName != "wodstarmobileapp.droid.StartScreenActivity") {
				StartActivity (typeof(StartScreenActivity));
			}
		}

		void goToWodLibrary(object sender, EventArgs e) {
			if (this.LocalClassName != "wodstarmobileapp.droid.WorkoutLibraryActivity") {
				StartActivity (typeof(WorkoutLibraryActivity));
			}
		}

		void goToLogin(object sender, EventArgs e) {
			if (this.LocalClassName != "wodstarmobileapp.droid.MainActivity") {
				StartActivity (typeof(MainActivity));
			}
		}

		void goToMovementLibrary(object sender, EventArgs e) {
			if (this.LocalClassName != "wodstarmobileapp.droid.MovementLibraryActivity") {
				Console.WriteLine ("Local class name = " + this.LocalClassName.ToString ());
				StartActivity (typeof(MovementLibraryActivity));
			}
		}
		//END NAVIGATION METHODS
	}
}

