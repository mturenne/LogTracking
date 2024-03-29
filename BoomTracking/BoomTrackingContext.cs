﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoomTracking
{
    public class BoomTrackingContext : DbContext
    {
        public DbSet<Boom> Booms { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<BoomGear> BoomGear { get; set; }
        public DbSet<BoomStick> BoomSticks { get; set; }
        public DbSet<Location> Locations { get; set; }

        public BoomTrackingContext()
            :base("name=DefaultConnection")
        {

        }
    }
}
