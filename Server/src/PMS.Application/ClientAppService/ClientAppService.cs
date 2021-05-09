using System;
using System.Collections.Generic;
using System.Text;
using PMS.Core;
using Microsoft.AspNetCore.Mvc;

namespace PMS.Application
{
    /// <summary>
    /// 
    /// </summary>
    public class ClientAppService: PMSAppServiceBase,IClientAppService
    {
        #region fileds
        /// <summary>
        /// 
        /// </summary>
        IClientRepository _clientRepository = null;

        IClientFactory _clientFactory = null;
        #endregion

        #region constructor
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="clientRepository"></param>
        public ClientAppService(IClientRepository clientRepository, IClientFactory clientFactory)
        {
            _clientRepository = clientRepository;
            _clientFactory = clientFactory;
        }
        #endregion

        #region public methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public QueryClientOutput QueryClientInfo(string id)
        {
            QueryClientOutput output = new QueryClientOutput();
            //IClient client = this._clientRepository.Query(id);
            output.Adress = "xxxx";
            return output;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public bool AddClient(AddClientInput input)
        {
            QueryClientOutput output = new QueryClientOutput();
            IClient client = _clientFactory.Create(input.Name,input.Adress,input.Tel);
            bool ret = this._clientRepository.Insert(client);
            return ret;
        }
        #endregion

    }
}
