using Microsoft.EntityFrameworkCore;

namespace EFCoreExample.Models
{
    public class SampleContext : DbContext
    {
        public SampleContext(DbContextOptions<SampleContext> options) : base(options)
        {
        }

        public DbSet<TableOne> TableOne { get; set; }

    }
}