using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProgram.Models.DTOs;
using FlooringProgram.Models.Interfaces;

namespace FlooringPrograms.Operations
{
    public class OrderManager
    {
        private IOrderRepository _myOrderRepository;

        public OrderManager(IOrderRepository orderRepository)
        {
            _myOrderRepository = orderRepository;
        }

        public List<Order> LoadOrdersFromFile(string f)
        {
            return _myOrderRepository.LoadOrdersFromFile(f);

        }

        public void SaveOrdersToFile(List<Order> allOrders, string fileName)
        {
            _myOrderRepository.SaveOrdersToFile(allOrders,fileName);
        }
    }
}
