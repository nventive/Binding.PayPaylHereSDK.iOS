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
	[Register("PPRetailSignatureReceiver", true)]
	public unsafe partial class PPRetailSignatureReceiver : PPRetailObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PPRetailSignatureReceiver");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PPRetailSignatureReceiver () : base (NSObjectFlag.Empty)
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
		protected PPRetailSignatureReceiver (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PPRetailSignatureReceiver (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("acquireSignature")]
		[CompilerGenerated]
		public virtual void AcquireSignature ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("acquireSignature"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("acquireSignature"));
			}
		}
		
		[Export ("addCancelledListener:")]
		[CompilerGenerated]
		public unsafe virtual NSObject AddCancelledListener ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailCancelledEvent))]PPRetailCancelledEvent listener)
		{
			BlockLiteral *block_ptr_listener;
			BlockLiteral block_listener;
			if (listener == null){
				block_ptr_listener = null;
			} else {
				block_listener = new BlockLiteral ();
				block_ptr_listener = &block_listener;
				block_listener.SetupBlockUnsafe (Trampolines.SDPPRetailCancelledEvent.Handler, listener);
			}
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addCancelledListener:"), (IntPtr) block_ptr_listener));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addCancelledListener:"), (IntPtr) block_ptr_listener));
			}
			if (block_ptr_listener != null)
				block_ptr_listener->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("cancel")]
		[CompilerGenerated]
		public virtual void Cancel ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cancel"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancel"));
			}
		}
		
		[Export ("continueWithSignature:")]
		[CompilerGenerated]
		public virtual void ContinueWithSignature (string base64SignatureJpeg)
		{
			var nsbase64SignatureJpeg = NSString.CreateNative (base64SignatureJpeg);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("continueWithSignature:"), nsbase64SignatureJpeg);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("continueWithSignature:"), nsbase64SignatureJpeg);
			}
			NSString.ReleaseNative (nsbase64SignatureJpeg);
			
		}
		
		[Export ("removeCancelledListener:")]
		[CompilerGenerated]
		public virtual void RemoveCancelledListener (NSObject listenerToken)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeCancelledListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeCancelledListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual PPRetailTransactionContext Context {
			[Export ("context", ArgumentSemantic.Retain)]
			get {
				PPRetailTransactionContext ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PPRetailTransactionContext> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("context")));
				} else {
					ret =  Runtime.GetNSObject<PPRetailTransactionContext> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("context")));
				}
				return ret;
			}
			
		}
		
	} /* class PPRetailSignatureReceiver */
}
