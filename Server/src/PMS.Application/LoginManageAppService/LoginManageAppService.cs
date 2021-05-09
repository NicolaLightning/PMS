using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Microsoft.Net.Http;
using Microsoft.AspNetCore.Mvc;

namespace PMS.Application
{
    /// <summary>
    /// 登录管理应用
    /// </summary>
    public class LoginManageAppService:PMSAppServiceBase,ILoginManageAppService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public GetInfoOutput GetInfo()
        {
            GetInfoOutput output = new GetInfoOutput();
            output.UserName = "向阳";
            List<string> roles = new List<string>();
            roles.Add("admin");
            output.Roles= roles;
            return output;
        }
    }
}
