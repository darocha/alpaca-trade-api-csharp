﻿using System;
using System.Collections.Generic;

namespace Alpaca.Markets
{
    /// <summary>
    /// Encapsulates watch list information from Alpaca REST API.
    /// </summary>
    public interface IWatchList
    {
        /// <summary>
        /// Gets unique watch list identifier.
        /// </summary>
        Guid WatchListId { get; }

        /// <summary>
        /// Gets watch list creation time.
        /// </summary>
        [Obsolete("This property will be removed in the next major release. Use the CreatedUtc property instead.", false)]
        DateTime Created { get; }

        /// <summary>
        /// Gets watch list creation time in UTC time zone.
        /// </summary>
        DateTime CreatedUtc { get; }

        /// <summary>
        /// Gets watch list last update time.
        /// </summary>
        [Obsolete("This property will be removed in the next major release. Use the UpdatedUtc property instead.", false)]
        DateTime? Updated { get; }

        /// <summary>
        /// Gets watch list last update time in UTC time zone.
        /// </summary>
        DateTime? UpdatedUtc { get; }

        /// <summary>
        /// Gets watch list user-defined name.
        /// </summary>
        String Name { get; }

        /// <summary>
        /// Gets <see cref="IAccountBase.AccountId"/> fro this watch list.
        /// </summary>
        Guid AccountId { get; }

        /// <summary>
        /// Gets the content of this watchlist, in the order as registered by the client.
        /// </summary>
        IReadOnlyList<IAsset> Assets { get; }
    }
}
