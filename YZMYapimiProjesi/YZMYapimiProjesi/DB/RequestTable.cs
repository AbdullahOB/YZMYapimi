//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YZMYapimiProjesi.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class RequestTable
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public string MsgSubject { get; set; }
        public int statueId { get; set; }
        public int ParaMiktari { get; set; }
    
        public virtual KullaniciTable KullaniciTable { get; set; }
        public virtual Statue Statue { get; set; }
    }
}