//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrganizationAthleticsCompetitions.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProgramCompetition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProgramCompetition()
        {
            this.Request = new HashSet<Request>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdCompetition { get; set; }
        public Nullable<int> IdTypeProgram { get; set; }
        public Nullable<int> IdTypeCompetition { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public TimeSpan TimeStart { get; set; }
        public Nullable<int> MaxCountAttendees { get; set; }
        public Nullable<int> CountAttendees { get; set; }
        public string Gender { get; set; }
        public Nullable<bool> IsDeleted { get; set; }

        public string ProgramCompet => $"{TypeProgram.Name} {TypeCompetition.Name}";
        public string VisibilityResult { get 
            {
                if (Date.Value.Date <= DateTime.Now.Date)
                    return "Visibility";
                else
                    return "Collapsed";
            } }
        public virtual Competition Competition { get; set; }
        public virtual Gender Gender1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Request> Request { get; set; }
        public virtual TypeCompetition TypeCompetition { get; set; }
        public virtual TypeProgram TypeProgram { get; set; }
    }
}
