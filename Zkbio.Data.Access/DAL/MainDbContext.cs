﻿using Microsoft.EntityFrameworkCore;

namespace Zkbio.Data.Access.DAL
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options)
         : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var mappings = MappingsHelper.GetMainMappings();

            foreach (var mapping in mappings)
            {
                mapping.Visit(modelBuilder);
            }
        }
    }
}
