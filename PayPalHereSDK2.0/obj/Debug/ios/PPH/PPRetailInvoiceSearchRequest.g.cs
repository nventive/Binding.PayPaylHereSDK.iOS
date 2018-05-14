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
	[Register("PPRetailInvoiceSearchRequest", true)]
	public unsafe partial class PPRetailInvoiceSearchRequest : PPRetailObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PPRetailInvoiceSearchRequest");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PPRetailInvoiceSearchRequest () : base (NSObjectFlag.Empty)
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
		protected PPRetailInvoiceSearchRequest (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PPRetailInvoiceSearchRequest (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("addStatus:")]
		[CompilerGenerated]
		public virtual void AddStatus (PPRetailInvoiceStatus status)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("addStatus:"), (Int64)status);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("addStatus:"), (int)status);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("addStatus:"), (Int64)status);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("addStatus:"), (int)status);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Archived {
			[Export ("archived")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("archived"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("archived"));
				}
			}
			
			[Export ("setArchived:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setArchived:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setArchived:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Email {
			[Export ("email", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("email")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("email")));
				}
			}
			
			[Export ("setEmail:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setEmail:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setEmail:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual NSDate EndCreationDate {
			[Export ("endCreationDate", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("endCreationDate")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("endCreationDate")));
				}
				return ret;
			}
			
			[Export ("setEndCreationDate:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setEndCreationDate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setEndCreationDate:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSDate EndDueDate {
			[Export ("endDueDate", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("endDueDate")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("endDueDate")));
				}
				return ret;
			}
			
			[Export ("setEndDueDate:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setEndDueDate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setEndDueDate:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSDate EndInvoiceDate {
			[Export ("endInvoiceDate", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("endInvoiceDate")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("endInvoiceDate")));
				}
				return ret;
			}
			
			[Export ("setEndInvoiceDate:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setEndInvoiceDate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setEndInvoiceDate:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSDate EndPaymentDate {
			[Export ("endPaymentDate", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("endPaymentDate")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("endPaymentDate")));
				}
				return ret;
			}
			
			[Export ("setEndPaymentDate:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setEndPaymentDate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setEndPaymentDate:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber LowerTotalAmount {
			[Export ("lowerTotalAmount", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lowerTotalAmount")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lowerTotalAmount")));
				}
				return ret;
			}
			
			[Export ("setLowerTotalAmount:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLowerTotalAmount:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLowerTotalAmount:"), value == null ? IntPtr.Zero : value.Handle);
				}
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
		public virtual int PageSize {
			[Export ("pageSize")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("pageSize"));
				} else {
					return global::ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pageSize"));
				}
			}
			
			[Export ("setPageSize:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setPageSize:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setPageSize:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string RecipientBusinessName {
			[Export ("recipientBusinessName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("recipientBusinessName")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("recipientBusinessName")));
				}
			}
			
			[Export ("setRecipientBusinessName:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRecipientBusinessName:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRecipientBusinessName:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string RecipientFirstName {
			[Export ("recipientFirstName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("recipientFirstName")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("recipientFirstName")));
				}
			}
			
			[Export ("setRecipientFirstName:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRecipientFirstName:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRecipientFirstName:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string RecipientLastName {
			[Export ("recipientLastName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("recipientLastName")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("recipientLastName")));
				}
			}
			
			[Export ("setRecipientLastName:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRecipientLastName:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRecipientLastName:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual NSDate StartCreationDate {
			[Export ("startCreationDate", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("startCreationDate")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startCreationDate")));
				}
				return ret;
			}
			
			[Export ("setStartCreationDate:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setStartCreationDate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setStartCreationDate:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSDate StartDueDate {
			[Export ("startDueDate", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("startDueDate")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startDueDate")));
				}
				return ret;
			}
			
			[Export ("setStartDueDate:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setStartDueDate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setStartDueDate:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int StartIndex {
			[Export ("startIndex")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("startIndex"));
				} else {
					return global::ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startIndex"));
				}
			}
			
			[Export ("setStartIndex:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setStartIndex:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setStartIndex:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSDate StartInvoiceDate {
			[Export ("startInvoiceDate", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("startInvoiceDate")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startInvoiceDate")));
				}
				return ret;
			}
			
			[Export ("setStartInvoiceDate:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setStartInvoiceDate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setStartInvoiceDate:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSDate StartPaymentDate {
			[Export ("startPaymentDate", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("startPaymentDate")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startPaymentDate")));
				}
				return ret;
			}
			
			[Export ("setStartPaymentDate:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setStartPaymentDate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setStartPaymentDate:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool TotalCountRequired {
			[Export ("totalCountRequired")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("totalCountRequired"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("totalCountRequired"));
				}
			}
			
			[Export ("setTotalCountRequired:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setTotalCountRequired:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setTotalCountRequired:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber UpperTotalAmount {
			[Export ("upperTotalAmount", ArgumentSemantic.Retain)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("upperTotalAmount")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("upperTotalAmount")));
				}
				return ret;
			}
			
			[Export ("setUpperTotalAmount:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUpperTotalAmount:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUpperTotalAmount:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
	} /* class PPRetailInvoiceSearchRequest */
}
