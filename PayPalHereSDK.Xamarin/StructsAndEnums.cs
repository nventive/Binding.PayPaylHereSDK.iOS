using System;
using ObjCRuntime;

namespace PPH
{

	[Native]
	public enum PPHReaderType : ulong
	{
		Unknown,
		AudioJack,
		DockPort,
		ChipAndPinBluetooth,
	}

	[Native]
	[Flags]
	public enum PPHReaderTypeMask : ulong
	{
		None = 0x0000,
		AudioJack = 0x0002,
		DockPort = 0x0004,
		ChipAndPinBluetooth = 0x0008,
		All = AudioJack | DockPort | ChipAndPinBluetooth
	}

	[Native]
	public enum PPHReaderModel : ulong
	{
		Unknown,
		MiuraM000,
		MiuraM003,
		MiuraM010,
		MagtekAudio,
		RoamAudio,
		MagtekiDynamo
	}

	[Native]
	[Flags]
	public enum PPHSupportedPaymentInterface : ulong
	{
		Unknown = 1,
		ContactlessMagStripe = 2,
		ContactlessEMVChipAndPin = 4,
		EMVChipAndPin = 6,
		Swipe = 8
	}

	[Native]
	[Flags]
	public enum PPHSupportedPaymentInterfaceMask : ulong
	{
		None = 0,
		ContactlessMagStripe = PPHSupportedPaymentInterface.ContactlessMagStripe,
		ContactlessEMVChipAndPin = PPHSupportedPaymentInterface.ContactlessEMVChipAndPin,
		EMVChipAndPin = PPHSupportedPaymentInterface.EMVChipAndPin,
		Swipe = PPHSupportedPaymentInterface.Swipe,
		All = ContactlessMagStripe | ContactlessEMVChipAndPin | EMVChipAndPin | Swipe
	}

	[Native]
	public enum PPHMagStripeTracksMask : ulong
	{
		None = 0,
		TrackOne = 1 << 0,
		TrackTwo = 1 << 1,
		TrackThree = 1 << 2,
		All = TrackOne | TrackTwo | TrackThree
	}

	[Native]
	public enum PPHDisplayReader : ulong
	{
		Unknown,
		M010
	}

	public enum PPHReaderBatteryStatus
	{
		OnBattery,
		Charging,
		ChargedConnectedToPower,
		BatteryLow
	}

	[Native]
	public enum PPHReaderError : ulong
	{
		None = 0,
		AudioAccessDenied = 1,
		LocationNotAvailable = 2,
		ConnectFailed = 3,
		NotAvailable = 4,
		TransactionNotValid = 5,
		NonReaderConnected = 6,
		InvalidState = 7
	}

	[Native]
	public enum PPHLocationCheckinType : ulong
	{
		None = 0,
		Standard
	}

	[Native]
	public enum PPHLocationCheckinExtensionType : ulong
	{
		None = 0,
		PostOpen
	}

	[Native]
	public enum PPHLocationStatus : ulong
	{
		Unknown = 0,
		Active = 1,
		Deleted = 2
	}

	[Native]
	public enum PPHGratuityType : ulong
	{
		None = 0,
		Standard = 1
	}

	[Native]
	public enum PPHCreditCardType : ulong
	{
		Unknown = 0,
		Visa = 1,
		Mastercard = 2,
		Discover = 3,
		AmEx = 4,
		Jcb = 5,
		Maestro = 6,
		PayPal = 7
	}

	[Native]
	public enum PPHContactlessTransactionType : ulong
	{
		Unknown = 0,
		Msd,
		Emv
	}

	public enum PPHInvoiceStatus : ulong
	{
		Unknown = 0,
		Draft = 1,
		Sent = 2,
		Paid = 3,
		MarkedAsPaid = 4,
		Canceled = 5,
		Refunded = 6,
		PartialRefund = 7,
		Reversed = 8,
		Pending = 9,
		Saved = 10,
		MarkedAsRefunded = 11
	}

	[Native]
	public enum PPHAvailablePaymentTypes : ulong
	{
		None = 0,
		Card = 1,
		Checkin = 1 << 1,
		Chip = 1 << 2,
		ContactlessMSD = 1 << 3,
		ContactlessEMV = 1 << 4
	}

	public enum PPHPaymentMethod : ulong
	{
		Unknown = 0,
		Key,
		Scan,
		Swipe,
		Paypal,
		Check,
		Cash,
		ChipCard,
		EmvSwipe,
		ContactlessMSD,
		ContactlessEMV,
		Other
	}

