namespace MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tramitador")]
    public partial class Tramitador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tramitador()
        {
            Tramite = new HashSet<Tramite>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CedulaT { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellidos { get; set; }

        [StringLength(50)]
        public string Privilegios { get; set; }

        public int? Telefono { get; set; }

        [Required]
        [StringLength(40)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(50)]
        public string ContraseñaT { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha_nacimiento { get; set; }

        [StringLength(50)]
        public string Pasado_judicial { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        [StringLength(50)]
        public string Experiencia { get; set; }

        [StringLength(50)]
        public string Tipo_vehiculo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tramite> Tramite { get; set; }
    }
}
