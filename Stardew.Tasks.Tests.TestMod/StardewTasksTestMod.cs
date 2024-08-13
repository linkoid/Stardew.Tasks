using SmiteLib.Injection;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;

namespace Linkoid.Stardew.Tasks.Tests.TestMod;

public sealed class StardewTasksTestMod : Mod
{
	public static StardewTasksTestMod Instance { get; private set; } = null!;
	public static new IModHelper Helper => (Instance as Mod).Helper;
	public static new IMonitor Monitor => (Instance as Mod).Monitor;

	private SmiteInjection smiteInjection = null!;
	
	public override void Entry(IModHelper helper)
	{
		Instance = this;
		ModTests.Mod = this;

		Helper.Events.GameLoop.GameLaunched += OnGameLaunched;
		Helper.Events.GameLoop.UpdateTicked += OnUpdateTicked;

		smiteInjection = new SmiteInjection(typeof(ModTests).Assembly);
	}

	private void OnGameLaunched(object? sender, GameLaunchedEventArgs e)
	{
		smiteInjection.EntryPoint();
	}

	private void OnUpdateTicked(object? sender, UpdateTickedEventArgs e)
	{
		smiteInjection.UpdatePoint();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			smiteInjection.ExitPoint();
		}
	}
}