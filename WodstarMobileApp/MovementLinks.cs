using System;

namespace WodstarMobileApp
{
	public class MovementLinks
	{
		public static String[] MovementUrls = new String[] {hangPowerCleanLink, burpeeLink, backSquatLink, hangSnatchLink, squatCleanLink, powerCleanLink, hangSquatCleanLink,
			boxJumpLink, airSquatLink, deadliftLink, doubleUndersLink, frontSquatLink, splitJerkLink, ringMuscleUpLink, pistolSquatLink, powerSnatchLink, sumoDeadliftHighPullLink, thrusterLink, 
			americanKettlebellSwingLink, strictPressLink, pushPressLink, strictRingMuscleUpLink, russianKettlebellSwingLink, rowingLink
		};

		public static Movement[] allMovements;

		//Types of movements
		public const String strength = "strength";
		public const String bodyweight = "bodyweight";
		public const String cardio = "cardio";

		//Movement names
		public const String hangPowerClean ="Hang Power Clean";
		public const String burpee = "Burpee";
		public const String backSquat = "Back Squat";
		public const String hangSnatch = "Hang Snatch";
		public const String squatClean = "Squat Clean";
		public const String powerClean = "Power Clean";
		public const String hangSquatClean = "Hang Squat Clean";
		public const String boxJump = "Box Jump";
		public const String airSquat = "Air Squat";
		public const String deadlift = "Deadlift";
		public const String doubleUnders = "Double Unders";
		public const String frontSquat = "Front Squat";
		public const String splitJerk = "Split Jerk";
		public const String ringMuscleUp = "Ring Muscle Up";
		public const String ringKippingMuscleUp = "Ring Kipping Muscle Up";
		public const String kippingBarMuscleUp = "Kipping Bar Muscle Up";
		public const String pistolSquat = "Pistol Squat";
		public const String powerSnatch = "Power Snatch";
		public const String sumoDeadliftHighPull = "Sumo Deadlift High Pull";
		public const String thruster = "Thruster";
		public const String americanKettlebellSwing = "American KettlebellSwing";
		public const String strictPress = "Strict Press";
		public const String pushPress = "Push Press";
		public const String strictRingMuscleUp = "Strict Ring Muscle Up";
		public const String russianKettlebellSwing = "Russian Kettlebell Swing";
		public const String rowing = "Rowing";
		public const String pullUp = "Pull Up";
		public const String run = "Run";
		public const String squatSnatch = "Squat Snatch";

		//Movement Ids
		public const int hangPowerClean =1;
		public const int burpee = 2;
		public const int backSquat = 3;
		public const int hangSnatch = 4;
		public const int squatClean = 5;
		public const int powerClean = 6;
		public const int hangSquatClean = 7;
		public const int boxJump = 8;
		public const int airSquat = 9;
		public const int deadlift = 10;
		public const int doubleUnders = 11;
		public const int frontSquat = 12;
		public const int splitJerk = 13;
		public const int ringMuscleUp = 14;
		public const int ringKippingMuscleUp = 15;
		public const int kippingBarMuscleUp = 16
		public const int pistolSquat = 17;
		public const int powerSnatch = 18;
		public const int sumoDeadliftHighPull = 19;
		public const int thruster = 20;
		public const int americanKettlebellSwing = 21;
		public const int strictPress = 22;
		public const int pushPress = 23;
		public const int strictRingMuscleUp = 24;
		public const int russianKettlebellSwing = 25;
		public const int rowing = 26;
		public const int pullUp = 27;
		public const int run = 28;
		public const int squatSnatch = 29;

		//Types of equipment
		public const String box = "Box";
		public const String barbell = "Barbell";
		public const String body = "Body";
		public const String pullUpBar = "Pull-Up Bar";
		public const String dumbbell = "Dumbbell";
		public const String kettlebell = "Kettlebell";
		public const String medicineBall = "Medicine Ball";
		public const String ghdTable = "GHD Table";
		public const String wall = "Wall";
		public const String jumprope = "Jump Rope";
		public const String rings = "Rings";
		public const String paralleletts = "Paralleletts";
		public const String rope = "Rope";
		public const String wallBall = "Wall Ball";
		public const String rack = "Rack";
		public const String band = "Band";
		public const String rower = "Rowing Machine";

		//TODO: Initial grab from Azure should fill or double check these
		//Youtube Embed links for each movement
		public const String hangPowerCleanLink ="FfcU7GIboKI";
		public const String burpeeLink = "aXAEKD6uazI";
		public const String backSquatLink = "3U5xpGhkSPI";
		public const String hangSnatchLink = "UcEQhGsbAWU";
		public const String squatCleanLink = "kNh9Nc5AgQw";
		public const String powerCleanLink = "iLZE_89teic";
		public const String hangSquatCleanLink = "im5gB2GbJ2s";
		public const String boxJumpLink = "w-mbKI6W5q8";
		public const String airSquatLink = "KS7-aXERCH0";
		public const String deadliftLink = "CIqL-vOKdVc";
		public const String doubleUndersLink = "wwoqzm-eOwk";
		public const String frontSquatLink = "QCfP9R-Wq9g";
		public const String splitJerkLink = "WFK64tMMoJQ";
		public const String ringMuscleUpLink = "JgK85N__YVQ";
		public const String pistolSquatLink = "IOmFq0g7Mlw";
		public const String powerSnatchLink = "v3vsfL5MOEQ";
		public const String sumoDeadliftHighPullLink = "1s0Kn3n6lkA";
		public const String thrusterLink = "S4oR5TWpodM";
		public const String americanKettlebellSwingLink = "lqoEqPlk5b0";
		public const String strictPressLink = "SQFQP_1dJWM";
		public const String pushPressLink = "AU4OaeYFCEE";
		public const String strictRingMuscleUpLink = "dOp_qalvlXM";
		public const String russianKettlebellSwingLink = "OTUnj2TGfdA";
		public const String rowingLink = "7VmDpg6-QhA";

		//*******************************************************************************
		public static Movement hangPowerCleanMovement = new Movement(hangPowerClean, hangPowerCleanLink, strength, barbell);
		public static Movement ringMuscleUpMovement = new Movement(ringMuscleUp, ringMuscleUpLink, bodyweight, rings, 
			ringKippingMuscleUp, "Chest to Bar Pull-Up and Dip (2:1)", "Pull-Up and Dip (2:1)");
		public static Movement squatSnatchMovement = new Movement(squatSnatch, powerSnatchLink, strength, barbell);
		public static Movement rowingMovement = new Movement(rowing, rowingLink, strength, rower);
		public static Movement thrusterMovement = new Movement(thruster, thrusterLink, strength, barbell);
		public static Movement pullUpMovement = new Movement(pullUp, null, strength, pullUpBar);
		public static Movement runMovement = new Movement(run, null, cardio, null);
	}
}

