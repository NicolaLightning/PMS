using System;
using System.Collections.Generic;
using System.Text;
using PMS.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Abp.EntityFrameworkCore;
using System.Linq;


namespace PMS.EntityFrameworkCore
{
    /// <summary>
    /// 
    /// </summary>
    public class ClientRepository : PMSRepositoryBase<Client>, IClientRepository
    {
        #region fileds
        /// <summary>
        /// 
        /// </summary>
        private readonly Func<IQueryable<Client>> generateArQueryable;
        #endregion

        #region construtor
        /// <summary>
        /// 构造方法
        /// </summary>
        public ClientRepository()
        {
            this.generateArQueryable = () => Context.Client;
        }
        #endregion

        /// <summary>
        /// 插入一个对象
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public bool Insert(IClient client)
        {
            if (client == null)
            {
                return false;
            }

            return base.Insert(client as Client);
        }

        /// <summary>
        /// 更新一个对象
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public bool Update(IClient client)
        {
            if (client == null)
            {
                return false;
            }

            return base.Update(client as Client);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public bool Delete(IClient client)
        {
            if (client == null)
            {
                return false;
            }

            return base.Delete(client as Client);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IClient Query(string id)
        {
            Guid Id = new Guid(id);
            return this.generateArQueryable().FirstOrDefault(t => t.Id == Id);
        }

    }
}
