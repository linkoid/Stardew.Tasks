// Copyright (c) 2024 linkoid 
// Linkoid licenses this file to you under the MIT license.
// See the LICENSE file in the project below for more information.
// https://github.com/linkoid/Stardew.Tasks?tab=MIT-1-ov-file

using System;
using System.Reflection;

namespace Linkoid.Stardew.Tasks.Internal
{
    internal static class EventWrapper
    {
        public static EventWrapper<TDelegate> Create<TDelegate>(Action<TDelegate>? add, Action<TDelegate>? remove)
            where TDelegate : Delegate
        {
            return new EventWrapper<TDelegate>(add, remove);
        }

        public static EventWrapper<TDelegate> Create<TDelegate>(EventInfo eventInfo)
            where TDelegate : Delegate
        {
            return Create<TDelegate>(null, eventInfo);
        }

        public static EventWrapper<TDelegate> Create<TDelegate>(object? target, EventInfo eventInfo)
            where TDelegate : Delegate
        {
            return Create(
                eventInfo.AddMethod?.CreateDelegate<Action<TDelegate>>(target),
                eventInfo.RemoveMethod?.CreateDelegate<Action<TDelegate>>(target));
        }

        public static EventWrapper<TDelegate> Create<TDelegate>(Type type, string nameOfEvent)
            where TDelegate : Delegate
        {
            EventInfo eventInfo =
                type.GetEvent(nameOfEvent, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
                ?? throw new MissingMemberException(type.FullName, nameOfEvent);
            return Create<TDelegate>(eventInfo);
        }

        public static EventWrapper<TDelegate> Create<TDelegate>(object target, string nameOfEvent)
            where TDelegate : Delegate
        {
            EventInfo eventInfo =
                target.GetType().GetEvent(nameOfEvent, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                ?? throw new MissingMemberException(target?.GetType().FullName, nameOfEvent);
            return Create<TDelegate>(target, eventInfo);
        }

        public static EventWrapper<EventHandler<TEventArgs>> Create<TEventArgs>(Action<EventHandler<TEventArgs>>? add, Action<EventHandler<TEventArgs>>? remove)
            where TEventArgs : EventArgs
            => Create(add, remove);
    }

    internal readonly struct EventWrapper<TDelegate>
        where TDelegate : Delegate
    {
        private readonly Action<TDelegate> _add;
        private readonly Action<TDelegate> _remove;

        private static void NotSupported(TDelegate _)
            => throw new NotSupportedException();

        public EventWrapper(Action<TDelegate>? add, Action<TDelegate>? remove)
        {
            _add = add ?? NotSupported;
            _remove = remove ?? NotSupported;
        }

        public void Add(TDelegate @delegate)
            => _add.Invoke(@delegate);

        public void Remove(TDelegate @delegate)
            => _remove.Invoke(@delegate);

        public static EventWrapper<TDelegate> operator +(EventWrapper<TDelegate> @this, TDelegate value)
        {
            @this.Add(value);
            return @this;
        }

        public static EventWrapper<TDelegate> operator -(EventWrapper<TDelegate> @this, TDelegate value)
        {
            @this.Remove(value);
            return @this;
        }
    }
}