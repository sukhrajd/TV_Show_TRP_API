using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TV_Show_TRP_API.Models;

namespace TV_Show_TRP_API.Data
{
    public class TV_Show_TRP_APIContext : DbContext
    {
        public TV_Show_TRP_APIContext (DbContextOptions<TV_Show_TRP_APIContext> options)
            : base(options)
        {
        }

        public DbSet<TV_Show_TRP_API.Models.TVShow_TRP> TVShow_TRP { get; set; }
    }
}
