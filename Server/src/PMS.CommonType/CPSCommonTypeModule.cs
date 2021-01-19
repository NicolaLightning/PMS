

namespace PMS.CommonType
{
    using System;
    using Abp.Reflection.Extensions;
    using Abp.Modules;
    using Abp.AutoMapper;
    public class CPSCommonTypeModule:AbpModule
    {
        public override void PreInitialize()
        {
            base.PreInitialize();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CPSCommonTypeModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
