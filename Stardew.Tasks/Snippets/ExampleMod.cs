// Copyright (c) 2024 linkoid 
// Linkoid licenses this file to you under the MIT license.
// See the LICENSE file in the project below for more information.
// https://github.com/linkoid/Stardew.Tasks?tab=MIT-1-ov-file

using ContentPatcher;
using StardewModdingAPI;
using StardewValley.Menus;
using System;
using System.Collections.Generic;
using System.Text;
namespace ContentPatcher { internal interface IContentPatcherAPI { void RegisterToken(IManifest mod, string name, Func<IEnumerable<string>?> getValue); } }

#nullable disable

namespace Linkoid.Stardew.Tasks.Snippets
{
    internal class ExampleMod : Mod
    {
        public override async void Entry(IModHelper helper)
        {
            // Log that the mod has been loaded
            this.Monitor.Log("My mod has been loaded!");

            // Wait until all mods have been loaded
            await helper.Events.GameLoop.WaitForGameLaunched(); // Stardew Tasks Extension

            // Get another mod's API
            var contentPatcherApi = helper.ModRegistry.GetApi<IContentPatcherAPI>("Pathoschild.ContentPatcher");

            // Wait for a button press
            var buttonEvent = await helper.Events.Input.WaitForButtonPressed(); // Stardew Tasks Extension

            // Log what the first button pressed was
            string firstButtonName = buttonEvent.Button.ToString();
            this.Monitor.Log($"The first button pressed was '{firstButtonName}'");

            // Create a token that evaluates to the first button pressed
            contentPatcherApi.RegisterToken(this.ModManifest, "FirstButtonPressed", () => new string[] { firstButtonName });
        }
    }
}
