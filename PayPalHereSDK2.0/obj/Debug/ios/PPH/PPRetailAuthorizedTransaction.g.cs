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
	[Register("PPRetailAuthorizedTransaction", true)]
	public unsafe partial class PPRetailAuthorizedTransaction : PPRetailObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PPRetailAuthorizedTransaction");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PPRetailAuthorizedTransaction (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PPRetailAuthorizedTransaction (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithAuthorizationId:invoiceId:currency:")]
		[CompilerGenerated]
		public PPRetailAuthorizedTransaction (string authorizationId, string invoiceId, string currency)
			: base (NSObjectFlag.Empty)
		{
			var nsauthorizationId = NSString.CreateNative (authorizationId);
			var nsinvoiceId = NSString.CreateNative (invoiceId);
			var nscurrency = NSString.CreateNative (currency);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithAuthorizationId:invoiceId:currency:"), nsauthorizationId, nsinvoiceId, nscurrency), "initWithAuthorizationId:invoiceId:currency:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithAuthorizationId:invoiceId:currency:"), nsauthorizationId, nsinvoiceId, nscurrency), "initWithAuthorizationId:invoiceId:currency:");
			}
			NSString.ReleaseNative (nsauthorizationId);
			NSString.ReleaseNative (nsinvoiceId);
			NSString.ReleaseNative (nscurrency);
			
		}
		
		[Export ("captureTransaction:gratuityAmount:callback:")]
		[CompilerGenerated]
		public unsafe virtual void CaptureTransaction (NSDecimalNumber totalAmount, NSDecimalNumber gratuityAmount, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailAuthorizedTransactionCaptureCompleteHandler))]PPRetailAuthorizedTransactionCaptureCompleteHandler callback)
		{
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailAuthorizedTransactionCaptureCompleteHandler.Handler, callback);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("captureTransaction:gratuityAmount:callback:"), totalAmount == null ? IntPtr.Zero : totalAmount.Handle, gratuityAmount == null ? IntPtr.Zero : gratuityAmount.Handle, (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("captureTransaction:gratuityAmount:callback:"), totalAmount == null ? IntPtr.Zero : totalAmount.Handle, gratuityAmount == null ? IntPtr.Zero : gratuityAmount.Handle, (IntPtr) block_ptr_callback);
			}
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("captureTransaction:gratuityAmount:base64SignatureJpeg:callback:")]
		[CompilerGenerated]
		public unsafe virtual void CaptureTransaction (NSDecimalNumber totalAmount, NSDecimalNumber gratuityAmount, string base64SignatureJpeg, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailAuthorizedTransactionCaptureCompleteHandler))]PPRetailAuthorizedTransactionCaptureCompleteHandler callback)
		{
			var nsbase64SignatureJpeg = NSString.CreateNative (base64SignatureJpeg);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailAuthorizedTransactionCaptureCompleteHandler.Handler, callback);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("captureTransaction:gratuityAmount:base64SignatureJpeg:callback:"), totalAmount == null ? IntPtr.Zero : totalAmount.Handle, gratuityAmount == null ? IntPtr.Zero : gratuityAmount.Handle, nsbase64SignatureJpeg, (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("captureTransaction:gratuityAmount:base64SignatureJpeg:callback:"), totalAmount == null ? IntPtr.Zero : totalAmount.Handle, gratuityAmount == null ? IntPtr.Zero : gratuityAmount.Handle, nsbase64SignatureJpeg, (IntPtr) block_ptr_callback);
			}
			NSString.ReleaseNative (nsbase64SignatureJpeg);
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("voidTransaction:")]
		[CompilerGenerated]
		public unsafe virtual void VoidTransaction ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailAuthorizedTransactionVoidCompleteHandler))]PPRetailAuthorizedTransactionVoidCompleteHandler callback)
		{
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailAuthorizedTransactionVoidCompleteHandler.Handler, callback);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("voidTransaction:"), (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("voidTransaction:"), (IntPtr) block_ptr_callback);
			}
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public virtual string AuthorizationId {
			[Export ("authorizationId", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("authorizationId")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("authorizationId")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber AuthorizedAmount {
			[Export ("authorizedAmount", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("authorizedAmount")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("authorizedAmount")));
				}
				return ret;
			}
			
			[Export ("setAuthorizedAmount:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAuthorizedAmount:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAuthorizedAmount:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Currency {
			[Export ("currency", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("currency")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("currency")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string InvoiceId {
			[Export ("invoiceId", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("invoiceId")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("invoiceId")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Status {
			[Export ("status", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("status")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("status")));
				}
			}
			
			[Export ("setStatus:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setStatus:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setStatus:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual NSDate TimeCreated {
			[Export ("timeCreated", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("timeCreated")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("timeCreated")));
				}
				return ret;
			}
			
			[Export ("setTimeCreated:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTimeCreated:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTimeCreated:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
	} /* class PPRetailAuthorizedTransaction */
}
