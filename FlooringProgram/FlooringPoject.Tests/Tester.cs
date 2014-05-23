using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProgram.Data;
using FlooringProgram.Data.Mocks;
using FlooringProgram.Models.DTOs;
using FlooringProgram.UI.WorkFlows;
using FlooringPrograms.Operations;
using NUnit.Framework;

namespace FlooringPoject.Tests
{
    [TestFixture]
    internal class Tester
    {
        [Test]
        public void LoadFileTest()
        {
            string fake = "fake";

            var fm = new OrderManager(new OrderRepositoryMock());

            List<Order> actual = fm.LoadOrdersFromFile(fake);
            Assert.IsTrue(actual != null);

        }

        [Test]
        public void WriteToFileTest()
        {
            string fake = "fake";

            var saveInput = new List<Order>();
            var testOrder = new Order();
            testOrder.OrderNumber = 1;
            testOrder.Name = "Smith";
            testOrder.State = "OH";
            testOrder.TaxRate = .10M;
            testOrder.ProductType = "Carpet";
            testOrder.Area = 10M;
            testOrder.CostPerSquareFoot = 2M;
            testOrder.LaborCostPerSquareFoot = 5M; 
            // normally this is where we would stop entering data and
            // and the Calculator would be called to finish computing the 
            // last four values for the order
            testOrder.MaterialCost = testOrder.Area * testOrder.CostPerSquareFoot;
            testOrder.LaborCost = testOrder.LaborCostPerSquareFoot * testOrder.Area;
            testOrder.Tax = testOrder.TaxRate * testOrder.MaterialCost;
            testOrder.Total = testOrder.MaterialCost + testOrder.LaborCost + testOrder.Tax;

            saveInput.Add(testOrder);
            var fm = new OrderManager(new OrderRepository());
            fm.SaveOrdersToFile(saveInput,fake);


        }

        [Test]
        public void TestMockOrder()
        {
            
            var fm = new OrderManager(new OrderRepositoryMock());
            List<Order> fakeOrder= fm.LoadOrdersFromFile("doesItIgnoreThisFileName?");//yes, it just wanted a string input
            var Order = fakeOrder.Any(p => p.Name == "Becky");
            Assert.IsTrue(Order);

        }




        // erics fake order "Orders_06012013.txt"

        //[Test]
        //public void TestOrderNumAssignment()
        //{
        //    var testOrder=new Order();
        //    testOrder.Name = "Smith";
        //    testOrder.State = "OH";
        //    testOrder.TaxRate = 0.10M;
        //    testOrder.ProductType = "Carpet";
        //    testOrder.Area = 5M;
        //    testOrder.CostPerSquareFoot = 2M;
        //    testOrder.LaborCostPerSquareFoot = 1M;
        //    testOrder.MaterialCost = 4M;
        //    testOrder.LaborCost = 10M;
        //    testOrder.Tax = 10M;
        //    testOrder.Total = 10M;

        //    var p=new AddOrderWorkFlow();
        //    var list= p.GetTodaysOrders();
        //    int n =p.GetNextOrderNumber(list);
        //    Assert.IsTrue(n==1);

        //}

    }

}
