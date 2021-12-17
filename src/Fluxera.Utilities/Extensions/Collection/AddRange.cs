﻿// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System.Collections.Generic;
	using Guards;

	public static partial class CollectionExtensions
	{
		/// <summary>
		///     Adds the given values to the target list.
		/// </summary>
		/// <typeparam name="T">The type of the elements.</typeparam>
		/// <param name="target">The target list to add the elements to.</param>
		/// <param name="values">The elements to add.</param>
		public static void AddRange<T>(this ICollection<T> target, IEnumerable<T> values)
		{
			Guard.Against.Null(target, nameof(target));
			Guard.Against.Null(values, nameof(values));

			foreach (T value in values)
			{
				target.Add(value);
			}
		}
	}
}