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
	[Protocol (Name = "PPManticoreNativeObjectProtocol", WrapperType = typeof (PPManticoreNativeObjectProtocolWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "NativeClassForObject", Selector = "nativeClassForObject:", ReturnType = typeof (Class), ParameterType = new Type [] { typeof (JavaScriptCore.JSValue) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Impl", Selector = "impl", PropertyType = typeof (JavaScriptCore.JSValue), GetterSelector = "impl", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "Engine", Selector = "engine", PropertyType = typeof (PPH.PPManticoreEngine), GetterSelector = "engine", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IPPManticoreNativeObjectProtocol : INativeObject, IDisposable
	{
	}
	
	public static partial class PPManticoreNativeObjectProtocol_Extensions {
		[CompilerGenerated]
		public static global::JavaScriptCore.JSValue GetImpl (this IPPManticoreNativeObjectProtocol This)
		{
			return  Runtime.GetNSObject<global::JavaScriptCore.JSValue> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("impl")));
		}
		
	}
	
	internal sealed class PPManticoreNativeObjectProtocolWrapper : BaseWrapper, IPPManticoreNativeObjectProtocol {
		[Preserve (Conditional = true)]
		public PPManticoreNativeObjectProtocolWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PPH {
	[Protocol()]
	[Register("PPManticoreNativeObjectProtocol", false)]
	[Model]
	public unsafe partial class PPManticoreNativeObjectProtocol : NSObject, IPPManticoreNativeObjectProtocol {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PPManticoreNativeObjectProtocol () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PPManticoreNativeObjectProtocol (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PPManticoreNativeObjectProtocol (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("initFromJavascript:")]
		[CompilerGenerated]
		public PPManticoreNativeObjectProtocol (global::JavaScriptCore.JSValue value)
			: base (NSObjectFlag.Empty)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("nativeClassForObject:")]
		[CompilerGenerated]
		public static Class NativeClassForObject (global::JavaScriptCore.JSValue value)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public static PPManticoreEngine Engine {
			[Export ("engine")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::JavaScriptCore.JSValue Impl {
			[Export ("impl")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
	} /* class PPManticoreNativeObjectProtocol */
}
