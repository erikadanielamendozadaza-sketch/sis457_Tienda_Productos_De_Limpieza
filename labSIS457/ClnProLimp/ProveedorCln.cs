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
        public static List<Proveedor> listar()
        {
            using (var context = new LabProLimpEntities())
            {
                return context.Proveedor.Where(x => x.estado == 1).OrderBy(x => x.nombreEmpresa).ToList();
            }
        }
    }
}
