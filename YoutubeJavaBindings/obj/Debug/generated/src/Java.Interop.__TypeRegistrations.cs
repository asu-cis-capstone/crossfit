using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/google/android/youtube/player",
					},
					new Converter<string, Type>[]{
						lookup_com_google_android_youtube_player_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_google_android_youtube_player_mappings;
		static Type lookup_com_google_android_youtube_player_package (string klass)
		{
			if (package_com_google_android_youtube_player_mappings == null) {
				package_com_google_android_youtube_player_mappings = new string[]{
					"com/google/android/youtube/player/YouTubeApiServiceUtil:Google.YouTube.Player.YouTubeApiServiceUtil",
					"com/google/android/youtube/player/YouTubeBaseActivity:Google.YouTube.Player.YouTubeBaseActivity",
					"com/google/android/youtube/player/YouTubeInitializationResult:Google.YouTube.Player.YouTubeInitializationResult",
					"com/google/android/youtube/player/YouTubeIntents:Google.YouTube.Player.YouTubeIntents",
					"com/google/android/youtube/player/YouTubePlayer$ErrorReason:Google.YouTube.Player.YouTubePlayerErrorReason",
					"com/google/android/youtube/player/YouTubePlayer$PlayerStyle:Google.YouTube.Player.YouTubePlayerPlayerStyle",
					"com/google/android/youtube/player/YouTubePlayerFragment:Google.YouTube.Player.YouTubePlayerFragment",
					"com/google/android/youtube/player/YouTubePlayerView:Google.YouTube.Player.YouTubePlayerView",
					"com/google/android/youtube/player/YouTubeStandalonePlayer:Google.YouTube.Player.YouTubeStandalonePlayer",
					"com/google/android/youtube/player/YouTubeThumbnailLoader$ErrorReason:Google.YouTube.Player.YouTubeThumbnailLoaderErrorReason",
					"com/google/android/youtube/player/YouTubeThumbnailView:Google.YouTube.Player.YouTubeThumbnailView",
				};
			}

			return Lookup (package_com_google_android_youtube_player_mappings, klass);
		}
	}
}
