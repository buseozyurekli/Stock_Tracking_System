﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class stockTrackingSystemEntities : DbContext
    {
        public stockTrackingSystemEntities()
            : base("name=stockTrackingSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tblDebit> tblDebit { get; set; }
        public virtual DbSet<tblDebitedStock> tblDebitedStock { get; set; }
        public virtual DbSet<tblDepartment> tblDepartment { get; set; }
        public virtual DbSet<tblPersons> tblPersons { get; set; }
        public virtual DbSet<tblProducts> tblProducts { get; set; }
        public virtual DbSet<tblStock> tblStock { get; set; }
        public virtual DbSet<tblTypes> tblTypes { get; set; }
        public virtual DbSet<tblUsers> tblUsers { get; set; }
        public virtual DbSet<tblUserType> tblUserType { get; set; }
    
        public virtual int sp_AddDebit(Nullable<int> productID, Nullable<int> personID, Nullable<int> quantity)
        {
            var productIDParameter = productID.HasValue ?
                new ObjectParameter("productID", productID) :
                new ObjectParameter("productID", typeof(int));
    
            var personIDParameter = personID.HasValue ?
                new ObjectParameter("personID", personID) :
                new ObjectParameter("personID", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AddDebit", productIDParameter, personIDParameter, quantityParameter);
        }
    
        public virtual int sp_AddProduct(string productName, Nullable<decimal> purchasedPrice, Nullable<System.DateTime> purchasedDate, string productType, Nullable<int> quantity, string purchasedCompany)
        {
            var productNameParameter = productName != null ?
                new ObjectParameter("productName", productName) :
                new ObjectParameter("productName", typeof(string));
    
            var purchasedPriceParameter = purchasedPrice.HasValue ?
                new ObjectParameter("purchasedPrice", purchasedPrice) :
                new ObjectParameter("purchasedPrice", typeof(decimal));
    
            var purchasedDateParameter = purchasedDate.HasValue ?
                new ObjectParameter("purchasedDate", purchasedDate) :
                new ObjectParameter("purchasedDate", typeof(System.DateTime));
    
            var productTypeParameter = productType != null ?
                new ObjectParameter("productType", productType) :
                new ObjectParameter("productType", typeof(string));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(int));
    
            var purchasedCompanyParameter = purchasedCompany != null ?
                new ObjectParameter("purchasedCompany", purchasedCompany) :
                new ObjectParameter("purchasedCompany", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AddProduct", productNameParameter, purchasedPriceParameter, purchasedDateParameter, productTypeParameter, quantityParameter, purchasedCompanyParameter);
        }
    
        public virtual int sp_AddStock(Nullable<int> productID, Nullable<int> amountToAdd)
        {
            var productIDParameter = productID.HasValue ?
                new ObjectParameter("productID", productID) :
                new ObjectParameter("productID", typeof(int));
    
            var amountToAddParameter = amountToAdd.HasValue ?
                new ObjectParameter("amountToAdd", amountToAdd) :
                new ObjectParameter("amountToAdd", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AddStock", productIDParameter, amountToAddParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_ChangePassword(Nullable<int> personID, string newPassword)
        {
            var personIDParameter = personID.HasValue ?
                new ObjectParameter("personID", personID) :
                new ObjectParameter("personID", typeof(int));
    
            var newPasswordParameter = newPassword != null ?
                new ObjectParameter("newPassword", newPassword) :
                new ObjectParameter("newPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ChangePassword", personIDParameter, newPasswordParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_DebitDeletion(Nullable<int> debitID)
        {
            var debitIDParameter = debitID.HasValue ?
                new ObjectParameter("debitID", debitID) :
                new ObjectParameter("debitID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DebitDeletion", debitIDParameter);
        }
    
        public virtual ObjectResult<sp_DebitedListOfDepartment_Result> sp_DebitedListOfDepartment(Nullable<int> departmentID)
        {
            var departmentIDParameter = departmentID.HasValue ?
                new ObjectParameter("departmentID", departmentID) :
                new ObjectParameter("departmentID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_DebitedListOfDepartment_Result>("sp_DebitedListOfDepartment", departmentIDParameter);
        }
    
        public virtual ObjectResult<sp_DebitedListOfPerson_Result> sp_DebitedListOfPerson(Nullable<int> personID)
        {
            var personIDParameter = personID.HasValue ?
                new ObjectParameter("personID", personID) :
                new ObjectParameter("personID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_DebitedListOfPerson_Result>("sp_DebitedListOfPerson", personIDParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_EditDebit(Nullable<int> debitID, Nullable<int> productID, Nullable<int> personID, Nullable<int> quantity)
        {
            var debitIDParameter = debitID.HasValue ?
                new ObjectParameter("debitID", debitID) :
                new ObjectParameter("debitID", typeof(int));
    
            var productIDParameter = productID.HasValue ?
                new ObjectParameter("productID", productID) :
                new ObjectParameter("productID", typeof(int));
    
            var personIDParameter = personID.HasValue ?
                new ObjectParameter("personID", personID) :
                new ObjectParameter("personID", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EditDebit", debitIDParameter, productIDParameter, personIDParameter, quantityParameter);
        }
    
        public virtual int sp_EditProduct(Nullable<int> productID, string productName, Nullable<decimal> productPurchasePrice, Nullable<System.DateTime> productPurchaseDate, string productType, string purchasedCompany, Nullable<int> quantity)
        {
            var productIDParameter = productID.HasValue ?
                new ObjectParameter("productID", productID) :
                new ObjectParameter("productID", typeof(int));
    
            var productNameParameter = productName != null ?
                new ObjectParameter("productName", productName) :
                new ObjectParameter("productName", typeof(string));
    
            var productPurchasePriceParameter = productPurchasePrice.HasValue ?
                new ObjectParameter("productPurchasePrice", productPurchasePrice) :
                new ObjectParameter("productPurchasePrice", typeof(decimal));
    
            var productPurchaseDateParameter = productPurchaseDate.HasValue ?
                new ObjectParameter("productPurchaseDate", productPurchaseDate) :
                new ObjectParameter("productPurchaseDate", typeof(System.DateTime));
    
            var productTypeParameter = productType != null ?
                new ObjectParameter("productType", productType) :
                new ObjectParameter("productType", typeof(string));
    
            var purchasedCompanyParameter = purchasedCompany != null ?
                new ObjectParameter("purchasedCompany", purchasedCompany) :
                new ObjectParameter("purchasedCompany", typeof(string));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EditProduct", productIDParameter, productNameParameter, productPurchasePriceParameter, productPurchaseDateParameter, productTypeParameter, purchasedCompanyParameter, quantityParameter);
        }
    
        public virtual ObjectResult<string> sp_Encoder(string password)
        {
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_Encoder", passwordParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_ListAllProducts_Result> sp_ListAllProducts()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ListAllProducts_Result>("sp_ListAllProducts");
        }
    
        public virtual ObjectResult<sp_ListDepartment_Result> sp_ListDepartment()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ListDepartment_Result>("sp_ListDepartment");
        }
    
        public virtual ObjectResult<sp_ListMyProducts_Result> sp_ListMyProducts(Nullable<int> personID)
        {
            var personIDParameter = personID.HasValue ?
                new ObjectParameter("personID", personID) :
                new ObjectParameter("personID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ListMyProducts_Result>("sp_ListMyProducts", personIDParameter);
        }
    
        public virtual ObjectResult<sp_ListPersonnel_Result> sp_ListPersonnel()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ListPersonnel_Result>("sp_ListPersonnel");
        }
    
        public virtual ObjectResult<sp_ListProducts_Result> sp_ListProducts()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ListProducts_Result>("sp_ListProducts");
        }
    
        public virtual ObjectResult<sp_PersonnelDetail_Result> sp_PersonnelDetail(Nullable<int> personID)
        {
            var personIDParameter = personID.HasValue ?
                new ObjectParameter("personID", personID) :
                new ObjectParameter("personID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_PersonnelDetail_Result>("sp_PersonnelDetail", personIDParameter);
        }
    
        public virtual int sp_ProductDeletion(Nullable<int> productID)
        {
            var productIDParameter = productID.HasValue ?
                new ObjectParameter("productID", productID) :
                new ObjectParameter("productID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ProductDeletion", productIDParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<sp_ListDebit_Result> sp_ListDebit()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ListDebit_Result>("sp_ListDebit");
        }
    }
}