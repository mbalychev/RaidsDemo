using Microsoft.EntityFrameworkCore.Query.ExpressionVisitors.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Raids2020.Models.Filtering
{
    public class FilterRaids
    {
        public int TerrId { get; set; }
        public string NomerRaid { get; set; }
        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }
        public string Sort { get; set; }

        public FilterRaids()
        {
            DateTime today = DateTime.Today;

            TerrId = 0;
            NomerRaid = "";
            Start = today.AddMonths(-3);
            Stop = today;
        }

    }
}
