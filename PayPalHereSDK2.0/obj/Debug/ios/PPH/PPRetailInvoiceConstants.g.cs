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
	[Register("PPRetailInvoiceConstants", true)]
	public unsafe partial class PPRetailInvoiceConstants : PPRetailObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PPRetailInvoiceConstants");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PPRetailInvoiceConstants () : base (NSObjectFlag.Empty)
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
		protected PPRetailInvoiceConstants (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PPRetailInvoiceConstants (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public static NSDecimalNumber DiscountPercentageDecimalPrecision {
			[Export ("discountPercentageDecimalPrecision")]
			get {
				NSDecimalNumber ret;
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("discountPercentageDecimalPrecision")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static NSDecimalNumber InvoiceMerchantMemoMaxLength {
			[Export ("invoiceMerchantMemoMaxLength")]
			get {
				NSDecimalNumber ret;
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("invoiceMerchantMemoMaxLength")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static NSDecimalNumber InvoiceNoteMaxLength {
			[Export ("invoiceNoteMaxLength")]
			get {
				NSDecimalNumber ret;
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("invoiceNoteMaxLength")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static NSDecimalNumber InvoiceNumberMaxLength {
			[Export ("invoiceNumberMaxLength")]
			get {
				NSDecimalNumber ret;
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("invoiceNumberMaxLength")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static NSDecimalNumber InvoiceReferenceMaxLength {
			[Export ("invoiceReferenceMaxLength")]
			get {
				NSDecimalNumber ret;
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("invoiceReferenceMaxLength")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static NSDecimalNumber InvoiceTermsMaxLength {
			[Export ("invoiceTermsMaxLength")]
			get {
				NSDecimalNumber ret;
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("invoiceTermsMaxLength")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static NSDecimalNumber ItemDescriptionMaxLength {
			[Export ("itemDescriptionMaxLength")]
			get {
				NSDecimalNumber ret;
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("itemDescriptionMaxLength")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static NSDecimalNumber ItemNameMaxLength {
			[Export ("itemNameMaxLength")]
			get {
				NSDecimalNumber ret;
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("itemNameMaxLength")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static NSDecimalNumber ItemPriceMax {
			[Export ("itemPriceMax")]
			get {
				NSDecimalNumber ret;
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("itemPriceMax")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static NSDecimalNumber ItemQuantityDecimalPrecision {
			[Export ("itemQuantityDecimalPrecision")]
			get {
				NSDecimalNumber ret;
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("itemQuantityDecimalPrecision")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static NSDecimalNumber ItemQuantityMax {
			[Export ("itemQuantityMax")]
			get {
				NSDecimalNumber ret;
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("itemQuantityMax")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static NSDecimalNumber ItemQuantityMin {
			[Export ("itemQuantityMin")]
			get {
				NSDecimalNumber ret;
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("itemQuantityMin")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static NSDecimalNumber TaxRateDecimalPrecision {
			[Export ("taxRateDecimalPrecision")]
			get {
				NSDecimalNumber ret;
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("taxRateDecimalPrecision")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static NSDecimalNumber TaxRateMaxValue {
			[Export ("taxRateMaxValue")]
			get {
				NSDecimalNumber ret;
				ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("taxRateMaxValue")));
				return ret;
			}
			
		}
		
	} /* class PPRetailInvoiceConstants */
}
