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

    public partial class Rfile
    {
        public int Id { get; set; }
        [DisplayName("Файл")]
        public string Name { get; set; }
        public int RpokazatelId { get; set; }
        public Nullable<int> RaidId { get; set; }
    }
}
