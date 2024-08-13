using SmiteLib.Framework;
using StardewModdingAPI;
using System.Text;

namespace Linkoid.Stardew.Tasks.Tests;

[SmiteProcess(@"S:\SteamLibrary\steamapps\common\Stardew Valley\StardewModdingAPI.exe",
	OutputEncoding = nameof(Encoding.Unicode))]
public static class ModTests
{
	public static Mod Mod = null!;

	[SmiteTest]
	public static async Task Test()
	{
		await Mod.Helper.Events.GameLoop.WaitForUpdateTicking();
	}
}
