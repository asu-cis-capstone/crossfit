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
				Java.Util.Calendar calendar = ((UserJournal) p0).cal;
				//Java.Util.Date javaDate = new Java.Util.Date (statTime.Year, statTime.Month, statTime.Day, statTime.Hour, statTime.Minute);
				return calendar;
			} else {
				return Int32.Parse(((UserJournal)p0).statResult);
			}
		}

		public journalDataBinding (string propertyName)
		{
			this.propertyName = propertyName;
		}
	}
}

