using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.Application
{
    /// <summary>
    /// 获取用户信息输出类
    /// </summary>
    public class GetInfoOutput
    {
        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 用户权限
        /// </summary>
        public List<string> Roles { get; set; }
    }
}
