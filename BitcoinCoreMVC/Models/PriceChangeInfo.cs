

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitcoinCoreMVC.Models
{
    public class PriceChangeInfo
    {
        public string symbol { get; set; }
        public float priceChange { get; set; }
        public float priceChangePercent { get; set; }
        public float weightedAvgPrice { get; set; }
        public float prevClosePrice { get; set; }
        public float lastPrice { get; set; }
        public float bidPrice { get; set; }
        public float askPrice { get; set; }
        public float openPrice { get; set; }
        public float highPrice { get; set; }
        public float lowPrice { get; set; }
        public float volume { get; set; }
        public long openTime { get; set; }
        public long closeTime { get; set; }
        public int firstId { get; set; }
        public int lastId { get; set; }
        public int count { get; set; }
    }
}
