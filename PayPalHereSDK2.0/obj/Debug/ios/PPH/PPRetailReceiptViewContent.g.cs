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
	[Register("PPRetailReceiptViewContent", true)]
	public unsafe partial class PPRetailReceiptViewContent : PPRetailObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PPRetailReceiptViewContent");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PPRetailReceiptViewContent () : base (NSObjectFlag.Empty)
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
		protected PPRetailReceiptViewContent (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PPRetailReceiptViewContent (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual PPRetailReceiptEmailEntryViewContent ReceiptEmailEntryViewContent {
			[Export ("receiptEmailEntryViewContent", ArgumentSemantic.Retain)]
			get {
				PPRetailReceiptEmailEntryViewContent ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PPRetailReceiptEmailEntryViewContent> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("receiptEmailEntryViewContent")));
				} else {
					ret =  Runtime.GetNSObject<PPRetailReceiptEmailEntryViewContent> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("receiptEmailEntryViewContent")));
				}
				return ret;
			}
			
			[Export ("setReceiptEmailEntryViewContent:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setReceiptEmailEntryViewContent:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setReceiptEmailEntryViewContent:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PPRetailReceiptOptionsViewContent ReceiptOptionsViewContent {
			[Export ("receiptOptionsViewContent", ArgumentSemantic.Retain)]
			get {
				PPRetailReceiptOptionsViewContent ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PPRetailReceiptOptionsViewContent> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("receiptOptionsViewContent")));
				} else {
					ret =  Runtime.GetNSObject<PPRetailReceiptOptionsViewContent> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("receiptOptionsViewContent")));
				}
				return ret;
			}
			
			[Export ("setReceiptOptionsViewContent:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setReceiptOptionsViewContent:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setReceiptOptionsViewContent:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PPRetailReceiptSMSEntryViewContent ReceiptSMSEntryViewContent {
			[Export ("receiptSMSEntryViewContent", ArgumentSemantic.Retain)]
			get {
				PPRetailReceiptSMSEntryViewContent ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PPRetailReceiptSMSEntryViewContent> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("receiptSMSEntryViewContent")));
				} else {
					ret =  Runtime.GetNSObject<PPRetailReceiptSMSEntryViewContent> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("receiptSMSEntryViewContent")));
				}
				return ret;
			}
			
			[Export ("setReceiptSMSEntryViewContent:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setReceiptSMSEntryViewContent:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setReceiptSMSEntryViewContent:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
	} /* class PPRetailReceiptViewContent */
}
