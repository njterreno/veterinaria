//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mascota
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mascota()
        {
            this.Consulta = new HashSet<Consulta>();
        }
    
        public int IDMascota { get; set; }
        public Nullable<int> IDDueño { get; set; }
        public Nullable<int> IDTipo { get; set; }
        public Nullable<int> IDRaza { get; set; }
        public string Nombre { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public Nullable<System.DateTime> FechaBaja { get; set; }
        public string Motivo { get; set; }
        public byte[] Foto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consulta> Consulta { get; set; }
        public virtual Dueño Dueño { get; set; }
        public virtual Raza Raza { get; set; }
        public virtual Tipo Tipo { get; set; }
    }
}
