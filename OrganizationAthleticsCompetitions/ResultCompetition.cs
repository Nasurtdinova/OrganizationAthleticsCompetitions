//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrganizationAthleticsCompetitions
{
    using System;
    using System.Collections.Generic;
    
    public partial class ResultCompetition
    {
        public int Id { get; set; }
        public Nullable<int> IdRequest { get; set; }
        public Nullable<double> Result { get; set; }
        public Nullable<int> Rank { get; set; }
        public int Score { get; set; }
    
        public virtual Request Request { get; set; }
    }
}
