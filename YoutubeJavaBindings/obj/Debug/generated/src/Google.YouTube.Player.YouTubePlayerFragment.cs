using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.YouTube.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerFragment']"
	[global::Android.Runtime.Register ("com/google/android/youtube/player/YouTubePlayerFragment", DoNotGenerateAcw=true)]
	public partial class YouTubePlayerFragment : global::Android.App.Fragment, global::Google.YouTube.Player.IYouTubePlayerProvider {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/youtube/player/YouTubePlayerFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (YouTubePlayerFragment); }
		}

		protected YouTubePlayerFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerFragment']/constructor[@name='YouTubePlayerFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public YouTubePlayerFragment () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (YouTubePlayerFragment)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static Delegate cb_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_;
#pragma warning disable 0169
		static Delegate GetInitialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_Handler ()
		{
			if (cb_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_ == null)
				cb_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_);
			return cb_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_;
		}

		static void n_Initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Google.YouTube.Player.YouTubePlayerFragment __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubePlayerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Google.YouTube.Player.IYouTubePlayerOnInitializedListener p1 = (global::Google.YouTube.Player.IYouTubePlayerOnInitializedListener)global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerOnInitializedListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerFragment']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.android.youtube.player.YouTubePlayer.OnInitializedListener']]"
		[Register ("initialize", "(Ljava/lang/String;Lcom/google/android/youtube/player/YouTubePlayer$OnInitializedListener;)V", "GetInitialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_Handler")]
		public virtual void Initialize (string p0, global::Google.YouTube.Player.IYouTubePlayerOnInitializedListener p1)
		{
			if (id_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_ == IntPtr.Zero)
				id_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_ = JNIEnv.GetMethodID (class_ref, "initialize", "(Ljava/lang/String;Lcom/google/android/youtube/player/YouTubePlayer$OnInitializedListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initialize", "(Ljava/lang/String;Lcom/google/android/youtube/player/YouTubePlayer$OnInitializedListener;)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_newInstance;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerFragment']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/google/android/youtube/player/YouTubePlayerFragment;", "")]
		public static global::Google.YouTube.Player.YouTubePlayerFragment NewInstance ()
		{
			if (id_newInstance == IntPtr.Zero)
				id_newInstance = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "()Lcom/google/android/youtube/player/YouTubePlayerFragment;");
			return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubePlayerFragment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance), JniHandleOwnership.TransferLocalRef);
		}

	}
}
