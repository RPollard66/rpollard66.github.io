using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProgram.Models.DTOs;
using FlooringProgram.Models.Interfaces;

namespace FlooringProgram.Data.Mocks
{
    public class TaxRateRepositoryMock: ITaxRateRepository
    {
        public List<TaxRate> GetAllTaxRates()
        {
            return new List<TaxRate>()
            {
                new TaxRate() { State="VT", TaxPercent = 0.10M},
                new TaxRate() { State="CA", TaxPercent = 0.50M}
            };
        }
    }
}
