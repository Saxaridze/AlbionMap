//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlbionMap
{
    using System;
    using System.Collections.Generic;
    
    public partial class MainLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MainLocation()
        {
            this.LocationAndResources = new HashSet<LocationAndResource>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> IDRegion { get; set; }
        public string LevelLocation { get; set; }
        public string Enchantment { get; set; }
        public string ImageLocation { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationAndResource> LocationAndResources { get; set; }
        public virtual TypeOfRegion TypeOfRegion { get; set; }
    }
}
