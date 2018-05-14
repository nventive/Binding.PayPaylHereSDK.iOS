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
	public unsafe static partial class PPManticoreEngine_Private  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PPManticoreEngine");
		
		[Export ("exports")]
		[CompilerGenerated]
		public static global::JavaScriptCore.JSValue Exports (this PPManticoreEngine This)
		{
			return  Runtime.GetNSObject<global::JavaScriptCore.JSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("exports")));
		}
		
		[Export ("jsEngine")]
		[CompilerGenerated]
		public static global::JavaScriptCore.JSContext Get_JsEngine (this PPManticoreEngine This)
		{
			return  Runtime.GetNSObject<global::JavaScriptCore.JSContext> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("jsEngine")));
		}
		
		[Export ("native")]
		[CompilerGenerated]
		public static PPManticoreNativeInterface Native (this PPManticoreEngine This)
		{
			return  Runtime.GetNSObject<PPManticoreNativeInterface> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("native")));
		}
		
		[Export ("setexports")]
		[CompilerGenerated]
		public static void Set_Exports (this PPManticoreEngine This, global::JavaScriptCore.JSValue value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setexports"), value.Handle);
		}
		
		[Export ("setjsEngine")]
		[CompilerGenerated]
		public static void Set_JsEngine (this PPManticoreEngine This, global::JavaScriptCore.JSContext value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setjsEngine"), value.Handle);
		}
		
		[Export ("setnative")]
		[CompilerGenerated]
		public static void Set_Native (this PPManticoreEngine This, PPManticoreNativeInterface value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setnative"), value.Handle);
		}
		
	} /* class PPManticoreEngine_Private */
}
