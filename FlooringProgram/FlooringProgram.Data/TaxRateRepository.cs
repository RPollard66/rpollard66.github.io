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
    public class TaxRateRepository:ITaxRateRepository
    {
        public List<TaxRate> GetAllTaxRates()
        {
            var taxesByState = new List<TaxRate>();
            var allLines = File.ReadAllLines("Taxes.txt");

            foreach (var line in allLines.Skip(1))
            {
                string[] columns = line.Split('|');
                var taxSchedule = new TaxRate();

                taxSchedule.State = columns[0];
                taxSchedule.TaxPercent = decimal.Parse(columns[1])/100;
                taxesByState.Add(taxSchedule);
            }
            return taxesByState;
            
        }
        
        // THIS IS PRE-INTERFACES CODE
        //public List<TaxRate> LoadTaxesAndStatesFromFile()
        //{
        //    string fileName = "Taxes.txt";
        //    string[] allLines = File.ReadAllLines(fileName);
        //    return TaxesListFromArray(allLines);
        //}

        //private List<TaxRate> TaxesListFromArray(string[] allLines)
        //{
        //    var taxesByState = new List<TaxRate>();
        //    var allLines = File.ReadAllLines("Taxes.txt");

            //foreach (var line in allLines.Skip(1))
            //{
            //    string[] columns = line.Split('|');
            //    var taxSchedule = new TaxRate();

            //    taxSchedule.State = columns[0];
            //    taxSchedule.TaxPercent = decimal.Parse(columns[1]);
            //    taxesByState.Add(taxSchedule);
            //}
            //return taxesByState;
        //}


        // ERICs code:
        //for (int i = 1; i < allLines.Length; i++)
        //{
        //    var columns = allLines[i].Split(',');

        //    TaxRate rate = new TaxRate();
        //    rate.State = columns[0];
        //    rate.TaxPercent = decimal.Parse(columns[1]);

        //    rates.Add(rate);
        //}

        //return rates;
    }
}
