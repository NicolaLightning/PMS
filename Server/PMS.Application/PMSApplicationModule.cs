using System;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PMS.Application
{
    [DependsOn(
    typeof(PMSCoreModule),
    typeof(AbpAutoMapperModule))]
    public class PMSApplicationModule : AbpModule
    {
    }
}
