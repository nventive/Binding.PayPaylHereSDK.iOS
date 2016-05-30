using System;
using ObjCRuntime;

[assembly: LinkWith ("PayPalHereSDK.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64 | LinkTarget.Simulator | LinkTarget.Simulator64, ForceLoad = false, SmartLink = true, Frameworks = "AudioToolbox MobileCoreServices Security CFNetwork AVFoundation ExternalAccessory MediaPlayer CoreTelephony Foundation CoreBluetooth SystemConfiguration", LinkerFlags = "-ObjC -stdlib=libstdc++ -lstdc++ -lz -lsqlite3 -lxml2")]

