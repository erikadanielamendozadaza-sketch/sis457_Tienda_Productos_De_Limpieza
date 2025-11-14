using CadProLimp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnProLimp
{
    public class UnidadMedidaCln
    {
        public static int insertar(UnidadMedida unidadmedida)
        {
            using (var context = new LabProLimpEntities())
            {
                context.UnidadMedida.Add(unidadmedida);
                context.SaveChanges();
                return unidadmedida.id;
            }
        }

        public static int actualizar(UnidadMedida unidadmedida)
        {
            using (var context = new LabProLimpEntities())
            {
                var existe = context.UnidadMedida.Find(unidadmedida.id);
                existe.descripcion = unidadmedida.descripcion;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabProLimpEntities())
            {
                var existe = context.UnidadMedida.Find(id);
                existe.estado = -1;
                existe.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
                    
        }


        public static UnidadMedida obtenerUno(int id)
        {
            using (var context = new LabProLimpEntities())
            { 
                return context.UnidadMedida.Find(id);
            }
        }

        public static List<UnidadMedida> listar() 
        {
            using (var context = new LabProLimpEntities())
            {
                return context.UnidadMedida.Where(x => x.estado == 1).OrderBy(x => x.descripcion).ToList();
            }
        }

        public static List<paUnidadMedidaListar_Result> listarPa(string parametro)
        {
            using (var context = new LabProLimpEntities())
            {
                return context.paUnidadMedidaListar(parametro).ToList();
            }
        }
    }
}
