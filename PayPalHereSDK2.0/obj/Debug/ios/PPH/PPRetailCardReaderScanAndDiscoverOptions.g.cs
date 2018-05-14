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
	[Register("PPRetailCardReaderScanAndDiscoverOptions", true)]
	public unsafe partial class PPRetailCardReaderScanAndDiscoverOptions : PPRetailObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PPRetailCardReaderScanAndDiscoverOptions");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PPRetailCardReaderScanAndDiscoverOptions () : base (NSObjectFlag.Empty)
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
		protected PPRetailCardReaderScanAndDiscoverOptions (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PPRetailCardReaderScanAndDiscoverOptions (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("addOnCardReaderDiscoveredListener:")]
		[CompilerGenerated]
		public unsafe virtual NSObject AddOnCardReaderDiscoveredListener ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailOnCardReaderDiscoveredEvent))]PPRetailOnCardReaderDiscoveredEvent listener)
		{
			BlockLiteral *block_ptr_listener;
			BlockLiteral block_listener;
			if (listener == null){
				block_ptr_listener = null;
			} else {
				block_listener = new BlockLiteral ();
				block_ptr_listener = &block_listener;
				block_listener.SetupBlockUnsafe (Trampolines.SDPPRetailOnCardReaderDiscoveredEvent.Handler, listener);
			}
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addOnCardReaderDiscoveredListener:"), (IntPtr) block_ptr_listener));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addOnCardReaderDiscoveredListener:"), (IntPtr) block_ptr_listener));
			}
			if (block_ptr_listener != null)
				block_ptr_listener->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("addOnConnectionStatusListener:")]
		[CompilerGenerated]
		public unsafe virtual NSObject AddOnConnectionStatusListener ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailOnConnectionStatusEvent))]PPRetailOnConnectionStatusEvent listener)
		{
			BlockLiteral *block_ptr_listener;
			BlockLiteral block_listener;
			if (listener == null){
				block_ptr_listener = null;
			} else {
				block_listener = new BlockLiteral ();
				block_ptr_listener = &block_listener;
				block_listener.SetupBlockUnsafe (Trampolines.SDPPRetailOnConnectionStatusEvent.Handler, listener);
			}
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addOnConnectionStatusListener:"), (IntPtr) block_ptr_listener));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addOnConnectionStatusListener:"), (IntPtr) block_ptr_listener));
			}
			if (block_ptr_listener != null)
				block_ptr_listener->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("addOnScanCompleteListener:")]
		[CompilerGenerated]
		public unsafe virtual NSObject AddOnScanCompleteListener ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailOnScanCompleteEvent))]PPRetailOnScanCompleteEvent listener)
		{
			BlockLiteral *block_ptr_listener;
			BlockLiteral block_listener;
			if (listener == null){
				block_ptr_listener = null;
			} else {
				block_listener = new BlockLiteral ();
				block_ptr_listener = &block_listener;
				block_listener.SetupBlockUnsafe (Trampolines.SDPPRetailOnScanCompleteEvent.Handler, listener);
			}
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addOnScanCompleteListener:"), (IntPtr) block_ptr_listener));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addOnScanCompleteListener:"), (IntPtr) block_ptr_listener));
			}
			if (block_ptr_listener != null)
				block_ptr_listener->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("connectToCardReader:")]
		[CompilerGenerated]
		public virtual void ConnectToCardReader (string id)
		{
			var nsid = NSString.CreateNative (id);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("connectToCardReader:"), nsid);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("connectToCardReader:"), nsid);
			}
			NSString.ReleaseNative (nsid);
			
		}
		
		[Export ("onAddedObserver")]
		[CompilerGenerated]
		public virtual void OnAddedObserver ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("onAddedObserver"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("onAddedObserver"));
			}
		}
		
		[Export ("removeOnCardReaderDiscoveredListener:")]
		[CompilerGenerated]
		public virtual void RemoveOnCardReaderDiscoveredListener (NSObject listenerToken)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeOnCardReaderDiscoveredListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeOnCardReaderDiscoveredListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			}
		}
		
		[Export ("removeOnConnectionStatusListener:")]
		[CompilerGenerated]
		public virtual void RemoveOnConnectionStatusListener (NSObject listenerToken)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeOnConnectionStatusListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeOnConnectionStatusListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			}
		}
		
		[Export ("removeOnScanCompleteListener:")]
		[CompilerGenerated]
		public virtual void RemoveOnScanCompleteListener (NSObject listenerToken)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeOnScanCompleteListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeOnScanCompleteListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			}
		}
		
	} /* class PPRetailCardReaderScanAndDiscoverOptions */
}
