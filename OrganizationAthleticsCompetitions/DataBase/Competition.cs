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
    using System.ComponentModel.DataAnnotations;

    public partial class Competition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Competition()
        {
            this.ProgramCompetition = new HashSet<ProgramCompetition>();
        }
    
        public int Id { get; set; }
        [Required(ErrorMessage = "Заполните название!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Заполните дату начала!")]
        public Nullable<System.DateTime> DateStart { get; set; }
        [Required(ErrorMessage = "Заполните дату окончания!")]
        public Nullable<System.DateTime> DateEnd { get; set; }
        public Nullable<int> IdCategory { get; set; }
        public Nullable<int> IdVenue { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        [Required(ErrorMessage = "Заполните категорию!")]
        public virtual CategoryCompetition CategoryCompetition { get; set; }
        [Required(ErrorMessage = "Заполните место проведения!")]
        public virtual Venue Venue { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProgramCompetition> ProgramCompetition { get; set; }
    }
}
