USE [SaleTools]
GO

INSERT INTO [dbo].[GoodInfo]
           ([Id]
           ,[GoodsNum]
           ,[BarCode]
           ,[MiddleCode]
           ,[BoxCode]
           ,[SupplierId]
           ,[SupplierNum]
           ,[SupplierName]
           ,[FirstTypeId]
           ,[FirstTypeName]
           ,[SecondTypeId]
           ,[SecondTypeName]
           ,[ThirdTYypeId]
           ,[ThirdTypeName]
           ,[GoodsTittle]
           ,[GoodsSubTittle]
           ,[BrandId]
           ,[BrandName]
           ,[RetailtPrice]
           ,[MarketPrice]
           ,[CostPrice]
           ,[Stock]
           ,[IsLockStork]
           ,[BoxSpec]
           ,[Spec]
           ,[Unit]
           ,[Weight]
           ,[Size]
           ,[ShelfLife]
           ,[MinCount]
           ,[LimitCount]
           ,[pic1]
           ,[pic2]
           ,[pic3]
           ,[pic4]
           ,[pic5]
           ,[KeyWord]
           ,[Detail]
           ,[CreateUserId]
           ,[CreateUserName]
           ,[IsDelete]
           ,[CreateTime]
           ,[LastUpdateTime]
           ,[SortId]
           ,[IsUpShelves]
           ,[ErpId]
           ,[BasePrice]
           ,[PriceForA]
           ,[PriceForB]
           ,[PriceForC]
           ,[PriceForD]
           ,[PriceForLianSuo])
     select 
           newid()
		   ,STR(F2, 11, 0)
		   ,F4
		   ,''
		   ,''
		   ,-1
		   ,''
		   ,F6
		   ,'00000000-0000-0000-0000-000000000000'
		   ,''
           ,'00000000-0000-0000-0000-000000000000'
           ,''
           ,'00000000-0000-0000-0000-000000000000'
           ,''
           ,[售价关联基本单位单价数，数量关联基本单位数量]
           ,[售价关联基本单位单价数，数量关联基本单位数量]
           ,'00000000-0000-0000-0000-000000000000'
           ,F7
           ,F14
           ,F14
           ,F12
           ,-1
           ,0
           ,F10
           ,F10
           ,F8
           ,''
           ,''
           ,12
           ,F10
           ,0
           ,''
          ,''
           ,''
           ,''
           ,''
           ,''
           ,''
           ,'A77D5476-501F-4F50-A5AB-B364E8F92F21'
           ,'管理员'
           ,0
           ,'2018-9-10'
           ,'2018-9-10'
           ,1
           ,1
           ,'-1'
           ,0
           ,0
           ,0
           ,0
           ,0
           ,F14 FROM [SaleTools].[dbo].[导出数据$]

	update b  set b.BrandId = a.Id from goodsbrand a ,GoodInfo b  where ErpId = '-1' and a.BrandName=b.BrandName
  
  
  update b  set b.SupplierId = a.Id ,b.SupplierNum = a.SupplierNum from Supplier a ,GoodInfo b  where ErpId = '-1' and a.SupplierName=b.SupplierName
  
  
  update GoodInfo set pic1 = '/GoodImg/Imgs/'+BarCode+'.jpg' where ErpId ='-1'
  
  
  select a.UserCode,b.GoodsNum from  [V3_DataTOP].[dbo].[ptype] a ,GoodInfo b  where ErpId = '-1' and a.EntryCode=b.BarCode
  
  update b  set b.ErpId = a.typeId from [V3_DataTOP].[dbo].[ptype] a ,GoodInfo b  where ErpId = '-1' and a.EntryCode=b.BarCode