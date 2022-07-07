using System.Collections.Generic;
using System.Linq;
using Sample_Astronaut.Models;

namespace Sample_Astronaut.Data
{
    public class WorksStore
    {
        public static List<WorksViewModel> GetWorks()
        {
            return new List<WorksViewModel>
            {
                
                new WorksViewModel(1 , "Lorem Ipsum" , "Nulla facilisi. Vivamus vestibulum, elit in scelerisque ultricies." , "work01-hover.jpg"),
                new WorksViewModel(2 , "Lorem Ipsum" , "Nulla facilisi. Vivamus vestibulum, elit in scelerisque ultricies." , "work02-hover.jpg"),
                new WorksViewModel(3 , "Lorem Ipsum" , "Nulla facilisi. Vivamus vestibulum, elit in scelerisque ultricies." , "work03-hover.jpg"),
            };
        }

        public static WorksViewModel GEtProjectBy(long id)
        {
            return GetWorks().FirstOrDefault(x => x.Id == id);
        }
    }
}
