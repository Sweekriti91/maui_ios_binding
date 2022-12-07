XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
PROJECT=XMBindingLibrary.xcodeproj
TARGET=XMBindingLibrary


all: libXMBindingLibraryUniversal.a


libXMBindingLibrary-x86_64.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -arch x86_64 -configuration Release clean build
	-mv build/Release-iphonesimulator/lib$(TARGET).a $@

libXMBindingLibrary-arm64.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build
	-mv build/Release-iphoneos/lib$(TARGET).a $@

libXMBindingLibraryUniversal.a: libXMBindingLibrary-arm64.a libXMBindingLibrary-x86_64.a
	lipo -create -output $@ $^


clean:
	-rm -rf *.a build/
