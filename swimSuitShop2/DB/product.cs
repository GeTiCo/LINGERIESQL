//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace swimSuitShop2.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        public int productId { get; set; }
        public int categoryId { get; set; }
        public string productName { get; set; }
        public int productCost { get; set; }
        public string productSize { get; set; }
        public string productMaterial { get; set; }
        public string productStructure { get; set; }
        public string productInformation { get; set; }
        public string productPhotoUrl { get; set; }
    
        public virtual category category { get; set; }
    }
}
