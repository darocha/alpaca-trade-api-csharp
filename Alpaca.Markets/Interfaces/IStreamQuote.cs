﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace Alpaca.Markets
{
    /// <summary>
    /// Encapsulates quote information from Polygon streaming API.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMemberInSuper.Global")]
    public interface IStreamQuote : IQuoteBase<Int64>, IStreamBase
    {
        /// <summary>
        /// Gets quote timestamp.
        /// </summary>
        [Obsolete("This property will be removed in the next major release. Use the TimeUtc property instead.", false)]
        DateTime Time { get; }

        /// <summary>
        /// Gets quote timestamp in UTC time zone.
        /// </summary>
        DateTime TimeUtc { get; }
    }
}
