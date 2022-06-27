using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample_Astronaut.Models
{
    public class ContactorsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public ContactorsViewModel(int id , string name)
        {
            Id = id;
            Name = name;
        }
    }
}
