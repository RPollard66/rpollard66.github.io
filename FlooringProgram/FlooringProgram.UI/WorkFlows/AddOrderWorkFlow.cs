using System;
using System.Collections.Generic;
using System.Linq;
using FlooringProgram.Models.DTOs;
using FlooringPrograms.Operations;

namespace FlooringProgram.UI.WorkFlows
{
    public class AddOrderWorkFlow
    {
        private readonly TaxRateManager _taxRateManager;
        private readonly OrderManager _orderManager;
        private readonly ProductManager _productManager;

        public string Filename = "Orders_" + DateTime.Today.ToString("MMddyyyy") + ".txt";
        public Order NewOrder = new Order();
        public Calculator Calc = new Calculator();

        public AddOrderWorkFlow(TaxRateManager taxRateManager, OrderManager orderManager, ProductManager productManager)
        {
            _taxRateManager = taxRateManager;
            _orderManager = orderManager;
            _productManager = productManager;
        }

        public void Execute()
        {
            GetUserOrderData();
        }

        private void GetUserOrderData()
        {
            
            GetOrderName(NewOrder);
            GetTaxRate(NewOrder);
            var chosenProduct = GetOrderProduct(NewOrder);
            GetOrderArea(NewOrder);

            //these set values based on the current prod type chosen
            NewOrder.CostPerSquareFoot = chosenProduct.CostPerSquareFoot;
            NewOrder.LaborCostPerSquareFoot = chosenProduct.LaborCostPerSquareFoot;

            Calc.CalculateValues(NewOrder, chosenProduct);
            DisplaySummary(NewOrder);
        }

        private void GetOrderArea(Order order)
        {
            decimal temp;

            Console.Write("Area (square ft): ");
            string userInput = Console.ReadLine();

            while (!decimal.TryParse(userInput, out temp))
            {
                Console.WriteLine("Invalid input");
            }

            order.Area = temp;
        }

        private void GetOrderName(Order order)
        {
            do
            {
                Console.Write("Name: ");
                order.Name = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(order.Name));
        }

        private void GetTaxRate(Order order)
        {
            string userInput;        
            var taxList = _taxRateManager.GetAllTaxRates();

            do
            {
                Console.Write("State (OH, PA, MI, IN): ");
                userInput = Console.ReadLine();
            } while (taxList.All(s => s.State != userInput));
            order.State = userInput;

            // this sets the tax rate based on the current state chosen
            order.TaxRate = taxList.First(x => x.State == order.State).TaxPercent;
        }

        private Product GetOrderProduct(Order order)
        {
            string userInput;
            var prodList = _productManager.GetAllProducts();

            do
            {
                Console.Write("Product Type (Carpet, Laminate, Tile, Wood): ");
                userInput = Console.ReadLine();

            } while (prodList.All(p => p.ProductType != userInput));
            order.ProductType = userInput;

            return prodList.First(p => p.ProductType == userInput);
        }

        private void DisplaySummary(Order order)
        {
            Console.WriteLine("Name: {0}", order.Name);
            Console.WriteLine("State: {0}", order.State);
            Console.WriteLine("Product Type: {0}", order.ProductType);
            Console.WriteLine("Area: {0}", order.Area);
            Console.WriteLine("Cost per square ft: {0:C}", order.CostPerSquareFoot);
            Console.WriteLine("Labor cost per square ft: {0:C}", order.LaborCostPerSquareFoot);
            Console.WriteLine("Material cost: {0:C}", order.MaterialCost);
            Console.WriteLine("Labor cost: {0:C}", order.LaborCost);
            Console.WriteLine("Tax: {0:C}", order.Tax);
            Console.WriteLine("TOTAL COST: {0:C}", order.Total);
            Console.WriteLine();

            string result = GetConfirmation();
            switch (result)
            {
                case "Y":
                    AddNewOrder(order);
                    break;
                case "N":
                    break;
            }


        }

        private string GetConfirmation()
        {

            string userInput;

            do
            {
                Console.WriteLine("Do you wish to confirm this order (Y/N)? ");
                userInput = Console.ReadLine();

            } while (!(userInput == "Y" || userInput == "N"));


            return userInput;


        }

        private void AddNewOrder(Order order)
        {
            var allOrders = GetTodaysOrders();
            order.OrderNumber = GetNextOrderNumber(allOrders);
            allOrders.Add(order);
            _orderManager.SaveOrdersToFile(allOrders, Filename);
        }

        public List<Order> GetTodaysOrders()
        {
            return _orderManager.LoadOrdersFromFile(Filename);
        }

        public int GetNextOrderNumber(List<Order> orders)
        {
            if (orders.Any())
                return orders.Max(o => o.OrderNumber) + 1;

            return 1;
        }


    }
}
