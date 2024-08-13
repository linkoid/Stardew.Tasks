

using StardewModdingAPI.Events;
using System;
using System.Threading.Tasks;

namespace Linkoid.Stardew.Tasks;

public static class SMAPIEventExtensions
{
	public static ValueTask<AssetRequestedEventArgs> WaitForAssetRequested(this IContentEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<AssetRequestedEventArgs>(
			new(x => events.AssetRequested += x,
				y => events.AssetRequested -= y),
			timeout
		);
	}
	public static ValueTask<AssetsInvalidatedEventArgs> WaitForAssetsInvalidated(this IContentEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<AssetsInvalidatedEventArgs>(
			new(x => events.AssetsInvalidated += x,
				y => events.AssetsInvalidated -= y),
			timeout
		);
	}
	public static ValueTask<AssetReadyEventArgs> WaitForAssetReady(this IContentEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<AssetReadyEventArgs>(
			new(x => events.AssetReady += x,
				y => events.AssetReady -= y),
			timeout
		);
	}
	public static ValueTask<LocaleChangedEventArgs> WaitForLocaleChanged(this IContentEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<LocaleChangedEventArgs>(
			new(x => events.LocaleChanged += x,
				y => events.LocaleChanged -= y),
			timeout
		);
	}
	public static ValueTask<MenuChangedEventArgs> WaitForMenuChanged(this IDisplayEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<MenuChangedEventArgs>(
			new(x => events.MenuChanged += x,
				y => events.MenuChanged -= y),
			timeout
		);
	}
	public static ValueTask<RenderingStepEventArgs> WaitForRenderingStep(this IDisplayEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<RenderingStepEventArgs>(
			new(x => events.RenderingStep += x,
				y => events.RenderingStep -= y),
			timeout
		);
	}
	public static ValueTask<RenderedStepEventArgs> WaitForRenderedStep(this IDisplayEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<RenderedStepEventArgs>(
			new(x => events.RenderedStep += x,
				y => events.RenderedStep -= y),
			timeout
		);
	}
	public static ValueTask<RenderingEventArgs> WaitForRendering(this IDisplayEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<RenderingEventArgs>(
			new(x => events.Rendering += x,
				y => events.Rendering -= y),
			timeout
		);
	}
	public static ValueTask<RenderedEventArgs> WaitForRendered(this IDisplayEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<RenderedEventArgs>(
			new(x => events.Rendered += x,
				y => events.Rendered -= y),
			timeout
		);
	}
	public static ValueTask<RenderingWorldEventArgs> WaitForRenderingWorld(this IDisplayEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<RenderingWorldEventArgs>(
			new(x => events.RenderingWorld += x,
				y => events.RenderingWorld -= y),
			timeout
		);
	}
	public static ValueTask<RenderedWorldEventArgs> WaitForRenderedWorld(this IDisplayEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<RenderedWorldEventArgs>(
			new(x => events.RenderedWorld += x,
				y => events.RenderedWorld -= y),
			timeout
		);
	}
	public static ValueTask<RenderingActiveMenuEventArgs> WaitForRenderingActiveMenu(this IDisplayEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<RenderingActiveMenuEventArgs>(
			new(x => events.RenderingActiveMenu += x,
				y => events.RenderingActiveMenu -= y),
			timeout
		);
	}
	public static ValueTask<RenderedActiveMenuEventArgs> WaitForRenderedActiveMenu(this IDisplayEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<RenderedActiveMenuEventArgs>(
			new(x => events.RenderedActiveMenu += x,
				y => events.RenderedActiveMenu -= y),
			timeout
		);
	}
	public static ValueTask<RenderingHudEventArgs> WaitForRenderingHud(this IDisplayEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<RenderingHudEventArgs>(
			new(x => events.RenderingHud += x,
				y => events.RenderingHud -= y),
			timeout
		);
	}
	public static ValueTask<RenderedHudEventArgs> WaitForRenderedHud(this IDisplayEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<RenderedHudEventArgs>(
			new(x => events.RenderedHud += x,
				y => events.RenderedHud -= y),
			timeout
		);
	}
	public static ValueTask<WindowResizedEventArgs> WaitForWindowResized(this IDisplayEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<WindowResizedEventArgs>(
			new(x => events.WindowResized += x,
				y => events.WindowResized -= y),
			timeout
		);
	}
	public static ValueTask<GameLaunchedEventArgs> WaitForGameLaunched(this IGameLoopEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<GameLaunchedEventArgs>(
			new(x => events.GameLaunched += x,
				y => events.GameLaunched -= y),
			timeout
		);
	}
	public static ValueTask<UpdateTickingEventArgs> WaitForUpdateTicking(this IGameLoopEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<UpdateTickingEventArgs>(
			new(x => events.UpdateTicking += x,
				y => events.UpdateTicking -= y),
			timeout
		);
	}
	public static ValueTask<UpdateTickedEventArgs> WaitForUpdateTicked(this IGameLoopEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<UpdateTickedEventArgs>(
			new(x => events.UpdateTicked += x,
				y => events.UpdateTicked -= y),
			timeout
		);
	}
	public static ValueTask<OneSecondUpdateTickingEventArgs> WaitForOneSecondUpdateTicking(this IGameLoopEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<OneSecondUpdateTickingEventArgs>(
			new(x => events.OneSecondUpdateTicking += x,
				y => events.OneSecondUpdateTicking -= y),
			timeout
		);
	}
	public static ValueTask<OneSecondUpdateTickedEventArgs> WaitForOneSecondUpdateTicked(this IGameLoopEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<OneSecondUpdateTickedEventArgs>(
			new(x => events.OneSecondUpdateTicked += x,
				y => events.OneSecondUpdateTicked -= y),
			timeout
		);
	}
	public static ValueTask<SaveCreatingEventArgs> WaitForSaveCreating(this IGameLoopEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<SaveCreatingEventArgs>(
			new(x => events.SaveCreating += x,
				y => events.SaveCreating -= y),
			timeout
		);
	}
	public static ValueTask<SaveCreatedEventArgs> WaitForSaveCreated(this IGameLoopEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<SaveCreatedEventArgs>(
			new(x => events.SaveCreated += x,
				y => events.SaveCreated -= y),
			timeout
		);
	}
	public static ValueTask<SavingEventArgs> WaitForSaving(this IGameLoopEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<SavingEventArgs>(
			new(x => events.Saving += x,
				y => events.Saving -= y),
			timeout
		);
	}
	public static ValueTask<SavedEventArgs> WaitForSaved(this IGameLoopEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<SavedEventArgs>(
			new(x => events.Saved += x,
				y => events.Saved -= y),
			timeout
		);
	}
	public static ValueTask<SaveLoadedEventArgs> WaitForSaveLoaded(this IGameLoopEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<SaveLoadedEventArgs>(
			new(x => events.SaveLoaded += x,
				y => events.SaveLoaded -= y),
			timeout
		);
	}
	public static ValueTask<DayStartedEventArgs> WaitForDayStarted(this IGameLoopEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<DayStartedEventArgs>(
			new(x => events.DayStarted += x,
				y => events.DayStarted -= y),
			timeout
		);
	}
	public static ValueTask<DayEndingEventArgs> WaitForDayEnding(this IGameLoopEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<DayEndingEventArgs>(
			new(x => events.DayEnding += x,
				y => events.DayEnding -= y),
			timeout
		);
	}
	public static ValueTask<TimeChangedEventArgs> WaitForTimeChanged(this IGameLoopEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<TimeChangedEventArgs>(
			new(x => events.TimeChanged += x,
				y => events.TimeChanged -= y),
			timeout
		);
	}
	public static ValueTask<ReturnedToTitleEventArgs> WaitForReturnedToTitle(this IGameLoopEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<ReturnedToTitleEventArgs>(
			new(x => events.ReturnedToTitle += x,
				y => events.ReturnedToTitle -= y),
			timeout
		);
	}
	public static ValueTask<ButtonsChangedEventArgs> WaitForButtonsChanged(this IInputEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<ButtonsChangedEventArgs>(
			new(x => events.ButtonsChanged += x,
				y => events.ButtonsChanged -= y),
			timeout
		);
	}
	public static ValueTask<ButtonPressedEventArgs> WaitForButtonPressed(this IInputEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<ButtonPressedEventArgs>(
			new(x => events.ButtonPressed += x,
				y => events.ButtonPressed -= y),
			timeout
		);
	}
	public static ValueTask<ButtonReleasedEventArgs> WaitForButtonReleased(this IInputEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<ButtonReleasedEventArgs>(
			new(x => events.ButtonReleased += x,
				y => events.ButtonReleased -= y),
			timeout
		);
	}
	public static ValueTask<CursorMovedEventArgs> WaitForCursorMoved(this IInputEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<CursorMovedEventArgs>(
			new(x => events.CursorMoved += x,
				y => events.CursorMoved -= y),
			timeout
		);
	}
	public static ValueTask<MouseWheelScrolledEventArgs> WaitForMouseWheelScrolled(this IInputEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<MouseWheelScrolledEventArgs>(
			new(x => events.MouseWheelScrolled += x,
				y => events.MouseWheelScrolled -= y),
			timeout
		);
	}
	public static ValueTask<PeerContextReceivedEventArgs> WaitForPeerContextReceived(this IMultiplayerEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<PeerContextReceivedEventArgs>(
			new(x => events.PeerContextReceived += x,
				y => events.PeerContextReceived -= y),
			timeout
		);
	}
	public static ValueTask<PeerConnectedEventArgs> WaitForPeerConnected(this IMultiplayerEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<PeerConnectedEventArgs>(
			new(x => events.PeerConnected += x,
				y => events.PeerConnected -= y),
			timeout
		);
	}
	public static ValueTask<ModMessageReceivedEventArgs> WaitForModMessageReceived(this IMultiplayerEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<ModMessageReceivedEventArgs>(
			new(x => events.ModMessageReceived += x,
				y => events.ModMessageReceived -= y),
			timeout
		);
	}
	public static ValueTask<PeerDisconnectedEventArgs> WaitForPeerDisconnected(this IMultiplayerEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<PeerDisconnectedEventArgs>(
			new(x => events.PeerDisconnected += x,
				y => events.PeerDisconnected -= y),
			timeout
		);
	}
	public static ValueTask<InventoryChangedEventArgs> WaitForInventoryChanged(this IPlayerEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<InventoryChangedEventArgs>(
			new(x => events.InventoryChanged += x,
				y => events.InventoryChanged -= y),
			timeout
		);
	}
	public static ValueTask<LevelChangedEventArgs> WaitForLevelChanged(this IPlayerEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<LevelChangedEventArgs>(
			new(x => events.LevelChanged += x,
				y => events.LevelChanged -= y),
			timeout
		);
	}
	public static ValueTask<WarpedEventArgs> WaitForWarped(this IPlayerEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<WarpedEventArgs>(
			new(x => events.Warped += x,
				y => events.Warped -= y),
			timeout
		);
	}
	public static ValueTask<LoadStageChangedEventArgs> WaitForLoadStageChanged(this ISpecializedEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<LoadStageChangedEventArgs>(
			new(x => events.LoadStageChanged += x,
				y => events.LoadStageChanged -= y),
			timeout
		);
	}
	public static ValueTask<UnvalidatedUpdateTickingEventArgs> WaitForUnvalidatedUpdateTicking(this ISpecializedEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<UnvalidatedUpdateTickingEventArgs>(
			new(x => events.UnvalidatedUpdateTicking += x,
				y => events.UnvalidatedUpdateTicking -= y),
			timeout
		);
	}
	public static ValueTask<UnvalidatedUpdateTickedEventArgs> WaitForUnvalidatedUpdateTicked(this ISpecializedEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<UnvalidatedUpdateTickedEventArgs>(
			new(x => events.UnvalidatedUpdateTicked += x,
				y => events.UnvalidatedUpdateTicked -= y),
			timeout
		);
	}
	public static ValueTask<LocationListChangedEventArgs> WaitForLocationListChanged(this IWorldEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<LocationListChangedEventArgs>(
			new(x => events.LocationListChanged += x,
				y => events.LocationListChanged -= y),
			timeout
		);
	}
	public static ValueTask<BuildingListChangedEventArgs> WaitForBuildingListChanged(this IWorldEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<BuildingListChangedEventArgs>(
			new(x => events.BuildingListChanged += x,
				y => events.BuildingListChanged -= y),
			timeout
		);
	}
	public static ValueTask<DebrisListChangedEventArgs> WaitForDebrisListChanged(this IWorldEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<DebrisListChangedEventArgs>(
			new(x => events.DebrisListChanged += x,
				y => events.DebrisListChanged -= y),
			timeout
		);
	}
	public static ValueTask<LargeTerrainFeatureListChangedEventArgs> WaitForLargeTerrainFeatureListChanged(this IWorldEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<LargeTerrainFeatureListChangedEventArgs>(
			new(x => events.LargeTerrainFeatureListChanged += x,
				y => events.LargeTerrainFeatureListChanged -= y),
			timeout
		);
	}
	public static ValueTask<NpcListChangedEventArgs> WaitForNpcListChanged(this IWorldEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<NpcListChangedEventArgs>(
			new(x => events.NpcListChanged += x,
				y => events.NpcListChanged -= y),
			timeout
		);
	}
	public static ValueTask<ObjectListChangedEventArgs> WaitForObjectListChanged(this IWorldEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<ObjectListChangedEventArgs>(
			new(x => events.ObjectListChanged += x,
				y => events.ObjectListChanged -= y),
			timeout
		);
	}
	public static ValueTask<ChestInventoryChangedEventArgs> WaitForChestInventoryChanged(this IWorldEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<ChestInventoryChangedEventArgs>(
			new(x => events.ChestInventoryChanged += x,
				y => events.ChestInventoryChanged -= y),
			timeout
		);
	}
	public static ValueTask<TerrainFeatureListChangedEventArgs> WaitForTerrainFeatureListChanged(this IWorldEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<TerrainFeatureListChangedEventArgs>(
			new(x => events.TerrainFeatureListChanged += x,
				y => events.TerrainFeatureListChanged -= y),
			timeout
		);
	}
	public static ValueTask<FurnitureListChangedEventArgs> WaitForFurnitureListChanged(this IWorldEvents events, TimeSpan? timeout = null)
	{
		return StardewTask.WaitForEventArgs<FurnitureListChangedEventArgs>(
			new(x => events.FurnitureListChanged += x,
				y => events.FurnitureListChanged -= y),
			timeout
		);
	}
}
