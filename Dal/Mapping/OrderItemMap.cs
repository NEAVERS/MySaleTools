﻿using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    public class OrderItemMap : EntityTypeConfiguration<OrderItem>
    {
        public OrderItemMap()
        {
            this.HasKey(t => t.Id);
            this.Property(t=>t.LessPrice).HasPrecision(30, 20);
            this.Property(t => t.Price).HasPrecision(30, 20);
            this.Property(t => t.RealPrice).HasPrecision(30, 20);
            this.Property(t => t.TotalPrice).HasPrecision(30, 20);
            
            this.ToTable("OrderItem");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.OrderNum).HasColumnName("OrderNum");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ProductTittle).HasColumnName("ProductTittle");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.RealPrice).HasColumnName("RealPrice");
            this.Property(t => t.Count).HasColumnName("Count");
            this.Property(t => t.TotalPrice).HasColumnName("TotalPrice");
            this.Property(t => t.LessPrice).HasColumnName("LessPrice");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.IsEffective).HasColumnName("IsEffective");
            this.Property(t => t.IsInShoppingCar).HasColumnName("IsInShoppingCar");
            this.Property(t => t.CreateUserId).HasColumnName("CreateUserId");
            this.Property(t => t.Pic).HasColumnName("Pic");
            this.Property(t => t.ProductType).HasColumnName("ProductType");
            this.Property(t => t.ProductTypeId).HasColumnName("ProductTypeId");
            this.Property(t => t.BarCode).HasColumnName("BarCode");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.SupplierId).HasColumnName("SupplierId");
            this.Property(t => t.SupplierName).HasColumnName("SupplierName");
            this.Property(t => t.Brand).HasColumnName("Brand");
            this.Property(t => t.BrandId).HasColumnName("BrandId");


            this.Property(t => t.IsError).HasColumnName("IsError");
            this.Property(t => t.ErrorTypeCode).HasColumnName("ErrorTypeCode");
            this.Property(t => t.ErrorType).HasColumnName("ErrorType");
            this.Property(t => t.ErrorReasonCode).HasColumnName("ErrorReasonCode");
            this.Property(t => t.ErrorReason).HasColumnName("ErrorReason");
            this.Property(t => t.ErrorMark).HasColumnName("ErrorMark");
            this.Property(t => t.ErrorCount).HasColumnName("ErrorCount");
            this.Property(t => t.IsGift).HasColumnName("IsGift");
            
        }
    }
}
