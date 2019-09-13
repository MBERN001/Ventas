using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeInventario.Modelos;
using System.ComponentModel;

namespace SistemaDeInventario.BL
{
    public class ProveedoresBL
    {
        public BindingList<Proveedores> ListadeProveedores { get; set; }
        public ProveedoresBL()
        {
            ListadeProveedores = new BindingList<Proveedores>();
            CrearDatosdePrueba();
        }
        private void CrearDatosdePrueba()
        {

            var proveedor1 = new Proveedores(1, "EPSON","257848874");
            Proveedores proveedor2 = new Proveedores(2, "KLIP XTREME","5847478498");
            Proveedores proveedor3 = new Proveedores(3, "DELL","478479654784");
            Proveedores proveedor4 = new Proveedores(4, "DXRACER","14748748487");
            Proveedores proveedor5 = new Proveedores(5, "ARGOM","5484964197");


            ListadeProveedores.Add(proveedor1);
            ListadeProveedores.Add(proveedor2);
            ListadeProveedores.Add(proveedor3);
            ListadeProveedores.Add(proveedor4);
            ListadeProveedores.Add(proveedor5);
        }
     }    
  }
