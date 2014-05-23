using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringProgram.Models.DTOs
{
    public class NewOrderInputType
    {
        public string Name { get; set; }
        public string State { get; set; }
        public string Product { get; set; }
        public DateTime Date { get; set; }
        public decimal Area { get; set; }
    }
}
