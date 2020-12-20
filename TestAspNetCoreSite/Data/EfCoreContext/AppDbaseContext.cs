using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAspNetCoreSite.Data.Models;

namespace TestAspNetCoreSite.Data.EfCoreContext
{
    public class AppDbaseContext : DbContext
    {
        public AppDbaseContext(DbContextOptions<AppDbaseContext> options) : base(options)
        {

        }

        public DbSet<MicrowaveModel> Microwaves { get; set; }
        public DbSet<MicrowaveCategoryModel> MicrowaveCategory { get; set; }
    }   

}
