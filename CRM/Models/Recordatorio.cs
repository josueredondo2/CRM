//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Recordatorio
    {
        public int Id_Recordatorio { get; set; }
        public string Tipo { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> Hora { get; set; }
        public Nullable<int> Minutos { get; set; }
        public string Abreviatura { get; set; }
        public string Detalle { get; set; }
        public Nullable<int> Empresa { get; set; }
    
        public virtual Empresa Empresa1 { get; set; }
    }
}
