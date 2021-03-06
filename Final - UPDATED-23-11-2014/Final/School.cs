//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Final
{
    using System;
    using System.Collections.Generic;
    
    public partial class School
    {
        public School()
        {
            this.AdministrativeStaffs = new HashSet<AdministrativeStaff>();
            this.Classes = new HashSet<Class>();
            this.Students = new HashSet<Student>();
            this.Teachers = new HashSet<Teacher>();
            this.Principals = new HashSet<Principal>();
        }
    
        public int SchoolCode { get; set; }
        public string SchoolName { get; set; }
        public string OfficeNumber { get; set; }
        public string Email { get; set; }
        public int VillageID { get; set; }
        public int ParishID { get; set; }
    
        public virtual ICollection<AdministrativeStaff> AdministrativeStaffs { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
        public virtual Parish Parish { get; set; }
        public virtual Village Village { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Principal> Principals { get; set; }
    }
}
