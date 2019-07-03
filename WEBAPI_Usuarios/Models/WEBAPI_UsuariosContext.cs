using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WEBAPI_Usuarios.Entities;

namespace WEBAPI_Usuarios.Models
{
    public class WEBAPI_UsuariosContext : DbContext
    {
        public WEBAPI_UsuariosContext() : base("name=WEBAPI_UsuariosContext")
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<DetalheUsuario> Detalhe_Usuarios { get; set; }
    }
}
