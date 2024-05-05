using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using M09.UF1.AC1.Models;

namespace M09.UF1.AC1.Data
{
    public class M09UF1AC1Context : DbContext
    {
        public M09UF1AC1Context (DbContextOptions<M09UF1AC1Context> options)
            : base(options)
        {
        }

        public DbSet<M09.UF1.AC1.Models.Cliente> Cliente { get; set; } = default!;
    }
}
