using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Raids2020.Models
{
    public class Risp
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Исполнитель")]
        public int IspId { get; set; }
        public Nullable<int> RpokazatelId { get; set; }
        [DisplayName("Начало участия")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime Start { get; set; }
        [DisplayName("Завершение участия")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime Stop { get; set; }
        [DisplayName("Id рейда")]
        public int RaidId { get; set; }
        public Nullable<int> EtcId { get; set; }

        public Raid Raid { get; set; }
        public Isp Isp { get; set; }
        public Rpokazatel Rpokazatel { get; set; }
        public List<ExceptionDate> ExceptionDates { get; set; }
    }

}
