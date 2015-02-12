Quick Start Guide
=======

Development Environment - Xamarin Studio
-----------
Download Xamarin Studio to your machine. 
###
* It is necessary that at least the “Indie” subscription is purchased.
* In many cases, the Xamarin download will take a few tries. It’s important to make sure that the Android SDK is fully downloaded, which you may have to do separately. 

Connect Xamarin to the Github repo
###
* https://github.com/asu-cis-capstone/crossfit/

Within the WodstarMobileApp solution there are two sub-projects containing the Android and Apple/IOS specific interfaces, and main project contains the platform neutral data models.
###
* Note that the IOS sub-project can only be compiled and modeled from MacOS because Apple does not release a cross-platform development kit.
* In the top left of Xamarin Studio, select the device you would like to run the application on. You can either plug in an Android device or an iOS device if you are on a Mac computer, and Xamarin will automatically run on that device. Alternatively, you can also select an emulator to run the program on. Select the emulator and start it up.
* Hit the run button in debug mode to run the project on your selected emulator or device, or hit the run button in release mode to compile a final project.

General Notes: This application is being developed under the MVC design principles, please take that into consideration if committing any changes.

Cloud Storage - Azure
-----------
* Create administrative account to manage the Azure cloud services.
* Create database instance.
* Run provided SQL commands to create the necessary database users, tables, and populate core tables.

Authentication - Social Media
-----------
Facebook
###
* Register for Facebook Developer account
* Create a new application ID to enter into the Crossfit source code

Google Play
###
* Register for Google Play Developer account

Apple store
###
* Register for Apple Developer account 
