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

    public partial class Gosplan
    {
        public int Id { get; set; }
        public Nullable<int> PokazatelId { get; set; }
        public Nullable<int> EtcId { get; set; }
        public Nullable<int> TerrId { get; set; }
        [DisplayName("Месяц")]
        public Nullable<int> Month { get; set; }
        [DisplayName("Год")]
        public Nullable<int> Year { get; set; }
        [DisplayName("План")]
        public Nullable<decimal> Plan { get; set; }
    }
}
