using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ebuy.Web.Models
{
    public class EbuyDataContext:DbContext
    {
        public DbSet<Auction> Auctions { get; set; }
    }
}