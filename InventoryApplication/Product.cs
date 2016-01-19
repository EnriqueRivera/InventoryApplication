//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventoryApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public Product()
        {
            this.Arrives = new HashSet<Arrive>();
            this.Departures = new HashSet<Departure>();
        }
    
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<Arrive> Arrives { get; set; }
        public virtual ICollection<Departure> Departures { get; set; }
    }
}
