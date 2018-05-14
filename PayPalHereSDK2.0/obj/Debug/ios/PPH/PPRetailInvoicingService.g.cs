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
	[Register("PPRetailInvoicingService", true)]
	public unsafe partial class PPRetailInvoicingService : PPRetailObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PPRetailInvoicingService");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PPRetailInvoicingService () : base (NSObjectFlag.Empty)
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
		protected PPRetailInvoicingService (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PPRetailInvoicingService (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("getAccountSummary:")]
		[CompilerGenerated]
		public unsafe static void GetAccountSummary ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailInvoicingServiceGetAccountSummaryHandler))]PPRetailInvoicingServiceGetAccountSummaryHandler completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDPPRetailInvoicingServiceGetAccountSummaryHandler.Handler, completionHandler);
			}
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("getAccountSummary:"), (IntPtr) block_ptr_completionHandler);
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("getInvoice:completionHandler:")]
		[CompilerGenerated]
		public unsafe static void GetInvoice (string invoiceID, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailInvoicingServiceGetInvoiceHandler))]PPRetailInvoicingServiceGetInvoiceHandler completionHandler)
		{
			var nsinvoiceID = NSString.CreateNative (invoiceID);
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDPPRetailInvoicingServiceGetInvoiceHandler.Handler, completionHandler);
			}
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("getInvoice:completionHandler:"), nsinvoiceID, (IntPtr) block_ptr_completionHandler);
			NSString.ReleaseNative (nsinvoiceID);
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("getInvoices:completionHandler:")]
		[CompilerGenerated]
		public unsafe static void GetInvoices (PPRetailInvoiceListRequest @params, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailInvoicingServiceGetInvoicesHandler))]PPRetailInvoicingServiceGetInvoicesHandler completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDPPRetailInvoicingServiceGetInvoicesHandler.Handler, completionHandler);
			}
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("getInvoices:completionHandler:"), @params == null ? IntPtr.Zero : @params.Handle, (IntPtr) block_ptr_completionHandler);
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("getNextInvoiceNumber:")]
		[CompilerGenerated]
		public unsafe static void GetNextInvoiceNumber ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailInvoicingServiceGetNextInvoiceNumberHandler))]PPRetailInvoicingServiceGetNextInvoiceNumberHandler completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDPPRetailInvoicingServiceGetNextInvoiceNumberHandler.Handler, completionHandler);
			}
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("getNextInvoiceNumber:"), (IntPtr) block_ptr_completionHandler);
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("getTemplates:")]
		[CompilerGenerated]
		public unsafe static void GetTemplates ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailInvoicingServiceGetTemplatesHandler))]PPRetailInvoicingServiceGetTemplatesHandler completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDPPRetailInvoicingServiceGetTemplatesHandler.Handler, completionHandler);
			}
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("getTemplates:"), (IntPtr) block_ptr_completionHandler);
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("searchInvoices:completionHandler:")]
		[CompilerGenerated]
		public unsafe static void SearchInvoices (PPRetailInvoiceSearchRequest @params, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailInvoicingServiceSearchInvoicesHandler))]PPRetailInvoicingServiceSearchInvoicesHandler completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDPPRetailInvoicingServiceSearchInvoicesHandler.Handler, completionHandler);
			}
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("searchInvoices:completionHandler:"), @params == null ? IntPtr.Zero : @params.Handle, (IntPtr) block_ptr_completionHandler);
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("uploadFile:contentType:completionHandler:")]
		[CompilerGenerated]
		public unsafe static void UploadFile (string fileHandle, string contentType, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPPRetailInvoicingServiceUploadFileHandler))]PPRetailInvoicingServiceUploadFileHandler completionHandler)
		{
			var nsfileHandle = NSString.CreateNative (fileHandle);
			var nscontentType = NSString.CreateNative (contentType);
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDPPRetailInvoicingServiceUploadFileHandler.Handler, completionHandler);
			}
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("uploadFile:contentType:completionHandler:"), nsfileHandle, nscontentType, (IntPtr) block_ptr_completionHandler);
			NSString.ReleaseNative (nsfileHandle);
			NSString.ReleaseNative (nscontentType);
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
	} /* class PPRetailInvoicingService */
}
