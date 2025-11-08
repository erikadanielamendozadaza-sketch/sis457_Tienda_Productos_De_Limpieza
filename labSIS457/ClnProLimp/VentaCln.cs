using CadProLimp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnProLimp
{
    public class VentaCln
    {
        public static int insertar(Venta venta)
        {
            using (var context = new LabProLimpEntities())
            { 
                context.Venta.Add(venta);
                context.SaveChanges();
                return venta.id;
            }
        }

        public static int actualizar(Venta venta)
        {
            using (var context = new LabProLimpEntities())
            {
                var existe = context.Venta.Find(venta.id);
                existe.idcliente = venta.idcliente;
                existe.idempleado = venta.idempleado;
                existe.fecha = venta.fecha;
                existe.total = venta.total;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabProLimpEntities())
            {
                var existe = context.Venta.Find(id);
                existe.estado = -1;
                existe.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static List<Venta> listar()
        {
            using (var context = new LabProLimpEntities())
            { 
                return context.Venta.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paVentaListar_Result> listarPa(string parametro)
        {
            using (var context = new LabProLimpEntities())
            {
                return context.paVentaListar(parametro).ToList();
            }
        }
    }
}
