using CadProLimp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnProLimp
{
    public class ClienteCln
    {
        public static Cliente validar(string cliente, string cedulaIdentidad)
        {
            using (var context = new LabProLimpEntities())
            {
                return context.Cliente.Where(c => c.razonSocial == cliente && c.cedulaIdentidad == cedulaIdentidad).FirstOrDefault();
            }
        }

        public static int insertar(Cliente cliente)
        {
            using (var context = new LabProLimpEntities())
            { 
                context.Cliente.Add(cliente);
                context.SaveChanges();
                return cliente.id;
            }
        }

        public static int actualizar(Cliente cliente)
        {
            using (var context = new LabProLimpEntities())
            {
                var existe = context.Cliente.Find(cliente.id);
                existe.razonSocial = cliente.razonSocial;
                existe.cedulaIdentidad = cliente.cedulaIdentidad;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabProLimpEntities())
            {
                var existe = context.Cliente.Find(id);
                existe.estado = -1;
                existe.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Cliente obtenerUno(int id)
        {
            using (var context = new LabProLimpEntities())
            { 
                return context.Cliente.Find(id);
            }
        }

        public static List<Cliente> listar()
        {
            using (var context = new LabProLimpEntities())
            {
                return context.Cliente.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paClienteListar_Result> listarPa(string parametro)
        {
            using (var context = new LabProLimpEntities())
            {
                return context.paClienteListar(parametro).ToList();
            }
        }


    }
}
