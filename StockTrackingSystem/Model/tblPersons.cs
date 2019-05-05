//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockTrackingSystem.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPersons
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPersons()
        {
            this.tblDebit = new HashSet<tblDebit>();
        }
    
        public int personID { get; set; }
        public string personName { get; set; }
        public string personLastName { get; set; }
        public Nullable<System.DateTime> personBirthDate { get; set; }
        public Nullable<System.DateTime> dateOfStart { get; set; }
        public Nullable<bool> activityStatus { get; set; }
        public Nullable<int> userID { get; set; }
        public Nullable<int> departmentID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDebit> tblDebit { get; set; }
        public virtual tblDepartment tblDepartment { get; set; }
        public virtual tblUsers tblUsers { get; set; }
    }
}