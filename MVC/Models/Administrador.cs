namespace MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Administrador")]
    public partial class Administrador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CedulaA { get; set; }

        [Required]
        [StringLength(20)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(20)]
        public string Apellidos { get; set; }

        [Required]
        [StringLength(50)]
        public string Correo { get; set; }

        [Required]
        [StringLength(13)]
        public string Contraseña { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        [StringLength(100)]
        public string Direccion { get; set; }
    }
}
