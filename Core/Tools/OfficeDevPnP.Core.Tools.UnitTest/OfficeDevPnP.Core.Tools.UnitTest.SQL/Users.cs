//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OfficeDevPnP.Core.Tools.UnitTest.SQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            this.IsAdmin = false;
            this.IsCoreMember = false;
            this.SendTestResults = false;
            this.IsEmailVerified = false;
        }
    
        public int Id { get; set; }
        public string UPN { get; set; }
        public string Name { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsCoreMember { get; set; }
        public bool SendTestResults { get; set; }
        public string Email { get; set; }
        public bool IsEmailVerified { get; set; }
    }
}
