using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLabsMVC.Models.Level1
{
    public class LeapYearsResult
    {

        // instantiate the list in a ctor because otherwise it is nullible and will throw an error
        public List<int> LeapYrsList { get; set; } 
        
        public LeapYearsResult()
        {
            LeapYrsList=new List<int>();
        }

        
    }
    
   
}