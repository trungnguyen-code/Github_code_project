//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_63134865.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HangSanXuat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HangSanXuat()
        {
            this.SanPhams = new HashSet<SanPham>();
        }
    
        public int MaHSX { get; set; }
        public string TenHSX { get; set; }
        public string SdtHSX { get; set; }
        public string EmailHSX { get; set; }
        public string DiaChiHSX { get; set; }
        public string AnhHSX { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
