//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Polic.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class RepiceId
    {
        public int Id { get; set; }
        public string PreparationName { get; set; }
        public Nullable<System.DateTime> DateStart { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
        public Nullable<int> MedCardId { get; set; }
    
        public virtual MedCard MedCard { get; set; }
    }
}
