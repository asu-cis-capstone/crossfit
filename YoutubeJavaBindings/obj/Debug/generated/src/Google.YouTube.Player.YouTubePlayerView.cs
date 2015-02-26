using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.YouTube.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerView']"
	[global::Android.Runtime.Register ("com/google/android/youtube/player/YouTubePlayerView", DoNotGenerateAcw=true)]
	public sealed partial class YouTubePlayerView : global::Android.Views.ViewGroup, global::Google.YouTube.Player.IYouTubePlayerProvider {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/youtube/player/YouTubePlayerView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (YouTubePlayerView); }
		}

		internal YouTubePlayerView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerView']/constructor[@name='YouTubePlayerView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public YouTubePlayerView (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (YouTubePlayerView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerView']/constructor[@name='YouTubePlayerView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public YouTubePlayerView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (YouTubePlayerView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerView']/constructor[@name='YouTubePlayerView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public YouTubePlayerView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (YouTubePlayerView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_addFocusables_Ljava_util_ArrayList_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerView']/method[@name='addFocusables' and count(parameter)=2 and parameter[1][@type='java.util.ArrayList'] and parameter[2][@type='int']]"
		[Register ("addFocusables", "(Ljava/util/ArrayList;I)V", "")]
		public void AddFocusables (global::System.Collections.Generic.IList<global::Android.Views.View> p0, int p1)
		{
			if (id_addFocusables_Ljava_util_ArrayList_I == IntPtr.Zero)
				id_addFocusables_Ljava_util_ArrayList_I = JNIEnv.GetMethodID (class_ref, "addFocusables", "(Ljava/util/ArrayList;I)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Views.View>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_addFocusables_Ljava_util_ArrayList_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_addFocusables_Ljava_util_ArrayList_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerView']/method[@name='addFocusables' and count(parameter)=3 and parameter[1][@type='java.util.ArrayList'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("addFocusables", "(Ljava/util/ArrayList;II)V", "")]
		public void AddFocusables (global::System.Collections.Generic.IList<global::Android.Views.View> p0, int p1, int p2)
		{
			if (id_addFocusables_Ljava_util_ArrayList_II == IntPtr.Zero)
				id_addFocusables_Ljava_util_ArrayList_II = JNIEnv.GetMethodID (class_ref, "addFocusables", "(Ljava/util/ArrayList;II)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Views.View>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_addFocusables_Ljava_util_ArrayList_II, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_addView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerView']/method[@name='addView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("addView", "(Landroid/view/View;)V", "")]
		public override sealed void AddView (global::Android.Views.View p0)
		{
			if (id_addView_Landroid_view_View_ == IntPtr.Zero)
				id_addView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "addView", "(Landroid/view/View;)V");
			JNIEnv.CallVoidMethod  (Handle, id_addView_Landroid_view_View_, new JValue (p0));
		}

		static IntPtr id_addView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerView']/method[@name='addView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.ViewGroup.LayoutParams']]"
		[Register ("addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", "")]
		public override sealed void AddView (global::Android.Views.View p0, global::Android.Views.ViewGroup.LayoutParams p1)
		{
			if (id_addView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ == IntPtr.Zero)
				id_addView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ = JNIEnv.GetMethodID (class_ref, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			JNIEnv.CallVoidMethod  (Handle, id_addView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_addView_Landroid_view_View_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerView']/method[@name='addView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("addView", "(Landroid/view/View;I)V", "")]
		public override sealed void AddView (global::Android.Views.View p0, int p1)
		{
			if (id_addView_Landroid_view_View_I == IntPtr.Zero)
				id_addView_Landroid_view_View_I = JNIEnv.GetMethodID (class_ref, "addView", "(Landroid/view/View;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_addView_Landroid_view_View_I, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_addView_Landroid_view_View_ILandroid_view_ViewGroup_LayoutParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerView']/method[@name='addView' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='android.view.ViewGroup.LayoutParams']]"
		[Register ("addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", "")]
		public override sealed void AddView (global::Android.Views.View p0, int p1, global::Android.Views.ViewGroup.LayoutParams p2)
		{
			if (id_addView_Landroid_view_View_ILandroid_view_ViewGroup_LayoutParams_ == IntPtr.Zero)
				id_addView_Landroid_view_View_ILandroid_view_ViewGroup_LayoutParams_ = JNIEnv.GetMethodID (class_ref, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			JNIEnv.CallVoidMethod  (Handle, id_addView_Landroid_view_View_ILandroid_view_ViewGroup_LayoutParams_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_addView_Landroid_view_View_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerView']/method[@name='addView' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("addView", "(Landroid/view/View;II)V", "")]
		public override sealed void AddView (global::Android.Views.View p0, int p1, int p2)
		{
			if (id_addView_Landroid_view_View_II == IntPtr.Zero)
				id_addView_Landroid_view_View_II = JNIEnv.GetMethodID (class_ref, "addView", "(Landroid/view/View;II)V");
			JNIEnv.CallVoidMethod  (Handle, id_addView_Landroid_view_View_II, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_clearChildFocus_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerView']/method[@name='clearChildFocus' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("clearChildFocus", "(Landroid/view/View;)V", "")]
		public override sealed void ClearChildFocus (global::Android.Views.View p0)
		{
			if (id_clearChildFocus_Landroid_view_View_ == IntPtr.Zero)
				id_clearChildFocus_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "clearChildFocus", "(Landroid/view/View;)V");
			JNIEnv.CallVoidMethod  (Handle, id_clearChildFocus_Landroid_view_View_, new JValue (p0));
		}

		static IntPtr id_dispatchKeyEvent_Landroid_view_KeyEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerView']/method[@name='dispatchKeyEvent' and count(parameter)=1 and parameter[1][@type='android.view.KeyEvent']]"
		[Register ("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", "")]
		public override sealed bool DispatchKeyEvent (global::Android.Views.KeyEvent p0)
		{
			if (id_dispatchKeyEvent_Landroid_view_KeyEvent_ == IntPtr.Zero)
				id_dispatchKeyEvent_Landroid_view_KeyEvent_ = JNIEnv.GetMethodID (class_ref, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_dispatchKeyEvent_Landroid_view_KeyEvent_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_focusableViewAvailable_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerView']/method[@name='focusableViewAvailable' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("focusableViewAvailable", "(Landroid/view/View;)V", "")]
		public override sealed void FocusableViewAvailable (global::Android.Views.View p0)
		{
			if (id_focusableViewAvailable_Landroid_view_View_ == IntPtr.Zero)
				id_focusableViewAvailable_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "focusableViewAvailable", "(Landroid/view/View;)V");
			JNIEnv.CallVoidMethod  (Handle, id_focusableViewAvailable_Landroid_view_View_, new JValue (p0));
		}

		static IntPtr id_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerView']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.android.youtube.player.YouTubePlayer.OnInitializedListener']]"
		[Register ("initialize", "(Ljava/lang/String;Lcom/google/android/youtube/player/YouTubePlayer$OnInitializedListener;)V", "")]
		public void Initialize (string p0, global::Google.YouTube.Player.IYouTubePlayerOnInitializedListener p1)
		{
			if (id_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_ == IntPtr.Zero)
				id_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_ = JNIEnv.GetMethodID (class_ref, "initialize", "(Ljava/lang/String;Lcom/google/android/youtube/player/YouTubePlayer$OnInitializedListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_onAttachedToWindow;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerView']/method[@name='onAttachedToWindow' and count(parameter)=0]"
		[Register ("onAttachedToWindow", "()V", "")]
		protected override sealed void OnAttachedToWindow ()
		{
			if (id_onAttachedToWindow == IntPtr.Zero)
				id_onAttachedToWindow = JNIEnv.GetMethodID (class_ref, "onAttachedToWindow", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_onAttachedToWindow);
		}

		static IntPtr id_onConfigurationChanged_Landroid_content_res_Configuration_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerView']/method[@name='onConfigurationChanged' and count(parameter)=1 and parameter[1][@type='android.content.res.Configuration']]"
		[Register ("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", "")]
		public void OnConfigurationChanged (global::Android.Content.Res.Configuration p0)
		{
			if (id_onConfigurationChanged_Landroid_content_res_Configuration_ == IntPtr.Zero)
				id_onConfigurationChanged_Landroid_content_res_Configuration_ = JNIEnv.GetMethodID (class_ref, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			JNIEnv.CallVoidMethod  (Handle, id_onConfigurationChanged_Landroid_content_res_Configuration_, new JValue (p0));
		}

		static IntPtr id_onDetachedFromWindow;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerView']/method[@name='onDetachedFromWindow' and count(parameter)=0]"
		[Register ("onDetachedFromWindow", "()V", "")]
		protected override sealed void OnDetachedFromWindow ()
		{
			if (id_onDetachedFromWindow == IntPtr.Zero)
				id_onDetachedFromWindow = JNIEnv.GetMethodID (class_ref, "onDetachedFromWindow", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_onDetachedFromWindow);
		}

		static IntPtr id_onLayout_ZIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerView']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "")]
		protected override sealed void OnLayout (bool p0, int p1, int p2, int p3, int p4)
		{
			if (id_onLayout_ZIIII == IntPtr.Zero)
				id_onLayout_ZIIII = JNIEnv.GetMethodID (class_ref, "onLayout", "(ZIIII)V");
			JNIEnv.CallVoidMethod  (Handle, id_onLayout_ZIIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static IntPtr id_onMeasure_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerView']/method[@name='onMeasure' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onMeasure", "(II)V", "")]
		protected override sealed void OnMeasure (int p0, int p1)
		{
			if (id_onMeasure_II == IntPtr.Zero)
				id_onMeasure_II = JNIEnv.GetMethodID (class_ref, "onMeasure", "(II)V");
			JNIEnv.CallVoidMethod  (Handle, id_onMeasure_II, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_onTouchEvent_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerView']/method[@name='onTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onTouchEvent", "(Landroid/view/MotionEvent;)Z", "")]
		public override sealed bool OnTouchEvent (global::Android.Views.MotionEvent p0)
		{
			if (id_onTouchEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onTouchEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_onTouchEvent_Landroid_view_MotionEvent_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_requestChildFocus_Landroid_view_View_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerView']/method[@name='requestChildFocus' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.View']]"
		[Register ("requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V", "")]
		public override sealed void RequestChildFocus (global::Android.Views.View p0, global::Android.Views.View p1)
		{
			if (id_requestChildFocus_Landroid_view_View_Landroid_view_View_ == IntPtr.Zero)
				id_requestChildFocus_Landroid_view_View_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V");
			JNIEnv.CallVoidMethod  (Handle, id_requestChildFocus_Landroid_view_View_Landroid_view_View_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setClipToPadding_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerView']/method[@name='setClipToPadding' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setClipToPadding", "(Z)V", "")]
		public override sealed void SetClipToPadding (bool p0)
		{
			if (id_setClipToPadding_Z == IntPtr.Zero)
				id_setClipToPadding_Z = JNIEnv.GetMethodID (class_ref, "setClipToPadding", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_setClipToPadding_Z, new JValue (p0));
		}

		static IntPtr id_setPadding_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerView']/method[@name='setPadding' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setPadding", "(IIII)V", "")]
		public override sealed void SetPadding (int p0, int p1, int p2, int p3)
		{
			if (id_setPadding_IIII == IntPtr.Zero)
				id_setPadding_IIII = JNIEnv.GetMethodID (class_ref, "setPadding", "(IIII)V");
			JNIEnv.CallVoidMethod  (Handle, id_setPadding_IIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

	}
}
