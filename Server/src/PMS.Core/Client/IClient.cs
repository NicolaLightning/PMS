using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;

namespace PMS.Core
{
    /// <summary>
    /// 
    /// </summary>
    public interface IClient : IAggregateRoot<Guid>
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 
        /// </summary>
        public string Adress { get; }

        /// <summary>
        /// 
        /// </summary>
        public string Tel { get; }
    }
}
