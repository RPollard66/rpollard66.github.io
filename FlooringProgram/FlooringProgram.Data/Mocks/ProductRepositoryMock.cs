using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProgram.Models.DTOs;
using FlooringProgram.Models.Interfaces;

namespace FlooringProgram.Data.Mocks
{
    public class ProductRepositoryMock: IProductRepository
    {
        public List<Product> GetAllProducts()
        {
            return new List<Product>()
            {
                new Product() {CostPerSquareFoot = 1.00M, LaborCostPerSquareFoot = 1.00M, ProductType = "Bamboo"},
                new Product() {CostPerSquareFoot = 100.00M, LaborCostPerSquareFoot = 100.00M, ProductType = "Moon Rock"},
                new Product() {CostPerSquareFoot = 5.00M, LaborCostPerSquareFoot = 2.00M, ProductType = "Trees"}
            };
        }
    }
}
