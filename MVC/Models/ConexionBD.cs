namespace MVC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ConexionBD : DbContext
    {
        public ConexionBD()
            : base("name=ConexionBD")
        {
        }

        public virtual DbSet<Administrador> Administrador { get; set; }
        public virtual DbSet<Calificar_cliente> Calificar_cliente { get; set; }
        public virtual DbSet<Calificar_tramitador> Calificar_tramitador { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Tramitador> Tramitador { get; set; }
        public virtual DbSet<Tramite> Tramite { get; set; }
        public virtual DbSet<Tramite_condinero> Tramite_condinero { get; set; }
        public virtual DbSet<Tramite_sindinero> Tramite_sindinero { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrador>()
                .Property(e => e.Nombres)
                .IsFixedLength();

            modelBuilder.Entity<Administrador>()
                .Property(e => e.Apellidos)
                .IsFixedLength();

            modelBuilder.Entity<Administrador>()
                .Property(e => e.Correo)
                .IsFixedLength();

            modelBuilder.Entity<Administrador>()
                .Property(e => e.Contraseña)
                .IsFixedLength();

            modelBuilder.Entity<Administrador>()
                .Property(e => e.Telefono)
                .IsFixedLength();

            modelBuilder.Entity<Administrador>()
                .Property(e => e.Direccion)
                .IsFixedLength();

            modelBuilder.Entity<Calificar_cliente>()
                .Property(e => e.Nombres)
                .IsFixedLength();

            modelBuilder.Entity<Calificar_cliente>()
                .Property(e => e.Tipo)
                .IsFixedLength();

            modelBuilder.Entity<Calificar_cliente>()
                .Property(e => e.Descripcion)
                .IsFixedLength();

            modelBuilder.Entity<Calificar_cliente>()
                .Property(e => e.Estado)
                .IsFixedLength();

            modelBuilder.Entity<Calificar_cliente>()
                .Property(e => e.Calificacion)
                .IsFixedLength();

            modelBuilder.Entity<Calificar_cliente>()
                .Property(e => e.Comentarios)
                .IsFixedLength();

            modelBuilder.Entity<Calificar_tramitador>()
                .Property(e => e.Nombres)
                .IsFixedLength();

            modelBuilder.Entity<Calificar_tramitador>()
                .Property(e => e.Tipo)
                .IsFixedLength();

            modelBuilder.Entity<Calificar_tramitador>()
                .Property(e => e.Descripcion)
                .IsFixedLength();

            modelBuilder.Entity<Calificar_tramitador>()
                .Property(e => e.Estado)
                .IsFixedLength();

            modelBuilder.Entity<Calificar_tramitador>()
                .Property(e => e.Calificacion)
                .IsFixedLength();

            modelBuilder.Entity<Calificar_tramitador>()
                .Property(e => e.Comentarios)
                .IsFixedLength();

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nombres)
                .IsFixedLength();

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Apellidos)
                .IsFixedLength();

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Correo)
                .IsFixedLength();

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Contraseña)
                .IsFixedLength();

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Telefono)
                .IsFixedLength();

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Direccion)
                .IsFixedLength();

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Tramite)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => e.Idcliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tramitador>()
                .Property(e => e.Nombres)
                .IsFixedLength();

            modelBuilder.Entity<Tramitador>()
                .Property(e => e.Apellidos)
                .IsFixedLength();

            modelBuilder.Entity<Tramitador>()
                .Property(e => e.Privilegios)
                .IsFixedLength();

            modelBuilder.Entity<Tramitador>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Tramitador>()
                .Property(e => e.Direccion)
                .IsFixedLength();

            modelBuilder.Entity<Tramitador>()
                .Property(e => e.ContraseñaT)
                .IsFixedLength();

            modelBuilder.Entity<Tramitador>()
                .Property(e => e.Pasado_judicial)
                .IsFixedLength();

            modelBuilder.Entity<Tramitador>()
                .Property(e => e.Descripcion)
                .IsFixedLength();

            modelBuilder.Entity<Tramitador>()
                .Property(e => e.Experiencia)
                .IsFixedLength();

            modelBuilder.Entity<Tramitador>()
                .Property(e => e.Tipo_vehiculo)
                .IsFixedLength();

            modelBuilder.Entity<Tramitador>()
                .HasMany(e => e.Tramite)
                .WithRequired(e => e.Tramitador)
                .HasForeignKey(e => e.idtramitador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tramite>()
                .Property(e => e.estado)
                .IsFixedLength();

            modelBuilder.Entity<Tramite_condinero>()
                .Property(e => e.Estado_tramite)
                .IsFixedLength();

            modelBuilder.Entity<Tramite_condinero>()
                .Property(e => e.Nombre_tramite)
                .IsFixedLength();

            modelBuilder.Entity<Tramite_condinero>()
                .Property(e => e.Tipo_tramite)
                .IsFixedLength();

            modelBuilder.Entity<Tramite_condinero>()
                .Property(e => e.Transporte)
                .IsFixedLength();

            modelBuilder.Entity<Tramite_condinero>()
                .Property(e => e.Descripcion)
                .IsFixedLength();

            modelBuilder.Entity<Tramite_condinero>()
                .Property(e => e.Lugar_origen)
                .IsFixedLength();

            modelBuilder.Entity<Tramite_condinero>()
                .Property(e => e.Lugar_Destino)
                .IsFixedLength();

            modelBuilder.Entity<Tramite_condinero>()
                .Property(e => e.Monto)
                .IsFixedLength();

            modelBuilder.Entity<Tramite_condinero>()
                .Property(e => e.Costo_total)
                .IsFixedLength();

            modelBuilder.Entity<Tramite_sindinero>()
                .Property(e => e.Estado_tramite)
                .IsFixedLength();

            modelBuilder.Entity<Tramite_sindinero>()
                .Property(e => e.Nombre_tramite)
                .IsFixedLength();

            modelBuilder.Entity<Tramite_sindinero>()
                .Property(e => e.Tipo_tramite)
                .IsFixedLength();

            modelBuilder.Entity<Tramite_sindinero>()
                .Property(e => e.Transporte)
                .IsFixedLength();

            modelBuilder.Entity<Tramite_sindinero>()
                .Property(e => e.Descripcion)
                .IsFixedLength();

            modelBuilder.Entity<Tramite_sindinero>()
                .Property(e => e.Lugar_origen)
                .IsFixedLength();

            modelBuilder.Entity<Tramite_sindinero>()
                .Property(e => e.Lugar_Destino)
                .IsFixedLength();

            modelBuilder.Entity<Tramite_sindinero>()
                .Property(e => e.Costo_total)
                .IsFixedLength();
        }
    }
}
