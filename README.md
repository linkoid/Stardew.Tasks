# Stardew.Tasks

[![Stardew Valley](https://custom-icon-badges.demolab.com/badge/Stardew_Valley-FFD58E.svg?logo=stardewvalley)](https://stardewvalleywiki.com/Stardew_Valley)
[![SMAPI C#](https://custom-icon-badges.demolab.com/badge/SMAPI-C%23-%23239120.svg?logo=smapi)](https://stardewvalleywiki.com/Modding:Modder_Guide/Get_Started)

[![GitHub](https://img.shields.io/badge/GitHub-%23121011.svg?logo=github&logoColor=white)](https://github.com/linkoid/Stardew.Tasks)
[![NuGet](https://img.shields.io/nuget/v/Linkoid.Stardew.Tasks?logo=nuget&logoColor=fff&label=NuGet)](https://www.nuget.org/packages/Linkoid.Stardew.Tasks)
[![License](https://img.shields.io/github/license/linkoid/Stardew.Tasks)](https://github.com/linkoid/Stardew.Tasks?tab=MIT-1-ov-file)

Provides extensions that allow using async methods in Stardew Valley with SMAPI's Event Interfaces.
The NuGet package is provided as source code, meaning that Stardew.Tasks is only required at compile time. This means end-users will not need to download Stardew.Tasks.

## Example
This example shows how some of the extension methods could be used in an async Entry method.
```cs
public override async void Entry(IModHelper helper)
{
    // Log that the mod has been loaded
    this.Monitor.Log("My mod has been loaded!");

    // Wait until all mods have been loaded
    await helper.Events.GameLoop.WaitForGameLaunched(); // Stardew Tasks Extension

    // Get another mod's API
    dynamic contentPatcherApi = helper.ModRegistry.GetApi("Pathoschild.ContentPatcher");

    // Wait for a button press
    var buttonEvent = await helper.Events.Input.WaitForButtonPressed(); // Stardew Tasks Extension

    // Log what the first button pressed was
    string firstButtonName = buttonEvent.Button.ToString();
    this.Monitor.Log($"The first button pressed was '{firstButtonName}'");

    // Create a token that evaluates to the first button pressed
    contentPatcherApi.RegisterToken(this.ModManifest, "FirstButtonPressed", 
        (Func<IEnumerable<string>>)(() => new string[] { firstButtonName }));
}
```
