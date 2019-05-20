namespace MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cliente")]
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            Tramite = new HashSet<Tramite>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage ="Este campo es requerido")]
        public int CedulaC { get; set; }

        
        [StringLength(20)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(20)]
        public string Apellidos { get; set; }

        [Required]
        [StringLength(50)]
        public string Correo { get; set; }

        [Required(ErrorMessage ="Campo oblogatorio")]
        [DataType(DataType.Password)]
        [StringLength(13)]
        public string Contraseña { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        [StringLength(100)]
        public string Direccion { get; set; }

        
        

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tramite> Tramite { get; set; }

        
    }
}