	public enum PPHPaymentMethodDetail : ulong
	{
		None = 0,
		BankTransfer = 5,
		DebitCard = 6,
		WireTransfer = 7
	}

	[Native]
	public enum PPHTransactionStatus : ulong
	{
		Paid,
		PaymentDeclined,
		PaymentCancelled,
		Refunded,
		PartiallyRefunded,
		RefundDeclined,
		RefundCancelled
	}

	[Native]
	public enum PPHAccountStatus : ulong
	{
		Unknown,
		Ready,
		Restricted,
		Eligible,
		Ineligible
	}

	[Native]
	public enum PPHAccessResultType : ulong
	{
		Success,
		Failed
	}

	public enum PPHInvoiceTotalParts : ulong
	{
		IncludeNone = 0,
		IncludeItems = 1 << 0,
		IncludeTax = 1 << 1,
		IncludeDiscount = 1 << 2,
		IncludeGratuity = 1 << 3,
		IncludeShipping = 1 << 4,
		IncludeShippingTax = 1 << 5,
		IncludeRefund = 1 << 6,
		IncludeCustomAmount = 1 << 7,
		SimpleTotal = IncludeItems | IncludeTax,
		GrandTotal = IncludeItems | IncludeTax | IncludeDiscount | IncludeGratuity | IncludeShipping | IncludeShippingTax | IncludeCustomAmount,
		TaxTotal = IncludeTax | IncludeShippingTax,
		GrandTotalInclusive = IncludeItems | IncludeDiscount | IncludeGratuity | IncludeShipping | IncludeShippingTax | IncludeCustomAmount
	}

	[Native]
	public enum PPHLocationCheckinStatus : ulong
	{
		Unknown = 0,
		Active,
		Cancelled,
		Expired,
		Paid,
		Left,
		Deleted
	}

	[Native]
	public enum PPHContactlessTimeoutAction : ulong
	{
		ContinueWithContactless,
		ContinueWithContact,
		CancelTransaction
	}

	[Native]
	public enum PPHTransactionEventType : ulong
	{
		Idle,
		GettingPaymentInfo,
		DidStartReaderDetection,
		DidDetectReaderDevice,
		DidRemoveReader,
		CardReadBegun,
		CardDataReceived,
		ReadCardNotAllowed,
		FailedToReadCard,
		ProcessingPayment,
		WaitingForSignature,
		TransactionCancelled,
		TransactionDeclined
	}

	[Native]
	public enum PPHAnalyticsEventType : ulong
	{
		None = 0,
		Normal = 1,
		Log = 2
	}

	[Native]
	public enum PPHAnalyticsEventName : ulong
	{
		None = 0,
		ReaderInserted,
		ReaderRemoved,
		AudioSwiperError,
		AudioSwipeSuccessful,
		DockPortSwiperError,
		DockPortSwipeSuccessful,
		SoftwareUpdateError,
		SoftwareUpdateRestartReader
	}

	[Native]
	public enum PPHSDKServiceType : ulong
	{
		Live,
		Sandbox
	}

	[Native]
	public enum PPHInitResultType : ulong
	{
		Success,
		FailedInsufficientCredentials,
		Failed
	}

	[Native]
	public enum PPHChipAndPinEventType : ulong
	{
		Approved = 1,
		Declined = 2,
		AuthRequired = 3,
		Failed = 4,
		Cancelled = 5,
		PinVerified = 6,
		PinIncorrect = 7,
		WaitingForPin = 8,
		PinBlocked = 9,
		ButtonPressed = 10,
		CardBlocked = 11,
		CardInserted = 12,
		CardRemoved = 13,
		CardInvalid = 14,
		CardDeclined = 15,
		CardChipBroken = 16,
		DecisionRequired = 17,
		CardTapped = 18,
		CardTapFailure = 19,
		NumericEntry = 20
	}

	[Native]
	public enum PPHCardTapError : ulong
	{
		Unknown,
		HardwareFailure,
		ChipCardInserted,
		MSDCardSwiped,
		ContactlessTimeout,
		ICCRequested,
		InsertSwipeOrTapNewCard
	}

	[Native]
	public enum PPHChipAndPinButtonType : ulong
	{
		Unknown,
		KeyPadDigit,
		Back,
		Cancel,
		Ok
	}

	public enum PPHPrinterFormat : byte
	{
		Text,
		Html
	}

	public enum PPHInvoiceReceiptType : byte
	{
		Customer,
		Merchant,
		Gift
	}

}

