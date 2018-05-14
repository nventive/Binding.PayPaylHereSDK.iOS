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
	[Register("PPRetailTransactionContext", true)]
	public unsafe partial class PPRetailTransactionContext : PPRetailObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PPRetailTransactionContext");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PPRetailTransactionContext (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PPRetailTransactionContext (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithInvoice:merchant:")]
		[CompilerGenerated]
		public PPRetailTransactionContext (PPRetailInvoice invoice, PPRetailMerchant merchant)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithInvoice:merchant:"), invoice == null ? IntPtr.Zero : invoice.Handle, merchant == null ? IntPtr.Zero : merchant.Handle), "initWithInvoice:merchant:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithInvoice:merchant:"), invoice == null ? IntPtr.Zero : invoice.Handle, merchant == null ? IntPtr.Zero : merchant.Handle), "initWithInvoice:merchant:");
			}
		}
		
		[Export ("addContactlessReaderDeactivatedListener:")]
		[CompilerGenerated]
		public unsafe virtual NSObject AddContactlessReaderDeactivatedListener ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailContactlessReaderDeactivatedEvent))]PPRetailContactlessReaderDeactivatedEvent listener)
		{
			BlockLiteral *block_ptr_listener;
			BlockLiteral block_listener;
			if (listener == null){
				block_ptr_listener = null;
			} else {
				block_listener = new BlockLiteral ();
				block_ptr_listener = &block_listener;
				block_listener.SetupBlockUnsafe (Trampolines.SDPPRetailContactlessReaderDeactivatedEvent.Handler, listener);
			}
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addContactlessReaderDeactivatedListener:"), (IntPtr) block_ptr_listener));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addContactlessReaderDeactivatedListener:"), (IntPtr) block_ptr_listener));
			}
			if (block_ptr_listener != null)
				block_ptr_listener->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("addDidCompleteSignatureListener:")]
		[CompilerGenerated]
		public unsafe virtual NSObject AddDidCompleteSignatureListener ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailDidCompleteSignatureEvent))]PPRetailDidCompleteSignatureEvent listener)
		{
			BlockLiteral *block_ptr_listener;
			BlockLiteral block_listener;
			if (listener == null){
				block_ptr_listener = null;
			} else {
				block_listener = new BlockLiteral ();
				block_ptr_listener = &block_listener;
				block_listener.SetupBlockUnsafe (Trampolines.SDPPRetailDidCompleteSignatureEvent.Handler, listener);
			}
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addDidCompleteSignatureListener:"), (IntPtr) block_ptr_listener));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addDidCompleteSignatureListener:"), (IntPtr) block_ptr_listener));
			}
			if (block_ptr_listener != null)
				block_ptr_listener->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("addPinEntryListener:")]
		[CompilerGenerated]
		public unsafe virtual NSObject AddPinEntryListener ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailPinEntryEvent))]PPRetailPinEntryEvent listener)
		{
			BlockLiteral *block_ptr_listener;
			BlockLiteral block_listener;
			if (listener == null){
				block_ptr_listener = null;
			} else {
				block_listener = new BlockLiteral ();
				block_ptr_listener = &block_listener;
				block_listener.SetupBlockUnsafe (Trampolines.SDPPRetailPinEntryEvent.Handler, listener);
			}
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addPinEntryListener:"), (IntPtr) block_ptr_listener));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addPinEntryListener:"), (IntPtr) block_ptr_listener));
			}
			if (block_ptr_listener != null)
				block_ptr_listener->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("addReaderTippingCompletedListener:")]
		[CompilerGenerated]
		public unsafe virtual NSObject AddReaderTippingCompletedListener ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailReaderTippingCompletedEvent))]PPRetailReaderTippingCompletedEvent listener)
		{
			BlockLiteral *block_ptr_listener;
			BlockLiteral block_listener;
			if (listener == null){
				block_ptr_listener = null;
			} else {
				block_listener = new BlockLiteral ();
				block_ptr_listener = &block_listener;
				block_listener.SetupBlockUnsafe (Trampolines.SDPPRetailReaderTippingCompletedEvent.Handler, listener);
			}
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addReaderTippingCompletedListener:"), (IntPtr) block_ptr_listener));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addReaderTippingCompletedListener:"), (IntPtr) block_ptr_listener));
			}
			if (block_ptr_listener != null)
				block_ptr_listener->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("addWillPresentSignatureListener:")]
		[CompilerGenerated]
		public unsafe virtual NSObject AddWillPresentSignatureListener ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailWillPresentSignatureEvent))]PPRetailWillPresentSignatureEvent listener)
		{
			BlockLiteral *block_ptr_listener;
			BlockLiteral block_listener;
			if (listener == null){
				block_ptr_listener = null;
			} else {
				block_listener = new BlockLiteral ();
				block_ptr_listener = &block_listener;
				block_listener.SetupBlockUnsafe (Trampolines.SDPPRetailWillPresentSignatureEvent.Handler, listener);
			}
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addWillPresentSignatureListener:"), (IntPtr) block_ptr_listener));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addWillPresentSignatureListener:"), (IntPtr) block_ptr_listener));
			}
			if (block_ptr_listener != null)
				block_ptr_listener->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("beginPayment:")]
		[CompilerGenerated]
		public virtual PPRetailTransactionContext BeginPayment (PPRetailTransactionBeginOptions options)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PPRetailTransactionContext> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("beginPayment:"), options == null ? IntPtr.Zero : options.Handle));
			} else {
				return  Runtime.GetNSObject<PPRetailTransactionContext> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("beginPayment:"), options == null ? IntPtr.Zero : options.Handle));
			}
		}
		
		[Export ("beginRefund:amount:")]
		[CompilerGenerated]
		public virtual PPRetailTransactionContext BeginRefund (bool cardPresent, NSDecimalNumber amount)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PPRetailTransactionContext> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_bool_IntPtr (this.Handle, Selector.GetHandle ("beginRefund:amount:"), cardPresent, amount == null ? IntPtr.Zero : amount.Handle));
			} else {
				return  Runtime.GetNSObject<PPRetailTransactionContext> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("beginRefund:amount:"), cardPresent, amount == null ? IntPtr.Zero : amount.Handle));
			}
		}
		
		[Export ("beginRefund:amount:refundTag:")]
		[CompilerGenerated]
		public virtual PPRetailTransactionContext BeginRefund (bool cardPresent, NSDecimalNumber amount, string refundTag)
		{
			var nsrefundTag = NSString.CreateNative (refundTag);
			
			PPRetailTransactionContext ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PPRetailTransactionContext> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_bool_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("beginRefund:amount:refundTag:"), cardPresent, amount == null ? IntPtr.Zero : amount.Handle, nsrefundTag));
			} else {
				ret =  Runtime.GetNSObject<PPRetailTransactionContext> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_bool_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("beginRefund:amount:refundTag:"), cardPresent, amount == null ? IntPtr.Zero : amount.Handle, nsrefundTag));
			}
			NSString.ReleaseNative (nsrefundTag);
			
			return ret;
		}
		
		[Export ("clear:")]
		[CompilerGenerated]
		public unsafe virtual void Clear ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailTransactionContextCompleteHandler))]PPRetailTransactionContextCompleteHandler callback)
		{
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailTransactionContextCompleteHandler.Handler, callback);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("clear:"), (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("clear:"), (IntPtr) block_ptr_callback);
			}
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("clearOnReaderTip")]
		[CompilerGenerated]
		public virtual void ClearOnReaderTip ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("clearOnReaderTip"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clearOnReaderTip"));
			}
		}
		
		[Export ("continueWithCard:")]
		[CompilerGenerated]
		public virtual void ContinueWithCard (PPRetailCard card)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("continueWithCard:"), card == null ? IntPtr.Zero : card.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("continueWithCard:"), card == null ? IntPtr.Zero : card.Handle);
			}
		}
		
		[Export ("continueWithCash")]
		[CompilerGenerated]
		public virtual void ContinueWithCash ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("continueWithCash"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("continueWithCash"));
			}
		}
		
		[Export ("continueWithCheck")]
		[CompilerGenerated]
		public virtual void ContinueWithCheck ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("continueWithCheck"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("continueWithCheck"));
			}
		}
		
		[Export ("deactivateFormFactors:callback:")]
		[CompilerGenerated]
		public unsafe virtual void DeactivateFormFactors (NSObject[] formFactors, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailTransactionContextCompleteHandler))]PPRetailTransactionContextCompleteHandler callback)
		{
			var nsa_formFactors = formFactors == null ? null : NSArray.FromNSObjects (formFactors);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailTransactionContextCompleteHandler.Handler, callback);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("deactivateFormFactors:callback:"), nsa_formFactors == null ? IntPtr.Zero : nsa_formFactors.Handle, (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("deactivateFormFactors:callback:"), nsa_formFactors == null ? IntPtr.Zero : nsa_formFactors.Handle, (IntPtr) block_ptr_callback);
			}
			if (nsa_formFactors != null)
				nsa_formFactors.Dispose ();
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("discardPresentedCard:")]
		[CompilerGenerated]
		public virtual void DiscardPresentedCard (PPRetailCard card)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("discardPresentedCard:"), card == null ? IntPtr.Zero : card.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("discardPresentedCard:"), card == null ? IntPtr.Zero : card.Handle);
			}
		}
		
		[Export ("dropHandlers")]
		[CompilerGenerated]
		public virtual void DropHandlers ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("dropHandlers"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dropHandlers"));
			}
		}
		
		[Export ("removeContactlessReaderDeactivatedListener:")]
		[CompilerGenerated]
		public virtual void RemoveContactlessReaderDeactivatedListener (NSObject listenerToken)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeContactlessReaderDeactivatedListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeContactlessReaderDeactivatedListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			}
		}
		
		[Export ("removeDidCompleteSignatureListener:")]
		[CompilerGenerated]
		public virtual void RemoveDidCompleteSignatureListener (NSObject listenerToken)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeDidCompleteSignatureListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeDidCompleteSignatureListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			}
		}
		
		[Export ("removePinEntryListener:")]
		[CompilerGenerated]
		public virtual void RemovePinEntryListener (NSObject listenerToken)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removePinEntryListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removePinEntryListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			}
		}
		
		[Export ("removeReaderTippingCompletedListener:")]
		[CompilerGenerated]
		public virtual void RemoveReaderTippingCompletedListener (NSObject listenerToken)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeReaderTippingCompletedListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeReaderTippingCompletedListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			}
		}
		
		[Export ("removeWillPresentSignatureListener:")]
		[CompilerGenerated]
		public virtual void RemoveWillPresentSignatureListener (NSObject listenerToken)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeWillPresentSignatureListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeWillPresentSignatureListener:"), listenerToken == null ? IntPtr.Zero : listenerToken.Handle);
			}
		}
		
		[Export ("requestPaymentCancellation")]
		[CompilerGenerated]
		public virtual bool RequestPaymentCancellation ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("requestPaymentCancellation"));
			} else {
				return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requestPaymentCancellation"));
			}
		}
		
		[Export ("setAdditionalReceiptOptions:receiptHandler:")]
		[CompilerGenerated]
		public unsafe virtual void SetAdditionalReceiptOptions (NSObject[] additionalReceiptOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailTransactionContextReceiptOptionHandlerHandler))]PPRetailTransactionContextReceiptOptionHandlerHandler receiptHandler)
		{
			var nsa_additionalReceiptOptions = additionalReceiptOptions == null ? null : NSArray.FromNSObjects (additionalReceiptOptions);
			BlockLiteral *block_ptr_receiptHandler;
			BlockLiteral block_receiptHandler;
			if (receiptHandler == null){
				block_ptr_receiptHandler = null;
			} else {
				block_receiptHandler = new BlockLiteral ();
				block_ptr_receiptHandler = &block_receiptHandler;
				block_receiptHandler.SetupBlockUnsafe (Trampolines.SDPPRetailTransactionContextReceiptOptionHandlerHandler.Handler, receiptHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setAdditionalReceiptOptions:receiptHandler:"), nsa_additionalReceiptOptions == null ? IntPtr.Zero : nsa_additionalReceiptOptions.Handle, (IntPtr) block_ptr_receiptHandler);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setAdditionalReceiptOptions:receiptHandler:"), nsa_additionalReceiptOptions == null ? IntPtr.Zero : nsa_additionalReceiptOptions.Handle, (IntPtr) block_ptr_receiptHandler);
			}
			if (nsa_additionalReceiptOptions != null)
				nsa_additionalReceiptOptions.Dispose ();
			if (block_ptr_receiptHandler != null)
				block_ptr_receiptHandler->CleanupBlock ();
			
		}
		
		[Export ("setCaptureHandler:")]
		[CompilerGenerated]
		public unsafe virtual void SetCaptureHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailTransactionContextOnAuthCompleteHandler))]PPRetailTransactionContextOnAuthCompleteHandler captureHandler)
		{
			BlockLiteral *block_ptr_captureHandler;
			BlockLiteral block_captureHandler;
			if (captureHandler == null){
				block_ptr_captureHandler = null;
			} else {
				block_captureHandler = new BlockLiteral ();
				block_ptr_captureHandler = &block_captureHandler;
				block_captureHandler.SetupBlockUnsafe (Trampolines.SDPPRetailTransactionContextOnAuthCompleteHandler.Handler, captureHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCaptureHandler:"), (IntPtr) block_ptr_captureHandler);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCaptureHandler:"), (IntPtr) block_ptr_captureHandler);
			}
			if (block_ptr_captureHandler != null)
				block_ptr_captureHandler->CleanupBlock ();
			
		}
		
		[Export ("setCardInsertedHandler:")]
		[CompilerGenerated]
		public unsafe virtual void SetCardInsertedHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailTransactionContextCardInsertedHandlerHandler))]PPRetailTransactionContextCardInsertedHandlerHandler cardInsertedHandler)
		{
			BlockLiteral *block_ptr_cardInsertedHandler;
			BlockLiteral block_cardInsertedHandler;
			if (cardInsertedHandler == null){
				block_ptr_cardInsertedHandler = null;
			} else {
				block_cardInsertedHandler = new BlockLiteral ();
				block_ptr_cardInsertedHandler = &block_cardInsertedHandler;
				block_cardInsertedHandler.SetupBlockUnsafe (Trampolines.SDPPRetailTransactionContextCardInsertedHandlerHandler.Handler, cardInsertedHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCardInsertedHandler:"), (IntPtr) block_ptr_cardInsertedHandler);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCardInsertedHandler:"), (IntPtr) block_ptr_cardInsertedHandler);
			}
			if (block_ptr_cardInsertedHandler != null)
				block_ptr_cardInsertedHandler->CleanupBlock ();
			
		}
		
		[Export ("setCardPresentedHandler:")]
		[CompilerGenerated]
		public unsafe virtual void SetCardPresentedHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailTransactionContextCardPresentedHandler))]PPRetailTransactionContextCardPresentedHandler cardPresentedHandler)
		{
			BlockLiteral *block_ptr_cardPresentedHandler;
			BlockLiteral block_cardPresentedHandler;
			if (cardPresentedHandler == null){
				block_ptr_cardPresentedHandler = null;
			} else {
				block_cardPresentedHandler = new BlockLiteral ();
				block_ptr_cardPresentedHandler = &block_cardPresentedHandler;
				block_cardPresentedHandler.SetupBlockUnsafe (Trampolines.SDPPRetailTransactionContextCardPresentedHandler.Handler, cardPresentedHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCardPresentedHandler:"), (IntPtr) block_ptr_cardPresentedHandler);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCardPresentedHandler:"), (IntPtr) block_ptr_cardPresentedHandler);
			}
			if (block_ptr_cardPresentedHandler != null)
				block_ptr_cardPresentedHandler->CleanupBlock ();
			
		}
		
		[Export ("setCompletedHandler:")]
		[CompilerGenerated]
		public unsafe virtual void SetCompletedHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailTransactionContextTransactionCompletedHandler))]PPRetailTransactionContextTransactionCompletedHandler completedHandler)
		{
			BlockLiteral *block_ptr_completedHandler;
			BlockLiteral block_completedHandler;
			if (completedHandler == null){
				block_ptr_completedHandler = null;
			} else {
				block_completedHandler = new BlockLiteral ();
				block_ptr_completedHandler = &block_completedHandler;
				block_completedHandler.SetupBlockUnsafe (Trampolines.SDPPRetailTransactionContextTransactionCompletedHandler.Handler, completedHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCompletedHandler:"), (IntPtr) block_ptr_completedHandler);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCompletedHandler:"), (IntPtr) block_ptr_completedHandler);
			}
			if (block_ptr_completedHandler != null)
				block_ptr_completedHandler->CleanupBlock ();
			
		}
		
		[Export ("setSignatureCollector:")]
		[CompilerGenerated]
		public unsafe virtual void SetSignatureCollector ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailTransactionContextSignatureCollectorHandler))]PPRetailTransactionContextSignatureCollectorHandler collector)
		{
			BlockLiteral *block_ptr_collector;
			BlockLiteral block_collector;
			if (collector == null){
				block_ptr_collector = null;
			} else {
				block_collector = new BlockLiteral ();
				block_ptr_collector = &block_collector;
				block_collector.SetupBlockUnsafe (Trampolines.SDPPRetailTransactionContextSignatureCollectorHandler.Handler, collector);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSignatureCollector:"), (IntPtr) block_ptr_collector);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSignatureCollector:"), (IntPtr) block_ptr_collector);
			}
			if (block_ptr_collector != null)
				block_ptr_collector->CleanupBlock ();
			
		}
		
		[Export ("setTokenExpiredHandler:")]
		[CompilerGenerated]
		public unsafe virtual void SetTokenExpiredHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailTransactionContextTokenExpirationHandlerHandler))]PPRetailTransactionContextTokenExpirationHandlerHandler expirationHandler)
		{
			BlockLiteral *block_ptr_expirationHandler;
			BlockLiteral block_expirationHandler;
			if (expirationHandler == null){
				block_ptr_expirationHandler = null;
			} else {
				block_expirationHandler = new BlockLiteral ();
				block_ptr_expirationHandler = &block_expirationHandler;
				block_expirationHandler.SetupBlockUnsafe (Trampolines.SDPPRetailTransactionContextTokenExpirationHandlerHandler.Handler, expirationHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTokenExpiredHandler:"), (IntPtr) block_ptr_expirationHandler);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTokenExpiredHandler:"), (IntPtr) block_ptr_expirationHandler);
			}
			if (block_ptr_expirationHandler != null)
				block_ptr_expirationHandler->CleanupBlock ();
			
		}
		
		[Export ("startInvoiceSync")]
		[CompilerGenerated]
		public virtual void StartInvoiceSync ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("startInvoiceSync"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startInvoiceSync"));
			}
		}
		
		[Export ("syncInvoiceOnce")]
		[CompilerGenerated]
		public virtual void SyncInvoiceOnce ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("syncInvoiceOnce"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("syncInvoiceOnce"));
			}
		}
		
		[CompilerGenerated]
		public virtual PPRetailInvoice Invoice {
			[Export ("invoice", ArgumentSemantic.Retain)]
			get {
				PPRetailInvoice ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PPRetailInvoice> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("invoice")));
				} else {
					ret =  Runtime.GetNSObject<PPRetailInvoice> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("invoice")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsPaymentInRetryOrProgress {
			[Export ("isPaymentInRetryOrProgress")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPaymentInRetryOrProgress"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isPaymentInRetryOrProgress"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsRefund {
			[Export ("isRefund")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRefund"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRefund"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsSignatureRequired {
			[Export ("isSignatureRequired")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSignatureRequired"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isSignatureRequired"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual PPRetailPaymentState PaymentState {
			[Export ("getPaymentState")]
			get {
				PPRetailPaymentState ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PPRetailPaymentState) global::ApiDefinitions.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("getPaymentState"));
					} else {
						ret = (PPRetailPaymentState) global::ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("getPaymentState"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PPRetailPaymentState) global::ApiDefinitions.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getPaymentState"));
					} else {
						ret = (PPRetailPaymentState) global::ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getPaymentState"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PPRetailTippingState TippingState {
			[Export ("getTippingState")]
			get {
				PPRetailTippingState ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PPRetailTippingState) global::ApiDefinitions.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("getTippingState"));
					} else {
						ret = (PPRetailTippingState) global::ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("getTippingState"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PPRetailTippingState) global::ApiDefinitions.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getTippingState"));
					} else {
						ret = (PPRetailTippingState) global::ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getTippingState"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string TotalDisplayFooter {
			[Export ("totalDisplayFooter", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("totalDisplayFooter")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("totalDisplayFooter")));
				}
			}
			
			[Export ("setTotalDisplayFooter:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTotalDisplayFooter:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTotalDisplayFooter:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual PPRetailTransactionType Type {
			[Export ("type", ArgumentSemantic.UnsafeUnretained)]
			get {
				PPRetailTransactionType ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PPRetailTransactionType) global::ApiDefinitions.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
					} else {
						ret = (PPRetailTransactionType) global::ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PPRetailTransactionType) global::ApiDefinitions.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("type"));
					} else {
						ret = (PPRetailTransactionType) global::ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("type"));
					}
				}
				return ret;
			}
			
			[Export ("setType:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setType:"), (Int64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setType:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setType:"), (Int64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setType:"), (int)value);
					}
				}
			}
		}
		
	} /* class PPRetailTransactionContext */
}
