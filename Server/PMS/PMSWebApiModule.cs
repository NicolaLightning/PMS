using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using PMS.WebApi.Configuration;

namespace PMS.WebApi
{
    public class PMSWebApiModule:AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PMSWebApiModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PMSWebApiModule).GetAssembly());
        }
    }
}
