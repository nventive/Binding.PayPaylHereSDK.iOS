//
//  ManticoreTestAppTests.m
//  ManticoreTestAppTests
//
//  Copyright (c) 2015 PayPal. All rights reserved.
//

#import <Foundation/Foundation.h>

#if TARGET_OS_IPHONE
#import <UIKit/UIKit.h>
#else
#import <Cocoa/Cocoa.h>
#endif

#import <XCTest/XCTest.h>
#import <ManticoreNative/PPManticoreEngine.h>
#import "PPManticoreSDKTestDefault.h"
#import "PPManticoreSDKTestDefaultSubclass.h"
#import "PPManticoreSDKTest.h"
#import "PPManticoreError.h"

@interface ManticoreTests : XCTestCase <
  PPManticorePluginDelegate
>

@property (nonatomic, strong) PPManticoreEngine *engine;
@property (nonatomic, strong) PPManticoreSDKTest *t;
@property (nonatomic, strong) NSMutableString *delegateCalls;

@end

@implementation ManticoreTests

- (void)setUp {
    [super setUp];
    
    self.engine = [PPManticoreEngine new];
    
    NSString *jsPath = [[NSBundle mainBundle] pathForResource:@"index.pack" ofType:@"js"];
    NSString *js = [NSString stringWithContentsOfFile:jsPath encoding:NSUTF8StringEncoding error:nil];
    [self.engine loadScript:js withName:@"index.pack.js"];
    
    [PPManticoreJSBackedObject setManticoreEngine:self.engine];
    
    self.t = [[PPManticoreSDKTest alloc] initWithStringProperty:@"stringProp"];
}

- (void)tearDown {
    self.engine = nil;
    [PPManticoreJSBackedObject setManticoreEngine:nil];
    
    [super tearDown];
}

- (void)verifyDefaultsObject:(PPManticoreSDKTestDefault *)t {
    XCTAssertNotNil(t, @"the defaults object should be non-nil.");
    
    XCTAssertEqual(t.test, 1, @"test should be 1.");
    XCTAssertEqual(t.itsTrue, YES, @"itsTrue should be true.");
    XCTAssertEqual(t.itsFalse, false, @"itsFalse should be true.");
    XCTAssertEqual(t.blankInt, 0, @"blankInt should be 0.");
    XCTAssertEqual(t.intOne, 1, @"intOne should be 1.");
    XCTAssertEqual(t.blankDecimal, nil, @"blankDecimal should be nil.");
    XCTAssertEqualObjects(t.decimalHundredOhOne, [NSDecimalNumber decimalNumberWithString:@"100.01"], @"decimalHundredOhOne should be 100.01.");
    XCTAssertEqual(t.nullString, nil, @"nullString should be nil.");
    XCTAssertTrue(t.isItTrue, @"isItTrue should return true.");
    XCTAssertTrue([t.now isKindOfClass:[NSDate class]], @"now should be an NSDate, but we don't know exactly what date.");
    XCTAssertEqualObjects(t.stringArray, (@[@"a", @"b", @"c"]), @"stringArray, should be ['a', 'b', 'c']");
    
    t.test = 12;
    t.itsTrue = NO;
    t.intOne = 10;
    t.blankDecimal = [NSDecimalNumber decimalNumberWithString:@"12"];
    t.now = [NSDate dateWithTimeIntervalSince1970:0];
    t.stringArray = @[@"d", @"e"];
    
    XCTAssertEqual(t.test, 12, @"test should now be 12.");
    XCTAssertEqual(t.itsTrue, NO, @"itsTrue should now be false.");
    XCTAssertEqual(t.intOne, 10, @"intOne should now be 10.");
    XCTAssertEqualObjects(t.blankDecimal, [NSDecimalNumber decimalNumberWithString:@"12"], @"blankDecimal should now be 12.");
    XCTAssertEqualObjects(t.now, [NSDate dateWithTimeIntervalSince1970:0], @"now should now be 1970");
    XCTAssertEqualObjects(t.stringArray, (@[@"d", @"e"]), @"stringArray should now be ['d', 'e']");
}

