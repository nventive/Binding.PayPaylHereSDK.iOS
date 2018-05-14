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
	[Register("PPRetailSDK", true)]
	public unsafe partial class PPRetailSDK : PPRetailObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PPRetailSDK");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PPRetailSDK () : base (NSObjectFlag.Empty)
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
		protected PPRetailSDK (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PPRetailSDK (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("addDeviceDiscoveredListener:")]
		[CompilerGenerated]
		public unsafe virtual NSObject AddDeviceDiscoveredListener ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailDeviceDiscoveredEvent))]PPRetailDeviceDiscoveredEvent listener)
		{
			BlockLiteral *block_ptr_listener;
			BlockLiteral block_listener;
			if (listener == null){
				block_ptr_listener = null;
			} else {
				block_listener = new BlockLiteral ();
				block_ptr_listener = &block_listener;
				block_listener.SetupBlockUnsafe (Trampolines.SDPPRetailDeviceDiscoveredEvent.Handler, listener);
			}
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addDeviceDiscoveredListener:"), (IntPtr) block_ptr_listener));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addDeviceDiscoveredListener:"), (IntPtr) block_ptr_listener));
			}
			if (block_ptr_listener != null)
				block_ptr_listener->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("addPageViewedListener:")]
		[CompilerGenerated]
		public unsafe virtual NSObject AddPageViewedListener ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailPageViewedEvent))]PPRetailPageViewedEvent listener)
		{
			BlockLiteral *block_ptr_listener;
			BlockLiteral block_listener;
			if (listener == null){
				block_ptr_listener = null;
			} else {
				block_listener = new BlockLiteral ();
				block_ptr_listener = &block_listener;
				block_listener.SetupBlockUnsafe (Trampolines.SDPPRetailPageViewedEvent.Handler, listener);
			}
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addPageViewedListener:"), (IntPtr) block_ptr_listener));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addPageViewedListener:"), (IntPtr) block_ptr_listener));
			}
			if (block_ptr_listener != null)
				block_ptr_listener->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("createTransaction:")]
		[CompilerGenerated]
		public virtual PPRetailTransactionContext CreateTransaction (PPRetailInvoice invoice)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PPRetailTransactionContext> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("createTransaction:"), invoice == null ? IntPtr.Zero : invoice.Handle));
			} else {
				return  Runtime.GetNSObject<PPRetailTransactionContext> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("createTransaction:"), invoice == null ? IntPtr.Zero : invoice.Handle));
			}
		}
		
		[Export ("getDeviceManager")]
		[CompilerGenerated]
		public virtual PPRetailDeviceManager DeviceManager ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PPRetailDeviceManager> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getDeviceManager")));
			} else {
				return  Runtime.GetNSObject<PPRetailDeviceManager> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getDeviceManager")));
			}
		}
		
		[Export ("discoveredPaymentDevice:")]
		[CompilerGenerated]
		public virtual void DiscoveredPaymentDevice (PPRetailPaymentDevice pd)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("discoveredPaymentDevice:"), pd == null ? IntPtr.Zero : pd.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("discoveredPaymentDevice:"), pd == null ? IntPtr.Zero : pd.Handle);
			}
		}
		
		[Export ("logViaJs:component:message:extraData:")]
		[CompilerGenerated]
		public virtual void LogViaJs (string level, string component, string message, NSDictionary extraData)
		{
			var nslevel = NSString.CreateNative (level);
			var nscomponent = NSString.CreateNative (component);
			var nsmessage = NSString.CreateNative (message);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("logViaJs:component:message:extraData:"), nslevel, nscomponent, nsmessage, extraData == null ? IntPtr.Zero : extraData.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("logViaJs:component:message:extraData:"), nslevel, nscomponent, nsmessage, extraData == null ? IntPtr.Zero : extraData.Handle);
			}
			NSString.ReleaseNative (nslevel);
			NSString.ReleaseNative (nscomponent);
			NSString.ReleaseNative (nsmessage);
			
		}
		
		[Export ("logout")]
		[CompilerGenerated]
		public virtual void Logout ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("logout"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("logout"));
			}
		}
		
		[Export ("getMerchant")]
		[CompilerGenerated]
		public virtual PPRetailMerchant Merchant ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PPRetailMerchant> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getMerchant")));
			} else {
				return  Runtime.GetNSObject<PPRetailMerchant> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getMerchant")));
			}
		}
		
		[Export ("removeDeviceDiscoveredListener:")]
		[CompilerGenerated]
		public virtual void RemoveDeviceDiscoveredListener (NSObject listenerToken)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeDeviceDiscoveredListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeDeviceDiscoveredListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			}
		}
		
		[Export ("removePageViewedListener:")]
		[CompilerGenerated]
		public virtual void RemovePageViewedListener (NSObject listenerToken)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removePageViewedListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removePageViewedListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			}
		}
		
		[Export ("getSdkVersion")]
		[CompilerGenerated]
		public virtual string SdkVersion ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getSdkVersion")));
			} else {
				return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getSdkVersion")));
			}
		}
		
		[Export ("setExecutingEnvironment:")]
		[CompilerGenerated]
		public virtual void SetExecutingEnvironment (PPRetailSdkEnvironmentInfo sdkEnvInfo)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setExecutingEnvironment:"), sdkEnvInfo == null ? IntPtr.Zero : sdkEnvInfo.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setExecutingEnvironment:"), sdkEnvInfo == null ? IntPtr.Zero : sdkEnvInfo.Handle);
			}
		}
		
		[Export ("setLogLevel:")]
		[CompilerGenerated]
		public virtual void SetLogLevel (PPRetaillogLevel level)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setLogLevel:"), (Int64)level);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setLogLevel:"), (int)level);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setLogLevel:"), (Int64)level);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setLogLevel:"), (int)level);
				}
			}
		}
		
		[Export ("setNetworkInterceptor:")]
		[CompilerGenerated]
		public unsafe virtual void SetNetworkInterceptor ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailSDKInterceptHandler))]PPRetailSDKInterceptHandler interceptor)
		{
			BlockLiteral *block_ptr_interceptor;
			BlockLiteral block_interceptor;
			if (interceptor == null){
				block_ptr_interceptor = null;
			} else {
				block_interceptor = new BlockLiteral ();
				block_ptr_interceptor = &block_interceptor;
				block_interceptor.SetupBlockUnsafe (Trampolines.SDPPRetailSDKInterceptHandler.Handler, interceptor);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setNetworkInterceptor:"), (IntPtr) block_ptr_interceptor);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setNetworkInterceptor:"), (IntPtr) block_ptr_interceptor);
			}
			if (block_ptr_interceptor != null)
				block_ptr_interceptor->CleanupBlock ();
			
		}
		
		[Export ("getTransactionManager")]
		[CompilerGenerated]
		public virtual PPRetailTransactionManager TransactionManager ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PPRetailTransactionManager> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getTransactionManager")));
			} else {
				return  Runtime.GetNSObject<PPRetailTransactionManager> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getTransactionManager")));
			}
		}
		
	} /* class PPRetailSDK */
}
