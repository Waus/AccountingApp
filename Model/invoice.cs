//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JPK_generator.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class invoice
    {
        public int invoice_id { get; set; }
        public string invoice_number { get; set; }
        public string description { get; set; }
        public Nullable<decimal> amount_net { get; set; }
        public Nullable<decimal> amount_vat { get; set; }
        public Nullable<decimal> vat_rate { get; set; }
        public string contractor_name { get; set; }
        public string contractor_address1 { get; set; }
        public string contractor_address2 { get; set; }
        public Nullable<int> contractor_nip { get; set; }
        public Nullable<bool> income { get; set; }
        public Nullable<System.DateTime> date_of_issue { get; set; }
        public Nullable<System.DateTime> date_of_sale { get; set; }
    }
}
