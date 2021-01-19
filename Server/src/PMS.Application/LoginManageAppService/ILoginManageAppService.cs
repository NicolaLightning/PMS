using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;

namespace PMS.Application
{
    /// <summary>
    /// 登录管理应用
    /// </summary>
    public interface ILoginManageAppService:IApplicationService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
       public GetInfoOutput GetInfo();
    }
}
