using System;
using System.Collections.Generic;
using System.Text;
using PMS.Core;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Abp.EntityFrameworkCore;
using System.Linq;

namespace PMS.EntityFrameworkCore
{
    /// <summary>
    /// 
    /// </summary>
    public class ClientMap:IEntityTypeConfiguration<Client>
    {
        #region filed
        private const string ClientId = "ClientId";
        #endregion

        #region public methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public void Configure (EntityTypeBuilder<Client> builder)
        {
            //索引
            builder.HasIndex(m => m.Id);

            //主键
            builder.HasKey(m => new { m.Id });

            //配置列
            builder.Property(m => m.Name).HasColumnName(ClientConst.Name);
            builder.Property(m => m.Adress).HasColumnName(ClientConst.Adress);
            builder.Property(m => m.Tel).HasColumnName(ClientConst.Tel);
            builder.Property(m => m.Status).HasColumnName(ClientConst.Status);
        }
        #endregion
    }
}
