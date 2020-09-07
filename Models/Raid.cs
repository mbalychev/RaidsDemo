using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Raids2020.Models
{
    public partial class Raid
    {
        private DateTime stop;

        public int Id { get; set; }

        [Required(ErrorMessage = "Необходимо указать номер рейда")]
        [Remote (action: "CheckNomer", controller: "Raids", ErrorMessage ="Рейд с таким номером уже существует")]
        [DisplayName("Номер")] 
        public string Nomer { get; set; }

        [Required (ErrorMessage ="Необходимо указать номер приказа")]
        [DisplayName("Приказ")]
        public string Prikaz { get; set; }

        [Required(ErrorMessage = "Необходимо указать дату начало рейда")]
        [DisplayName("Начало")]
        [DataType(DataType.Date)]
        public System.DateTime Start { get; set; }

        [DisplayName("Завершение")]
        [Required(ErrorMessage = "Необходимо указать дату завершения рейда")]
        [DataType(DataType.Date)]
        public DateTime Stop
        {
            get => stop;
            set
            {
                DateTime date = value;
                if (date >= this.Start)
                    stop = value;
            }
        }

        [Required(ErrorMessage = "Необходимо указать территорию")]
        [DisplayName("Территория")]
        public int TerrId { get; set; }
        
        [DisplayName("Завершен")]
        public bool Close { get; set; }

        public int NumberInt
        {
            get
            {
                try { return Convert.ToInt32(this.Nomer); } catch (Exception e) { return 0; }
            }
        }

        public Terr Terr { get; set; }
        public List<Risp> Risp { get; set; }
        
        public List<Act> Acts { get; set; }
        public List<Task> Tasks { get; set; }
        public List<Order> Orders { get; set; }
        public List<Protocol> Protocols { get; set; }
        public List<Rpokazatel> Rpokazatel { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
