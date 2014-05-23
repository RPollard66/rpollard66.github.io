using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProgram.Data;
using FlooringProgram.Models.DTOs;
using FlooringPrograms.Operations;
using Ninject;

namespace FlooringProgram.UI.WorkFlows
{
    public class DisplayOrdersWorkFlow
    {
        private readonly FetchOrdersMatchingDate _fetchOrdersMatchingDate;


        private List<Order> _ordersToDisplay;


        public DisplayOrdersWorkFlow(FetchOrdersMatchingDate fetchOrdersMatchingDate)
        {
            _fetchOrdersMatchingDate = fetchOrdersMatchingDate;
        }

        public void Execute()
        {
            GetOrderData();
            
        }    
        
        private void GetOrderData()
        {

            _ordersToDisplay = _fetchOrdersMatchingDate.Execute();
            if (_ordersToDisplay == null)
            {
                Console.WriteLine("There are no orders on that date.\n (press enter to continue...)");
                Console.ReadLine();
                return; 
            }
                
            DisplayOrders();
        }

        private void DisplayOrders()
        {
            foreach (var p in _ordersToDisplay)
            {
               Console.WriteLine("{0:D} {1} {2} {3:C}", p.OrderNumber,p.Name,p.ProductType,p.Total); 
            }
            Console.ReadLine();

        }


    }
}
