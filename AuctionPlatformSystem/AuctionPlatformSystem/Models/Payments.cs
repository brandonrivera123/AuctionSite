using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionPlatformSystem.Models
{
    public class Payments
    {
        public int totalTotal { get; set; }
        public int pendingTotal { get; set; }
        public int paidTotal { get; set; }
        public int notPaidTotal { get; set; }
    }
}