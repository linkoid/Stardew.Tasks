using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Linkoid.Stardew.Tasks;

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
