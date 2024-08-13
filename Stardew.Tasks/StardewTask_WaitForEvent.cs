using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace Linkoid.Stardew.Tasks;

public static class StardewTask
{
	internal static async ValueTask<TResult> WaitForEvent<TDelegate, TResult>(
			Func<TaskCompletionSource<TResult>, TDelegate> createDelegate,
			EventWrapper<TDelegate> eventWrapper,
			TimeSpan? timeout = null)
		where TDelegate : Delegate
	{
		// Create a task completion source.
		var tcs = new TaskCompletionSource<TResult>();

		// Create a cancellation token and have it cancel our
		// task completion source when it times out.
		CancellationTokenSource cts = timeout.HasValue ? new(timeout.Value) : new CancellationTokenSource();
		cts.Token.Register(() => tcs.TrySetCanceled());

		// Create the deleate.
		var @delegate = createDelegate(tcs);
		try
		{
			// Subscribe for event.
			eventWrapper += @delegate;

			// Await the result.
			return await tcs.Task;
		}
		finally
		{
			// Unsubscribe from event.
			eventWrapper -= @delegate;
		}
	}

	private static ValueTask<(object sender, TEventArgs eventArgs)> WaitForEvent<TEventArgs>(
		Func<TaskCompletionSource<(object sender, TEventArgs eventArgs)>, EventHandler<TEventArgs>> createDelegate,
		EventWrapper<EventHandler<TEventArgs>> eventWrapper,
		TimeSpan? timeout = null)
	{
		return WaitForEvent<EventHandler<TEventArgs>, (object, TEventArgs)>(createDelegate, eventWrapper, timeout);
	}

	internal static ValueTask<(object sender, TEventArgs eventArgs)> WaitForEvent<TEventArgs>(
		EventWrapper<EventHandler<TEventArgs>> eventWrapper, TimeSpan? timeout = null)
	{
		return WaitForEvent(static tcs => (s, e) => tcs.SetResult((s!, e)),
			eventWrapper, timeout);
	}

	internal static ValueTask<TEventArgs> WaitForEventArgs<TEventArgs>(
		EventWrapper<EventHandler<TEventArgs>> eventWrapper, TimeSpan? timeout = null)
	{
		return WaitForEvent<EventHandler<TEventArgs>, TEventArgs>(static tcs => (s, e) => tcs.SetResult(e),
			eventWrapper, timeout);
	}
}
