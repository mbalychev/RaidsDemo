using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Raids2020.Models
{
    public class FileDocument
    {
        [Required]
        public int Id { get; set; }
        public int RpokazatelId { get; set; }
        [DisplayName("Файл")]
        public string Name { get; set; }


    }
}
