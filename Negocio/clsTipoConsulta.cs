using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class clsTipoConsulta
    {
        public List<TipoConsulta> LeerTiposConsulta()
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return BD.TipoConsulta.ToList();
            }
        }

        public List<TipoConsulta> LeerTipoConsultaXNombre(string nombre)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return BD.TipoConsulta.Where(b=>b.Descripcion == nombre).ToList();
            }
        }

        public List<TipoConsulta> LeerTipoConsultaXID(int IDTipoConsulta)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return BD.TipoConsulta.Where(b => b.IDTipoConsulta == IDTipoConsulta).ToList();
            }
        }

        public class TipoConsultaV
        {
            public int IDTipoConsulta { get; set; }
            public string Descripcion { get; set; }
        }

        public void cargarComboTipoConsulta(ComboBox cmbTipoConsulta)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                cmbTipoConsulta.DisplayMember = "Descripcion";
                cmbTipoConsulta.ValueMember = "IDTipoConsulta";

                IQueryable<TipoConsultaV> iqTipoConsulta = from x in BD.TipoConsulta
                                                           select new TipoConsultaV
                                                           {
                                                               IDTipoConsulta = x.IDTipoConsulta,
                                                               Descripcion = x.Descripcion
                                                           };

                List<TipoConsultaV> lstTipoConsultaV = new List<TipoConsultaV>();
                lstTipoConsultaV.Add(new TipoConsultaV { IDTipoConsulta = 0, Descripcion = " " });
                lstTipoConsultaV.AddRange(iqTipoConsulta.ToList());
                cmbTipoConsulta.DataSource = lstTipoConsultaV;
                cmbTipoConsulta.SelectedIndex = 0;
            }
        }
    }
}
