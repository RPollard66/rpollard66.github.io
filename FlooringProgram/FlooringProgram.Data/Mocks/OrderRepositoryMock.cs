using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProgram.Models.DTOs;
using FlooringProgram.Models.Interfaces;

namespace FlooringProgram.Data.Mocks
{
    public class OrderRepositoryMock:IOrderRepository
    {

        public List<Order> LoadOrdersFromFile(string fileName)
        {

            var orders = new List<Order>();
            var order = new Order();
            order.OrderNumber = 1; //int
            order.Name = "Becky";
            order.State = "VT";
            order.TaxRate = 10M;//decimal
            order.ProductType = "Trees";
            order.Area = 100M;//decimal
            order.CostPerSquareFoot = 5M;//decimal
            order.LaborCostPerSquareFoot = 2M;//decimal
            order.MaterialCost = 500M;//decimal
            order.LaborCost = 200M;//decimal
            order.Tax = 50M;//decimal
            order.Total = 750M;//decimal
            orders.Add(order);

            return orders;

            // erics fake order: "Orders_06012013.txt"

            //string[] mockLines = File.ReadAllLines(fileName);
            //foreach (string line in mockLines.Skip(1))
            //{
            //    string[] columns = line.Split('|');

            //    Order order = new Order();
            //    order.OrderNumber = int.Parse(columns[0]);
            //    order.Name = columns[1];
            //    order.State = columns[2];
            //    order.TaxRate = decimal.Parse(columns[3]);
            //    order.ProductType = columns[4];
            //    order.Area = decimal.Parse(columns[5]);
            //    order.CostPerSquareFoot = decimal.Parse(columns[6]);
            //    order.LaborCostPerSquareFoot = decimal.Parse(columns[7]);
            //    order.MaterialCost = decimal.Parse(columns[8]);
            //    order.LaborCost = decimal.Parse(columns[9]);
            //    order.Tax = decimal.Parse(columns[10]);
            //    order.Total = decimal.Parse(columns[11]);
            //    orders.Add(order);
            //}
            //return orders;

        }

        public void SaveOrdersToFile(List<Order> allOrders, string fileName)
        {
            
        }
    }
}
