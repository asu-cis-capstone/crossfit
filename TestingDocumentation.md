# Testing Documentation
Because Xamarin requires that any automated testing be done through its "Test Cloud", we have had to implement testing directly into the code. The "Test Cloud" cost upwards of $12,000/year and is not a tool within our budget. 

###Database Connect
Class: WodstarMobileApp.Azure.cs (line 32)<br/>
Scope: <br/>
Code: <br/>
public static void InitializeAzure ()
		{
			Console.WriteLine ("InitializeAzure method called"); <br/>
			//connect to Azure <br/>
			azureClient = new MobileServiceClient ("https://wodstar.azure-mobile.net/", "aLMiHItrYdPiUdpjhotOQZAHKLDqVd66"); <br/>
			Console.WriteLine ("azureClient = " + azureClient.ApplicationUri);<br/>
			CurrentPlatform.Init ();<br/>
			<b>//DB connect test<br/>
			Console.WriteLine ("Azure initialization successful");</b><br/>
		}//end initializeAzure method<br/>

###Database Read
Class: WodstarMobileApp.Azure.cs (line 56) <br/>
Scope: <br/>
Code:

###User Account Creation 
Class: WodstarMobileApp.Azure.cs (line 70) <br/>
Scope: <br/>
Code:

###Facebook Login
Class: WodstarMobileApp.Droid.MainActivity.cs (line 43) <br/>
Scope: <br/>
Code:

###Facebook Logout
Class: <br/>
Scope: <br/>
Code:

###YouTube Connect
Class: WodstarMobileApp.Droid.MovementLibraryActivity.cs (line 81)<br/>
Scope: <br/>
Code: 

###YouTube Load
Class: WodstarMobileApp.Droid.MovementLibraryActivity.cs (line 89) <br/>
Scope: <br/>
Code:

###WOD Page Search
Class: <br/>
Scope: <br/>
Code:

###WOD Data Added
Class: WodstarMobileApp.Azure.cs (<br/>
Scope: <br/>
Code:





