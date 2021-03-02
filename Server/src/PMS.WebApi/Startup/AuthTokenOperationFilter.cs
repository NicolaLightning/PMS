

namespace PMS.Web.Host
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.OpenApi.Models;
    using Swashbuckle.AspNetCore.SwaggerGen;

    /// <summary>
    /// Swagger Token 参数拦截器
    /// </summary>
    public class AuthTokenOperationFilter:IOperationFilter
    {
        /// <summary>
        /// 接口方法
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="context"></param>
        public void Apply(OpenApiOperation operation,OperationFilterContext context)
        {
            if(operation.Parameters == null)
            {
                operation.Parameters = new List<OpenApiParameter>();
            }
            operation.Parameters.Add(new OpenApiParameter()
            {
                Name = "Token",
                In = ParameterLocation.Header,
                Required = false
            });
        }
    }
}
