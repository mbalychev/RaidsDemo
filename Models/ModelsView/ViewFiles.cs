using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Raids2020.Models.ModelsView
{
    public class ViewFiles 
    {
        public List<Order> Orders { get; set; }
        public List<Task> Tasks { get; set; }
        public List<Act> Acts { get; set; }

        public ViewFiles (Raid raid)
        {
            Acts = raid.Acts;
            Orders = raid.Orders;
            Tasks = raid.Tasks;
        }
    }
}
