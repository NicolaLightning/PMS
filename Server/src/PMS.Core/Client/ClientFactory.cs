using System;
using System.Collections.Generic;
using System.Text;
using Abp.Dependency;

namespace PMS.Core
{
    /// <summary>
    /// 
    /// </summary>
    public class ClientFactory:IClientFactory
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="adress"></param>
        /// <param name="tel"></param>
        /// <returns></returns>
        public IClient Create(string name,string adress,string tel)
        {
            Client client = new Client();
            client.Name = name;
            client.Adress = adress;
            client.Tel = tel;
            return client;
        }
    }
}
