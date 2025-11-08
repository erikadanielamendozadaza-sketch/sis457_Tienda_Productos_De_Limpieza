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
        public static List<UnidadMedida> listar() 
        {
            using (var context = new LabProLimpEntities())
            {
                return context.UnidadMedida.Where(x => x.estado == 1).OrderBy(x => x.descripcion).ToList();
            }
        }
    }
}
