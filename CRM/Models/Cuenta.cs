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
    
    public partial class Cuenta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cuenta()
        {
            this.Abono = new HashSet<Abono>();
        }
    
        public int Id_Cuenta { get; set; }
        public Nullable<int> Servicio_Empresa { get; set; }
        public Nullable<System.DateTime> Fecha_Creacion { get; set; }
        public Nullable<double> Saldo_Actual { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Abono> Abono { get; set; }
        public virtual ServicioEmpresa ServicioEmpresa { get; set; }
    }
}