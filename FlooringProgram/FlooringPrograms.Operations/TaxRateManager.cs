using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProgram.Models.DTOs;
using FlooringProgram.Models.Interfaces;

namespace FlooringPrograms.Operations
{
    public class TaxRateManager
    {
        private ITaxRateRepository _myTaxRateRepository;

        public TaxRateManager(ITaxRateRepository taxRateRepository)
        {
            _myTaxRateRepository = taxRateRepository;
        }

        public List<TaxRate> GetAllTaxRates()
        {
            return _myTaxRateRepository.GetAllTaxRates();
        }

        
    }
}
