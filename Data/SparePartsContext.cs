using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VaruosadAPI.Models;

namespace VaruosadAPI.Data
{
    public class SparePartsContext : DbContext
    {
        public SparePartsContext (DbContextOptions<SparePartsContext> options)
            : base(options)
        {
        }

        public DbSet<VaruosadAPI.Models.SparePartsModel> SparePartsModel { get; set; } = default!;
    }
}
