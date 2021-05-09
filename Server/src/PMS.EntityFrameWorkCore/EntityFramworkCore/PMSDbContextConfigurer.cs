using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace PMS.EntityFrameworkCore
{
    /// <summary>
    /// 
    /// </summary>
    public static class PMSDbContextConfigurer
    {
        /// <summary>
        /// 
        /// </summary>
        public static string CurrentConnectionString = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        public static bool SkipDbContextRegistartion = false;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="connectionString"></param>
        public static void Configure(DbContextOptionsBuilder<PMSDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="connection"></param>
        public static void Configure(DbContextOptionsBuilder<PMSDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
