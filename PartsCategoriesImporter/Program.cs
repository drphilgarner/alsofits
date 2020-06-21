using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using Dapper;
namespace PartsCategoriesImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opening parts categories");

            var lines =File.ReadLines("PartsCategories.txt").ToList();
                
            bool isNewCategory = false;


            var insertParent = "INSERT INTO tbl_PartCategoryParent (FullName) OUTPUT INSERTED.[PartCategoryParentId] values (@FullName);";
            var insertChild = "INSERT INTO tbl_PartCategoryChild (FullName, PartCategoryParentId) OUTPUT INSERTED.[PartCategoryChildId] values (@FullName, @PartCategoryParentId)";
            
            var connStr = new SqlConnectionStringBuilder{
                DataSource = "192.168.1.94",
                InitialCatalog = "alsofits",
                Password = "t6;h5W`AVTv[L+>7",
                UserID = "sa"
            };

            var parentCategory = String.Empty;
            int parentId =0;

            using (var conn = new SqlConnection(connStr.ToString())){

                foreach (var line in lines){
                

                    if (isNewCategory){
                        isNewCategory = false;
                        parentCategory = line.Trim();

                        var parentRow = conn.QuerySingle<int>(insertParent, new {FullName = parentCategory} );
                        parentId = parentRow;

                        continue;
                    }

                    if (line == ""){
                        //new category
                        isNewCategory = true;
                        continue;
                    }
                    else{
                        //this is a category row
                        var childRow = conn.QuerySingle<int>(insertChild, new {FullName = line.Trim(), PartCategoryParentId = parentId});
                    }
                }
                
            }
        }
    }
}
