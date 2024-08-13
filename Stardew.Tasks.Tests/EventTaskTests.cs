using NUnit.Framework;
using StardewModdingAPI.Events;
using System.Diagnostics;

namespace Linkoid.Stardew.Tasks.Tests;

public class EventTaskTests : IGameLoopEvents
{
	public event EventHandler<GameLaunchedEventArgs> GameLaunched;
	public event EventHandler<UpdateTickingEventArgs> UpdateTicking;
	public event EventHandler<UpdateTickedEventArgs> UpdateTicked;
	public event EventHandler<OneSecondUpdateTickingEventArgs> OneSecondUpdateTicking;
	public event EventHandler<OneSecondUpdateTickedEventArgs> OneSecondUpdateTicked;
	public event EventHandler<SaveCreatingEventArgs> SaveCreating;
	public event EventHandler<SaveCreatedEventArgs> SaveCreated;
	public event EventHandler<SavingEventArgs> Saving;
	public event EventHandler<SavedEventArgs> Saved;
	public event EventHandler<SaveLoadedEventArgs> SaveLoaded;
	public event EventHandler<DayStartedEventArgs> DayStarted;
	public event EventHandler<DayEndingEventArgs> DayEnding;
	public event EventHandler<TimeChangedEventArgs> TimeChanged;
	public event EventHandler<ReturnedToTitleEventArgs> ReturnedToTitle;

	[SetUp]
	public void SetUp()
	{
		
	}

	[Test]
	public async Task Success()
	{
		// Simulate event invoke in 100 milliseconds
		var eventArgs = new UpdateTickingEventArgs();
		_ = Task.Run(async () =>
		{
			await Task.Delay(100);
			UpdateTicking.Invoke(this, eventArgs);
		});

		// Start a Stopwatch to see how long we waited.
		var sw = Stopwatch.StartNew();

		// Wait for the result from our task.
		var taskBuilder = async () =>
		{
			var result = await this.WaitForUpdateTicking();
			Console.WriteLine("This should be the first line");
			return result;
		};
		var task = taskBuilder.Invoke();


		UpdateTicking += (_, _) => Console.WriteLine("This should be the second line");

		var result = await task;

		// Stop the stopwatch
		sw.Stop();

		// Assert that the event fired.
		Assert.AreEqual(result, eventArgs);

		// Assert we only waited the 100 milliseconds!
		//Assert.InRange(sw.ElapsedMilliseconds, 80, 120);
	}

	[Test]
	public async Task RunsOnce()
	{
		// Simulate event invoke in 100 milliseconds
		var eventArgs = new UpdateTickingEventArgs();
		var fireTask = Task.Run(async () =>
		{
			await Task.Delay(100);
			UpdateTicking.Invoke(this, eventArgs);
			await Task.Delay(100);
			UpdateTicking.Invoke(this, new());
		});

		// Start a Stopwatch to see how long we waited.
		var sw = Stopwatch.StartNew();

		// Wait for the result from our task.
		var taskBuilder = async () =>
		{
			var result = await this.WaitForUpdateTicking();
			Console.WriteLine("This should be the first line");
			return result;
		};
		var task = taskBuilder.Invoke();


		UpdateTicking += (_, _) => Console.WriteLine("This should be the second line");

		var result = await task;

		// Stop the stopwatch
		sw.Stop();

		await fireTask;

		// Assert that the event fired.
		Assert.AreEqual(result, eventArgs);

		// Assert we only waited the 100 milliseconds!
		//Assert.InRange(sw.ElapsedMilliseconds, 80, 120);
	}

	//[Test]
	//public void Failure()
	//{
	//	Assert.Throws(typeof(AggregateException), () =>
	//	{
	//		// Wait for task to timeout.
	//		var task = SingleParamTestEvenAsync();
	//		task.Wait();
	//	});
	//}
}
