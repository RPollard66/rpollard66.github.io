using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FlooringProgram.Data;
using FlooringProgram.Models.DTOs;
using FlooringPrograms.Operations;

namespace FlooringProgram.UI.WorkFlows
{
    
    
    public class RemoveOrderWorkFlow
    {
        private readonly FetchOrdersMatchingDate _fetchOrdersMatchingDate;
        private readonly OrderManager _orderManager;
        public string CurrentFile;
        public List<Order> OrdersToDisplay;

        public RemoveOrderWorkFlow(FetchOrdersMatchingDate fetchOrdersMatchingDate, OrderManager orderManager)
        {
            _fetchOrdersMatchingDate = fetchOrdersMatchingDate;
            _orderManager = orderManager;
        }

        public RemoveOrderWorkFlow()
        {
            OrdersToDisplay = _fetchOrdersMatchingDate.Execute();
            CurrentFile = _fetchOrdersMatchingDate.CurrentFile;
        }

        public void Execute()
        {
                       
            if (OrdersToDisplay == null)
                return;
            DisplayOrders();
            ChooseOrderToRemove();
        }

        private void DisplayOrders()
        {
            foreach (var p in OrdersToDisplay)
            {
                Console.WriteLine("{0:D} {1} {2} {3:C}", p.OrderNumber, p.Name, p.ProductType, p.Total);
            }
            Console.ReadLine();
        }

        private void ChooseOrderToRemove()
        {

            bool res;
            int userNum;
            do
            {
                Console.WriteLine("Choose order# to remove (press <enter> to cancel): ");
                string userChoice = Console.ReadLine();
                if (string.IsNullOrEmpty(userChoice))
                {
                    var m = new Menu();
                    m.Run();
                }

                res = int.TryParse(userChoice, out userNum);
                if(!res)
                    Console.WriteLine("Invalid choice");

            } while (!res);   

            var choice = OrdersToDisplay.FirstOrDefault(p => p.OrderNumber == userNum);

            DeleteOrder(choice);

        }

        private void DeleteOrder(Order choice)
        {
            Console.Clear();
            
            string userConfirm;
            
            do
            {
                Console.WriteLine("{0} {1} {2} {3}\n",choice.OrderNumber, choice.Name, choice.ProductType, choice.Total);         
                Console.WriteLine("Confirm deletion of order? (Y/N)");
                userConfirm = Console.ReadLine();

            } while (!(userConfirm=="Y" || userConfirm=="N"));

            switch (userConfirm)
            {
                case "Y":
                    OrdersToDisplay.Remove(choice);
                    SaveUpdatedFile();
                    break;

                case "N":
                    break;
            }
            
        }

        private void SaveUpdatedFile()
        {
            
            _orderManager.SaveOrdersToFile(OrdersToDisplay,CurrentFile);
        
        }
    }
}
