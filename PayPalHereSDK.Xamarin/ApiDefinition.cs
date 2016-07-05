using System;

using Foundation;
using UIKit;
using System;
using CoreGraphics;
using CoreLocation;
using ObjCRuntime;


namespace PPH
{

	// @interface PPHReaderConstants : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHReaderConstants
	{
		// +(PPHReaderModel)readerModelFromModelString:(NSString *)modelString;
		[Static]
		[Export("readerModelFromModelString:")]
		PPHReaderModel ReaderModelFromModelString(string modelString);

		// +(PPHReaderType)readerTypeFromModel:(PPHReaderModel)model;
		[Static]
		[Export("readerTypeFromModel:")]
		PPHReaderType ReaderTypeFromModel(PPHReaderModel model);

		// +(NSString *)stringForReaderType:(PPHReaderType)type;
		[Static]
		[Export("stringForReaderType:")]
		string StringForReaderType(PPHReaderType type);
	}

	// @protocol PPHCardReaderDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface PPHCardReaderDelegate
	{
		// @optional -(void)didFindAvailableReaderDevice:(PPHCardReaderMetadata *)reader;
		[Export("didFindAvailableReaderDevice:")]
		void DidFindAvailableReaderDevice(PPHCardReaderMetadata reader);

		// @optional -(void)didStartReaderDetection:(PPHCardReaderMetadata *)reader;
		[Export("didStartReaderDetection:")]
		void DidStartReaderDetection(PPHCardReaderMetadata reader);

		// @optional -(void)didDetectReaderDevice:(PPHCardReaderMetadata *)reader;
		[Export("didDetectReaderDevice:")]
		void DidDetectReaderDevice(PPHCardReaderMetadata reader);

		// @optional -(void)didRemoveReader:(PPHReaderType)readerType;
		[Export("didRemoveReader:")]
		void DidRemoveReader(PPHReaderType readerType);

		// @optional -(void)didDetectCardSwipeAttempt;
		[Export("didDetectCardSwipeAttempt")]
		void DidDetectCardSwipeAttempt();

		// @optional -(void)didCompleteCardSwipe:(PPHCardSwipeData *)card;
		[Export("didCompleteCardSwipe:")]
		void DidCompleteCardSwipe(PPHCardSwipeData card);

		// @optional -(void)didFailToReadCard;
		[Export("didFailToReadCard")]
		void DidFailToReadCard();

		// @optional -(void)didReceiveCardReaderMetadata:(PPHCardReaderMetadata *)metadata;
		[Export("didReceiveCardReaderMetadata:")]
		void DidReceiveCardReaderMetadata(PPHCardReaderMetadata metadata);

		// @optional -(void)activeReaderChangedFrom:(PPHCardReaderMetadata *)previousReader to:(PPHCardReaderMetadata *)currentReader;
		[Export("activeReaderChangedFrom:to:")]
		void ActiveReaderChangedFrom(PPHCardReaderMetadata previousReader, PPHCardReaderMetadata currentReader);

		// @optional -(void)didUpgradeReader:(BOOL)successful withMessage:(NSString *)message;
		[Export("didUpgradeReader:withMessage:")]
		void DidUpgradeReader(bool successful, string message);

		// @optional -(void)didRemoveCard;
		[Export("didRemoveCard")]
		void DidRemoveCard();
	}

	// @interface PPHCardReaderWatcher : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHCardReaderWatcher
	{
		// -(id)initWithDelegate:(id<PPHCardReaderDelegate>)delegate;
		[Export("initWithDelegate:")]
		IntPtr Constructor(PPHCardReaderDelegate cardReaderDelegate);
	}

	// @interface PPHCardReaderDisplayScreen : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHCardReaderDisplayScreen
	{
		// @property (readonly, nonatomic) BOOL backLightPresent;
		[Export("backLightPresent")]
		bool BackLightPresent { get; }

		// @property (readonly, nonatomic) CGSize resolutionDimensions;
		[Export("resolutionDimensions")]
		CGSize ResolutionDimensions { get; }
	}

	// @interface PPHCardReaderKeyPad : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHCardReaderKeyPad
	{
		// @property (readonly, nonatomic) BOOL backLightPresent;
		[Export("backLightPresent")]
		bool BackLightPresent { get; }
	}

	// @interface PPHSupportedPaymentInterfaces : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHSupportedPaymentInterfaces
	{
		// @property (readonly, nonatomic) PPHSupportedPaymentInterfaceMask supportedPayments;
		[Export("supportedPayments")]
		PPHSupportedPaymentInterfaceMask SupportedPayments { get; }

		// @property (readonly, nonatomic) BOOL swipe;
		[Export("swipe")]
		bool Swipe { get; }

		// @property (readonly, nonatomic) BOOL contactless;
		[Export("contactless")]
		bool Contactless { get; }

		// @property (readonly, nonatomic) BOOL chipAndPinEMV;
		[Export("chipAndPinEMV")]
		bool ChipAndPinEMV { get; }

		// @property (readonly, nonatomic) PPHMagStripeTracksMask supportedTracks;
		[Export("supportedTracks")]
		PPHMagStripeTracksMask SupportedTracks { get; }
	}

	// @interface PPHCardReaderCapabilities : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHCardReaderCapabilities
	{
		// -(PPHCardReaderDisplayScreen *)display;
		[Export("display")]
		PPHCardReaderDisplayScreen Display { get; }

		// -(PPHCardReaderKeyPad *)inputKeyPad;
		[Export("inputKeyPad")]
		PPHCardReaderKeyPad InputKeyPad { get; }

		// -(PPHSupportedPaymentInterfaces *)paymentCapabilities;
		[Export("paymentCapabilities")]
		PPHSupportedPaymentInterfaces PaymentCapabilities { get; }

		// -(BOOL)beeperPresent;
		[Export("beeperPresent")]
		bool BeeperPresent { get; }

		// -(BOOL)builtInPrinter;
		[Export("builtInPrinter")]
		bool BuiltInPrinter { get; }

		// -(NSDictionary *)extraCapabilityInfo;
		[Export("extraCapabilityInfo")]
		NSDictionary ExtraCapabilityInfo { get; }
	}

	// @interface PPHReaderDisplayFormatter : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHReaderDisplayFormatter
	{
		// @property (readonly, nonatomic, strong) NSMutableString * stringValue;
		[Export("stringValue", ArgumentSemantic.Strong)]
		NSMutableString StringValue { get; }

		// +(PPHReaderDisplayFormatter *)formatterWithNumCharactersPerRow:(NSUInteger)numChars;
		[Static]
		[Export("formatterWithNumCharactersPerRow:")]
		PPHReaderDisplayFormatter FormatterWithNumCharactersPerRow(nuint numChars);

		// +(PPHReaderDisplayFormatter *)formatterForDisplayReader:(PPHDisplayReader)reader;
		[Static]
		[Export("formatterForDisplayReader:")]
		PPHReaderDisplayFormatter FormatterForDisplayReader(PPHDisplayReader reader);

		// -(void)justifyString:(NSString *)str withAlignment:(NSTextAlignment)alignment;
		[Export("justifyString:withAlignment:")]
		void JustifyString(string str, UITextAlignment alignment);

		// -(void)stringWithLeftString:(NSString *)left andRightString:(NSString *)right;
		[Export("stringWithLeftString:andRightString:")]
		void StringWithLeftString(string left, string right);

		// -(NSString *)readerTextForKey:(NSString *)key;
		[Export("readerTextForKey:")]
		string ReaderTextForKey(string key);

		// -(NSArray *)splitOnNewLine:(NSString *)str;
		[Export("splitOnNewLine:")]
		NSObject[] SplitOnNewLine(string str);

		// -(void)addPaddedLine;
		[Export("addPaddedLine")]
		void AddPaddedLine();

		// -(void)clearString;
		[Export("clearString")]
		void ClearString();
	}

	// @interface PPHReaderBatteryMetadata : NSObject <NSCoding>
	[BaseType(typeof(NSObject))]
	interface PPHReaderBatteryMetadata : INSCoding
	{
		// @property (nonatomic) PPHReaderBatteryStatus status;
		[Export("status", ArgumentSemantic.Assign)]
		PPHReaderBatteryStatus Status { get; set; }

		// @property (nonatomic) int level;
		[Export("level")]
		int Level { get; set; }

		// -(BOOL)connectedToPower;
		[Export("connectedToPower")]
		bool ConnectedToPower { get; }

		// +(instancetype)batteryMetadataWithStatus:(PPHReaderBatteryStatus)status;
		[Static]
		[Export("batteryMetadataWithStatus:")]
		PPHReaderBatteryMetadata BatteryMetadataWithStatus(PPHReaderBatteryStatus status);

		// +(instancetype)batteryMetadataWithStatus:(PPHReaderBatteryStatus)status level:(int)level;
		[Static]
		[Export("batteryMetadataWithStatus:level:")]
		PPHReaderBatteryMetadata BatteryMetadataWithStatus(PPHReaderBatteryStatus status, int level);

		// -(instancetype)initBatteryMetadataForStatus:(PPHReaderBatteryStatus)status level:(int)level;
		[Export("initBatteryMetadataForStatus:level:")]
		IntPtr Constructor(PPHReaderBatteryStatus status, int level);
	}

	// @interface PPHCardReaderMetadata : NSObject <NSCoding>
	[BaseType(typeof(NSObject))]
	interface PPHCardReaderMetadata : INSCoding
	{
		// +(PPHCardReaderMetadata *)anyReader;
		[Static]
		[Export("anyReader")]
		PPHCardReaderMetadata AnyReader { get; }

		// @property (assign, nonatomic) PPHReaderType readerType;
		[Export("readerType", ArgumentSemantic.Assign)]
		PPHReaderType ReaderType { get; set; }

		// @property (nonatomic, strong) NSString * family;
		[Export("family", ArgumentSemantic.Strong)]
		string Family { get; set; }

		// @property (nonatomic, strong) NSString * friendlyName;
		[Export("friendlyName", ArgumentSemantic.Strong)]
		string FriendlyName { get; set; }

		// @property (nonatomic, strong) NSString * protocolName;
		[Export("protocolName", ArgumentSemantic.Strong)]
		string ProtocolName { get; set; }

		// @property (nonatomic, strong) NSString * modelNo;
		[Export("modelNo", ArgumentSemantic.Strong)]
		string ModelNo { get; set; }

		// @property (assign, nonatomic) PPHReaderModel readerModel;
		[Export("readerModel", ArgumentSemantic.Assign)]
		PPHReaderModel ReaderModel { get; set; }

		// @property (nonatomic, strong) NSString * serialNumber;
		[Export("serialNumber", ArgumentSemantic.Strong)]
		string SerialNumber { get; set; }

		// @property (nonatomic, strong) NSString * osRevision;
		[Export("osRevision", ArgumentSemantic.Strong)]
		string OsRevision { get; set; }

		// @property (nonatomic, strong) NSString * firmwareRevision;
		[Export("firmwareRevision", ArgumentSemantic.Strong)]
		string FirmwareRevision { get; set; }

		// @property (nonatomic, strong) PPHReaderBatteryMetadata * batteryInfo;
		[Export("batteryInfo", ArgumentSemantic.Strong)]
		PPHReaderBatteryMetadata BatteryInfo { get; set; }

		// -(PPHCardReaderCapabilities *)capabilities;
		[Export("capabilities")]
		PPHCardReaderCapabilities Capabilities { get; }

		// -(BOOL)cardIsInserted;
		[Export("cardIsInserted")]
		bool CardIsInserted { get; }

		// -(BOOL)isReadyToTransact;
		[Export("isReadyToTransact")]
		bool IsReadyToTransact { get; }

		// -(BOOL)upgradeIsAvailable;
		[Export("upgradeIsAvailable")]
		bool UpgradeIsAvailable { get; }

		// -(BOOL)upgradeIsReady;
		[Export("upgradeIsReady")]
		bool UpgradeIsReady { get; }

		// -(BOOL)upgradeIsManadatory;
		[Export("upgradeIsManadatory")]
		bool UpgradeIsManadatory { get; }

		// -(BOOL)upgradeIsInitialSetup;
		[Export("upgradeIsInitialSetup")]
		bool UpgradeIsInitialSetup { get; }

		// -(BOOL)batteryIsLow;
		[Export("batteryIsLow")]
		bool BatteryIsLow { get; }

		// -(BOOL)batteryIsCritical;
		[Export("batteryIsCritical")]
		bool BatteryIsCritical { get; }

		// -(BOOL)isReadyForUpgrade;
		[Export("isReadyForUpgrade")]
		bool IsReadyForUpgrade { get; }

		// -(BOOL)batteryIsCharging;
		[Export("batteryIsCharging")]
		bool BatteryIsCharging { get; }
	}

