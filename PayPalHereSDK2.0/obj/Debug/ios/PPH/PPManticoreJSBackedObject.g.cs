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
	[Register("PPManticoreJSBackedObject", true)]
	public unsafe partial class PPManticoreJSBackedObject : NSObject, IPPManticoreNativeObjectProtocol {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PPManticoreJSBackedObject");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PPManticoreJSBackedObject () : base (NSObjectFlag.Empty)
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
		protected PPManticoreJSBackedObject (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PPManticoreJSBackedObject (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initFromJavascript:")]
		[CompilerGenerated]
		public PPManticoreJSBackedObject (global::JavaScriptCore.JSValue value)
			: base (NSObjectFlag.Empty)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initFromJavascript:"), value.Handle), "initFromJavascript:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initFromJavascript:"), value.Handle), "initFromJavascript:");
			}
		}
		
		[Export ("nativeClassForObject:")]
		[CompilerGenerated]
		public static Class NativeClassForObject (global::JavaScriptCore.JSValue value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			IntPtr ret;
			ret = global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("nativeClassForObject:"), value.Handle);
			return ret == IntPtr.Zero ? null : new global::ObjCRuntime.Class (ret);
		}
		
		[Export ("setManticoreEngine:")]
		[CompilerGenerated]
		public static void SetManticoreEngine (PPManticoreEngine engine)
		{
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setManticoreEngine:"), engine == null ? IntPtr.Zero : engine.Handle);
		}
		
		[CompilerGenerated]
		public static PPManticoreEngine Engine {
			[Export ("engine")]
			get {
				PPManticoreEngine ret;
				ret =  Runtime.GetNSObject<PPManticoreEngine> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("engine")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::JavaScriptCore.JSValue Impl {
			[Export ("impl", ArgumentSemantic.Retain)]
			get {
				global::JavaScriptCore.JSValue ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::JavaScriptCore.JSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("impl")));
				} else {
					ret =  Runtime.GetNSObject<global::JavaScriptCore.JSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("impl")));
				}
				return ret;
			}
			
			[Export ("setImpl:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setImpl:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setImpl:"), value.Handle);
				}
			}
		}
		
	} /* class PPManticoreJSBackedObject */
}
