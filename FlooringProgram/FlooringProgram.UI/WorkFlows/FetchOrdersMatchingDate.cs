using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProgram.Data;
using FlooringProgram.Models.DTOs;
using FlooringProgram.Models.Interfaces;
using FlooringPrograms.Operations;

namespace FlooringProgram.UI.WorkFlows
{
    public class FetchOrdersMatchingDate
    {
        private readonly OrderManager _orderManager;
        public string CurrentFile;
        public string UserInput;
        public List<Order> Orders;

        public FetchOrdersMatchingDate(OrderManager orderManager)
        {
            _orderManager = orderManager;
        }


        public List<Order> Execute()
        {
            QueryUserForFileName();
            SearchForFileByDate(UserInput);
            return Orders;
        }
        
        private void QueryUserForFileName()
        {
            Console.WriteLine("Enter the date of the order in the format MMDDYYYY: ");
            UserInput = Console.ReadLine();
            

        }

        private void SearchForFileByDate(string userInput)
        {
            if (!File.Exists("Orders_"+userInput+".txt"))
            {
                Console.WriteLine("No orders exist on that date.");
                return;
                
            }
            CurrentFile = "Orders_" + userInput + ".txt";
            GetListOfOrdersByDate(CurrentFile);
        }

        private void GetListOfOrdersByDate(string currentFile)
        {
                       
            Orders= _orderManager.LoadOrdersFromFile(currentFile);
           
        }
    }
}
