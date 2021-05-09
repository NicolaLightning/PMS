using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;

namespace PMS.Application
{
    /// <summary>
    /// 
    /// </summary>
    public interface IClientAppService:IApplicationService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public QueryClientOutput QueryClientInfo(string id);
    }
}
