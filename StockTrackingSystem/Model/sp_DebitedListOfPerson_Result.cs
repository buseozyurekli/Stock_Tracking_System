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
    
    public partial class sp_DebitedListOfPerson_Result
    {
        public string Person_Name { get; set; }
        public int productID { get; set; }
        public string productName { get; set; }
        public Nullable<decimal> productPurchasePrice { get; set; }
        public Nullable<System.DateTime> productPurchaseDate { get; set; }
        public string productType { get; set; }
        public Nullable<bool> productActivity { get; set; }
        public string purchasedCompany { get; set; }
    }
}
