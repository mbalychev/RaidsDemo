using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Raids2020.Models
{
    public class RaidsContext : DbContext
    {
        public RaidsContext(DbContextOptions<RaidsContext> options)
            : base(options)
        {
        }

        public DbSet<Etc> Etcs { get; set; }
        public DbSet<ExceptionDate> ExceptionDates { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<Gosplan> Gosplans { get; set; }
        public DbSet<Goszadanie> Goszadanies { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Isp> Isps { get; set; }
        public DbSet<Pisp> Pisps { get; set; }
        public DbSet<Pokazatel> Pokazatels { get; set; }
        public DbSet<Raid> Raids { get; set; }

        public DbSet<File> Files { get; set; }
        public DbSet<ProtocolFiles> ProtocolFiles { get; set; }
        public DbSet<Rfile> Rfiles { get; set; }

        public DbSet<Risp> Risps { get; set; }
        public DbSet<Rpokazatel> Rpokazatels { get; set; }
        public DbSet<Protocol> Protocols { get; set; }
        public DbSet<Terr> Terrs { get; set; }
        public DbSet<ProtocolIsp> ProtocolIsps { get; set; }
    }
}
