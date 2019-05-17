# BlackAndWhiteConverter
C# application that transforms any picture into fully black-and-white (binary) picture

## To run the app:
- Either open `BlackAndWhiteConverter.sln` file in Visual Studio
- Or go to BlackAndWhiteBinaryConverter/obj/Debug/ and run BlackAndWhiteBinaryConverter.exe

## Usage
- When the app is started, you need to uplad any picture to it
- Then the app will go through each the color of each pixel:
  - if it is lighter that `[128, 128,128]` then the color of this pixel in converted picture will be white
  - else the color of this pixel in converted picture will be white
- Thus the converted picture that is shown constists of only completely white pixels `[255,255,255]` and completely black pixels `[0,0,0]`
  
