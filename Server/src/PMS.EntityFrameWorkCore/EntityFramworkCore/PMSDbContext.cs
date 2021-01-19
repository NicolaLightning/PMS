using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Abp.EntityFrameworkCore;

namespace PMS.EntityFrameworkCore
{
    public class PMSDbContext: AbpDbContext
    {
        public PMSDbContext(DbContextOptions<PMSDbContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}
