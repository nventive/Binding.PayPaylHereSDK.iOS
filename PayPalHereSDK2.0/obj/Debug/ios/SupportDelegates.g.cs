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
	public delegate void PPRetailAuthorizedTransactionCaptureCompleteHandler (PPH.PPRetailError arg0, string arg1);
	public delegate void PPRetailAuthorizedTransactionVoidCompleteHandler (PPH.PPRetailError arg0);
	public delegate void PPRetailBatteryStatusUpdateEvent (PPH.PPRetailBatteryInfo arg0);
	public delegate void PPRetailCancelledEvent ();
	public delegate void PPRetailCardPresentedEvent (PPH.PPRetailCard arg0);
	public delegate void PPRetailCardRemovedEvent ();
	public delegate void PPRetailConnectedEvent ();
	public delegate void PPRetailConnectionErrorEvent (PPH.PPRetailError arg0);
	public delegate void PPRetailContactlessReaderDeactivatedEvent ();
	public delegate void PPRetailDeviceDiscoveredEvent (PPH.PPRetailPaymentDevice arg0);
	public delegate void PPRetailDeviceManagerConnectionHandler (PPH.PPRetailError arg0, PPH.PPRetailPaymentDevice arg1);
	public delegate void PPRetailDeviceUpdateCompletedHandler (PPH.PPRetailError arg0, bool arg1);
	public delegate void PPRetailDidCompleteSignatureEvent (PPH.PPRetailError arg0);
	public delegate void PPRetailDisconnectedEvent (PPH.PPRetailError arg0);
	public delegate void PPRetailInvoiceCancelledHandler (PPH.PPRetailError arg0);
	public delegate void PPRetailInvoiceDeletedHandler (PPH.PPRetailError arg0);
	public delegate void PPRetailInvoiceGotDetailsHandler (PPH.PPRetailError arg0);
	public delegate void PPRetailInvoicePaidHandler (PPH.PPRetailError arg0);
	public delegate void PPRetailInvoiceRemindedHandler (PPH.PPRetailError arg0);
	public delegate void PPRetailInvoiceSavedHandler (PPH.PPRetailError arg0);
	public delegate void PPRetailInvoiceSentHandler (PPH.PPRetailError arg0);
	public delegate void PPRetailInvoicingServiceGetAccountSummaryHandler (PPH.PPRetailError arg0, PPH.PPRetailAccountSummary arg1);
	public delegate void PPRetailInvoicingServiceGetInvoiceHandler (PPH.PPRetailError arg0, PPH.PPRetailInvoice arg1);
	public delegate void PPRetailInvoicingServiceGetInvoicesHandler (PPH.PPRetailError arg0, PPH.PPRetailInvoiceListResponse arg1);
	public delegate void PPRetailInvoicingServiceGetNextInvoiceNumberHandler (PPH.PPRetailError arg0, string arg1);
	public delegate void PPRetailInvoicingServiceGetTemplatesHandler (PPH.PPRetailError arg0, PPH.PPRetailInvoiceTemplatesResponse arg1);
	public delegate void PPRetailInvoicingServiceSearchInvoicesHandler (PPH.PPRetailError arg0, PPH.PPRetailInvoiceListResponse arg1);
	public delegate void PPRetailInvoicingServiceUploadFileHandler (PPH.PPRetailError arg0, PPH.PPRetailInvoiceAttachment arg1);
	public delegate void PPRetailMerchantHandler (PPH.PPRetailError arg0, PPH.PPRetailMerchant arg1);
	public delegate void PPRetailMerchantReceiptForwardedHandler (PPH.PPRetailError arg0);
	public delegate void PPRetailOnCardReaderDiscoveredEvent (PPH.PPRetailDiscoveredCardReader arg0);
	public delegate void PPRetailOnConnectionResultEvent (PPH.PPRetailError arg0, PPH.PPRetailPaymentDevice arg1);
	public delegate void PPRetailOnConnectionStatusEvent (PPH.PPRetailError arg0, PPH.PPRetailDiscoveredCardReader arg1);
	public delegate void PPRetailOnScanCompleteEvent (PPH.PPRetailError arg0);
	public delegate void PPRetailPageViewedEvent (PPH.PPRetailError arg0, PPH.PPRetailPage arg1);
	public delegate void PPRetailPaymentDeviceBatteryInfoHandler (PPH.PPRetailError arg0, PPH.PPRetailBatteryInfo arg1);
	public delegate void PPRetailPaymentDeviceConnectHandler (PPH.PPRetailError arg0);
	public delegate void PPRetailPaymentDeviceDeviceLogsHandler (PPH.PPRetailError arg0);
	public delegate void PPRetailPaymentDeviceDisconnectHandler (PPH.PPRetailError arg0);
	public delegate void PPRetailPinEntryEvent (bool arg0, bool arg1, int arg2, bool arg3);
	public delegate void PPRetailReaderTippingCompletedEvent (NSDecimalNumber arg0);
	public delegate void PPRetailReconnectReaderEvent (int arg0);
	public delegate void PPRetailSDKInterceptHandler (PPH.PPRetailNetworkRequest arg0);
	public delegate void PPRetailSelectedEvent ();
	public delegate void PPRetailTransactionContextCardInsertedHandlerHandler (PPH.PPRetailCardInsertedHandler arg0);
	public delegate void PPRetailTransactionContextCardPresentedHandler (PPH.PPRetailCard arg0);
	public delegate void PPRetailTransactionContextCompleteHandler (PPH.PPRetailError arg0);
	public delegate void PPRetailTransactionContextOnAuthCompleteHandler (PPH.PPRetailError arg0, PPH.PPRetailCaptureHandler arg1, PPH.PPRetailTransactionRecord arg2);
	public delegate void PPRetailTransactionContextReceiptOptionHandlerHandler (int arg0, string arg1, PPH.PPRetailTransactionRecord arg2);
	public delegate void PPRetailTransactionContextSignatureCollectorHandler (PPH.PPRetailSignatureReceiver arg0);
	public delegate void PPRetailTransactionContextTokenExpirationHandlerHandler (PPH.PPRetailTokenExpirationHandler arg0);
	public delegate void PPRetailTransactionContextTransactionCompletedHandler (PPH.PPRetailError arg0, PPH.PPRetailTransactionRecord arg1);
	public delegate void PPRetailTransactionManagerCaptureAuthorizedTransactionHandler (PPH.PPRetailError arg0, string arg1);
	public delegate void PPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler (PPH.PPRetailError arg0, NSObject[] arg1, string arg2);
	public delegate void PPRetailTransactionManagerTransactionHandler (PPH.PPRetailError arg0, PPH.PPRetailTransactionContext arg1);
	public delegate void PPRetailTransactionManagerVoidAuthorizationHandler (PPH.PPRetailError arg0);
	public delegate void PPRetailUpdateRequiredEvent (PPH.PPRetailDeviceUpdate arg0);
	public delegate void PPRetailWillPresentSignatureEvent ();
}

