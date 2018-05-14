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
	[Protocol (Name = "PPManticorePluginDelegate", WrapperType = typeof (PPManticorePluginDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillLoadPolyfill", Selector = "willLoadPolyfill:", ParameterType = new Type [] { typeof (PPH.PPManticoreEngine) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidLoadPolyfill", Selector = "didLoadPolyfill:", ParameterType = new Type [] { typeof (PPH.PPManticoreEngine) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillLoadScriptEngine", Selector = "engine:willLoadScript:withName:", ParameterType = new Type [] { typeof (PPH.PPManticoreEngine), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidLoadWithScriptEngine", Selector = "engine:didLoadScript:withName:", ParameterType = new Type [] { typeof (PPH.PPManticoreEngine), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	public interface IPPManticorePluginDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PPManticorePluginDelegate_Extensions {
		[CompilerGenerated]
		public static void WillLoadPolyfill (this IPPManticorePluginDelegate This, PPManticoreEngine engine)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("willLoadPolyfill:"), engine.Handle);
		}
		
		[CompilerGenerated]
		public static void DidLoadPolyfill (this IPPManticorePluginDelegate This, PPManticoreEngine engine)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("didLoadPolyfill:"), engine.Handle);
		}
		
		[CompilerGenerated]
		public static void WillLoadScriptEngine (this IPPManticorePluginDelegate This, PPManticoreEngine engine, string script, string name)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			if (script == null)
				throw new ArgumentNullException ("script");
			var nsscript = NSString.CreateNative (script);
			var nsname = NSString.CreateNative (name);
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("engine:willLoadScript:withName:"), engine.Handle, nsscript, nsname);
			NSString.ReleaseNative (nsscript);
			NSString.ReleaseNative (nsname);
			
		}
		
		[CompilerGenerated]
		public static void DidLoadWithScriptEngine (this IPPManticorePluginDelegate This, PPManticoreEngine engine, string script, string name)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			if (script == null)
				throw new ArgumentNullException ("script");
			var nsscript = NSString.CreateNative (script);
			var nsname = NSString.CreateNative (name);
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("engine:didLoadScript:withName:"), engine.Handle, nsscript, nsname);
			NSString.ReleaseNative (nsscript);
			NSString.ReleaseNative (nsname);
			
		}
		
	}
	
	internal sealed class PPManticorePluginDelegateWrapper : BaseWrapper, IPPManticorePluginDelegate {
		[Preserve (Conditional = true)]
		public PPManticorePluginDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PPH {
	[Protocol()]
	[Register("PPManticorePluginDelegate", false)]
	[Model]
	public unsafe partial class PPManticorePluginDelegate : NSObject, IPPManticorePluginDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PPManticorePluginDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PPManticorePluginDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PPManticorePluginDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("didLoadPolyfill:")]
		[CompilerGenerated]
		public virtual void DidLoadPolyfill (PPManticoreEngine engine)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("engine:didLoadScript:withName:")]
		[CompilerGenerated]
		public virtual void DidLoadWithScriptEngine (PPManticoreEngine engine, string script, string name)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("willLoadPolyfill:")]
		[CompilerGenerated]
		public virtual void WillLoadPolyfill (PPManticoreEngine engine)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("engine:willLoadScript:withName:")]
		[CompilerGenerated]
		public virtual void WillLoadScriptEngine (PPManticoreEngine engine, string script, string name)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PPManticorePluginDelegate */
}
