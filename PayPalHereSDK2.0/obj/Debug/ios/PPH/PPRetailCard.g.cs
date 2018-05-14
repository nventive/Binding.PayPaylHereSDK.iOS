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
	[Register("PPRetailCard", true)]
	public unsafe partial class PPRetailCard : PPRetailObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PPRetailCard");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PPRetailCard () : base (NSObjectFlag.Empty)
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
		protected PPRetailCard (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PPRetailCard (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual PPRetailCardIssuer CardIssuer {
			[Export ("cardIssuer", ArgumentSemantic.UnsafeUnretained)]
			get {
				PPRetailCardIssuer ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PPRetailCardIssuer) global::ApiDefinitions.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("cardIssuer"));
					} else {
						ret = (PPRetailCardIssuer) global::ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("cardIssuer"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PPRetailCardIssuer) global::ApiDefinitions.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cardIssuer"));
					} else {
						ret = (PPRetailCardIssuer) global::ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cardIssuer"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string CardholderName {
			[Export ("cardholderName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cardholderName")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cardholderName")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool Failed {
			[Export ("failed")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("failed"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("failed"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual PPRetailFormFactor FormFactor {
			[Export ("formFactor", ArgumentSemantic.UnsafeUnretained)]
			get {
				PPRetailFormFactor ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PPRetailFormFactor) global::ApiDefinitions.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("formFactor"));
					} else {
						ret = (PPRetailFormFactor) global::ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("formFactor"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PPRetailFormFactor) global::ApiDefinitions.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("formFactor"));
					} else {
						ret = (PPRetailFormFactor) global::ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("formFactor"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsContactlessMSD {
			[Export ("isContactlessMSD")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isContactlessMSD"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isContactlessMSD"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsEmv {
			[Export ("isEmv")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isEmv"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isEmv"));
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
		public virtual string LastFourDigits {
			[Export ("lastFourDigits", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lastFourDigits")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lastFourDigits")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool PinPresent {
			[Export ("pinPresent")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("pinPresent"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pinPresent"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual PPRetailPaymentDevice Reader {
			[Export ("reader", ArgumentSemantic.Retain)]
			get {
				PPRetailPaymentDevice ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PPRetailPaymentDevice> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("reader")));
				} else {
					ret =  Runtime.GetNSObject<PPRetailPaymentDevice> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("reader")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Timestamp {
			[Export ("timestamp", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("timestamp")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("timestamp")));
				}
			}
			
		}
		
	} /* class PPRetailCard */
}
