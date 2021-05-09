using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PMS.Core;
using PMS.Configuration;

namespace PMS.EntityFrameworkCore
{
    /// <summary>
    /// 
    /// </summary>
    public class PMSDbContextFactory: IDesignTimeDbContextFactory<PMSDbContext>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public PMSDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PMSDbContext>();
            
            if(PMSDbContextConfigurer.SkipDbContextRegistartion)
            {
                
            }

            if(string.IsNullOrEmpty(PMSDbContextConfigurer.CurrentConnectionString))
            {
                //var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());
            }
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());
            PMSDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PMSConsts.ConnectionStringName));

            return new PMSDbContext(builder.Options);
        }
    }
}
