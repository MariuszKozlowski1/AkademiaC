//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpeedwayBetting.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblUsers
    {
        public tblUsers()
        {
            this.tblBets = new HashSet<tblBets>();
        }
    
        public int ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    
        public virtual ICollection<tblBets> tblBets { get; set; }
    }
}
