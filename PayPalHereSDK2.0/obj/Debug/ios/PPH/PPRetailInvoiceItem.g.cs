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
	[Register("PPRetailInvoiceItem", true)]
	public unsafe partial class PPRetailInvoiceItem : PPRetailObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PPRetailInvoiceItem");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PPRetailInvoiceItem (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PPRetailInvoiceItem (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithName:quantity:unitPrice:itemId:detailId:")]
		[CompilerGenerated]
		public PPRetailInvoiceItem (string name, NSDecimalNumber quantity, NSDecimalNumber unitPrice, int itemId, string detailId)
			: base (NSObjectFlag.Empty)
		{
			var nsname = NSString.CreateNative (name);
			var nsdetailId = NSString.CreateNative (detailId);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_int_IntPtr (this.Handle, Selector.GetHandle ("initWithName:quantity:unitPrice:itemId:detailId:"), nsname, quantity == null ? IntPtr.Zero : quantity.Handle, unitPrice == null ? IntPtr.Zero : unitPrice.Handle, itemId, nsdetailId), "initWithName:quantity:unitPrice:itemId:detailId:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_int_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithName:quantity:unitPrice:itemId:detailId:"), nsname, quantity == null ? IntPtr.Zero : quantity.Handle, unitPrice == null ? IntPtr.Zero : unitPrice.Handle, itemId, nsdetailId), "initWithName:quantity:unitPrice:itemId:detailId:");
			}
			NSString.ReleaseNative (nsname);
			NSString.ReleaseNative (nsdetailId);
			
		}
		
		[Export ("discountAmountForDisplay")]
		[CompilerGenerated]
		public virtual NSDecimalNumber DiscountAmountForDisplay ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("discountAmountForDisplay")));
			} else {
				return  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("discountAmountForDisplay")));
			}
		}
		
		[Export ("duplicate")]
		[CompilerGenerated]
		public virtual PPRetailInvoiceItem Duplicate ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PPRetailInvoiceItem> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("duplicate")));
			} else {
				return  Runtime.GetNSObject<PPRetailInvoiceItem> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("duplicate")));
			}
		}
		
		[Export ("isEqualToItem:")]
		[CompilerGenerated]
		public virtual bool IsEqualToItem (PPRetailInvoiceItem item)
		{
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isEqualToItem:"), item == null ? IntPtr.Zero : item.Handle);
			} else {
				return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isEqualToItem:"), item == null ? IntPtr.Zero : item.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual NSDate Date {
			[Export ("date", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("date")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("date")));
				}
				return ret;
			}
			
			[Export ("setDate:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDate:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string DetailId {
			[Export ("detailId", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("detailId")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("detailId")));
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
		public virtual string ImageURL {
			[Export ("imageURL", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("imageURL")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("imageURL")));
				}
			}
			
			[Export ("setImageURL:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setImageURL:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setImageURL:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ItemDescription {
			[Export ("itemDescription", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("itemDescription")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("itemDescription")));
				}
			}
			
			[Export ("setItemDescription:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setItemDescription:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setItemDescription:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual int ItemId {
			[Export ("itemId")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("itemId"));
				} else {
					return global::ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("itemId"));
				}
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
			
			[Export ("setName:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setName:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setName:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber Quantity {
			[Export ("quantity", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("quantity")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("quantity")));
				}
				return ret;
			}
			
			[Export ("setQuantity:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setQuantity:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setQuantity:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string TaxName {
			[Export ("taxName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("taxName")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("taxName")));
				}
			}
			
			[Export ("setTaxName:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTaxName:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTaxName:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber TaxRate {
			[Export ("taxRate", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("taxRate")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("taxRate")));
				}
				return ret;
			}
			
			[Export ("setTaxRate:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTaxRate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTaxRate:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string UnitOfMeasure {
			[Export ("unitOfMeasure", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("unitOfMeasure")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("unitOfMeasure")));
				}
			}
			
			[Export ("setUnitOfMeasure:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUnitOfMeasure:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUnitOfMeasure:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber UnitPrice {
			[Export ("unitPrice", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("unitPrice")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("unitPrice")));
				}
				return ret;
			}
			
			[Export ("setUnitPrice:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUnitPrice:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUnitPrice:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
	} /* class PPRetailInvoiceItem */
}
