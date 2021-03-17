
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SoftBit.Core.models;

namespace SoftBit.Infrastructure.data
{
    public class SoftBitDbContext : DbContext
    {
        /*Este constructor sirve para enlazar el DbContext con la cadena de conexion que se encuentra en el archivo
        appSettings.json*/
        public SoftBitDbContext(DbContextOptions<SoftBitDbContext> options) :base(options)
        {

        }
        //se colocan las entidades o modelos que han sido creados en el proyecto core
        public DbSet<Role> Roles {get; set;}
        public DbSet<User> Users {get; set;}
        public DbSet<Cita> Citas {get; set;}
        public DbSet<Horarios> Horarios {get;set;}

        public DbSet<Mensajes> Mensajes {get;set;}

        //se agrega un metodo para configurara el DbContext
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //este siclo me sirve para elimiar un bug con relaciones en cascada en la bd
            foreach(var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            //este siclo sirve para eliminar la pluralizacion de las tablas
            foreach(IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.SetTableName(entity.DisplayName());
            }
            base.OnModelCreating(modelBuilder);
        }
        
    }
}