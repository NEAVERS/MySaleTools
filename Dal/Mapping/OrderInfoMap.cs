﻿using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    public class OrderInfoMap : EntityTypeConfiguration<OrderInfo>
    {
        public OrderInfoMap()
        {
            this.HasKey(t => t.Id);
            this.ToTable("OrderInfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.OrderNum).HasColumnName("OrderNum");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.Stutas).HasColumnName("Stutas");
            this.Property(t => t.SendPeople).HasColumnName("SendPeople");
            this.Property(t => t.PayTime).HasColumnName("PayTime");
            this.Property(t => t.SendTime).HasColumnName("SendTime");
            this.Property(t => t.PayType).HasColumnName("PayType");
            this.Property(t => t.TotalMoney).HasColumnName("TotalMoney");
            this.Property(t => t.LessMoney).HasColumnName("LessMoney");
            this.Property(t => t.RealMoney).HasColumnName("RealMoney");
            this.Property(t => t.PayMoney).HasColumnName("PayMoney");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.RootUserId).HasColumnName("RootUserId");
            this.Property(t => t.RootUserName).HasColumnName("RootUserName");
            this.Property(t => t.CreateUserId).HasColumnName("CreateUserId");
            this.Property(t => t.CreateUserName).HasColumnName("CreateUserName");
            this.Property(t => t.CreateUserTypeId).HasColumnName("CreateUserTypeId");
            this.Property(t => t.CreateUserType).HasColumnName("CreateUserType");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.SaleManGuid).HasColumnName("SaleManGuid");
            this.Property(t => t.SaleManName).HasColumnName("SaleManName");

        }

    }
}