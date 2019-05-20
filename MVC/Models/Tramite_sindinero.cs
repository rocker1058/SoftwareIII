namespace MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tramite_sindinero
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_tramite { get; set; }

        [StringLength(20)]
        public string Estado_tramite { get; set; }

        [StringLength(20)]
        public string Nombre_tramite { get; set; }

        [StringLength(20)]
        public string Tipo_tramite { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha_tramite { get; set; }

        [StringLength(20)]
        public string Transporte { get; set; }

        public double? Tiempo_tramite { get; set; }

        [StringLength(200)]
        public string Descripcion { get; set; }

        [StringLength(50)]
        public string Lugar_origen { get; set; }

        [StringLength(50)]
        public string Lugar_Destino { get; set; }

        [StringLength(10)]
        public string Costo_total { get; set; }
    }
}
