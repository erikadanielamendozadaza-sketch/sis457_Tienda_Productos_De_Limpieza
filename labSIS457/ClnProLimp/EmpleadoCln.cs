using CadProLimp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnProLimp
{
    public class EmpleadoCln
    {
        public static int insertar(Empleado empleado)
        {
            using (var context = new LabProLimpEntities())
            { 
                context.Empleado.Add(empleado);
                context.SaveChanges();
                return empleado.id;
            }
        }

        public static int actualizar(Empleado empleado) 
        {
            using (var context = new LabProLimpEntities())
            {
                var existe = context.Empleado.Find(empleado.id);
                existe.nombres = empleado.nombres;
                existe.primerApellido = empleado.primerApellido;
                existe.segundoApellido = empleado.segundoApellido;
                existe.cedulaIdentidad = empleado.cedulaIdentidad;
                existe.usuario = empleado.usuario;
                existe.contraseña = empleado.contraseña;
                existe.telefono = empleado.telefono;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabProLimpEntities())
            {
                var existe = context.Empleado.Find(id);
                existe.estado = -1;
                existe.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Empleado obtenerUno(int id)
        {
            using (var context = new LabProLimpEntities())
            { 
                return context.Empleado.Find(id);
            }
        }

        public static List<Empleado> listar()
        {
            using (var context = new LabProLimpEntities())
            {
                return context.Empleado.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paEmpleadoListar_Result> listarPa(string parametro)
        {
            using (var context = new LabProLimpEntities())
            {
                return context.paEmpleadoListar(parametro).ToList();
            }
        }
    }
}
