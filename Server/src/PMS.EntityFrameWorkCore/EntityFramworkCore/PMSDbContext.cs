using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Abp.EntityFrameworkCore;
using PMS.Core;

namespace PMS.EntityFrameworkCore
{
    /// <summary>
    /// 
    /// </summary>
    public class PMSDbContext: AbpDbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public PMSDbContext(DbContextOptions<PMSDbContext> options)
           : base(options)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Client> Client { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
