using SistemaDeInventario.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeInventario.BL
{
   public class UsuariosBL
    {

        public BindingList<Usuario> ListadeUsuarios { get; set; }

        public UsuariosBL()
        {
            ListadeUsuarios = new BindingList<Usuario>();
            CargarDatosdePrueba();         
        }
        private void CargarDatosdePrueba()
        {
            var usuarioAdmin = new Usuario(1, "Milton", "478");
            usuarioAdmin.PuedeVerClientes = true;
            usuarioAdmin.PuedeVerCompras = true;
            usuarioAdmin.PuedeVerFacturas = true;
            usuarioAdmin.PuedeVerProductos = true;
            usuarioAdmin.PuedeVerProveedores = true;
            usuarioAdmin.PuedeVerReportes = true;

            var usuarioAdmin2 = new Usuario(2, "Jorge", "124");
            usuarioAdmin.PuedeVerClientes = true;
            usuarioAdmin.PuedeVerCompras = true;
            usuarioAdmin.PuedeVerFacturas = true;
            usuarioAdmin.PuedeVerProductos = true;
            usuarioAdmin.PuedeVerProveedores = true;
            usuarioAdmin.PuedeVerReportes = true;

            var usuarioAdmin3 = new Usuario(3, "Roberto", "321");
            usuarioAdmin.PuedeVerClientes = true;
            usuarioAdmin.PuedeVerCompras = true;
            usuarioAdmin.PuedeVerFacturas = true;
            usuarioAdmin.PuedeVerProductos = true;
            usuarioAdmin.PuedeVerProveedores = true;
            usuarioAdmin.PuedeVerReportes = true;

            ListadeUsuarios.Add(usuarioAdmin);
            ListadeUsuarios.Add(usuarioAdmin2);
            ListadeUsuarios.Add(usuarioAdmin3);

        }
        public Usuario Autenticar(string usuario, string contrasena)
        {
            foreach (var usuario in ListadeUsuarios)
            {
                if (usuario.Nombre == nombre && usuario.Contrasena == contrasena)
                {
                    return usuario;
                }
            }

            return null;
        }
    }
}
