using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebRole1.Models
{
    public class MarketViewModel
    {
        public string Country { get; set; }
        public string Currency { get; set; }
        public string Language { get; set; }
        public int NumberOfUsers { get; set; }
        public string SalesModel { get; set; }
    }
}