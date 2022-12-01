//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practice.Components
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.ProductOrder = new HashSet<ProductOrder>();
            this.ProductShipment = new HashSet<ProductShipment>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public string MainImage { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> DateOfAddition { get; set; }
        public int UnitId { get; set; }
        public int ManufacturerCountryId { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual ManufacturerCountry ManufacturerCountry { get; set; }
        public virtual Unit Unit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductOrder> ProductOrder { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductShipment> ProductShipment { get; set; }
    }
}
