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
    using System.ComponentModel;
    using System;
    using System.Collections.Generic;
    
    public partial class Fuel
    {
        public int Id { get; set; }
        public int GradeId { get; set; }
        [DisplayName("Дата")]
        public Nullable<System.DateTime> Date { get; set; }
        [DisplayName("Стоимость")]
        public Nullable<decimal> Coast { get; set; }
        [DisplayName("Количество")]
        public decimal Amount { get; set; }
        public int RpokazatelId { get; set; }

        
    }
}