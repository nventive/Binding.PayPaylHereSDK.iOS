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
	[Register("PPRetailTransactionManager", true)]
	public unsafe partial class PPRetailTransactionManager : PPRetailObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PPRetailTransactionManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PPRetailTransactionManager () : base (NSObjectFlag.Empty)
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
		protected PPRetailTransactionManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PPRetailTransactionManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("captureAuthorization:invoiceId:totalAmount:gratuityAmount:currency:callback:")]
		[CompilerGenerated]
		public unsafe virtual void CaptureAuthorization (string authorizationId, string invoiceId, NSDecimalNumber totalAmount, NSDecimalNumber gratuityAmount, string currency, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailTransactionManagerCaptureAuthorizedTransactionHandler))]PPRetailTransactionManagerCaptureAuthorizedTransactionHandler callback)
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
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("captureAuthorization:invoiceId:totalAmount:gratuityAmount:currency:callback:"), nsauthorizationId, nsinvoiceId, totalAmount == null ? IntPtr.Zero : totalAmount.Handle, gratuityAmount == null ? IntPtr.Zero : gratuityAmount.Handle, nscurrency, (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("captureAuthorization:invoiceId:totalAmount:gratuityAmount:currency:callback:"), nsauthorizationId, nsinvoiceId, totalAmount == null ? IntPtr.Zero : totalAmount.Handle, gratuityAmount == null ? IntPtr.Zero : gratuityAmount.Handle, nscurrency, (IntPtr) block_ptr_callback);
			}
			NSString.ReleaseNative (nsauthorizationId);
			NSString.ReleaseNative (nsinvoiceId);
			NSString.ReleaseNative (nscurrency);
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("captureAuthorization:invoiceId:totalAmount:gratuityAmount:currency:base64SignatureJpeg:callback:")]
		[CompilerGenerated]
		public unsafe virtual void CaptureAuthorization (string authorizationId, string invoiceId, NSDecimalNumber totalAmount, NSDecimalNumber gratuityAmount, string currency, string base64SignatureJpeg, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailTransactionManagerCaptureAuthorizedTransactionHandler))]PPRetailTransactionManagerCaptureAuthorizedTransactionHandler callback)
		{
			var nsauthorizationId = NSString.CreateNative (authorizationId);
			var nsinvoiceId = NSString.CreateNative (invoiceId);
			var nscurrency = NSString.CreateNative (currency);
			var nsbase64SignatureJpeg = NSString.CreateNative (base64SignatureJpeg);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailTransactionManagerCaptureAuthorizedTransactionHandler.Handler, callback);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("captureAuthorization:invoiceId:totalAmount:gratuityAmount:currency:base64SignatureJpeg:callback:"), nsauthorizationId, nsinvoiceId, totalAmount == null ? IntPtr.Zero : totalAmount.Handle, gratuityAmount == null ? IntPtr.Zero : gratuityAmount.Handle, nscurrency, nsbase64SignatureJpeg, (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("captureAuthorization:invoiceId:totalAmount:gratuityAmount:currency:base64SignatureJpeg:callback:"), nsauthorizationId, nsinvoiceId, totalAmount == null ? IntPtr.Zero : totalAmount.Handle, gratuityAmount == null ? IntPtr.Zero : gratuityAmount.Handle, nscurrency, nsbase64SignatureJpeg, (IntPtr) block_ptr_callback);
			}
			NSString.ReleaseNative (nsauthorizationId);
			NSString.ReleaseNative (nsinvoiceId);
			NSString.ReleaseNative (nscurrency);
			NSString.ReleaseNative (nsbase64SignatureJpeg);
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("createRefundTransaction:transactionNumber:paymentMethod:callback:")]
		[CompilerGenerated]
		public unsafe virtual void CreateRefundTransaction (string invoiceId, string transactionNumber, PPRetailInvoicePaymentMethod paymentMethod, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailTransactionManagerTransactionHandler))]PPRetailTransactionManagerTransactionHandler callback)
		{
			var nsinvoiceId = NSString.CreateNative (invoiceId);
			var nstransactionNumber = NSString.CreateNative (transactionNumber);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailTransactionManagerTransactionHandler.Handler, callback);
			}
			
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_Int64_IntPtr (this.Handle, Selector.GetHandle ("createRefundTransaction:transactionNumber:paymentMethod:callback:"), nsinvoiceId, nstransactionNumber, (Int64)paymentMethod, (IntPtr) block_ptr_callback);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_int_IntPtr (this.Handle, Selector.GetHandle ("createRefundTransaction:transactionNumber:paymentMethod:callback:"), nsinvoiceId, nstransactionNumber, (int)paymentMethod, (IntPtr) block_ptr_callback);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_Int64_IntPtr (this.SuperHandle, Selector.GetHandle ("createRefundTransaction:transactionNumber:paymentMethod:callback:"), nsinvoiceId, nstransactionNumber, (Int64)paymentMethod, (IntPtr) block_ptr_callback);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr (this.SuperHandle, Selector.GetHandle ("createRefundTransaction:transactionNumber:paymentMethod:callback:"), nsinvoiceId, nstransactionNumber, (int)paymentMethod, (IntPtr) block_ptr_callback);
				}
			}
			NSString.ReleaseNative (nsinvoiceId);
			NSString.ReleaseNative (nstransactionNumber);
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("createTransaction:callback:")]
		[CompilerGenerated]
		public unsafe virtual void CreateTransaction (PPRetailInvoice invoice, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailTransactionManagerTransactionHandler))]PPRetailTransactionManagerTransactionHandler callback)
		{
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailTransactionManagerTransactionHandler.Handler, callback);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("createTransaction:callback:"), invoice == null ? IntPtr.Zero : invoice.Handle, (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("createTransaction:callback:"), invoice == null ? IntPtr.Zero : invoice.Handle, (IntPtr) block_ptr_callback);
			}
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("retrieveAuthorization:endDateTime:pageSize:status:callback:")]
		[CompilerGenerated]
		public unsafe virtual void RetrieveAuthorization (NSDate startDateTime, NSDate endDateTime, int pageSize, NSObject[] status, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler))]PPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler callback)
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
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("retrieveAuthorization:endDateTime:pageSize:status:callback:"), startDateTime == null ? IntPtr.Zero : startDateTime.Handle, endDateTime == null ? IntPtr.Zero : endDateTime.Handle, pageSize, nsa_status == null ? IntPtr.Zero : nsa_status.Handle, (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("retrieveAuthorization:endDateTime:pageSize:status:callback:"), startDateTime == null ? IntPtr.Zero : startDateTime.Handle, endDateTime == null ? IntPtr.Zero : endDateTime.Handle, pageSize, nsa_status == null ? IntPtr.Zero : nsa_status.Handle, (IntPtr) block_ptr_callback);
			}
			if (nsa_status != null)
				nsa_status.Dispose ();
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("retrieveAuthorizationUsingToken:callback:")]
		[CompilerGenerated]
		public unsafe virtual void RetrieveAuthorizationUsingToken (string nextPageToken, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler))]PPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler callback)
		{
			var nsnextPageToken = NSString.CreateNative (nextPageToken);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler.Handler, callback);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("retrieveAuthorizationUsingToken:callback:"), nsnextPageToken, (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("retrieveAuthorizationUsingToken:callback:"), nsnextPageToken, (IntPtr) block_ptr_callback);
			}
			NSString.ReleaseNative (nsnextPageToken);
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("voidAuthorization:callback:")]
		[CompilerGenerated]
		public unsafe virtual void VoidAuthorization (string authorizationId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailTransactionManagerVoidAuthorizationHandler))]PPRetailTransactionManagerVoidAuthorizationHandler callback)
		{
			var nsauthorizationId = NSString.CreateNative (authorizationId);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailTransactionManagerVoidAuthorizationHandler.Handler, callback);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("voidAuthorization:callback:"), nsauthorizationId, (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("voidAuthorization:callback:"), nsauthorizationId, (IntPtr) block_ptr_callback);
			}
			NSString.ReleaseNative (nsauthorizationId);
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
	} /* class PPRetailTransactionManager */
}
