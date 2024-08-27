// Copyright (c) 2024 linkoid 
// Linkoid licenses this file to you under the MIT license.
// See the LICENSE file in the project below for more information.
// https://github.com/linkoid/Stardew.Tasks?tab=MIT-1-ov-file

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Linkoid.Stardew.Tasks.Internal
{
	internal static class ReflectionExtensions
	{
		/// <summary>
		/// Creates a delegate of the given type 'T' from this method.
		/// </summary>
		public static T CreateDelegate<T>(this MethodInfo methodInfo)
			where T : Delegate
			=> (T)methodInfo.CreateDelegate(typeof(T));

		/// <summary>
		/// Creates a delegate of the given type 'T' with the specified target from this method.
		/// </summary>
		public static T CreateDelegate<T>(this MethodInfo methodInfo, object? target)
			where T : Delegate
			=> (T)methodInfo.CreateDelegate(typeof(T), target);

	}
}