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
	[Register("PPRetailDeviceUpdate", true)]
	public unsafe partial class PPRetailDeviceUpdate : PPRetailObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PPRetailDeviceUpdate");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PPRetailDeviceUpdate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PPRetailDeviceUpdate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithDevice:")]
		[CompilerGenerated]
		public PPRetailDeviceUpdate (PPRetailPaymentDevice device)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithDevice:"), device == null ? IntPtr.Zero : device.Handle), "initWithDevice:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDevice:"), device == null ? IntPtr.Zero : device.Handle), "initWithDevice:");
			}
		}
		
		[Export ("addReconnectReaderListener:")]
		[CompilerGenerated]
		public unsafe virtual NSObject AddReconnectReaderListener ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailReconnectReaderEvent))]PPRetailReconnectReaderEvent listener)
		{
			BlockLiteral *block_ptr_listener;
			BlockLiteral block_listener;
			if (listener == null){
				block_ptr_listener = null;
			} else {
				block_listener = new BlockLiteral ();
				block_ptr_listener = &block_listener;
				block_listener.SetupBlockUnsafe (Trampolines.SDPPRetailReconnectReaderEvent.Handler, listener);
			}
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addReconnectReaderListener:"), (IntPtr) block_ptr_listener));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addReconnectReaderListener:"), (IntPtr) block_ptr_listener));
			}
			if (block_ptr_listener != null)
				block_ptr_listener->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("begin:")]
		[CompilerGenerated]
		public unsafe virtual void Begin ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailDeviceUpdateCompletedHandler))]PPRetailDeviceUpdateCompletedHandler callback)
		{
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailDeviceUpdateCompletedHandler.Handler, callback);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("begin:"), (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("begin:"), (IntPtr) block_ptr_callback);
			}
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("offer:")]
		[CompilerGenerated]
		public unsafe virtual void Offer ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailDeviceUpdateCompletedHandler))]PPRetailDeviceUpdateCompletedHandler callback)
		{
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailDeviceUpdateCompletedHandler.Handler, callback);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("offer:"), (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("offer:"), (IntPtr) block_ptr_callback);
			}
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("removeReconnectReaderListener:")]
		[CompilerGenerated]
		public virtual void RemoveReconnectReaderListener (NSObject listenerToken)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeReconnectReaderListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeReconnectReaderListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			}
		}
		
		[Export ("validateUpdateEligibility")]
		[CompilerGenerated]
		public virtual void ValidateUpdateEligibility ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("validateUpdateEligibility"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("validateUpdateEligibility"));
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsRequired {
			[Export ("isRequired")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRequired"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRequired"));
				}
			}
			
			[Export ("setIsRequired:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsRequired:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsRequired:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool UpdateInProgress {
			[Export ("updateInProgress")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("updateInProgress"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("updateInProgress"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool WasInstalled {
			[Export ("wasInstalled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("wasInstalled"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("wasInstalled"));
				}
			}
			
			[Export ("setWasInstalled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setWasInstalled:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setWasInstalled:"), value);
				}
			}
		}
		
	} /* class PPRetailDeviceUpdate */
}
