using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;


namespace Datos
{
    public class clsDueños
    {   
        public List<Dueño> LeerDueños()
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return BD.Dueño.Include("Localidad").ToList();
            }
        }

        public Dueño LeerPorID(int IDDueño)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return BD.Dueño.SingleOrDefault(b => b.IDDueño == IDDueño);
            }
        }

        public List<Dueño> LeerDueñoXID(int IDDueño)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return BD.Dueño.Where(b => b.IDDueño == IDDueño).ToList();
            }
        }

        public List<Dueño> LeerPorDNI(int DNI)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                BD.Dueño.Include("Localidad").ToList();
                return BD.Dueño.Where(b => b.DNI == DNI).ToList();
            }
        }

        public List<Dueño> LeerDueñoXNombre(string nombre)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                BD.Dueño.Include("Localidad").ToList();
                return BD.Dueño.Where(b => b.Nombre.Contains(nombre.ToUpper())).ToList();
            }
        }

        public int Crear(Dueño dueño)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                BD.Dueño.Add(dueño);
                return BD.SaveChanges();
            }
        }

        public int Actualizar(Dueño dueño)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                Dueño c = BD.Dueño.SingleOrDefault(b => b.IDDueño == dueño.IDDueño);
                if (c != null)
                {
                    c.IDDueño = dueño.IDDueño;
                    c.Nombre = dueño.Nombre;
                    c.Apellido = dueño.Apellido;
                    c.Domicilio = dueño.Domicilio;
                    c.Telefono = dueño.Telefono;
                    c.IDLocalidad = dueño.IDLocalidad;
                    c.DNI = dueño.DNI;
                    c.Correo = dueño.Correo;
                    c.Observaciones = dueño.Observaciones;

                    return BD.SaveChanges();
                }
                else
                    return 0;
            }
        }

        public List<Localidad> LeerLocalidades()
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return BD.Localidad.ToList();
            }
        }

        public class DueñoV
        {
            public int IDDueño { get; set; }
            public string NombreCompleto { get; set; }
        }

        public void cargarComboCliente(ComboBox cmbDueño)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                cmbDueño.DisplayMember = "NombreCompleto";
                cmbDueño.ValueMember = "IDDueño";

                IQueryable<DueñoV> iqDueño = from x in BD.Dueño
                                                 select new DueñoV
                                                 {
                                                     IDDueño = x.IDDueño,
                                                     NombreCompleto = x.Nombre + " " + x.Apellido
                                                 };

                List<DueñoV> lstDueñoV = new List<DueñoV>();
                lstDueñoV.Add(new DueñoV { IDDueño = 0, NombreCompleto = " " });
                lstDueñoV.AddRange(iqDueño.ToList());
                cmbDueño.DataSource = lstDueñoV;
                cmbDueño.SelectedIndex = 0;
            }
        }
    }
}
