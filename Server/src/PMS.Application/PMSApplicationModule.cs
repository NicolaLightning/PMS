using System;
using System.Collections.Generic;
using System.Text;
using Abp.Modules;
using Abp.AutoMapper;
using PMS.Core;
using PMS.CommonType;
using Abp.Reflection.Extensions;

namespace PMS.Application
{
    [DependsOn(
        typeof(PMSCoreModule),
        typeof(AbpAutoMapperModule),
        typeof(CPSCommonTypeModule))]
    public class PMSApplicationModule: AbpModule
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
            base.PostInitialize();
        }

        /// <summary>
        /// 
        /// </summary>
        public override void Initialize()
        {
            var thisAssembly = typeof(PMSApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }

        public override void Shutdown()
        {
            base.Shutdown();
        }
    }
}
