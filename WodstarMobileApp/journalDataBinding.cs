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
				return ((UserJournal)(p0)).statDateTime;
			} else {
				return ((UserJournal)(p0)).statResult;
			}
		}
			
		public journalDataBinding (string propertyName)
		{
			this.propertyName = propertyName;
		}
	}
}

