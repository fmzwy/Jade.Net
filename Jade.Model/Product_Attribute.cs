//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jade.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product_Attribute
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product_Attribute()
        {
            this.Product_AttributeChild = new HashSet<Product_Attribute>();
            this.Product_Info = new HashSet<Product_Info>();
        }
    
        public int id { get; set; }
        public Nullable<int> parent_id { get; set; }
        public Nullable<int> category_id { get; set; }
        public int serial_no { get; set; }
        public string attribute_name { get; set; }
        public int input_type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Attribute> Product_AttributeChild { get; set; }
        public virtual Product_Attribute Product_AttributeParent { get; set; }
        public virtual Product_Category Product_Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Info> Product_Info { get; set; }
    }
}