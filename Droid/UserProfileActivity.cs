
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
using Xamarin.Facebook;
using Xamarin.Facebook.Widget;
using Android.Graphics.Drawables;

namespace WodstarMobileApp.Droid
{
	[Activity (Label = "UserProfileActivity", Theme="@android:style/Theme.Black.NoTitleBar", Icon = "@drawable/icon", ScreenOrientation = ScreenOrientation.Portrait)]			
	public class UserProfileActivity : Activity
	{
		private TextView userNameTextView;
		private TableLayout userDataTable;
		private ImageButton girlsButton;
		private ImageButton heroButton;
		private ImageButton prButton;
		private bool girlsVisible;
		private bool heroesVisible;
		private bool prVisible;
		private FrameLayout headerLayout;
		private ProfilePictureView profilePicture;
		private Workout selectedWorkout;
		private Movement selectedMovement;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			SetContentView (Resource.Layout.Journal);
		
			//Get instances of variable layout components		
			userDataTable = FindViewById<TableLayout> (Resource.Id.userDataTable);
			girlsButton = FindViewById<ImageButton> (Resource.Id.girlsButton);
			prButton = FindViewById<ImageButton> (Resource.Id.prButton);
			heroButton = FindViewById<ImageButton> (Resource.Id.heroButton);
			headerLayout = FindViewById<FrameLayout> (Resource.Id.headerLayout);

			initializeHeader ();
		
			girlsButton.Click += (sender, e) => {
				girlsButton.Selected=true;
				heroButton.Selected=false;
				prButton.Selected=false;
				showGirlsTable();
			};
			prButton.Click += (sender, e) => {
				heroButton.Selected=false;
				girlsButton.Selected=false;
				prButton.Selected=true;
				showPrTable ();
			};
			heroButton.Click += (sender, e) => {
				Console.WriteLine("hero button clicked");
				heroButton.Selected=true;
				prButton.Selected=false;
				girlsButton.Selected=false;
				showHeroTable();
			};

			JournalUtil.initializeDemoJournalData ();
			//Initialize views to Wods
			showGirlsTable();
			girlsVisible = true;

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
		}

		void initializeHeader() {
			//TODO: check and see if user has uploaded their own, then set background accordingly. 
			headerLayout.SetBackgroundResource (Resource.Drawable.fillerDefaultCoverPhoto);
			LinearLayout profileLayout = new LinearLayout (this);
			profileLayout.Orientation = Orientation.Vertical;
			userNameTextView = new TextView (this);
			userNameTextView.SetTextSize (Android.Util.ComplexUnitType.Sp, 18);
			userNameTextView.Text = Util.thisUser.firstName + " " + Util.thisUser.lastName;
			userNameTextView.SetTextColor (Android.Graphics.Color.White);
			userNameTextView.Gravity = GravityFlags.CenterHorizontal;
			userNameTextView.SetTextAppearance (this, Android.Resource.Style.TextAppearanceLarge);
			userNameTextView.SetPadding (0, 25, 0, 25);
			profilePicture = new ProfilePictureView (this);
			profilePicture.ProfileId = Util.thisUser.id;
			Console.WriteLine ("FB profile Id: " + Util.thisUser.id);
			profilePicture.SetPadding (0, 25, 0, 0);
			userDataTable.SetColumnStretchable (0, true);
			userDataTable.SetColumnShrinkable (0, true);

			profileLayout.AddView (profilePicture);
			profileLayout.AddView (userNameTextView);
			profileLayout.SetGravity (GravityFlags.Center);
			headerLayout.AddView (profileLayout);
		}

