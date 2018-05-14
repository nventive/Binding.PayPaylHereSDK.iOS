using System;
using ObjCRuntime;

namespace PPH
{
	[Native]
	public enum PPRetailInvoiceStatus : long
	{
		New = 0,
		Draft = 1,
		Sent = 2,
		Paid = 3,
		MarkedAsPaid = 4,
		Cancelled = 5,
		Refunded = 6,
		PartiallyRefunded = 7,
		MarkedAsRefunded = 8,
		PartiallyPaid = 9,
		Unpaid = 10,
		PaymentPending = 11,
		Scheduled = 12,
		Unknown = 13
	}

	[Native]
	public enum PPRetailInvoicePaymentType : long
	{
		None = 0,
		External = 1,
		Paypal = 2
	}

	[Native]
	public enum PPRetailInvoicePaymentMethod : long
	{
		None = 0,
		BankTransfer = 1,
		Cash = 2,
		Check = 3,
		CreditCard = 4,
		DebitCard = 5,
		Paypal = 6,
		WireTransfer = 7,
		Other = 8
	}

	[Native]
	public enum PPRetailInvoiceAction : long
	{
		None = 0,
		Delete = 1,
		Send = 2,
		Remind = 3,
		RecordPayment = 4,
		RecordRefund = 5,
		Copy = 6,
		Edit = 7,
		Call = 8,
		Cancel = 9,
		More = 10,
		Share = 11,
		ViewHistory = 12,
		ViewInvoice = 13
	}

	[Native]
	public enum PPRetailInvoicePaymentTermPaymentTerms : long
	{
		NoPaymentTerms = 0,
		DueOnReceipt = 1,
		Net10 = 2,
		Net15 = 3,
		Net30 = 4,
		Net45 = 5,
		Net60 = 6,
		Net90 = 7
	}

	[Native]
	public enum PPRetaillogLevel : long
	{
		quiet = 0,
		error = 1,
		warn = 2,
		info = 3,
		debug = 4
	}

	[Native]
	public enum PPRetailReceiptDestinationType : long
	{
		none = 0,
		email = 1,
		text = 2
	}

	[Native]
	public enum PPRetailPaymentState : long
	{
		idle = 0,
		inProgress = 1,
		retry = 2,
		complete = 3
	}

	[Native]
	public enum PPRetailTippingState : long
	{
		notStarted = 0,
		inProgress = 1,
		complete = 2
	}

	[Native]
	public enum PPRetailAuthStatus : long
	{
		pending = 0,
		canceled = 1
	}

	[Native]
	public enum PPRetailbatteryStatus : long
	{
		unknown = 0,
		draining = 1,
		drained = 2,
		charging = 3,
		charged = 4
	}

	[Native]
	public enum PPRetaildeviceCapabilityType : long
	{
		none = 0,
		display = 1,
		keyboard = 2,
		secureEntry = 3,
		contactless = 4
	}

	[Native]
	public enum PPRetailCardStatus : long
	{
		None = 0,
		NonEmvCard = 1,
		EmvCard = 3
	}

	[Native]
	public enum PPRetailCardIssuer : long
	{
		Unknown = 0,
		Visa = 1,
		MasterCard = 2,
		Maestro = 3,
		Amex = 4,
		Discover = 5,
		PayPal = 6
	}

	[Native]
	public enum PPRetailFormFactor : long
	{
		None = 0,
		MagneticCardSwipe = 1,
		Chip = 2,
		EmvCertifiedContactless = 3,
		SecureManualEntry = 4,
		ManualCardEntry = 5
	}

	[Native]
	public enum PPRetailTransactionType : long
	{
		Sale = 0,
		Auth = 1,
		Refund = 2,
		PartialRefund = 3
	}

	[Native]
	public enum PPRetailreaderType : long
	{
		Unknown = 0,
		Magstripe = 1,
		Emv = 2
	}

	[Native]
	public enum PPRetailreaderConnectionType : long
	{
		Unknown = 0,
		AudioJack = 1,
		Bluetooth = 2,
		DockPort = 3
	}

	[Native]
	public enum PPRetailReaderModel : long
	{
		Unknown = 0,
		Swiper = 1,
		M003 = 2,
		M010 = 3,
		Moby3000 = 4,
		Rp450 = 5
	}
}
