// Copyright (c) 2024 linkoid 
// Linkoid licenses this file to you under the MIT license.
// See the LICENSE file in the project below for more information.
// https://github.com/linkoid/Stardew.Tasks?tab=MIT-1-ov-file

using System;
using System.Threading.Tasks;
using StardewModdingAPI.Events;
using Linkoid.Stardew.Tasks.Internal;

namespace Linkoid.Stardew.Tasks
{
	internal static class SMAPIEventExtensions
	{
		/// <inheritdoc cref="IContentEvents.AssetRequested"/>
		public static ValueTask<AssetRequestedEventArgs> WaitForAssetRequested(this IContentEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<AssetRequestedEventArgs>(
				new EventWrapper<EventHandler<AssetRequestedEventArgs>>(
					x => events.AssetRequested += x,
					y => events.AssetRequested -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IContentEvents.AssetsInvalidated"/>
		public static ValueTask<AssetsInvalidatedEventArgs> WaitForAssetsInvalidated(this IContentEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<AssetsInvalidatedEventArgs>(
				new EventWrapper<EventHandler<AssetsInvalidatedEventArgs>>(
					x => events.AssetsInvalidated += x,
					y => events.AssetsInvalidated -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IContentEvents.AssetReady"/>
		public static ValueTask<AssetReadyEventArgs> WaitForAssetReady(this IContentEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<AssetReadyEventArgs>(
				new EventWrapper<EventHandler<AssetReadyEventArgs>>(
					x => events.AssetReady += x,
					y => events.AssetReady -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IContentEvents.LocaleChanged"/>
		public static ValueTask<LocaleChangedEventArgs> WaitForLocaleChanged(this IContentEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<LocaleChangedEventArgs>(
				new EventWrapper<EventHandler<LocaleChangedEventArgs>>(
					x => events.LocaleChanged += x,
					y => events.LocaleChanged -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IDisplayEvents.MenuChanged"/>
		public static ValueTask<MenuChangedEventArgs> WaitForMenuChanged(this IDisplayEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<MenuChangedEventArgs>(
				new EventWrapper<EventHandler<MenuChangedEventArgs>>(
					x => events.MenuChanged += x,
					y => events.MenuChanged -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IDisplayEvents.RenderingStep"/>
		public static ValueTask<RenderingStepEventArgs> WaitForRenderingStep(this IDisplayEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<RenderingStepEventArgs>(
				new EventWrapper<EventHandler<RenderingStepEventArgs>>(
					x => events.RenderingStep += x,
					y => events.RenderingStep -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IDisplayEvents.RenderedStep"/>
		public static ValueTask<RenderedStepEventArgs> WaitForRenderedStep(this IDisplayEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<RenderedStepEventArgs>(
				new EventWrapper<EventHandler<RenderedStepEventArgs>>(
					x => events.RenderedStep += x,
					y => events.RenderedStep -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IDisplayEvents.Rendering"/>
		public static ValueTask<RenderingEventArgs> WaitForRendering(this IDisplayEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<RenderingEventArgs>(
				new EventWrapper<EventHandler<RenderingEventArgs>>(
					x => events.Rendering += x,
					y => events.Rendering -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IDisplayEvents.Rendered"/>
		public static ValueTask<RenderedEventArgs> WaitForRendered(this IDisplayEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<RenderedEventArgs>(
				new EventWrapper<EventHandler<RenderedEventArgs>>(
					x => events.Rendered += x,
					y => events.Rendered -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IDisplayEvents.RenderingWorld"/>
		public static ValueTask<RenderingWorldEventArgs> WaitForRenderingWorld(this IDisplayEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<RenderingWorldEventArgs>(
				new EventWrapper<EventHandler<RenderingWorldEventArgs>>(
					x => events.RenderingWorld += x,
					y => events.RenderingWorld -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IDisplayEvents.RenderedWorld"/>
		public static ValueTask<RenderedWorldEventArgs> WaitForRenderedWorld(this IDisplayEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<RenderedWorldEventArgs>(
				new EventWrapper<EventHandler<RenderedWorldEventArgs>>(
					x => events.RenderedWorld += x,
					y => events.RenderedWorld -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IDisplayEvents.RenderingActiveMenu"/>
		public static ValueTask<RenderingActiveMenuEventArgs> WaitForRenderingActiveMenu(this IDisplayEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<RenderingActiveMenuEventArgs>(
				new EventWrapper<EventHandler<RenderingActiveMenuEventArgs>>(
					x => events.RenderingActiveMenu += x,
					y => events.RenderingActiveMenu -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IDisplayEvents.RenderedActiveMenu"/>
		public static ValueTask<RenderedActiveMenuEventArgs> WaitForRenderedActiveMenu(this IDisplayEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<RenderedActiveMenuEventArgs>(
				new EventWrapper<EventHandler<RenderedActiveMenuEventArgs>>(
					x => events.RenderedActiveMenu += x,
					y => events.RenderedActiveMenu -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IDisplayEvents.RenderingHud"/>
		public static ValueTask<RenderingHudEventArgs> WaitForRenderingHud(this IDisplayEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<RenderingHudEventArgs>(
				new EventWrapper<EventHandler<RenderingHudEventArgs>>(
					x => events.RenderingHud += x,
					y => events.RenderingHud -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IDisplayEvents.RenderedHud"/>
		public static ValueTask<RenderedHudEventArgs> WaitForRenderedHud(this IDisplayEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<RenderedHudEventArgs>(
				new EventWrapper<EventHandler<RenderedHudEventArgs>>(
					x => events.RenderedHud += x,
					y => events.RenderedHud -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IDisplayEvents.WindowResized"/>
		public static ValueTask<WindowResizedEventArgs> WaitForWindowResized(this IDisplayEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<WindowResizedEventArgs>(
				new EventWrapper<EventHandler<WindowResizedEventArgs>>(
					x => events.WindowResized += x,
					y => events.WindowResized -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IGameLoopEvents.GameLaunched"/>
		public static ValueTask<GameLaunchedEventArgs> WaitForGameLaunched(this IGameLoopEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<GameLaunchedEventArgs>(
				new EventWrapper<EventHandler<GameLaunchedEventArgs>>(
					x => events.GameLaunched += x,
					y => events.GameLaunched -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IGameLoopEvents.UpdateTicking"/>
		public static ValueTask<UpdateTickingEventArgs> WaitForUpdateTicking(this IGameLoopEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<UpdateTickingEventArgs>(
				new EventWrapper<EventHandler<UpdateTickingEventArgs>>(
					x => events.UpdateTicking += x,
					y => events.UpdateTicking -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IGameLoopEvents.UpdateTicked"/>
		public static ValueTask<UpdateTickedEventArgs> WaitForUpdateTicked(this IGameLoopEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<UpdateTickedEventArgs>(
				new EventWrapper<EventHandler<UpdateTickedEventArgs>>(
					x => events.UpdateTicked += x,
					y => events.UpdateTicked -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IGameLoopEvents.OneSecondUpdateTicking"/>
		public static ValueTask<OneSecondUpdateTickingEventArgs> WaitForOneSecondUpdateTicking(this IGameLoopEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<OneSecondUpdateTickingEventArgs>(
				new EventWrapper<EventHandler<OneSecondUpdateTickingEventArgs>>(
					x => events.OneSecondUpdateTicking += x,
					y => events.OneSecondUpdateTicking -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IGameLoopEvents.OneSecondUpdateTicked"/>
		public static ValueTask<OneSecondUpdateTickedEventArgs> WaitForOneSecondUpdateTicked(this IGameLoopEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<OneSecondUpdateTickedEventArgs>(
				new EventWrapper<EventHandler<OneSecondUpdateTickedEventArgs>>(
					x => events.OneSecondUpdateTicked += x,
					y => events.OneSecondUpdateTicked -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IGameLoopEvents.SaveCreating"/>
		public static ValueTask<SaveCreatingEventArgs> WaitForSaveCreating(this IGameLoopEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<SaveCreatingEventArgs>(
				new EventWrapper<EventHandler<SaveCreatingEventArgs>>(
					x => events.SaveCreating += x,
					y => events.SaveCreating -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IGameLoopEvents.SaveCreated"/>
		public static ValueTask<SaveCreatedEventArgs> WaitForSaveCreated(this IGameLoopEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<SaveCreatedEventArgs>(
				new EventWrapper<EventHandler<SaveCreatedEventArgs>>(
					x => events.SaveCreated += x,
					y => events.SaveCreated -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IGameLoopEvents.Saving"/>
		public static ValueTask<SavingEventArgs> WaitForSaving(this IGameLoopEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<SavingEventArgs>(
				new EventWrapper<EventHandler<SavingEventArgs>>(
					x => events.Saving += x,
					y => events.Saving -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IGameLoopEvents.Saved"/>
		public static ValueTask<SavedEventArgs> WaitForSaved(this IGameLoopEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<SavedEventArgs>(
				new EventWrapper<EventHandler<SavedEventArgs>>(
					x => events.Saved += x,
					y => events.Saved -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IGameLoopEvents.SaveLoaded"/>
		public static ValueTask<SaveLoadedEventArgs> WaitForSaveLoaded(this IGameLoopEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<SaveLoadedEventArgs>(
				new EventWrapper<EventHandler<SaveLoadedEventArgs>>(
					x => events.SaveLoaded += x,
					y => events.SaveLoaded -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IGameLoopEvents.DayStarted"/>
		public static ValueTask<DayStartedEventArgs> WaitForDayStarted(this IGameLoopEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<DayStartedEventArgs>(
				new EventWrapper<EventHandler<DayStartedEventArgs>>(
					x => events.DayStarted += x,
					y => events.DayStarted -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IGameLoopEvents.DayEnding"/>
		public static ValueTask<DayEndingEventArgs> WaitForDayEnding(this IGameLoopEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<DayEndingEventArgs>(
				new EventWrapper<EventHandler<DayEndingEventArgs>>(
					x => events.DayEnding += x,
					y => events.DayEnding -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IGameLoopEvents.TimeChanged"/>
		public static ValueTask<TimeChangedEventArgs> WaitForTimeChanged(this IGameLoopEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<TimeChangedEventArgs>(
				new EventWrapper<EventHandler<TimeChangedEventArgs>>(
					x => events.TimeChanged += x,
					y => events.TimeChanged -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IGameLoopEvents.ReturnedToTitle"/>
		public static ValueTask<ReturnedToTitleEventArgs> WaitForReturnedToTitle(this IGameLoopEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<ReturnedToTitleEventArgs>(
				new EventWrapper<EventHandler<ReturnedToTitleEventArgs>>(
					x => events.ReturnedToTitle += x,
					y => events.ReturnedToTitle -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IInputEvents.ButtonsChanged"/>
		public static ValueTask<ButtonsChangedEventArgs> WaitForButtonsChanged(this IInputEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<ButtonsChangedEventArgs>(
				new EventWrapper<EventHandler<ButtonsChangedEventArgs>>(
					x => events.ButtonsChanged += x,
					y => events.ButtonsChanged -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IInputEvents.ButtonPressed"/>
		public static ValueTask<ButtonPressedEventArgs> WaitForButtonPressed(this IInputEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<ButtonPressedEventArgs>(
				new EventWrapper<EventHandler<ButtonPressedEventArgs>>(
					x => events.ButtonPressed += x,
					y => events.ButtonPressed -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IInputEvents.ButtonReleased"/>
		public static ValueTask<ButtonReleasedEventArgs> WaitForButtonReleased(this IInputEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<ButtonReleasedEventArgs>(
				new EventWrapper<EventHandler<ButtonReleasedEventArgs>>(
					x => events.ButtonReleased += x,
					y => events.ButtonReleased -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IInputEvents.CursorMoved"/>
		public static ValueTask<CursorMovedEventArgs> WaitForCursorMoved(this IInputEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<CursorMovedEventArgs>(
				new EventWrapper<EventHandler<CursorMovedEventArgs>>(
					x => events.CursorMoved += x,
					y => events.CursorMoved -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IInputEvents.MouseWheelScrolled"/>
		public static ValueTask<MouseWheelScrolledEventArgs> WaitForMouseWheelScrolled(this IInputEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<MouseWheelScrolledEventArgs>(
				new EventWrapper<EventHandler<MouseWheelScrolledEventArgs>>(
					x => events.MouseWheelScrolled += x,
					y => events.MouseWheelScrolled -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IMultiplayerEvents.PeerContextReceived"/>
		public static ValueTask<PeerContextReceivedEventArgs> WaitForPeerContextReceived(this IMultiplayerEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<PeerContextReceivedEventArgs>(
				new EventWrapper<EventHandler<PeerContextReceivedEventArgs>>(
					x => events.PeerContextReceived += x,
					y => events.PeerContextReceived -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IMultiplayerEvents.PeerConnected"/>
		public static ValueTask<PeerConnectedEventArgs> WaitForPeerConnected(this IMultiplayerEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<PeerConnectedEventArgs>(
				new EventWrapper<EventHandler<PeerConnectedEventArgs>>(
					x => events.PeerConnected += x,
					y => events.PeerConnected -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IMultiplayerEvents.ModMessageReceived"/>
		public static ValueTask<ModMessageReceivedEventArgs> WaitForModMessageReceived(this IMultiplayerEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<ModMessageReceivedEventArgs>(
				new EventWrapper<EventHandler<ModMessageReceivedEventArgs>>(
					x => events.ModMessageReceived += x,
					y => events.ModMessageReceived -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IMultiplayerEvents.PeerDisconnected"/>
		public static ValueTask<PeerDisconnectedEventArgs> WaitForPeerDisconnected(this IMultiplayerEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<PeerDisconnectedEventArgs>(
				new EventWrapper<EventHandler<PeerDisconnectedEventArgs>>(
					x => events.PeerDisconnected += x,
					y => events.PeerDisconnected -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IPlayerEvents.InventoryChanged"/>
		public static ValueTask<InventoryChangedEventArgs> WaitForInventoryChanged(this IPlayerEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<InventoryChangedEventArgs>(
				new EventWrapper<EventHandler<InventoryChangedEventArgs>>(
					x => events.InventoryChanged += x,
					y => events.InventoryChanged -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IPlayerEvents.LevelChanged"/>
		public static ValueTask<LevelChangedEventArgs> WaitForLevelChanged(this IPlayerEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<LevelChangedEventArgs>(
				new EventWrapper<EventHandler<LevelChangedEventArgs>>(
					x => events.LevelChanged += x,
					y => events.LevelChanged -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IPlayerEvents.Warped"/>
		public static ValueTask<WarpedEventArgs> WaitForWarped(this IPlayerEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<WarpedEventArgs>(
				new EventWrapper<EventHandler<WarpedEventArgs>>(
					x => events.Warped += x,
					y => events.Warped -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="ISpecializedEvents.LoadStageChanged"/>
		public static ValueTask<LoadStageChangedEventArgs> WaitForLoadStageChanged(this ISpecializedEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<LoadStageChangedEventArgs>(
				new EventWrapper<EventHandler<LoadStageChangedEventArgs>>(
					x => events.LoadStageChanged += x,
					y => events.LoadStageChanged -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IWorldEvents.LocationListChanged"/>
		public static ValueTask<LocationListChangedEventArgs> WaitForLocationListChanged(this IWorldEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<LocationListChangedEventArgs>(
				new EventWrapper<EventHandler<LocationListChangedEventArgs>>(
					x => events.LocationListChanged += x,
					y => events.LocationListChanged -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IWorldEvents.BuildingListChanged"/>
		public static ValueTask<BuildingListChangedEventArgs> WaitForBuildingListChanged(this IWorldEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<BuildingListChangedEventArgs>(
				new EventWrapper<EventHandler<BuildingListChangedEventArgs>>(
					x => events.BuildingListChanged += x,
					y => events.BuildingListChanged -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IWorldEvents.DebrisListChanged"/>
		public static ValueTask<DebrisListChangedEventArgs> WaitForDebrisListChanged(this IWorldEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<DebrisListChangedEventArgs>(
				new EventWrapper<EventHandler<DebrisListChangedEventArgs>>(
					x => events.DebrisListChanged += x,
					y => events.DebrisListChanged -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IWorldEvents.LargeTerrainFeatureListChanged"/>
		public static ValueTask<LargeTerrainFeatureListChangedEventArgs> WaitForLargeTerrainFeatureListChanged(this IWorldEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<LargeTerrainFeatureListChangedEventArgs>(
				new EventWrapper<EventHandler<LargeTerrainFeatureListChangedEventArgs>>(
					x => events.LargeTerrainFeatureListChanged += x,
					y => events.LargeTerrainFeatureListChanged -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IWorldEvents.NpcListChanged"/>
		public static ValueTask<NpcListChangedEventArgs> WaitForNpcListChanged(this IWorldEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<NpcListChangedEventArgs>(
				new EventWrapper<EventHandler<NpcListChangedEventArgs>>(
					x => events.NpcListChanged += x,
					y => events.NpcListChanged -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IWorldEvents.ObjectListChanged"/>
		public static ValueTask<ObjectListChangedEventArgs> WaitForObjectListChanged(this IWorldEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<ObjectListChangedEventArgs>(
				new EventWrapper<EventHandler<ObjectListChangedEventArgs>>(
					x => events.ObjectListChanged += x,
					y => events.ObjectListChanged -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IWorldEvents.ChestInventoryChanged"/>
		public static ValueTask<ChestInventoryChangedEventArgs> WaitForChestInventoryChanged(this IWorldEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<ChestInventoryChangedEventArgs>(
				new EventWrapper<EventHandler<ChestInventoryChangedEventArgs>>(
					x => events.ChestInventoryChanged += x,
					y => events.ChestInventoryChanged -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IWorldEvents.TerrainFeatureListChanged"/>
		public static ValueTask<TerrainFeatureListChangedEventArgs> WaitForTerrainFeatureListChanged(this IWorldEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<TerrainFeatureListChangedEventArgs>(
				new EventWrapper<EventHandler<TerrainFeatureListChangedEventArgs>>(
					x => events.TerrainFeatureListChanged += x,
					y => events.TerrainFeatureListChanged -= y
				),
				timeout
			);
		}
		/// <inheritdoc cref="IWorldEvents.FurnitureListChanged"/>
		public static ValueTask<FurnitureListChangedEventArgs> WaitForFurnitureListChanged(this IWorldEvents events, TimeSpan? timeout = null)
		{
			return EventTaskFactory.WaitForEventArgs<FurnitureListChangedEventArgs>(
				new EventWrapper<EventHandler<FurnitureListChangedEventArgs>>(
					x => events.FurnitureListChanged += x,
					y => events.FurnitureListChanged -= y
				),
				timeout
			);
		}
	}
}