		void showGirlsTable() 
		{
			if (!girlsVisible) {
				girlsVisible = true;
				prVisible = false;
				heroesVisible = false;
				clearTable ();
				if (WorkoutUtil.benchmarkWods.Count > 0) {
					foreach (KeyValuePair<string, Workout> benchmarkWod in WorkoutUtil.benchmarkWods) {
						int baseInt = 0;
						foreach (UserJournal j in JournalUtil.wodJournalData) {
							Console.WriteLine ("wodJournalData: " + JournalUtil.wodJournalData.Count);
							if (j.statId == (benchmarkWod.Value.id)) {
								Console.WriteLine ("Entry type = " + j.entryType);
								if (j.entryType == JournalUtil.amrapType) {
									Console.WriteLine ("Girls entry is amrap");
									if (Int32.Parse (j.statResult) > baseInt) {
										baseInt = Int32.Parse (j.statResult);
									}
								}
							}
						}

						TableRow dataRow = new TableRow (this);
						dataRow.Id = 1;
						dataRow.Background = this.Resources.GetDrawable (Resource.Drawable.TableViewGradient);
						dataRow.Clickable = true;
						dataRow.Click += (sender, e) => {
							if(!dataRow.Selected) {
								dataRow.Selected = true;
								for(int i = 0; i < userDataTable.ChildCount; i++) {
									if(userDataTable.GetChildAt(i).GetType() == typeof(TableRow)) {
										userDataTable.GetChildAt(i).Selected=false;
									}
								}
								selectedWorkout = benchmarkWod.Value;
							} else {
								dataRow.Selected = false;
							}

						};
						dataRow.SetPadding (0, 30, 0, 30);
						TextView workoutName = initializeNameText ();
						workoutName.Text = benchmarkWod.Value.workoutName;
						dataRow.AddView (workoutName);

						if (baseInt != 0) {
							TextView workoutPr = initializePrText ();
							workoutPr.Text = baseInt.ToString ();
							dataRow.AddView (workoutPr);
						} else {
							Button logButton = initializeLogButton ();
							dataRow.AddView (logButton);
							//TODO: Add logging functionality
						}
						userDataTable.AddView (dataRow);
					}
				}// End if benchmark wods not empty
			else {
					//TODO: Notify user of internet connectivity issues, ask them to try again.	
				}
			}//End if girls visible
		}

		void showPrTable() {
			if (!prVisible) {
				prVisible = true;
				girlsVisible = false;
				heroesVisible = false;
				clearTable ();
				if(MovementLinks.movementDictionary.Count >0) {
					Console.WriteLine ("Movement dictionary not null");
					foreach (KeyValuePair<string, Movement> movement in MovementLinks.movementDictionary) {
						Console.WriteLine ("Movement name: " + movement.Value.name);
						if (movement.Value.type == MovementLinks.strength) {
							Console.WriteLine ("Movement is type strength");
							int baseInt = 0;
							foreach (UserJournal j in JournalUtil.prJournalData) {
								if (j.statId == (movement.Value.id)) {
									if (Int32.Parse (j.statResult) > baseInt) {
										baseInt = Int32.Parse (j.statResult);
									}
								}
							}
							TableRow dataRow = new TableRow (this);
							dataRow.Id = 1;
							dataRow.Background = this.Resources.GetDrawable (Resource.Drawable.TableViewGradient);
							dataRow.Clickable = true;
							dataRow.Click += (sender, e) => {
								if(!dataRow.Selected) {
									dataRow.Selected = true;
									for(int i = 0; i < userDataTable.ChildCount; i++) {
										if(userDataTable.GetChildAt(i).GetType() == typeof(TableRow)) {
											userDataTable.GetChildAt(i).Selected=false;
										}
									}
									selectedMovement = movement.Value;
								} else {
									dataRow.Selected = false;
								}

							};
							dataRow.SetPadding (0, 30, 0, 30);
							TextView workoutName = initializeNameText ();
							workoutName.Text = movement.Value.name;
							dataRow.AddView (workoutName);

							if (baseInt != 0) {
								TextView workoutPr = initializePrText ();
								workoutPr.Text = baseInt.ToString ();
								dataRow.AddView (workoutPr);
							} else {
								Button logButton = initializeLogButton ();
								dataRow.AddView (logButton);
								//TODO: Add logging functionality
							}
							userDataTable.AddView (dataRow);
						}
					} //End if movement is strength
				} //End if allMovements >0
			} //End if PR view visible
		} //End showPrTable()

