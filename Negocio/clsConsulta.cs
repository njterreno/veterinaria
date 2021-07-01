using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Datos
{
    public class clsConsulta
    {
        public List<Consulta> LeerDueños()
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return BD.Consulta.ToList();
            }
        }

        public int CrearConsulta(Consulta consulta)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                BD.Consulta.Add(consulta);
                return BD.SaveChanges();
            }
        }

        public List<Consulta> LeerConsultas()
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return BD.Consulta.ToList();
            }
        }

        public List<Consulta> LeerUltimaConsulta(int count)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return BD.Consulta.Where(b => b.IDConsulta == count).ToList();
            }
        }

        public List<Consulta> LeerConsultaXIDMascota(int IDMascota)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return BD.Consulta.Where(b => b.IDMascota == IDMascota).ToList();
            }
        }

        public Consulta LeerConsultaXID(int IDConsulta)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return BD.Consulta.SingleOrDefault(b => b.IDConsulta == IDConsulta);
            }
        }

        public int ActualizarConsulta(Consulta consulta)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                Consulta c = BD.Consulta.SingleOrDefault(b => b.IDConsulta == consulta.IDConsulta);
                if (c != null)
                {
                    c.IDConsulta = consulta.IDConsulta;
                    c.IDProfesional = consulta.IDProfesional;
                    c.IDMascota = consulta.IDMascota;
                    c.Fecha = consulta.Fecha;
                    c.Peso = consulta.Peso;
                    c.Observación = consulta.Observación;

                    return BD.SaveChanges();
                }
                else
                    return 0;
            }
        }
    }
}
