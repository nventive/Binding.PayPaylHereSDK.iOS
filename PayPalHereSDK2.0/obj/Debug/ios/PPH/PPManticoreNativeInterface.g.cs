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
	[Register("PPManticoreNativeInterface", true)]
	public unsafe partial class PPManticoreNativeInterface : NSObject, global::JavaScriptCore.IJSExport {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PPManticoreNativeInterface");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PPManticoreNativeInterface () : base (NSObjectFlag.Empty)
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
		protected PPManticoreNativeInterface (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PPManticoreNativeInterface (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithEngine:")]
		[CompilerGenerated]
		public PPManticoreNativeInterface (PPManticoreEngine engine)
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
		
		[Export ("http:callback:")]
		[CompilerGenerated]
		public virtual global::JavaScriptCore.JSValue Http (global::JavaScriptCore.JSValue options, global::JavaScriptCore.JSValue callback)
		{
			if (options == null)
				throw new ArgumentNullException ("options");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::JavaScriptCore.JSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("http:callback:"), options.Handle, callback.Handle));
			} else {
				return  Runtime.GetNSObject<global::JavaScriptCore.JSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("http:callback:"), options.Handle, callback.Handle));
			}
		}
		
		[Export ("log:component:message:")]
		[CompilerGenerated]
		public virtual void Log (string level, string component, string message)
		{
			if (level == null)
				throw new ArgumentNullException ("level");
			if (component == null)
				throw new ArgumentNullException ("component");
			if (message == null)
				throw new ArgumentNullException ("message");
			var nslevel = NSString.CreateNative (level);
			var nscomponent = NSString.CreateNative (component);
			var nsmessage = NSString.CreateNative (message);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("log:component:message:"), nslevel, nscomponent, nsmessage);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("log:component:message:"), nslevel, nscomponent, nsmessage);
			}
			NSString.ReleaseNative (nslevel);
			NSString.ReleaseNative (nscomponent);
			NSString.ReleaseNative (nsmessage);
			
		}
		
		[Export ("setTimeout:after:")]
		[CompilerGenerated]
		public unsafe virtual global::JavaScriptCore.JSValue SetTimeout ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action function, nint milliseconds)
		{
			if (function == null)
				throw new ArgumentNullException ("function");
			BlockLiteral *block_ptr_function;
			BlockLiteral block_function;
			block_function = new BlockLiteral ();
			block_ptr_function = &block_function;
			block_function.SetupBlockUnsafe (Trampolines.SDAction.Handler, function);
			
			global::JavaScriptCore.JSValue ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::JavaScriptCore.JSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_nint (this.Handle, Selector.GetHandle ("setTimeout:after:"), (IntPtr) block_ptr_function, milliseconds));
			} else {
				ret =  Runtime.GetNSObject<global::JavaScriptCore.JSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_nint (this.SuperHandle, Selector.GetHandle ("setTimeout:after:"), (IntPtr) block_ptr_function, milliseconds));
			}
			block_ptr_function->CleanupBlock ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public virtual global::JavaScriptCore.JSValue ManticoreObject {
			[Export ("manticoreObject", ArgumentSemantic.Retain)]
			get {
				global::JavaScriptCore.JSValue ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::JavaScriptCore.JSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("manticoreObject")));
				} else {
					ret =  Runtime.GetNSObject<global::JavaScriptCore.JSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("manticoreObject")));
				}
				return ret;
			}
			
		}
		
	} /* class PPManticoreNativeInterface */
}
