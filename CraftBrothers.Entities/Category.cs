using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftBrothers.Entities
{
    public  class Category : BaseEntity
    {
        // ID
        //public int ID { get; set; }

        //adding property
        //public string Name { get; set; }
        //public string Description { get; set; }
       // categeory have list of product 
       // one to many
        public List<Product> Products { get; set; }
    }
}
