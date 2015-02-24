using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.YouTube.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeInitializationResult']"
	[global::Android.Runtime.Register ("com/google/android/youtube/player/YouTubeInitializationResult", DoNotGenerateAcw=true)]
	public sealed partial class YouTubeInitializationResult : global::Java.Lang.Enum {


		static IntPtr CLIENT_LIBRARY_UPDATE_REQUIRED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeInitializationResult']/field[@name='CLIENT_LIBRARY_UPDATE_REQUIRED']"
		[Register ("CLIENT_LIBRARY_UPDATE_REQUIRED")]
		public static global::Google.YouTube.Player.YouTubeInitializationResult ClientLibraryUpdateRequired {
			get {
				if (CLIENT_LIBRARY_UPDATE_REQUIRED_jfieldId == IntPtr.Zero)
					CLIENT_LIBRARY_UPDATE_REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT_LIBRARY_UPDATE_REQUIRED", "Lcom/google/android/youtube/player/YouTubeInitializationResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLIENT_LIBRARY_UPDATE_REQUIRED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubeInitializationResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CLIENT_LIBRARY_UPDATE_REQUIRED_jfieldId == IntPtr.Zero)
					CLIENT_LIBRARY_UPDATE_REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT_LIBRARY_UPDATE_REQUIRED", "Lcom/google/android/youtube/player/YouTubeInitializationResult;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CLIENT_LIBRARY_UPDATE_REQUIRED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr DEVELOPER_KEY_INVALID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeInitializationResult']/field[@name='DEVELOPER_KEY_INVALID']"
		[Register ("DEVELOPER_KEY_INVALID")]
		public static global::Google.YouTube.Player.YouTubeInitializationResult DeveloperKeyInvalid {
			get {
				if (DEVELOPER_KEY_INVALID_jfieldId == IntPtr.Zero)
					DEVELOPER_KEY_INVALID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVELOPER_KEY_INVALID", "Lcom/google/android/youtube/player/YouTubeInitializationResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVELOPER_KEY_INVALID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubeInitializationResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DEVELOPER_KEY_INVALID_jfieldId == IntPtr.Zero)
					DEVELOPER_KEY_INVALID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVELOPER_KEY_INVALID", "Lcom/google/android/youtube/player/YouTubeInitializationResult;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DEVELOPER_KEY_INVALID_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr ERROR_CONNECTING_TO_SERVICE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeInitializationResult']/field[@name='ERROR_CONNECTING_TO_SERVICE']"
		[Register ("ERROR_CONNECTING_TO_SERVICE")]
		public static global::Google.YouTube.Player.YouTubeInitializationResult ErrorConnectingToService {
			get {
				if (ERROR_CONNECTING_TO_SERVICE_jfieldId == IntPtr.Zero)
					ERROR_CONNECTING_TO_SERVICE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_CONNECTING_TO_SERVICE", "Lcom/google/android/youtube/player/YouTubeInitializationResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_CONNECTING_TO_SERVICE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubeInitializationResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ERROR_CONNECTING_TO_SERVICE_jfieldId == IntPtr.Zero)
					ERROR_CONNECTING_TO_SERVICE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_CONNECTING_TO_SERVICE", "Lcom/google/android/youtube/player/YouTubeInitializationResult;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ERROR_CONNECTING_TO_SERVICE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr INTERNAL_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeInitializationResult']/field[@name='INTERNAL_ERROR']"
		[Register ("INTERNAL_ERROR")]
		public static global::Google.YouTube.Player.YouTubeInitializationResult InternalError {
			get {
				if (INTERNAL_ERROR_jfieldId == IntPtr.Zero)
					INTERNAL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERNAL_ERROR", "Lcom/google/android/youtube/player/YouTubeInitializationResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERNAL_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubeInitializationResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (INTERNAL_ERROR_jfieldId == IntPtr.Zero)
					INTERNAL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERNAL_ERROR", "Lcom/google/android/youtube/player/YouTubeInitializationResult;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, INTERNAL_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr INVALID_APPLICATION_SIGNATURE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeInitializationResult']/field[@name='INVALID_APPLICATION_SIGNATURE']"
		[Register ("INVALID_APPLICATION_SIGNATURE")]
		public static global::Google.YouTube.Player.YouTubeInitializationResult InvalidApplicationSignature {
			get {
				if (INVALID_APPLICATION_SIGNATURE_jfieldId == IntPtr.Zero)
					INVALID_APPLICATION_SIGNATURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_APPLICATION_SIGNATURE", "Lcom/google/android/youtube/player/YouTubeInitializationResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_APPLICATION_SIGNATURE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubeInitializationResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (INVALID_APPLICATION_SIGNATURE_jfieldId == IntPtr.Zero)
					INVALID_APPLICATION_SIGNATURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_APPLICATION_SIGNATURE", "Lcom/google/android/youtube/player/YouTubeInitializationResult;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, INVALID_APPLICATION_SIGNATURE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr NETWORK_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeInitializationResult']/field[@name='NETWORK_ERROR']"
		[Register ("NETWORK_ERROR")]
		public static global::Google.YouTube.Player.YouTubeInitializationResult NetworkError {
			get {
				if (NETWORK_ERROR_jfieldId == IntPtr.Zero)
					NETWORK_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_ERROR", "Lcom/google/android/youtube/player/YouTubeInitializationResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubeInitializationResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NETWORK_ERROR_jfieldId == IntPtr.Zero)
					NETWORK_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_ERROR", "Lcom/google/android/youtube/player/YouTubeInitializationResult;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, NETWORK_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SERVICE_DISABLED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeInitializationResult']/field[@name='SERVICE_DISABLED']"
		[Register ("SERVICE_DISABLED")]
		public static global::Google.YouTube.Player.YouTubeInitializationResult ServiceDisabled {
			get {
				if (SERVICE_DISABLED_jfieldId == IntPtr.Zero)
					SERVICE_DISABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_DISABLED", "Lcom/google/android/youtube/player/YouTubeInitializationResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SERVICE_DISABLED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubeInitializationResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SERVICE_DISABLED_jfieldId == IntPtr.Zero)
					SERVICE_DISABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_DISABLED", "Lcom/google/android/youtube/player/YouTubeInitializationResult;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SERVICE_DISABLED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SERVICE_INVALID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeInitializationResult']/field[@name='SERVICE_INVALID']"
		[Register ("SERVICE_INVALID")]
		public static global::Google.YouTube.Player.YouTubeInitializationResult ServiceInvalid {
			get {
				if (SERVICE_INVALID_jfieldId == IntPtr.Zero)
					SERVICE_INVALID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_INVALID", "Lcom/google/android/youtube/player/YouTubeInitializationResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SERVICE_INVALID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubeInitializationResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SERVICE_INVALID_jfieldId == IntPtr.Zero)
					SERVICE_INVALID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_INVALID", "Lcom/google/android/youtube/player/YouTubeInitializationResult;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SERVICE_INVALID_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SERVICE_MISSING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeInitializationResult']/field[@name='SERVICE_MISSING']"
		[Register ("SERVICE_MISSING")]
		public static global::Google.YouTube.Player.YouTubeInitializationResult ServiceMissing {
			get {
				if (SERVICE_MISSING_jfieldId == IntPtr.Zero)
					SERVICE_MISSING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_MISSING", "Lcom/google/android/youtube/player/YouTubeInitializationResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SERVICE_MISSING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubeInitializationResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SERVICE_MISSING_jfieldId == IntPtr.Zero)
					SERVICE_MISSING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_MISSING", "Lcom/google/android/youtube/player/YouTubeInitializationResult;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SERVICE_MISSING_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SERVICE_VERSION_UPDATE_REQUIRED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeInitializationResult']/field[@name='SERVICE_VERSION_UPDATE_REQUIRED']"
		[Register ("SERVICE_VERSION_UPDATE_REQUIRED")]
		public static global::Google.YouTube.Player.YouTubeInitializationResult ServiceVersionUpdateRequired {
			get {
				if (SERVICE_VERSION_UPDATE_REQUIRED_jfieldId == IntPtr.Zero)
					SERVICE_VERSION_UPDATE_REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_VERSION_UPDATE_REQUIRED", "Lcom/google/android/youtube/player/YouTubeInitializationResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SERVICE_VERSION_UPDATE_REQUIRED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubeInitializationResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SERVICE_VERSION_UPDATE_REQUIRED_jfieldId == IntPtr.Zero)
					SERVICE_VERSION_UPDATE_REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_VERSION_UPDATE_REQUIRED", "Lcom/google/android/youtube/player/YouTubeInitializationResult;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SERVICE_VERSION_UPDATE_REQUIRED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SUCCESS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeInitializationResult']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public static global::Google.YouTube.Player.YouTubeInitializationResult Success {
			get {
				if (SUCCESS_jfieldId == IntPtr.Zero)
					SUCCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUCCESS", "Lcom/google/android/youtube/player/YouTubeInitializationResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUCCESS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubeInitializationResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SUCCESS_jfieldId == IntPtr.Zero)
					SUCCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUCCESS", "Lcom/google/android/youtube/player/YouTubeInitializationResult;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SUCCESS_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr UNKNOWN_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeInitializationResult']/field[@name='UNKNOWN_ERROR']"
		[Register ("UNKNOWN_ERROR")]
		public static global::Google.YouTube.Player.YouTubeInitializationResult UnknownError {
			get {
				if (UNKNOWN_ERROR_jfieldId == IntPtr.Zero)
					UNKNOWN_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN_ERROR", "Lcom/google/android/youtube/player/YouTubeInitializationResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubeInitializationResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (UNKNOWN_ERROR_jfieldId == IntPtr.Zero)
					UNKNOWN_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN_ERROR", "Lcom/google/android/youtube/player/YouTubeInitializationResult;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, UNKNOWN_ERROR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/youtube/player/YouTubeInitializationResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (YouTubeInitializationResult); }
		}

		internal YouTubeInitializationResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isUserRecoverableError;
		public bool IsUserRecoverableError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeInitializationResult']/method[@name='isUserRecoverableError' and count(parameter)=0]"
			[Register ("isUserRecoverableError", "()Z", "GetIsUserRecoverableErrorHandler")]
			get {
				if (id_isUserRecoverableError == IntPtr.Zero)
					id_isUserRecoverableError = JNIEnv.GetMethodID (class_ref, "isUserRecoverableError", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isUserRecoverableError);
			}
		}

		static IntPtr id_getErrorDialog_Landroid_app_Activity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeInitializationResult']/method[@name='getErrorDialog' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register ("getErrorDialog", "(Landroid/app/Activity;I)Landroid/app/Dialog;", "")]
		public global::Android.App.Dialog GetErrorDialog (global::Android.App.Activity p0, int p1)
		{
			if (id_getErrorDialog_Landroid_app_Activity_I == IntPtr.Zero)
				id_getErrorDialog_Landroid_app_Activity_I = JNIEnv.GetMethodID (class_ref, "getErrorDialog", "(Landroid/app/Activity;I)Landroid/app/Dialog;");
			global::Android.App.Dialog __ret = global::Java.Lang.Object.GetObject<global::Android.App.Dialog> (JNIEnv.CallObjectMethod  (Handle, id_getErrorDialog_Landroid_app_Activity_I, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getErrorDialog_Landroid_app_Activity_ILandroid_content_DialogInterface_OnCancelListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeInitializationResult']/method[@name='getErrorDialog' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='android.content.DialogInterface.OnCancelListener']]"
		[Register ("getErrorDialog", "(Landroid/app/Activity;ILandroid/content/DialogInterface$OnCancelListener;)Landroid/app/Dialog;", "")]
		public global::Android.App.Dialog GetErrorDialog (global::Android.App.Activity p0, int p1, global::Android.Content.IDialogInterfaceOnCancelListener p2)
		{
			if (id_getErrorDialog_Landroid_app_Activity_ILandroid_content_DialogInterface_OnCancelListener_ == IntPtr.Zero)
				id_getErrorDialog_Landroid_app_Activity_ILandroid_content_DialogInterface_OnCancelListener_ = JNIEnv.GetMethodID (class_ref, "getErrorDialog", "(Landroid/app/Activity;ILandroid/content/DialogInterface$OnCancelListener;)Landroid/app/Dialog;");
			global::Android.App.Dialog __ret = global::Java.Lang.Object.GetObject<global::Android.App.Dialog> (JNIEnv.CallObjectMethod  (Handle, id_getErrorDialog_Landroid_app_Activity_ILandroid_content_DialogInterface_OnCancelListener_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeInitializationResult']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/android/youtube/player/YouTubeInitializationResult;", "")]
		public static global::Google.YouTube.Player.YouTubeInitializationResult ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/android/youtube/player/YouTubeInitializationResult;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Google.YouTube.Player.YouTubeInitializationResult __ret = global::Java.Lang.Object.GetObject<global::Google.YouTube.Player.YouTubeInitializationResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeInitializationResult']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/android/youtube/player/YouTubeInitializationResult;", "")]
		public static global::Google.YouTube.Player.YouTubeInitializationResult[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/android/youtube/player/YouTubeInitializationResult;");
			return (global::Google.YouTube.Player.YouTubeInitializationResult[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Google.YouTube.Player.YouTubeInitializationResult));
		}

	}
}