	// @interface PPHAmount : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPHAmount
	{
		// +(NSString *)localeCodeFromCountry:(NSString *)country;
		[Static]
		[Export("localeCodeFromCountry:")]
		string LocaleCodeFromCountry(string country);

		// +(NSString *)defaultCurrencyCodeInCountry:(NSString *)countryCode;
		[Static]
		[Export("defaultCurrencyCodeInCountry:")]
		string DefaultCurrencyCodeInCountry(string countryCode);

		// +(PPHAmount *)amountWithString:(NSString *)stringValue;
		[Static]
		[Export("amountWithString:")]
		PPHAmount AmountWithString(string stringValue);

		// +(PPHAmount *)amountWithDecimal:(NSDecimalNumber *)amount;
		[Static]
		[Export("amountWithDecimal:")]
		PPHAmount AmountWithDecimal(NSDecimalNumber amount);

		// +(PPHAmount *)amountWithDecimal:(NSDecimalNumber *)amount inCurrency:(NSString *)currency;
		[Static]
		[Export("amountWithDecimal:inCurrency:")]
		PPHAmount AmountWithDecimal(NSDecimalNumber amount, string currency);

		// +(PPHAmount *)amountWithString:(NSString *)stringValue inCurrency:(NSString *)currency;
		[Static]
		[Export("amountWithString:inCurrency:")]
		PPHAmount AmountWithString(string stringValue, string currency);

		// -(id)initWithAmount:(NSDecimalNumber *)amount inCurrency:(NSString *)currency __attribute__((objc_designated_initializer));
		[Export("initWithAmount:inCurrency:")]
		[DesignatedInitializer]
		IntPtr Constructor(NSDecimalNumber amount, string currency);

		// -(id)initWithPadding:(NSString *)amount inCurrency:(NSString *)currency;
		[Export("initWithPadding:inCurrency:")]
		IntPtr Constructor(string amount, string currency);

		// -(id)initWithRounding:(NSDecimalNumber *)amount inCurrency:(NSString *)currency;
		//[Export("initWithRounding:inCurrency:")]
		//IntPtr Constructor(NSDecimalNumber amount, string currency);

		// @property (readonly, nonatomic, strong) NSString * currencyCode;
		[Export("currencyCode", ArgumentSemantic.Strong)]
		string CurrencyCode { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * amount;
		[Export("amount", ArgumentSemantic.Strong)]
		NSDecimalNumber Amount { get; }

		// -(BOOL)isValid;
		[Export("isValid")]
		bool IsValid { get; }

		// -(BOOL)isAmountEqualToZero;
		[Export("isAmountEqualToZero")]
		bool IsAmountEqualToZero { get; }

		// -(BOOL)isAmountAboveCardPresentMinimum;
		[Export("isAmountAboveCardPresentMinimum")]
		bool IsAmountAboveCardPresentMinimum { get; }

		// -(BOOL)isAmountBelowCardPresentMaximum;
		[Export("isAmountBelowCardPresentMaximum")]
		bool IsAmountBelowCardPresentMaximum { get; }

		// -(BOOL)isAmountAcceptedForContactless;
		[Export("isAmountAcceptedForContactless")]
		bool IsAmountAcceptedForContactless { get; }

		// -(NSInteger)amountInCents;
		[Export("amountInCents")]
		nint AmountInCents { get; }

		// -(NSInteger)isoCurrencyNumber;
		[Export("isoCurrencyNumber")]
		nint IsoCurrencyNumber { get; }

		// -(NSString *)currencySymbol;
		[Export("currencySymbol")]
		string CurrencySymbol { get; }

		// -(NSUInteger)digitsAfterDecimalSeperator;
		[Export("digitsAfterDecimalSeperator")]
		nuint DigitsAfterDecimalSeperator { get; }

		// -(NSString *)decimalSeparator;
		[Export("decimalSeparator")]
		string DecimalSeparator { get; }

		// -(NSString *)stringValue;
		[Export("stringValue")]
		string StringValue { get; }

		// -(NSString *)stringValueWithoutCurrencySymbol;
		[Export("stringValueWithoutCurrencySymbol")]
		string StringValueWithoutCurrencySymbol { get; }

		// -(NSString *)stringValueForPayment;
		[Export("stringValueForPayment")]
		string StringValueForPayment { get; }

		// -(PPHAmount *)multiply:(NSDecimalNumber *)multiple;
		[Export("multiply:")]
		PPHAmount Multiply(NSDecimalNumber multiple);

		// -(PPHAmount *)subtract:(NSDecimalNumber *)operand;
		[Export("subtract:")]
		PPHAmount Subtract(NSDecimalNumber operand);

		// -(PPHAmount *)add:(NSDecimalNumber *)operand;
		[Export("add:")]
		PPHAmount Add(NSDecimalNumber operand);

		// -(PPHAmount *)divideBy:(NSDecimalNumber *)divisor;
		[Export("divideBy:")]
		PPHAmount DivideBy(NSDecimalNumber divisor);

		// -(PPHAmount *)multiplyByAmount:(PPHAmount *)multiple;
		[Export("multiplyByAmount:")]
		PPHAmount MultiplyByAmount(PPHAmount multiple);

		// -(PPHAmount *)subtractAmount:(PPHAmount *)operand;
		[Export("subtractAmount:")]
		PPHAmount SubtractAmount(PPHAmount operand);

		// -(PPHAmount *)addAmount:(PPHAmount *)operand;
		[Export("addAmount:")]
		PPHAmount AddAmount(PPHAmount operand);

		// -(PPHAmount *)divideByAmount:(PPHAmount *)divisor;
		[Export("divideByAmount:")]
		PPHAmount DivideByAmount(PPHAmount divisor);

		// -(PPHAmount *)roundedAmount;
		[Export("roundedAmount")]
		PPHAmount RoundedAmount { get; }
	}

	// @protocol PPHInvoiceProtocol <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface PPHInvoiceProtocol
	{
		// @required -(NSString *)currency;
		[Abstract]
		[Export("currency")]
		string Currency { get; }

		// @required -(PPHAmount *)totalAmount;
		[Abstract]
		[Export("totalAmount")]
		PPHAmount TotalAmount { get; }

		// @required -(NSString *)paypalInvoiceId;
		[Abstract]
		[Export("paypalInvoiceId")]
		string PaypalInvoiceId { get; }

		// @required -(NSDictionary *)asDictionary;
		[Abstract]
		[Export("asDictionary")]
		NSDictionary AsDictionary();

		// @required -(NSString *)payerEmail;
		[Abstract]
		[Export("payerEmail")]
		string PayerEmail { get; }
	}

	// @interface PPHCardReaderManager : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHCardReaderManager
	{
		// -(PPHReaderError)beginMonitoring;
		[Export("beginMonitoring")]
		PPHReaderError BeginMonitoring();

		// -(PPHReaderError)beginMonitoring:(PPHReaderTypeMask)readerTypes;
		[Export("beginMonitoring:")]
		PPHReaderError BeginMonitoring(PPHReaderTypeMask readerTypes);

		// @property (readonly, nonatomic) PPHReaderTypeMask monitoringForTypes;
		[Export("monitoringForTypes")]
		PPHReaderTypeMask MonitoringForTypes { get; }

		// -(void)endMonitoring;
		[Export("endMonitoring")]
		void EndMonitoring();

		// -(PPHReaderError)activateReader:(PPHCardReaderMetadata *)reader;
		[Export("activateReader:")]
		PPHReaderError ActivateReader(PPHCardReaderMetadata reader);

		// -(BOOL)openActiveReader;
		[Export("openActiveReader")]
		bool OpenActiveReader();

		// -(BOOL)closeActiveReader;
		[Export("closeActiveReader")]
		bool CloseActiveReader();

		// -(NSArray *)availableReaders;
		[Export("availableReaders")]
		NSObject[] AvailableReaders();

		// -(PPHCardReaderMetadata *)availableReaderOfType:(PPHReaderType)type;
		[Export("availableReaderOfType:")]
		PPHCardReaderMetadata AvailableReaderOfType(PPHReaderType type);

		// -(PPHCardReaderMetadata *)lastAvailableReaderOfType:(PPHReaderType)type;
		[Export("lastAvailableReaderOfType:")]
		PPHCardReaderMetadata LastAvailableReaderOfType(PPHReaderType type);

		// -(PPHCardReaderMetadata *)activeReader;
		[Export("activeReader")]
		PPHCardReaderMetadata ActiveReader { get; }

		// -(void)beginUpgradeUsingSDKUIForReader:(PPHCardReaderMetadata *)reader completionHandler:(void (^)(BOOL, NSString *))completionHandler;
		[Export("beginUpgradeUsingSDKUIForReader:completionHandler:")]
		void BeginUpgradeUsingSDKUIForReader(PPHCardReaderMetadata reader, Action<bool, NSString> completionHandler);
	}

	// @protocol PPHLocationWatcherDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface PPHLocationWatcherDelegate
	{
		// @optional -(void)locationWatcher:(PPHLocationWatcher *)watcher didDetectNewTab:(PPHLocationCheckin *)checkin;
		[Export("locationWatcher:didDetectNewTab:")]
		void DidDetectNewTab(PPHLocationWatcher watcher, PPHLocationCheckin checkin);

		// @optional -(void)locationWatcher:(PPHLocationWatcher *)watcher didDetectRemovedTab:(PPHLocationCheckin *)checkin;
		[Export("locationWatcher:didDetectRemovedTab:")]
		void DidDetectRemovedTab(PPHLocationWatcher watcher, PPHLocationCheckin checkin);

		// @optional -(void)locationWatcher:(PPHLocationWatcher *)watcher didReceiveError:(PPHError *)error;
		[Export("locationWatcher:didReceiveError:")]
		void DidReceiveError(PPHLocationWatcher watcher, PPHError error);

		// @optional -(void)locationWatcher:(PPHLocationWatcher *)watcher didCompleteUpdate:(NSArray *)openTabs wasModified:(BOOL)wasModified;
		[Export("locationWatcher:didCompleteUpdate:wasModified:")]
		void DidCompleteUpdate(PPHLocationWatcher watcher, NSObject[] openTabs, bool wasModified);
	}

	// @interface PPHLocationWatcher : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHLocationWatcher
	{
		[Wrap("WeakDelegate")]
		PPHLocationWatcherDelegate Delegate { get; set; }

		// @property (nonatomic, unsafe_unretained) id<PPHLocationWatcherDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic, strong) NSString * locationId;
		[Export("locationId", ArgumentSemantic.Strong)]
		string LocationId { get; }

		// @property (readonly, nonatomic, strong) NSArray * openTabs;
		[Export("openTabs", ArgumentSemantic.Strong)]
		NSObject[] OpenTabs { get; }

		// -(void)updateNow;
		[Export("updateNow")]
		void UpdateNow();

		// -(void)updatePeriodically:(NSInteger)minimumUpdateIntervalSeconds withMaximumInterval:(NSInteger)maximumUpdateIntervalSeconds;
		[Export("updatePeriodically:withMaximumInterval:")]
		void UpdatePeriodically(nint minimumUpdateIntervalSeconds, nint maximumUpdateIntervalSeconds);

		// -(void)stopPeriodicUpdates;
		[Export("stopPeriodicUpdates")]
		void StopPeriodicUpdates();
	}

	// @interface PPHLocation : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface PPHLocation : INSCopying
	{
		// -(id)initWithDictionary:(NSDictionary *)dictionary;
		[Export("initWithDictionary:")]
		IntPtr Constructor(NSDictionary dictionary);

		// -(void)save:(void (^)(PPHError *))completionHandler;
		[Export("save:")]
		void Save(Action<PPHError> completionHandler);

		// -(void)deleteLocation:(void (^)(PPHError *))completionHandler;
		[Export("deleteLocation:")]
		void DeleteLocation(Action<PPHError> completionHandler);

		// @property (nonatomic, strong) NSString * internalName;
		[Export("internalName", ArgumentSemantic.Strong)]
		string InternalName { get; set; }

		// @property (nonatomic, strong) NSString * displayMessage;
		[Export("displayMessage", ArgumentSemantic.Strong)]
		string DisplayMessage { get; set; }

		// @property (nonatomic, strong) PPHInvoiceContactInfo * contactInfo;
		[Export("contactInfo", ArgumentSemantic.Strong)]
		PPHInvoiceContactInfo ContactInfo { get; set; }

		// @property (assign, nonatomic) CLLocationCoordinate2D location;
		[Export("location", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D Location { get; set; }

		// @property (assign, nonatomic) BOOL isAvailable;
		[Export("isAvailable")]
		bool IsAvailable { get; set; }

		// @property (assign, nonatomic) BOOL isMobile;
		[Export("isMobile")]
		bool IsMobile { get; set; }

		// @property (assign, nonatomic) PPHLocationCheckinType checkinType;
		[Export("checkinType", ArgumentSemantic.Assign)]
		PPHLocationCheckinType CheckinType { get; set; }

		// @property (nonatomic, strong) NSURL * checkinExtensionUrl;
		[Export("checkinExtensionUrl", ArgumentSemantic.Strong)]
		NSUrl CheckinExtensionUrl { get; set; }

		// @property (assign, nonatomic) PPHLocationCheckinExtensionType checkinExtensionType;
		[Export("checkinExtensionType", ArgumentSemantic.Assign)]
		PPHLocationCheckinExtensionType CheckinExtensionType { get; set; }

		// @property (nonatomic, strong) NSString * logoUrl;
		[Export("logoUrl", ArgumentSemantic.Strong)]
		string LogoUrl { get; set; }

		// @property (assign, nonatomic) NSInteger checkinDurationInMinutes;
		[Export("checkinDurationInMinutes")]
		nint CheckinDurationInMinutes { get; set; }

		// @property (assign, nonatomic) PPHGratuityType gratuityType;
		[Export("gratuityType", ArgumentSemantic.Assign)]
		PPHGratuityType GratuityType { get; set; }

		// @property (readonly, nonatomic, strong) NSString * locationId;
		[Export("locationId", ArgumentSemantic.Strong)]
		string LocationId { get; }

		// @property (readonly, nonatomic, strong) NSDate * createDate;
		[Export("createDate", ArgumentSemantic.Strong)]
		NSDate CreateDate { get; }

		// @property (readonly, nonatomic, strong) NSDate * updateDate;
		[Export("updateDate", ArgumentSemantic.Strong)]
		NSDate UpdateDate { get; }

		// @property (readonly, nonatomic) PPHLocationStatus status;
		[Export("status")]
		PPHLocationStatus Status { get; }
	}

	// @interface PPHLocalManager : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHLocalManager
	{
		// -(PPHLocationWatcher *)watcherForLocationId:(NSString *)locationId withDelegate:(id<PPHLocationWatcherDelegate>)delegate;
		[Export("watcherForLocationId:withDelegate:")]
		PPHLocationWatcher WatcherForLocationId(string locationId, PPHLocationWatcherDelegate locationWatcherDelegate);

		// -(void)beginGetLocations:(void (^)(PPHError *, NSArray *))handler;
		[Export("beginGetLocations:")]
		void BeginGetLocations(Action<PPHError, NSArray> handler);
	}

	// @interface PPHCardNotPresentData : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHCardNotPresentData
	{
		// @property (nonatomic, strong) NSString * cardNumber;
		[Export("cardNumber", ArgumentSemantic.Strong)]
		string CardNumber { get; set; }

		// @property (nonatomic, strong) NSDate * expirationDate;
		[Export("expirationDate", ArgumentSemantic.Strong)]
		NSDate ExpirationDate { get; set; }

		// @property (nonatomic, strong) NSString * cvv2;
		[Export("cvv2", ArgumentSemantic.Strong)]
		string Cvv2 { get; set; }

		// @property (nonatomic, strong) NSString * postalCode;
		[Export("postalCode", ArgumentSemantic.Strong)]
		string PostalCode { get; set; }

		// @property (nonatomic) BOOL scanned;
		[Export("scanned")]
		bool Scanned { get; set; }

		// @property (readonly, nonatomic) BOOL isValid;
		[Export("isValid")]
		bool IsValid { get; }

		// @property (readonly, nonatomic) PPHCreditCardType cardType;
		[Export("cardType")]
		PPHCreditCardType CardType { get; }
	}


	// typedef void (^PPHInvoiceLoadDetailsCompletionHandler)(NSDictionary *, PPHError *);
	delegate void PPHInvoiceLoadDetailsCompletionHandler(NSDictionary arg0, PPHError arg1);

	// typedef void (^PPHTransactionDetailsResultWrapper)(PPMobileAPITransactionDetailsResult *);
	// delegate void PPHTransactionDetailsResultWrapper(PPMobileAPITransactionDetailsResult arg0);

	// typedef void (^PPHInvoiceBasicCompletionHandler)(PPHError *);
	delegate void PPHInvoiceBasicCompletionHandler(PPHError arg0);

	// typedef void (^PPHInvoiceLoadCompletionHandler)(PPHInvoice *, PPHError *);
	delegate void PPHInvoiceLoadCompletionHandler(PPHInvoice arg0, PPHError arg1);

	// @interface PPHInvoiceConstants : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHInvoiceConstants
	{

		// +(PPHInvoiceStatus)invoiceStatusFromString:(NSString *)string;
		[Static]
		[Export("invoiceStatusFromString:")]
		PPHInvoiceStatus InvoiceStatusFromString(string @string);

		// +(NSString *)stringFromInvoiceStatus:(PPHInvoiceStatus)status;
		[Static]
		[Export("stringFromInvoiceStatus:")]
		string StringFromInvoiceStatus(PPHInvoiceStatus status);

		// +(BOOL)invoiceStatusIsPaid:(PPHInvoiceStatus)status;
		[Static]
		[Export("invoiceStatusIsPaid:")]
		bool InvoiceStatusIsPaid(PPHInvoiceStatus status);

		// +(BOOL)invoiceStatusIsRefunded:(PPHInvoiceStatus)status;
		[Static]
		[Export("invoiceStatusIsRefunded:")]
		bool InvoiceStatusIsRefunded(PPHInvoiceStatus status);
	}

	// @interface PPHReceiptDestination : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHReceiptDestination
	{
		// @property (nonatomic, strong) NSString * destinationAddress;
		[Export("destinationAddress", ArgumentSemantic.Strong)]
		string DestinationAddress { get; set; }

		// @property (assign, nonatomic) BOOL isEmail;
		[Export("isEmail")]
		bool IsEmail { get; set; }
	}

	// @interface PPHPaymentConstants : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHPaymentConstants
	{
		// +(PPHPaymentMethod)paymentMethodFromString:(NSString *)string;
		[Static]
		[Export("paymentMethodFromString:")]
		PPHPaymentMethod PaymentMethodFromString(string @string);

		// +(PPHPaymentMethodDetail)paymentMethodDetailFromString:(NSString *)string;
		[Static]
		[Export("paymentMethodDetailFromString:")]
		PPHPaymentMethodDetail PaymentMethodDetailFromString(string @string);

		// +(NSString *)stringFromPaymentMethod:(PPHPaymentMethod)method;
		[Static]
		[Export("stringFromPaymentMethod:")]
		string StringFromPaymentMethod(PPHPaymentMethod method);

		// +(NSString *)stringFromPaymentMethodDetail:(PPHPaymentMethodDetail)type;
		[Static]
		[Export("stringFromPaymentMethodDetail:")]
		string StringFromPaymentMethodDetail(PPHPaymentMethodDetail type);

		// +(BOOL)paymentMethodIsContactless:(PPHPaymentMethod)method;
		[Static]
		[Export("paymentMethodIsContactless:")]
		bool PaymentMethodIsContactless(PPHPaymentMethod method);

		// +(BOOL)paymentMethodIsCardPresent:(PPHPaymentMethod)method;
		[Static]
		[Export("paymentMethodIsCardPresent:")]
		bool PaymentMethodIsCardPresent(PPHPaymentMethod method);

		// +(BOOL)paymentMethodIsEmv:(PPHPaymentMethod)method;
		[Static]
		[Export("paymentMethodIsEmv:")]
		bool PaymentMethodIsEmv(PPHPaymentMethod method);

		// +(BOOL)paymentMethodIsSwipe:(PPHPaymentMethod)method;
		[Static]
		[Export("paymentMethodIsSwipe:")]
		bool PaymentMethodIsSwipe(PPHPaymentMethod method);

		// +(BOOL)paymentMethodIsMSD:(PPHPaymentMethod)method;
		[Static]
		[Export("paymentMethodIsMSD:")]
		bool PaymentMethodIsMSD(PPHPaymentMethod method);

		// +(BOOL)paymentMethodIsCreditCard:(PPHPaymentMethod)method;
		[Static]
		[Export("paymentMethodIsCreditCard:")]
		bool PaymentMethodIsCreditCard(PPHPaymentMethod method);

		// +(BOOL)paymentMethodMarksAsPaid:(PPHPaymentMethod)method;
		[Static]
		[Export("paymentMethodMarksAsPaid:")]
		bool PaymentMethodMarksAsPaid(PPHPaymentMethod method);

		// +(PPHPaymentMethod)paymentMethodForContactlessTransactionType:(PPHContactlessTransactionType)type;
		[Static]
		[Export("paymentMethodForContactlessTransactionType:")]
		PPHPaymentMethod PaymentMethodForContactlessTransactionType(PPHContactlessTransactionType type);

		// +(BOOL)paymentMethod:(PPHPaymentMethod)method isAllowedInAvailablePaymentTypes:(PPHAvailablePaymentTypes)availablePaymentTypes;
		[Static]
		[Export("paymentMethod:isAllowedInAvailablePaymentTypes:")]
		bool PaymentMethod(PPHPaymentMethod method, PPHAvailablePaymentTypes availablePaymentTypes);

		// +(NSString *)stringFromTransactionStatus:(PPHTransactionStatus)transactionStatus;
		[Static]
		[Export("stringFromTransactionStatus:")]
		string StringFromTransactionStatus(PPHTransactionStatus transactionStatus);

		// +(BOOL)transactionStatusIsRefund:(PPHTransactionStatus)transactionStatus;
		[Static]
		[Export("transactionStatusIsRefund:")]
		bool TransactionStatusIsRefund(PPHTransactionStatus transactionStatus);

		// +(BOOL)transactionStatusIsSuccessful:(PPHTransactionStatus)transactionStatus;
		[Static]
		[Export("transactionStatusIsSuccessful:")]
		bool TransactionStatusIsSuccessful(PPHTransactionStatus transactionStatus);

		// +(BOOL)transactionStatusIsCancelled:(PPHTransactionStatus)transactionStatus;
		[Static]
		[Export("transactionStatusIsCancelled:")]
		bool TransactionStatusIsCancelled(PPHTransactionStatus transactionStatus);

		// +(BOOL)transactionStatusIsDeclined:(PPHTransactionStatus)transactionStatus;
		[Static]
		[Export("transactionStatusIsDeclined:")]
		bool TransactionStatusIsDeclined(PPHTransactionStatus transactionStatus);
	}

	// @interface PPHCardSwipeData : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHCardSwipeData
	{
		// -(id)initWithTrack1:(NSString *)track1 track2:(NSString *)track2 readerSerial:(NSString *)serial withType:(NSString *)readerType andExtraInfo:(NSDictionary *)extraInfo;
		[Export("initWithTrack1:track2:readerSerial:withType:andExtraInfo:")]
		IntPtr Constructor(string track1, string track2, string serial, string readerType, NSDictionary extraInfo);

		// -(id)initWithEncryptedTrack1:(NSString *)encryptedTrack1 encryptedTrack2:(NSString *)encryptedTrack2 readerSerial:(NSString *)serial keySerial:(NSString *)ksn withType:(NSString *)readerType;
		[Export("initWithEncryptedTrack1:encryptedTrack2:readerSerial:keySerial:withType:")]
		IntPtr Constructor(string encryptedTrack1, string encryptedTrack2, string serial, string ksn, string readerType);

		// @property (nonatomic, strong) NSString * maskedCardNumber;
		[Export("maskedCardNumber", ArgumentSemantic.Strong)]
		string MaskedCardNumber { get; set; }

		// @property (nonatomic, strong) NSString * cardholderName;
		[Export("cardholderName", ArgumentSemantic.Strong)]
		string CardholderName { get; set; }

		// @property (nonatomic, strong) NSString * cardholderFirstName;
		[Export("cardholderFirstName", ArgumentSemantic.Strong)]
		string CardholderFirstName { get; set; }

		// @property (nonatomic, strong) NSString * cardholderLastName;
		[Export("cardholderLastName", ArgumentSemantic.Strong)]
		string CardholderLastName { get; set; }

		// @property (nonatomic) NSInteger expirationMonth;
		[Export("expirationMonth")]
		nint ExpirationMonth { get; set; }

		// @property (nonatomic) NSInteger expirationYear;
		[Export("expirationYear")]
		nint ExpirationYear { get; set; }

		// @property (nonatomic, strong) NSDictionary * extraData;
		[Export("extraData", ArgumentSemantic.Strong)]
		NSDictionary ExtraData { get; set; }

		// @property (nonatomic, strong) NSString * ksn;
		[Export("ksn", ArgumentSemantic.Strong)]
		string Ksn { get; set; }

		// @property (nonatomic, strong) NSString * serial;
		[Export("serial", ArgumentSemantic.Strong)]
		string Serial { get; set; }

		// @property (nonatomic) BOOL signaturePresent;
		[Export("signaturePresent")]
		bool SignaturePresent { get; set; }

		// -(BOOL)parseTracks:(NSString *)track1AndOr2;
		[Export("parseTracks:")]
		bool ParseTracks(string track1AndOr2);

		// -(BOOL)parseTracksWithMaskedTrack1:(NSString *)maskedTrack1OrNil maskedTrack2:(NSString *)maskedTrack2OrNil;
		[Export("parseTracksWithMaskedTrack1:maskedTrack2:")]
		bool ParseTracksWithMaskedTrack1(string maskedTrack1OrNil, string maskedTrack2OrNil);

		// @property (nonatomic, strong) PPHCardReaderMetadata * reader;
		[Export("reader", ArgumentSemantic.Strong)]
		PPHCardReaderMetadata Reader { get; set; }

		// @property (readonly, nonatomic) PPHCreditCardType cardType;
		[Export("cardType")]
		PPHCreditCardType CardType { get; }

		// @property (readonly, nonatomic) BOOL cardAllowsSwipe;
		[Export("cardAllowsSwipe")]
		bool CardAllowsSwipe { get; }

		// -(NSDictionary *)asDictionary;
		[Export("asDictionary")]
		NSDictionary AsDictionary();
	}

	// @interface PPHTransactionRecord : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHTransactionRecord
	{
		// @property (readonly, nonatomic, strong) PPHInvoice * invoice;
		[Export("invoice", ArgumentSemantic.Strong)]
		PPHInvoice Invoice { get; }

		// @property (readonly, nonatomic, strong) NSDate * date;
		[Export("date", ArgumentSemantic.Strong)]
		NSDate Date { get; }

		// @property (readonly, nonatomic, strong) NSString * transactionId;
		[Export("transactionId", ArgumentSemantic.Strong)]
		string TransactionId { get; }

		// @property (readonly, nonatomic, strong) NSString * authorizationId;
		[Export("authorizationId", ArgumentSemantic.Strong)]
		string AuthorizationId { get; }

		// @property (readonly, nonatomic, strong) NSString * payPalInvoiceId;
		[Export("payPalInvoiceId", ArgumentSemantic.Strong)]
		string PayPalInvoiceId { get; }

		// @property (readonly, nonatomic, strong) NSString * correlationId;
		[Export("correlationId", ArgumentSemantic.Strong)]
		string CorrelationId { get; }

		// @property (readonly, copy, nonatomic) NSString * customerId;
		[Export("customerId")]
		string CustomerId { get; }

		// @property (readonly, copy, nonatomic) NSString * receiptPreferenceToken;
		[Export("receiptPreferenceToken")]
		string ReceiptPreferenceToken { get; }

		// @property (readonly, nonatomic) BOOL paidWithPayPal;
		[Export("paidWithPayPal")]
		bool PaidWithPayPal { get; }

		// @property (readonly, nonatomic) PPHPaymentMethod paymentMethod;
		[Export("paymentMethod")]
		PPHPaymentMethod PaymentMethod { get; }

		// @property (readonly, nonatomic) PPHPaymentMethodDetail paymentMethodDetail;
		[Export("paymentMethodDetail")]
		PPHPaymentMethodDetail PaymentMethodDetail { get; }

		// @property (readonly, nonatomic, strong) PPHCardSwipeData * encryptedCardData;
		[Export("encryptedCardData", ArgumentSemantic.Strong)]
		PPHCardSwipeData EncryptedCardData { get; }

		// @property (readonly, nonatomic, strong) NSString * authCode;
		[Export("authCode", ArgumentSemantic.Strong)]
		string AuthCode { get; }

		// @property (readonly, nonatomic, strong) NSString * transactionHandle;
		[Export("transactionHandle", ArgumentSemantic.Strong)]
		string TransactionHandle { get; }

		// @property (readonly, nonatomic, strong) PPHTokenizedCustomerInformation * customerInfo;
		[Export("customerInfo", ArgumentSemantic.Strong)]
		PPHTokenizedCustomerInformation CustomerInfo { get; }

		// @property (readonly, nonatomic, strong) PPHReceiptDestination * receiptDestination;
		[Export("receiptDestination", ArgumentSemantic.Strong)]
		PPHReceiptDestination ReceiptDestination { get; }

		// @property (readonly, nonatomic) PPHTransactionStatus transactionStatus;
		[Export("transactionStatus")]
		PPHTransactionStatus TransactionStatus { get; }

		// -(id)initWithTransactionId:(NSString *)transactionId;
		[Export("initWithTransactionId:")]
		IntPtr Constructor(string transactionId);

		// -(id)initWithTransactionId:(NSString *)transactionId andWithPayPalInvoiceId:(NSString *)payPalInvoiceId;
		[Export("initWithTransactionId:andWithPayPalInvoiceId:")]
		IntPtr Constructor(string transactionId, string payPalInvoiceId);

		// -(id)initWithAuthorizationId:(NSString *)authorizationId andWithInvoice:(PPHInvoice *)invoice;
		[Export("initWithAuthorizationId:andWithInvoice:")]
		IntPtr Constructor(string authorizationId, PPHInvoice invoice);

		// -(id)initWithInvoice:(PPHInvoice *)invoice;
		[Export("initWithInvoice:")]
		IntPtr Constructor(PPHInvoice invoice);
	}

	// @interface PPHPaymentResponse : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHPaymentResponse
	{
		// @property (nonatomic, strong) PPHError * error;
		[Export("error", ArgumentSemantic.Strong)]
		PPHError Error { get; set; }

		// @property (nonatomic, strong) NSString * transactionId;
		[Export("transactionId", ArgumentSemantic.Strong)]
		string TransactionId { get; set; }

		// @property (nonatomic, strong) NSString * authorizationId;
		[Export("authorizationId", ArgumentSemantic.Strong)]
		string AuthorizationId { get; set; }

		// @property (nonatomic, strong) NSString * paypalInvoiceId;
		[Export("paypalInvoiceId", ArgumentSemantic.Strong)]
		string PaypalInvoiceId { get; set; }

		// @property (nonatomic, strong) NSString * correlationId;
		[Export("correlationId", ArgumentSemantic.Strong)]
		string CorrelationId { get; set; }

		// @property (assign, nonatomic) BOOL isPaymentAuthorization;
		[Export("isPaymentAuthorization")]
		bool IsPaymentAuthorization { get; set; }

		// -(NSDictionary *)asDictionary;
		[Export("asDictionary")]
		NSDictionary AsDictionary();

		// -(id)initWithDictionary:(NSDictionary *)dictionary;
		[Export("initWithDictionary:")]
		IntPtr Constructor(NSDictionary dictionary);
	}

	// @interface PPHChipAndPinAuthResponse : PPHPaymentResponse
	[BaseType(typeof(PPHPaymentResponse))]
	interface PPHChipAndPinAuthResponse
	{
		// @property (nonatomic, strong) NSString * authCode;
		[Export("authCode", ArgumentSemantic.Strong)]
		string AuthCode { get; set; }

		// @property (nonatomic, strong) NSString * transactionHandle;
		[Export("transactionHandle", ArgumentSemantic.Strong)]
		string TransactionHandle { get; set; }

		// @property (nonatomic, strong) NSArray * warnings;
		[Export("warnings", ArgumentSemantic.Strong)]
		NSObject[] Warnings { get; set; }

		// @property (nonatomic, strong) NSString * responseCode;
		[Export("responseCode", ArgumentSemantic.Strong)]
		string ResponseCode { get; set; }
	}

	// @interface PPHRefundEligibilityResponse : PPHPaymentResponse
	[BaseType(typeof(PPHPaymentResponse))]
	interface PPHRefundEligibilityResponse
	{
		// @property (assign, nonatomic) BOOL isEligible;
		[Export("isEligible")]
		bool IsEligible { get; set; }
	}

	// @interface PPHCardChargeResponse : PPHPaymentResponse
	[BaseType(typeof(PPHPaymentResponse))]
	interface PPHCardChargeResponse
	{
		// @property (nonatomic, strong) PPHTokenizedCustomerInformation * customer;
		[Export("customer", ArgumentSemantic.Strong)]
		PPHTokenizedCustomerInformation Customer { get; set; }
	}

	// @interface PPHPaymentProcessor : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHPaymentProcessor
	{
		// -(void)beginRefund:(NSString *)transactionId forAmount:(PPHAmount *)amountOrNil completionHandler:(void (^)(PPHPaymentResponse *))completionHandler;
		[Export("beginRefund:forAmount:completionHandler:")]
		void BeginRefund(string transactionId, PPHAmount amountOrNil, Action<PPHPaymentResponse> completionHandler);

		// -(void)beginNonPayPalRefundWithInvoiceId:(NSString *)invoiceId forAmount:(PPHAmount *)amountOrNil completionHandler:(void (^)(PPHPaymentResponse *))completionHandler;
		[Export("beginNonPayPalRefundWithInvoiceId:forAmount:completionHandler:")]
		void BeginNonPayPalRefundWithInvoiceId(string invoiceId, PPHAmount amountOrNil, Action<PPHPaymentResponse> completionHandler);

		// -(void)beginCheckinPayment:(PPHLocationCheckin *)checkin forInvoice:(id<PPHInvoiceProtocol>)invoice completionHandler:(void (^)(PPHPaymentResponse *))completionHandler;
		[Export("beginCheckinPayment:forInvoice:completionHandler:")]
		void BeginCheckinPayment(PPHLocationCheckin checkin, PPHInvoiceProtocol invoice, Action<PPHPaymentResponse> completionHandler);

		// -(void)beginCardPresentChargeAttempt:(PPHCardSwipeData *)card forInvoice:(id<PPHInvoiceProtocol>)invoice withSignature:(UIImage *)signature completionHandler:(void (^)(PPHCardChargeResponse *))completionHandler;
		[Export("beginCardPresentChargeAttempt:forInvoice:withSignature:completionHandler:")]
		void BeginCardPresentChargeAttempt(PPHCardSwipeData card, PPHInvoiceProtocol invoice, UIImage signature, Action<PPHCardChargeResponse> completionHandler);

		// -(void)beginCardPresentAuthorizationAttempt:(PPHCardSwipeData *)card forInvoice:(id<PPHInvoiceProtocol>)invoice completionHandler:(void (^)(PPHCardChargeResponse *))completionHandler;
		[Export("beginCardPresentAuthorizationAttempt:forInvoice:completionHandler:")]
		void BeginCardPresentAuthorizationAttempt(PPHCardSwipeData card, PPHInvoiceProtocol invoice, Action<PPHCardChargeResponse> completionHandler);

		// -(void)beginCardNotPresentChargeAttempt:(PPHCardNotPresentData *)card forInvoice:(id<PPHInvoiceProtocol>)invoice completionHandler:(void (^)(PPHCardChargeResponse *))completionHandler;
		[Export("beginCardNotPresentChargeAttempt:forInvoice:completionHandler:")]
		void BeginCardNotPresentChargeAttempt(PPHCardNotPresentData card, PPHInvoiceProtocol invoice, Action<PPHCardChargeResponse> completionHandler);

		// -(void)beginCardNotPresentAuthorizationAttempt:(PPHCardNotPresentData *)card forInvoice:(id<PPHInvoiceProtocol>)invoice completionHandler:(void (^)(PPHCardChargeResponse *))completionHandler;
		[Export("beginCardNotPresentAuthorizationAttempt:forInvoice:completionHandler:")]
		void BeginCardNotPresentAuthorizationAttempt(PPHCardNotPresentData card, PPHInvoiceProtocol invoice, Action<PPHCardChargeResponse> completionHandler);

		// -(void)beginCaptureForTransactionId:(NSString *)txId withAmount:(PPHAmount *)amount andInvoice:(id<PPHInvoiceProtocol>)invoice asFinal:(BOOL)finalCapture withCompletionHandler:(void (^)(PPHCardChargeResponse *))completionHandler;
		[Export("beginCaptureForTransactionId:withAmount:andInvoice:asFinal:withCompletionHandler:")]
		void BeginCaptureForTransactionId(string txId, PPHAmount amount, PPHInvoiceProtocol invoice, bool finalCapture, Action<PPHCardChargeResponse> completionHandler);

		// -(void)beginVoidForTransactionId:(NSString *)txId withInvoice:(id<PPHInvoiceProtocol>)invoice andCompletionHandler:(void (^)(PPHCardChargeResponse *))completionHandler;
		[Export("beginVoidForTransactionId:withInvoice:andCompletionHandler:")]
		void BeginVoidForTransactionId(string txId, PPHInvoiceProtocol invoice, Action<PPHCardChargeResponse> completionHandler);

		// -(void)beginRecordingExternalPayment:(PPHPaymentMethod)paymentType withNote:(NSString *)note forInvoice:(id<PPHInvoiceProtocol>)invoice completionHandler:(void (^)(PPHPaymentResponse *))completionHandler;
		[Export("beginRecordingExternalPayment:withNote:forInvoice:completionHandler:")]
		void BeginRecordingExternalPayment(PPHPaymentMethod paymentType, string note, PPHInvoiceProtocol invoice, Action<PPHPaymentResponse> completionHandler);

		// -(void)provideSignature:(UIImage *)signature forTransaction:(PPHCardChargeResponse *)response andInvoice:(id<PPHInvoiceProtocol>)invoice completionHandler:(void (^)(PPHError *))completionHandler;
		[Export("provideSignature:forTransaction:andInvoice:completionHandler:")]
		void ProvideSignature(UIImage signature, PPHCardChargeResponse response, PPHInvoiceProtocol invoice, Action<PPHError> completionHandler);

		// -(void)checkRefundEligibilityForCardPresent:(PPHCardSwipeData *)card transactionRecord:(PPHTransactionRecord *)record completionHandler:(void (^)(PPHRefundEligibilityResponse *))completionHandler;
		[Export("checkRefundEligibilityForCardPresent:transactionRecord:completionHandler:")]
		void CheckRefundEligibilityForCardPresent(PPHCardSwipeData card, PPHTransactionRecord record, Action<PPHRefundEligibilityResponse> completionHandler);

		// -(void)beginSendReceipt:(PPHPaymentResponse *)payment to:(PPHReceiptDestination *)destination completionHandler:(PPHInvoiceBasicCompletionHandler)completionHandler;
		[Export("beginSendReceipt:to:completionHandler:")]
		void BeginSendReceipt(PPHPaymentResponse payment, PPHReceiptDestination destination, PPHInvoiceBasicCompletionHandler completionHandler);
	}

	// @interface PPHAccessAccount : NSObject <NSCoding>
	[BaseType(typeof(NSObject))]
	interface PPHAccessAccount : INSCoding
	{
		// -(id)initWithAccessToken:(NSString *)accessToken expires_in:(NSString *)seconds refreshUrl:(NSString *)refreshUrl details:(NSDictionary *)paypalAccessResponse;
		[Export("initWithAccessToken:expires_in:refreshUrl:details:")]
		IntPtr Constructor(string accessToken, string seconds, string refreshUrl, NSDictionary paypalAccessResponse);

		// -(BOOL)hasCredentials;
		[Export("hasCredentials")]
		bool HasCredentials { get; }

		// @property (readonly, nonatomic, strong) NSString * access_token;
		[Export("access_token", ArgumentSemantic.Strong)]
		string Access_token { get; }

		// @property (readonly, nonatomic, strong) NSString * refresh_url;
		[Export("refresh_url", ArgumentSemantic.Strong)]
		string Refresh_url { get; }

		// @property (readonly, nonatomic, strong) NSString * id_token;
		[Export("id_token", ArgumentSemantic.Strong)]
		string Id_token { get; }

		// @property (readonly, nonatomic, strong) NSString * tokenScope;
		[Export("tokenScope", ArgumentSemantic.Strong)]
		string TokenScope { get; }

		// @property (readonly, nonatomic, strong) NSDate * accessTokenExpiration;
		[Export("accessTokenExpiration", ArgumentSemantic.Strong)]
		NSDate AccessTokenExpiration { get; }

		// @property (readonly, assign, nonatomic) PPHAccountStatus status;
		[Export("status", ArgumentSemantic.Assign)]
		PPHAccountStatus Status { get; }

		// @property (readonly, nonatomic, strong) NSString * userId;
		[Export("userId", ArgumentSemantic.Strong)]
		string UserId { get; }

		// @property (readonly, nonatomic, strong) NSString * email;
		[Export("email", ArgumentSemantic.Strong)]
		string Email { get; }

		// @property (readonly, nonatomic, strong) NSArray * emails;
		[Export("emails", ArgumentSemantic.Strong)]
		NSObject[] Emails { get; }

		// @property (readonly, nonatomic) PPHAvailablePaymentTypes availablePaymentTypes;
		[Export("availablePaymentTypes")]
		PPHAvailablePaymentTypes AvailablePaymentTypes { get; }

		// @property (nonatomic, strong) PPHPaymentLimits * paymentLimits;
		[Export("paymentLimits", ArgumentSemantic.Strong)]
		PPHPaymentLimits PaymentLimits { get; set; }

		// @property (readonly, nonatomic, strong) NSDictionary * extraInfo;
		[Export("extraInfo", ArgumentSemantic.Strong)]
		NSDictionary ExtraInfo { get; }

		// @property (readonly, nonatomic, strong) NSString * currencyCode;
		[Export("currencyCode", ArgumentSemantic.Strong)]
		string CurrencyCode { get; }
	}

	// typedef void (^PPHAccessTokenRefreshHandler)(PPHAccessResultType, PPHError *);
	delegate void PPHAccessTokenRefreshHandler(PPHAccessResultType arg0, PPHError arg1);

	// typedef void (^PPHAccessCompletionHandler)(PPHAccessResultType, PPHAccessAccount *, NSDictionary *);
	delegate void PPHAccessCompletionHandler(PPHAccessResultType arg0, PPHAccessAccount arg1, NSDictionary arg2);

	// @interface PPHAccessController : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHAccessController
	{
		// -(void)setupMerchant:(PPHAccessAccount *)account completionHandler:(PPHAccessCompletionHandler)completionHandler __attribute__((deprecated("")));
		[Export("setupMerchant:completionHandler:")]
		void SetupMerchant(PPHAccessAccount account, PPHAccessCompletionHandler completionHandler);

		// -(void)refresh:(PPHAccessAccount *)account completionHandler:(PPHAccessTokenRefreshHandler)completionHandler;
		[Export("refresh:completionHandler:")]
		void Refresh(PPHAccessAccount account, PPHAccessTokenRefreshHandler completionHandler);
	}

	// @interface PPHInvoiceTotals : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHInvoiceTotals
	{
		// @property (readonly, nonatomic, strong) NSDecimalNumber * total __attribute__((deprecated("")));
		[Export("total", ArgumentSemantic.Strong)]
		NSDecimalNumber Total { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * subTotal;
		[Export("subTotal", ArgumentSemantic.Strong)]
		NSDecimalNumber SubTotal { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * itemTaxTotal;
		[Export("itemTaxTotal", ArgumentSemantic.Strong)]
		NSDecimalNumber ItemTaxTotal { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * taxTotal;
		[Export("taxTotal", ArgumentSemantic.Strong)]
		NSDecimalNumber TaxTotal { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * discountsTotal;
		[Export("discountsTotal", ArgumentSemantic.Strong)]
		NSDecimalNumber DiscountsTotal { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * gratuityTotal;
		[Export("gratuityTotal", ArgumentSemantic.Strong)]
		NSDecimalNumber GratuityTotal { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * shippingTotal;
		[Export("shippingTotal", ArgumentSemantic.Strong)]
		NSDecimalNumber ShippingTotal { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * refundTotal;
		[Export("refundTotal", ArgumentSemantic.Strong)]
		NSDecimalNumber RefundTotal { get; }

		// @property (readonly, nonatomic, strong) NSDictionary * taxDetails;
		[Export("taxDetails", ArgumentSemantic.Strong)]
		NSDictionary TaxDetails { get; }

		// -(id)initWithInvoice:(PPHInvoice *)invoice;
		[Export("initWithInvoice:")]
		IntPtr Constructor(PPHInvoice invoice);

		// -(NSDecimalNumber *)totalWithParts:(PPHInvoiceTotalParts)composition;
		[Export("totalWithParts:")]
		NSDecimalNumber TotalWithParts(PPHInvoiceTotalParts composition);
	}

	// @interface PPHInvoicePayment : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHInvoicePayment
	{
		// -(id)initWithTransaction:(NSString *)transactionId forAmount:(PPHAmount *)amount withMethod:(PPHPaymentMethod)method andDetail:(PPHPaymentMethodDetail)detail onDate:(NSDate *)date;
		[Export("initWithTransaction:forAmount:withMethod:andDetail:onDate:")]
		IntPtr Constructor(string transactionId, PPHAmount amount, PPHPaymentMethod method, PPHPaymentMethodDetail detail, NSDate date);

		// -(id)initWithDictionary:(NSDictionary *)representation;
		[Export("initWithDictionary:")]
		IntPtr Constructor(NSDictionary representation);

		// -(NSDictionary *)asDictionary;
		[Export("asDictionary")]
		NSDictionary AsDictionary();

		// @property (readonly, nonatomic) PPHPaymentMethod paymentMethod;
		[Export("paymentMethod")]
		PPHPaymentMethod PaymentMethod { get; }

		// @property (readonly, nonatomic) PPHPaymentMethodDetail paymentMethodDetail;
		[Export("paymentMethodDetail")]
		PPHPaymentMethodDetail PaymentMethodDetail { get; }

		// @property (readonly, nonatomic, strong) NSString * transactionId;
		[Export("transactionId", ArgumentSemantic.Strong)]
		string TransactionId { get; }

		// @property (readonly, nonatomic, strong) PPHAmount * amount;
		[Export("amount", ArgumentSemantic.Strong)]
		PPHAmount Amount { get; }

		// @property (readonly, nonatomic, strong) NSDate * date;
		[Export("date", ArgumentSemantic.Strong)]
		NSDate Date { get; }

		// @property (readonly, nonatomic) BOOL paidWithPayPal;
		[Export("paidWithPayPal")]
		bool PaidWithPayPal { get; }

		// @property (readonly, nonatomic) NSString * latitude;
		[Export("latitude")]
		string Latitude { get; }

		// @property (readonly, nonatomic) NSString * longitude;
		[Export("longitude")]
		string Longitude { get; }

		// @property (readonly, nonatomic, strong) NSString * details;
		[Export("details", ArgumentSemantic.Strong)]
		string Details { get; }

		// @property (readonly, nonatomic) PPHCreditCardType creditCardType;
		[Export("creditCardType")]
		PPHCreditCardType CreditCardType { get; }

		// @property (readonly, nonatomic, strong) NSString * creditCardLastFourDigits;
		[Export("creditCardLastFourDigits", ArgumentSemantic.Strong)]
		string CreditCardLastFourDigits { get; }

		// @property (readonly, nonatomic, strong) NSString * creditCardApplicationName;
		[Export("creditCardApplicationName", ArgumentSemantic.Strong)]
		string CreditCardApplicationName { get; }

		// @property (readonly, nonatomic, strong) PPHAmount * fee;
		[Export("fee", ArgumentSemantic.Strong)]
		PPHAmount Fee { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * cashTendered;
		[Export("cashTendered", ArgumentSemantic.Strong)]
		NSDecimalNumber CashTendered { get; }
	}

	// @interface PPHInvoiceItem : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPHInvoiceItem : INSCopying
	{
		// @property (readonly, nonatomic, strong) NSString * itemId;
		[Export("itemId", ArgumentSemantic.Strong)]
		string ItemId { get; }

		// @property (readonly, nonatomic, strong) NSString * itemDetailId;
		[Export("itemDetailId", ArgumentSemantic.Strong)]
		string ItemDetailId { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * quantity;
		[Export("quantity", ArgumentSemantic.Strong)]
		NSDecimalNumber Quantity { get; }

		// @property (readonly, nonatomic, strong) NSString * name;
		[Export("name", ArgumentSemantic.Strong)]
		string Name { get; }

		// @property (nonatomic, strong) NSString * itemDescription;
		[Export("itemDescription", ArgumentSemantic.Strong)]
		string ItemDescription { get; set; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * unitPrice;
		[Export("unitPrice", ArgumentSemantic.Strong)]
		NSDecimalNumber UnitPrice { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * taxRate;
		[Export("taxRate", ArgumentSemantic.Strong)]
		NSDecimalNumber TaxRate { get; }

		// @property (readonly, nonatomic, strong) NSString * taxRateName;
		[Export("taxRateName", ArgumentSemantic.Strong)]
		string TaxRateName { get; }

		// @property (nonatomic, strong) NSString * imageUrl;
		[Export("imageUrl", ArgumentSemantic.Strong)]
		string ImageUrl { get; set; }

		// -(NSDictionary *)asDictionary;
		[Export("asDictionary")]
		NSDictionary AsDictionary();

		// -(id)initWithDictionary:(NSDictionary *)representation;
		[Export("initWithDictionary:")]
		IntPtr Constructor(NSDictionary representation);

		// -(PPHAmount *)roundedTotalInCurrency:(NSString *)currency;
		[Export("roundedTotalInCurrency:")]
		PPHAmount RoundedTotalInCurrency(string currency);
	}

	// @interface PPHInvoiceContactInfo : NSObject <NSCoding, NSCopying>
	[BaseType(typeof(NSObject))]
	interface PPHInvoiceContactInfo : INSCoding, INSCopying
	{
		// @property (nonatomic, strong) NSString * firstName;
		[Export("firstName", ArgumentSemantic.Strong)]
		string FirstName { get; set; }

		// @property (nonatomic, strong) NSString * lastName;
		[Export("lastName", ArgumentSemantic.Strong)]
		string LastName { get; set; }

		// @property (nonatomic, strong) NSString * businessName;
		[Export("businessName", ArgumentSemantic.Strong)]
		string BusinessName { get; set; }

		// @property (nonatomic, strong) NSString * phoneNumber;
		[Export("phoneNumber", ArgumentSemantic.Strong)]
		string PhoneNumber { get; set; }

		// @property (nonatomic, strong) NSString * faxNumber;
		[Export("faxNumber", ArgumentSemantic.Strong)]
		string FaxNumber { get; set; }

		// @property (nonatomic, strong) NSString * website;
		[Export("website", ArgumentSemantic.Strong)]
		string Website { get; set; }

		// @property (nonatomic, strong) NSString * customValue;
		[Export("customValue", ArgumentSemantic.Strong)]
		string CustomValue { get; set; }

		// @property (nonatomic, strong) NSString * city;
		[Export("city", ArgumentSemantic.Strong)]
		string City { get; set; }

		// @property (nonatomic, strong) NSString * countryCode;
		[Export("countryCode", ArgumentSemantic.Strong)]
		string CountryCode { get; set; }

		// @property (nonatomic, strong) NSString * lineOne;
		[Export("lineOne", ArgumentSemantic.Strong)]
		string LineOne { get; set; }

		// @property (nonatomic, strong) NSString * lineTwo;
		[Export("lineTwo", ArgumentSemantic.Strong)]
		string LineTwo { get; set; }

		// @property (nonatomic, strong) NSString * postalCode;
		[Export("postalCode", ArgumentSemantic.Strong)]
		string PostalCode { get; set; }

		// @property (nonatomic, strong) NSString * taxId;
		[Export("taxId", ArgumentSemantic.Strong)]
		string TaxId { get; set; }

		// @property (nonatomic, strong) NSString * state;
		[Export("state", ArgumentSemantic.Strong)]
		string State { get; set; }

		// -(id)initWithCountryCode:(NSString *)countryCode city:(NSString *)city addressLineOne:(NSString *)lineOne;
		[Export("initWithCountryCode:city:addressLineOne:")]
		IntPtr Constructor(string countryCode, string city, string lineOne);

		// -(BOOL)isValidInfo;
		[Export("isValidInfo")]
		bool IsValidInfo { get; }

		// -(NSDictionary *)asDictionary;
		[Export("asDictionary")]
		NSDictionary AsDictionary();

		// -(id)initWithDictionary:(NSDictionary *)representation;
		[Export("initWithDictionary:")]
		IntPtr Constructor(NSDictionary representation);
	}

	// @interface PPHInvoiceItemContext : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHInvoiceItemContext
	{
	}

	// @interface PPHInvoice : NSObject <PPHInvoiceProtocol>
	[BaseType(typeof(NSObject))]
	interface PPHInvoice : PPHInvoiceProtocol
	{
		// +(void)downloadInvoiceForInvoiceId:(NSString *)invoiceId context:(PPHInvoiceItemContext *)context completionHandler:(PPHInvoiceLoadCompletionHandler)completionHandler;
		[Static]
		[Export("downloadInvoiceForInvoiceId:context:completionHandler:")]
		void DownloadInvoiceForInvoiceId(string invoiceId, PPHInvoiceItemContext context, PPHInvoiceLoadCompletionHandler completionHandler);

		// +(void)downloadInvoiceForMerchantReferenceNumber:(NSString *)referenceNumber context:(PPHInvoiceItemContext *)context completionHandler:(PPHInvoiceLoadCompletionHandler)completionHandler;
		[Static]
		[Export("downloadInvoiceForMerchantReferenceNumber:context:completionHandler:")]
		void DownloadInvoiceForMerchantReferenceNumber(string referenceNumber, PPHInvoiceItemContext context, PPHInvoiceLoadCompletionHandler completionHandler);

		// -(id)initWithCurrency:(NSString *)currency;
		[Export("initWithCurrency:")]
		IntPtr Constructor(string currency);

		// -(id)initWithDictionary:(NSDictionary *)representation;
		[Export("initWithDictionary:")]
		IntPtr Constructor(NSDictionary representation);

		// -(id)initWithDictionary:(NSDictionary *)representation context:(PPHInvoiceItemContext *)context;
		[Export("initWithDictionary:context:")]
		IntPtr Constructor(NSDictionary representation, PPHInvoiceItemContext context);

		// -(id)initWithDictionary:(NSDictionary *)representation invoiceId:(NSString *)invoiceId context:(PPHInvoiceItemContext *)context;
		[Export("initWithDictionary:invoiceId:context:")]
		IntPtr Constructor(NSDictionary representation, string invoiceId, PPHInvoiceItemContext context);

		// -(id)initWithItem:(NSString *)item forAmount:(PPHAmount *)amount;
		[Export("initWithItem:forAmount:")]
		IntPtr Constructor(string item, PPHAmount amount);

		// -(instancetype)copyAsTemplate;
		[Export("copyAsTemplate")]
		PPHInvoice CopyAsTemplate();

		// -(NSDictionary *)asDictionary;
		[Export("asDictionary")]
		NSDictionary AsDictionary();

		// -(void)readDictionary:(NSDictionary *)dictionary;
		[Export("readDictionary:")]
		void ReadDictionary(NSDictionary dictionary);

		// @property (nonatomic, strong) NSDecimalNumber * discountAmount;
		[Export("discountAmount", ArgumentSemantic.Strong)]
		NSDecimalNumber DiscountAmount { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * discountPercentage;
		[Export("discountPercentage", ArgumentSemantic.Strong)]
		NSDecimalNumber DiscountPercentage { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * gratuity;
		[Export("gratuity", ArgumentSemantic.Strong)]
		NSDecimalNumber Gratuity { get; set; }

		// @property (copy, nonatomic) NSString * paymentTerms;
		[Export("paymentTerms")]
		string PaymentTerms { get; set; }

		// @property (nonatomic, strong) NSDate * dueDate;
		[Export("dueDate", ArgumentSemantic.Strong)]
		NSDate DueDate { get; set; }

		// @property (copy, nonatomic) NSString * payerEmail;
		[Export("payerEmail")]
		string PayerEmail { get; set; }

		// @property (readonly, nonatomic, strong) PPHInvoiceContactInfo * billingInfo;
		[Export("billingInfo", ArgumentSemantic.Strong)]
		PPHInvoiceContactInfo BillingInfo { get; }

		// @property (readonly, nonatomic, strong) PPHInvoiceContactInfo * shippingInfo;
		[Export("shippingInfo", ArgumentSemantic.Strong)]
		PPHInvoiceContactInfo ShippingInfo { get; }

		// @property (nonatomic, strong) NSDecimalNumber * shippingAmount;
		[Export("shippingAmount", ArgumentSemantic.Strong)]
		NSDecimalNumber ShippingAmount { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * shippingTaxRate;
		[Export("shippingTaxRate", ArgumentSemantic.Strong)]
		NSDecimalNumber ShippingTaxRate { get; set; }

		// @property (copy, nonatomic) NSString * shippingTaxRateName;
		[Export("shippingTaxRateName")]
		string ShippingTaxRateName { get; set; }

		// @property (nonatomic) BOOL taxInclusive;
		[Export("taxInclusive")]
		bool TaxInclusive { get; set; }

		// @property (nonatomic) BOOL taxCalculatedAfterDiscount;
		[Export("taxCalculatedAfterDiscount")]
		bool TaxCalculatedAfterDiscount { get; set; }

		// @property (copy, nonatomic) NSString * customAmountName;
		[Export("customAmountName")]
		string CustomAmountName { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * customAmountValue;
		[Export("customAmountValue", ArgumentSemantic.Strong)]
		NSDecimalNumber CustomAmountValue { get; set; }

		// @property (copy, nonatomic) NSString * referrerCode;
		[Export("referrerCode")]
		string ReferrerCode { get; set; }

		// @property (copy, nonatomic) NSString * cashierId;
		[Export("cashierId")]
		string CashierId { get; set; }

		// @property (readonly, copy, nonatomic) NSString * currency;
		[Export("currency")]
		string Currency { get; }

		// @property (readonly, nonatomic) NSString * paypalInvoiceId;
		[Export("paypalInvoiceId")]
		string PaypalInvoiceId { get; }

		// @property (readonly, nonatomic) NSDate * createDate;
		[Export("createDate")]
		NSDate CreateDate { get; }

		// @property (nonatomic, strong) NSString * merchantReferenceNumber;
		[Export("merchantReferenceNumber", ArgumentSemantic.Strong)]
		string MerchantReferenceNumber { get; set; }

		// @property (readonly, nonatomic) NSString * merchantMemo;
		[Export("merchantMemo")]
		string MerchantMemo { get; }

		// @property (nonatomic, strong) PPHInvoicePayment * paymentInfo;
		[Export("paymentInfo", ArgumentSemantic.Strong)]
		PPHInvoicePayment PaymentInfo { get; set; }

		// @property (readonly, nonatomic) NSArray * refunds;
		[Export("refunds")]
		NSObject[] Refunds { get; }

		// @property (readonly, nonatomic) PPHInvoiceStatus status;
		[Export("status")]
		PPHInvoiceStatus Status { get; }

		// @property (readonly, nonatomic) BOOL originatedOnWeb;
		[Export("originatedOnWeb")]
		bool OriginatedOnWeb { get; }

		// @property (copy, nonatomic) NSString * terms;
		[Export("terms")]
		string Terms { get; set; }

		// @property (copy, nonatomic) NSString * customReceiptText;
		[Export("customReceiptText")]
		string CustomReceiptText { get; set; }

		// @property (readonly, nonatomic, strong) PPHInvoiceTotals * totals;
		[Export("totals", ArgumentSemantic.Strong)]
		PPHInvoiceTotals Totals { get; }

		// @property (readonly, nonatomic) PPHAmount * totalAmount;
		[Export("totalAmount")]
		PPHAmount TotalAmount { get; }

		// @property (readonly, nonatomic) NSDecimalNumber * subTotal;
		[Export("subTotal")]
		NSDecimalNumber SubTotal { get; }

		// @property (readonly, nonatomic) NSDecimalNumber * tax;
		[Export("tax")]
		NSDecimalNumber Tax { get; }

		// @property (readonly, nonatomic) NSDecimalNumber * subTotalWithDiscounts;
		[Export("subTotalWithDiscounts")]
		NSDecimalNumber SubTotalWithDiscounts { get; }

		// @property (readonly, nonatomic) NSDecimalNumber * totalDiscount;
		[Export("totalDiscount")]
		NSDecimalNumber TotalDiscount { get; }

		// @property (readonly, nonatomic) NSDecimalNumber * refundTotal;
		[Export("refundTotal")]
		NSDecimalNumber RefundTotal { get; }

		// @property (readonly, nonatomic) NSDecimalNumber * totalFees;
		[Export("totalFees")]
		NSDecimalNumber TotalFees { get; }

		// @property (readonly, nonatomic) NSDictionary * taxDetails;
		[Export("taxDetails")]
		NSDictionary TaxDetails { get; }

		// @property (readonly, nonatomic) PPHAmount * totalWithRefunds;
		[Export("totalWithRefunds")]
		PPHAmount TotalWithRefunds { get; }

		// @property (readonly, nonatomic) NSArray * items;
		[Export("items")]
		NSObject[] Items { get; }

		// @property (readonly, nonatomic) int itemCount;
		[Export("itemCount")]
		int ItemCount { get; }

		// -(NSDecimalNumber *)quantityByItemId:(NSString *)itemId;
		[Export("quantityByItemId:")]
		NSDecimalNumber QuantityByItemId(string itemId);

		// @property (copy, nonatomic) NSString * receiptPhoneNumber;
		[Export("receiptPhoneNumber")]
		string ReceiptPhoneNumber { get; set; }

		// @property (copy, nonatomic) NSString * receiptEmailAddress;
		[Export("receiptEmailAddress")]
		string ReceiptEmailAddress { get; set; }

		// @property (copy, nonatomic) NSString * note;
		[Export("note")]
		string Note { get; set; }

		// -(PPHInvoiceItem *)invoiceItemWithId:(NSString *)itemId;
		[Export("invoiceItemWithId:")]
		PPHInvoiceItem InvoiceItemWithId(string itemId);

		// -(PPHInvoiceItem *)invoiceItemWithId:(NSString *)itemId detailId:(NSString *)detailId;
		[Export("invoiceItemWithId:detailId:")]
		PPHInvoiceItem InvoiceItemWithId(string itemId, string detailId);

		// -(PPHInvoiceItem *)addItemWithId:(NSString *)itemId name:(NSString *)name quantity:(NSDecimalNumber *)quantity unitPrice:(NSDecimalNumber *)unitPrice taxRate:(NSDecimalNumber *)taxRate taxRateName:(NSString *)taxRateName;
		[Export("addItemWithId:name:quantity:unitPrice:taxRate:taxRateName:")]
		PPHInvoiceItem AddItemWithId(string itemId, string name, NSDecimalNumber quantity, NSDecimalNumber unitPrice, NSDecimalNumber taxRate, string taxRateName);

		// -(PPHInvoiceItem *)addItemWithId:(NSString *)itemId detailId:(NSString *)detailId name:(NSString *)name quantity:(NSDecimalNumber *)quantity unitPrice:(NSDecimalNumber *)unitPrice taxRate:(NSDecimalNumber *)taxRate taxRateName:(NSString *)taxRateName;
		[Export("addItemWithId:detailId:name:quantity:unitPrice:taxRate:taxRateName:")]
		PPHInvoiceItem AddItemWithId(string itemId, string detailId, string name, NSDecimalNumber quantity, NSDecimalNumber unitPrice, NSDecimalNumber taxRate, string taxRateName);

		// -(void)incrementInvoiceItem:(PPHInvoiceItem *)item byQuantity:(NSDecimalNumber *)quantity;
		[Export("incrementInvoiceItem:byQuantity:")]
		void IncrementInvoiceItem(PPHInvoiceItem item, NSDecimalNumber quantity);

		// -(void)removeAllItems;
		[Export("removeAllItems")]
		void RemoveAllItems();

		// -(void)refreshInvoice:(PPHInvoiceBasicCompletionHandler)completionHandler;
		[Export("refreshInvoice:")]
		void RefreshInvoice(PPHInvoiceBasicCompletionHandler completionHandler);

		// -(void)save:(PPHInvoiceBasicCompletionHandler)completionHandler;
		[Export("save:")]
		void Save(PPHInvoiceBasicCompletionHandler completionHandler);

		// -(void)send:(PPHInvoiceBasicCompletionHandler)completionHandler;
		[Export("send:")]
		void Send(PPHInvoiceBasicCompletionHandler completionHandler);

		// -(void)cancel:(PPHInvoiceBasicCompletionHandler)completionHandler;
		[Export("cancel:")]
		void Cancel(PPHInvoiceBasicCompletionHandler completionHandler);

		// -(void)getRefundDetails:(PPHInvoiceBasicCompletionHandler)completionHandler;
		[Export("getRefundDetails:")]
		void GetRefundDetails(PPHInvoiceBasicCompletionHandler completionHandler);

		// -(void)deleteInvoice:(PPHInvoiceBasicCompletionHandler)completionHandler;
		[Export("deleteInvoice:")]
		void DeleteInvoice(PPHInvoiceBasicCompletionHandler completionHandler);
	}

	// @interface PPHLocationCheckin : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHLocationCheckin
	{
		// @property (readonly, nonatomic, strong) NSString * checkinId;
		[Export("checkinId", ArgumentSemantic.Strong)]
		string CheckinId { get; }

		// @property (readonly, nonatomic, strong) NSString * customerId;
		[Export("customerId", ArgumentSemantic.Strong)]
		string CustomerId { get; }

		// @property (readonly, nonatomic, strong) NSString * customerName;
		[Export("customerName", ArgumentSemantic.Strong)]
		string CustomerName { get; }

		// @property (readonly, nonatomic, strong) NSDate * createDate;
		[Export("createDate", ArgumentSemantic.Strong)]
		NSDate CreateDate { get; }

		// @property (readonly, nonatomic, strong) NSDate * updateDate;
		[Export("updateDate", ArgumentSemantic.Strong)]
		NSDate UpdateDate { get; }

		// @property (readonly, nonatomic, strong) NSDate * expirationDate;
		[Export("expirationDate", ArgumentSemantic.Strong)]
		NSDate ExpirationDate { get; }

		// @property (readonly, nonatomic, strong) NSURL * photoUrl;
		[Export("photoUrl", ArgumentSemantic.Strong)]
		NSUrl PhotoUrl { get; }

		// @property (readonly, nonatomic) PPHLocationCheckinStatus status;
		[Export("status")]
		PPHLocationCheckinStatus Status { get; }

		// @property (nonatomic, strong) PPHAmount * gratuityAmount;
		[Export("gratuityAmount", ArgumentSemantic.Strong)]
		PPHAmount GratuityAmount { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * gratuityPercentage;
		[Export("gratuityPercentage", ArgumentSemantic.Strong)]
		NSDecimalNumber GratuityPercentage { get; set; }
	}

	// @protocol PPHTransactionControllerDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface PPHTransactionControllerDelegate
	{
		// @required -(void)userDidSelectPaymentMethod:(PPHPaymentMethod)paymentOption;
		[Abstract]
		[Export("userDidSelectPaymentMethod:")]
		void UserDidSelectPaymentMethod(PPHPaymentMethod paymentOption);

		// @required -(void)userDidSelectRefundMethod:(PPHPaymentMethod)refundOption;
		[Abstract]
		[Export("userDidSelectRefundMethod:")]
		void UserDidSelectRefundMethod(PPHPaymentMethod refundOption);

		// @required -(UINavigationController *)getCurrentNavigationController;
		[Abstract]
		[Export("getCurrentNavigationController")]
		UINavigationController CurrentNavigationController { get; }

		// @optional -(NSArray *)getReceiptOptions;
		[Export("getReceiptOptions")]
		NSObject[] ReceiptOptions { get; }

		// @optional -(void)receiptOptionsWillAppearForRecord:(PPHTransactionRecord *)record;
		[Export("receiptOptionsWillAppearForRecord:")]
		void ReceiptOptionsWillAppearForRecord(PPHTransactionRecord record);

		// @optional -(PPHContactlessTimeoutAction)contactlessTimeoutAction;
		[Export("contactlessTimeoutAction")]
		PPHContactlessTimeoutAction ContactlessTimeoutAction();

		// @optional -(void)userAddedGratuityToInvoice:(PPHInvoice *)invoice;
		[Export("userAddedGratuityToInvoice:")]
		void UserAddedGratuityToInvoice(PPHInvoice invoice);

		// @optional -(void)readerDidActivateForPayments;
		[Export("readerDidActivateForPayments")]
		void ReaderDidActivateForPayments();

		// @optional -(void)readerDidDeactivateForPayments;
		[Export("readerDidDeactivateForPayments")]
		void ReaderDidDeactivateForPayments();
	}

	// @interface PPHTransactionManagerEvent : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHTransactionManagerEvent
	{
		// @property (nonatomic) PPHTransactionEventType eventType;
		[Export("eventType", ArgumentSemantic.Assign)]
		PPHTransactionEventType EventType { get; set; }

		// @property (nonatomic, strong) PPHCardReaderMetadata * reader;
		[Export("reader", ArgumentSemantic.Strong)]
		PPHCardReaderMetadata Reader { get; set; }
	}

	// @protocol PPHTransactionManagerDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface PPHTransactionManagerDelegate
	{
		// @required -(void)onPaymentEvent:(PPHTransactionManagerEvent *)event;
		[Abstract]
		[Export("onPaymentEvent:")]
		void OnPaymentEvent(PPHTransactionManagerEvent paymentEvent);
	}

	// @interface PPHError : NSError
	[BaseType(typeof(NSError))]
	interface PPHError
	{
		// +(NSArray *)recentErrors;
		[Static]
		[Export("recentErrors")]
		NSObject[] RecentErrors { get; }

		// +(PPHError *)pphErrorWithNSError:(NSError *)error;
		[Static]
		[Export("pphErrorWithNSError:")]
		PPHError PphErrorWithNSError(NSError error);

		// +(instancetype)errorWithDomain:(NSString *)domain code:(NSInteger)code devMessage:(NSString *)devMessage;
		[Static]
		[Export("errorWithDomain:code:devMessage:")]
		PPHError ErrorWithDomain(string domain, nint code, string devMessage);

		// +(instancetype)errorWithDomain:(NSString *)domain code:(NSInteger)code devMessage:(NSString *)devMessage userMessage:(NSString *)userMessage;
		[Static]
		[Export("errorWithDomain:code:devMessage:userMessage:")]
		PPHError ErrorWithDomain(string domain, nint code, string devMessage, string userMessage);

		// -(instancetype)initWithDomain:(NSString *)domain code:(NSInteger)code devMessage:(NSString *)devMessage userMessage:(NSString *)userMessage userInfo:(NSDictionary *)userInfo __attribute__((objc_designated_initializer));
		[Export("initWithDomain:code:devMessage:userMessage:userInfo:")]
		[DesignatedInitializer]
		IntPtr Constructor(string domain, nint code, string devMessage, string userMessage, NSDictionary userInfo);

		// -(NSString *)apiMessage;
		[Export("apiMessage")]
		string ApiMessage { get; }

		// -(NSString *)apiShortMessage;
		[Export("apiShortMessage")]
		string ApiShortMessage { get; }

		// -(NSString *)mappedMessage;
		[Export("mappedMessage")]
		string MappedMessage { get; }

		// -(NSArray *)parameter;
		[Export("parameter")]
		NSObject[] Parameter { get; }

		// -(NSString *)correlationId;
		[Export("correlationId")]
		string CorrelationId { get; }

		// -(NSDate *)date;
		[Export("date")]
		NSDate Date { get; }

		// -(NSString *)devMessage;
		[Export("devMessage")]
		string DevMessage { get; }

		// -(BOOL)isCancelError;
		[Export("isCancelError")]
		bool IsCancelError { get; }

		// -(BOOL)isTimeoutError;
		[Export("isTimeoutError")]
		bool IsTimeoutError { get; }

		// -(NSDictionary *)asDictionary;
		[Export("asDictionary")]
		NSDictionary AsDictionary { get; }
	}

	// @interface PPHTransactionResponse : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHTransactionResponse
	{
		// @property (nonatomic, strong) PPHError * error;
		[Export("error", ArgumentSemantic.Strong)]
		PPHError Error { get; set; }

		// @property (nonatomic, strong) PPHTransactionRecord * record;
		[Export("record", ArgumentSemantic.Strong)]
		PPHTransactionRecord Record { get; set; }

		// @property (assign, nonatomic) BOOL isSignatureRequiredToFinalize;
		[Export("isSignatureRequiredToFinalize")]
		bool IsSignatureRequiredToFinalize { get; set; }
	}

	// typedef void (^PPHTransactionCompletionHandler)(PPHTransactionResponse *);
	delegate void PPHTransactionCompletionHandler(PPHTransactionResponse arg0);

	// typedef void (^PPHReceiptCompletionHandler)(PPHTransactionRecord *);
	delegate void PPHReceiptCompletionHandler(PPHTransactionRecord arg0);

	// @interface PPHTransactionManager : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHTransactionManager
	{
		// @property (nonatomic, strong) PPHInvoice * currentInvoice;
		[Export("currentInvoice", ArgumentSemantic.Strong)]
		PPHInvoice CurrentInvoice { get; set; }

		// @property (nonatomic, strong) PPHCardSwipeData * encryptedCardData;
		[Export("encryptedCardData", ArgumentSemantic.Strong)]
		PPHCardSwipeData EncryptedCardData { get; set; }

		// @property (nonatomic, strong) PPHCardNotPresentData * manualEntryOrScannedCardData;
		[Export("manualEntryOrScannedCardData", ArgumentSemantic.Strong)]
		PPHCardNotPresentData ManualEntryOrScannedCardData { get; set; }

		// @property (nonatomic, strong) PPHLocationCheckin * checkedInClient;
		[Export("checkedInClient", ArgumentSemantic.Strong)]
		PPHLocationCheckin CheckedInClient { get; set; }

		// @property (readonly, nonatomic) BOOL isProcessingPayment;
		[Export("isProcessingPayment")]
		bool IsProcessingPayment { get; }

		// @property (readonly, nonatomic) BOOL hasActiveTransaction;
		[Export("hasActiveTransaction")]
		bool HasActiveTransaction { get; }

		// @property (assign, nonatomic) BOOL ignoreHardwareReaders;
		[Export("ignoreHardwareReaders")]
		bool IgnoreHardwareReaders { get; set; }

		// -(BOOL)transactionRequiresSignatureForAmount:(PPHAmount *)amountOrNil paymentMethod:(PPHPaymentMethod)paymentMethod;
		[Export("transactionRequiresSignatureForAmount:paymentMethod:")]
		bool TransactionRequiresSignatureForAmount(PPHAmount amountOrNil, PPHPaymentMethod paymentMethod);

		// @property (assign, nonatomic) BOOL requireSignatureWhenApplicable;
		[Export("requireSignatureWhenApplicable")]
		bool RequireSignatureWhenApplicable { get; set; }

		// @property (assign, nonatomic) BOOL shouldPromptForOnReaderTips;
		[Export("shouldPromptForOnReaderTips")]
		bool ShouldPromptForOnReaderTips { get; set; }

		// @property (assign, nonatomic) BOOL usePercentageOnReaderTips;
		[Export("usePercentageOnReaderTips")]
		bool UsePercentageOnReaderTips { get; set; }

		// @property (assign, nonatomic) NSTimeInterval readerSleepDelay;
		//[Export("readerSleepDelay")]
		//double ReaderSleepDelay { get; set; }

		// -(void)beginPayment;
		[Export("beginPayment")]
		void BeginPayment();

		// -(void)beginPaymentWithAmount:(PPHAmount *)amount andName:(NSString *)itemName;
		[Export("beginPaymentWithAmount:andName:")]
		void BeginPaymentWithAmount(PPHAmount amount, string itemName);

		// -(void)beginPaymentWithInvoice:(PPHInvoice *)invoice;
		[Export("beginPaymentWithInvoice:")]
		void BeginPaymentWithInvoice(PPHInvoice invoice);

		// -(PPHError *)cancelPayment;
		[Export("cancelPayment")]
		PPHError CancelPayment();

		// -(void)authorizePaymentWithPaymentType:(PPHPaymentMethod)paymentMethod withCompletionHandler:(PPHTransactionCompletionHandler)completionHandler;
		[Export("authorizePaymentWithPaymentType:withCompletionHandler:")]
		void AuthorizePaymentWithPaymentType(PPHPaymentMethod paymentMethod, PPHTransactionCompletionHandler completionHandler);

		// -(void)voidAuthorization:(PPHTransactionRecord *)authorizedTransactionRecord withCompletionHandler:(PPHTransactionCompletionHandler)completionHandler;
		[Export("voidAuthorization:withCompletionHandler:")]
		void VoidAuthorization(PPHTransactionRecord authorizedTransactionRecord, PPHTransactionCompletionHandler completionHandler);

		// -(void)capturePaymentForAuthorization:(PPHTransactionRecord *)authorizedTransactionRecord withCompletionHandler:(PPHTransactionCompletionHandler)completionHandler;
		[Export("capturePaymentForAuthorization:withCompletionHandler:")]
		void CapturePaymentForAuthorization(PPHTransactionRecord authorizedTransactionRecord, PPHTransactionCompletionHandler completionHandler);

		// -(void)processPaymentWithPaymentType:(PPHPaymentMethod)paymentType withTransactionController:(id<PPHTransactionControllerDelegate>)controller completionHandler:(PPHTransactionCompletionHandler)completionHandler;
		[Export("processPaymentWithPaymentType:withTransactionController:completionHandler:")]
		void ProcessPaymentWithPaymentType(PPHPaymentMethod paymentType, PPHTransactionControllerDelegate controller, PPHTransactionCompletionHandler completionHandler);

		// -(void)provideSignature:(UIImage *)signature forTransaction:(PPHTransactionRecord *)previousTransaction completionHandler:(void (^)(PPHError *))completionHandler;
		[Export("provideSignature:forTransaction:completionHandler:")]
		void ProvideSignature(UIImage signature, PPHTransactionRecord previousTransaction, Action<PPHError> completionHandler);

		// -(void)beginRefund:(PPHTransactionRecord *)previousTransaction forAmount:(PPHAmount *)amountOrNil completionHandler:(PPHTransactionCompletionHandler)completionHandler;
		[Export("beginRefund:forAmount:completionHandler:")]
		void BeginRefund(PPHTransactionRecord previousTransaction, PPHAmount amountOrNil, PPHTransactionCompletionHandler completionHandler);

		// -(void)sendReceipt:(PPHTransactionRecord *)previousTransaction toRecipient:(PPHReceiptDestination *)destination completionHandler:(PPHInvoiceBasicCompletionHandler)completionHandler;
		[Export("sendReceipt:toRecipient:completionHandler:")]
		void SendReceipt(PPHTransactionRecord previousTransaction, PPHReceiptDestination destination, PPHInvoiceBasicCompletionHandler completionHandler);

		// -(BOOL)activateReaderForPayments:(PPHError **)error;
		[Export("activateReaderForPayments:")]
		bool ActivateReaderForPayments(out PPHError error);

		// -(void)deActivateReaderForPayments;
		[Export("deActivateReaderForPayments")]
		void DeActivateReaderForPayments();
	}

	// @interface EMV (PPHTransactionManager)
	[Category]
	[BaseType(typeof(PPHTransactionManager))]
	interface PPHTransactionManager_EMV
	{
		// -(void)beginPaymentUsingUIWithInvoice:(PPHInvoice *)invoice transactionController:(id<PPHTransactionControllerDelegate>)controller;
		[Export("beginPaymentUsingUIWithInvoice:transactionController:")]
		void BeginPaymentUsingUIWithInvoice(PPHInvoice invoice, PPHTransactionControllerDelegate controller);

		// -(void)processPaymentUsingUIWithPaymentType:(PPHPaymentMethod)paymentType completionHandler:(PPHTransactionCompletionHandler)completionHandler;
		[Export("processPaymentUsingUIWithPaymentType:completionHandler:")]
		void ProcessPaymentUsingUIWithPaymentType(PPHPaymentMethod paymentType, PPHTransactionCompletionHandler completionHandler);

		// -(void)beginRefundUsingUIWithInvoice:(PPHInvoice *)invoice transactionController:(id<PPHTransactionControllerDelegate>)controller;
		[Export("beginRefundUsingUIWithInvoice:transactionController:")]
		void BeginRefundUsingUIWithInvoice(PPHInvoice invoice, PPHTransactionControllerDelegate controller);

		// -(void)processRefundUsingUIWithAmount:(PPHAmount *)amount completionHandler:(PPHTransactionCompletionHandler)completionHandler;
		[Export("processRefundUsingUIWithAmount:completionHandler:")]
		void ProcessRefundUsingUIWithAmount(PPHAmount amount, PPHTransactionCompletionHandler completionHandler);

		// -(void)sendReceiptUsingUIWithTransactionRecord:(PPHTransactionRecord *)record amount:(PPHAmount *)transactionAmount transactionController:(id<PPHTransactionControllerDelegate>)transactionController destination:(PPHReceiptDestination *)destination completionHandler:(PPHReceiptCompletionHandler)completionHandler;
		[Export("sendReceiptUsingUIWithTransactionRecord:amount:transactionController:destination:completionHandler:")]
		void SendReceiptUsingUIWithTransactionRecord(PPHTransactionRecord record, PPHAmount transactionAmount, PPHTransactionControllerDelegate transactionController, PPHReceiptDestination destination, PPHReceiptCompletionHandler completionHandler);
	}

	// @protocol PPHNetworkRequestDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface PPHNetworkRequestDelegate
	{
		// @optional -(BOOL)beginRequest:(NSMutableURLRequest *)inRequest withID:(NSString *)identifier withHandler:(void (^)(NSHTTPURLResponse *, NSError *, NSData *))handler;
		[Export("beginRequest:withID:withHandler:")]
		bool BeginRequest(NSMutableUrlRequest inRequest, string identifier, Action<NSHttpUrlResponse, NSError, NSData> handler);

		// @optional -(void)cancelOperationsForID:(NSString *)identifier;
		[Export("cancelOperationsForID:")]
		void CancelOperationsForID(string identifier);

		// @optional -(void)modifyRequest:(NSMutableURLRequest *)inRequest;
		[Export("modifyRequest:")]
		void ModifyRequest(NSMutableUrlRequest inRequest);

		// @optional -(void)requestCompleted:(NSURLRequest *)inRequest withResponse:(NSHTTPURLResponse *)inResponse data:(NSData *)data andError:(NSError *)error;
		[Export("requestCompleted:withResponse:data:andError:")]
		void RequestCompleted(NSUrlRequest inRequest, NSHttpUrlResponse inResponse, NSData data, NSError error);
	}

	// @protocol PPHAnalyticsDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface PPHAnalyticsDelegate
	{
		// @required -(void)beginSession:(NSDictionary *)properties;
		[Abstract]
		[Export("beginSession:")]
		void BeginSession(NSDictionary properties);

		// @required -(void)amendSession:(NSDictionary *)properties;
		[Abstract]
		[Export("amendSession:")]
		void AmendSession(NSDictionary properties);

		// @required -(void)endSession;
		[Abstract]
		[Export("endSession")]
		void EndSession();

		// @required -(void)queueEvent:(PPHAnalyticsEventName)event withType:(PPHAnalyticsEventType)type andInfo:(NSDictionary *)info;
		[Abstract]
		[Export("queueEvent:withType:andInfo:")]
		void QueueEvent(PPHAnalyticsEventName analyticsEventName, PPHAnalyticsEventType type, NSDictionary info);
	}

	// @protocol PPHLoggingDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface PPHLoggingDelegate
	{
		// @optional -(void)logPayPalHereError:(NSString *)message;
		[Export("logPayPalHereError:")]
		void LogPayPalHereError(string message);

		// @optional -(void)logPayPalHereWarning:(NSString *)message;
		[Export("logPayPalHereWarning:")]
		void LogPayPalHereWarning(string message);

		// @optional -(void)logPayPalHereInfo:(NSString *)message;
		[Export("logPayPalHereInfo:")]
		void LogPayPalHereInfo(string message);

		// @optional -(void)logPayPalHereTrace:(NSString *)message;
		[Export("logPayPalHereTrace:")]
		void LogPayPalHereTrace(string message);

		// @optional -(void)logPayPalHereDebug:(NSString *)message;
		[Export("logPayPalHereDebug:")]
		void LogPayPalHereDebug(string message);

		// @optional -(void)logPayPalHereHardwareError:(NSString *)message;
		[Export("logPayPalHereHardwareError:")]
		void LogPayPalHereHardwareError(string message);

		// @optional -(void)logPayPalHereHardwareWarning:(NSString *)message;
		[Export("logPayPalHereHardwareWarning:")]
		void LogPayPalHereHardwareWarning(string message);

		// @optional -(void)logPayPalHereHardwareInfo:(NSString *)message;
		[Export("logPayPalHereHardwareInfo:")]
		void LogPayPalHereHardwareInfo(string message);

		// @optional -(void)flush;
		[Export("flush")]
		void Flush();
	}

	// typedef void (^PPHInitializationCompletionHandler)(PPHInitResultType, PPHError *, PPHMerchantInfo *);
	delegate void PPHInitializationCompletionHandler(PPHInitResultType arg0, PPHError arg1, PPHMerchantInfo arg2);

	// @interface PayPalHereSDK : NSObject
	[BaseType(typeof(NSObject))]
	interface PayPalHereSDK
	{
		// +(PPHCardReaderManager *)sharedCardReaderManager;
		[Static]
		[Export("sharedCardReaderManager")]
		PPHCardReaderManager SharedCardReaderManager { get; }

		// +(PPHLocalManager *)sharedLocalManager;
		[Static]
		[Export("sharedLocalManager")]
		PPHLocalManager SharedLocalManager { get; }

		// +(PPHPaymentProcessor *)sharedPaymentProcessor;
		[Static]
		[Export("sharedPaymentProcessor")]
		PPHPaymentProcessor SharedPaymentProcessor { get; }

		// +(PPHAccessController *)sharedAccessController __attribute__((deprecated("")));
		[Static]
		[Export("sharedAccessController")]
		PPHAccessController SharedAccessController { get; }

		// +(PPHTransactionManager *)sharedTransactionManager;
		[Static]
		[Export("sharedTransactionManager")]
		PPHTransactionManager SharedTransactionManager { get; }

		// +(id<PPHNetworkRequestDelegate>)networkDelegate;
		// +(void)setNetworkDelegate:(id<PPHNetworkRequestDelegate>)delegate;
		[Static]
		[Export("networkDelegate")]
		PPHNetworkRequestDelegate NetworkDelegate { get; set; }

		// +(id<PPHAnalyticsDelegate>)analyticsDelegate;
		// +(void)setAnalyticsDelegate:(id<PPHAnalyticsDelegate>)delegate;
		[Static]
		[Export("analyticsDelegate")]
		PPHAnalyticsDelegate AnalyticsDelegate { get; set; }

		// +(id<PPHLoggingDelegate>)loggingDelegate;
		// +(void)setLoggingDelegate:(id<PPHLoggingDelegate>)delegate;
		[Static]
		[Export("loggingDelegate")]
		PPHLoggingDelegate LoggingDelegate { get; set; }

		// +(PPHMerchantInfo *)activeMerchant;
		[Static]
		[Export("activeMerchant")]
		PPHMerchantInfo ActiveMerchant { get; }

		// +(void)clearActiveMerchant;
		[Static]
		[Export("clearActiveMerchant")]
		void ClearActiveMerchant();

		// +(void)setupWithCredentials:(NSString *)access_token refreshUrl:(NSString *)refresh_url tokenExpiryOrNil:(NSString *)expiry thenCompletionHandler:(PPHInitializationCompletionHandler)completionHandler;
		[Static]
		[Export("setupWithCredentials:refreshUrl:tokenExpiryOrNil:thenCompletionHandler:")]
		void SetupWithCredentials(string access_token, string refresh_url, string expiry, PPHInitializationCompletionHandler completionHandler);

		// +(void)setupWithCompositeTokenString:(NSString *)compositeString thenCompletionHandler:(PPHInitializationCompletionHandler)completionHandler;
		[Static]
		[Export("setupWithCompositeTokenString:thenCompletionHandler:")]
		void SetupWithCompositeTokenString(string compositeString, PPHInitializationCompletionHandler completionHandler);

		// +(void)setActiveMerchant:(PPHMerchantInfo *)merchant withMerchantId:(NSString *)merchantId completionHandler:(PPHAccessCompletionHandler)completionHandler __attribute__((deprecated("")));
		[Static]
		[Export("setActiveMerchant:withMerchantId:completionHandler:")]
		void SetActiveMerchant(PPHMerchantInfo merchant, string merchantId, PPHAccessCompletionHandler completionHandler);

		// +(BOOL)hasLocationAccess;
		[Static]
		[Export("hasLocationAccess")]
		bool HasLocationAccess { get; }

		// +(BOOL)askForLocationAccess;
		[Static]
		[Export("askForLocationAccess")]
		bool AskForLocationAccess { get; }

		// +(void)startWatchingLocation;
		[Static]
		[Export("startWatchingLocation")]
		void StartWatchingLocation();

		// +(void)stopWatchingLocation;
		[Static]
		[Export("stopWatchingLocation")]
		void StopWatchingLocation();

		// +(void)setBaseAPIURL:(NSURL *)url __attribute__((deprecated("")));
		[Static]
		[Export("setBaseAPIURL:")]
		void SetBaseAPIURL(NSUrl url);

		// +(void)selectEnvironmentWithType:(PPHSDKServiceType)serviceType;
		[Static]
		[Export("selectEnvironmentWithType:")]
		void SelectEnvironmentWithType(PPHSDKServiceType serviceType);

		// +(NSString *)sdkVersion;
		[Static]
		[Export("sdkVersion")]
		string SdkVersion { get; }

		// +(NSString *)referrerCode;
		// +(void)setReferrerCode:(NSString *)referrerCode;
		[Static]
		[Export("referrerCode")]
		string ReferrerCode { get; set; }

		// +(NSString *)baseURL;
		[Static]
		[Export("baseURL")]
		string BaseURL();
	}

	// @interface PPHChipAndPinEvent : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHChipAndPinEvent
	{
		// @property (readonly, nonatomic) PPHChipAndPinEventType eventType;
		[Export("eventType")]
		PPHChipAndPinEventType EventType { get; }

		// @property (readonly, nonatomic) PPHCardReaderMetadata * reader;
		[Export("reader")]
		PPHCardReaderMetadata Reader { get; }
	}

	// @interface PPHChipAndPinDecisionEvent : PPHChipAndPinEvent
	[BaseType(typeof(PPHChipAndPinEvent))]
	interface PPHChipAndPinDecisionEvent
	{
		// -(NSInteger)count;
		[Export("count")]
		nint Count { get; }

		// -(NSString *)applicationNameAtIndex:(NSInteger)ix;
		[Export("applicationNameAtIndex:")]
		string ApplicationNameAtIndex(nint ix);

		// -(NSString *)applicationIdAtIndex:(NSInteger)ix;
		[Export("applicationIdAtIndex:")]
		string ApplicationIdAtIndex(nint ix);
	}

	// @interface PPHChipAndPinButtonPressedEvent : PPHChipAndPinEvent
	[BaseType(typeof(PPHChipAndPinEvent))]
	interface PPHChipAndPinButtonPressedEvent
	{
		// @property (readonly, nonatomic) NSInteger digits;
		[Export("digits")]
		nint Digits { get; }

		// @property (readonly, nonatomic) PPHChipAndPinButtonType pressedButton;
		[Export("pressedButton")]
		PPHChipAndPinButtonType PressedButton { get; }
	}

	// @interface PPHChipAndPinWaitingForPinEvent : PPHChipAndPinButtonPressedEvent
	[BaseType(typeof(PPHChipAndPinButtonPressedEvent))]
	interface PPHChipAndPinWaitingForPinEvent
	{
		// @property (readonly, nonatomic) BOOL lastAttempt;
		[Export("lastAttempt")]
		bool LastAttempt { get; }
	}

	// @interface PPHChipAndPinPinIncorrectEvent : PPHChipAndPinEvent
	[BaseType(typeof(PPHChipAndPinEvent))]
	interface PPHChipAndPinPinIncorrectEvent
	{
		// @property (readonly, nonatomic) BOOL lastAttempt;
		[Export("lastAttempt")]
		bool LastAttempt { get; }
	}

	// @interface PPHChipAndPinEventWithEmv : PPHChipAndPinEvent
	[BaseType(typeof(PPHChipAndPinEvent))]
	interface PPHChipAndPinEventWithEmv
	{
		// @property (readonly, nonatomic, strong) NSData * emvData;
		[Export("emvData", ArgumentSemantic.Strong)]
		NSData EmvData { get; }

		// @property (readonly, nonatomic, strong) NSString * terminalId;
		[Export("terminalId", ArgumentSemantic.Strong)]
		string TerminalId { get; }
	}

	// @interface PPHChipAndPinAuthEvent : PPHChipAndPinEventWithEmv
	[BaseType(typeof(PPHChipAndPinEventWithEmv))]
	interface PPHChipAndPinAuthEvent
	{
		// @property (readonly, nonatomic) BOOL pinVerified;
		[Export("pinVerified")]
		bool PinVerified { get; }

		// @property (readonly, nonatomic) BOOL pinPresent;
		[Export("pinPresent")]
		bool PinPresent { get; }

		// @property (readonly, nonatomic) BOOL signatureRequired;
		[Export("signatureRequired")]
		bool SignatureRequired { get; }

		// @property (readonly, nonatomic) NSString * serial;
		[Export("serial")]
		string Serial { get; }
	}

	// @interface PPHChipAndPinCancelEvent : PPHChipAndPinEvent
	[BaseType(typeof(PPHChipAndPinEvent))]
	interface PPHChipAndPinCancelEvent
	{
		// @property (readonly, nonatomic) BOOL cardRemoved;
		[Export("cardRemoved")]
		bool CardRemoved { get; }
	}

	// @interface PPHChipAndPinCardChipBrokenEvent : PPHChipAndPinEvent
	[BaseType(typeof(PPHChipAndPinEvent))]
	interface PPHChipAndPinCardChipBrokenEvent
	{
		// @property (readonly, nonatomic) BOOL fallbackEnabled;
		[Export("fallbackEnabled")]
		bool FallbackEnabled { get; }
	}

	// @interface PPHChipAndPinCardTapFailureEvent : PPHChipAndPinEvent
	[BaseType(typeof(PPHChipAndPinEvent))]
	interface PPHChipAndPinCardTapFailureEvent
	{
		// @property (readonly, nonatomic) PPHCardTapError tapError;
		[Export("tapError")]
		PPHCardTapError TapError { get; }
	}

	// @interface PPHChipAndPinCardTappedEvent : PPHChipAndPinEvent
	[BaseType(typeof(PPHChipAndPinEvent))]
	interface PPHChipAndPinCardTappedEvent
	{
		// @property (assign, nonatomic) PPHContactlessTransactionType tapType;
		[Export("tapType", ArgumentSemantic.Assign)]
		PPHContactlessTransactionType TapType { get; set; }
	}

	// @interface PPHChipAndPinNumericEntryEvent : PPHChipAndPinEvent
	[BaseType(typeof(PPHChipAndPinEvent))]
	interface PPHChipAndPinNumericEntryEvent
	{
		// @property (readonly, nonatomic) NSDecimalNumber * number;
		[Export("number")]
		NSDecimalNumber Number { get; }
	}

	// @interface PPHInvoiceFormatterData : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHInvoiceFormatterData
	{
		// @property (assign, nonatomic) PPHPrinterFormat format;
		[Export("format", ArgumentSemantic.Assign)]
		PPHPrinterFormat Format { get; set; }

		// @property (assign, nonatomic) NSUInteger lineWidth;
		[Export("lineWidth")]
		nuint LineWidth { get; set; }

		// @property (assign, nonatomic) PPHInvoiceReceiptType receiptType;
		[Export("receiptType", ArgumentSemantic.Assign)]
		PPHInvoiceReceiptType ReceiptType { get; set; }

		// @property (assign, nonatomic) PPHTransactionStatus txnStatus;
		[Export("txnStatus", ArgumentSemantic.Assign)]
		PPHTransactionStatus TxnStatus { get; set; }

		// @property (nonatomic, strong) NSString * returnPolicy;
		[Export("returnPolicy", ArgumentSemantic.Strong)]
		string ReturnPolicy { get; set; }

		// @property (nonatomic, strong) NSString * footerText;
		[Export("footerText", ArgumentSemantic.Strong)]
		string FooterText { get; set; }

		// -(id)initWithFormat:(PPHPrinterFormat)format lineWidth:(NSUInteger)lineWidth receiptType:(PPHInvoiceReceiptType)receiptType txnStatus:(PPHTransactionStatus)txnStatus returnPolicy:(NSString *)returnPolicy footerText:(NSString *)footerText;
		[Export("initWithFormat:lineWidth:receiptType:txnStatus:returnPolicy:footerText:")]
		IntPtr Constructor(PPHPrinterFormat format, nuint lineWidth, PPHInvoiceReceiptType receiptType, PPHTransactionStatus txnStatus, string returnPolicy, string footerText);
	}

	// @interface PPHInvoiceFormatter : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHInvoiceFormatter
	{
		// -(NSString *)formattedStringForInvoice:(PPHInvoice *)invoice withFormatData:(PPHInvoiceFormatterData *)data;
		[Export("formattedStringForInvoice:withFormatData:")]
		string FormattedStringForInvoice(PPHInvoice invoice, PPHInvoiceFormatterData data);

		// -(NSString *)formattedStringForInvoice:(PPHInvoice *)invoice;
		[Export("formattedStringForInvoice:")]
		string FormattedStringForInvoice(PPHInvoice invoice);

		// -(UIImage *)formattedImageForInvoice:(PPHInvoice *)invoice withWidth:(NSInteger)widthInPixels;
		[Export("formattedImageForInvoice:withWidth:")]
		UIImage FormattedImageForInvoice(PPHInvoice invoice, nint widthInPixels);
	}

	// @interface PPHMerchantInfo : NSObject <NSCoding>
	[BaseType(typeof(NSObject))]
	interface PPHMerchantInfo : INSCoding
	{
		// @property (nonatomic, strong) NSURL * invoiceLogoUrl;
		[Export("invoiceLogoUrl", ArgumentSemantic.Strong)]
		NSUrl InvoiceLogoUrl { get; set; }

		// @property (nonatomic, strong) PPHInvoiceContactInfo * invoiceContactInfo;
		[Export("invoiceContactInfo", ArgumentSemantic.Strong)]
		PPHInvoiceContactInfo InvoiceContactInfo { get; set; }

		// @property (nonatomic, strong) NSString * currencyCode;
		[Export("currencyCode", ArgumentSemantic.Strong)]
		string CurrencyCode { get; set; }

		// @property (nonatomic, strong) NSString * taxId;
		[Export("taxId", ArgumentSemantic.Strong)]
		string TaxId { get; set; }

		// @property (nonatomic, strong) PPHAccessAccount * payPalAccount;
		[Export("payPalAccount", ArgumentSemantic.Strong)]
		PPHAccessAccount PayPalAccount { get; set; }

		// @property (nonatomic, strong) NSString * terms;
		[Export("terms", ArgumentSemantic.Strong)]
		string Terms { get; set; }

		// @property (nonatomic, strong) NSString * customReceiptText;
		[Export("customReceiptText", ArgumentSemantic.Strong)]
		string CustomReceiptText { get; set; }

		// -(void)saveMerchantPreferencesWithTaxID:(NSString *)taxID ccStatementName:(NSString *)ccStatementName completionHandler:(void (^)(BOOL))completionHandler;
		[Export("saveMerchantPreferencesWithTaxID:ccStatementName:completionHandler:")]
		void SaveMerchantPreferencesWithTaxID(string taxID, string ccStatementName, Action<bool> completionHandler);

		// -(void)getMerchantPreferencesWithCompletionHandler:(void (^)(NSString *, NSString *))completionHandler;
		[Export("getMerchantPreferencesWithCompletionHandler:")]
		void GetMerchantPreferencesWithCompletionHandler(Action<NSString, NSString> completionHandler);
	}

	// @interface PPHPaymentLimits : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHPaymentLimits
	{
		// @property (nonatomic, strong) NSDecimalNumber * minimumCardChargeAllowed;
		[Export("minimumCardChargeAllowed", ArgumentSemantic.Strong)]
		NSDecimalNumber MinimumCardChargeAllowed { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * maximumCardChargeAllowed;
		[Export("maximumCardChargeAllowed", ArgumentSemantic.Strong)]
		NSDecimalNumber MaximumCardChargeAllowed { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * signatureRequiredAbove;
		[Export("signatureRequiredAbove", ArgumentSemantic.Strong)]
		NSDecimalNumber SignatureRequiredAbove { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * contactlessTransactionLimit;
		[Export("contactlessTransactionLimit", ArgumentSemantic.Strong)]
		NSDecimalNumber ContactlessTransactionLimit { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * captureTolerance;
		[Export("captureTolerance", ArgumentSemantic.Strong)]
		NSDecimalNumber CaptureTolerance { get; set; }
	}

	// typedef void (^PPHReceiptOptionBlock)(PPHTransactionRecord *, UIView *);
	delegate void PPHReceiptOptionBlock(PPHTransactionRecord arg0, UIView arg1);

	// typedef BOOL (^PPHReceiptOptionPredicateBlock)(PPHTransactionRecord *);
	delegate bool PPHReceiptOptionPredicateBlock(PPHTransactionRecord arg0);

	// @interface PPHReceiptOption : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHReceiptOption
	{
		// -(instancetype)initWithBlock:(PPHReceiptOptionBlock)optionBlock predicate:(PPHReceiptOptionPredicateBlock)shouldShowOption buttonLabel:(NSString *)buttonLabel;
		[Export("initWithBlock:predicate:buttonLabel:")]
		IntPtr Constructor(PPHReceiptOptionBlock optionBlock, PPHReceiptOptionPredicateBlock shouldShowOption, string buttonLabel);

		// @property (copy, nonatomic) NSString * optionButtonLabelText;
		[Export("optionButtonLabelText")]
		string OptionButtonLabelText { get; set; }

		// @property (nonatomic, strong) PPHReceiptOptionBlock optionBlock;
		[Export("optionBlock", ArgumentSemantic.Strong)]
		PPHReceiptOptionBlock OptionBlock { get; set; }

		// @property (nonatomic, strong) PPHReceiptOptionPredicateBlock shouldShowOption;
		[Export("shouldShowOption", ArgumentSemantic.Strong)]
		PPHReceiptOptionPredicateBlock ShouldShowOption { get; set; }
	}

	// @protocol PPHSignatureViewDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface PPHSignatureViewDelegate
	{
		// @required -(void)signatureTouchesBegan;
		[Abstract]
		[Export("signatureTouchesBegan")]
		void SignatureTouchesBegan();

		// @required -(void)signatureUpdated:(BOOL)isEmpty;
		[Abstract]
		[Export("signatureUpdated:")]
		void SignatureUpdated(bool isEmpty);
	}

	// @interface PPHSignatureView : UIView
	[BaseType(typeof(UIView))]
	interface PPHSignatureView
	{
		[Wrap("WeakDelegate")]
		PPHSignatureViewDelegate Delegate { get; set; }

		// @property (unsafe_unretained) id<PPHSignatureViewDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
		NSObject WeakDelegate { get; set; }

		// -(BOOL)isEmptySignature;
		[Export("isEmptySignature")]
		bool IsEmptySignature { get; }

		// -(UIImage *)printableImage;
		[Export("printableImage")]
		UIImage PrintableImage { get; }

		// -(void)clearSignaturePad;
		[Export("clearSignaturePad")]
		void ClearSignaturePad();
	}

	// @interface PPHSDKBaseViewController : UIViewController
	[BaseType(typeof(UIViewController))]
	interface PPHSDKBaseViewController
	{
	}

	// @protocol PPHSignatureViewControllerDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface PPHSignatureViewControllerDelegate
	{
		// @required -(void)takeSignatureViewController:(PPHSignatureViewController *)viewController collectedSignatureImage:(UIImage *)signatureImage;
		[Abstract]
		[Export("takeSignatureViewController:collectedSignatureImage:")]
		void TakeSignatureViewController(PPHSignatureViewController viewController, UIImage signatureImage);

		// @required -(void)takeSignatureViewControllerCanceledCollectingSignature:(PPHSignatureViewController *)viewController;
		[Abstract]
		[Export("takeSignatureViewControllerCanceledCollectingSignature:")]
		void TakeSignatureViewControllerCanceledCollectingSignature(PPHSignatureViewController viewController);
	}

	// @interface PPHSignatureViewController : PPHSDKBaseViewController
	[BaseType(typeof(PPHSDKBaseViewController))]
	interface PPHSignatureViewController
	{
		// +(instancetype)newWithDelegate:(id<PPHSignatureViewControllerDelegate>)delegate forRefund:(BOOL)forRefund amount:(PPHAmount *)amount maskedCardNumber:(NSString *)maskedCardNumber cardType:(PPHCreditCardType)cardType hideCancelButton:(BOOL)hideCancelButton;
		[Static]
		[Export("newWithDelegate:forRefund:amount:maskedCardNumber:cardType:hideCancelButton:")]
		PPHSignatureViewController NewWithDelegate(PPHSignatureViewControllerDelegate signatureViewControllerDelegate, bool forRefund, PPHAmount amount, string maskedCardNumber, PPHCreditCardType cardType, bool hideCancelButton);
	}

	// @interface PPHTokenizedCustomerInformation : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHTokenizedCustomerInformation
	{
		// @property (nonatomic, strong) NSString * customerId;
		[Export("customerId", ArgumentSemantic.Strong)]
		string CustomerId { get; set; }

		// @property (nonatomic, strong) NSString * maskedEmailAddress;
		[Export("maskedEmailAddress", ArgumentSemantic.Strong)]
		string MaskedEmailAddress { get; set; }

		// @property (nonatomic, strong) NSString * maskedMobileNumber;
		[Export("maskedMobileNumber", ArgumentSemantic.Strong)]
		string MaskedMobileNumber { get; set; }

		// @property (nonatomic, strong) NSString * receiptPreferenceToken;
		[Export("receiptPreferenceToken", ArgumentSemantic.Strong)]
		string ReceiptPreferenceToken { get; set; }
	}

	// @interface PPHTransactionWatcher : NSObject
	[BaseType(typeof(NSObject))]
	interface PPHTransactionWatcher
	{
		// -(id)initWithDelegate:(id<PPHTransactionManagerDelegate>)delegate;
		[Export("initWithDelegate:")]
		IntPtr Constructor(PPHTransactionManagerDelegate transactionManagerDelegate);
	}

}

