using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.YouTube.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayer.ErrorReason']"
	[global::Android.Runtime.Register ("com/google/android/youtube/player/YouTubePlayer$ErrorReason", DoNotGenerateAcw=true)]
	public sealed partial class YouTubePlayerErrorReason : global::Java.Lang.Enum {


		static IntPtr AUTOPLAY_DISABLED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayer.ErrorReason']/field[@name='AUTOPLAY_DISABLED']"
		[Register ("AUTOPLAY_DISABLED")]
		public static global::Google.YouTube.Player.YouTubePlayerErrorReason AutoplayDisabled {
			get {
				if (AUTOPLAY_DISABLED_jfieldId == IntPtr.Zero)
					AUTOPLAY_DISABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTOPLAY_DISABLED", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTOPLAY_DISABLED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubePlayerErrorReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (AUTOPLAY_DISABLED_jfieldId == IntPtr.Zero)
					AUTOPLAY_DISABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTOPLAY_DISABLED", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, AUTOPLAY_DISABLED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr BLOCKED_FOR_APP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayer.ErrorReason']/field[@name='BLOCKED_FOR_APP']"
		[Register ("BLOCKED_FOR_APP")]
		public static global::Google.YouTube.Player.YouTubePlayerErrorReason BlockedForApp {
			get {
				if (BLOCKED_FOR_APP_jfieldId == IntPtr.Zero)
					BLOCKED_FOR_APP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLOCKED_FOR_APP", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BLOCKED_FOR_APP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubePlayerErrorReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (BLOCKED_FOR_APP_jfieldId == IntPtr.Zero)
					BLOCKED_FOR_APP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLOCKED_FOR_APP", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, BLOCKED_FOR_APP_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EMBEDDING_DISABLED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayer.ErrorReason']/field[@name='EMBEDDING_DISABLED']"
		[Register ("EMBEDDING_DISABLED")]
		public static global::Google.YouTube.Player.YouTubePlayerErrorReason EmbeddingDisabled {
			get {
				if (EMBEDDING_DISABLED_jfieldId == IntPtr.Zero)
					EMBEDDING_DISABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMBEDDING_DISABLED", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMBEDDING_DISABLED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubePlayerErrorReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EMBEDDING_DISABLED_jfieldId == IntPtr.Zero)
					EMBEDDING_DISABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMBEDDING_DISABLED", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EMBEDDING_DISABLED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr EMPTY_PLAYLIST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayer.ErrorReason']/field[@name='EMPTY_PLAYLIST']"
		[Register ("EMPTY_PLAYLIST")]
		public static global::Google.YouTube.Player.YouTubePlayerErrorReason EmptyPlaylist {
			get {
				if (EMPTY_PLAYLIST_jfieldId == IntPtr.Zero)
					EMPTY_PLAYLIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_PLAYLIST", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMPTY_PLAYLIST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubePlayerErrorReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EMPTY_PLAYLIST_jfieldId == IntPtr.Zero)
					EMPTY_PLAYLIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_PLAYLIST", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, EMPTY_PLAYLIST_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr INTERNAL_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayer.ErrorReason']/field[@name='INTERNAL_ERROR']"
		[Register ("INTERNAL_ERROR")]
		public static global::Google.YouTube.Player.YouTubePlayerErrorReason InternalError {
			get {
				if (INTERNAL_ERROR_jfieldId == IntPtr.Zero)
					INTERNAL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERNAL_ERROR", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERNAL_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubePlayerErrorReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (INTERNAL_ERROR_jfieldId == IntPtr.Zero)
					INTERNAL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERNAL_ERROR", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, INTERNAL_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr NETWORK_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayer.ErrorReason']/field[@name='NETWORK_ERROR']"
		[Register ("NETWORK_ERROR")]
		public static global::Google.YouTube.Player.YouTubePlayerErrorReason NetworkError {
			get {
				if (NETWORK_ERROR_jfieldId == IntPtr.Zero)
					NETWORK_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_ERROR", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubePlayerErrorReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NETWORK_ERROR_jfieldId == IntPtr.Zero)
					NETWORK_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_ERROR", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NETWORK_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr NOT_PLAYABLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayer.ErrorReason']/field[@name='NOT_PLAYABLE']"
		[Register ("NOT_PLAYABLE")]
		public static global::Google.YouTube.Player.YouTubePlayerErrorReason NotPlayable {
			get {
				if (NOT_PLAYABLE_jfieldId == IntPtr.Zero)
					NOT_PLAYABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_PLAYABLE", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_PLAYABLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubePlayerErrorReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NOT_PLAYABLE_jfieldId == IntPtr.Zero)
					NOT_PLAYABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_PLAYABLE", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NOT_PLAYABLE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr PLAYER_VIEW_NOT_VISIBLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayer.ErrorReason']/field[@name='PLAYER_VIEW_NOT_VISIBLE']"
		[Register ("PLAYER_VIEW_NOT_VISIBLE")]
		public static global::Google.YouTube.Player.YouTubePlayerErrorReason PlayerViewNotVisible {
			get {
				if (PLAYER_VIEW_NOT_VISIBLE_jfieldId == IntPtr.Zero)
					PLAYER_VIEW_NOT_VISIBLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAYER_VIEW_NOT_VISIBLE", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAYER_VIEW_NOT_VISIBLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubePlayerErrorReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PLAYER_VIEW_NOT_VISIBLE_jfieldId == IntPtr.Zero)
					PLAYER_VIEW_NOT_VISIBLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAYER_VIEW_NOT_VISIBLE", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, PLAYER_VIEW_NOT_VISIBLE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr PLAYER_VIEW_TOO_SMALL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayer.ErrorReason']/field[@name='PLAYER_VIEW_TOO_SMALL']"
		[Register ("PLAYER_VIEW_TOO_SMALL")]
		public static global::Google.YouTube.Player.YouTubePlayerErrorReason PlayerViewTooSmall {
			get {
				if (PLAYER_VIEW_TOO_SMALL_jfieldId == IntPtr.Zero)
					PLAYER_VIEW_TOO_SMALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAYER_VIEW_TOO_SMALL", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAYER_VIEW_TOO_SMALL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubePlayerErrorReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PLAYER_VIEW_TOO_SMALL_jfieldId == IntPtr.Zero)
					PLAYER_VIEW_TOO_SMALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAYER_VIEW_TOO_SMALL", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, PLAYER_VIEW_TOO_SMALL_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr UNAUTHORIZED_OVERLAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayer.ErrorReason']/field[@name='UNAUTHORIZED_OVERLAY']"
		[Register ("UNAUTHORIZED_OVERLAY")]
		public static global::Google.YouTube.Player.YouTubePlayerErrorReason UnauthorizedOverlay {
			get {
				if (UNAUTHORIZED_OVERLAY_jfieldId == IntPtr.Zero)
					UNAUTHORIZED_OVERLAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNAUTHORIZED_OVERLAY", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNAUTHORIZED_OVERLAY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubePlayerErrorReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (UNAUTHORIZED_OVERLAY_jfieldId == IntPtr.Zero)
					UNAUTHORIZED_OVERLAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNAUTHORIZED_OVERLAY", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, UNAUTHORIZED_OVERLAY_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr UNEXPECTED_SERVICE_DISCONNECTION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayer.ErrorReason']/field[@name='UNEXPECTED_SERVICE_DISCONNECTION']"
		[Register ("UNEXPECTED_SERVICE_DISCONNECTION")]
		public static global::Google.YouTube.Player.YouTubePlayerErrorReason UnexpectedServiceDisconnection {
			get {
				if (UNEXPECTED_SERVICE_DISCONNECTION_jfieldId == IntPtr.Zero)
					UNEXPECTED_SERVICE_DISCONNECTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNEXPECTED_SERVICE_DISCONNECTION", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNEXPECTED_SERVICE_DISCONNECTION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubePlayerErrorReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (UNEXPECTED_SERVICE_DISCONNECTION_jfieldId == IntPtr.Zero)
					UNEXPECTED_SERVICE_DISCONNECTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNEXPECTED_SERVICE_DISCONNECTION", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, UNEXPECTED_SERVICE_DISCONNECTION_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr UNKNOWN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayer.ErrorReason']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public static global::Google.YouTube.Player.YouTubePlayerErrorReason Unknown {
			get {
				if (UNKNOWN_jfieldId == IntPtr.Zero)
					UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubePlayerErrorReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (UNKNOWN_jfieldId == IntPtr.Zero)
					UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, UNKNOWN_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr USER_DECLINED_HIGH_BANDWIDTH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayer.ErrorReason']/field[@name='USER_DECLINED_HIGH_BANDWIDTH']"
		[Register ("USER_DECLINED_HIGH_BANDWIDTH")]
		public static global::Google.YouTube.Player.YouTubePlayerErrorReason UserDeclinedHighBandwidth {
			get {
				if (USER_DECLINED_HIGH_BANDWIDTH_jfieldId == IntPtr.Zero)
					USER_DECLINED_HIGH_BANDWIDTH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_DECLINED_HIGH_BANDWIDTH", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_DECLINED_HIGH_BANDWIDTH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubePlayerErrorReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (USER_DECLINED_HIGH_BANDWIDTH_jfieldId == IntPtr.Zero)
					USER_DECLINED_HIGH_BANDWIDTH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_DECLINED_HIGH_BANDWIDTH", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, USER_DECLINED_HIGH_BANDWIDTH_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr USER_DECLINED_RESTRICTED_CONTENT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayer.ErrorReason']/field[@name='USER_DECLINED_RESTRICTED_CONTENT']"
		[Register ("USER_DECLINED_RESTRICTED_CONTENT")]
		public static global::Google.YouTube.Player.YouTubePlayerErrorReason UserDeclinedRestrictedContent {
			get {
				if (USER_DECLINED_RESTRICTED_CONTENT_jfieldId == IntPtr.Zero)
					USER_DECLINED_RESTRICTED_CONTENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_DECLINED_RESTRICTED_CONTENT", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_DECLINED_RESTRICTED_CONTENT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubePlayerErrorReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (USER_DECLINED_RESTRICTED_CONTENT_jfieldId == IntPtr.Zero)
					USER_DECLINED_RESTRICTED_CONTENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_DECLINED_RESTRICTED_CONTENT", "Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, USER_DECLINED_RESTRICTED_CONTENT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/youtube/player/YouTubePlayer$ErrorReason", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (YouTubePlayerErrorReason); }
		}

		internal YouTubePlayerErrorReason (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayer.ErrorReason']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;", "")]
		public static global::Google.YouTube.Player.YouTubePlayerErrorReason ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Google.YouTube.Player.YouTubePlayerErrorReason __ret = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubePlayerErrorReason> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayer.ErrorReason']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;", "")]
		public static global::Google.YouTube.Player.YouTubePlayerErrorReason[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;");
			return (global::Google.YouTube.Player.YouTubePlayerErrorReason[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Google.YouTube.Player.YouTubePlayerErrorReason));
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer.OnFullscreenListener']"
	[Register ("com/google/android/youtube/player/YouTubePlayer$OnFullscreenListener", "", "Google.YouTube.Player.IYouTubePlayerOnFullscreenListenerInvoker")]
	public partial interface IYouTubePlayerOnFullscreenListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer.OnFullscreenListener']/method[@name='onFullscreen' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onFullscreen", "(Z)V", "GetOnFullscreen_ZHandler:Google.YouTube.Player.IYouTubePlayerOnFullscreenListenerInvoker, YoutubeJavaBindings")]
		void OnFullscreen (bool p0);

	}

	[global::Android.Runtime.Register ("com/google/android/youtube/player/YouTubePlayer$OnFullscreenListener", DoNotGenerateAcw=true)]
	internal class IYouTubePlayerOnFullscreenListenerInvoker : global::Java.Lang.Object, IYouTubePlayerOnFullscreenListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/youtube/player/YouTubePlayer$OnFullscreenListener");
		IntPtr class_ref;

		public static IYouTubePlayerOnFullscreenListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IYouTubePlayerOnFullscreenListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.youtube.player.YouTubePlayer.OnFullscreenListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IYouTubePlayerOnFullscreenListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IYouTubePlayerOnFullscreenListenerInvoker); }
		}

		static Delegate cb_onFullscreen_Z;
#pragma warning disable 0169
		static Delegate GetOnFullscreen_ZHandler ()
		{
			if (cb_onFullscreen_Z == null)
				cb_onFullscreen_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnFullscreen_Z);
			return cb_onFullscreen_Z;
		}

		static void n_OnFullscreen_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Google.YouTube.Player.IYouTubePlayerOnFullscreenListener __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerOnFullscreenListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFullscreen (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFullscreen_Z;
		public void OnFullscreen (bool p0)
		{
			if (id_onFullscreen_Z == IntPtr.Zero)
				id_onFullscreen_Z = JNIEnv.GetMethodID (class_ref, "onFullscreen", "(Z)V");
			JNIEnv.CallVoidMethod (Handle, id_onFullscreen_Z, new JValue (p0));
		}

	}

	public partial class YouTubePlayerOnFullscreenEventArgs : global::System.EventArgs {

		public YouTubePlayerOnFullscreenEventArgs (bool p0)
		{
			this.p0 = p0;
		}

		bool p0;
		public bool P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/android/youtube/player/YouTubePlayer_OnFullscreenListenerImplementor")]
	internal sealed class IYouTubePlayerOnFullscreenListenerImplementor : global::Java.Lang.Object, IYouTubePlayerOnFullscreenListener {

		object sender;

		public IYouTubePlayerOnFullscreenListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/google/android/youtube/player/YouTubePlayer_OnFullscreenListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<YouTubePlayerOnFullscreenEventArgs> Handler;
#pragma warning restore 0649

		public void OnFullscreen (bool p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new YouTubePlayerOnFullscreenEventArgs (p0));
		}

		internal static bool __IsEmpty (IYouTubePlayerOnFullscreenListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer.OnInitializedListener']"
	[Register ("com/google/android/youtube/player/YouTubePlayer$OnInitializedListener", "", "Google.YouTube.Player.IYouTubePlayerOnInitializedListenerInvoker")]
	public partial interface IYouTubePlayerOnInitializedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer.OnInitializedListener']/method[@name='onInitializationFailure' and count(parameter)=2 and parameter[1][@type='com.google.android.youtube.player.YouTubePlayer.Provider'] and parameter[2][@type='com.google.android.youtube.player.YouTubeInitializationResult']]"
		[Register ("onInitializationFailure", "(Lcom/google/android/youtube/player/YouTubePlayer$Provider;Lcom/google/android/youtube/player/YouTubeInitializationResult;)V", "GetOnInitializationFailure_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubeInitializationResult_Handler:Google.YouTube.Player.IYouTubePlayerOnInitializedListenerInvoker, YoutubeJavaBindings")]
		void OnInitializationFailure (global::Google.YouTube.Player.IYouTubePlayerProvider p0, global::Google.YouTube.Player.YouTubeInitializationResult p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer.OnInitializedListener']/method[@name='onInitializationSuccess' and count(parameter)=3 and parameter[1][@type='com.google.android.youtube.player.YouTubePlayer.Provider'] and parameter[2][@type='com.google.android.youtube.player.YouTubePlayer'] and parameter[3][@type='boolean']]"
		[Register ("onInitializationSuccess", "(Lcom/google/android/youtube/player/YouTubePlayer$Provider;Lcom/google/android/youtube/player/YouTubePlayer;Z)V", "GetOnInitializationSuccess_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubePlayer_ZHandler:Google.YouTube.Player.IYouTubePlayerOnInitializedListenerInvoker, YoutubeJavaBindings")]
		void OnInitializationSuccess (global::Google.YouTube.Player.IYouTubePlayerProvider p0, global::Google.YouTube.Player.IYouTubePlayer p1, bool p2);

	}

	[global::Android.Runtime.Register ("com/google/android/youtube/player/YouTubePlayer$OnInitializedListener", DoNotGenerateAcw=true)]
	internal class IYouTubePlayerOnInitializedListenerInvoker : global::Java.Lang.Object, IYouTubePlayerOnInitializedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/youtube/player/YouTubePlayer$OnInitializedListener");
		IntPtr class_ref;

		public static IYouTubePlayerOnInitializedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IYouTubePlayerOnInitializedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.youtube.player.YouTubePlayer.OnInitializedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IYouTubePlayerOnInitializedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IYouTubePlayerOnInitializedListenerInvoker); }
		}

		static Delegate cb_onInitializationFailure_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubeInitializationResult_;
#pragma warning disable 0169
		static Delegate GetOnInitializationFailure_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubeInitializationResult_Handler ()
		{
			if (cb_onInitializationFailure_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubeInitializationResult_ == null)
				cb_onInitializationFailure_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubeInitializationResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnInitializationFailure_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubeInitializationResult_);
			return cb_onInitializationFailure_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubeInitializationResult_;
		}

		static void n_OnInitializationFailure_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubeInitializationResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Google.YouTube.Player.IYouTubePlayerOnInitializedListener __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerOnInitializedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.YouTube.Player.IYouTubePlayerProvider p0 = (global::Google.YouTube.Player.IYouTubePlayerProvider)global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerProvider> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Google.YouTube.Player.YouTubeInitializationResult p1 = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubeInitializationResult> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnInitializationFailure (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onInitializationFailure_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubeInitializationResult_;
		public void OnInitializationFailure (global::Google.YouTube.Player.IYouTubePlayerProvider p0, global::Google.YouTube.Player.YouTubeInitializationResult p1)
		{
			if (id_onInitializationFailure_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubeInitializationResult_ == IntPtr.Zero)
				id_onInitializationFailure_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubeInitializationResult_ = JNIEnv.GetMethodID (class_ref, "onInitializationFailure", "(Lcom/google/android/youtube/player/YouTubePlayer$Provider;Lcom/google/android/youtube/player/YouTubeInitializationResult;)V");
			JNIEnv.CallVoidMethod (Handle, id_onInitializationFailure_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubeInitializationResult_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_onInitializationSuccess_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubePlayer_Z;
#pragma warning disable 0169
		static Delegate GetOnInitializationSuccess_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubePlayer_ZHandler ()
		{
			if (cb_onInitializationSuccess_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubePlayer_Z == null)
				cb_onInitializationSuccess_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubePlayer_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnInitializationSuccess_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubePlayer_Z);
			return cb_onInitializationSuccess_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubePlayer_Z;
		}

		static void n_OnInitializationSuccess_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubePlayer_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Google.YouTube.Player.IYouTubePlayerOnInitializedListener __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerOnInitializedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.YouTube.Player.IYouTubePlayerProvider p0 = (global::Google.YouTube.Player.IYouTubePlayerProvider)global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerProvider> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Google.YouTube.Player.IYouTubePlayer p1 = (global::Google.YouTube.Player.IYouTubePlayer)global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnInitializationSuccess (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onInitializationSuccess_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubePlayer_Z;
		public void OnInitializationSuccess (global::Google.YouTube.Player.IYouTubePlayerProvider p0, global::Google.YouTube.Player.IYouTubePlayer p1, bool p2)
		{
			if (id_onInitializationSuccess_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubePlayer_Z == IntPtr.Zero)
				id_onInitializationSuccess_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubePlayer_Z = JNIEnv.GetMethodID (class_ref, "onInitializationSuccess", "(Lcom/google/android/youtube/player/YouTubePlayer$Provider;Lcom/google/android/youtube/player/YouTubePlayer;Z)V");
			JNIEnv.CallVoidMethod (Handle, id_onInitializationSuccess_Lcom_google_android_youtube_player_YouTubePlayer_Provider_Lcom_google_android_youtube_player_YouTubePlayer_Z, new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}

	public partial class InitializationFailureEventArgs : global::System.EventArgs {

		public InitializationFailureEventArgs (global::Google.YouTube.Player.IYouTubePlayerProvider p0, global::Google.YouTube.Player.YouTubeInitializationResult p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Google.YouTube.Player.IYouTubePlayerProvider p0;
		public global::Google.YouTube.Player.IYouTubePlayerProvider P0 {
			get { return p0; }
		}

		global::Google.YouTube.Player.YouTubeInitializationResult p1;
		public global::Google.YouTube.Player.YouTubeInitializationResult P1 {
			get { return p1; }
		}
	}

	public partial class InitializationSuccessEventArgs : global::System.EventArgs {

		public InitializationSuccessEventArgs (global::Google.YouTube.Player.IYouTubePlayerProvider p0, global::Google.YouTube.Player.IYouTubePlayer p1, bool p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Google.YouTube.Player.IYouTubePlayerProvider p0;
		public global::Google.YouTube.Player.IYouTubePlayerProvider P0 {
			get { return p0; }
		}

		global::Google.YouTube.Player.IYouTubePlayer p1;
		public global::Google.YouTube.Player.IYouTubePlayer P1 {
			get { return p1; }
		}

		bool p2;
		public bool P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/android/youtube/player/YouTubePlayer_OnInitializedListenerImplementor")]
	internal sealed class IYouTubePlayerOnInitializedListenerImplementor : global::Java.Lang.Object, IYouTubePlayerOnInitializedListener {

		object sender;

		public IYouTubePlayerOnInitializedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/google/android/youtube/player/YouTubePlayer_OnInitializedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<InitializationFailureEventArgs> OnInitializationFailureHandler;
#pragma warning restore 0649

		public void OnInitializationFailure (global::Google.YouTube.Player.IYouTubePlayerProvider p0, global::Google.YouTube.Player.YouTubeInitializationResult p1)
		{
			var __h = OnInitializationFailureHandler;
			if (__h != null)
				__h (sender, new InitializationFailureEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<InitializationSuccessEventArgs> OnInitializationSuccessHandler;
#pragma warning restore 0649

		public void OnInitializationSuccess (global::Google.YouTube.Player.IYouTubePlayerProvider p0, global::Google.YouTube.Player.IYouTubePlayer p1, bool p2)
		{
			var __h = OnInitializationSuccessHandler;
			if (__h != null)
				__h (sender, new InitializationSuccessEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IYouTubePlayerOnInitializedListenerImplementor value)
		{
			return value.OnInitializationFailureHandler == null && value.OnInitializationSuccessHandler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer.PlaybackEventListener']"
	[Register ("com/google/android/youtube/player/YouTubePlayer$PlaybackEventListener", "", "Google.YouTube.Player.IYouTubePlayerPlaybackEventListenerInvoker")]
	public partial interface IYouTubePlayerPlaybackEventListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer.PlaybackEventListener']/method[@name='onBuffering' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onBuffering", "(Z)V", "GetOnBuffering_ZHandler:Google.YouTube.Player.IYouTubePlayerPlaybackEventListenerInvoker, YoutubeJavaBindings")]
		void OnBuffering (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer.PlaybackEventListener']/method[@name='onPaused' and count(parameter)=0]"
		[Register ("onPaused", "()V", "GetOnPausedHandler:Google.YouTube.Player.IYouTubePlayerPlaybackEventListenerInvoker, YoutubeJavaBindings")]
		void OnPaused ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer.PlaybackEventListener']/method[@name='onPlaying' and count(parameter)=0]"
		[Register ("onPlaying", "()V", "GetOnPlayingHandler:Google.YouTube.Player.IYouTubePlayerPlaybackEventListenerInvoker, YoutubeJavaBindings")]
		void OnPlaying ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer.PlaybackEventListener']/method[@name='onSeekTo' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onSeekTo", "(I)V", "GetOnSeekTo_IHandler:Google.YouTube.Player.IYouTubePlayerPlaybackEventListenerInvoker, YoutubeJavaBindings")]
		void OnSeekTo (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer.PlaybackEventListener']/method[@name='onStopped' and count(parameter)=0]"
		[Register ("onStopped", "()V", "GetOnStoppedHandler:Google.YouTube.Player.IYouTubePlayerPlaybackEventListenerInvoker, YoutubeJavaBindings")]
		void OnStopped ();

	}

	[global::Android.Runtime.Register ("com/google/android/youtube/player/YouTubePlayer$PlaybackEventListener", DoNotGenerateAcw=true)]
	internal class IYouTubePlayerPlaybackEventListenerInvoker : global::Java.Lang.Object, IYouTubePlayerPlaybackEventListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/youtube/player/YouTubePlayer$PlaybackEventListener");
		IntPtr class_ref;

		public static IYouTubePlayerPlaybackEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IYouTubePlayerPlaybackEventListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.youtube.player.YouTubePlayer.PlaybackEventListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IYouTubePlayerPlaybackEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IYouTubePlayerPlaybackEventListenerInvoker); }
		}

		static Delegate cb_onBuffering_Z;
#pragma warning disable 0169
		static Delegate GetOnBuffering_ZHandler ()
		{
			if (cb_onBuffering_Z == null)
				cb_onBuffering_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnBuffering_Z);
			return cb_onBuffering_Z;
		}

		static void n_OnBuffering_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Google.YouTube.Player.IYouTubePlayerPlaybackEventListener __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerPlaybackEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBuffering (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBuffering_Z;
		public void OnBuffering (bool p0)
		{
			if (id_onBuffering_Z == IntPtr.Zero)
				id_onBuffering_Z = JNIEnv.GetMethodID (class_ref, "onBuffering", "(Z)V");
			JNIEnv.CallVoidMethod (Handle, id_onBuffering_Z, new JValue (p0));
		}

		static Delegate cb_onPaused;
#pragma warning disable 0169
		static Delegate GetOnPausedHandler ()
		{
			if (cb_onPaused == null)
				cb_onPaused = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPaused);
			return cb_onPaused;
		}

		static void n_OnPaused (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.YouTube.Player.IYouTubePlayerPlaybackEventListener __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerPlaybackEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPaused ();
		}
#pragma warning restore 0169

		IntPtr id_onPaused;
		public void OnPaused ()
		{
			if (id_onPaused == IntPtr.Zero)
				id_onPaused = JNIEnv.GetMethodID (class_ref, "onPaused", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onPaused);
		}

		static Delegate cb_onPlaying;
#pragma warning disable 0169
		static Delegate GetOnPlayingHandler ()
		{
			if (cb_onPlaying == null)
				cb_onPlaying = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPlaying);
			return cb_onPlaying;
		}

		static void n_OnPlaying (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.YouTube.Player.IYouTubePlayerPlaybackEventListener __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerPlaybackEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPlaying ();
		}
#pragma warning restore 0169

		IntPtr id_onPlaying;
		public void OnPlaying ()
		{
			if (id_onPlaying == IntPtr.Zero)
				id_onPlaying = JNIEnv.GetMethodID (class_ref, "onPlaying", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onPlaying);
		}

		static Delegate cb_onSeekTo_I;
#pragma warning disable 0169
		static Delegate GetOnSeekTo_IHandler ()
		{
			if (cb_onSeekTo_I == null)
				cb_onSeekTo_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnSeekTo_I);
			return cb_onSeekTo_I;
		}

		static void n_OnSeekTo_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Google.YouTube.Player.IYouTubePlayerPlaybackEventListener __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerPlaybackEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSeekTo (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSeekTo_I;
		public void OnSeekTo (int p0)
		{
			if (id_onSeekTo_I == IntPtr.Zero)
				id_onSeekTo_I = JNIEnv.GetMethodID (class_ref, "onSeekTo", "(I)V");
			JNIEnv.CallVoidMethod (Handle, id_onSeekTo_I, new JValue (p0));
		}

		static Delegate cb_onStopped;
#pragma warning disable 0169
		static Delegate GetOnStoppedHandler ()
		{
			if (cb_onStopped == null)
				cb_onStopped = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStopped);
			return cb_onStopped;
		}

		static void n_OnStopped (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.YouTube.Player.IYouTubePlayerPlaybackEventListener __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerPlaybackEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStopped ();
		}
#pragma warning restore 0169

		IntPtr id_onStopped;
		public void OnStopped ()
		{
			if (id_onStopped == IntPtr.Zero)
				id_onStopped = JNIEnv.GetMethodID (class_ref, "onStopped", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onStopped);
		}

	}

	public partial class BufferingEventArgs : global::System.EventArgs {

		public BufferingEventArgs (bool p0)
		{
			this.p0 = p0;
		}

		bool p0;
		public bool P0 {
			get { return p0; }
		}
	}

	public partial class SeekToEventArgs : global::System.EventArgs {

		public SeekToEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/android/youtube/player/YouTubePlayer_PlaybackEventListenerImplementor")]
	internal sealed class IYouTubePlayerPlaybackEventListenerImplementor : global::Java.Lang.Object, IYouTubePlayerPlaybackEventListener {

		object sender;

		public IYouTubePlayerPlaybackEventListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/google/android/youtube/player/YouTubePlayer_PlaybackEventListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BufferingEventArgs> OnBufferingHandler;
#pragma warning restore 0649

		public void OnBuffering (bool p0)
		{
			var __h = OnBufferingHandler;
			if (__h != null)
				__h (sender, new BufferingEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler OnPausedHandler;
#pragma warning restore 0649

		public void OnPaused ()
		{
			var __h = OnPausedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnPlayingHandler;
#pragma warning restore 0649

		public void OnPlaying ()
		{
			var __h = OnPlayingHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<SeekToEventArgs> OnSeekToHandler;
#pragma warning restore 0649

		public void OnSeekTo (int p0)
		{
			var __h = OnSeekToHandler;
			if (__h != null)
				__h (sender, new SeekToEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler OnStoppedHandler;
#pragma warning restore 0649

		public void OnStopped ()
		{
			var __h = OnStoppedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IYouTubePlayerPlaybackEventListenerImplementor value)
		{
			return value.OnBufferingHandler == null && value.OnPausedHandler == null && value.OnPlayingHandler == null && value.OnSeekToHandler == null && value.OnStoppedHandler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer.PlayerStateChangeListener']"
	[Register ("com/google/android/youtube/player/YouTubePlayer$PlayerStateChangeListener", "", "Google.YouTube.Player.IYouTubePlayerPlayerStateChangeListenerInvoker")]
	public partial interface IYouTubePlayerPlayerStateChangeListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer.PlayerStateChangeListener']/method[@name='onAdStarted' and count(parameter)=0]"
		[Register ("onAdStarted", "()V", "GetOnAdStartedHandler:Google.YouTube.Player.IYouTubePlayerPlayerStateChangeListenerInvoker, YoutubeJavaBindings")]
		void OnAdStarted ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer.PlayerStateChangeListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.google.android.youtube.player.YouTubePlayer.ErrorReason']]"
		[Register ("onError", "(Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;)V", "GetOnError_Lcom_google_android_youtube_player_YouTubePlayer_ErrorReason_Handler:Google.YouTube.Player.IYouTubePlayerPlayerStateChangeListenerInvoker, YoutubeJavaBindings")]
		void OnError (global::Google.YouTube.Player.YouTubePlayerErrorReason p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer.PlayerStateChangeListener']/method[@name='onLoaded' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onLoaded", "(Ljava/lang/String;)V", "GetOnLoaded_Ljava_lang_String_Handler:Google.YouTube.Player.IYouTubePlayerPlayerStateChangeListenerInvoker, YoutubeJavaBindings")]
		void OnLoaded (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer.PlayerStateChangeListener']/method[@name='onLoading' and count(parameter)=0]"
		[Register ("onLoading", "()V", "GetOnLoadingHandler:Google.YouTube.Player.IYouTubePlayerPlayerStateChangeListenerInvoker, YoutubeJavaBindings")]
		void OnLoading ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer.PlayerStateChangeListener']/method[@name='onVideoEnded' and count(parameter)=0]"
		[Register ("onVideoEnded", "()V", "GetOnVideoEndedHandler:Google.YouTube.Player.IYouTubePlayerPlayerStateChangeListenerInvoker, YoutubeJavaBindings")]
		void OnVideoEnded ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer.PlayerStateChangeListener']/method[@name='onVideoStarted' and count(parameter)=0]"
		[Register ("onVideoStarted", "()V", "GetOnVideoStartedHandler:Google.YouTube.Player.IYouTubePlayerPlayerStateChangeListenerInvoker, YoutubeJavaBindings")]
		void OnVideoStarted ();

	}

	[global::Android.Runtime.Register ("com/google/android/youtube/player/YouTubePlayer$PlayerStateChangeListener", DoNotGenerateAcw=true)]
	internal class IYouTubePlayerPlayerStateChangeListenerInvoker : global::Java.Lang.Object, IYouTubePlayerPlayerStateChangeListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/youtube/player/YouTubePlayer$PlayerStateChangeListener");
		IntPtr class_ref;

		public static IYouTubePlayerPlayerStateChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IYouTubePlayerPlayerStateChangeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.youtube.player.YouTubePlayer.PlayerStateChangeListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IYouTubePlayerPlayerStateChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IYouTubePlayerPlayerStateChangeListenerInvoker); }
		}

		static Delegate cb_onAdStarted;
#pragma warning disable 0169
		static Delegate GetOnAdStartedHandler ()
		{
			if (cb_onAdStarted == null)
				cb_onAdStarted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAdStarted);
			return cb_onAdStarted;
		}

		static void n_OnAdStarted (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.YouTube.Player.IYouTubePlayerPlayerStateChangeListener __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerPlayerStateChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAdStarted ();
		}
#pragma warning restore 0169

		IntPtr id_onAdStarted;
		public void OnAdStarted ()
		{
			if (id_onAdStarted == IntPtr.Zero)
				id_onAdStarted = JNIEnv.GetMethodID (class_ref, "onAdStarted", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onAdStarted);
		}

		static Delegate cb_onError_Lcom_google_android_youtube_player_YouTubePlayer_ErrorReason_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_google_android_youtube_player_YouTubePlayer_ErrorReason_Handler ()
		{
			if (cb_onError_Lcom_google_android_youtube_player_YouTubePlayer_ErrorReason_ == null)
				cb_onError_Lcom_google_android_youtube_player_YouTubePlayer_ErrorReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Lcom_google_android_youtube_player_YouTubePlayer_ErrorReason_);
			return cb_onError_Lcom_google_android_youtube_player_YouTubePlayer_ErrorReason_;
		}

		static void n_OnError_Lcom_google_android_youtube_player_YouTubePlayer_ErrorReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.YouTube.Player.IYouTubePlayerPlayerStateChangeListener __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerPlayerStateChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.YouTube.Player.YouTubePlayerErrorReason p0 = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubePlayerErrorReason> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_google_android_youtube_player_YouTubePlayer_ErrorReason_;
		public void OnError (global::Google.YouTube.Player.YouTubePlayerErrorReason p0)
		{
			if (id_onError_Lcom_google_android_youtube_player_YouTubePlayer_ErrorReason_ == IntPtr.Zero)
				id_onError_Lcom_google_android_youtube_player_YouTubePlayer_ErrorReason_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/google/android/youtube/player/YouTubePlayer$ErrorReason;)V");
			JNIEnv.CallVoidMethod (Handle, id_onError_Lcom_google_android_youtube_player_YouTubePlayer_ErrorReason_, new JValue (p0));
		}

		static Delegate cb_onLoaded_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnLoaded_Ljava_lang_String_Handler ()
		{
			if (cb_onLoaded_Ljava_lang_String_ == null)
				cb_onLoaded_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLoaded_Ljava_lang_String_);
			return cb_onLoaded_Ljava_lang_String_;
		}

		static void n_OnLoaded_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.YouTube.Player.IYouTubePlayerPlayerStateChangeListener __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerPlayerStateChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLoaded (p0);
		}
#pragma warning restore 0169

		IntPtr id_onLoaded_Ljava_lang_String_;
		public void OnLoaded (string p0)
		{
			if (id_onLoaded_Ljava_lang_String_ == IntPtr.Zero)
				id_onLoaded_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onLoaded", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_onLoaded_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onLoading;
#pragma warning disable 0169
		static Delegate GetOnLoadingHandler ()
		{
			if (cb_onLoading == null)
				cb_onLoading = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLoading);
			return cb_onLoading;
		}

		static void n_OnLoading (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.YouTube.Player.IYouTubePlayerPlayerStateChangeListener __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerPlayerStateChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLoading ();
		}
#pragma warning restore 0169

		IntPtr id_onLoading;
		public void OnLoading ()
		{
			if (id_onLoading == IntPtr.Zero)
				id_onLoading = JNIEnv.GetMethodID (class_ref, "onLoading", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onLoading);
		}

		static Delegate cb_onVideoEnded;
#pragma warning disable 0169
		static Delegate GetOnVideoEndedHandler ()
		{
			if (cb_onVideoEnded == null)
				cb_onVideoEnded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnVideoEnded);
			return cb_onVideoEnded;
		}

		static void n_OnVideoEnded (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.YouTube.Player.IYouTubePlayerPlayerStateChangeListener __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerPlayerStateChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnVideoEnded ();
		}
#pragma warning restore 0169

		IntPtr id_onVideoEnded;
		public void OnVideoEnded ()
		{
			if (id_onVideoEnded == IntPtr.Zero)
				id_onVideoEnded = JNIEnv.GetMethodID (class_ref, "onVideoEnded", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onVideoEnded);
		}

		static Delegate cb_onVideoStarted;
#pragma warning disable 0169
		static Delegate GetOnVideoStartedHandler ()
		{
			if (cb_onVideoStarted == null)
				cb_onVideoStarted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnVideoStarted);
			return cb_onVideoStarted;
		}

		static void n_OnVideoStarted (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.YouTube.Player.IYouTubePlayerPlayerStateChangeListener __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerPlayerStateChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnVideoStarted ();
		}
#pragma warning restore 0169

		IntPtr id_onVideoStarted;
		public void OnVideoStarted ()
		{
			if (id_onVideoStarted == IntPtr.Zero)
				id_onVideoStarted = JNIEnv.GetMethodID (class_ref, "onVideoStarted", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onVideoStarted);
		}

	}

	public partial class ErrorEventArgs : global::System.EventArgs {

		public ErrorEventArgs (global::Google.YouTube.Player.YouTubePlayerErrorReason p0)
		{
			this.p0 = p0;
		}

		global::Google.YouTube.Player.YouTubePlayerErrorReason p0;
		public global::Google.YouTube.Player.YouTubePlayerErrorReason P0 {
			get { return p0; }
		}
	}

	public partial class LoadedEventArgs : global::System.EventArgs {

		public LoadedEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/android/youtube/player/YouTubePlayer_PlayerStateChangeListenerImplementor")]
	internal sealed class IYouTubePlayerPlayerStateChangeListenerImplementor : global::Java.Lang.Object, IYouTubePlayerPlayerStateChangeListener {

		object sender;

		public IYouTubePlayerPlayerStateChangeListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/google/android/youtube/player/YouTubePlayer_PlayerStateChangeListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler OnAdStartedHandler;
#pragma warning restore 0649

		public void OnAdStarted ()
		{
			var __h = OnAdStartedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<ErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

		public void OnError (global::Google.YouTube.Player.YouTubePlayerErrorReason p0)
		{
			var __h = OnErrorHandler;
			if (__h != null)
				__h (sender, new ErrorEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<LoadedEventArgs> OnLoadedHandler;
#pragma warning restore 0649

		public void OnLoaded (string p0)
		{
			var __h = OnLoadedHandler;
			if (__h != null)
				__h (sender, new LoadedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler OnLoadingHandler;
#pragma warning restore 0649

		public void OnLoading ()
		{
			var __h = OnLoadingHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnVideoEndedHandler;
#pragma warning restore 0649

		public void OnVideoEnded ()
		{
			var __h = OnVideoEndedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnVideoStartedHandler;
#pragma warning restore 0649

		public void OnVideoStarted ()
		{
			var __h = OnVideoStartedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IYouTubePlayerPlayerStateChangeListenerImplementor value)
		{
			return value.OnAdStartedHandler == null && value.OnErrorHandler == null && value.OnLoadedHandler == null && value.OnLoadingHandler == null && value.OnVideoEndedHandler == null && value.OnVideoStartedHandler == null;
		}
	}


	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayer.PlayerStyle']"
	[global::Android.Runtime.Register ("com/google/android/youtube/player/YouTubePlayer$PlayerStyle", DoNotGenerateAcw=true)]
	public sealed partial class YouTubePlayerPlayerStyle : global::Java.Lang.Enum {


		static IntPtr CHROMELESS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayer.PlayerStyle']/field[@name='CHROMELESS']"
		[Register ("CHROMELESS")]
		public static global::Google.YouTube.Player.YouTubePlayerPlayerStyle Chromeless {
			get {
				if (CHROMELESS_jfieldId == IntPtr.Zero)
					CHROMELESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHROMELESS", "Lcom/google/android/youtube/player/YouTubePlayer$PlayerStyle;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHROMELESS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubePlayerPlayerStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CHROMELESS_jfieldId == IntPtr.Zero)
					CHROMELESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHROMELESS", "Lcom/google/android/youtube/player/YouTubePlayer$PlayerStyle;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CHROMELESS_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr DEFAULT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayer.PlayerStyle']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Google.YouTube.Player.YouTubePlayerPlayerStyle Default {
			get {
				if (DEFAULT_jfieldId == IntPtr.Zero)
					DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lcom/google/android/youtube/player/YouTubePlayer$PlayerStyle;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubePlayerPlayerStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DEFAULT_jfieldId == IntPtr.Zero)
					DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lcom/google/android/youtube/player/YouTubePlayer$PlayerStyle;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DEFAULT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr MINIMAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayer.PlayerStyle']/field[@name='MINIMAL']"
		[Register ("MINIMAL")]
		public static global::Google.YouTube.Player.YouTubePlayerPlayerStyle Minimal {
			get {
				if (MINIMAL_jfieldId == IntPtr.Zero)
					MINIMAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MINIMAL", "Lcom/google/android/youtube/player/YouTubePlayer$PlayerStyle;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MINIMAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubePlayerPlayerStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MINIMAL_jfieldId == IntPtr.Zero)
					MINIMAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MINIMAL", "Lcom/google/android/youtube/player/YouTubePlayer$PlayerStyle;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, MINIMAL_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/youtube/player/YouTubePlayer$PlayerStyle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (YouTubePlayerPlayerStyle); }
		}

		internal YouTubePlayerPlayerStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayer.PlayerStyle']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/android/youtube/player/YouTubePlayer$PlayerStyle;", "")]
		public static global::Google.YouTube.Player.YouTubePlayerPlayerStyle ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/android/youtube/player/YouTubePlayer$PlayerStyle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Google.YouTube.Player.YouTubePlayerPlayerStyle __ret = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubePlayerPlayerStyle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayer.PlayerStyle']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/android/youtube/player/YouTubePlayer$PlayerStyle;", "")]
		public static global::Google.YouTube.Player.YouTubePlayerPlayerStyle[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/android/youtube/player/YouTubePlayer$PlayerStyle;");
			return (global::Google.YouTube.Player.YouTubePlayerPlayerStyle[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Google.YouTube.Player.YouTubePlayerPlayerStyle));
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer.PlaylistEventListener']"
	[Register ("com/google/android/youtube/player/YouTubePlayer$PlaylistEventListener", "", "Google.YouTube.Player.IYouTubePlayerPlaylistEventListenerInvoker")]
	public partial interface IYouTubePlayerPlaylistEventListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer.PlaylistEventListener']/method[@name='onNext' and count(parameter)=0]"
		[Register ("onNext", "()V", "GetOnNextHandler:Google.YouTube.Player.IYouTubePlayerPlaylistEventListenerInvoker, YoutubeJavaBindings")]
		void OnNext ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer.PlaylistEventListener']/method[@name='onPlaylistEnded' and count(parameter)=0]"
		[Register ("onPlaylistEnded", "()V", "GetOnPlaylistEndedHandler:Google.YouTube.Player.IYouTubePlayerPlaylistEventListenerInvoker, YoutubeJavaBindings")]
		void OnPlaylistEnded ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer.PlaylistEventListener']/method[@name='onPrevious' and count(parameter)=0]"
		[Register ("onPrevious", "()V", "GetOnPreviousHandler:Google.YouTube.Player.IYouTubePlayerPlaylistEventListenerInvoker, YoutubeJavaBindings")]
		void OnPrevious ();

	}

	[global::Android.Runtime.Register ("com/google/android/youtube/player/YouTubePlayer$PlaylistEventListener", DoNotGenerateAcw=true)]
	internal class IYouTubePlayerPlaylistEventListenerInvoker : global::Java.Lang.Object, IYouTubePlayerPlaylistEventListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/youtube/player/YouTubePlayer$PlaylistEventListener");
		IntPtr class_ref;

		public static IYouTubePlayerPlaylistEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IYouTubePlayerPlaylistEventListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.youtube.player.YouTubePlayer.PlaylistEventListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IYouTubePlayerPlaylistEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IYouTubePlayerPlaylistEventListenerInvoker); }
		}

		static Delegate cb_onNext;
#pragma warning disable 0169
		static Delegate GetOnNextHandler ()
		{
			if (cb_onNext == null)
				cb_onNext = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnNext);
			return cb_onNext;
		}

		static void n_OnNext (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.YouTube.Player.IYouTubePlayerPlaylistEventListener __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerPlaylistEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNext ();
		}
#pragma warning restore 0169

		IntPtr id_onNext;
		public void OnNext ()
		{
			if (id_onNext == IntPtr.Zero)
				id_onNext = JNIEnv.GetMethodID (class_ref, "onNext", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onNext);
		}

		static Delegate cb_onPlaylistEnded;
#pragma warning disable 0169
		static Delegate GetOnPlaylistEndedHandler ()
		{
			if (cb_onPlaylistEnded == null)
				cb_onPlaylistEnded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPlaylistEnded);
			return cb_onPlaylistEnded;
		}

		static void n_OnPlaylistEnded (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.YouTube.Player.IYouTubePlayerPlaylistEventListener __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerPlaylistEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPlaylistEnded ();
		}
#pragma warning restore 0169

		IntPtr id_onPlaylistEnded;
		public void OnPlaylistEnded ()
		{
			if (id_onPlaylistEnded == IntPtr.Zero)
				id_onPlaylistEnded = JNIEnv.GetMethodID (class_ref, "onPlaylistEnded", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onPlaylistEnded);
		}

		static Delegate cb_onPrevious;
#pragma warning disable 0169
		static Delegate GetOnPreviousHandler ()
		{
			if (cb_onPrevious == null)
				cb_onPrevious = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPrevious);
			return cb_onPrevious;
		}

		static void n_OnPrevious (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.YouTube.Player.IYouTubePlayerPlaylistEventListener __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerPlaylistEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPrevious ();
		}
#pragma warning restore 0169

		IntPtr id_onPrevious;
		public void OnPrevious ()
		{
			if (id_onPrevious == IntPtr.Zero)
				id_onPrevious = JNIEnv.GetMethodID (class_ref, "onPrevious", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onPrevious);
		}

	}

	[global::Android.Runtime.Register ("mono/com/google/android/youtube/player/YouTubePlayer_PlaylistEventListenerImplementor")]
	internal sealed class IYouTubePlayerPlaylistEventListenerImplementor : global::Java.Lang.Object, IYouTubePlayerPlaylistEventListener {

		object sender;

		public IYouTubePlayerPlaylistEventListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/google/android/youtube/player/YouTubePlayer_PlaylistEventListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler OnNextHandler;
#pragma warning restore 0649

		public void OnNext ()
		{
			var __h = OnNextHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnPlaylistEndedHandler;
#pragma warning restore 0649

		public void OnPlaylistEnded ()
		{
			var __h = OnPlaylistEndedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnPreviousHandler;
#pragma warning restore 0649

		public void OnPrevious ()
		{
			var __h = OnPreviousHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IYouTubePlayerPlaylistEventListenerImplementor value)
		{
			return value.OnNextHandler == null && value.OnPlaylistEndedHandler == null && value.OnPreviousHandler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer.Provider']"
	[Register ("com/google/android/youtube/player/YouTubePlayer$Provider", "", "Google.YouTube.Player.IYouTubePlayerProviderInvoker")]
	public partial interface IYouTubePlayerProvider : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer.Provider']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.android.youtube.player.YouTubePlayer.OnInitializedListener']]"
		[Register ("initialize", "(Ljava/lang/String;Lcom/google/android/youtube/player/YouTubePlayer$OnInitializedListener;)V", "GetInitialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_Handler:Google.YouTube.Player.IYouTubePlayerProviderInvoker, YoutubeJavaBindings")]
		void Initialize (string p0, global::Google.YouTube.Player.IYouTubePlayerOnInitializedListener p1);

	}

	[global::Android.Runtime.Register ("com/google/android/youtube/player/YouTubePlayer$Provider", DoNotGenerateAcw=true)]
	internal class IYouTubePlayerProviderInvoker : global::Java.Lang.Object, IYouTubePlayerProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/youtube/player/YouTubePlayer$Provider");
		IntPtr class_ref;

		public static IYouTubePlayerProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IYouTubePlayerProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.youtube.player.YouTubePlayer.Provider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IYouTubePlayerProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IYouTubePlayerProviderInvoker); }
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
			global::Google.YouTube.Player.IYouTubePlayerProvider __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Google.YouTube.Player.IYouTubePlayerOnInitializedListener p1 = (global::Google.YouTube.Player.IYouTubePlayerOnInitializedListener)global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerOnInitializedListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_;
		public void Initialize (string p0, global::Google.YouTube.Player.IYouTubePlayerOnInitializedListener p1)
		{
			if (id_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_ == IntPtr.Zero)
				id_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_ = JNIEnv.GetMethodID (class_ref, "initialize", "(Ljava/lang/String;Lcom/google/android/youtube/player/YouTubePlayer$OnInitializedListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}


	[Register ("com/google/android/youtube/player/YouTubePlayer")]
	public abstract class YouTubePlayer {

		internal YouTubePlayer ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/field[@name='FULLSCREEN_FLAG_ALWAYS_FULLSCREEN_IN_LANDSCAPE']"
		[Register ("FULLSCREEN_FLAG_ALWAYS_FULLSCREEN_IN_LANDSCAPE")]
		public const int FullscreenFlagAlwaysFullscreenInLandscape = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/field[@name='FULLSCREEN_FLAG_CONTROL_ORIENTATION']"
		[Register ("FULLSCREEN_FLAG_CONTROL_ORIENTATION")]
		public const int FullscreenFlagControlOrientation = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/field[@name='FULLSCREEN_FLAG_CONTROL_SYSTEM_UI']"
		[Register ("FULLSCREEN_FLAG_CONTROL_SYSTEM_UI")]
		public const int FullscreenFlagControlSystemUi = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/field[@name='FULLSCREEN_FLAG_CUSTOM_LAYOUT']"
		[Register ("FULLSCREEN_FLAG_CUSTOM_LAYOUT")]
		public const int FullscreenFlagCustomLayout = (int) 8;
	}

	[System.Obsolete ("Use the 'YouTubePlayer' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class YouTubePlayerConsts : YouTubePlayer {

		private YouTubePlayerConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']"
	[Register ("com/google/android/youtube/player/YouTubePlayer", "", "Google.YouTube.Player.IYouTubePlayerInvoker")]
	public partial interface IYouTubePlayer : IJavaObject {

		int CurrentTimeMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='getCurrentTimeMillis' and count(parameter)=0]"
			[Register ("getCurrentTimeMillis", "()I", "GetGetCurrentTimeMillisHandler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")] get;
		}

		int DurationMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='getDurationMillis' and count(parameter)=0]"
			[Register ("getDurationMillis", "()I", "GetGetDurationMillisHandler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")] get;
		}

		int FullscreenControlFlags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='getFullscreenControlFlags' and count(parameter)=0]"
			[Register ("getFullscreenControlFlags", "()I", "GetGetFullscreenControlFlagsHandler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='setFullscreenControlFlags' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFullscreenControlFlags", "(I)V", "GetSetFullscreenControlFlags_IHandler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")] set;
		}

		bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='hasNext' and count(parameter)=0]"
			[Register ("hasNext", "()Z", "GetHasNextHandler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")] get;
		}

		bool HasPrevious {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='hasPrevious' and count(parameter)=0]"
			[Register ("hasPrevious", "()Z", "GetHasPreviousHandler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")] get;
		}

		bool IsPlaying {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='isPlaying' and count(parameter)=0]"
			[Register ("isPlaying", "()Z", "GetIsPlayingHandler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='addFullscreenControlFlag' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("addFullscreenControlFlag", "(I)V", "GetAddFullscreenControlFlag_IHandler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void AddFullscreenControlFlag (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='cuePlaylist' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("cuePlaylist", "(Ljava/lang/String;)V", "GetCuePlaylist_Ljava_lang_String_Handler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void CuePlaylist (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='cuePlaylist' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("cuePlaylist", "(Ljava/lang/String;II)V", "GetCuePlaylist_Ljava_lang_String_IIHandler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void CuePlaylist (string p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='cueVideo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("cueVideo", "(Ljava/lang/String;)V", "GetCueVideo_Ljava_lang_String_Handler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void CueVideo (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='cueVideo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("cueVideo", "(Ljava/lang/String;I)V", "GetCueVideo_Ljava_lang_String_IHandler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void CueVideo (string p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='cueVideos' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("cueVideos", "(Ljava/util/List;)V", "GetCueVideos_Ljava_util_List_Handler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void CueVideos (global::System.Collections.Generic.IList<string> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='cueVideos' and count(parameter)=3 and parameter[1][@type='java.util.List'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("cueVideos", "(Ljava/util/List;II)V", "GetCueVideos_Ljava_util_List_IIHandler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void CueVideos (global::System.Collections.Generic.IList<string> p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='loadPlaylist' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadPlaylist", "(Ljava/lang/String;)V", "GetLoadPlaylist_Ljava_lang_String_Handler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void LoadPlaylist (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='loadPlaylist' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("loadPlaylist", "(Ljava/lang/String;II)V", "GetLoadPlaylist_Ljava_lang_String_IIHandler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void LoadPlaylist (string p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='loadVideo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadVideo", "(Ljava/lang/String;)V", "GetLoadVideo_Ljava_lang_String_Handler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void LoadVideo (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='loadVideo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("loadVideo", "(Ljava/lang/String;I)V", "GetLoadVideo_Ljava_lang_String_IHandler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void LoadVideo (string p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='loadVideos' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("loadVideos", "(Ljava/util/List;)V", "GetLoadVideos_Ljava_util_List_Handler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void LoadVideos (global::System.Collections.Generic.IList<string> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='loadVideos' and count(parameter)=3 and parameter[1][@type='java.util.List'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("loadVideos", "(Ljava/util/List;II)V", "GetLoadVideos_Ljava_util_List_IIHandler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void LoadVideos (global::System.Collections.Generic.IList<string> p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()V", "GetNextHandler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void Next ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void Pause ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='play' and count(parameter)=0]"
		[Register ("play", "()V", "GetPlayHandler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void Play ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='previous' and count(parameter)=0]"
		[Register ("previous", "()V", "GetPreviousHandler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void Previous ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void Release ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='seekRelativeMillis' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("seekRelativeMillis", "(I)V", "GetSeekRelativeMillis_IHandler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void SeekRelativeMillis (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='seekToMillis' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("seekToMillis", "(I)V", "GetSeekToMillis_IHandler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void SeekToMillis (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='setFullscreen' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setFullscreen", "(Z)V", "GetSetFullscreen_ZHandler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void SetFullscreen (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='setManageAudioFocus' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setManageAudioFocus", "(Z)V", "GetSetManageAudioFocus_ZHandler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void SetManageAudioFocus (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='setOnFullscreenListener' and count(parameter)=1 and parameter[1][@type='com.google.android.youtube.player.YouTubePlayer.OnFullscreenListener']]"
		[Register ("setOnFullscreenListener", "(Lcom/google/android/youtube/player/YouTubePlayer$OnFullscreenListener;)V", "GetSetOnFullscreenListener_Lcom_google_android_youtube_player_YouTubePlayer_OnFullscreenListener_Handler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void SetOnFullscreenListener (global::Google.YouTube.Player.IYouTubePlayerOnFullscreenListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='setPlaybackEventListener' and count(parameter)=1 and parameter[1][@type='com.google.android.youtube.player.YouTubePlayer.PlaybackEventListener']]"
		[Register ("setPlaybackEventListener", "(Lcom/google/android/youtube/player/YouTubePlayer$PlaybackEventListener;)V", "GetSetPlaybackEventListener_Lcom_google_android_youtube_player_YouTubePlayer_PlaybackEventListener_Handler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void SetPlaybackEventListener (global::Google.YouTube.Player.IYouTubePlayerPlaybackEventListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='setPlayerStateChangeListener' and count(parameter)=1 and parameter[1][@type='com.google.android.youtube.player.YouTubePlayer.PlayerStateChangeListener']]"
		[Register ("setPlayerStateChangeListener", "(Lcom/google/android/youtube/player/YouTubePlayer$PlayerStateChangeListener;)V", "GetSetPlayerStateChangeListener_Lcom_google_android_youtube_player_YouTubePlayer_PlayerStateChangeListener_Handler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void SetPlayerStateChangeListener (global::Google.YouTube.Player.IYouTubePlayerPlayerStateChangeListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='setPlayerStyle' and count(parameter)=1 and parameter[1][@type='com.google.android.youtube.player.YouTubePlayer.PlayerStyle']]"
		[Register ("setPlayerStyle", "(Lcom/google/android/youtube/player/YouTubePlayer$PlayerStyle;)V", "GetSetPlayerStyle_Lcom_google_android_youtube_player_YouTubePlayer_PlayerStyle_Handler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void SetPlayerStyle (global::Google.YouTube.Player.YouTubePlayerPlayerStyle p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='setPlaylistEventListener' and count(parameter)=1 and parameter[1][@type='com.google.android.youtube.player.YouTubePlayer.PlaylistEventListener']]"
		[Register ("setPlaylistEventListener", "(Lcom/google/android/youtube/player/YouTubePlayer$PlaylistEventListener;)V", "GetSetPlaylistEventListener_Lcom_google_android_youtube_player_YouTubePlayer_PlaylistEventListener_Handler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void SetPlaylistEventListener (global::Google.YouTube.Player.IYouTubePlayerPlaylistEventListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubePlayer']/method[@name='setShowFullscreenButton' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShowFullscreenButton", "(Z)V", "GetSetShowFullscreenButton_ZHandler:Google.YouTube.Player.IYouTubePlayerInvoker, YoutubeJavaBindings")]
		void SetShowFullscreenButton (bool p0);

	}

	[global::Android.Runtime.Register ("com/google/android/youtube/player/YouTubePlayer", DoNotGenerateAcw=true)]
	internal class IYouTubePlayerInvoker : global::Java.Lang.Object, IYouTubePlayer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/youtube/player/YouTubePlayer");
		IntPtr class_ref;

		public static IYouTubePlayer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IYouTubePlayer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.youtube.player.YouTubePlayer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IYouTubePlayerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IYouTubePlayerInvoker); }
		}

		static Delegate cb_getCurrentTimeMillis;
#pragma warning disable 0169
		static Delegate GetGetCurrentTimeMillisHandler ()
		{
			if (cb_getCurrentTimeMillis == null)
				cb_getCurrentTimeMillis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentTimeMillis);
			return cb_getCurrentTimeMillis;
		}

		static int n_GetCurrentTimeMillis (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentTimeMillis;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentTimeMillis;
		public int CurrentTimeMillis {
			get {
				if (id_getCurrentTimeMillis == IntPtr.Zero)
					id_getCurrentTimeMillis = JNIEnv.GetMethodID (class_ref, "getCurrentTimeMillis", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getCurrentTimeMillis);
			}
		}

		static Delegate cb_getDurationMillis;
#pragma warning disable 0169
		static Delegate GetGetDurationMillisHandler ()
		{
			if (cb_getDurationMillis == null)
				cb_getDurationMillis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDurationMillis);
			return cb_getDurationMillis;
		}

		static int n_GetDurationMillis (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DurationMillis;
		}
#pragma warning restore 0169

		IntPtr id_getDurationMillis;
		public int DurationMillis {
			get {
				if (id_getDurationMillis == IntPtr.Zero)
					id_getDurationMillis = JNIEnv.GetMethodID (class_ref, "getDurationMillis", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getDurationMillis);
			}
		}

		static Delegate cb_getFullscreenControlFlags;
#pragma warning disable 0169
		static Delegate GetGetFullscreenControlFlagsHandler ()
		{
			if (cb_getFullscreenControlFlags == null)
				cb_getFullscreenControlFlags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFullscreenControlFlags);
			return cb_getFullscreenControlFlags;
		}

		static int n_GetFullscreenControlFlags (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FullscreenControlFlags;
		}
#pragma warning restore 0169

		static Delegate cb_setFullscreenControlFlags_I;
#pragma warning disable 0169
		static Delegate GetSetFullscreenControlFlags_IHandler ()
		{
			if (cb_setFullscreenControlFlags_I == null)
				cb_setFullscreenControlFlags_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFullscreenControlFlags_I);
			return cb_setFullscreenControlFlags_I;
		}

		static void n_SetFullscreenControlFlags_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FullscreenControlFlags = p0;
		}
#pragma warning restore 0169

		IntPtr id_getFullscreenControlFlags;
		IntPtr id_setFullscreenControlFlags_I;
		public int FullscreenControlFlags {
			get {
				if (id_getFullscreenControlFlags == IntPtr.Zero)
					id_getFullscreenControlFlags = JNIEnv.GetMethodID (class_ref, "getFullscreenControlFlags", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getFullscreenControlFlags);
			}
			set {
				if (id_setFullscreenControlFlags_I == IntPtr.Zero)
					id_setFullscreenControlFlags_I = JNIEnv.GetMethodID (class_ref, "setFullscreenControlFlags", "(I)V");
				JNIEnv.CallVoidMethod (Handle, id_setFullscreenControlFlags_I, new JValue (value));
			}
		}

		static Delegate cb_hasNext;
#pragma warning disable 0169
		static Delegate GetHasNextHandler ()
		{
			if (cb_hasNext == null)
				cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasNext);
			return cb_hasNext;
		}

		static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		IntPtr id_hasNext;
		public bool HasNext {
			get {
				if (id_hasNext == IntPtr.Zero)
					id_hasNext = JNIEnv.GetMethodID (class_ref, "hasNext", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasNext);
			}
		}

		static Delegate cb_hasPrevious;
#pragma warning disable 0169
		static Delegate GetHasPreviousHandler ()
		{
			if (cb_hasPrevious == null)
				cb_hasPrevious = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasPrevious);
			return cb_hasPrevious;
		}

		static bool n_HasPrevious (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasPrevious;
		}
#pragma warning restore 0169

		IntPtr id_hasPrevious;
		public bool HasPrevious {
			get {
				if (id_hasPrevious == IntPtr.Zero)
					id_hasPrevious = JNIEnv.GetMethodID (class_ref, "hasPrevious", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasPrevious);
			}
		}

		static Delegate cb_isPlaying;
#pragma warning disable 0169
		static Delegate GetIsPlayingHandler ()
		{
			if (cb_isPlaying == null)
				cb_isPlaying = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPlaying);
			return cb_isPlaying;
		}

		static bool n_IsPlaying (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPlaying;
		}
#pragma warning restore 0169

		IntPtr id_isPlaying;
		public bool IsPlaying {
			get {
				if (id_isPlaying == IntPtr.Zero)
					id_isPlaying = JNIEnv.GetMethodID (class_ref, "isPlaying", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isPlaying);
			}
		}

		static Delegate cb_addFullscreenControlFlag_I;
#pragma warning disable 0169
		static Delegate GetAddFullscreenControlFlag_IHandler ()
		{
			if (cb_addFullscreenControlFlag_I == null)
				cb_addFullscreenControlFlag_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_AddFullscreenControlFlag_I);
			return cb_addFullscreenControlFlag_I;
		}

		static void n_AddFullscreenControlFlag_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddFullscreenControlFlag (p0);
		}
#pragma warning restore 0169

		IntPtr id_addFullscreenControlFlag_I;
		public void AddFullscreenControlFlag (int p0)
		{
			if (id_addFullscreenControlFlag_I == IntPtr.Zero)
				id_addFullscreenControlFlag_I = JNIEnv.GetMethodID (class_ref, "addFullscreenControlFlag", "(I)V");
			JNIEnv.CallVoidMethod (Handle, id_addFullscreenControlFlag_I, new JValue (p0));
		}

		static Delegate cb_cuePlaylist_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCuePlaylist_Ljava_lang_String_Handler ()
		{
			if (cb_cuePlaylist_Ljava_lang_String_ == null)
				cb_cuePlaylist_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CuePlaylist_Ljava_lang_String_);
			return cb_cuePlaylist_Ljava_lang_String_;
		}

		static void n_CuePlaylist_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CuePlaylist (p0);
		}
#pragma warning restore 0169

		IntPtr id_cuePlaylist_Ljava_lang_String_;
		public void CuePlaylist (string p0)
		{
			if (id_cuePlaylist_Ljava_lang_String_ == IntPtr.Zero)
				id_cuePlaylist_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "cuePlaylist", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_cuePlaylist_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_cuePlaylist_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetCuePlaylist_Ljava_lang_String_IIHandler ()
		{
			if (cb_cuePlaylist_Ljava_lang_String_II == null)
				cb_cuePlaylist_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_CuePlaylist_Ljava_lang_String_II);
			return cb_cuePlaylist_Ljava_lang_String_II;
		}

		static void n_CuePlaylist_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CuePlaylist (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_cuePlaylist_Ljava_lang_String_II;
		public void CuePlaylist (string p0, int p1, int p2)
		{
			if (id_cuePlaylist_Ljava_lang_String_II == IntPtr.Zero)
				id_cuePlaylist_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "cuePlaylist", "(Ljava/lang/String;II)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_cuePlaylist_Ljava_lang_String_II, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_cueVideo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCueVideo_Ljava_lang_String_Handler ()
		{
			if (cb_cueVideo_Ljava_lang_String_ == null)
				cb_cueVideo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CueVideo_Ljava_lang_String_);
			return cb_cueVideo_Ljava_lang_String_;
		}

		static void n_CueVideo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CueVideo (p0);
		}
#pragma warning restore 0169

		IntPtr id_cueVideo_Ljava_lang_String_;
		public void CueVideo (string p0)
		{
			if (id_cueVideo_Ljava_lang_String_ == IntPtr.Zero)
				id_cueVideo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "cueVideo", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_cueVideo_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_cueVideo_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetCueVideo_Ljava_lang_String_IHandler ()
		{
			if (cb_cueVideo_Ljava_lang_String_I == null)
				cb_cueVideo_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_CueVideo_Ljava_lang_String_I);
			return cb_cueVideo_Ljava_lang_String_I;
		}

		static void n_CueVideo_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CueVideo (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_cueVideo_Ljava_lang_String_I;
		public void CueVideo (string p0, int p1)
		{
			if (id_cueVideo_Ljava_lang_String_I == IntPtr.Zero)
				id_cueVideo_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "cueVideo", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_cueVideo_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_cueVideos_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetCueVideos_Ljava_util_List_Handler ()
		{
			if (cb_cueVideos_Ljava_util_List_ == null)
				cb_cueVideos_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CueVideos_Ljava_util_List_);
			return cb_cueVideos_Ljava_util_List_;
		}

		static void n_CueVideos_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CueVideos (p0);
		}
#pragma warning restore 0169

		IntPtr id_cueVideos_Ljava_util_List_;
		public void CueVideos (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_cueVideos_Ljava_util_List_ == IntPtr.Zero)
				id_cueVideos_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "cueVideos", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod (Handle, id_cueVideos_Ljava_util_List_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_cueVideos_Ljava_util_List_II;
#pragma warning disable 0169
		static Delegate GetCueVideos_Ljava_util_List_IIHandler ()
		{
			if (cb_cueVideos_Ljava_util_List_II == null)
				cb_cueVideos_Ljava_util_List_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_CueVideos_Ljava_util_List_II);
			return cb_cueVideos_Ljava_util_List_II;
		}

		static void n_CueVideos_Ljava_util_List_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CueVideos (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_cueVideos_Ljava_util_List_II;
		public void CueVideos (global::System.Collections.Generic.IList<string> p0, int p1, int p2)
		{
			if (id_cueVideos_Ljava_util_List_II == IntPtr.Zero)
				id_cueVideos_Ljava_util_List_II = JNIEnv.GetMethodID (class_ref, "cueVideos", "(Ljava/util/List;II)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod (Handle, id_cueVideos_Ljava_util_List_II, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_loadPlaylist_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadPlaylist_Ljava_lang_String_Handler ()
		{
			if (cb_loadPlaylist_Ljava_lang_String_ == null)
				cb_loadPlaylist_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadPlaylist_Ljava_lang_String_);
			return cb_loadPlaylist_Ljava_lang_String_;
		}

		static void n_LoadPlaylist_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadPlaylist (p0);
		}
#pragma warning restore 0169

		IntPtr id_loadPlaylist_Ljava_lang_String_;
		public void LoadPlaylist (string p0)
		{
			if (id_loadPlaylist_Ljava_lang_String_ == IntPtr.Zero)
				id_loadPlaylist_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadPlaylist", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_loadPlaylist_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_loadPlaylist_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetLoadPlaylist_Ljava_lang_String_IIHandler ()
		{
			if (cb_loadPlaylist_Ljava_lang_String_II == null)
				cb_loadPlaylist_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_LoadPlaylist_Ljava_lang_String_II);
			return cb_loadPlaylist_Ljava_lang_String_II;
		}

		static void n_LoadPlaylist_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadPlaylist (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_loadPlaylist_Ljava_lang_String_II;
		public void LoadPlaylist (string p0, int p1, int p2)
		{
			if (id_loadPlaylist_Ljava_lang_String_II == IntPtr.Zero)
				id_loadPlaylist_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "loadPlaylist", "(Ljava/lang/String;II)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_loadPlaylist_Ljava_lang_String_II, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_loadVideo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadVideo_Ljava_lang_String_Handler ()
		{
			if (cb_loadVideo_Ljava_lang_String_ == null)
				cb_loadVideo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadVideo_Ljava_lang_String_);
			return cb_loadVideo_Ljava_lang_String_;
		}

		static void n_LoadVideo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadVideo (p0);
		}
#pragma warning restore 0169

		IntPtr id_loadVideo_Ljava_lang_String_;
		public void LoadVideo (string p0)
		{
			if (id_loadVideo_Ljava_lang_String_ == IntPtr.Zero)
				id_loadVideo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadVideo", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_loadVideo_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_loadVideo_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetLoadVideo_Ljava_lang_String_IHandler ()
		{
			if (cb_loadVideo_Ljava_lang_String_I == null)
				cb_loadVideo_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_LoadVideo_Ljava_lang_String_I);
			return cb_loadVideo_Ljava_lang_String_I;
		}

		static void n_LoadVideo_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadVideo (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_loadVideo_Ljava_lang_String_I;
		public void LoadVideo (string p0, int p1)
		{
			if (id_loadVideo_Ljava_lang_String_I == IntPtr.Zero)
				id_loadVideo_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "loadVideo", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_loadVideo_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_loadVideos_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetLoadVideos_Ljava_util_List_Handler ()
		{
			if (cb_loadVideos_Ljava_util_List_ == null)
				cb_loadVideos_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadVideos_Ljava_util_List_);
			return cb_loadVideos_Ljava_util_List_;
		}

		static void n_LoadVideos_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadVideos (p0);
		}
#pragma warning restore 0169

		IntPtr id_loadVideos_Ljava_util_List_;
		public void LoadVideos (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_loadVideos_Ljava_util_List_ == IntPtr.Zero)
				id_loadVideos_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "loadVideos", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod (Handle, id_loadVideos_Ljava_util_List_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_loadVideos_Ljava_util_List_II;
#pragma warning disable 0169
		static Delegate GetLoadVideos_Ljava_util_List_IIHandler ()
		{
			if (cb_loadVideos_Ljava_util_List_II == null)
				cb_loadVideos_Ljava_util_List_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_LoadVideos_Ljava_util_List_II);
			return cb_loadVideos_Ljava_util_List_II;
		}

		static void n_LoadVideos_Ljava_util_List_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadVideos (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_loadVideos_Ljava_util_List_II;
		public void LoadVideos (global::System.Collections.Generic.IList<string> p0, int p1, int p2)
		{
			if (id_loadVideos_Ljava_util_List_II == IntPtr.Zero)
				id_loadVideos_Ljava_util_List_II = JNIEnv.GetMethodID (class_ref, "loadVideos", "(Ljava/util/List;II)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod (Handle, id_loadVideos_Ljava_util_List_II, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Next);
			return cb_next;
		}

		static void n_Next (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Next ();
		}
#pragma warning restore 0169

		IntPtr id_next;
		public void Next ()
		{
			if (id_next == IntPtr.Zero)
				id_next = JNIEnv.GetMethodID (class_ref, "next", "()V");
			JNIEnv.CallVoidMethod (Handle, id_next);
		}

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Pause);
			return cb_pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		IntPtr id_pause;
		public void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			JNIEnv.CallVoidMethod (Handle, id_pause);
		}

		static Delegate cb_play;
#pragma warning disable 0169
		static Delegate GetPlayHandler ()
		{
			if (cb_play == null)
				cb_play = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Play);
			return cb_play;
		}

		static void n_Play (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Play ();
		}
#pragma warning restore 0169

		IntPtr id_play;
		public void Play ()
		{
			if (id_play == IntPtr.Zero)
				id_play = JNIEnv.GetMethodID (class_ref, "play", "()V");
			JNIEnv.CallVoidMethod (Handle, id_play);
		}

		static Delegate cb_previous;
#pragma warning disable 0169
		static Delegate GetPreviousHandler ()
		{
			if (cb_previous == null)
				cb_previous = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Previous);
			return cb_previous;
		}

		static void n_Previous (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Previous ();
		}
#pragma warning restore 0169

		IntPtr id_previous;
		public void Previous ()
		{
			if (id_previous == IntPtr.Zero)
				id_previous = JNIEnv.GetMethodID (class_ref, "previous", "()V");
			JNIEnv.CallVoidMethod (Handle, id_previous);
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		IntPtr id_release;
		public void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			JNIEnv.CallVoidMethod (Handle, id_release);
		}

		static Delegate cb_seekRelativeMillis_I;
#pragma warning disable 0169
		static Delegate GetSeekRelativeMillis_IHandler ()
		{
			if (cb_seekRelativeMillis_I == null)
				cb_seekRelativeMillis_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SeekRelativeMillis_I);
			return cb_seekRelativeMillis_I;
		}

		static void n_SeekRelativeMillis_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeekRelativeMillis (p0);
		}
#pragma warning restore 0169

		IntPtr id_seekRelativeMillis_I;
		public void SeekRelativeMillis (int p0)
		{
			if (id_seekRelativeMillis_I == IntPtr.Zero)
				id_seekRelativeMillis_I = JNIEnv.GetMethodID (class_ref, "seekRelativeMillis", "(I)V");
			JNIEnv.CallVoidMethod (Handle, id_seekRelativeMillis_I, new JValue (p0));
		}

		static Delegate cb_seekToMillis_I;
#pragma warning disable 0169
		static Delegate GetSeekToMillis_IHandler ()
		{
			if (cb_seekToMillis_I == null)
				cb_seekToMillis_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SeekToMillis_I);
			return cb_seekToMillis_I;
		}

		static void n_SeekToMillis_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeekToMillis (p0);
		}
#pragma warning restore 0169

		IntPtr id_seekToMillis_I;
		public void SeekToMillis (int p0)
		{
			if (id_seekToMillis_I == IntPtr.Zero)
				id_seekToMillis_I = JNIEnv.GetMethodID (class_ref, "seekToMillis", "(I)V");
			JNIEnv.CallVoidMethod (Handle, id_seekToMillis_I, new JValue (p0));
		}

		static Delegate cb_setFullscreen_Z;
#pragma warning disable 0169
		static Delegate GetSetFullscreen_ZHandler ()
		{
			if (cb_setFullscreen_Z == null)
				cb_setFullscreen_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFullscreen_Z);
			return cb_setFullscreen_Z;
		}

		static void n_SetFullscreen_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFullscreen (p0);
		}
#pragma warning restore 0169

		IntPtr id_setFullscreen_Z;
		public void SetFullscreen (bool p0)
		{
			if (id_setFullscreen_Z == IntPtr.Zero)
				id_setFullscreen_Z = JNIEnv.GetMethodID (class_ref, "setFullscreen", "(Z)V");
			JNIEnv.CallVoidMethod (Handle, id_setFullscreen_Z, new JValue (p0));
		}

		static Delegate cb_setManageAudioFocus_Z;
#pragma warning disable 0169
		static Delegate GetSetManageAudioFocus_ZHandler ()
		{
			if (cb_setManageAudioFocus_Z == null)
				cb_setManageAudioFocus_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetManageAudioFocus_Z);
			return cb_setManageAudioFocus_Z;
		}

		static void n_SetManageAudioFocus_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetManageAudioFocus (p0);
		}
#pragma warning restore 0169

		IntPtr id_setManageAudioFocus_Z;
		public void SetManageAudioFocus (bool p0)
		{
			if (id_setManageAudioFocus_Z == IntPtr.Zero)
				id_setManageAudioFocus_Z = JNIEnv.GetMethodID (class_ref, "setManageAudioFocus", "(Z)V");
			JNIEnv.CallVoidMethod (Handle, id_setManageAudioFocus_Z, new JValue (p0));
		}

		static Delegate cb_setOnFullscreenListener_Lcom_google_android_youtube_player_YouTubePlayer_OnFullscreenListener_;
#pragma warning disable 0169
		static Delegate GetSetOnFullscreenListener_Lcom_google_android_youtube_player_YouTubePlayer_OnFullscreenListener_Handler ()
		{
			if (cb_setOnFullscreenListener_Lcom_google_android_youtube_player_YouTubePlayer_OnFullscreenListener_ == null)
				cb_setOnFullscreenListener_Lcom_google_android_youtube_player_YouTubePlayer_OnFullscreenListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnFullscreenListener_Lcom_google_android_youtube_player_YouTubePlayer_OnFullscreenListener_);
			return cb_setOnFullscreenListener_Lcom_google_android_youtube_player_YouTubePlayer_OnFullscreenListener_;
		}

		static void n_SetOnFullscreenListener_Lcom_google_android_youtube_player_YouTubePlayer_OnFullscreenListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.YouTube.Player.IYouTubePlayerOnFullscreenListener p0 = (global::Google.YouTube.Player.IYouTubePlayerOnFullscreenListener)global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerOnFullscreenListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnFullscreenListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnFullscreenListener_Lcom_google_android_youtube_player_YouTubePlayer_OnFullscreenListener_;
		public void SetOnFullscreenListener (global::Google.YouTube.Player.IYouTubePlayerOnFullscreenListener p0)
		{
			if (id_setOnFullscreenListener_Lcom_google_android_youtube_player_YouTubePlayer_OnFullscreenListener_ == IntPtr.Zero)
				id_setOnFullscreenListener_Lcom_google_android_youtube_player_YouTubePlayer_OnFullscreenListener_ = JNIEnv.GetMethodID (class_ref, "setOnFullscreenListener", "(Lcom/google/android/youtube/player/YouTubePlayer$OnFullscreenListener;)V");
			JNIEnv.CallVoidMethod (Handle, id_setOnFullscreenListener_Lcom_google_android_youtube_player_YouTubePlayer_OnFullscreenListener_, new JValue (p0));
		}

		static Delegate cb_setPlaybackEventListener_Lcom_google_android_youtube_player_YouTubePlayer_PlaybackEventListener_;
#pragma warning disable 0169
		static Delegate GetSetPlaybackEventListener_Lcom_google_android_youtube_player_YouTubePlayer_PlaybackEventListener_Handler ()
		{
			if (cb_setPlaybackEventListener_Lcom_google_android_youtube_player_YouTubePlayer_PlaybackEventListener_ == null)
				cb_setPlaybackEventListener_Lcom_google_android_youtube_player_YouTubePlayer_PlaybackEventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlaybackEventListener_Lcom_google_android_youtube_player_YouTubePlayer_PlaybackEventListener_);
			return cb_setPlaybackEventListener_Lcom_google_android_youtube_player_YouTubePlayer_PlaybackEventListener_;
		}

		static void n_SetPlaybackEventListener_Lcom_google_android_youtube_player_YouTubePlayer_PlaybackEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.YouTube.Player.IYouTubePlayerPlaybackEventListener p0 = (global::Google.YouTube.Player.IYouTubePlayerPlaybackEventListener)global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerPlaybackEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPlaybackEventListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setPlaybackEventListener_Lcom_google_android_youtube_player_YouTubePlayer_PlaybackEventListener_;
		public void SetPlaybackEventListener (global::Google.YouTube.Player.IYouTubePlayerPlaybackEventListener p0)
		{
			if (id_setPlaybackEventListener_Lcom_google_android_youtube_player_YouTubePlayer_PlaybackEventListener_ == IntPtr.Zero)
				id_setPlaybackEventListener_Lcom_google_android_youtube_player_YouTubePlayer_PlaybackEventListener_ = JNIEnv.GetMethodID (class_ref, "setPlaybackEventListener", "(Lcom/google/android/youtube/player/YouTubePlayer$PlaybackEventListener;)V");
			JNIEnv.CallVoidMethod (Handle, id_setPlaybackEventListener_Lcom_google_android_youtube_player_YouTubePlayer_PlaybackEventListener_, new JValue (p0));
		}

		static Delegate cb_setPlayerStateChangeListener_Lcom_google_android_youtube_player_YouTubePlayer_PlayerStateChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetPlayerStateChangeListener_Lcom_google_android_youtube_player_YouTubePlayer_PlayerStateChangeListener_Handler ()
		{
			if (cb_setPlayerStateChangeListener_Lcom_google_android_youtube_player_YouTubePlayer_PlayerStateChangeListener_ == null)
				cb_setPlayerStateChangeListener_Lcom_google_android_youtube_player_YouTubePlayer_PlayerStateChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlayerStateChangeListener_Lcom_google_android_youtube_player_YouTubePlayer_PlayerStateChangeListener_);
			return cb_setPlayerStateChangeListener_Lcom_google_android_youtube_player_YouTubePlayer_PlayerStateChangeListener_;
		}

		static void n_SetPlayerStateChangeListener_Lcom_google_android_youtube_player_YouTubePlayer_PlayerStateChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.YouTube.Player.IYouTubePlayerPlayerStateChangeListener p0 = (global::Google.YouTube.Player.IYouTubePlayerPlayerStateChangeListener)global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerPlayerStateChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPlayerStateChangeListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setPlayerStateChangeListener_Lcom_google_android_youtube_player_YouTubePlayer_PlayerStateChangeListener_;
		public void SetPlayerStateChangeListener (global::Google.YouTube.Player.IYouTubePlayerPlayerStateChangeListener p0)
		{
			if (id_setPlayerStateChangeListener_Lcom_google_android_youtube_player_YouTubePlayer_PlayerStateChangeListener_ == IntPtr.Zero)
				id_setPlayerStateChangeListener_Lcom_google_android_youtube_player_YouTubePlayer_PlayerStateChangeListener_ = JNIEnv.GetMethodID (class_ref, "setPlayerStateChangeListener", "(Lcom/google/android/youtube/player/YouTubePlayer$PlayerStateChangeListener;)V");
			JNIEnv.CallVoidMethod (Handle, id_setPlayerStateChangeListener_Lcom_google_android_youtube_player_YouTubePlayer_PlayerStateChangeListener_, new JValue (p0));
		}

		static Delegate cb_setPlayerStyle_Lcom_google_android_youtube_player_YouTubePlayer_PlayerStyle_;
#pragma warning disable 0169
		static Delegate GetSetPlayerStyle_Lcom_google_android_youtube_player_YouTubePlayer_PlayerStyle_Handler ()
		{
			if (cb_setPlayerStyle_Lcom_google_android_youtube_player_YouTubePlayer_PlayerStyle_ == null)
				cb_setPlayerStyle_Lcom_google_android_youtube_player_YouTubePlayer_PlayerStyle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlayerStyle_Lcom_google_android_youtube_player_YouTubePlayer_PlayerStyle_);
			return cb_setPlayerStyle_Lcom_google_android_youtube_player_YouTubePlayer_PlayerStyle_;
		}

		static void n_SetPlayerStyle_Lcom_google_android_youtube_player_YouTubePlayer_PlayerStyle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.YouTube.Player.YouTubePlayerPlayerStyle p0 = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubePlayerPlayerStyle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPlayerStyle (p0);
		}
#pragma warning restore 0169

		IntPtr id_setPlayerStyle_Lcom_google_android_youtube_player_YouTubePlayer_PlayerStyle_;
		public void SetPlayerStyle (global::Google.YouTube.Player.YouTubePlayerPlayerStyle p0)
		{
			if (id_setPlayerStyle_Lcom_google_android_youtube_player_YouTubePlayer_PlayerStyle_ == IntPtr.Zero)
				id_setPlayerStyle_Lcom_google_android_youtube_player_YouTubePlayer_PlayerStyle_ = JNIEnv.GetMethodID (class_ref, "setPlayerStyle", "(Lcom/google/android/youtube/player/YouTubePlayer$PlayerStyle;)V");
			JNIEnv.CallVoidMethod (Handle, id_setPlayerStyle_Lcom_google_android_youtube_player_YouTubePlayer_PlayerStyle_, new JValue (p0));
		}

		static Delegate cb_setPlaylistEventListener_Lcom_google_android_youtube_player_YouTubePlayer_PlaylistEventListener_;
#pragma warning disable 0169
		static Delegate GetSetPlaylistEventListener_Lcom_google_android_youtube_player_YouTubePlayer_PlaylistEventListener_Handler ()
		{
			if (cb_setPlaylistEventListener_Lcom_google_android_youtube_player_YouTubePlayer_PlaylistEventListener_ == null)
				cb_setPlaylistEventListener_Lcom_google_android_youtube_player_YouTubePlayer_PlaylistEventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlaylistEventListener_Lcom_google_android_youtube_player_YouTubePlayer_PlaylistEventListener_);
			return cb_setPlaylistEventListener_Lcom_google_android_youtube_player_YouTubePlayer_PlaylistEventListener_;
		}

		static void n_SetPlaylistEventListener_Lcom_google_android_youtube_player_YouTubePlayer_PlaylistEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.YouTube.Player.IYouTubePlayerPlaylistEventListener p0 = (global::Google.YouTube.Player.IYouTubePlayerPlaylistEventListener)global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayerPlaylistEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPlaylistEventListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setPlaylistEventListener_Lcom_google_android_youtube_player_YouTubePlayer_PlaylistEventListener_;
		public void SetPlaylistEventListener (global::Google.YouTube.Player.IYouTubePlayerPlaylistEventListener p0)
		{
			if (id_setPlaylistEventListener_Lcom_google_android_youtube_player_YouTubePlayer_PlaylistEventListener_ == IntPtr.Zero)
				id_setPlaylistEventListener_Lcom_google_android_youtube_player_YouTubePlayer_PlaylistEventListener_ = JNIEnv.GetMethodID (class_ref, "setPlaylistEventListener", "(Lcom/google/android/youtube/player/YouTubePlayer$PlaylistEventListener;)V");
			JNIEnv.CallVoidMethod (Handle, id_setPlaylistEventListener_Lcom_google_android_youtube_player_YouTubePlayer_PlaylistEventListener_, new JValue (p0));
		}

		static Delegate cb_setShowFullscreenButton_Z;
#pragma warning disable 0169
		static Delegate GetSetShowFullscreenButton_ZHandler ()
		{
			if (cb_setShowFullscreenButton_Z == null)
				cb_setShowFullscreenButton_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowFullscreenButton_Z);
			return cb_setShowFullscreenButton_Z;
		}

		static void n_SetShowFullscreenButton_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Google.YouTube.Player.IYouTubePlayer __this = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.IYouTubePlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShowFullscreenButton (p0);
		}
#pragma warning restore 0169

		IntPtr id_setShowFullscreenButton_Z;
		public void SetShowFullscreenButton (bool p0)
		{
			if (id_setShowFullscreenButton_Z == IntPtr.Zero)
				id_setShowFullscreenButton_Z = JNIEnv.GetMethodID (class_ref, "setShowFullscreenButton", "(Z)V");
			JNIEnv.CallVoidMethod (Handle, id_setShowFullscreenButton_Z, new JValue (p0));
		}

	}

}
