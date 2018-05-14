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
	[Register("PPManticoreEngine", true)]
	public unsafe partial class PPManticoreEngine : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PPManticoreEngine");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PPManticoreEngine () : base (NSObjectFlag.Empty)
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
		protected PPManticoreEngine (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PPManticoreEngine (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("attachNativeObject:ofType:")]
		[CompilerGenerated]
		public virtual NSObject AttachNativeObject (global::JavaScriptCore.JSValue value, Class nativeType)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (nativeType == null)
				throw new ArgumentNullException ("nativeType");
			if (IsDirectBinding) {
				return Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("attachNativeObject:ofType:"), value.Handle, nativeType.Handle));
			} else {
				return Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("attachNativeObject:ofType:"), value.Handle, nativeType.Handle));
			}
		}
		
		[Export ("createJSObject:withArguments:")]
		[CompilerGenerated]
		public virtual global::JavaScriptCore.JSValue CreateJSObject (string jsClassName, NSObject[] args)
		{
			if (jsClassName == null)
				throw new ArgumentNullException ("jsClassName");
			var nsjsClassName = NSString.CreateNative (jsClassName);
			var nsa_args = args == null ? null : NSArray.FromNSObjects (args);
			
			global::JavaScriptCore.JSValue ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::JavaScriptCore.JSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("createJSObject:withArguments:"), nsjsClassName, nsa_args == null ? IntPtr.Zero : nsa_args.Handle));
			} else {
				ret =  Runtime.GetNSObject<global::JavaScriptCore.JSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("createJSObject:withArguments:"), nsjsClassName, nsa_args == null ? IntPtr.Zero : nsa_args.Handle));
			}
			NSString.ReleaseNative (nsjsClassName);
			if (nsa_args != null)
				nsa_args.Dispose ();
			
			return ret;
		}
		
		[Export ("loadScript:withName:")]
		[CompilerGenerated]
		public virtual void LoadScript (string script, string name)
		{
			if (script == null)
				throw new ArgumentNullException ("script");
			var nsscript = NSString.CreateNative (script);
			var nsname = NSString.CreateNative (name);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("loadScript:withName:"), nsscript, nsname);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("loadScript:withName:"), nsscript, nsname);
			}
			NSString.ReleaseNative (nsscript);
			NSString.ReleaseNative (nsname);
			
		}
		
		[Export ("resolveJSClass:")]
		[CompilerGenerated]
		public virtual global::JavaScriptCore.JSValue ResolveJSClass (string jsClassName)
		{
			if (jsClassName == null)
				throw new ArgumentNullException ("jsClassName");
			var nsjsClassName = NSString.CreateNative (jsClassName);
			
			global::JavaScriptCore.JSValue ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::JavaScriptCore.JSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("resolveJSClass:"), nsjsClassName));
			} else {
				ret =  Runtime.GetNSObject<global::JavaScriptCore.JSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("resolveJSClass:"), nsjsClassName));
			}
			NSString.ReleaseNative (nsjsClassName);
			
			return ret;
		}
		
		[Export ("resolveJSObject:ofType:")]
		[CompilerGenerated]
		public virtual NSObject ResolveJSObject (NSObject @object, Class nativeType)
		{
			if (nativeType == null)
				throw new ArgumentNullException ("nativeType");
			if (IsDirectBinding) {
				return Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("resolveJSObject:ofType:"), @object == null ? IntPtr.Zero : @object.Handle, nativeType.Handle));
			} else {
				return Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("resolveJSObject:ofType:"), @object == null ? IntPtr.Zero : @object.Handle, nativeType.Handle));
			}
		}
		
		[Export ("resolvePromise:toCallback:")]
		[CompilerGenerated]
		public unsafe virtual void ResolvePromise (global::JavaScriptCore.JSValue promise, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<global::JavaScriptCore.JSValue, global::JavaScriptCore.JSValue> callback)
		{
			if (promise == null)
				throw new ArgumentNullException ("promise");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlockUnsafe (Trampolines.SDActionArity2V0.Handler, callback);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("resolvePromise:toCallback:"), promise.Handle, (IntPtr) block_ptr_callback);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("resolvePromise:toCallback:"), promise.Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public virtual global::JavaScriptCore.JSContext Context {
			[Export ("context")]
			get {
				global::JavaScriptCore.JSContext ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::JavaScriptCore.JSContext> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("context")));
				} else {
					ret =  Runtime.GetNSObject<global::JavaScriptCore.JSContext> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("context")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual PPManticoreTypeConverter Converter {
			[Export ("converter", ArgumentSemantic.Retain)]
			get {
				PPManticoreTypeConverter ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PPManticoreTypeConverter> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("converter")));
				} else {
					ret =  Runtime.GetNSObject<PPManticoreTypeConverter> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("converter")));
				}
				return ret;
			}
			
			[Export ("setConverter:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setConverter:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setConverter:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::JavaScriptCore.JSContext GlobalContext {
			[Export ("globalContext")]
			get {
				global::JavaScriptCore.JSContext ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::JavaScriptCore.JSContext> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("globalContext")));
				} else {
					ret =  Runtime.GetNSObject<global::JavaScriptCore.JSContext> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("globalContext")));
				}
				return ret;
			}
			
		}
		
	} /* class PPManticoreEngine */
}
