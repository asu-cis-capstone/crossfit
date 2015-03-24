using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;
using System.Collections.Generic;

namespace WodstarMobileApp.Droid
{
	public class Util
	{
		public const String wodstarRed = "#B5191D";
		public static  WodstarMobileApp.UserAccount thisUser = new UserAccount("14", "dprovenzano", "user", "Dan", "Provenzano", "Male", 29);
	/*
		public static UserJournal demoentry1 = new UserJournal (thisUser.id, WorkoutUtil.wodType, WorkoutUtil.franId, WorkoutUtil.forTime, "Fran", "3:42.13");
		public static UserJournal demoentry2 = new UserJournal (thisUser.id, WorkoutUtil.wodType, WorkoutUtil.franId, WorkoutUtil.forTime, "Fran", "4:12.08");
		public static UserJournal demoentry3 = new UserJournal (thisUser.id, WorkoutUtil.wodType, WorkoutUtil.franId, WorkoutUtil.forTime, "Fran", "5:09.16");
		public static UserJournal demoentry4 = new UserJournal (thisUser.id, WorkoutUtil.wodType, WorkoutUtil.franId, WorkoutUtil.forTime, "Fran", "3:51.27");
		public static UserJournal demoentry5 = new UserJournal (thisUser.id, WorkoutUtil.wodType, WorkoutUtil.franId, WorkoutUtil.forTime, "Fran", "4:39.46");

		public static UserJournal demoentry6 = new UserJournal (thisUser.id, WorkoutUtil.wodType, WorkoutUtil.warFrankId, WorkoutUtil.forTime, "War Frank", "8:21:43");
		public static UserJournal demoentry7 = new UserJournal (thisUser.id, WorkoutUtil.wodType, WorkoutUtil.warFrankId, WorkoutUtil.forTime, "War Frank", "8:21:43");
		public static UserJournal demoentry8 = new UserJournal (thisUser.id, WorkoutUtil.wodType, WorkoutUtil.warFrankId, WorkoutUtil.forTime, "War Frank", "8:21:43");

		public static UserJournal demoentry9 = new UserJournal (thisUser.id, WorkoutUtil.wodType, WorkoutUtil.warFrankId, WorkoutUtil.forTime, "War Frank", "8:21:43");
		public static UserJournal demoentry10 = new UserJournal (thisUser.id, WorkoutUtil.wodType, WorkoutUtil.warFrankId, WorkoutUtil.forTime, "War Frank", "8:21:43");

		public static UserJournal demoentry11 = new UserJournal (thisUser.id, WorkoutUtil.prType, MovementLinks.backSquatId, WorkoutUtil.strengthType, "Back Squat", "345");
		public static UserJournal demoentry12 = new UserJournal (thisUser.id, WorkoutUtil.prType, MovementLinks.backSquatId, WorkoutUtil.strengthType, "Back Squat", "312");

		public static UserJournal demoentry13 = new UserJournal (thisUser.id, WorkoutUtil.prType, MovementLinks.squatCleanId, WorkoutUtil.strengthType, "Squat Clean", "217");
		public static UserJournal demoentry14 = new UserJournal (thisUser.id, WorkoutUtil.prType, MovementLinks.squatCleanId, WorkoutUtil.strengthType, "Squat Clean", "243");

		public static List<UserJournal> demoJournal = new List<UserJournal>() {demoentry1, demoentry2, demoentry3, demoentry4, demoentry5,
			demoentry6, demoentry7, demoentry8, demoentry9, demoentry10, demoentry11, demoentry12, demoentry13, demoentry14};
	*/
		public static String fbUserId = null;
	}
}

