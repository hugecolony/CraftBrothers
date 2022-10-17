using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftBrothers.Entities
{
    public class Product : BaseEntity
    {
        // relationship 
        public Category Category { get; set; }
        public Brand Brand { get; set; }    

        // each product have a specific category

        public decimal Price { get; set; }


    }
}
