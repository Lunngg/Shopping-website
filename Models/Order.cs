//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PROJECT_WEB_ADMIN.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int ID { get; set; }
        public string Method { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public string Note { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual OrdersDetail OrdersDetail { get; set; }
        public virtual Sale Sale { get; set; }
    }
}