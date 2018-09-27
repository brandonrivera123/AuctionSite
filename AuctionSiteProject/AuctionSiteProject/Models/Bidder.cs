using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionSiteProject.Models
{
    public class Bidder
    {
        public string email { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string comments { get; set; }
        public string status { get; set; }
    }
}