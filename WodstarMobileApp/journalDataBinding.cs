using System;
using Com.Telerik.Widget.Chart.Engine.Databinding;

namespace WodstarMobileApp
{
	public class journalDataBinding : DataPointBinding 
	{
		private string propertyName;

		public override Java.Lang.Object GetValue (Java.Lang.Object p0)
		{
			if (propertyName == "Date") {
				DateTime statTime = ((UserJournal) p0).statDateTime;
				Java.Util.Date javaDate = new Java.Util.Date (statTime.Year, statTime.Month, statTime.Day, statTime.Hour, statTime.Minute);
				return (Java.Lang.Object)(javaDate);
			} else {
<<<<<<< HEAD
				return Int32.Parse(((UserJournal)p0).statResult);
=======
				return ((UserJournal)p0).statResult;
>>>>>>> 559489002ab9c3855d207b08d07869c7ab1540bb
			}
		}

		public journalDataBinding (string propertyName)
		{
			this.propertyName = propertyName;
		}
	}
}

