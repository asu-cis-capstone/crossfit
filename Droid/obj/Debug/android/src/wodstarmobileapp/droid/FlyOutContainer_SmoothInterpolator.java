package wodstarmobileapp.droid;


public class FlyOutContainer_SmoothInterpolator
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.animation.TimeInterpolator
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_getInterpolation:(F)F:GetGetInterpolation_FHandler:Android.Animation.ITimeInterpolatorInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("WodstarMobileApp.Droid.FlyOutContainer/SmoothInterpolator, WodstarMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", FlyOutContainer_SmoothInterpolator.class, __md_methods);
	}


	public FlyOutContainer_SmoothInterpolator () throws java.lang.Throwable
	{
		super ();
		if (getClass () == FlyOutContainer_SmoothInterpolator.class)
			mono.android.TypeManager.Activate ("WodstarMobileApp.Droid.FlyOutContainer/SmoothInterpolator, WodstarMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public float getInterpolation (float p0)
	{
		return n_getInterpolation (p0);
	}

	private native float n_getInterpolation (float p0);

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
