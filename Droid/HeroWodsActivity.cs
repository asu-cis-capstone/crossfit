
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
		AutoCompleteTextView autocompleteHero;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.HeroWods);

			autocompleteHero = FindViewById<AutoCompleteTextView> (Resource.Id.autocompleteHero);
			var adapter = new ArrayAdapter<String> (this, Resource.Layout.AutcompleteTextViewTemplate, WorkoutUtil.stringHeroWods);
			autocompleteHero.Adapter = adapter;
			autocompleteHero.SetSelectAllOnFocus (true);
			autocompleteHero.Threshold = 1;
			autocompleteHero.SetText ("Search", false);
			autocompleteHero.ItemClick += searchItemSelected;

			workoutLayout = FindViewById<LinearLayout> (Resource.Id.wodLibraryLayout);
			initializeHeroWods ();

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

		private void initializeHeroWods() {
			Console.WriteLine ("InitializeHeroWods");
			for(int i=0; i < WorkoutUtil.stringHeroWods.Length; i++) {
				//Create relative layout, image button, and text
				RelativeLayout rLayout = new RelativeLayout(this);
				ImageButton heroButton = (ImageButton)LayoutInflater.Inflate (Resource.Layout.WodImageButtonTemplate, null);
				TextView heroText = (TextView)LayoutInflater.Inflate(Resource.Layout.WodTextViewTemplate, null);

				if (WorkoutUtil.heroIds.ContainsKey (WorkoutUtil.stringHeroWods [i])) {
					String intentWorkoutName = WorkoutUtil.stringHeroWods [i];
					String intentWorkoutId = WorkoutUtil.heroIds [WorkoutUtil.stringHeroWods [i]];
					var intent = new Intent (this, typeof(WorkoutActivity));
					intent.PutExtra ("workoutName", intentWorkoutName);
					intent.PutExtra ("workoutId", intentWorkoutId);
					heroButton.Click += (object sender, EventArgs e) => StartActivity (intent);
				}
					
				heroText.Text = WorkoutUtil.stringHeroWods [i];
				heroText.Gravity = GravityFlags.Center;
				heroText.SetTextSize(Android.Util.ComplexUnitType.Sp, 44);
				rLayout.SetPadding (75, 100, 75, 0);
				RelativeLayout.LayoutParams lp = new RelativeLayout.LayoutParams (RelativeLayout.LayoutParams.WrapContent, RelativeLayout.LayoutParams.WrapContent);
				lp.AddRule (LayoutRules.CenterInParent);
				heroText.LayoutParameters = lp;
				heroButton.SetImageDrawable(GetDrawable(Resource.Drawable.american));
				heroButton.SetMinimumHeight (162);


				rLayout.SetGravity (Android.Views.GravityFlags.Center);
				rLayout.SetBackgroundColor (new Android.Graphics.Color (255, 255, 255, 0));
				rLayout.AddView(heroButton);
				rLayout.AddView(heroText);
				workoutLayout.AddView(rLayout);
			}
			for (int i = 0; i <WorkoutUtil.canadaHeroWods.Length; i++) {
				//Create relative layout, image button, and text
				RelativeLayout rLayout = new RelativeLayout(this);
				ImageButton heroButton = (ImageButton)LayoutInflater.Inflate (Resource.Layout.WodImageButtonTemplate, null);
				TextView heroText = (TextView)LayoutInflater.Inflate(Resource.Layout.WodTextViewTemplate, null);

				if (WorkoutUtil.heroIds.ContainsKey (WorkoutUtil.canadaHeroWods [i])) {
					String intentWorkoutName = WorkoutUtil.stringHeroWods [i];
					String intentWorkoutId = WorkoutUtil.heroIds [WorkoutUtil.canadaHeroWods [i]];
					var intent = new Intent (this, typeof(WorkoutActivity));
					intent.PutExtra ("workoutName", intentWorkoutName);
					intent.PutExtra ("workoutId", intentWorkoutId);
					heroButton.Click += (object sender, EventArgs e) => StartActivity (intent);
				}

				heroText.Text = WorkoutUtil.canadaHeroWods [i];
				heroText.Gravity = GravityFlags.Center;
				heroText.SetTextSize(Android.Util.ComplexUnitType.Sp, 44);
				rLayout.SetPadding (75, 100, 75, 0);
				RelativeLayout.LayoutParams lp = new RelativeLayout.LayoutParams (RelativeLayout.LayoutParams.WrapContent,
					RelativeLayout.LayoutParams.WrapContent);
				lp.AddRule (LayoutRules.CenterInParent);
				//WorkoutUtil.canadaHeroWods [i].ToLower ();
				heroText.LayoutParameters = lp;
				heroButton.SetAdjustViewBounds (false);

				heroButton.SetImageDrawable(GetDrawable(Resource.Drawable.canadian));
				rLayout.SetGravity (Android.Views.GravityFlags.Center);
				rLayout.SetBackgroundColor (new Android.Graphics.Color (255, 255, 255, 0));

				rLayout.AddView(heroButton);
				rLayout.AddView(heroText);
				workoutLayout.AddView(rLayout);
			}
			for (int i = 0; i <WorkoutUtil.australiaHeroWods.Length; i++) {
				//Create relative layout, image button, and text
				RelativeLayout rLayout = new RelativeLayout(this);
				ImageButton heroButton = (ImageButton)LayoutInflater.Inflate (Resource.Layout.WodImageButtonTemplate, null);
				TextView heroText = (TextView)LayoutInflater.Inflate(Resource.Layout.WodTextViewTemplate, null);

				if (WorkoutUtil.heroIds.ContainsKey (WorkoutUtil.australiaHeroWods [i])) {
					String intentWorkoutName = WorkoutUtil.australiaHeroWods [i];
					String intentWorkoutId = WorkoutUtil.heroIds [WorkoutUtil.australiaHeroWods [i]];
					var intent = new Intent (this, typeof(WorkoutActivity));
					intent.PutExtra ("workoutName", intentWorkoutName);
					intent.PutExtra ("workoutId", intentWorkoutId);
					heroButton.Click += (object sender, EventArgs e) => StartActivity (intent);
				}

				heroText.Text = WorkoutUtil.australiaHeroWods [i];
				heroText.Gravity = GravityFlags.Center;
				heroText.SetTextSize(Android.Util.ComplexUnitType.Sp, 44);
				rLayout.SetPadding (75, 100, 75, 0);
				RelativeLayout.LayoutParams lp = new RelativeLayout.LayoutParams (RelativeLayout.LayoutParams.WrapContent,
					RelativeLayout.LayoutParams.WrapContent);
				lp.AddRule (LayoutRules.CenterInParent);
				heroText.LayoutParameters = lp;
				heroButton.SetImageDrawable(GetDrawable(Resource.Drawable.australian));
				heroButton.SetMinimumHeight (162);
				rLayout.SetGravity (Android.Views.GravityFlags.Center);
				rLayout.SetBackgroundColor (new Android.Graphics.Color (255, 255, 255, 0));

				rLayout.AddView(heroButton);
				rLayout.AddView(heroText);
				workoutLayout.AddView(rLayout);
			}
		} // End initializeHeroWods()

		void searchItemSelected(object sender, AdapterView.ItemClickEventArgs e) {
			String workoutSelected = autocompleteHero.Text;
			if(WorkoutUtil.benchmarkIds.ContainsKey(workoutSelected)) {
				var intent = new Intent(this, typeof(WorkoutActivity));
				intent.PutExtra("workoutName", workoutSelected);
				intent.PutExtra("workoutId", WorkoutUtil.benchmarkIds[workoutSelected]);
				StartActivity(intent);
			}
		}

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

