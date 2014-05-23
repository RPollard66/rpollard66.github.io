using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProgram.Models.DTOs;
using FlooringProgram.Models.Interfaces;

namespace FlooringProgram.Data
{
     public class ProductRepository:IProductRepository
    {
         public List<Product> GetAllProducts()
         {
             List<Product> prodList = new List<Product>();
             string[] allLines = File.ReadAllLines("Products.txt");
             foreach (var line in allLines.Skip(1))
             {
                 string[] columns = line.Split('|');
                 var productInfo = new Product();

                 productInfo.ProductType = columns[0];
                 productInfo.CostPerSquareFoot = decimal.Parse(columns[1]);
                 productInfo.LaborCostPerSquareFoot = decimal.Parse(columns[2]);
                 prodList.Add(productInfo);

             }
             return prodList;
             
         }



         // MY OLD CODE PRE-INTERFACES
        //public List<Product> LoadProductsFromFile()
        //{
        //    string fileName = "Products.txt";
        //    string[] allLines = File.ReadAllLines(fileName);
        //    return ProductListFromArray(allLines);
        //}

        //private List<Product> ProductListFromArray(string[] allLines)
        //{
        //    var prodList = new List<Product>();
        //    foreach (var line in allLines.Skip(1))
        //    {
        //        string[] columns = line.Split('|');
        //        var productInfo = new Product();

        //        productInfo.ProductType = columns[0];
        //        productInfo.CostPerSquareFoot = decimal.Parse(columns[1]);
        //        productInfo.LaborCostPerSquareFoot=decimal.Parse(columns[2]);
        //        prodList.Add(productInfo);

        //    }
        //    return prodList;
        //}


         //ERICs code:
         //var allLines = File.ReadAllLines("Products.txt");

         //    for (int i = 1; i < allLines.Length; i++)
         //    {
         //        var columns = allLines[i].Split(',');

         //        Product product = new Product();
         //        product.ProductType = columns[0];
         //        product.CostPerSquareFoot = decimal.Parse(columns[1]);
         //        product.LaborCostPerSquareFoot = decimal.Parse(columns[2]);

         //        products.Add(product);
         //    }

         //    return products;




    }
}
