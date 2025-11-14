using CadProLimp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnProLimp
{
    public class ProveedorCln
    {

        public static int insertar(Proveedor proveedor)
        {
            using (var context = new LabProLimpEntities())
            {
                context.Proveedor.Add(proveedor);
                context.SaveChanges();
                return proveedor.id;
            }
        }

        public static int actualizar(Proveedor proveedor)
        {
            using (var context = new LabProLimpEntities())
            {
                var existe = context.Proveedor.Find(proveedor.id);
                existe.nombreEmpresa = proveedor.nombreEmpresa;
                existe.telefono = proveedor.telefono;
                existe.direccion = proveedor.direccion;
                existe.email = proveedor.email;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabProLimpEntities())
            {
                var existe = context.Proveedor.Find(id);
                existe.estado = -1;
                existe.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Proveedor obtenerUno(int id)
        {
            using (var context = new LabProLimpEntities())
            {
                return context.Proveedor.Find(id);
            }
        }


        public static List<Proveedor> listar()
        {
            using (var context = new LabProLimpEntities())
            {
                return context.Proveedor.Where(x => x.estado == 1).OrderBy(x => x.nombreEmpresa).ToList();
            }
        }

        public static List<paProveedorListar_Result> listarPa(string parametro)
        {
            using (var context = new LabProLimpEntities())
            {
                return context.paProveedorListar(parametro).ToList();
            }
        }


    }
}
