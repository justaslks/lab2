//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class studentModule
    {
        public int ConnectionID { get; set; }
        public int StudentID { get; set; }
        public int ModuleID { get; set; }
    
        public virtual module module { get; set; }
        public virtual student student { get; set; }
    }
}
