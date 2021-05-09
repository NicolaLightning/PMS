using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PMS.Web.Host.Configration;
using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.AspNetCore.SignalR;
using PMS.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using PMS.Core;
using PMS.Application;

namespace PMS.Web.Host
{
    /// <summary>
    /// 
    /// </summary>
    [DependsOn(
  typeof(PMSApplicationModule),
  typeof(PMSEntityFrameworkModule),
  typeof(AbpAspNetCoreModule)
 , typeof(AbpAspNetCoreSignalRModule))]
    public class PMSWebHostModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="env"></param>
        public PMSWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        /// <summary>
        /// 
        /// </summary>
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PMSWebHostModule).GetAssembly());
        }

        /// <summary>
        /// 
        /// </summary>
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                PMSConsts.ConnectionStringName
            );

            // Use database for language management
            PMSDbContextConfigurer.CurrentConnectionString = "";

            Configuration.Modules.AbpAspNetCore()
                 .CreateControllersForAppServices(
                     typeof(PMSApplicationModule).GetAssembly()
                 );
        }
    }

}
