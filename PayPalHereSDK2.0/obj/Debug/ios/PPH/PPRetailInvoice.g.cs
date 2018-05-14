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
	[Register("PPRetailInvoice", true)]
	public unsafe partial class PPRetailInvoice : PPRetailObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PPRetailInvoice");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PPRetailInvoice () : base (NSObjectFlag.Empty)
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
		protected PPRetailInvoice (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PPRetailInvoice (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithCurrencyCode:")]
		[CompilerGenerated]
		public PPRetailInvoice (string currencyCode)
			: base (NSObjectFlag.Empty)
		{
			var nscurrencyCode = NSString.CreateNative (currencyCode);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCurrencyCode:"), nscurrencyCode), "initWithCurrencyCode:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCurrencyCode:"), nscurrencyCode), "initWithCurrencyCode:");
			}
			NSString.ReleaseNative (nscurrencyCode);
			
		}
		
		[Export ("addAttachment:")]
		[CompilerGenerated]
		public virtual NSObject[] AddAttachment (PPRetailInvoiceAttachment attachment)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<NSObject>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addAttachment:"), attachment == null ? IntPtr.Zero : attachment.Handle));
			} else {
				return NSArray.ArrayFromHandle<NSObject>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addAttachment:"), attachment == null ? IntPtr.Zero : attachment.Handle));
			}
		}
		
		[Export ("addInvoiceItem:")]
		[CompilerGenerated]
		public virtual PPRetailInvoiceItem AddInvoiceItem (PPRetailInvoiceItem item)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PPRetailInvoiceItem> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addInvoiceItem:"), item == null ? IntPtr.Zero : item.Handle));
			} else {
				return  Runtime.GetNSObject<PPRetailInvoiceItem> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addInvoiceItem:"), item == null ? IntPtr.Zero : item.Handle));
			}
		}
		
		[Export ("addItem:quantity:unitPrice:itemId:detailId:")]
		[CompilerGenerated]
		public virtual PPRetailInvoiceItem AddItem (string name, NSDecimalNumber quantity, NSDecimalNumber unitPrice, int itemId, string detailId)
		{
			var nsname = NSString.CreateNative (name);
			var nsdetailId = NSString.CreateNative (detailId);
			
			PPRetailInvoiceItem ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PPRetailInvoiceItem> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_int_IntPtr (this.Handle, Selector.GetHandle ("addItem:quantity:unitPrice:itemId:detailId:"), nsname, quantity == null ? IntPtr.Zero : quantity.Handle, unitPrice == null ? IntPtr.Zero : unitPrice.Handle, itemId, nsdetailId));
			} else {
				ret =  Runtime.GetNSObject<PPRetailInvoiceItem> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_int_IntPtr (this.SuperHandle, Selector.GetHandle ("addItem:quantity:unitPrice:itemId:detailId:"), nsname, quantity == null ? IntPtr.Zero : quantity.Handle, unitPrice == null ? IntPtr.Zero : unitPrice.Handle, itemId, nsdetailId));
			}
			NSString.ReleaseNative (nsname);
			NSString.ReleaseNative (nsdetailId);
			
			return ret;
		}
		
		[Export ("cancel:callback:")]
		[CompilerGenerated]
		public unsafe virtual void Cancel (PPRetailInvoiceNotification notification, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailInvoiceCancelledHandler))]PPRetailInvoiceCancelledHandler callback)
		{
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailInvoiceCancelledHandler.Handler, callback);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("cancel:callback:"), notification == null ? IntPtr.Zero : notification.Handle, (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("cancel:callback:"), notification == null ? IntPtr.Zero : notification.Handle, (IntPtr) block_ptr_callback);
			}
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("deepEqual:")]
		[CompilerGenerated]
		public virtual bool DeepEqual (PPRetailInvoice invoice)
		{
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("deepEqual:"), invoice == null ? IntPtr.Zero : invoice.Handle);
			} else {
				return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("deepEqual:"), invoice == null ? IntPtr.Zero : invoice.Handle);
			}
		}
		
		[Export ("deleteFromServer:")]
		[CompilerGenerated]
		public unsafe virtual void DeleteFromServer ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailInvoiceDeletedHandler))]PPRetailInvoiceDeletedHandler callback)
		{
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailInvoiceDeletedHandler.Handler, callback);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("deleteFromServer:"), (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("deleteFromServer:"), (IntPtr) block_ptr_callback);
			}
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("findItem:detailId:")]
		[CompilerGenerated]
		public virtual PPRetailInvoiceItem FindItem (int itemId, string detailId)
		{
			var nsdetailId = NSString.CreateNative (detailId);
			
			PPRetailInvoiceItem ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PPRetailInvoiceItem> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_int_IntPtr (this.Handle, Selector.GetHandle ("findItem:detailId:"), itemId, nsdetailId));
			} else {
				ret =  Runtime.GetNSObject<PPRetailInvoiceItem> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_int_IntPtr (this.SuperHandle, Selector.GetHandle ("findItem:detailId:"), itemId, nsdetailId));
			}
			NSString.ReleaseNative (nsdetailId);
			
			return ret;
		}
		
		[Export ("getDetails:")]
		[CompilerGenerated]
		public unsafe virtual void GetDetails ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailInvoiceGotDetailsHandler))]PPRetailInvoiceGotDetailsHandler callback)
		{
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailInvoiceGotDetailsHandler.Handler, callback);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("getDetails:"), (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("getDetails:"), (IntPtr) block_ptr_callback);
			}
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("getItem:")]
		[CompilerGenerated]
		public virtual PPRetailInvoiceItem GetItem (int itemIndex)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PPRetailInvoiceItem> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_int (this.Handle, Selector.GetHandle ("getItem:"), itemIndex));
			} else {
				return  Runtime.GetNSObject<PPRetailInvoiceItem> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("getItem:"), itemIndex));
			}
		}
		
		[Export ("recordPayment:callback:")]
		[CompilerGenerated]
		public unsafe virtual void RecordPayment (PPRetailInvoicePayment paymentInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailInvoicePaidHandler))]PPRetailInvoicePaidHandler callback)
		{
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailInvoicePaidHandler.Handler, callback);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("recordPayment:callback:"), paymentInfo == null ? IntPtr.Zero : paymentInfo.Handle, (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("recordPayment:callback:"), paymentInfo == null ? IntPtr.Zero : paymentInfo.Handle, (IntPtr) block_ptr_callback);
			}
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("recordRefund:callback:")]
		[CompilerGenerated]
		public unsafe virtual void RecordRefund (PPRetailInvoiceRefund refundInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailInvoicePaidHandler))]PPRetailInvoicePaidHandler callback)
		{
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailInvoicePaidHandler.Handler, callback);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("recordRefund:callback:"), refundInfo == null ? IntPtr.Zero : refundInfo.Handle, (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("recordRefund:callback:"), refundInfo == null ? IntPtr.Zero : refundInfo.Handle, (IntPtr) block_ptr_callback);
			}
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("remind:callback:")]
		[CompilerGenerated]
		public unsafe virtual void Remind (PPRetailInvoiceNotification notification, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailInvoiceRemindedHandler))]PPRetailInvoiceRemindedHandler callback)
		{
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailInvoiceRemindedHandler.Handler, callback);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("remind:callback:"), notification == null ? IntPtr.Zero : notification.Handle, (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("remind:callback:"), notification == null ? IntPtr.Zero : notification.Handle, (IntPtr) block_ptr_callback);
			}
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("removeAllItems")]
		[CompilerGenerated]
		public virtual void RemoveAllItems ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeAllItems"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("removeAllItems"));
			}
		}
		
		[Export ("removeAttachment:")]
		[CompilerGenerated]
		public virtual bool RemoveAttachment (PPRetailInvoiceAttachment attachment)
		{
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeAttachment:"), attachment == null ? IntPtr.Zero : attachment.Handle);
			} else {
				return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeAttachment:"), attachment == null ? IntPtr.Zero : attachment.Handle);
			}
		}
		
		[Export ("removeItem:")]
		[CompilerGenerated]
		public virtual bool RemoveItem (PPRetailInvoiceItem item)
		{
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeItem:"), item == null ? IntPtr.Zero : item.Handle);
			} else {
				return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeItem:"), item == null ? IntPtr.Zero : item.Handle);
			}
		}
		
		[Export ("save:")]
		[CompilerGenerated]
		public unsafe virtual void Save ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailInvoiceSavedHandler))]PPRetailInvoiceSavedHandler callback)
		{
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailInvoiceSavedHandler.Handler, callback);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("save:"), (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("save:"), (IntPtr) block_ptr_callback);
			}
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("send:callback:")]
		[CompilerGenerated]
		public unsafe virtual void Send (bool shouldNotifyMerchant, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailInvoiceSentHandler))]PPRetailInvoiceSentHandler callback)
		{
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailInvoiceSentHandler.Handler, callback);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, Selector.GetHandle ("send:callback:"), shouldNotifyMerchant, (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("send:callback:"), shouldNotifyMerchant, (IntPtr) block_ptr_callback);
			}
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("update:shouldNotifyCustomer:callback:")]
		[CompilerGenerated]
		public unsafe virtual void Update (bool shouldNotifyMerchant, bool shouldNotifyCustomer, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailInvoiceSavedHandler))]PPRetailInvoiceSavedHandler callback)
		{
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			if (callback == null){
				block_ptr_callback = null;
			} else {
				block_callback = new BlockLiteral ();
				block_ptr_callback = &block_callback;
				block_callback.SetupBlockUnsafe (Trampolines.SDPPRetailInvoiceSavedHandler.Handler, callback);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_bool_bool_IntPtr (this.Handle, Selector.GetHandle ("update:shouldNotifyCustomer:callback:"), shouldNotifyMerchant, shouldNotifyCustomer, (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("update:shouldNotifyCustomer:callback:"), shouldNotifyMerchant, shouldNotifyCustomer, (IntPtr) block_ptr_callback);
			}
			if (block_ptr_callback != null)
				block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("withInvoice:")]
		[CompilerGenerated]
		public static PPRetailInvoice WithInvoice (PPRetailInvoice invoice)
		{
			return  Runtime.GetNSObject<PPRetailInvoice> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("withInvoice:"), invoice == null ? IntPtr.Zero : invoice.Handle));
		}
		
		[CompilerGenerated]
		public virtual string AdditionalData {
			[Export ("additionalData", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("additionalData")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("additionalData")));
				}
			}
			
			[Export ("setAdditionalData:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAdditionalData:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAdditionalData:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool AllowPartialPayment {
			[Export ("allowPartialPayment")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowPartialPayment"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("allowPartialPayment"));
				}
			}
			
			[Export ("setAllowPartialPayment:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAllowPartialPayment:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAllowPartialPayment:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AllowTip {
			[Export ("allowTip")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowTip"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("allowTip"));
				}
			}
			
			[Export ("setAllowTip:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAllowTip:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAllowTip:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber AmountPaidNet {
			[Export ("amountPaidNet", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("amountPaidNet")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("amountPaidNet")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSObject[] Attachments {
			[Export ("attachments", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("attachments")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("attachments")));
				}
				return ret;
			}
			
			[Export ("setAttachments:", ArgumentSemantic.Retain)]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAttachments:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAttachments:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
			}
		}
		
		[CompilerGenerated]
		public virtual PPRetailInvoiceBillingInfo BillingInfo {
			[Export ("billingInfo", ArgumentSemantic.Retain)]
			get {
				PPRetailInvoiceBillingInfo ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PPRetailInvoiceBillingInfo> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("billingInfo")));
				} else {
					ret =  Runtime.GetNSObject<PPRetailInvoiceBillingInfo> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("billingInfo")));
				}
				return ret;
			}
			
			[Export ("setBillingInfo:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBillingInfo:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBillingInfo:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSObject[] CCInfo {
			[Export ("CCInfo", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("CCInfo")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("CCInfo")));
				}
				return ret;
			}
			
			[Export ("setCCInfo:", ArgumentSemantic.Retain)]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCCInfo:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCCInfo:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
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
			
			[Export ("setCurrency:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCurrency:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCurrency:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual PPRetailInvoiceCustomAmount Custom {
			[Export ("custom", ArgumentSemantic.Retain)]
			get {
				PPRetailInvoiceCustomAmount ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PPRetailInvoiceCustomAmount> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("custom")));
				} else {
					ret =  Runtime.GetNSObject<PPRetailInvoiceCustomAmount> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("custom")));
				}
				return ret;
			}
			
			[Export ("setCustom:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCustom:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCustom:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber DiscountAmount {
			[Export ("discountAmount", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("discountAmount")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("discountAmount")));
				}
				return ret;
			}
			
			[Export ("setDiscountAmount:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDiscountAmount:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDiscountAmount:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber DiscountPercentage {
			[Export ("discountPercentage", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("discountPercentage")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("discountPercentage")));
				}
				return ret;
			}
			
			[Export ("setDiscountPercentage:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDiscountPercentage:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDiscountPercentage:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber DiscountPrice {
			[Export ("discountPrice", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("discountPrice")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("discountPrice")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PPRetailInvoice Duplicate {
			[Export ("duplicate")]
			get {
				PPRetailInvoice ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PPRetailInvoice> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("duplicate")));
				} else {
					ret =  Runtime.GetNSObject<PPRetailInvoice> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("duplicate")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber GratuityAmount {
			[Export ("gratuityAmount", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("gratuityAmount")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("gratuityAmount")));
				}
				return ret;
			}
			
			[Export ("setGratuityAmount:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setGratuityAmount:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setGratuityAmount:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool HasBeenPaid {
			[Export ("hasBeenPaid")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasBeenPaid"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hasBeenPaid"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool HasDetails {
			[Export ("hasDetails")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasDetails"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hasDetails"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string InvoiceDate {
			[Export ("invoiceDate", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("invoiceDate")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("invoiceDate")));
				}
			}
			
			[Export ("setInvoiceDate:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setInvoiceDate:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setInvoiceDate:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsDirtyFromServer {
			[Export ("isDirtyFromServer")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isDirtyFromServer"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isDirtyFromServer"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsPastDue {
			[Export ("isPastDue")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPastDue"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isPastDue"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int ItemCount {
			[Export ("itemCount")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("itemCount"));
				} else {
					return global::ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("itemCount"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber ItemDiscounts {
			[Export ("itemDiscounts", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("itemDiscounts")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("itemDiscounts")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber ItemTax {
			[Export ("itemTax", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("itemTax")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("itemTax")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSObject[] Items {
			[Export ("items", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("items")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("items")));
				}
				return ret;
			}
			
			[Export ("setItems:", ArgumentSemantic.Retain)]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setItems:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setItems:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
			}
		}
		
		[CompilerGenerated]
		public virtual string LogoURL {
			[Export ("logoURL", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("logoURL")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("logoURL")));
				}
			}
			
			[Export ("setLogoURL:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLogoURL:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLogoURL:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual PPRetailInvoiceMerchantInfo MerchantInfo {
			[Export ("merchantInfo", ArgumentSemantic.Retain)]
			get {
				PPRetailInvoiceMerchantInfo ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PPRetailInvoiceMerchantInfo> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("merchantInfo")));
				} else {
					ret =  Runtime.GetNSObject<PPRetailInvoiceMerchantInfo> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("merchantInfo")));
				}
				return ret;
			}
			
			[Export ("setMerchantInfo:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMerchantInfo:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMerchantInfo:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string MerchantMemo {
			[Export ("merchantMemo", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("merchantMemo")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("merchantMemo")));
				}
			}
			
			[Export ("setMerchantMemo:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMerchantMemo:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMerchantMemo:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual PPRetailInvoiceMetaData Metadata {
			[Export ("metadata", ArgumentSemantic.Retain)]
			get {
				PPRetailInvoiceMetaData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PPRetailInvoiceMetaData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("metadata")));
				} else {
					ret =  Runtime.GetNSObject<PPRetailInvoiceMetaData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("metadata")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber MinimumAmountDue {
			[Export ("minimumAmountDue", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("minimumAmountDue")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("minimumAmountDue")));
				}
				return ret;
			}
			
			[Export ("setMinimumAmountDue:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMinimumAmountDue:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMinimumAmountDue:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Note {
			[Export ("note", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("note")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("note")));
				}
			}
			
			[Export ("setNote:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setNote:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setNote:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string Number {
			[Export ("number", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("number")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("number")));
				}
			}
			
			[Export ("setNumber:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setNumber:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setNumber:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber PaidAmount {
			[Export ("paidAmount", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("paidAmount")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("paidAmount")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber PaidAmountOther {
			[Export ("paidAmountOther", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("paidAmountOther")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("paidAmountOther")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber PaidAmountPayPal {
			[Export ("paidAmountPayPal", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("paidAmountPayPal")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("paidAmountPayPal")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string PayPalId {
			[Export ("payPalId", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("payPalId")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("payPalId")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string PayerViewUrl {
			[Export ("payerViewUrl", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("payerViewUrl")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("payerViewUrl")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual PPRetailInvoicePaymentTerm PaymentTerms {
			[Export ("paymentTerms", ArgumentSemantic.Retain)]
			get {
				PPRetailInvoicePaymentTerm ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PPRetailInvoicePaymentTerm> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("paymentTerms")));
				} else {
					ret =  Runtime.GetNSObject<PPRetailInvoicePaymentTerm> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("paymentTerms")));
				}
				return ret;
			}
			
			[Export ("setPaymentTerms:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPaymentTerms:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPaymentTerms:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSObject[] Payments {
			[Export ("payments", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("payments")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("payments")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Reference {
			[Export ("reference", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("reference")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("reference")));
				}
			}
			
			[Export ("setReference:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setReference:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setReference:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber RefundedAmount {
			[Export ("refundedAmount", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("refundedAmount")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("refundedAmount")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber RefundedAmountOther {
			[Export ("refundedAmountOther", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("refundedAmountOther")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("refundedAmountOther")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber RefundedAmountPayPal {
			[Export ("refundedAmountPayPal", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("refundedAmountPayPal")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("refundedAmountPayPal")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSObject[] Refunds {
			[Export ("refunds", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("refunds")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("refunds")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber RemainingAmount {
			[Export ("remainingAmount", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("remainingAmount")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remainingAmount")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber ShippingAmount {
			[Export ("shippingAmount", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("shippingAmount")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shippingAmount")));
				}
				return ret;
			}
			
			[Export ("setShippingAmount:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setShippingAmount:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setShippingAmount:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PPRetailInvoiceShippingInfo ShippingInfo {
			[Export ("shippingInfo", ArgumentSemantic.Retain)]
			get {
				PPRetailInvoiceShippingInfo ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PPRetailInvoiceShippingInfo> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("shippingInfo")));
				} else {
					ret =  Runtime.GetNSObject<PPRetailInvoiceShippingInfo> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shippingInfo")));
				}
				return ret;
			}
			
			[Export ("setShippingInfo:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setShippingInfo:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setShippingInfo:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string ShippingTaxName {
			[Export ("shippingTaxName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("shippingTaxName")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shippingTaxName")));
				}
			}
			
			[Export ("setShippingTaxName:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setShippingTaxName:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setShippingTaxName:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber ShippingTaxRate {
			[Export ("shippingTaxRate", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("shippingTaxRate")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shippingTaxRate")));
				}
				return ret;
			}
			
			[Export ("setShippingTaxRate:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setShippingTaxRate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setShippingTaxRate:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PPRetailInvoiceStatus Status {
			[Export ("status", ArgumentSemantic.UnsafeUnretained)]
			get {
				PPRetailInvoiceStatus ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PPRetailInvoiceStatus) global::ApiDefinitions.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("status"));
					} else {
						ret = (PPRetailInvoiceStatus) global::ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("status"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PPRetailInvoiceStatus) global::ApiDefinitions.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("status"));
					} else {
						ret = (PPRetailInvoiceStatus) global::ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("status"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber SubTotal {
			[Export ("subTotal", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("subTotal")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("subTotal")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static NSObject[] SupportedCurrencies {
			[Export ("supportedCurrencies")]
			get {
				NSObject[] ret;
				ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("supportedCurrencies")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSDictionary TaxBreakdown {
			[Export ("taxBreakdown", ArgumentSemantic.Retain)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("taxBreakdown")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("taxBreakdown")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool TaxCalculatedAfterDiscount {
			[Export ("taxCalculatedAfterDiscount")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("taxCalculatedAfterDiscount"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("taxCalculatedAfterDiscount"));
				}
			}
			
			[Export ("setTaxCalculatedAfterDiscount:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setTaxCalculatedAfterDiscount:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setTaxCalculatedAfterDiscount:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool TaxInclusive {
			[Export ("taxInclusive")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("taxInclusive"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("taxInclusive"));
				}
			}
			
			[Export ("setTaxInclusive:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setTaxInclusive:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setTaxInclusive:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string TemplateID {
			[Export ("templateID", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("templateID")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("templateID")));
				}
			}
			
			[Export ("setTemplateID:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTemplateID:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTemplateID:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string TermsAndConditions {
			[Export ("termsAndConditions", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("termsAndConditions")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("termsAndConditions")));
				}
			}
			
			[Export ("setTermsAndConditions:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTermsAndConditions:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTermsAndConditions:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber Total {
			[Export ("total", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("total")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("total")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber TotalDiscount {
			[Export ("totalDiscount", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("totalDiscount")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("totalDiscount")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Uri {
			[Export ("uri", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("uri")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("uri")));
				}
			}
			
			[Export ("setUri:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUri:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUri:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool WasDeleted {
			[Export ("wasDeleted")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("wasDeleted"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("wasDeleted"));
				}
			}
			
			[Export ("setWasDeleted:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setWasDeleted:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setWasDeleted:"), value);
				}
			}
		}
		
	} /* class PPRetailInvoice */
}