- (void)testPlugin {
    PPManticoreEngine *engine = [[PPManticoreEngine alloc] init];
    self.delegateCalls = [NSMutableString new];
    PPManticorePlugin *plugin = [[PPManticorePlugin alloc] initWithDelegate:self forEngine:engine];
    [engine loadScript:@"{}" withName:@"testerscript"];
    [self.engine loadScript:@"{}" withName:@"testerscript"];
    plugin = nil;
    [engine loadScript:@"{}" withName:@"foobar"];
    XCTAssertEqualObjects(@"WILLLOADPOLY,DIDLOADPOLY,WILLLOADSCRIPT,testerscriptDIDLOADSCRIPT,testerscript", self.delegateCalls);
}

-(void)willLoadPolyfill:(PPManticoreEngine *)engine {
    [self.delegateCalls appendString:@"WILLLOADPOLY,"];
}

-(void)didLoadPolyfill:(PPManticoreEngine *)engine {
    [self.delegateCalls appendString:@"DIDLOADPOLY,"];
}

-(void)engine:(PPManticoreEngine *)engine willLoadScript:(NSString *)script withName:(NSString *)name {
    [self.delegateCalls appendString:@"WILLLOADSCRIPT,"];
    [self.delegateCalls appendString:name];
}

-(void)engine:(PPManticoreEngine *)engine didLoadScript:(NSString *)script withName:(NSString *)name {
    [self.delegateCalls appendString:@"DIDLOADSCRIPT,"];
    [self.delegateCalls appendString:name];
}

- (void)testEcho {
    
    __block BOOL didBlockRun = NO;
    __block PPManticoreError *echoError;
    __block NSString *echoArg;
    
    [self.t echo:@"teststring" callback:^(PPManticoreError *error, NSString *arg) {
        didBlockRun = YES;
        echoError = error;
        echoArg = arg;
    }];
    XCTAssertTrue(didBlockRun, @"the echo block should have run.");
    XCTAssertNil(echoError, @"echo shouldn't cause an error.");
    XCTAssertEqualObjects(echoArg, @"teststring", @"echo should echo it's argument");
    
    didBlockRun = NO;
    
    XCTestExpectation *expectEcho = [self expectationWithDescription:@"expect echo"];
    [self.t echoWithSetTimeout:@"teststring2" callback:^(PPManticoreError *error, NSString *arg) {
        didBlockRun = YES;
        echoError = error;
        echoArg = arg;
        [expectEcho fulfill];
    }];
    XCTAssertFalse(didBlockRun, @"the echo block shouldn't have run yet.");
    [self waitForExpectationsWithTimeout:0.2 handler:nil];
    XCTAssertTrue(didBlockRun, @"the echo block should have run.");
    XCTAssertNil(echoError, @"echo shouldn't cause an error.");
    XCTAssertEqualObjects(echoArg, @"teststring2", @"echo should echo it's argument");
}

- (void)testEvents {
    __weak typeof(self) weakSelf = self;
    
    XCTestExpectation *expectSignal = [self expectationWithDescription:@"expect signal"];
    id signal = [self.t addFakeEventListener:^(PPManticoreSDKTestDefault *item) {
        [weakSelf verifyDefaultsObject:item];
        [expectSignal fulfill];
    }];
    [self.t triggerFakeAfterTimeout];
    [self waitForExpectationsWithTimeout:1 handler:nil];
    
    [self.t removeFakeEventListener:signal];
    
    XCTestExpectation *otherExpectSignal = [self expectationWithDescription:@"expect signal"];
    [self.t addFakeEventListener:^(PPManticoreSDKTestDefault *item) {
        [weakSelf verifyDefaultsObject:item];
        dispatch_after(dispatch_time(DISPATCH_TIME_NOW, (int64_t)(0.1 * NSEC_PER_SEC)), dispatch_get_main_queue(), ^{
            [otherExpectSignal fulfill];
        });
    }];
    [self.t triggerFakeAfterTimeout];
    [self waitForExpectationsWithTimeout:0.3 handler:nil];
}

