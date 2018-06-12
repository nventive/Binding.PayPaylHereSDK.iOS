# Xamarin Binding for PayPalHere SDK iOS

A Xamarin.Android binding library for [PayPalHere SDK iOS](https://github.com/paypal/paypal-here-sdk-ios-distribution)

## Status

| VSTS | NuGet |
|------|-------|
| ![Build status](https://uno-platform.visualstudio.com/_apis/public/build/definitions/1dd81cbd-cb35-41de-a570-b0df3571a196/8/badge) | ![NuGet](https://buildstats.info/nuget/nventive.PayPalHereSDK?includePreReleases=false) |

## How to use it

First of, we higly recommend to read the documentation provided by [PayPal](https://developer.paypal.com/docs/integration/paypal-here/).

### Initialize the SDK

First of go ahead and try the iOS sample app from paypal which you can find [here](https://developer.paypal.com/docs/integration/paypal-here/using-sample-apps/).

In order for this to be setup correctly, you need to have a paypal business account and setup a rest application on the PayPal website which i wont explain here.

You will need to setup a browser or webview to login into paypal merchant page and retrieve the access token and refresh url/refresh token.

Initilization of the service after a successfull login into paypal.
``` csharp
 PayPalRetailSDK.InitializeMerchantWithCredentials(
	new SdkCredential(tokenInformation.AccessToken, refreshUrl, "live"),
    new PPRetailMerchantHandler((error, merchantInfo) => { /*do something*/ }));
```

### Device reader handler
To start a connection with a paypal reader you will need to add an information in the info.plist

``` plist
		<key>UISupportedExternalAccessoryProtocols</key>
		<array>
			<string>com.paypal.here.reader</string>
		</array>
```

Then to initialize a connection to a card reader simply call :

``` csharp
PayPalRetailSDK.DeviceManager.SearchAndConnect(new PPRetailDeviceManagerConnectionHandler((error, reader) => {
    //do something
}));
```

Be sure to to look for hardware updates and at least do the required ones (use the reader object from the callback).

### Initialize a payment

To start a payment process you need to create an invoice with PPRetailInvoice
and then create a transaction context with PayPalRetailSDK.TransactionManager.CreateTransaction();

From there you can set the receipt handler, card handler for callback and the completition handler.

Everything payment related will be handle by paypal itself no need to do anything.

Note : it is possible to initialize a manual entry card payment but creating a PPRetailManuallyEnteredCard and use the 

``` sharp
transactionContext.ContinueWithCard(card);
```

which will trigger the payment to be processed.


# Known issues
None.