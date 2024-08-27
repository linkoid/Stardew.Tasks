# Stardew.Tasks
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
