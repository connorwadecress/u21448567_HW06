//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace u21448567_HW06.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class staff
    {
        public staff()
        {
            this.orders = new HashSet<order>();
            this.staffs1 = new HashSet<staff>();
        }
    
        public int staff_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public byte active { get; set; }
        public int store_id { get; set; }
        public Nullable<int> manager_id { get; set; }
    
        public virtual ICollection<order> orders { get; set; }
        public virtual ICollection<staff> staffs1 { get; set; }
        public virtual staff staff1 { get; set; }
        public virtual store store { get; set; }
    }
}
