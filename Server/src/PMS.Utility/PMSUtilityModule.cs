using System;
using System.Collections.Generic;
using System.Text;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;


namespace PMS.Utility
{
   public  class PMSUtilityModule:AbpModule
    {
        public override void PreInitialize()
        {
            //Configuration.Authorization.Providers.Add<PMSAuthorizationProvider>();
        }

        /// <summary>
        /// 
        /// </summary>
        public override void PostInitialize()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public override void Initialize()
        {
            var thisAssembly = typeof(PMSUtilityModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
