using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProgram.Models.DTOs;
using FlooringProgram.Models.Interfaces;

namespace FlooringPrograms.Operations
{
    public class ProductManager
    {
        private IProductRepository _myProductRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _myProductRepository = productRepository;
        }

        public List<Product> GetAllProducts()
        {
            return _myProductRepository.GetAllProducts();
        }


    }
}
