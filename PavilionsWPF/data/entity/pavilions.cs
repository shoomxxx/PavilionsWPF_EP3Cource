//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PavilionsWPF.data.entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class pavilions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pavilions()
        {
            this.rent = new HashSet<rent>();
        }
    
        public string num_pavilion { get; set; }
        public int shop_centr_id { get; set; }
        public int floor { get; set; }
        public int status { get; set; }
        public decimal area { get; set; }
        public decimal cost { get; set; }
        public decimal value_added_factor { get; set; }
    
        public virtual shops_centers shops_centers { get; set; }
        public virtual statuses statuses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rent> rent { get; set; }
    }
}