using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;
using Abp.Domain.Entities;

namespace PMS.Core
{
    /// <summary>
    /// 客户
    /// </summary>
    public class Client:AggregateRoot<Guid>,IClient
    {
        /// <summary>
        /// 
        /// </summary>
        private string name = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        private string adress = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        private string tel = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        private bool status = false;

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get 
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Adress
        {
            get
            {
                return this.adress;
            }
            set
            {
                this.adress = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Tel
        {
            get
            {
                return this.tel;
            }
            set
            {
                this.tel = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Status
        {
            get
            {
                return this.status;
            }
            set
            {
                this.status = value;
            }
        }
    }
}
