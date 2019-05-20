using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class MVCContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MVCContext() : base("name=MVCContext")
        {
        }

        public System.Data.Entity.DbSet<MVC.Models.Administrador> Administradors { get; set; }

        public System.Data.Entity.DbSet<MVC.Models.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<MVC.Models.Tramitador> Tramitadors { get; set; }

        public System.Data.Entity.DbSet<MVC.Models.Calificar_cliente> Calificar_cliente { get; set; }

        public System.Data.Entity.DbSet<MVC.Models.Calificar_tramitador> Calificar_tramitador { get; set; }

        public System.Data.Entity.DbSet<MVC.Models.Tramite> Tramites { get; set; }

        public System.Data.Entity.DbSet<MVC.Models.Tramite_condinero> Tramite_condinero { get; set; }

        public System.Data.Entity.DbSet<MVC.Models.Tramite_sindinero> Tramite_sindinero { get; set; }
    }
}
