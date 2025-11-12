using CadProLimp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnProLimp
{
    public class ProductoCln
    {
        public static int insertar(Producto producto)
        {
            using (var context = new LabProLimpEntities())
            { 
                context.Producto.Add(producto);
                context.SaveChanges();
                return producto.id;
            }
        }

        public static int actualizar(Producto producto)
        {
            using (var context = new LabProLimpEntities())
            {
                var existe = context.Producto.Find(producto.id);
                existe.idunidadMedida = producto.idunidadMedida;
                existe.idproveedor = producto.idproveedor;
                existe.codigo = producto.codigo;
                existe.nombre = producto.nombre;
                existe.categoria = producto.categoria;
                existe.precioUnitario = producto.precioUnitario;
                existe.stock = producto.stock;
                existe.fechaVencimiento = producto.fechaVencimiento;
                existe.fechaUltimaCompra = producto.fechaUltimaCompra;
                existe.precioCompra = producto.precioCompra;
                existe.cantidadMinimaStock = producto.cantidadMinimaStock;
                return context.SaveChanges();

            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabProLimpEntities())
            {
                var existe = context.Producto.Find(id);
                existe.estado = -1;
                existe.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Producto obtenerUno(int id)
        {
            using (var context = new LabProLimpEntities())
            {
                return context.Producto.Find(id);
            }
        }

        public static List<Producto> listar()
        {
            using (var context = new LabProLimpEntities())
            {
                return context.Producto.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paProductoListar_Result> listarPa(string parametro)
        {
            using (var context = new LabProLimpEntities())
            {
                return context.paProductoListar(parametro).ToList();
            }
        }
    }
}
