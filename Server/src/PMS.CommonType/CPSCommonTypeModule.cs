

namespace PMS.CommonType
{
    using System;
    using Abp.Reflection.Extensions;
    using Abp.Modules;
    using Abp.AutoMapper;

    /// <summary>
    /// 
    /// </summary>
    public class CPSCommonTypeModule:AbpModule
    {
        /// <summary>
        /// 
        /// </summary>
        public override void PreInitialize()
        {
            base.PreInitialize();
        }

        /// <summary>
        /// 
        /// </summary>
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
