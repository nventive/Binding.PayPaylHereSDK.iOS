//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;

namespace PPH {
	[Register("PayPalRetailSDK", true)]
	public unsafe partial class PayPalRetailSDK : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PayPalRetailSDK");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PayPalRetailSDK () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PayPalRetailSDK (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PayPalRetailSDK (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("addDeviceDiscoveredListener:")]
		[CompilerGenerated]
		public unsafe static NSObject AddDeviceDiscoveredListener ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailDeviceDiscoveredEvent))]PPRetailDeviceDiscoveredEvent listener)
		{
			if (listener == null)
				throw new ArgumentNullException ("listener");
			BlockLiteral *block_ptr_listener;
			BlockLiteral block_listener;
			block_listener = new BlockLiteral ();
			block_ptr_listener = &block_listener;
			block_listener.SetupBlockUnsafe (Trampolines.SDPPRetailDeviceDiscoveredEvent.Handler, listener);
			
			NSObject ret;
			ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("addDeviceDiscoveredListener:"), (IntPtr) block_ptr_listener));
			block_ptr_listener->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("captureAuthorizedTransaction:invoiceId:totalAmount:gratuityAmount:currency:callback:")]
		[CompilerGenerated]
		public unsafe static void CaptureAuthorizedTransaction (string authorizationId, string invoiceId, NSDecimalNumber totalAmount, NSDecimalNumber gratuityAmount, string currency, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailTransactionManagerCaptureAuthorizedTransactionHandler))]PPRetailTransactionManagerCaptureAuthorizedTransactionHandler callback)
		{
			var nsauthorizationId = NSString.CreateNative (authorizationId);
			var nsinvoiceId = NSString.CreateNative (invoiceId);
			var nscurrency = NSString.CreateNative (currency);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailTransactionManagerCaptureAuthorizedTransactionHandler.Handler, callback);
			}
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("captureAuthorizedTransaction:invoiceId:totalAmount:gratuityAmount:currency:callback:"), nsauthorizationId, nsinvoiceId, totalAmount == null ? IntPtr.Zero : totalAmount.Handle, gratuityAmount == null ? IntPtr.Zero : gratuityAmount.Handle, nscurrency, (IntPtr) block_ptr_callback);
			NSString.ReleaseNative (nsauthorizationId);
			NSString.ReleaseNative (nsinvoiceId);
			NSString.ReleaseNative (nscurrency);
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("checkIfSwiperIsEligibleForMerchant")]
		[CompilerGenerated]
		public static bool CheckIfSwiperIsEligibleForMerchant ()
		{
			return global::ApiDefinitions.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("checkIfSwiperIsEligibleForMerchant"));
		}
		
		[Export ("connectToLastActiveReader")]
		[CompilerGenerated]
		public static void ConnectToLastActiveReader ()
		{
			global::ApiDefinitions.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("connectToLastActiveReader"));
		}
		
		[Export ("createTransaction:")]
		[CompilerGenerated]
		public static PPRetailTransactionContext CreateTransaction (PPRetailInvoice invoice)
		{
			if (invoice == null)
				throw new ArgumentNullException ("invoice");
			return  Runtime.GetNSObject<PPRetailTransactionContext> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("createTransaction:"), invoice.Handle));
		}
		
		[Export ("getCurrentNavigationController")]
		[CompilerGenerated]
		public static global::UIKit.UINavigationController CurrentNavigationController ()
		{
			return  Runtime.GetNSObject<global::UIKit.UINavigationController> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getCurrentNavigationController")));
		}
		
		[Export ("endCardReaderDiscovery")]
		[CompilerGenerated]
		public static void EndCardReaderDiscovery ()
		{
			global::ApiDefinitions.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("endCardReaderDiscovery"));
		}
		
		[Export ("initializeMerchant:repository:completionHandler:")]
		[CompilerGenerated]
		public unsafe static PPRetailError InitializeMerchant (string merchantToken, string repository, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailMerchantHandler))]PPRetailMerchantHandler handler)
		{
			if (merchantToken == null)
				throw new ArgumentNullException ("merchantToken");
			if (repository == null)
				throw new ArgumentNullException ("repository");
			if (handler == null)
				throw new ArgumentNullException ("handler");
			var nsmerchantToken = NSString.CreateNative (merchantToken);
			var nsrepository = NSString.CreateNative (repository);
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlockUnsafe (Trampolines.SDPPRetailMerchantHandler.Handler, handler);
			
			PPRetailError ret;
			ret =  Runtime.GetNSObject<PPRetailError> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("initializeMerchant:repository:completionHandler:"), nsmerchantToken, nsrepository, (IntPtr) block_ptr_handler));
			NSString.ReleaseNative (nsmerchantToken);
			NSString.ReleaseNative (nsrepository);
			block_ptr_handler->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("initializeMerchantWithCredentials:completionHandler:")]
		[CompilerGenerated]
		public unsafe static void InitializeMerchantWithCredentials (SdkCredential credentials, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailMerchantHandler))]PPRetailMerchantHandler handler)
		{
			if (credentials == null)
				throw new ArgumentNullException ("credentials");
			if (handler == null)
				throw new ArgumentNullException ("handler");
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlockUnsafe (Trampolines.SDPPRetailMerchantHandler.Handler, handler);
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("initializeMerchantWithCredentials:completionHandler:"), credentials.Handle, (IntPtr) block_ptr_handler);
			block_ptr_handler->CleanupBlock ();
			
		}
		
		[Export ("initializePPHRetailMerchant:completionHandler:")]
		[CompilerGenerated]
		public unsafe static void InitializePPHRetailMerchant (PPHRetailMerchant merchant, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailMerchantHandler))]PPRetailMerchantHandler handler)
		{
			if (merchant == null)
				throw new ArgumentNullException ("merchant");
			if (handler == null)
				throw new ArgumentNullException ("handler");
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlockUnsafe (Trampolines.SDPPRetailMerchantHandler.Handler, handler);
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("initializePPHRetailMerchant:completionHandler:"), merchant.Handle, (IntPtr) block_ptr_handler);
			block_ptr_handler->CleanupBlock ();
			
		}
		
		[Export ("initializeSDK")]
		[CompilerGenerated]
		public static PPRetailError InitializeSDK ()
		{
			return  Runtime.GetNSObject<PPRetailError> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("initializeSDK")));
		}
		
		[Export ("localizedStringNamed:withDefault:forTable:")]
		[CompilerGenerated]
		public static string LocalizedStringNamed (string name, string defaultValue, string table)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (defaultValue == null)
				throw new ArgumentNullException ("defaultValue");
			if (table == null)
				throw new ArgumentNullException ("table");
			var nsname = NSString.CreateNative (name);
			var nsdefaultValue = NSString.CreateNative (defaultValue);
			var nstable = NSString.CreateNative (table);
			
			string ret;
			ret = NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("localizedStringNamed:withDefault:forTable:"), nsname, nsdefaultValue, nstable));
			NSString.ReleaseNative (nsname);
			NSString.ReleaseNative (nsdefaultValue);
			NSString.ReleaseNative (nstable);
			
			return ret;
		}
		
		[Export ("logViaSDK:component:message:")]
		[CompilerGenerated]
		public static void LogViaSDK (string logLevel, string component, string message)
		{
			if (logLevel == null)
				throw new ArgumentNullException ("logLevel");
			if (component == null)
				throw new ArgumentNullException ("component");
			if (message == null)
				throw new ArgumentNullException ("message");
			var nslogLevel = NSString.CreateNative (logLevel);
			var nscomponent = NSString.CreateNative (component);
			var nsmessage = NSString.CreateNative (message);
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("logViaSDK:component:message:"), nslogLevel, nscomponent, nsmessage);
			NSString.ReleaseNative (nslogLevel);
			NSString.ReleaseNative (nscomponent);
			NSString.ReleaseNative (nsmessage);
			
		}
		
		[Export ("logout")]
		[CompilerGenerated]
		public static void Logout ()
		{
			global::ApiDefinitions.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("logout"));
		}
		
		[Export ("getMerchantCountryCode")]
		[CompilerGenerated]
		public static string MerchantCountryCode ()
		{
			return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getMerchantCountryCode")));
		}
		
		[Export ("removeDeviceDiscoveredListener:")]
		[CompilerGenerated]
		public static void RemoveDeviceDiscoveredListener (NSObject listenerToken)
		{
			if (listenerToken == null)
				throw new ArgumentNullException ("listenerToken");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("removeDeviceDiscoveredListener:"), listenerToken.Handle);
		}
		
		[Export ("retrieveAuthorizedTransactions:endDateTime:pageSize:status:callback:")]
		[CompilerGenerated]
		public unsafe static void RetrieveAuthorizedTransactions (NSDate startDateTime, NSDate endDateTime, int pageSize, NSObject[] status, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler))]PPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler callback)
		{
			var nsa_status = status == null ? null : NSArray.FromNSObjects (status);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler.Handler, callback);
			}
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("retrieveAuthorizedTransactions:endDateTime:pageSize:status:callback:"), startDateTime == null ? IntPtr.Zero : startDateTime.Handle, endDateTime == null ? IntPtr.Zero : endDateTime.Handle, pageSize, nsa_status == null ? IntPtr.Zero : nsa_status.Handle, (IntPtr) block_ptr_callback);
			if (nsa_status != null)
				nsa_status.Dispose ();
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("sendReceiptWithUI:invoice:isEmail:callback:")]
		[CompilerGenerated]
		public unsafe static void SendReceiptWithUI (global::UIKit.UINavigationController navigationController, PPRetailRetailInvoice invoice, bool isEmail, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V1))]global::System.Action<PPRetailError, NSDictionary> callback)
		{
			if (navigationController == null)
				throw new ArgumentNullException ("navigationController");
			if (invoice == null)
				throw new ArgumentNullException ("invoice");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlockUnsafe (Trampolines.SDActionArity2V1.Handler, callback);
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_bool_IntPtr (class_ptr, Selector.GetHandle ("sendReceiptWithUI:invoice:isEmail:callback:"), navigationController.Handle, invoice.Handle, isEmail, (IntPtr) block_ptr_callback);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("setRetailSDKAppDelegate:")]
		[CompilerGenerated]
		public static void SetRetailSDKAppDelegate (PPHRetailSDKAppDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setRetailSDKAppDelegate:"), @delegate.Handle);
		}
		
		[Export ("shutdownSDK")]
		[CompilerGenerated]
		public static void ShutdownSDK ()
		{
			global::ApiDefinitions.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("shutdownSDK"));
		}
		
		[Export ("startWatchingAudio")]
		[CompilerGenerated]
		public static void StartWatchingAudio ()
		{
			global::ApiDefinitions.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("startWatchingAudio"));
		}
		
		[CompilerGenerated]
		public static PPRetailDeviceManager DeviceManager {
			[Export ("deviceManager")]
			get {
				PPRetailDeviceManager ret;
				ret =  Runtime.GetNSObject<PPRetailDeviceManager> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("deviceManager")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static PPRetailTransactionManager TransactionManager {
			[Export ("transactionManager")]
			get {
				PPRetailTransactionManager ret;
				ret =  Runtime.GetNSObject<PPRetailTransactionManager> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("transactionManager")));
				return ret;
			}
			
		}
		
	} /* class PayPalRetailSDK */
}
