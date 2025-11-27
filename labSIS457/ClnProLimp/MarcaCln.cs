using CadProLimp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnProLimp
{
    public class MarcaCln
    {
        public static int insertar(Marca marca)
        {
            using (var context = new LabProLimpEntities())
            {
                context.Marca.Add(marca);
                context.SaveChanges();
                return marca.id;
            }
        }

        public static int actualizar(Marca marca)
        {
            using (var context = new LabProLimpEntities())
            {
                var existe = context.Marca.Find(marca.id);
                existe.nombre = marca.nombre;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabProLimpEntities())
            {
                var existe = context.Marca.Find(id);
                existe.estado = -1;
                existe.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }

        }


        public static Marca obtenerUno(int id)
        {
            using (var context = new LabProLimpEntities())
            {
                return context.Marca.Find(id);
            }
        }

        public static List<Marca> listar()
        {
            using (var context = new LabProLimpEntities())
            {
                return context.Marca.Where(x => x.estado == 1).OrderBy(x => x.nombre).ToList();
            }
        }

        public static List<paMarcaListar_Result> listarPa(string parametro)
        {
            using (var context = new LabProLimpEntities())
            {
                return context.paMarcaListar(parametro).ToList();
            }
        }
    }
}
