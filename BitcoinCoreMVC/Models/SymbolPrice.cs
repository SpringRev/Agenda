
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitcoinCoreMVC.Models
{
    public class ArrayOfSymbolPrice
    {
        public SymbolPrice[] SymbolPrices { get; set; }
    }

    public class SymbolPrice
    {
        public string symbol { get; set; }
        public float Price { get; set; }
    }
}
