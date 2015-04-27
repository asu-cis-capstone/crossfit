
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
using Com.Telerik.Widget.Chart.Visualization.Behaviors;
using Com.Telerik.Widget.Chart.Engine.Axes;
using Com.Telerik.Android.Common;
using Com.Telerik.Widget.Chart.Engine.Axes.Common;
using Java.Text;

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
			base.SetContentView(Resource.Layout.TestJournalContent);
			journalData = new Java.Util.ArrayList();
			journalData.Add(new UserJournal(Util.thisUser.id, JournalUtil.prType, MovementLinks.allMovements[2].id, JournalUtil.prType, MovementLinks.allMovements[2].name, "60", System.DateTime.Now));
			journalData.Add(new UserJournal(Util.thisUser.id, JournalUtil.prType, MovementLinks.allMovements[2].id, JournalUtil.prType, MovementLinks.allMovements[2].name, "47", System.DateTime.Now.AddDays(1)));
			journalData.Add(new UserJournal(Util.thisUser.id, JournalUtil.prType, MovementLinks.allMovements[2].id, JournalUtil.prType, MovementLinks.allMovements[2].name, "71", System.DateTime.Now.AddDays(2)));
			journalData.Add(new UserJournal(Util.thisUser.id, JournalUtil.prType, MovementLinks.allMovements[2].id, JournalUtil.prType, MovementLinks.allMovements[2].name, "85", System.DateTime.Now.AddDays(3)));
			journalData.Add(new UserJournal(Util.thisUser.id, JournalUtil.prType, MovementLinks.allMovements[2].id, JournalUtil.prType, MovementLinks.allMovements[2].name, "80", System.DateTime.Now.AddDays(4)));
			mainLayout = FindViewById<LinearLayout>(Resource.Id.FlyOutContent);

			chartView = new RadCartesianChartView (this);
			ChartTooltipBehavior toolTipBehavior = new ChartTooltipBehavior (this);
			toolTipBehavior.ContentAdapter ().CategoryToStringConverter = new dateConverter ();
			toolTipBehavior.ContentAdapter ().ValueToStringConverter = new valueConverter ();

			ChartPanAndZoomBehavior panAndZoomBehavior = new ChartPanAndZoomBehavior ();
			panAndZoomBehavior.PanMode = ChartPanZoomMode.Both;
			panAndZoomBehavior.ZoomStrategy = ChartZoomStrategy.Deferred;
			chartView.Behaviors.Add (toolTipBehavior);
			SplineSeries lineSeries = new SplineSeries ();
			lineSeries.CategoryBinding = new journalDataBinding ("Date");
			lineSeries.ValueBinding = new journalDataBinding ("Result");
			lineSeries.Data = this.journalData;
			lineSeries.StrokeThickness = 15;
			chartView.Series.Add (lineSeries);

			DateTimeCategoricalAxis hAxis = new DateTimeCategoricalAxis ();

			chartView.HorizontalAxis = hAxis;
			LinearAxis vAxis = new LinearAxis ();
			chartView.VerticalAxis = vAxis;
			hAxis.DateTimeComponent = DateTimeComponent.Month;
			hAxis.SetDateTimeFormat(new SimpleDateFormat("MMM-yyyy"));
			hAxis.LabelValueToStringConverter = new XLabelValueConverter();
			vAxis.LabelValueToStringConverter = new YLabelValueConverter ();

			mainLayout.AddView (chartView);

			//Get intents to figure out which movement to pull
			//Parse data from the list of all journal data to pull this workout's data
			//Turn into list of numeric points for graph
			//Create graph
		}
	}

	class dateConverter : Java.Lang.Object, IFunction {
		public Java.Lang.Object Apply(Java.Lang.Object argument) {
		SimpleDateFormat format = new SimpleDateFormat ("MMM dd");
			return format.Format (((Java.Util.Date)argument).Time);
		}
	}

	class valueConverter: Java.Lang.Object, IFunction {
		public Java.Lang.Object Apply(Java.Lang.Object argument) {
			String format = "{0,-1}";
			return String.Format (format, argument);
		}
	}

	class YLabelValueConverter: Java.Lang.Object, IFunction {
		public Java.Lang.Object Apply(Java.Lang.Object argument) {
			double labelValue = (argument.JavaCast<MajorTickModel> ()).Value ();
			String format = "{0,-1}";
			return String.Format (format, labelValue);
		}
	}
	class XLabelValueConverter: Java.Lang.Object, IFunction {
		public Java.Lang.Object Apply(Java.Lang.Object argument) {
			double labelValue = argument.JavaCast<MajorTickModel> ().Value();
			SimpleDateFormat format = new SimpleDateFormat ("MMM dd");
			return format.Format (((Java.Util.Date)argument).Time);

		}

	}
}

