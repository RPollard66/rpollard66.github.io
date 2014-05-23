using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProgram.Data;
using FlooringProgram.Data.Mocks;
using FlooringProgram.Models.Interfaces;
using Ninject.Modules;

namespace FlooringPrograms.Operations
{
    public class FlooringMasteryModule:NinjectModule
    {
        public override void Load()
        {
            Bind<ITaxRateRepository>().To<TaxRateRepository>();
            Bind<IProductRepository>().To<ProductRepository>();
            Bind<IOrderRepository>().To<OrderRepository>();
        }
    }
}
