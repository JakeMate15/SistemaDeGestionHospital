//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionHospital.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estudios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estudios()
        {
            this.HistorialEstudios = new HashSet<HistorialEstudios>();
        }
    
        public int idEstudio { get; set; }
        public string Nombre { get; set; }
        public decimal Costo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistorialEstudios> HistorialEstudios { get; set; }
    }
}