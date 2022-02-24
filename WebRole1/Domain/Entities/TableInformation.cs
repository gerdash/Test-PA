using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebRole1.Domain.Entities
{
    public class TableInformation
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Currency { get; set; }
        public string Language { get; set; }
        public int NumberOfUsers { get; set; }
        public string SalesModel { get; set; }

    }
}