		void showHeroTable() {
			if (!heroesVisible) {
				heroesVisible = true;
				prVisible = false;
				girlsVisible = false;
				clearTable ();
				//TODO: need to add Canadian and Australian wods - try C# union
				if (WorkoutUtil.heroWods.Count > 0) {
					foreach (KeyValuePair<string, Workout> heroWod in WorkoutUtil.heroWods) {
						int baseInt = 0;
						foreach (UserJournal j in JournalUtil.wodJournalData) {
							if (j.statId == (heroWod.Value.id)) {
								Console.WriteLine ("Entry type = " + j.entryType);
								if (j.entryType == JournalUtil.amrapType) {
									Console.WriteLine ("Hero entry is amrap");
									if (Int32.Parse (j.statResult) > baseInt) {
										baseInt = Int32.Parse (j.statResult);
									}
								}
							}
						}
						TableRow dataRow = new TableRow (this);
						dataRow.Id = 1;
						dataRow.Background = this.Resources.GetDrawable (Resource.Drawable.TableViewGradient);
						dataRow.Clickable = true;
						dataRow.Click += (sender, e) => {
							if(!dataRow.Selected) {
								dataRow.Selected = true;
								for(int i = 0; i < userDataTable.ChildCount; i++) {
									if(userDataTable.GetChildAt(i).GetType() == typeof(TableRow)) {
										userDataTable.GetChildAt(i).Selected=false;
									}
								}
								selectedWorkout = heroWod.Value;
							} else {
								dataRow.Selected = false;
							}

						};
						dataRow.SetPadding (0, 30, 0, 30);
						TextView workoutName = initializeNameText ();
						workoutName.Text = heroWod.Value.workoutName;
						dataRow.AddView (workoutName);

						if (baseInt != 0) {
							TextView workoutPr = initializePrText ();
							workoutPr.Text = baseInt.ToString ();
							dataRow.AddView (workoutPr);
						} else {
							Button logButton = initializeLogButton ();
							dataRow.AddView (logButton);
							//TODO: Add logging functionality
						}
						userDataTable.AddView (dataRow);
					} //End foreach heroWod
				} //End if count >0
			} //End if heroes not already visible
		} //end showHeroTable()

		void clearTable() {
			for(int i = 0; i <userDataTable.ChildCount; i++) {
				View child = userDataTable.GetChildAt (i);
				if(child is TableRow) {
					((ViewGroup)child).RemoveAllViews ();
				}
				userDataTable.RemoveView (child);
				userDataTable.RemoveAllViews ();
			}
		}

		TextView initializePrText() {
			TextView workoutPr = new TextView (this);
			workoutPr.Gravity = GravityFlags.Right;
			workoutPr.SetPadding (0, 0, 15, 0);
			workoutPr.SetTextColor (Android.Graphics.Color.White);
			workoutPr.SetTextSize (Android.Util.ComplexUnitType.Sp, 20);
			return workoutPr;
		}

		Button initializeLogButton() {
			Button logButton = new Button (this);
			logButton.Text = "Log";
			logButton.Gravity = GravityFlags.Right;
			logButton.SetBackgroundColor (Android.Graphics.Color.Transparent);
			logButton.SetTextColor (Android.Graphics.Color.White);
			logButton.SetTextSize (Android.Util.ComplexUnitType.Sp, 20);
			return logButton;
		}

		TextView initializeNameText() {
			TextView workoutName = new TextView (this);
			workoutName.SetPadding (20, 0, 50, 0);
			workoutName.SetTextSize (Android.Util.ComplexUnitType.Sp, 20);
			workoutName.Gravity = GravityFlags.Left;
			workoutName.SetTextColor (Android.Graphics.Color.White);
			return workoutName;
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

