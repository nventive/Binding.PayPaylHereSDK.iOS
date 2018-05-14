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

namespace ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailAuthorizedTransactionCaptureCompleteHandler))]
		internal delegate void DPPRetailAuthorizedTransactionCaptureCompleteHandler (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailAuthorizedTransactionCaptureCompleteHandler {
			static internal readonly DPPRetailAuthorizedTransactionCaptureCompleteHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailAuthorizedTransactionCaptureCompleteHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailAuthorizedTransactionCaptureCompleteHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0), NSString.FromHandle (arg1));
			}
		} /* class SDPPRetailAuthorizedTransactionCaptureCompleteHandler */
		
		internal class NIDPPRetailAuthorizedTransactionCaptureCompleteHandler {
			IntPtr blockPtr;
			DPPRetailAuthorizedTransactionCaptureCompleteHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailAuthorizedTransactionCaptureCompleteHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailAuthorizedTransactionCaptureCompleteHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailAuthorizedTransactionCaptureCompleteHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailAuthorizedTransactionCaptureCompleteHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailAuthorizedTransactionCaptureCompleteHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailAuthorizedTransactionCaptureCompleteHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0, string arg1)
			{
				var nsarg1 = NSString.CreateNative (arg1);
				
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, nsarg1);
				NSString.ReleaseNative (nsarg1);
				
			}
		} /* class NIDPPRetailAuthorizedTransactionCaptureCompleteHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailAuthorizedTransactionVoidCompleteHandler))]
		internal delegate void DPPRetailAuthorizedTransactionVoidCompleteHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailAuthorizedTransactionVoidCompleteHandler {
			static internal readonly DPPRetailAuthorizedTransactionVoidCompleteHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailAuthorizedTransactionVoidCompleteHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailAuthorizedTransactionVoidCompleteHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0));
			}
		} /* class SDPPRetailAuthorizedTransactionVoidCompleteHandler */
		
		internal class NIDPPRetailAuthorizedTransactionVoidCompleteHandler {
			IntPtr blockPtr;
			DPPRetailAuthorizedTransactionVoidCompleteHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailAuthorizedTransactionVoidCompleteHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailAuthorizedTransactionVoidCompleteHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailAuthorizedTransactionVoidCompleteHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailAuthorizedTransactionVoidCompleteHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailAuthorizedTransactionVoidCompleteHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailAuthorizedTransactionVoidCompleteHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailAuthorizedTransactionVoidCompleteHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailBatteryStatusUpdateEvent))]
		internal delegate void DPPRetailBatteryStatusUpdateEvent (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailBatteryStatusUpdateEvent {
			static internal readonly DPPRetailBatteryStatusUpdateEvent Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailBatteryStatusUpdateEvent))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailBatteryStatusUpdateEvent) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailBatteryInfo> (arg0));
			}
		} /* class SDPPRetailBatteryStatusUpdateEvent */
		
		internal class NIDPPRetailBatteryStatusUpdateEvent {
			IntPtr blockPtr;
			DPPRetailBatteryStatusUpdateEvent invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailBatteryStatusUpdateEvent (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailBatteryStatusUpdateEvent> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailBatteryStatusUpdateEvent ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailBatteryStatusUpdateEvent Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailBatteryStatusUpdateEvent;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailBatteryStatusUpdateEvent ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailBatteryInfo arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailBatteryStatusUpdateEvent */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailCancelledEvent))]
		internal delegate void DPPRetailCancelledEvent (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailCancelledEvent {
			static internal readonly DPPRetailCancelledEvent Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailCancelledEvent))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailCancelledEvent) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDPPRetailCancelledEvent */
		
		internal class NIDPPRetailCancelledEvent {
			IntPtr blockPtr;
			DPPRetailCancelledEvent invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailCancelledEvent (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailCancelledEvent> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailCancelledEvent ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailCancelledEvent Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailCancelledEvent;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailCancelledEvent ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDPPRetailCancelledEvent */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailCardPresentedEvent))]
		internal delegate void DPPRetailCardPresentedEvent (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailCardPresentedEvent {
			static internal readonly DPPRetailCardPresentedEvent Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailCardPresentedEvent))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailCardPresentedEvent) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailCard> (arg0));
			}
		} /* class SDPPRetailCardPresentedEvent */
		
		internal class NIDPPRetailCardPresentedEvent {
			IntPtr blockPtr;
			DPPRetailCardPresentedEvent invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailCardPresentedEvent (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailCardPresentedEvent> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailCardPresentedEvent ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailCardPresentedEvent Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailCardPresentedEvent;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailCardPresentedEvent ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailCard arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailCardPresentedEvent */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailCardRemovedEvent))]
		internal delegate void DPPRetailCardRemovedEvent (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailCardRemovedEvent {
			static internal readonly DPPRetailCardRemovedEvent Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailCardRemovedEvent))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailCardRemovedEvent) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDPPRetailCardRemovedEvent */
		
		internal class NIDPPRetailCardRemovedEvent {
			IntPtr blockPtr;
			DPPRetailCardRemovedEvent invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailCardRemovedEvent (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailCardRemovedEvent> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailCardRemovedEvent ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailCardRemovedEvent Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailCardRemovedEvent;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailCardRemovedEvent ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDPPRetailCardRemovedEvent */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailConnectedEvent))]
		internal delegate void DPPRetailConnectedEvent (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailConnectedEvent {
			static internal readonly DPPRetailConnectedEvent Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailConnectedEvent))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailConnectedEvent) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDPPRetailConnectedEvent */
		
		internal class NIDPPRetailConnectedEvent {
			IntPtr blockPtr;
			DPPRetailConnectedEvent invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailConnectedEvent (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailConnectedEvent> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailConnectedEvent ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailConnectedEvent Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailConnectedEvent;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailConnectedEvent ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDPPRetailConnectedEvent */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailConnectionErrorEvent))]
		internal delegate void DPPRetailConnectionErrorEvent (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailConnectionErrorEvent {
			static internal readonly DPPRetailConnectionErrorEvent Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailConnectionErrorEvent))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailConnectionErrorEvent) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0));
			}
		} /* class SDPPRetailConnectionErrorEvent */
		
		internal class NIDPPRetailConnectionErrorEvent {
			IntPtr blockPtr;
			DPPRetailConnectionErrorEvent invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailConnectionErrorEvent (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailConnectionErrorEvent> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailConnectionErrorEvent ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailConnectionErrorEvent Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailConnectionErrorEvent;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailConnectionErrorEvent ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailConnectionErrorEvent */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailContactlessReaderDeactivatedEvent))]
		internal delegate void DPPRetailContactlessReaderDeactivatedEvent (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailContactlessReaderDeactivatedEvent {
			static internal readonly DPPRetailContactlessReaderDeactivatedEvent Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailContactlessReaderDeactivatedEvent))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailContactlessReaderDeactivatedEvent) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDPPRetailContactlessReaderDeactivatedEvent */
		
		internal class NIDPPRetailContactlessReaderDeactivatedEvent {
			IntPtr blockPtr;
			DPPRetailContactlessReaderDeactivatedEvent invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailContactlessReaderDeactivatedEvent (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailContactlessReaderDeactivatedEvent> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailContactlessReaderDeactivatedEvent ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailContactlessReaderDeactivatedEvent Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailContactlessReaderDeactivatedEvent;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailContactlessReaderDeactivatedEvent ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDPPRetailContactlessReaderDeactivatedEvent */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailDeviceDiscoveredEvent))]
		internal delegate void DPPRetailDeviceDiscoveredEvent (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailDeviceDiscoveredEvent {
			static internal readonly DPPRetailDeviceDiscoveredEvent Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailDeviceDiscoveredEvent))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailDeviceDiscoveredEvent) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailPaymentDevice> (arg0));
			}
		} /* class SDPPRetailDeviceDiscoveredEvent */
		
		internal class NIDPPRetailDeviceDiscoveredEvent {
			IntPtr blockPtr;
			DPPRetailDeviceDiscoveredEvent invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailDeviceDiscoveredEvent (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailDeviceDiscoveredEvent> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailDeviceDiscoveredEvent ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailDeviceDiscoveredEvent Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailDeviceDiscoveredEvent;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailDeviceDiscoveredEvent ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailPaymentDevice arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailDeviceDiscoveredEvent */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailDeviceManagerConnectionHandler))]
		internal delegate void DPPRetailDeviceManagerConnectionHandler (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailDeviceManagerConnectionHandler {
			static internal readonly DPPRetailDeviceManagerConnectionHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailDeviceManagerConnectionHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailDeviceManagerConnectionHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0),  Runtime.GetNSObject<PPH.PPRetailPaymentDevice> (arg1));
			}
		} /* class SDPPRetailDeviceManagerConnectionHandler */
		
		internal class NIDPPRetailDeviceManagerConnectionHandler {
			IntPtr blockPtr;
			DPPRetailDeviceManagerConnectionHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailDeviceManagerConnectionHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailDeviceManagerConnectionHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailDeviceManagerConnectionHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailDeviceManagerConnectionHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailDeviceManagerConnectionHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailDeviceManagerConnectionHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0, global::PPH.PPRetailPaymentDevice arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDPPRetailDeviceManagerConnectionHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailDeviceUpdateCompletedHandler))]
		internal delegate void DPPRetailDeviceUpdateCompletedHandler (IntPtr block, IntPtr arg0, bool arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailDeviceUpdateCompletedHandler {
			static internal readonly DPPRetailDeviceUpdateCompletedHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailDeviceUpdateCompletedHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, bool arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailDeviceUpdateCompletedHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0), arg1);
			}
		} /* class SDPPRetailDeviceUpdateCompletedHandler */
		
		internal class NIDPPRetailDeviceUpdateCompletedHandler {
			IntPtr blockPtr;
			DPPRetailDeviceUpdateCompletedHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailDeviceUpdateCompletedHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailDeviceUpdateCompletedHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailDeviceUpdateCompletedHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailDeviceUpdateCompletedHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailDeviceUpdateCompletedHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailDeviceUpdateCompletedHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0, bool arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1);
			}
		} /* class NIDPPRetailDeviceUpdateCompletedHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailDidCompleteSignatureEvent))]
		internal delegate void DPPRetailDidCompleteSignatureEvent (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailDidCompleteSignatureEvent {
			static internal readonly DPPRetailDidCompleteSignatureEvent Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailDidCompleteSignatureEvent))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailDidCompleteSignatureEvent) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0));
			}
		} /* class SDPPRetailDidCompleteSignatureEvent */
		
		internal class NIDPPRetailDidCompleteSignatureEvent {
			IntPtr blockPtr;
			DPPRetailDidCompleteSignatureEvent invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailDidCompleteSignatureEvent (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailDidCompleteSignatureEvent> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailDidCompleteSignatureEvent ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailDidCompleteSignatureEvent Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailDidCompleteSignatureEvent;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailDidCompleteSignatureEvent ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailDidCompleteSignatureEvent */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailDisconnectedEvent))]
		internal delegate void DPPRetailDisconnectedEvent (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailDisconnectedEvent {
			static internal readonly DPPRetailDisconnectedEvent Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailDisconnectedEvent))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailDisconnectedEvent) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0));
			}
		} /* class SDPPRetailDisconnectedEvent */
		
		internal class NIDPPRetailDisconnectedEvent {
			IntPtr blockPtr;
			DPPRetailDisconnectedEvent invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailDisconnectedEvent (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailDisconnectedEvent> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailDisconnectedEvent ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailDisconnectedEvent Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailDisconnectedEvent;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailDisconnectedEvent ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailDisconnectedEvent */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailInvoiceCancelledHandler))]
		internal delegate void DPPRetailInvoiceCancelledHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailInvoiceCancelledHandler {
			static internal readonly DPPRetailInvoiceCancelledHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailInvoiceCancelledHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailInvoiceCancelledHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0));
			}
		} /* class SDPPRetailInvoiceCancelledHandler */
		
		internal class NIDPPRetailInvoiceCancelledHandler {
			IntPtr blockPtr;
			DPPRetailInvoiceCancelledHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailInvoiceCancelledHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailInvoiceCancelledHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailInvoiceCancelledHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailInvoiceCancelledHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailInvoiceCancelledHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailInvoiceCancelledHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailInvoiceCancelledHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailInvoiceDeletedHandler))]
		internal delegate void DPPRetailInvoiceDeletedHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailInvoiceDeletedHandler {
			static internal readonly DPPRetailInvoiceDeletedHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailInvoiceDeletedHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailInvoiceDeletedHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0));
			}
		} /* class SDPPRetailInvoiceDeletedHandler */
		
		internal class NIDPPRetailInvoiceDeletedHandler {
			IntPtr blockPtr;
			DPPRetailInvoiceDeletedHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailInvoiceDeletedHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailInvoiceDeletedHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailInvoiceDeletedHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailInvoiceDeletedHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailInvoiceDeletedHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailInvoiceDeletedHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailInvoiceDeletedHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailInvoiceGotDetailsHandler))]
		internal delegate void DPPRetailInvoiceGotDetailsHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailInvoiceGotDetailsHandler {
			static internal readonly DPPRetailInvoiceGotDetailsHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailInvoiceGotDetailsHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailInvoiceGotDetailsHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0));
			}
		} /* class SDPPRetailInvoiceGotDetailsHandler */
		
		internal class NIDPPRetailInvoiceGotDetailsHandler {
			IntPtr blockPtr;
			DPPRetailInvoiceGotDetailsHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailInvoiceGotDetailsHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailInvoiceGotDetailsHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailInvoiceGotDetailsHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailInvoiceGotDetailsHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailInvoiceGotDetailsHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailInvoiceGotDetailsHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailInvoiceGotDetailsHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailInvoicePaidHandler))]
		internal delegate void DPPRetailInvoicePaidHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailInvoicePaidHandler {
			static internal readonly DPPRetailInvoicePaidHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailInvoicePaidHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailInvoicePaidHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0));
			}
		} /* class SDPPRetailInvoicePaidHandler */
		
		internal class NIDPPRetailInvoicePaidHandler {
			IntPtr blockPtr;
			DPPRetailInvoicePaidHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailInvoicePaidHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailInvoicePaidHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailInvoicePaidHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailInvoicePaidHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailInvoicePaidHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailInvoicePaidHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailInvoicePaidHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailInvoiceRemindedHandler))]
		internal delegate void DPPRetailInvoiceRemindedHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailInvoiceRemindedHandler {
			static internal readonly DPPRetailInvoiceRemindedHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailInvoiceRemindedHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailInvoiceRemindedHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0));
			}
		} /* class SDPPRetailInvoiceRemindedHandler */
		
		internal class NIDPPRetailInvoiceRemindedHandler {
			IntPtr blockPtr;
			DPPRetailInvoiceRemindedHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailInvoiceRemindedHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailInvoiceRemindedHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailInvoiceRemindedHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailInvoiceRemindedHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailInvoiceRemindedHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailInvoiceRemindedHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailInvoiceRemindedHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailInvoiceSavedHandler))]
		internal delegate void DPPRetailInvoiceSavedHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailInvoiceSavedHandler {
			static internal readonly DPPRetailInvoiceSavedHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailInvoiceSavedHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailInvoiceSavedHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0));
			}
		} /* class SDPPRetailInvoiceSavedHandler */
		
		internal class NIDPPRetailInvoiceSavedHandler {
			IntPtr blockPtr;
			DPPRetailInvoiceSavedHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailInvoiceSavedHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailInvoiceSavedHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailInvoiceSavedHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailInvoiceSavedHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailInvoiceSavedHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailInvoiceSavedHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailInvoiceSavedHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailInvoiceSentHandler))]
		internal delegate void DPPRetailInvoiceSentHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailInvoiceSentHandler {
			static internal readonly DPPRetailInvoiceSentHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailInvoiceSentHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailInvoiceSentHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0));
			}
		} /* class SDPPRetailInvoiceSentHandler */
		
		internal class NIDPPRetailInvoiceSentHandler {
			IntPtr blockPtr;
			DPPRetailInvoiceSentHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailInvoiceSentHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailInvoiceSentHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailInvoiceSentHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailInvoiceSentHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailInvoiceSentHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailInvoiceSentHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailInvoiceSentHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailInvoicingServiceGetAccountSummaryHandler))]
		internal delegate void DPPRetailInvoicingServiceGetAccountSummaryHandler (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailInvoicingServiceGetAccountSummaryHandler {
			static internal readonly DPPRetailInvoicingServiceGetAccountSummaryHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailInvoicingServiceGetAccountSummaryHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailInvoicingServiceGetAccountSummaryHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0),  Runtime.GetNSObject<PPH.PPRetailAccountSummary> (arg1));
			}
		} /* class SDPPRetailInvoicingServiceGetAccountSummaryHandler */
		
		internal class NIDPPRetailInvoicingServiceGetAccountSummaryHandler {
			IntPtr blockPtr;
			DPPRetailInvoicingServiceGetAccountSummaryHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailInvoicingServiceGetAccountSummaryHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailInvoicingServiceGetAccountSummaryHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailInvoicingServiceGetAccountSummaryHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailInvoicingServiceGetAccountSummaryHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailInvoicingServiceGetAccountSummaryHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailInvoicingServiceGetAccountSummaryHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0, global::PPH.PPRetailAccountSummary arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDPPRetailInvoicingServiceGetAccountSummaryHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailInvoicingServiceGetInvoiceHandler))]
		internal delegate void DPPRetailInvoicingServiceGetInvoiceHandler (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailInvoicingServiceGetInvoiceHandler {
			static internal readonly DPPRetailInvoicingServiceGetInvoiceHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailInvoicingServiceGetInvoiceHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailInvoicingServiceGetInvoiceHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0),  Runtime.GetNSObject<PPH.PPRetailInvoice> (arg1));
			}
		} /* class SDPPRetailInvoicingServiceGetInvoiceHandler */
		
		internal class NIDPPRetailInvoicingServiceGetInvoiceHandler {
			IntPtr blockPtr;
			DPPRetailInvoicingServiceGetInvoiceHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailInvoicingServiceGetInvoiceHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailInvoicingServiceGetInvoiceHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailInvoicingServiceGetInvoiceHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailInvoicingServiceGetInvoiceHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailInvoicingServiceGetInvoiceHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailInvoicingServiceGetInvoiceHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0, global::PPH.PPRetailInvoice arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDPPRetailInvoicingServiceGetInvoiceHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailInvoicingServiceGetInvoicesHandler))]
		internal delegate void DPPRetailInvoicingServiceGetInvoicesHandler (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailInvoicingServiceGetInvoicesHandler {
			static internal readonly DPPRetailInvoicingServiceGetInvoicesHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailInvoicingServiceGetInvoicesHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailInvoicingServiceGetInvoicesHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0),  Runtime.GetNSObject<PPH.PPRetailInvoiceListResponse> (arg1));
			}
		} /* class SDPPRetailInvoicingServiceGetInvoicesHandler */
		
		internal class NIDPPRetailInvoicingServiceGetInvoicesHandler {
			IntPtr blockPtr;
			DPPRetailInvoicingServiceGetInvoicesHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailInvoicingServiceGetInvoicesHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailInvoicingServiceGetInvoicesHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailInvoicingServiceGetInvoicesHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailInvoicingServiceGetInvoicesHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailInvoicingServiceGetInvoicesHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailInvoicingServiceGetInvoicesHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0, global::PPH.PPRetailInvoiceListResponse arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDPPRetailInvoicingServiceGetInvoicesHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailInvoicingServiceGetNextInvoiceNumberHandler))]
		internal delegate void DPPRetailInvoicingServiceGetNextInvoiceNumberHandler (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailInvoicingServiceGetNextInvoiceNumberHandler {
			static internal readonly DPPRetailInvoicingServiceGetNextInvoiceNumberHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailInvoicingServiceGetNextInvoiceNumberHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailInvoicingServiceGetNextInvoiceNumberHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0), NSString.FromHandle (arg1));
			}
		} /* class SDPPRetailInvoicingServiceGetNextInvoiceNumberHandler */
		
		internal class NIDPPRetailInvoicingServiceGetNextInvoiceNumberHandler {
			IntPtr blockPtr;
			DPPRetailInvoicingServiceGetNextInvoiceNumberHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailInvoicingServiceGetNextInvoiceNumberHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailInvoicingServiceGetNextInvoiceNumberHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailInvoicingServiceGetNextInvoiceNumberHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailInvoicingServiceGetNextInvoiceNumberHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailInvoicingServiceGetNextInvoiceNumberHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailInvoicingServiceGetNextInvoiceNumberHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0, string arg1)
			{
				var nsarg1 = NSString.CreateNative (arg1);
				
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, nsarg1);
				NSString.ReleaseNative (nsarg1);
				
			}
		} /* class NIDPPRetailInvoicingServiceGetNextInvoiceNumberHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailInvoicingServiceGetTemplatesHandler))]
		internal delegate void DPPRetailInvoicingServiceGetTemplatesHandler (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailInvoicingServiceGetTemplatesHandler {
			static internal readonly DPPRetailInvoicingServiceGetTemplatesHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailInvoicingServiceGetTemplatesHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailInvoicingServiceGetTemplatesHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0),  Runtime.GetNSObject<PPH.PPRetailInvoiceTemplatesResponse> (arg1));
			}
		} /* class SDPPRetailInvoicingServiceGetTemplatesHandler */
		
		internal class NIDPPRetailInvoicingServiceGetTemplatesHandler {
			IntPtr blockPtr;
			DPPRetailInvoicingServiceGetTemplatesHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailInvoicingServiceGetTemplatesHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailInvoicingServiceGetTemplatesHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailInvoicingServiceGetTemplatesHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailInvoicingServiceGetTemplatesHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailInvoicingServiceGetTemplatesHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailInvoicingServiceGetTemplatesHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0, global::PPH.PPRetailInvoiceTemplatesResponse arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDPPRetailInvoicingServiceGetTemplatesHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailInvoicingServiceSearchInvoicesHandler))]
		internal delegate void DPPRetailInvoicingServiceSearchInvoicesHandler (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailInvoicingServiceSearchInvoicesHandler {
			static internal readonly DPPRetailInvoicingServiceSearchInvoicesHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailInvoicingServiceSearchInvoicesHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailInvoicingServiceSearchInvoicesHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0),  Runtime.GetNSObject<PPH.PPRetailInvoiceListResponse> (arg1));
			}
		} /* class SDPPRetailInvoicingServiceSearchInvoicesHandler */
		
		internal class NIDPPRetailInvoicingServiceSearchInvoicesHandler {
			IntPtr blockPtr;
			DPPRetailInvoicingServiceSearchInvoicesHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailInvoicingServiceSearchInvoicesHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailInvoicingServiceSearchInvoicesHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailInvoicingServiceSearchInvoicesHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailInvoicingServiceSearchInvoicesHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailInvoicingServiceSearchInvoicesHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailInvoicingServiceSearchInvoicesHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0, global::PPH.PPRetailInvoiceListResponse arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDPPRetailInvoicingServiceSearchInvoicesHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailInvoicingServiceUploadFileHandler))]
		internal delegate void DPPRetailInvoicingServiceUploadFileHandler (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailInvoicingServiceUploadFileHandler {
			static internal readonly DPPRetailInvoicingServiceUploadFileHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailInvoicingServiceUploadFileHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailInvoicingServiceUploadFileHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0),  Runtime.GetNSObject<PPH.PPRetailInvoiceAttachment> (arg1));
			}
		} /* class SDPPRetailInvoicingServiceUploadFileHandler */
		
		internal class NIDPPRetailInvoicingServiceUploadFileHandler {
			IntPtr blockPtr;
			DPPRetailInvoicingServiceUploadFileHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailInvoicingServiceUploadFileHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailInvoicingServiceUploadFileHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailInvoicingServiceUploadFileHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailInvoicingServiceUploadFileHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailInvoicingServiceUploadFileHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailInvoicingServiceUploadFileHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0, global::PPH.PPRetailInvoiceAttachment arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDPPRetailInvoicingServiceUploadFileHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailMerchantHandler))]
		internal delegate void DPPRetailMerchantHandler (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailMerchantHandler {
			static internal readonly DPPRetailMerchantHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailMerchantHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailMerchantHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0),  Runtime.GetNSObject<PPH.PPRetailMerchant> (arg1));
			}
		} /* class SDPPRetailMerchantHandler */
		
		internal class NIDPPRetailMerchantHandler {
			IntPtr blockPtr;
			DPPRetailMerchantHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailMerchantHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailMerchantHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailMerchantHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailMerchantHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailMerchantHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailMerchantHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0, global::PPH.PPRetailMerchant arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDPPRetailMerchantHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailMerchantReceiptForwardedHandler))]
		internal delegate void DPPRetailMerchantReceiptForwardedHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailMerchantReceiptForwardedHandler {
			static internal readonly DPPRetailMerchantReceiptForwardedHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailMerchantReceiptForwardedHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailMerchantReceiptForwardedHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0));
			}
		} /* class SDPPRetailMerchantReceiptForwardedHandler */
		
		internal class NIDPPRetailMerchantReceiptForwardedHandler {
			IntPtr blockPtr;
			DPPRetailMerchantReceiptForwardedHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailMerchantReceiptForwardedHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailMerchantReceiptForwardedHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailMerchantReceiptForwardedHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailMerchantReceiptForwardedHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailMerchantReceiptForwardedHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailMerchantReceiptForwardedHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailMerchantReceiptForwardedHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailOnCardReaderDiscoveredEvent))]
		internal delegate void DPPRetailOnCardReaderDiscoveredEvent (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailOnCardReaderDiscoveredEvent {
			static internal readonly DPPRetailOnCardReaderDiscoveredEvent Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailOnCardReaderDiscoveredEvent))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailOnCardReaderDiscoveredEvent) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailDiscoveredCardReader> (arg0));
			}
		} /* class SDPPRetailOnCardReaderDiscoveredEvent */
		
		internal class NIDPPRetailOnCardReaderDiscoveredEvent {
			IntPtr blockPtr;
			DPPRetailOnCardReaderDiscoveredEvent invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailOnCardReaderDiscoveredEvent (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailOnCardReaderDiscoveredEvent> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailOnCardReaderDiscoveredEvent ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailOnCardReaderDiscoveredEvent Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailOnCardReaderDiscoveredEvent;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailOnCardReaderDiscoveredEvent ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailDiscoveredCardReader arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailOnCardReaderDiscoveredEvent */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailOnConnectionResultEvent))]
		internal delegate void DPPRetailOnConnectionResultEvent (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailOnConnectionResultEvent {
			static internal readonly DPPRetailOnConnectionResultEvent Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailOnConnectionResultEvent))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailOnConnectionResultEvent) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0),  Runtime.GetNSObject<PPH.PPRetailPaymentDevice> (arg1));
			}
		} /* class SDPPRetailOnConnectionResultEvent */
		
		internal class NIDPPRetailOnConnectionResultEvent {
			IntPtr blockPtr;
			DPPRetailOnConnectionResultEvent invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailOnConnectionResultEvent (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailOnConnectionResultEvent> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailOnConnectionResultEvent ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailOnConnectionResultEvent Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailOnConnectionResultEvent;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailOnConnectionResultEvent ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0, global::PPH.PPRetailPaymentDevice arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDPPRetailOnConnectionResultEvent */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailOnConnectionStatusEvent))]
		internal delegate void DPPRetailOnConnectionStatusEvent (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailOnConnectionStatusEvent {
			static internal readonly DPPRetailOnConnectionStatusEvent Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailOnConnectionStatusEvent))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailOnConnectionStatusEvent) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0),  Runtime.GetNSObject<PPH.PPRetailDiscoveredCardReader> (arg1));
			}
		} /* class SDPPRetailOnConnectionStatusEvent */
		
		internal class NIDPPRetailOnConnectionStatusEvent {
			IntPtr blockPtr;
			DPPRetailOnConnectionStatusEvent invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailOnConnectionStatusEvent (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailOnConnectionStatusEvent> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailOnConnectionStatusEvent ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailOnConnectionStatusEvent Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailOnConnectionStatusEvent;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailOnConnectionStatusEvent ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0, global::PPH.PPRetailDiscoveredCardReader arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDPPRetailOnConnectionStatusEvent */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailOnScanCompleteEvent))]
		internal delegate void DPPRetailOnScanCompleteEvent (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailOnScanCompleteEvent {
			static internal readonly DPPRetailOnScanCompleteEvent Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailOnScanCompleteEvent))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailOnScanCompleteEvent) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0));
			}
		} /* class SDPPRetailOnScanCompleteEvent */
		
		internal class NIDPPRetailOnScanCompleteEvent {
			IntPtr blockPtr;
			DPPRetailOnScanCompleteEvent invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailOnScanCompleteEvent (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailOnScanCompleteEvent> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailOnScanCompleteEvent ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailOnScanCompleteEvent Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailOnScanCompleteEvent;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailOnScanCompleteEvent ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailOnScanCompleteEvent */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailPageViewedEvent))]
		internal delegate void DPPRetailPageViewedEvent (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailPageViewedEvent {
			static internal readonly DPPRetailPageViewedEvent Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailPageViewedEvent))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailPageViewedEvent) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0),  Runtime.GetNSObject<PPH.PPRetailPage> (arg1));
			}
		} /* class SDPPRetailPageViewedEvent */
		
		internal class NIDPPRetailPageViewedEvent {
			IntPtr blockPtr;
			DPPRetailPageViewedEvent invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailPageViewedEvent (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailPageViewedEvent> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailPageViewedEvent ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailPageViewedEvent Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailPageViewedEvent;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailPageViewedEvent ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0, global::PPH.PPRetailPage arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDPPRetailPageViewedEvent */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailPaymentDeviceBatteryInfoHandler))]
		internal delegate void DPPRetailPaymentDeviceBatteryInfoHandler (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailPaymentDeviceBatteryInfoHandler {
			static internal readonly DPPRetailPaymentDeviceBatteryInfoHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailPaymentDeviceBatteryInfoHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailPaymentDeviceBatteryInfoHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0),  Runtime.GetNSObject<PPH.PPRetailBatteryInfo> (arg1));
			}
		} /* class SDPPRetailPaymentDeviceBatteryInfoHandler */
		
		internal class NIDPPRetailPaymentDeviceBatteryInfoHandler {
			IntPtr blockPtr;
			DPPRetailPaymentDeviceBatteryInfoHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailPaymentDeviceBatteryInfoHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailPaymentDeviceBatteryInfoHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailPaymentDeviceBatteryInfoHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailPaymentDeviceBatteryInfoHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailPaymentDeviceBatteryInfoHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailPaymentDeviceBatteryInfoHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0, global::PPH.PPRetailBatteryInfo arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDPPRetailPaymentDeviceBatteryInfoHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailPaymentDeviceConnectHandler))]
		internal delegate void DPPRetailPaymentDeviceConnectHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailPaymentDeviceConnectHandler {
			static internal readonly DPPRetailPaymentDeviceConnectHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailPaymentDeviceConnectHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailPaymentDeviceConnectHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0));
			}
		} /* class SDPPRetailPaymentDeviceConnectHandler */
		
		internal class NIDPPRetailPaymentDeviceConnectHandler {
			IntPtr blockPtr;
			DPPRetailPaymentDeviceConnectHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailPaymentDeviceConnectHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailPaymentDeviceConnectHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailPaymentDeviceConnectHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailPaymentDeviceConnectHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailPaymentDeviceConnectHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailPaymentDeviceConnectHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailPaymentDeviceConnectHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailPaymentDeviceDeviceLogsHandler))]
		internal delegate void DPPRetailPaymentDeviceDeviceLogsHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailPaymentDeviceDeviceLogsHandler {
			static internal readonly DPPRetailPaymentDeviceDeviceLogsHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailPaymentDeviceDeviceLogsHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailPaymentDeviceDeviceLogsHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0));
			}
		} /* class SDPPRetailPaymentDeviceDeviceLogsHandler */
		
		internal class NIDPPRetailPaymentDeviceDeviceLogsHandler {
			IntPtr blockPtr;
			DPPRetailPaymentDeviceDeviceLogsHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailPaymentDeviceDeviceLogsHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailPaymentDeviceDeviceLogsHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailPaymentDeviceDeviceLogsHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailPaymentDeviceDeviceLogsHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailPaymentDeviceDeviceLogsHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailPaymentDeviceDeviceLogsHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailPaymentDeviceDeviceLogsHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailPaymentDeviceDisconnectHandler))]
		internal delegate void DPPRetailPaymentDeviceDisconnectHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailPaymentDeviceDisconnectHandler {
			static internal readonly DPPRetailPaymentDeviceDisconnectHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailPaymentDeviceDisconnectHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailPaymentDeviceDisconnectHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0));
			}
		} /* class SDPPRetailPaymentDeviceDisconnectHandler */
		
		internal class NIDPPRetailPaymentDeviceDisconnectHandler {
			IntPtr blockPtr;
			DPPRetailPaymentDeviceDisconnectHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailPaymentDeviceDisconnectHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailPaymentDeviceDisconnectHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailPaymentDeviceDisconnectHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailPaymentDeviceDisconnectHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailPaymentDeviceDisconnectHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailPaymentDeviceDisconnectHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailPaymentDeviceDisconnectHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailPinEntryEvent))]
		internal delegate void DPPRetailPinEntryEvent (IntPtr block, bool arg0, bool arg1, int arg2, bool arg3);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailPinEntryEvent {
			static internal readonly DPPRetailPinEntryEvent Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailPinEntryEvent))]
			static unsafe void Invoke (IntPtr block, bool arg0, bool arg1, int arg2, bool arg3) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailPinEntryEvent) (descriptor->Target);
				if (del != null)
					del (arg0, arg1, arg2, arg3);
			}
		} /* class SDPPRetailPinEntryEvent */
		
		internal class NIDPPRetailPinEntryEvent {
			IntPtr blockPtr;
			DPPRetailPinEntryEvent invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailPinEntryEvent (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailPinEntryEvent> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailPinEntryEvent ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailPinEntryEvent Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailPinEntryEvent;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailPinEntryEvent ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (bool arg0, bool arg1, int arg2, bool arg3)
			{
				invoker (blockPtr, arg0, arg1, arg2, arg3);
			}
		} /* class NIDPPRetailPinEntryEvent */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailReaderTippingCompletedEvent))]
		internal delegate void DPPRetailReaderTippingCompletedEvent (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailReaderTippingCompletedEvent {
			static internal readonly DPPRetailReaderTippingCompletedEvent Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailReaderTippingCompletedEvent))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailReaderTippingCompletedEvent) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSDecimalNumber> (arg0));
			}
		} /* class SDPPRetailReaderTippingCompletedEvent */
		
		internal class NIDPPRetailReaderTippingCompletedEvent {
			IntPtr blockPtr;
			DPPRetailReaderTippingCompletedEvent invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailReaderTippingCompletedEvent (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailReaderTippingCompletedEvent> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailReaderTippingCompletedEvent ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailReaderTippingCompletedEvent Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailReaderTippingCompletedEvent;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailReaderTippingCompletedEvent ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSDecimalNumber arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailReaderTippingCompletedEvent */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailReconnectReaderEvent))]
		internal delegate void DPPRetailReconnectReaderEvent (IntPtr block, int arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailReconnectReaderEvent {
			static internal readonly DPPRetailReconnectReaderEvent Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailReconnectReaderEvent))]
			static unsafe void Invoke (IntPtr block, int arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailReconnectReaderEvent) (descriptor->Target);
				if (del != null)
					del (arg0);
			}
		} /* class SDPPRetailReconnectReaderEvent */
		
		internal class NIDPPRetailReconnectReaderEvent {
			IntPtr blockPtr;
			DPPRetailReconnectReaderEvent invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailReconnectReaderEvent (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailReconnectReaderEvent> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailReconnectReaderEvent ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailReconnectReaderEvent Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailReconnectReaderEvent;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailReconnectReaderEvent ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (int arg0)
			{
				invoker (blockPtr, arg0);
			}
		} /* class NIDPPRetailReconnectReaderEvent */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailSDKInterceptHandler))]
		internal delegate void DPPRetailSDKInterceptHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailSDKInterceptHandler {
			static internal readonly DPPRetailSDKInterceptHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailSDKInterceptHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailSDKInterceptHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailNetworkRequest> (arg0));
			}
		} /* class SDPPRetailSDKInterceptHandler */
		
		internal class NIDPPRetailSDKInterceptHandler {
			IntPtr blockPtr;
			DPPRetailSDKInterceptHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailSDKInterceptHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailSDKInterceptHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailSDKInterceptHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailSDKInterceptHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailSDKInterceptHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailSDKInterceptHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailNetworkRequest arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailSDKInterceptHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailSelectedEvent))]
		internal delegate void DPPRetailSelectedEvent (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailSelectedEvent {
			static internal readonly DPPRetailSelectedEvent Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailSelectedEvent))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailSelectedEvent) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDPPRetailSelectedEvent */
		
		internal class NIDPPRetailSelectedEvent {
			IntPtr blockPtr;
			DPPRetailSelectedEvent invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailSelectedEvent (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailSelectedEvent> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailSelectedEvent ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailSelectedEvent Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailSelectedEvent;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailSelectedEvent ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDPPRetailSelectedEvent */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailTransactionContextCardInsertedHandlerHandler))]
		internal delegate void DPPRetailTransactionContextCardInsertedHandlerHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailTransactionContextCardInsertedHandlerHandler {
			static internal readonly DPPRetailTransactionContextCardInsertedHandlerHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailTransactionContextCardInsertedHandlerHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailTransactionContextCardInsertedHandlerHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailCardInsertedHandler> (arg0));
			}
		} /* class SDPPRetailTransactionContextCardInsertedHandlerHandler */
		
		internal class NIDPPRetailTransactionContextCardInsertedHandlerHandler {
			IntPtr blockPtr;
			DPPRetailTransactionContextCardInsertedHandlerHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailTransactionContextCardInsertedHandlerHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailTransactionContextCardInsertedHandlerHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailTransactionContextCardInsertedHandlerHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailTransactionContextCardInsertedHandlerHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailTransactionContextCardInsertedHandlerHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailTransactionContextCardInsertedHandlerHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailCardInsertedHandler arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailTransactionContextCardInsertedHandlerHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailTransactionContextCardPresentedHandler))]
		internal delegate void DPPRetailTransactionContextCardPresentedHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailTransactionContextCardPresentedHandler {
			static internal readonly DPPRetailTransactionContextCardPresentedHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailTransactionContextCardPresentedHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailTransactionContextCardPresentedHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailCard> (arg0));
			}
		} /* class SDPPRetailTransactionContextCardPresentedHandler */
		
		internal class NIDPPRetailTransactionContextCardPresentedHandler {
			IntPtr blockPtr;
			DPPRetailTransactionContextCardPresentedHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailTransactionContextCardPresentedHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailTransactionContextCardPresentedHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailTransactionContextCardPresentedHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailTransactionContextCardPresentedHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailTransactionContextCardPresentedHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailTransactionContextCardPresentedHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailCard arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailTransactionContextCardPresentedHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailTransactionContextCompleteHandler))]
		internal delegate void DPPRetailTransactionContextCompleteHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailTransactionContextCompleteHandler {
			static internal readonly DPPRetailTransactionContextCompleteHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailTransactionContextCompleteHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailTransactionContextCompleteHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0));
			}
		} /* class SDPPRetailTransactionContextCompleteHandler */
		
		internal class NIDPPRetailTransactionContextCompleteHandler {
			IntPtr blockPtr;
			DPPRetailTransactionContextCompleteHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailTransactionContextCompleteHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailTransactionContextCompleteHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailTransactionContextCompleteHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailTransactionContextCompleteHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailTransactionContextCompleteHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailTransactionContextCompleteHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailTransactionContextCompleteHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailTransactionContextOnAuthCompleteHandler))]
		internal delegate void DPPRetailTransactionContextOnAuthCompleteHandler (IntPtr block, IntPtr arg0, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailTransactionContextOnAuthCompleteHandler {
			static internal readonly DPPRetailTransactionContextOnAuthCompleteHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailTransactionContextOnAuthCompleteHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailTransactionContextOnAuthCompleteHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0),  Runtime.GetNSObject<PPH.PPRetailCaptureHandler> (arg1),  Runtime.GetNSObject<PPH.PPRetailTransactionRecord> (arg2));
			}
		} /* class SDPPRetailTransactionContextOnAuthCompleteHandler */
		
		internal class NIDPPRetailTransactionContextOnAuthCompleteHandler {
			IntPtr blockPtr;
			DPPRetailTransactionContextOnAuthCompleteHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailTransactionContextOnAuthCompleteHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailTransactionContextOnAuthCompleteHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailTransactionContextOnAuthCompleteHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailTransactionContextOnAuthCompleteHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailTransactionContextOnAuthCompleteHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailTransactionContextOnAuthCompleteHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0, global::PPH.PPRetailCaptureHandler arg1, global::PPH.PPRetailTransactionRecord arg2)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
			}
		} /* class NIDPPRetailTransactionContextOnAuthCompleteHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailTransactionContextReceiptOptionHandlerHandler))]
		internal delegate void DPPRetailTransactionContextReceiptOptionHandlerHandler (IntPtr block, int arg0, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailTransactionContextReceiptOptionHandlerHandler {
			static internal readonly DPPRetailTransactionContextReceiptOptionHandlerHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailTransactionContextReceiptOptionHandlerHandler))]
			static unsafe void Invoke (IntPtr block, int arg0, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailTransactionContextReceiptOptionHandlerHandler) (descriptor->Target);
				if (del != null)
					del (arg0, NSString.FromHandle (arg1),  Runtime.GetNSObject<PPH.PPRetailTransactionRecord> (arg2));
			}
		} /* class SDPPRetailTransactionContextReceiptOptionHandlerHandler */
		
		internal class NIDPPRetailTransactionContextReceiptOptionHandlerHandler {
			IntPtr blockPtr;
			DPPRetailTransactionContextReceiptOptionHandlerHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailTransactionContextReceiptOptionHandlerHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailTransactionContextReceiptOptionHandlerHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailTransactionContextReceiptOptionHandlerHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailTransactionContextReceiptOptionHandlerHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailTransactionContextReceiptOptionHandlerHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailTransactionContextReceiptOptionHandlerHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (int arg0, string arg1, global::PPH.PPRetailTransactionRecord arg2)
			{
				var nsarg1 = NSString.CreateNative (arg1);
				
				invoker (blockPtr, arg0, nsarg1, arg2 == null ? IntPtr.Zero : arg2.Handle);
				NSString.ReleaseNative (nsarg1);
				
			}
		} /* class NIDPPRetailTransactionContextReceiptOptionHandlerHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailTransactionContextSignatureCollectorHandler))]
		internal delegate void DPPRetailTransactionContextSignatureCollectorHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailTransactionContextSignatureCollectorHandler {
			static internal readonly DPPRetailTransactionContextSignatureCollectorHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailTransactionContextSignatureCollectorHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailTransactionContextSignatureCollectorHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailSignatureReceiver> (arg0));
			}
		} /* class SDPPRetailTransactionContextSignatureCollectorHandler */
		
		internal class NIDPPRetailTransactionContextSignatureCollectorHandler {
			IntPtr blockPtr;
			DPPRetailTransactionContextSignatureCollectorHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailTransactionContextSignatureCollectorHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailTransactionContextSignatureCollectorHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailTransactionContextSignatureCollectorHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailTransactionContextSignatureCollectorHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailTransactionContextSignatureCollectorHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailTransactionContextSignatureCollectorHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailSignatureReceiver arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailTransactionContextSignatureCollectorHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailTransactionContextTokenExpirationHandlerHandler))]
		internal delegate void DPPRetailTransactionContextTokenExpirationHandlerHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailTransactionContextTokenExpirationHandlerHandler {
			static internal readonly DPPRetailTransactionContextTokenExpirationHandlerHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailTransactionContextTokenExpirationHandlerHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailTransactionContextTokenExpirationHandlerHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailTokenExpirationHandler> (arg0));
			}
		} /* class SDPPRetailTransactionContextTokenExpirationHandlerHandler */
		
		internal class NIDPPRetailTransactionContextTokenExpirationHandlerHandler {
			IntPtr blockPtr;
			DPPRetailTransactionContextTokenExpirationHandlerHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailTransactionContextTokenExpirationHandlerHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailTransactionContextTokenExpirationHandlerHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailTransactionContextTokenExpirationHandlerHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailTransactionContextTokenExpirationHandlerHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailTransactionContextTokenExpirationHandlerHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailTransactionContextTokenExpirationHandlerHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailTokenExpirationHandler arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailTransactionContextTokenExpirationHandlerHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailTransactionContextTransactionCompletedHandler))]
		internal delegate void DPPRetailTransactionContextTransactionCompletedHandler (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailTransactionContextTransactionCompletedHandler {
			static internal readonly DPPRetailTransactionContextTransactionCompletedHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailTransactionContextTransactionCompletedHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailTransactionContextTransactionCompletedHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0),  Runtime.GetNSObject<PPH.PPRetailTransactionRecord> (arg1));
			}
		} /* class SDPPRetailTransactionContextTransactionCompletedHandler */
		
		internal class NIDPPRetailTransactionContextTransactionCompletedHandler {
			IntPtr blockPtr;
			DPPRetailTransactionContextTransactionCompletedHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailTransactionContextTransactionCompletedHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailTransactionContextTransactionCompletedHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailTransactionContextTransactionCompletedHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailTransactionContextTransactionCompletedHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailTransactionContextTransactionCompletedHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailTransactionContextTransactionCompletedHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0, global::PPH.PPRetailTransactionRecord arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDPPRetailTransactionContextTransactionCompletedHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailTransactionManagerCaptureAuthorizedTransactionHandler))]
		internal delegate void DPPRetailTransactionManagerCaptureAuthorizedTransactionHandler (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailTransactionManagerCaptureAuthorizedTransactionHandler {
			static internal readonly DPPRetailTransactionManagerCaptureAuthorizedTransactionHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailTransactionManagerCaptureAuthorizedTransactionHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailTransactionManagerCaptureAuthorizedTransactionHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0), NSString.FromHandle (arg1));
			}
		} /* class SDPPRetailTransactionManagerCaptureAuthorizedTransactionHandler */
		
		internal class NIDPPRetailTransactionManagerCaptureAuthorizedTransactionHandler {
			IntPtr blockPtr;
			DPPRetailTransactionManagerCaptureAuthorizedTransactionHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailTransactionManagerCaptureAuthorizedTransactionHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailTransactionManagerCaptureAuthorizedTransactionHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailTransactionManagerCaptureAuthorizedTransactionHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailTransactionManagerCaptureAuthorizedTransactionHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailTransactionManagerCaptureAuthorizedTransactionHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailTransactionManagerCaptureAuthorizedTransactionHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0, string arg1)
			{
				var nsarg1 = NSString.CreateNative (arg1);
				
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, nsarg1);
				NSString.ReleaseNative (nsarg1);
				
			}
		} /* class NIDPPRetailTransactionManagerCaptureAuthorizedTransactionHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler))]
		internal delegate void DPPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler (IntPtr block, IntPtr arg0, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler {
			static internal readonly DPPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0), NSArray.ArrayFromHandle<NSObject> (arg1), NSString.FromHandle (arg2));
			}
		} /* class SDPPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler */
		
		internal class NIDPPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler {
			IntPtr blockPtr;
			DPPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0, NSObject[] arg1, string arg2)
			{
				var nsa_arg1 = arg1 == null ? null : NSArray.FromNSObjects (arg1);
				var nsarg2 = NSString.CreateNative (arg2);
				
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, nsa_arg1 == null ? IntPtr.Zero : nsa_arg1.Handle, nsarg2);
				if (nsa_arg1 != null)
					nsa_arg1.Dispose ();
				NSString.ReleaseNative (nsarg2);
				
			}
		} /* class NIDPPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailTransactionManagerTransactionHandler))]
		internal delegate void DPPRetailTransactionManagerTransactionHandler (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailTransactionManagerTransactionHandler {
			static internal readonly DPPRetailTransactionManagerTransactionHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailTransactionManagerTransactionHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailTransactionManagerTransactionHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0),  Runtime.GetNSObject<PPH.PPRetailTransactionContext> (arg1));
			}
		} /* class SDPPRetailTransactionManagerTransactionHandler */
		
		internal class NIDPPRetailTransactionManagerTransactionHandler {
			IntPtr blockPtr;
			DPPRetailTransactionManagerTransactionHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailTransactionManagerTransactionHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailTransactionManagerTransactionHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailTransactionManagerTransactionHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailTransactionManagerTransactionHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailTransactionManagerTransactionHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailTransactionManagerTransactionHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0, global::PPH.PPRetailTransactionContext arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDPPRetailTransactionManagerTransactionHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailTransactionManagerVoidAuthorizationHandler))]
		internal delegate void DPPRetailTransactionManagerVoidAuthorizationHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailTransactionManagerVoidAuthorizationHandler {
			static internal readonly DPPRetailTransactionManagerVoidAuthorizationHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailTransactionManagerVoidAuthorizationHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailTransactionManagerVoidAuthorizationHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg0));
			}
		} /* class SDPPRetailTransactionManagerVoidAuthorizationHandler */
		
		internal class NIDPPRetailTransactionManagerVoidAuthorizationHandler {
			IntPtr blockPtr;
			DPPRetailTransactionManagerVoidAuthorizationHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailTransactionManagerVoidAuthorizationHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailTransactionManagerVoidAuthorizationHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailTransactionManagerVoidAuthorizationHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailTransactionManagerVoidAuthorizationHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailTransactionManagerVoidAuthorizationHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailTransactionManagerVoidAuthorizationHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailTransactionManagerVoidAuthorizationHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailUpdateRequiredEvent))]
		internal delegate void DPPRetailUpdateRequiredEvent (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailUpdateRequiredEvent {
			static internal readonly DPPRetailUpdateRequiredEvent Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailUpdateRequiredEvent))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailUpdateRequiredEvent) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailDeviceUpdate> (arg0));
			}
		} /* class SDPPRetailUpdateRequiredEvent */
		
		internal class NIDPPRetailUpdateRequiredEvent {
			IntPtr blockPtr;
			DPPRetailUpdateRequiredEvent invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailUpdateRequiredEvent (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailUpdateRequiredEvent> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailUpdateRequiredEvent ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailUpdateRequiredEvent Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailUpdateRequiredEvent;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailUpdateRequiredEvent ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailDeviceUpdate arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDPPRetailUpdateRequiredEvent */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::PPH.PPRetailWillPresentSignatureEvent))]
		internal delegate void DPPRetailWillPresentSignatureEvent (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPPRetailWillPresentSignatureEvent {
			static internal readonly DPPRetailWillPresentSignatureEvent Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPPRetailWillPresentSignatureEvent))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::PPH.PPRetailWillPresentSignatureEvent) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDPPRetailWillPresentSignatureEvent */
		
		internal class NIDPPRetailWillPresentSignatureEvent {
			IntPtr blockPtr;
			DPPRetailWillPresentSignatureEvent invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPPRetailWillPresentSignatureEvent (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPPRetailWillPresentSignatureEvent> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPPRetailWillPresentSignatureEvent ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::PPH.PPRetailWillPresentSignatureEvent Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::PPH.PPRetailWillPresentSignatureEvent;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPPRetailWillPresentSignatureEvent ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDPPRetailWillPresentSignatureEvent */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action))]
		internal delegate void DAction (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAction {
			static internal readonly DAction Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DAction))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDAction */
		
		internal class NIDAction {
			IntPtr blockPtr;
			DAction invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDAction (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DAction> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDAction ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDAction ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDAction */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::JavaScriptCore.JSValue, global::JavaScriptCore.JSValue>))]
		internal delegate void DActionArity2V0 (IntPtr block, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V0 {
			static internal readonly DActionArity2V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V0))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::JavaScriptCore.JSValue, global::JavaScriptCore.JSValue>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<JavaScriptCore.JSValue> (arg1),  Runtime.GetNSObject<JavaScriptCore.JSValue> (arg2));
			}
		} /* class SDActionArity2V0 */
		
		internal class NIDActionArity2V0 {
			IntPtr blockPtr;
			DActionArity2V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity2V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity2V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity2V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::JavaScriptCore.JSValue, global::JavaScriptCore.JSValue> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::JavaScriptCore.JSValue, global::JavaScriptCore.JSValue>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity2V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::JavaScriptCore.JSValue arg1, global::JavaScriptCore.JSValue arg2)
			{
				invoker (blockPtr, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
			}
		} /* class NIDActionArity2V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::PPH.PPRetailError, NSDictionary>))]
		internal delegate void DActionArity2V1 (IntPtr block, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V1 {
			static internal readonly DActionArity2V1 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V1))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::PPH.PPRetailError, NSDictionary>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PPH.PPRetailError> (arg1),  Runtime.GetNSObject<NSDictionary> (arg2));
			}
		} /* class SDActionArity2V1 */
		
		internal class NIDActionArity2V1 {
			IntPtr blockPtr;
			DActionArity2V1 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity2V1 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity2V1> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity2V1 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::PPH.PPRetailError, NSDictionary> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::PPH.PPRetailError, NSDictionary>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity2V1 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PPH.PPRetailError arg1, NSDictionary arg2)
			{
				invoker (blockPtr, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
			}
		} /* class NIDActionArity2V1 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Func<NSObject, NSObject>))]
		internal delegate IntPtr DFuncArity2V0 (IntPtr block, IntPtr arg);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDFuncArity2V0 {
			static internal readonly DFuncArity2V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DFuncArity2V0))]
			static unsafe IntPtr Invoke (IntPtr block, IntPtr arg) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Func<NSObject, NSObject>) (descriptor->Target);
				Foundation.NSObject retval = del ( Runtime.GetNSObject<NSObject> (arg));
				return retval != null ? retval.Handle : IntPtr.Zero;
			}
		} /* class SDFuncArity2V0 */
		
		internal class NIDFuncArity2V0 {
			IntPtr blockPtr;
			DFuncArity2V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDFuncArity2V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DFuncArity2V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDFuncArity2V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Func<NSObject, NSObject> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Func<NSObject, NSObject>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDFuncArity2V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe NSObject Invoke (NSObject arg)
			{
				var ret = Runtime.GetNSObject (invoker (blockPtr, arg == null ? IntPtr.Zero : arg.Handle));
				return ret;
			}
		} /* class NIDFuncArity2V0 */
	}
}
