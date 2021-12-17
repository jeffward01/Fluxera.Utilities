﻿// ReSharper disable once CheckNamespace

namespace Fluxera.Utilities.Extensions
{
	using System;

	public static partial class DateTimeExtensions
	{
		/// <summary>
		///     Gets a <see cref="DateTime"/> representing noon on the given date.
		/// </summary>
		/// <param name="current">The date.</param>
		/// <returns>The modified <see cref="DateTime"/>.</returns>
		public static DateTime Noon(this DateTime current)
		{
			return current.SetTime(12);
		}
	}
}