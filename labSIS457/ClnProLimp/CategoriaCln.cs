using CadProLimp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnProLimp
{
    public class CategoriaCln
    {
        public static int insertar(Categoria categoria)
        {
            using (var context = new LabProLimpEntities())
            {
                context.Categoria.Add(categoria);
                context.SaveChanges();
                return categoria.id;
            }
        }

        public static int actualizar(Categoria categoria)
        {
            using (var context = new LabProLimpEntities())
            {
                var existe = context.Categoria.Find(categoria.id);
                existe.nombre = categoria.nombre;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabProLimpEntities())
            {
                var existe = context.Categoria.Find(id);
                existe.estado = -1;
                existe.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }

        }


        public static Categoria obtenerUno(int id)
        {
            using (var context = new LabProLimpEntities())
            {
                return context.Categoria.Find(id);
            }
        }

        public static List<Categoria> listar()
        {
            using (var context = new LabProLimpEntities())
            {
                return context.Categoria.Where(x => x.estado == 1).OrderBy(x => x.nombre).ToList();
            }
        }

        public static List<paCategoriaListar_Result> listarPa(string parametro)
        {
            using (var context = new LabProLimpEntities())
            {
                return context.paCategoriaListar(parametro).ToList();
            }
        }
    }
}
