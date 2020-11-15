SELECT TOP (1000) [ModelId]
      ,[FullName]
      ,[ShortName]
      ,[ManufacturerId]
  FROM [alsofits].[dbo].[tbl_Model]
  where [FullName] like '%166%'


  select * from  [alsofits].[dbo].[tbl_Model]
where [ManufacturerId] = 2073


select * from  [alsofits].[dbo].[tbl_Part];
select * from  [alsofits].[dbo].[tbl_PartModel];


delete from [alsofits].[dbo].[tbl_Part] where PartId =3
