using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Raids2020.Models
{
    public class Doc : File
    {
        public int RpokazatelId { get; set; }

        public Rpokazatel Rpokazatel { get; set; }
    }
}
