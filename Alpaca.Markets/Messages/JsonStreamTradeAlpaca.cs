﻿using System;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace Alpaca.Markets
{
    [SuppressMessage(
        "Microsoft.Performance", "CA1812:Avoid uninstantiated internal classes",
        Justification = "Object instances of this class will be created by Newtonsoft.JSON library.")]
    internal sealed class JsonStreamTradeAlpaca : IStreamTrade
    {
        [JsonProperty(PropertyName = "T", Required = Required.Always)]
        public String Symbol { get; set; } = String.Empty;

        [JsonProperty(PropertyName = "i", Required = Required.Default)]
        public String TradeId { get; set; } = String.Empty;

        [JsonProperty(PropertyName = "x", Required = Required.Always)]
        public Int64 Exchange { get; set; }

        [JsonProperty(PropertyName = "p", Required = Required.Always)]
        public Decimal Price { get; set; }

        [JsonProperty(PropertyName = "s", Required = Required.Always)]
        public Int64 Size { get; set; }

        [JsonProperty(PropertyName = "t", Required = Required.Always)]
        public Int64 Timestamp { get; set; }

        [JsonIgnore]
        public DateTime Time =>
            DateTimeHelper.FromUnixTimeNanoseconds(Timestamp);

        [JsonIgnore]
        public DateTime TimeUtc =>
            DateTimeHelper.FromUnixTimeNanoseconds(Timestamp);
    }
}
