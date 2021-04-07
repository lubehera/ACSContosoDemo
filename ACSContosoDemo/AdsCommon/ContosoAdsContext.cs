using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace AdsCommon
{
    public class AdsContext : DbContext
    {
        public AdsContext() : base("name=ContosoAdsContext")
        {
        }

        public AdsContext(string connString) : base(connString)
        {
        }

        public System.Data.Entity.DbSet<Ad> Ads { get; set; }
    
    }
}
