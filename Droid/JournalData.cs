
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
using Com.Telerik.Widget.Chart.Visualization.CartesianChart;
using Com.Telerik.Widget.Chart.Visualization.CartesianChart.Series.Categorical;
using Com.Telerik.Widget.Chart.Visualization.CartesianChart.Axes;
using Java.Util;

namespace WodstarMobileApp.Droid
{
	[Activity (Label = "JournalData", Theme="@android:style/Theme.Black.NoTitleBar", Icon = "@drawable/icon")]		
	public class JournalData : Activity
	{

		private Java.Util.ArrayList journalData;
		private LinearLayout mainLayout;
		RadCartesianChartView chartView;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			//base.SetContentView(Resource.Layout.JournalData);
			journalData = new Java.Util.ArrayList();
			journalData.Add(new UserJournal(Util.thisUser.id, JournalUtil.prType, MovementLinks.allMovements[2].id, JournalUtil.prType, MovementLinks.allMovements[2].name, "60", System.DateTime.Now));
			journalData.Add(new UserJournal(Util.thisUser.id, JournalUtil.prType, MovementLinks.allMovements[2].id, JournalUtil.prType, MovementLinks.allMovements[2].name, "70", System.DateTime.Now.AddDays(1)));
			journalData.Add(new UserJournal(Util.thisUser.id, JournalUtil.prType, MovementLinks.allMovements[2].id, JournalUtil.prType, MovementLinks.allMovements[2].name, "80", System.DateTime.Now.AddDays(2)));
			journalData.Add(new UserJournal(Util.thisUser.id, JournalUtil.prType, MovementLinks.allMovements[2].id, JournalUtil.prType, MovementLinks.allMovements[2].name, "90", System.DateTime.Now.AddDays(3)));

			mainLayout = FindViewById<LinearLayout>(Resource.Id.FlyOutContent);

			chartView = new RadCartesianChartView (this);
			LineSeries lineSeries = new LineSeries ();
			lineSeries.CategoryBinding = new journalDataBinding ("Date");
			lineSeries.ValueBinding = new journalDataBinding ("Result");
			lineSeries.Data = this.journalData;
			chartView.Series.Add (lineSeries);
			DateTimeCategoricalAxis hAxis = new DateTimeCategoricalAxis ();
			chartView.HorizontalAxis = hAxis;
			LinearAxis vAxis = new LinearAxis ();
			chartView.VerticalAxis = vAxis;

			mainLayout.AddView (chartView);

			//Get intents to figure out which movement to pull
			//Parse data from the list of all journal data to pull this workout's data
			//Turn into list of numeric points for graph
			//Create graph
		}
	}
}

