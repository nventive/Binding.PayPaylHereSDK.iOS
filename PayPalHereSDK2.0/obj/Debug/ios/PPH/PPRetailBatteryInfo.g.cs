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
	[Register("PPRetailBatteryInfo", true)]
	public unsafe partial class PPRetailBatteryInfo : PPRetailObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PPRetailBatteryInfo");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PPRetailBatteryInfo (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PPRetailBatteryInfo (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithPercentage:isCharging:measuredOn:status:")]
		[CompilerGenerated]
		public PPRetailBatteryInfo (int percentage, bool isCharging, NSDate measuredOn, PPRetailbatteryStatus status)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_int_bool_IntPtr_Int64 (this.Handle, Selector.GetHandle ("initWithPercentage:isCharging:measuredOn:status:"), percentage, isCharging, measuredOn == null ? IntPtr.Zero : measuredOn.Handle, (Int64)status), "initWithPercentage:isCharging:measuredOn:status:");
				} else {
					InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_int_bool_IntPtr_int (this.Handle, Selector.GetHandle ("initWithPercentage:isCharging:measuredOn:status:"), percentage, isCharging, measuredOn == null ? IntPtr.Zero : measuredOn.Handle, (int)status), "initWithPercentage:isCharging:measuredOn:status:");
				}
			} else {
				if (IntPtr.Size == 8) {
					InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_int_bool_IntPtr_Int64 (this.SuperHandle, Selector.GetHandle ("initWithPercentage:isCharging:measuredOn:status:"), percentage, isCharging, measuredOn == null ? IntPtr.Zero : measuredOn.Handle, (Int64)status), "initWithPercentage:isCharging:measuredOn:status:");
				} else {
					InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_int_bool_IntPtr_int (this.SuperHandle, Selector.GetHandle ("initWithPercentage:isCharging:measuredOn:status:"), percentage, isCharging, measuredOn == null ? IntPtr.Zero : measuredOn.Handle, (int)status), "initWithPercentage:isCharging:measuredOn:status:");
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsCharging {
			[Export ("isCharging")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isCharging"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isCharging"));
				}
			}
			
			[Export ("setIsCharging:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsCharging:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsCharging:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsLevelCritical {
			[Export ("isLevelCritical")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isLevelCritical"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isLevelCritical"));
				}
			}
			
			[Export ("setIsLevelCritical:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsLevelCritical:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsLevelCritical:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsLevelUpdateCritical {
			[Export ("isLevelUpdateCritical")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isLevelUpdateCritical"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isLevelUpdateCritical"));
				}
			}
			
			[Export ("setIsLevelUpdateCritical:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsLevelUpdateCritical:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsLevelUpdateCritical:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSDate MeasuredOn {
			[Export ("measuredOn", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("measuredOn")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("measuredOn")));
				}
				return ret;
			}
			
			[Export ("setMeasuredOn:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMeasuredOn:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMeasuredOn:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int Percentage {
			[Export ("percentage")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("percentage"));
				} else {
					return global::ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("percentage"));
				}
			}
			
			[Export ("setPercentage:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setPercentage:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setPercentage:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual PPRetailbatteryStatus Status {
			[Export ("status", ArgumentSemantic.UnsafeUnretained)]
			get {
				PPRetailbatteryStatus ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (PPRetailbatteryStatus) global::ApiDefinitions.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("status"));
					} else {
						ret = (PPRetailbatteryStatus) global::ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("status"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (PPRetailbatteryStatus) global::ApiDefinitions.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("status"));
					} else {
						ret = (PPRetailbatteryStatus) global::ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("status"));
					}
				}
				return ret;
			}
			
			[Export ("setStatus:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setStatus:"), (Int64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setStatus:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setStatus:"), (Int64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setStatus:"), (int)value);
					}
				}
			}
		}
		
	} /* class PPRetailBatteryInfo */
}
