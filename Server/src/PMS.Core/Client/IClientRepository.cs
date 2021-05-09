using System;
using System.Collections.Generic;
using System.Text;
using Abp.Dependency;

namespace PMS.Core
{
    /// <summary>
    /// 
    /// </summary>
    public interface IClientRepository:ISingletonDependency
    {
        #region public methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        bool Insert(IClient client);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        bool Update(IClient client);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        bool Delete(IClient client);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IClient Query(string id);
        #endregion
    }
}
