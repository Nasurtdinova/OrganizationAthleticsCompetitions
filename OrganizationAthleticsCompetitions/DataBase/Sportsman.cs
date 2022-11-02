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
    
    public partial class Sportsman
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sportsman()
        {
            this.Request = new HashSet<Request>();
        }
    
        public int Id { get; set; }
        public string FullName { get; set; }
        public Nullable<int> IdCity { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public Nullable<int> Height { get; set; }
        public Nullable<double> Weight { get; set; }
        public Nullable<int> IdCategorySportsman { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] Image { get; set; }
        public Nullable<int> IdTeam { get; set; }
        public Nullable<bool> IsDeleted { get; set; }

        public int Score => DataAccess.GetScoreSportsman(Id);
    
        public virtual CategorySportsman CategorySportsman { get; set; }
        public virtual City City { get; set; }
        public virtual Gender Gender1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Request> Request { get; set; }
        public virtual Team Team { get; set; }
    }
}
