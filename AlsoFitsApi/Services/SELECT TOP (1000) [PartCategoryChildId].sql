SELECT TOP (1000) [PartCategoryChildId]
      ,[FullName]
      ,[PartCategoryParentId]
  FROM [alsofits].[dbo].[tbl_PartCategoryChild]
  where [FullName] like '%control%'