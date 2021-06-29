ScreenBlank
===

This is a tiny utility written in C# (.NET core 3.1) that will create a full-screen black form on a given screen. I made it because sometimes I want to focus on specific screens, but I can't really turn it off because of the amazing combination of DisplayPort hotplug behaviour and Windows not knowing how to restore monitors after they come back.

To use just run it, select the monitors (might need to play around to figure out which one is which since I don't do anything fancy to resolve their names) and press blank. To close the windows either use the "Exit" button on the main form or alt+f4 out of individual ones.
If you need the run-time, you can find it [here](https://dotnet.microsoft.com/download/dotnet/3.1/runtime).

To build it open it up in Visual Studio. Only thing you need is .NET Core 3.1 libraries.
