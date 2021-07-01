using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class clsProfesional
    {
        public List<Profesional> LeerProfesionales()
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return BD.Profesional.ToList();
            }
        }

        public List<Profesional> LeerProfesXApellido(string apellido)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return BD.Profesional.Where(b => b.Apellido == apellido).ToList();
            }
        }

        public List<Profesional> LeerProfesXID(int IDProfes)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return BD.Profesional.Where(b => b.IDProfesional == IDProfes).ToList();
            }
        }

        public class ProfesionalV
        {
            public int IDProfesional { get; set; }
            public string Apellido { get; set; }
        }

        public void cargarComboProfesional(ComboBox cmbProfesional)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                cmbProfesional.DisplayMember = "Apellido";
                cmbProfesional.ValueMember = "IDProfesional";

                IQueryable<ProfesionalV> iqProfesional = from x in BD.Profesional
                                                         select new ProfesionalV
                                                         {
                                                             IDProfesional = x.IDProfesional,
                                                             Apellido = x.Apellido
                                                         };

                List<ProfesionalV> lstProfesionalV = new List<ProfesionalV>();
                lstProfesionalV.Add(new ProfesionalV { IDProfesional = 0, Apellido = " " });
                lstProfesionalV.AddRange(iqProfesional.ToList());
                cmbProfesional.DataSource = lstProfesionalV;
                cmbProfesional.SelectedIndex = 0;
            }
        }
    }

}
