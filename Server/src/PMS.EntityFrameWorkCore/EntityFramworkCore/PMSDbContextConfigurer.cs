using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace PMS.EntityFrameworkCore
{
    public static class PMSDbContextConfigurer
    {
        public static string CurrentConnectionString = string.Empty;

        public static bool SkipDbContextRegistartion = false;
        public static void Configure(DbContextOptionsBuilder<PMSDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PMSDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
