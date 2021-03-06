//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Raids2020.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;


    public class Rpokazatel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [DisplayName("Показатель")]
        public int PokazatelId { get; set; }
        [Required]
        [DisplayName("Уточнение")]
        public int EtcId { get; set; }
        [Required]
        [DisplayName("Рейд")]
        public int RaidId { get; set; }
        [DisplayName("Значение")]
        public decimal Amount { get; set; }
        public Nullable<int> ChapterId { get; set; }
        public Nullable<int> FuelId { get; set; }

        public Pokazatel Pokazatel { get; set; }
        public Etc Etc { get; set; }
        public List<Doc> Docs { get; set; }
        public List<Pisp> Pisps { get; set; }
    }
}
