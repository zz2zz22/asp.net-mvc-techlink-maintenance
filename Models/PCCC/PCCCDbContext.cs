using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace aspdotnet_webapp_techlink_maintenance.Models
{
    public class PCCCDbContext:DbContext
    {
        public PCCCDbContext():base("name=conn"){}
        public DbSet<Device_Info> device_Infos { get; set; }
        public DbSet<PCCC_Record> pCCC_Records { get; set; }
    }
}