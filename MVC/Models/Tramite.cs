namespace MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tramite")]
    public partial class Tramite
    {
        public int Idcliente { get; set; }

        public int idtramitador { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idtramite { get; set; }

        [Required]
        [StringLength(100)]
        public string estado { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Tramitador Tramitador { get; set; }
    }
}
