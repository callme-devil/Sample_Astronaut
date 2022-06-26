using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample_Astronaut.Models
{
    public class WorksViewModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public WorksViewModel(long id , string name , string description , string image)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
        }
    }

}
