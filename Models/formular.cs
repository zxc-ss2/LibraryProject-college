//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class formular
    {
        public int formular_id { get; set; }
        public Nullable<int> id_trading { get; set; }
    
        public virtual trading trading { get; set; }
    }
}