//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI_Quanly
{
    using System;
    using System.Collections.Generic;
    
    public partial class sachthuoctacgia
    {
        public int id { get; set; }
        public string id_sach { get; set; }
        public string id_user { get; set; }
    
        public virtual sach sach { get; set; }
        public virtual taikhoan taikhoan { get; set; }
    }
}
