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
    
    public partial class User
    {
        public User()
        {
            this.AdministrativeStaffs = new HashSet<AdministrativeStaff>();
            this.Parents = new HashSet<Parent>();
            this.Students = new HashSet<Student>();
            this.Teachers = new HashSet<Teacher>();
            this.Principals = new HashSet<Principal>();
        }
    
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string AccessType { get; set; }
        public string Email { get; set; }
    
        public virtual ICollection<AdministrativeStaff> AdministrativeStaffs { get; set; }
        public virtual ICollection<Parent> Parents { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Principal> Principals { get; set; }
    }
}