- (void)testReturnAnObject {
    PPManticoreSDKTestDefault *one = [self.t returnAnObject];
    PPManticoreSDKTestDefault *two = [self.t returnAnObject];
    
    XCTAssertNotEqual(one, two);
    
    [self verifyDefaultsObject:one];
    [self verifyDefaultsObject:two];
}

- (void)verifyMixed:(NSDictionary *)mixed {
    XCTAssertEqualObjects(@1.1, mixed[@"aFloat"]);
    XCTAssertEqualObjects(@4, mixed[@"anInt"]);
    XCTAssertEqualObjects(@{}, mixed[@"aMixed"]);
    XCTAssertEqualObjects(@YES, mixed[@"aBool"]);
    XCTAssertEqualObjects(@(1), mixed[@"anObject"][@"itsTrue"]);
    XCTAssertEqualObjects([NSNull null], mixed[@"aNull"]);
    XCTAssertEqualObjects(@"testing", mixed[@"aString"]);
}

- (void)testTakeAndReturnMixed {
    NSDictionary *mixed = [self.t returnAMixedType];
    [self verifyMixed:mixed];
    NSDictionary *otherMixed = [self.t takeAMixedType:mixed];
    [self verifyMixed:otherMixed];
    XCTAssertEqualObjects(mixed, otherMixed);
}

- (void)testException {
    @try {
        [self.t throwOne];
        XCTAssert(NO, @"Expected exception.");
    }
    @catch (NSException *exception) {
        
    }
}

- (void)testDerivedClasses {
    PPManticoreSDKTestDefault *derived = [self.t returnADerivedObject];
    XCTAssert([derived isKindOfClass:[PPManticoreSDKTestDefault class]]);
    XCTAssert([derived isKindOfClass:[PPManticoreSDKTestDefaultSubclass class]]);
    NSArray *derivedArray = [self.t returnBaseAndDerived];
    XCTAssert([derivedArray[0] isKindOfClass:[PPManticoreSDKTestDefault class]]);
    XCTAssert(![derivedArray[0] isKindOfClass:[PPManticoreSDKTestDefaultSubclass class]]);
    XCTAssert([derivedArray[1] isKindOfClass:[PPManticoreSDKTestDefault class]]);
    XCTAssert([derivedArray[1] isKindOfClass:[PPManticoreSDKTestDefaultSubclass class]]);
}

- (void)testStaticMethod {
    PPManticoreSDKTest *t = [PPManticoreSDKTest staticMethod];
    XCTAssertEqualObjects([t class], [PPManticoreSDKTest class], @"staticMethod should return a PPManticoreTestSDKTest instance.");
    [self verifyDefaultsObject:[t returnAnObject]];
}

- (void)testFetch {
    XCTestExpectation *expectSignal = [self expectationWithDescription:@"expect signal"];
    [self.t goFetch:^(PPManticoreError *error, NSDictionary *response) {
        XCTAssertNil(error, @"No error for plain fetch.");
        NSDictionary *args = response[@"args"];
        XCTAssert(args, @"Expected args object");
        XCTAssertEqualObjects(args[@"foo"], @"bar", @"foo should be bar in response");
        [expectSignal fulfill];
    }];
    [self waitForExpectationsWithTimeout:30 handler:nil];
}

- (void)testFetchP {
    XCTestExpectation *expectSignal = [self expectationWithDescription:@"expect signal"];
    [self.t goFetchP:^(PPManticoreError *error, NSDictionary *response) {
        XCTAssertNil(error, @"No error for plain fetch.");
        NSDictionary *args = response[@"args"];
        XCTAssert(args, @"Expected args object");
        XCTAssertEqualObjects(args[@"baz"], @"bop", @"foo should be bar in response");
        [expectSignal fulfill];
    }];
    [self waitForExpectationsWithTimeout:30 handler:nil];
}
@end
