using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Raids2020.Models
{
    public class File
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RaidId { get; set; }
        public Raid Raid { get; set; }
        public string Discriminator { get; set; }
    }
}
