using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionPlatformSystem.Models
{
    public class AuctionItems
    {
        public int auctionItemID { get; set; }
        public string item { get; set; }
        public int salePrice { get; set; }
        public string description { get; set; }
    }
}