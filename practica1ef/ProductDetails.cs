//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace practica1ef
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductDetails
    {
        public int ProductDetailID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
    
        public virtual Products Products {private get; set; }
    }
}
