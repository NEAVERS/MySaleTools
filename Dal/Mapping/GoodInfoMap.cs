﻿using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    public class GoodInfoMap: EntityTypeConfiguration<GoodInfo>
    {
        public GoodInfoMap()
        {
            this.ToTable("GoodInfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.GoodsNum).HasColumnName("GoodsNum");
            this.Property(t => t.BarCode).HasColumnName("BarCode");
            this.Property(t => t.MiddleCode).HasColumnName("MiddleCode");
            this.Property(t => t.BoxCode).HasColumnName("BoxCode");
            this.Property(t => t.SupplierId).HasColumnName("SupplierId");
            this.Property(t => t.SupplierNum).HasColumnName("SupplierNum");
            this.Property(t => t.SupplierName).HasColumnName("SupplierName");
            this.Property(t => t.FirstTypeId).HasColumnName("FirstTypeId");
            this.Property(t => t.FirstTypeName).HasColumnName("FirstTypeName");
            this.Property(t => t.SecondTypeId).HasColumnName("SecondTypeId");
            this.Property(t => t.SecondTypeName).HasColumnName("SecondTypeName");
            this.Property(t => t.ThirdTYypeId).HasColumnName("ThirdTYypeId");
            this.Property(t => t.ThirdTypeName).HasColumnName("ThirdTypeName");
            this.Property(t => t.GoodsTittle).HasColumnName("GoodsTittle");
            this.Property(t => t.GoodsSubTittle).HasColumnName("GoodsSubTittle");
            this.Property(t => t.BrandId).HasColumnName("BrandId");
            this.Property(t => t.BrandName).HasColumnName("BrandName");
            this.Property(t => t.RetailtPrice).HasColumnName("RetailtPrice");
            this.Property(t => t.MarketPrice).HasColumnName("MarketPrice");
            this.Property(t => t.CostPrice).HasColumnName("CostPrice");
            this.Property(t => t.Stock).HasColumnName("Stock");
            this.Property(t => t.IsLockStork).HasColumnName("IsLockStork");
            this.Property(t => t.BoxSpec).HasColumnName("BoxSpec");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.Size).HasColumnName("Size");
            this.Property(t => t.ShelfLife).HasColumnName("ShelfLife");
            this.Property(t => t.MinCount).HasColumnName("MinCount");
            this.Property(t => t.LimitCount).HasColumnName("LimitCount");
            this.Property(t => t.pic1).HasColumnName("pic1");
            this.Property(t => t.pic2).HasColumnName("pic2");
            this.Property(t => t.pic3).HasColumnName("pic3");
            this.Property(t => t.pic4).HasColumnName("pic4");
            this.Property(t => t.pic5).HasColumnName("pic5");
            this.Property(t => t.KeyWord).HasColumnName("KeyWord");
            this.Property(t => t.Detail).HasColumnName("Detail");
            this.Property(t => t.CreateUserId).HasColumnName("CreateUserId");
            this.Property(t => t.CreateUserName).HasColumnName("CreateUserName");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.LastUpdateTime).HasColumnName("LastUpdateTime");
            
            this.Property(t => t.IsUpShelves).HasColumnName("IsUpShelves");
            this.Property(t => t.SortId).HasColumnName("SortId");

        }
    }
}
