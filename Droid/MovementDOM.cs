using System;

namespace WodstarMobileApp.Droid
{
	public class MovementDOM
	{
		private String rxName;
		private Uri rxLink;

		private String blueDiamondName;
		private Uri blueDiamondLink;

		//Etc on levels.

		public MovementDOM (String rxName, Uri rxLink, String blueDiamondName, Uri blueDiamondLink)
		{
			this.rxName = rxName;
			this.rxLink = rxLink;
			this.blueDiamondName = blueDiamondName;
			this.blueDiamondLink = blueDiamondLink;
		}
	}
}

