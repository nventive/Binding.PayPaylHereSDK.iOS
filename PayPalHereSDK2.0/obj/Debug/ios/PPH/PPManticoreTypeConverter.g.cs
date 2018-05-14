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
	[Register("PPManticoreTypeConverter", true)]
	public unsafe partial class PPManticoreTypeConverter : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PPManticoreTypeConverter");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PPManticoreTypeConverter () : base (NSObjectFlag.Empty)
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
		protected PPManticoreTypeConverter (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PPManticoreTypeConverter (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithEngine:")]
		[CompilerGenerated]
		public PPManticoreTypeConverter (PPManticoreEngine engine)
			: base (NSObjectFlag.Empty)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithEngine:"), engine.Handle), "initWithEngine:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithEngine:"), engine.Handle), "initWithEngine:");
			}
		}
		
		[Export ("toJsArray:withConverter:")]
		[CompilerGenerated]
		public unsafe virtual global::JavaScriptCore.JSValue ToJsArray (NSObject[] array, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V0))]global::System.Func<NSObject, NSObject> converter)
		{
			if (array == null)
				throw new ArgumentNullException ("array");
			if (converter == null)
				throw new ArgumentNullException ("converter");
			var nsa_array = NSArray.FromNSObjects (array);
			BlockLiteral *block_ptr_converter;
			BlockLiteral block_converter;
			block_converter = new BlockLiteral ();
			block_ptr_converter = &block_converter;
			block_converter.SetupBlockUnsafe (Trampolines.SDFuncArity2V0.Handler, converter);
			
			global::JavaScriptCore.JSValue ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::JavaScriptCore.JSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("toJsArray:withConverter:"), nsa_array.Handle, (IntPtr) block_ptr_converter));
			} else {
				ret =  Runtime.GetNSObject<global::JavaScriptCore.JSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("toJsArray:withConverter:"), nsa_array.Handle, (IntPtr) block_ptr_converter));
			}
			nsa_array.Dispose ();
			block_ptr_converter->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("toJsBool:")]
		[CompilerGenerated]
		public virtual global::JavaScriptCore.JSValue ToJsBool (bool boolValue)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::JavaScriptCore.JSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_bool (this.Handle, Selector.GetHandle ("toJsBool:"), boolValue));
			} else {
				return  Runtime.GetNSObject<global::JavaScriptCore.JSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("toJsBool:"), boolValue));
			}
		}
		
		[Export ("toJsDecimal:")]
		[CompilerGenerated]
		public virtual global::JavaScriptCore.JSValue ToJsDecimal (NSDecimalNumber decimalValue)
		{
			if (decimalValue == null)
				throw new ArgumentNullException ("decimalValue");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::JavaScriptCore.JSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("toJsDecimal:"), decimalValue.Handle));
			} else {
				return  Runtime.GetNSObject<global::JavaScriptCore.JSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("toJsDecimal:"), decimalValue.Handle));
			}
		}
		
		[Export ("toJsInt:")]
		[CompilerGenerated]
		public virtual global::JavaScriptCore.JSValue ToJsInt (int integerValue)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::JavaScriptCore.JSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_int (this.Handle, Selector.GetHandle ("toJsInt:"), integerValue));
			} else {
				return  Runtime.GetNSObject<global::JavaScriptCore.JSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("toJsInt:"), integerValue));
			}
		}
		
		[Export ("toJsObject:")]
		[CompilerGenerated]
		public virtual global::JavaScriptCore.JSValue ToJsObject (NSDictionary value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::JavaScriptCore.JSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("toJsObject:"), value.Handle));
			} else {
				return  Runtime.GetNSObject<global::JavaScriptCore.JSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("toJsObject:"), value.Handle));
			}
		}
		
		[Export ("toNativeArray:withConverter:")]
		[CompilerGenerated]
		public unsafe virtual NSObject[] ToNativeArray (global::JavaScriptCore.JSValue value, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V0))]global::System.Func<NSObject, NSObject> converter)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (converter == null)
				throw new ArgumentNullException ("converter");
			BlockLiteral *block_ptr_converter;
			BlockLiteral block_converter;
			block_converter = new BlockLiteral ();
			block_ptr_converter = &block_converter;
			block_converter.SetupBlockUnsafe (Trampolines.SDFuncArity2V0.Handler, converter);
			
			NSObject[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("toNativeArray:withConverter:"), value.Handle, (IntPtr) block_ptr_converter));
			} else {
				ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("toNativeArray:withConverter:"), value.Handle, (IntPtr) block_ptr_converter));
			}
			block_ptr_converter->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("toNativeBool:")]
		[CompilerGenerated]
		public virtual bool ToNativeBool (global::JavaScriptCore.JSValue value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("toNativeBool:"), value.Handle);
			} else {
				return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("toNativeBool:"), value.Handle);
			}
		}
		
		[Export ("toNativeDecimal:")]
		[CompilerGenerated]
		public virtual NSDecimalNumber ToNativeDecimal (global::JavaScriptCore.JSValue value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("toNativeDecimal:"), value.Handle));
			} else {
				return  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("toNativeDecimal:"), value.Handle));
			}
		}
		
		[Export ("toNativeError:")]
		[CompilerGenerated]
		public virtual NSError ToNativeError (global::JavaScriptCore.JSValue error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSError> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("toNativeError:"), error.Handle));
			} else {
				return  Runtime.GetNSObject<NSError> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("toNativeError:"), error.Handle));
			}
		}
		
		[Export ("toNativeInt:")]
		[CompilerGenerated]
		public virtual int ToNativeInt (global::JavaScriptCore.JSValue value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("toNativeInt:"), value.Handle);
			} else {
				return global::ApiDefinitions.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("toNativeInt:"), value.Handle);
			}
		}
		
		[Export ("toNativeObject:")]
		[CompilerGenerated]
		public virtual NSDictionary ToNativeObject (global::JavaScriptCore.JSValue value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("toNativeObject:"), value.Handle));
			} else {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("toNativeObject:"), value.Handle));
			}
		}
		
		[CompilerGenerated]
		public virtual Class ErrorClass {
			[Export ("errorClass", ArgumentSemantic.UnsafeUnretained)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("errorClass"));
				} else {
					ret = global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("errorClass"));
				}
				return ret == IntPtr.Zero ? null : new global::ObjCRuntime.Class (ret);
			}
			
			[Export ("setErrorClass:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setErrorClass:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setErrorClass:"), value.Handle);
				}
			}
		}
		
	} /* class PPManticoreTypeConverter */
}
