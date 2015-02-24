package wodstarmobileapp.droid;


public class MainActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer,
		com.facebook.Request.GraphUserCallback
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onActivityResult:(IILandroid/content/Intent;)V:GetOnActivityResult_IILandroid_content_Intent_Handler\n" +
			"n_onCompleted:(Lcom/facebook/model/GraphUser;Lcom/facebook/Response;)V:GetOnCompleted_Lcom_facebook_model_GraphUser_Lcom_facebook_Response_Handler:Xamarin.Facebook.Request/IGraphUserCallbackInvoker, Xamarin.Facebook\n" +
			"";
		mono.android.Runtime.register ("WodstarMobileApp.Droid.MainActivity, WodstarMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainActivity.class, __md_methods);
	}


	public MainActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MainActivity.class)
			mono.android.TypeManager.Activate ("WodstarMobileApp.Droid.MainActivity, WodstarMobileApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onActivityResult (int p0, int p1, android.content.Intent p2)
	{
		n_onActivityResult (p0, p1, p2);
	}

	private native void n_onActivityResult (int p0, int p1, android.content.Intent p2);


	public void onCompleted (com.facebook.model.GraphUser p0, com.facebook.Response p1)
	{
		n_onCompleted (p0, p1);
	}

	private native void n_onCompleted (com.facebook.model.GraphUser p0, com.facebook.Response p1);

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
