using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class clsDetalleConsulta
    {
        public int CrearDetalleConsulta(DetalleConsulta detalleconsulta)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                BD.DetalleConsulta.Add(detalleconsulta);
                return BD.SaveChanges();
            }
        }

        public List<DetalleConsulta> LeerDetalleConsultaXIDConsulta(int IDConsulta)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return BD.DetalleConsulta.Where(b => b.IDConsulta == IDConsulta).ToList();
            }
        }

        public int ActualizarDetalleConsulta(DetalleConsulta detalleconsulta)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                DetalleConsulta c = BD.DetalleConsulta.SingleOrDefault(b => b.IDDetalle == detalleconsulta.IDDetalle);
                if (c != null)
                {
                    c.IDDetalle = detalleconsulta.IDDetalle;
                    c.IDConsulta = detalleconsulta.IDConsulta;
                    c.IDTipoConsulta = detalleconsulta.IDTipoConsulta;
                    c.Diagnostico = detalleconsulta.Diagnostico;
                    c.Tratamiento = detalleconsulta.Tratamiento;
                    c.Dosis = detalleconsulta.Dosis;
                    c.NumeroLote = detalleconsulta.NumeroLote;
                    c.FechaVto = detalleconsulta.FechaVto;

                    return BD.SaveChanges();
                }
                else
                    return 0;
            }
        }
    }
}
