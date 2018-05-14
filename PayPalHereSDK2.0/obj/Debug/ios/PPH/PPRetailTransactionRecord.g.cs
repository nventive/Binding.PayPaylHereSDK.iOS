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
	[Register("PPRetailTransactionRecord", true)]
	public unsafe partial class PPRetailTransactionRecord : PPRetailObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PPRetailTransactionRecord");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PPRetailTransactionRecord () : base (NSObjectFlag.Empty)
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
		protected PPRetailTransactionRecord (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PPRetailTransactionRecord (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual string AuthCode {
			[Export ("authCode", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("authCode")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("authCode")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string CaptureId {
			[Export ("captureId", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("captureId")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("captureId")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual PPRetailCard Card {
			[Export ("card", ArgumentSemantic.Retain)]
			get {
				PPRetailCard ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PPRetailCard> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("card")));
				} else {
					ret =  Runtime.GetNSObject<PPRetailCard> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("card")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string CorrelationId {
			[Export ("correlationId", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("correlationId")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("correlationId")));
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
		public virtual PPRetailPayer Payer {
			[Export ("payer", ArgumentSemantic.Retain)]
			get {
				PPRetailPayer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PPRetailPayer> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("payer")));
				} else {
					ret =  Runtime.GetNSObject<PPRetailPayer> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("payer")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PPRetailInvoicePaymentMethod PaymentMethod {
			[Export ("paymentMethod", ArgumentSemantic.UnsafeUnretained)]
			get {
				PPRetailInvoicePaymentMethod ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PPRetailInvoicePaymentMethod) global::ApiDefinitions.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("paymentMethod"));
					} else {
						ret = (PPRetailInvoicePaymentMethod) global::ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("paymentMethod"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PPRetailInvoicePaymentMethod) global::ApiDefinitions.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("paymentMethod"));
					} else {
						ret = (PPRetailInvoicePaymentMethod) global::ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("paymentMethod"));
					}
				}
				return ret;
			}
			
			[Export ("setPaymentMethod:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setPaymentMethod:"), (Int64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setPaymentMethod:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setPaymentMethod:"), (Int64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setPaymentMethod:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PPRetailReceiptDestination ReceiptDestination {
			[Export ("receiptDestination", ArgumentSemantic.Retain)]
			get {
				PPRetailReceiptDestination ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PPRetailReceiptDestination> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("receiptDestination")));
				} else {
					ret =  Runtime.GetNSObject<PPRetailReceiptDestination> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("receiptDestination")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string ResponseCode {
			[Export ("responseCode", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("responseCode")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("responseCode")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string TransactionHandle {
			[Export ("transactionHandle", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("transactionHandle")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("transactionHandle")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string TransactionNumber {
			[Export ("transactionNumber", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("transactionNumber")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("transactionNumber")));
				}
			}
			
		}
		
	} /* class PPRetailTransactionRecord */
}
