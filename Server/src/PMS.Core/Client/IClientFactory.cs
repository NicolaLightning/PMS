using System;
using System.Collections.Generic;
using System.Text;
using Abp.Dependency;

namespace PMS.Core
{
    /// <summary>
    /// 
    /// </summary>
    public interface IClientFactory: ISingletonDependency
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IClient Create(string name, string adress, string tel);
    }
}
