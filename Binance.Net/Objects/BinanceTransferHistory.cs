﻿using System;
using System.Collections.Generic;
using System.Text;
using Binance.Net.Converters;
using CryptoExchange.Net.Converters;
using Newtonsoft.Json;

namespace Binance.Net.Objects
{
    /// <summary>
    /// Transfer history
    /// </summary>
    public class BinanceTransferHistory
    {
        /// <summary>
        /// Total results
        /// </summary>
        public int Total { get; set; }
        /// <summary>
        /// Results for this page
        /// </summary>
        [JsonProperty("rows")]
        public BinanceTransferHistoryEntry[] Data { get; set; }
    }

    /// <summary>
    /// Transfer history entry
    /// </summary>
    public class BinanceTransferHistoryEntry
    {
        /// <summary>
        /// Amount of the transfer
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// Asset of the transfer
        /// </summary>
        public decimal Asset { get; set; }
        /// <summary>
        /// Status of the transfer
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Timestamp of the transaction
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        public decimal Timestamp { get; set; }
        /// <summary>
        /// Transaction id
        /// </summary>
        [JsonProperty("txId")]
        public decimal TransactionId { get; set; }
        /// <summary>
        /// Direction of the transfer
        /// </summary>
        [JsonProperty("type"), JsonConverter(typeof(TransferDirectionConverter))]
        public TransferDirection Direction { get; set; }
    }
}
