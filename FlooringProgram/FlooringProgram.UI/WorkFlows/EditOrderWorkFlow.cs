using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProgram.Data;
using FlooringProgram.Models.DTOs;
using FlooringProgram.Models.Interfaces;
using FlooringPrograms.Operations;

namespace FlooringProgram.UI.WorkFlows
{
    public class EditOrderWorkFlow
    {
        private readonly OrderManager _orderManager;
        private readonly TaxRateManager _taxRateManager;
        private readonly ProductManager _productManager;
        private readonly FetchOrdersMatchingDate _fetchOrdersMatchingDate;

        public string CurrentFile;
        public List<Order> OrdersToDisplay;

        public EditOrderWorkFlow(OrderManager orderManager, TaxRateManager taxRateManager, ProductManager productManager, FetchOrdersMatchingDate fetchOrdersMatchingDate)
        {
            _orderManager = orderManager;
            _taxRateManager = taxRateManager;
            _productManager = productManager;
            _fetchOrdersMatchingDate = fetchOrdersMatchingDate;
        }

        public EditOrderWorkFlow()
        {
            OrdersToDisplay = _fetchOrdersMatchingDate.Execute();
            CurrentFile = _fetchOrdersMatchingDate.CurrentFile;
        }

        public void Execute()
        {

            if (OrdersToDisplay == null)
                return;
            DisplayOrders();
            ChooseOrderToEdit();
        }

        private void DisplayOrders()
        {
            foreach (var p in OrdersToDisplay)
            {
                Console.WriteLine("{0:D} {1} {2} {3:C}", p.OrderNumber, p.Name, p.ProductType, p.Total);
            }
            Console.ReadLine();
        }

        private void ChooseOrderToEdit()
        {

            bool res;
            int userNum;
            do
            {
                Console.WriteLine("Choose order# to edit (press <enter> to cancel): ");
                string userChoice = Console.ReadLine();
                if (string.IsNullOrEmpty(userChoice))
                {
                    var m=new Menu();
                    m.Run();
                }

                res = int.TryParse(userChoice, out userNum);
                if (!res)
                    Console.WriteLine("Invalid choice");

            } while (!res);

            var choice = OrdersToDisplay.FirstOrDefault(p => p.OrderNumber == userNum);

            EditOrder(choice);

        }

        private void EditOrder(Order choice)
        {
            Console.WriteLine("Enter a new value for each field, or press enter to keep current info: ");
            Console.WriteLine();

            Console.Write("Name ({0})", choice.Name);
            string userInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(userInput))
                choice.Name = userInput;

            Console.Write("State ({0})", choice.State);
            userInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(userInput))
            {
                choice.State = userInput;
                UpdateTaxRate(choice);
                UpdateCosts(choice);
            }


            Console.Write("Product Type ({0})", choice.ProductType);
            userInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(userInput))
            {
                choice.ProductType = userInput;
                UpDateProductInfo(choice);
                UpdateCosts(choice);
            }


            Console.Write("Area ({0})", choice.Area);
            userInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(userInput))
            {
                bool res;
                decimal userNum;
                do
                {
                    res = decimal.TryParse(userInput, out userNum);
                    if (!res)
                    {
                        Console.WriteLine("Invalid choice\n");
                        Console.Write("Area ({0})", choice.Area);
                        userInput = Console.ReadLine();
                        res = decimal.TryParse(userInput, out userNum);
                    }
                        

                } while (!res);
                choice.Area = userNum;
                UpdateCosts(choice);
            }
            ConfirmAndUpdateOrder(choice);

        }

        private void UpDateProductInfo(Order choice)
        {


         

            var prodList = _productManager.GetAllProducts();
            var prod = prodList.Find(y => y.ProductType == choice.ProductType);

            choice.CostPerSquareFoot = prod.CostPerSquareFoot;
            choice.LaborCostPerSquareFoot = prod.LaborCostPerSquareFoot;

            var c = new Calculator();
            c.CalculateValues(choice, prod);
        }

        private void UpdateCosts(Order choice)
        {
            
            var prodList = _productManager.GetAllProducts();
            var prod = prodList.Find(y => y.ProductType == choice.ProductType);
            var c = new Calculator();
            c.CalculateValues(choice, prod);

        }


        private void UpdateTaxRate(Order choice)
        {
           
            var taxList = _taxRateManager.GetAllTaxRates();

            var res = taxList.Find(p => p.State == choice.State);
            choice.TaxRate = res.TaxPercent;

        }

        private void ConfirmAndUpdateOrder(Order choice)
        {
            Console.Clear();

            string userConfirm;

            do
            {
                Console.WriteLine("{0} {1} {2} {3}\n", choice.OrderNumber, choice.Name, choice.ProductType, choice.Total);
                Console.WriteLine("Confirm update of order? (Y/N)");
                userConfirm = Console.ReadLine();

            } while (!(userConfirm == "Y" || userConfirm == "N"));

            switch (userConfirm)
            {
                case "Y":
                    SaveUpdatedFile();
                    break;

                case "N":
                    break;
            }
        }

        private void SaveUpdatedFile()
        {
            
            _orderManager.SaveOrdersToFile(OrdersToDisplay, CurrentFile);

        }


        
    }
}
