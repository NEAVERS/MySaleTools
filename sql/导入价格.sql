/****** Script for SelectTopNRows command from SSMS  ******/
SELECT  p.typeId,p.SaleUnitId,p.baseUnitId,pue.Rate,pue.Rate*price.PreBuyPrice1
  FROM [V3_DataTOP].[dbo].[ptype] p 
  join [PType_Units_Ext] pue on p.typeId = pue.PtypeID and pue.UnitsId = p.SaleUnitId
  join [V3_DataTOP].[dbo].[PType_Price] price on p.typeId  =price.PTypeID;
