SELECT TOP (1000) [ModelId]
      ,[FullName]
      ,[ShortName]
      ,[ManufacturerId]
  FROM [alsofits].[dbo].[tbl_Model]
  where [FullName] like '%166%'


  select * from  [alsofits].[dbo].[tbl_Model]
where [ManufacturerId] = 2021


select * from  [alsofits].[dbo].[tbl_Manufacturer];
select * from  [alsofits].[dbo].[tbl_PartModel];


delete from [alsofits].[dbo].[tbl_Part] where PartId =3

delete from [alsofits].[dbo].[tbl_Model]
where [ManufacturerId] = 2022