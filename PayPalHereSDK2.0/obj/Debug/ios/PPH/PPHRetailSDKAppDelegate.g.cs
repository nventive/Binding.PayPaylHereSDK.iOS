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
	[Protocol (Name = "PPHRetailSDKAppDelegate", WrapperType = typeof (PPHRetailSDKAppDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CurrentNavigationController", Selector = "getCurrentNavigationController", ReturnType = typeof (UINavigationController))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReaderConnectionViewDismissed", Selector = "readerConnectionViewDismissed")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LastActiveReaderConnected", Selector = "lastActiveReaderConnected")]
	public interface IPPHRetailSDKAppDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("getCurrentNavigationController")]
		[Preserve (Conditional = true)]
		global::UIKit.UINavigationController CurrentNavigationController ();
		
	}
	
	public static partial class PPHRetailSDKAppDelegate_Extensions {
		[CompilerGenerated]
		public static void ReaderConnectionViewDismissed (this IPPHRetailSDKAppDelegate This)
		{
			global::ApiDefinitions.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("readerConnectionViewDismissed"));
		}
		
		[CompilerGenerated]
		public static void LastActiveReaderConnected (this IPPHRetailSDKAppDelegate This)
		{
			global::ApiDefinitions.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("lastActiveReaderConnected"));
		}
		
	}
	
	internal sealed class PPHRetailSDKAppDelegateWrapper : BaseWrapper, IPPHRetailSDKAppDelegate {
		[Preserve (Conditional = true)]
		public PPHRetailSDKAppDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("getCurrentNavigationController")]
		[CompilerGenerated]
		public global::UIKit.UINavigationController CurrentNavigationController ()
		{
			return  Runtime.GetNSObject<global::UIKit.UINavigationController> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getCurrentNavigationController")));
		}
		
	}
}
namespace PPH {
	[Protocol()]
	[Register("PPHRetailSDKAppDelegate", false)]
	[Model]
	public unsafe abstract partial class PPHRetailSDKAppDelegate : NSObject, IPPHRetailSDKAppDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PPHRetailSDKAppDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PPHRetailSDKAppDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PPHRetailSDKAppDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("getCurrentNavigationController")]
		[CompilerGenerated]
		public abstract global::UIKit.UINavigationController CurrentNavigationController ();
		[Export ("lastActiveReaderConnected")]
		[CompilerGenerated]
		public virtual void LastActiveReaderConnected ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("readerConnectionViewDismissed")]
		[CompilerGenerated]
		public virtual void ReaderConnectionViewDismissed ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PPHRetailSDKAppDelegate */
}
