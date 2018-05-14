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
	[Register("PPRetailPaymentDevice", true)]
	public unsafe partial class PPRetailPaymentDevice : PPRetailObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PPRetailPaymentDevice");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PPRetailPaymentDevice (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PPRetailPaymentDevice (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithUniqueId:native:app:isUsb:hardwareAddress:")]
		[CompilerGenerated]
		public PPRetailPaymentDevice (string uniqueId, PPRetailObject native, PPRetailObject app, bool isUsb, string hardwareAddress)
			: base (NSObjectFlag.Empty)
		{
			var nsuniqueId = NSString.CreateNative (uniqueId);
			var nshardwareAddress = NSString.CreateNative (hardwareAddress);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_bool_IntPtr (this.Handle, Selector.GetHandle ("initWithUniqueId:native:app:isUsb:hardwareAddress:"), nsuniqueId, native == null ? IntPtr.Zero : native.Handle, app == null ? IntPtr.Zero : app.Handle, isUsb, nshardwareAddress), "initWithUniqueId:native:app:isUsb:hardwareAddress:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithUniqueId:native:app:isUsb:hardwareAddress:"), nsuniqueId, native == null ? IntPtr.Zero : native.Handle, app == null ? IntPtr.Zero : app.Handle, isUsb, nshardwareAddress), "initWithUniqueId:native:app:isUsb:hardwareAddress:");
			}
			NSString.ReleaseNative (nsuniqueId);
			NSString.ReleaseNative (nshardwareAddress);
			
		}
		
		[Export ("addBatteryStatusUpdateListener:")]
		[CompilerGenerated]
		public unsafe virtual NSObject AddBatteryStatusUpdateListener ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailBatteryStatusUpdateEvent))]PPRetailBatteryStatusUpdateEvent listener)
		{
			BlockLiteral *block_ptr_listener;
			BlockLiteral block_listener;
			if (listener == null){
				block_ptr_listener = null;
			} else {
				block_listener = new BlockLiteral ();
				block_ptr_listener = &block_listener;
				block_listener.SetupBlockUnsafe (Trampolines.SDPPRetailBatteryStatusUpdateEvent.Handler, listener);
			}
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addBatteryStatusUpdateListener:"), (IntPtr) block_ptr_listener));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addBatteryStatusUpdateListener:"), (IntPtr) block_ptr_listener));
			}
			if (block_ptr_listener != null)
				block_ptr_listener->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("addCardPresentedListener:")]
		[CompilerGenerated]
		public unsafe virtual NSObject AddCardPresentedListener ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailCardPresentedEvent))]PPRetailCardPresentedEvent listener)
		{
			BlockLiteral *block_ptr_listener;
			BlockLiteral block_listener;
			if (listener == null){
				block_ptr_listener = null;
			} else {
				block_listener = new BlockLiteral ();
				block_ptr_listener = &block_listener;
				block_listener.SetupBlockUnsafe (Trampolines.SDPPRetailCardPresentedEvent.Handler, listener);
			}
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addCardPresentedListener:"), (IntPtr) block_ptr_listener));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addCardPresentedListener:"), (IntPtr) block_ptr_listener));
			}
			if (block_ptr_listener != null)
				block_ptr_listener->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("addCardRemovedListener:")]
		[CompilerGenerated]
		public unsafe virtual NSObject AddCardRemovedListener ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailCardRemovedEvent))]PPRetailCardRemovedEvent listener)
		{
			BlockLiteral *block_ptr_listener;
			BlockLiteral block_listener;
			if (listener == null){
				block_ptr_listener = null;
			} else {
				block_listener = new BlockLiteral ();
				block_ptr_listener = &block_listener;
				block_listener.SetupBlockUnsafe (Trampolines.SDPPRetailCardRemovedEvent.Handler, listener);
			}
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addCardRemovedListener:"), (IntPtr) block_ptr_listener));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addCardRemovedListener:"), (IntPtr) block_ptr_listener));
			}
			if (block_ptr_listener != null)
				block_ptr_listener->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("addConnectedListener:")]
		[CompilerGenerated]
		public unsafe virtual NSObject AddConnectedListener ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailConnectedEvent))]PPRetailConnectedEvent listener)
		{
			BlockLiteral *block_ptr_listener;
			BlockLiteral block_listener;
			if (listener == null){
				block_ptr_listener = null;
			} else {
				block_listener = new BlockLiteral ();
				block_ptr_listener = &block_listener;
				block_listener.SetupBlockUnsafe (Trampolines.SDPPRetailConnectedEvent.Handler, listener);
			}
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addConnectedListener:"), (IntPtr) block_ptr_listener));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addConnectedListener:"), (IntPtr) block_ptr_listener));
			}
			if (block_ptr_listener != null)
				block_ptr_listener->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("addConnectionErrorListener:")]
		[CompilerGenerated]
		public unsafe virtual NSObject AddConnectionErrorListener ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailConnectionErrorEvent))]PPRetailConnectionErrorEvent listener)
		{
			BlockLiteral *block_ptr_listener;
			BlockLiteral block_listener;
			if (listener == null){
				block_ptr_listener = null;
			} else {
				block_listener = new BlockLiteral ();
				block_ptr_listener = &block_listener;
				block_listener.SetupBlockUnsafe (Trampolines.SDPPRetailConnectionErrorEvent.Handler, listener);
			}
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addConnectionErrorListener:"), (IntPtr) block_ptr_listener));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addConnectionErrorListener:"), (IntPtr) block_ptr_listener));
			}
			if (block_ptr_listener != null)
				block_ptr_listener->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("addDisconnectedListener:")]
		[CompilerGenerated]
		public unsafe virtual NSObject AddDisconnectedListener ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailDisconnectedEvent))]PPRetailDisconnectedEvent listener)
		{
			BlockLiteral *block_ptr_listener;
			BlockLiteral block_listener;
			if (listener == null){
				block_ptr_listener = null;
			} else {
				block_listener = new BlockLiteral ();
				block_ptr_listener = &block_listener;
				block_listener.SetupBlockUnsafe (Trampolines.SDPPRetailDisconnectedEvent.Handler, listener);
			}
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addDisconnectedListener:"), (IntPtr) block_ptr_listener));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addDisconnectedListener:"), (IntPtr) block_ptr_listener));
			}
			if (block_ptr_listener != null)
				block_ptr_listener->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("addSelectedListener:")]
		[CompilerGenerated]
		public unsafe virtual NSObject AddSelectedListener ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailSelectedEvent))]PPRetailSelectedEvent listener)
		{
			BlockLiteral *block_ptr_listener;
			BlockLiteral block_listener;
			if (listener == null){
				block_ptr_listener = null;
			} else {
				block_listener = new BlockLiteral ();
				block_ptr_listener = &block_listener;
				block_listener.SetupBlockUnsafe (Trampolines.SDPPRetailSelectedEvent.Handler, listener);
			}
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addSelectedListener:"), (IntPtr) block_ptr_listener));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addSelectedListener:"), (IntPtr) block_ptr_listener));
			}
			if (block_ptr_listener != null)
				block_ptr_listener->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("addUpdateRequiredListener:")]
		[CompilerGenerated]
		public unsafe virtual NSObject AddUpdateRequiredListener ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailUpdateRequiredEvent))]PPRetailUpdateRequiredEvent listener)
		{
			BlockLiteral *block_ptr_listener;
			BlockLiteral block_listener;
			if (listener == null){
				block_ptr_listener = null;
			} else {
				block_listener = new BlockLiteral ();
				block_ptr_listener = &block_listener;
				block_listener.SetupBlockUnsafe (Trampolines.SDPPRetailUpdateRequiredEvent.Handler, listener);
			}
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addUpdateRequiredListener:"), (IntPtr) block_ptr_listener));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addUpdateRequiredListener:"), (IntPtr) block_ptr_listener));
			}
			if (block_ptr_listener != null)
				block_ptr_listener->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("connect:")]
		[CompilerGenerated]
		public unsafe virtual void Connect ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailPaymentDeviceConnectHandler))]PPRetailPaymentDeviceConnectHandler callback)
		{
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailPaymentDeviceConnectHandler.Handler, callback);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("connect:"), (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("connect:"), (IntPtr) block_ptr_callback);
			}
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("disconnect:")]
		[CompilerGenerated]
		public unsafe virtual void Disconnect ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailPaymentDeviceDisconnectHandler))]PPRetailPaymentDeviceDisconnectHandler callback)
		{
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailPaymentDeviceDisconnectHandler.Handler, callback);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("disconnect:"), (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("disconnect:"), (IntPtr) block_ptr_callback);
			}
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("doesHaveCapability:")]
		[CompilerGenerated]
		public virtual bool DoesHaveCapability (PPRetaildeviceCapabilityType capability)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("doesHaveCapability:"), (Int64)capability);
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend_int (this.Handle, Selector.GetHandle ("doesHaveCapability:"), (int)capability);
				}
			} else {
				if (IntPtr.Size == 8) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("doesHaveCapability:"), (Int64)capability);
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("doesHaveCapability:"), (int)capability);
				}
			}
		}
		
		[Export ("extractReaderLogs:")]
		[CompilerGenerated]
		public unsafe virtual void ExtractReaderLogs ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailPaymentDeviceDeviceLogsHandler))]PPRetailPaymentDeviceDeviceLogsHandler callback)
		{
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailPaymentDeviceDeviceLogsHandler.Handler, callback);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("extractReaderLogs:"), (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("extractReaderLogs:"), (IntPtr) block_ptr_callback);
			}
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("removeBatteryStatusUpdateListener:")]
		[CompilerGenerated]
		public virtual void RemoveBatteryStatusUpdateListener (NSObject listenerToken)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeBatteryStatusUpdateListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeBatteryStatusUpdateListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			}
		}
		
		[Export ("removeCardPresentedListener:")]
		[CompilerGenerated]
		public virtual void RemoveCardPresentedListener (NSObject listenerToken)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeCardPresentedListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeCardPresentedListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			}
		}
		
		[Export ("removeCardRemovedListener:")]
		[CompilerGenerated]
		public virtual void RemoveCardRemovedListener (NSObject listenerToken)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeCardRemovedListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeCardRemovedListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			}
		}
		
		[Export ("removeConnectedListener:")]
		[CompilerGenerated]
		public virtual void RemoveConnectedListener (NSObject listenerToken)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeConnectedListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeConnectedListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			}
		}
		
		[Export ("removeConnectionErrorListener:")]
		[CompilerGenerated]
		public virtual void RemoveConnectionErrorListener (NSObject listenerToken)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeConnectionErrorListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeConnectionErrorListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			}
		}
		
		[Export ("removeDisconnectedListener:")]
		[CompilerGenerated]
		public virtual void RemoveDisconnectedListener (NSObject listenerToken)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeDisconnectedListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeDisconnectedListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			}
		}
		
		[Export ("removeSelectedListener:")]
		[CompilerGenerated]
		public virtual void RemoveSelectedListener (NSObject listenerToken)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeSelectedListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeSelectedListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			}
		}
		
		[Export ("removeUpdateRequiredListener:")]
		[CompilerGenerated]
		public virtual void RemoveUpdateRequiredListener (NSObject listenerToken)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeUpdateRequiredListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeUpdateRequiredListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			}
		}
		
		[Export ("retrieveBatteryInfo:")]
		[CompilerGenerated]
		public unsafe virtual void RetrieveBatteryInfo ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailPaymentDeviceBatteryInfoHandler))]PPRetailPaymentDeviceBatteryInfoHandler cb)
		{
			BlockLiteral *block_ptr_cb;
			BlockLiteral block_cb;
			if (cb == null){
				block_ptr_cb = null;
			} else {
				block_cb = new BlockLiteral ();
				block_ptr_cb = &block_cb;
				block_cb.SetupBlockUnsafe (Trampolines.SDPPRetailPaymentDeviceBatteryInfoHandler.Handler, cb);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("retrieveBatteryInfo:"), (IntPtr) block_ptr_cb);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("retrieveBatteryInfo:"), (IntPtr) block_ptr_cb);
			}
			if (block_ptr_cb != null)
				block_ptr_cb->CleanupBlock ();
			
		}
		
		[Export ("getVersionInfo")]
		[CompilerGenerated]
		public virtual NSDictionary VersionInfo ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getVersionInfo")));
			} else {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getVersionInfo")));
			}
		}
		
		[CompilerGenerated]
		public virtual bool Activated {
			[Export ("activated")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("activated"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("activated"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Address {
			[Export ("address", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("address")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("address")));
				}
			}
			
			[Export ("setAddress:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAddress:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAddress:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool CardInSlot {
			[Export ("cardInSlot")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("cardInSlot"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cardInSlot"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual PPRetailreaderConnectionType ConnectionType {
			[Export ("connectionType", ArgumentSemantic.UnsafeUnretained)]
			get {
				PPRetailreaderConnectionType ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PPRetailreaderConnectionType) global::ApiDefinitions.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("connectionType"));
					} else {
						ret = (PPRetailreaderConnectionType) global::ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("connectionType"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PPRetailreaderConnectionType) global::ApiDefinitions.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("connectionType"));
					} else {
						ret = (PPRetailreaderConnectionType) global::ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("connectionType"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSObject[] FormFactors {
			[Export ("formFactors", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("formFactors")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("formFactors")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Id {
			[Export ("id", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("id")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("id")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsConnected {
			[Export ("isConnected")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isConnected"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isConnected"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual PPRetailDeviceStatus IsReadyForTransaction {
			[Export ("isReadyForTransaction")]
			get {
				PPRetailDeviceStatus ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PPRetailDeviceStatus> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("isReadyForTransaction")));
				} else {
					ret =  Runtime.GetNSObject<PPRetailDeviceStatus> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isReadyForTransaction")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PPRetailBatteryInfo LastKnownBatteryInfo {
			[Export ("lastKnownBatteryInfo", ArgumentSemantic.Retain)]
			get {
				PPRetailBatteryInfo ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PPRetailBatteryInfo> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lastKnownBatteryInfo")));
				} else {
					ret =  Runtime.GetNSObject<PPRetailBatteryInfo> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lastKnownBatteryInfo")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Manufacturer {
			[Export ("manufacturer", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("manufacturer")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("manufacturer")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual PPRetailReaderModel Model {
			[Export ("model", ArgumentSemantic.UnsafeUnretained)]
			get {
				PPRetailReaderModel ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PPRetailReaderModel) global::ApiDefinitions.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("model"));
					} else {
						ret = (PPRetailReaderModel) global::ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("model"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PPRetailReaderModel) global::ApiDefinitions.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("model"));
					} else {
						ret = (PPRetailReaderModel) global::ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("model"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Name {
			[Export ("name", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("name")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("name")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual PPRetailDeviceUpdate PendingUpdate {
			[Export ("pendingUpdate", ArgumentSemantic.Retain)]
			get {
				PPRetailDeviceUpdate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PPRetailDeviceUpdate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("pendingUpdate")));
				} else {
					ret =  Runtime.GetNSObject<PPRetailDeviceUpdate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pendingUpdate")));
				}
				return ret;
			}
			
			[Export ("setPendingUpdate:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPendingUpdate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPendingUpdate:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string SerialNumber {
			[Export ("serialNumber", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("serialNumber")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("serialNumber")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual PPRetailreaderType Type {
			[Export ("type", ArgumentSemantic.UnsafeUnretained)]
			get {
				PPRetailreaderType ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PPRetailreaderType) global::ApiDefinitions.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
					} else {
						ret = (PPRetailreaderType) global::ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PPRetailreaderType) global::ApiDefinitions.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("type"));
					} else {
						ret = (PPRetailreaderType) global::ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("type"));
					}
				}
				return ret;
			}
			
		}
		
	} /* class PPRetailPaymentDevice */
}
