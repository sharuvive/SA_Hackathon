//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SA_Hackathon.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Food
    {
        public Food()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int fid { get; set; }
        public string fname { get; set; }
        public Nullable<double> price { get; set; }
    
        public virtual ICollection<Order> Orders { get; set; }
    }
}
