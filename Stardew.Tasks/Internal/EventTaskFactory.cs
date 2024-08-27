// Copyright (c) 2024 linkoid 
// Linkoid licenses this file to you under the MIT license.
// See the LICENSE file in the project below for more information.
// https://github.com/linkoid/Stardew.Tasks?tab=MIT-1-ov-file

using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace Linkoid.Stardew.Tasks.Internal
{
    internal static class EventTaskFactory
    {
        internal delegate TDelegate TCSCompleterBuilder<out TDelegate, TResult>(TaskCompletionSource<TResult> tcs)
            where TDelegate : Delegate;

		internal static async ValueTask<TResult> WaitForEvent<TDelegate, TResult>(
				TCSCompleterBuilder<TDelegate, TResult> createDelegate,
                EventWrapper<TDelegate> eventWrapper,
                TimeSpan? timeout = null)
            where TDelegate : Delegate
        {
            // Create a task completion source.
            var tcs = new TaskCompletionSource<TResult>();

            // Create a cancellation token and have it cancel our
            // task completion source when it times out.
            CancellationTokenSource cts = timeout.HasValue ? new CancellationTokenSource(timeout.Value) : new CancellationTokenSource();
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
			TCSCompleterBuilder<EventHandler<TEventArgs>, (object sender, TEventArgs eventArgs)> createDelegate,
            EventWrapper<EventHandler<TEventArgs>> eventWrapper,
            TimeSpan? timeout = null)
        {
            return WaitForEvent<EventHandler<TEventArgs>, (object, TEventArgs)>(createDelegate, eventWrapper, timeout);
        }

        internal static ValueTask<(object sender, TEventArgs eventArgs)> WaitForEvent<TEventArgs>(
            EventWrapper<EventHandler<TEventArgs>> eventWrapper, TimeSpan? timeout = null)
        {
            return WaitForEvent(s_TCSCompleterFactory.EventArgsCompleter2, eventWrapper, timeout);
        }

        internal static ValueTask<TEventArgs> WaitForEventArgs<TEventArgs>(
            EventWrapper<EventHandler<TEventArgs>> eventWrapper, TimeSpan? timeout = null)
        {
            return WaitForEvent<EventHandler<TEventArgs>, TEventArgs>(
                s_TCSCompleterFactory.EventArgsCompleter1, eventWrapper, timeout);
        }

        private static readonly TCSCompleterFactory s_TCSCompleterFactory = new TCSCompleterFactory();
		private class TCSCompleterFactory
        {
            public EventHandler<TEventArgs> EventArgsCompleter2<TEventArgs>(TaskCompletionSource<(object, TEventArgs)> tcs)
            {
                return (s, e) => tcs.SetResult((s!, e));
			}
			public EventHandler<TEventArgs> EventArgsCompleter1<TEventArgs>(TaskCompletionSource<TEventArgs> tcs)
			{
				return (s, e) => tcs.SetResult(e);
			}
		}
    }
}