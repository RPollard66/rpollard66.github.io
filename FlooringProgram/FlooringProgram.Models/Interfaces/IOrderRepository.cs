using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProgram.Models.DTOs;

namespace FlooringProgram.Models.Interfaces
{
    public interface IOrderRepository
    {
        List<Order> LoadOrdersFromFile(string fileName);

        void SaveOrdersToFile(List<Order> allOrders, string fileName);


    }
}
