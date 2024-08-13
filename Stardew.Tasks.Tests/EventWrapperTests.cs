﻿using NUnit.Framework;

namespace Linkoid.Stardew.Tasks.Tests;

public class EventWrapperTests
{
	private static class TestClass
	{
		public static event EventHandler<bool> Event;
	}

	[Test]
	public void WrapEvent()
	{
		var wrapper2 = EventWrapper.Create<EventHandler<bool>>(
			value => TestClass.Event += value,
			value => TestClass.Event -= value
		);
	}
}
