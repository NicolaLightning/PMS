using Abp.Modules;
using Abp.AutoMapper;
using Abp.Reflection.Extensions;

namespace PMS.Core
{
    [DependsOn(typeof(AbpAutoMapperModule))]
    public class PMSCoreModule: AbpModule
    {
        public override void PreInitialize()
        {
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PMSCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            //IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
