package mono.com.facebook.ads;


public class AdListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.facebook.ads.AdListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onAdClicked:(Lcom/facebook/ads/Ad;)V:GetOnAdClicked_Lcom_facebook_ads_Ad_Handler:Xamarin.Facebook.Ads.IAdListenerInvoker, Xamarin.Facebook\n" +
			"n_onAdLoaded:(Lcom/facebook/ads/Ad;)V:GetOnAdLoaded_Lcom_facebook_ads_Ad_Handler:Xamarin.Facebook.Ads.IAdListenerInvoker, Xamarin.Facebook\n" +
			"n_onError:(Lcom/facebook/ads/Ad;Lcom/facebook/ads/AdError;)V:GetOnError_Lcom_facebook_ads_Ad_Lcom_facebook_ads_AdError_Handler:Xamarin.Facebook.Ads.IAdListenerInvoker, Xamarin.Facebook\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Facebook.Ads.IAdListenerImplementor, Xamarin.Facebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AdListenerImplementor.class, __md_methods);
	}


	public AdListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AdListenerImplementor.class)
			mono.android.TypeManager.Activate ("Xamarin.Facebook.Ads.IAdListenerImplementor, Xamarin.Facebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onAdClicked (com.facebook.ads.Ad p0)
	{
		n_onAdClicked (p0);
	}

	private native void n_onAdClicked (com.facebook.ads.Ad p0);


	public void onAdLoaded (com.facebook.ads.Ad p0)
	{
		n_onAdLoaded (p0);
	}

	private native void n_onAdLoaded (com.facebook.ads.Ad p0);


	public void onError (com.facebook.ads.Ad p0, com.facebook.ads.AdError p1)
	{
		n_onError (p0, p1);
	}

	private native void n_onError (com.facebook.ads.Ad p0, com.facebook.ads.AdError p1);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
