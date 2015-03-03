using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.YouTube.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeIntents']"
	[global::Android.Runtime.Register ("com/google/android/youtube/player/YouTubeIntents", DoNotGenerateAcw=true)]
	public sealed partial class YouTubeIntents : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/youtube/player/YouTubeIntents", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (YouTubeIntents); }
		}

		internal YouTubeIntents (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_canResolveOpenPlaylistIntent_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeIntents']/method[@name='canResolveOpenPlaylistIntent' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("canResolveOpenPlaylistIntent", "(Landroid/content/Context;)Z", "")]
		public static bool CanResolveOpenPlaylistIntent (global::Android.Content.Context p0)
		{
			if (id_canResolveOpenPlaylistIntent_Landroid_content_Context_ == IntPtr.Zero)
				id_canResolveOpenPlaylistIntent_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "canResolveOpenPlaylistIntent", "(Landroid/content/Context;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_canResolveOpenPlaylistIntent_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_canResolvePlayPlaylistIntent_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeIntents']/method[@name='canResolvePlayPlaylistIntent' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("canResolvePlayPlaylistIntent", "(Landroid/content/Context;)Z", "")]
		public static bool CanResolvePlayPlaylistIntent (global::Android.Content.Context p0)
		{
			if (id_canResolvePlayPlaylistIntent_Landroid_content_Context_ == IntPtr.Zero)
				id_canResolvePlayPlaylistIntent_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "canResolvePlayPlaylistIntent", "(Landroid/content/Context;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_canResolvePlayPlaylistIntent_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_canResolvePlayVideoIntent_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeIntents']/method[@name='canResolvePlayVideoIntent' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("canResolvePlayVideoIntent", "(Landroid/content/Context;)Z", "")]
		public static bool CanResolvePlayVideoIntent (global::Android.Content.Context p0)
		{
			if (id_canResolvePlayVideoIntent_Landroid_content_Context_ == IntPtr.Zero)
				id_canResolvePlayVideoIntent_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "canResolvePlayVideoIntent", "(Landroid/content/Context;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_canResolvePlayVideoIntent_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_canResolvePlayVideoIntentWithOptions_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeIntents']/method[@name='canResolvePlayVideoIntentWithOptions' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("canResolvePlayVideoIntentWithOptions", "(Landroid/content/Context;)Z", "")]
		public static bool CanResolvePlayVideoIntentWithOptions (global::Android.Content.Context p0)
		{
			if (id_canResolvePlayVideoIntentWithOptions_Landroid_content_Context_ == IntPtr.Zero)
				id_canResolvePlayVideoIntentWithOptions_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "canResolvePlayVideoIntentWithOptions", "(Landroid/content/Context;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_canResolvePlayVideoIntentWithOptions_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_canResolveSearchIntent_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeIntents']/method[@name='canResolveSearchIntent' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("canResolveSearchIntent", "(Landroid/content/Context;)Z", "")]
		public static bool CanResolveSearchIntent (global::Android.Content.Context p0)
		{
			if (id_canResolveSearchIntent_Landroid_content_Context_ == IntPtr.Zero)
				id_canResolveSearchIntent_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "canResolveSearchIntent", "(Landroid/content/Context;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_canResolveSearchIntent_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_canResolveUploadIntent_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeIntents']/method[@name='canResolveUploadIntent' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("canResolveUploadIntent", "(Landroid/content/Context;)Z", "")]
		public static bool CanResolveUploadIntent (global::Android.Content.Context p0)
		{
			if (id_canResolveUploadIntent_Landroid_content_Context_ == IntPtr.Zero)
				id_canResolveUploadIntent_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "canResolveUploadIntent", "(Landroid/content/Context;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_canResolveUploadIntent_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_canResolveUserIntent_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeIntents']/method[@name='canResolveUserIntent' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("canResolveUserIntent", "(Landroid/content/Context;)Z", "")]
		public static bool CanResolveUserIntent (global::Android.Content.Context p0)
		{
			if (id_canResolveUserIntent_Landroid_content_Context_ == IntPtr.Zero)
				id_canResolveUserIntent_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "canResolveUserIntent", "(Landroid/content/Context;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_canResolveUserIntent_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_createOpenPlaylistIntent_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeIntents']/method[@name='createOpenPlaylistIntent' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("createOpenPlaylistIntent", "(Landroid/content/Context;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent CreateOpenPlaylistIntent (global::Android.Content.Context p0, string p1)
		{
			if (id_createOpenPlaylistIntent_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_createOpenPlaylistIntent_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createOpenPlaylistIntent", "(Landroid/content/Context;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createOpenPlaylistIntent_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_createPlayPlaylistIntent_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeIntents']/method[@name='createPlayPlaylistIntent' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("createPlayPlaylistIntent", "(Landroid/content/Context;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent CreatePlayPlaylistIntent (global::Android.Content.Context p0, string p1)
		{
			if (id_createPlayPlaylistIntent_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_createPlayPlaylistIntent_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createPlayPlaylistIntent", "(Landroid/content/Context;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createPlayPlaylistIntent_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_createPlayVideoIntent_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeIntents']/method[@name='createPlayVideoIntent' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("createPlayVideoIntent", "(Landroid/content/Context;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent CreatePlayVideoIntent (global::Android.Content.Context p0, string p1)
		{
			if (id_createPlayVideoIntent_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_createPlayVideoIntent_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createPlayVideoIntent", "(Landroid/content/Context;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createPlayVideoIntent_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_createPlayVideoIntentWithOptions_Landroid_content_Context_Ljava_lang_String_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeIntents']/method[@name='createPlayVideoIntentWithOptions' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("createPlayVideoIntentWithOptions", "(Landroid/content/Context;Ljava/lang/String;ZZ)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent CreatePlayVideoIntentWithOptions (global::Android.Content.Context p0, string p1, bool p2, bool p3)
		{
			if (id_createPlayVideoIntentWithOptions_Landroid_content_Context_Ljava_lang_String_ZZ == IntPtr.Zero)
				id_createPlayVideoIntentWithOptions_Landroid_content_Context_Ljava_lang_String_ZZ = JNIEnv.GetStaticMethodID (class_ref, "createPlayVideoIntentWithOptions", "(Landroid/content/Context;Ljava/lang/String;ZZ)Landroid/content/Intent;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createPlayVideoIntentWithOptions_Landroid_content_Context_Ljava_lang_String_ZZ, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_createSearchIntent_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeIntents']/method[@name='createSearchIntent' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("createSearchIntent", "(Landroid/content/Context;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent CreateSearchIntent (global::Android.Content.Context p0, string p1)
		{
			if (id_createSearchIntent_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_createSearchIntent_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createSearchIntent", "(Landroid/content/Context;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createSearchIntent_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_createUploadIntent_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeIntents']/method[@name='createUploadIntent' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("createUploadIntent", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent CreateUploadIntent (global::Android.Content.Context p0, global::Android.Net.Uri p1)
		{
			if (id_createUploadIntent_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
				id_createUploadIntent_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "createUploadIntent", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/content/Intent;");
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createUploadIntent_Landroid_content_Context_Landroid_net_Uri_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_createUserIntent_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeIntents']/method[@name='createUserIntent' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("createUserIntent", "(Landroid/content/Context;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent CreateUserIntent (global::Android.Content.Context p0, string p1)
		{
			if (id_createUserIntent_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_createUserIntent_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createUserIntent", "(Landroid/content/Context;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createUserIntent_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_getInstalledYouTubeVersionCode_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeIntents']/method[@name='getInstalledYouTubeVersionCode' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstalledYouTubeVersionCode", "(Landroid/content/Context;)I", "")]
		public static int GetInstalledYouTubeVersionCode (global::Android.Content.Context p0)
		{
			if (id_getInstalledYouTubeVersionCode_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstalledYouTubeVersionCode_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstalledYouTubeVersionCode", "(Landroid/content/Context;)I");
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getInstalledYouTubeVersionCode_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getInstalledYouTubeVersionName_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeIntents']/method[@name='getInstalledYouTubeVersionName' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstalledYouTubeVersionName", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetInstalledYouTubeVersionName (global::Android.Content.Context p0)
		{
			if (id_getInstalledYouTubeVersionName_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstalledYouTubeVersionName_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstalledYouTubeVersionName", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstalledYouTubeVersionName_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_isYouTubeInstalled_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeIntents']/method[@name='isYouTubeInstalled' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isYouTubeInstalled", "(Landroid/content/Context;)Z", "")]
		public static bool IsYouTubeInstalled (global::Android.Content.Context p0)
		{
			if (id_isYouTubeInstalled_Landroid_content_Context_ == IntPtr.Zero)
				id_isYouTubeInstalled_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isYouTubeInstalled", "(Landroid/content/Context;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isYouTubeInstalled_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

	}
}
