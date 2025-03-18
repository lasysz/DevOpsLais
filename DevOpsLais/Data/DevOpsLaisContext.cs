using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DevOpsLais.Models;

namespace DevOpsLais.Data
{
    public class DevOpsLaisContext : DbContext
    {
        public DevOpsLaisContext (DbContextOptions<DevOpsLaisContext> options)
            : base(options)
        {
        }

        public DbSet<DevOpsLais.Models.Aluno> Aluno { get; set; } = default!;
    }
}
