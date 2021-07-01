using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace Datos
{
    public class clsMascotas
    {
        public List<Mascota> LeerMascotas()
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return BD.Mascota.ToList();
            }
        }

        public List<Mascota> LeerMascotasXIDDueño(int IDDueño)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return BD.Mascota.Where(b => b.IDDueño == IDDueño).ToList();
            }
        }

        public Mascota LeerMascotasXID(int IDM)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return BD.Mascota.SingleOrDefault(b => b.IDMascota == IDM);
            }
        }

        public List<Mascota> LeerMascotaXID(int IDMascota)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return BD.Mascota.Where(b => b.IDMascota == IDMascota).ToList();
            }
        }

        public List<Tipo> LeerTipoXID(int IDTipo)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return (BD.Tipo.Where(b => b.IDTipo == IDTipo).ToList());
            }
        }

        public List<Raza> LeerRazaXID(int IDRaza)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return (BD.Raza.Where(b => b.IDRaza == IDRaza).ToList());
            }
        }

        public List<Mascota> LeerMascotasXNombre(string nombre)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return (BD.Mascota.Where(b => b.Nombre.Contains(nombre)).ToList());
            }
        }

        public List<Mascota> LeerMascotaXNombre(string nombre)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return (BD.Mascota.Where(b => b.Nombre == nombre).ToList());
            }
        }

        public List<Tipo> LeerTipos()
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return BD.Tipo.ToList();
            }
        }

        public List<Tipo> LeerTipoXNombre(string nombre)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return BD.Tipo.Where(b => b.Nombre == nombre).ToList();
            }
        }

        public List<Raza> LeerRazas(int IDTipo)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return BD.Raza.Where(b => b.IDTipo == IDTipo).ToList();
            }
        }

        public List<Raza> LeerRazasXNombre(string nombre)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return BD.Raza.Where(b => b.Nombre == nombre).ToList();
            }
        }

        public List<Dueño> LeerIDxDNI(int DNI)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                return (BD.Dueño.Where(b => b.DNI == DNI).ToList());
            }
        }

        public int CrearMascota(Mascota mascota)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                BD.Mascota.Add(mascota);
                return BD.SaveChanges();
            }
        }

        public int ActualizarDatosMascota(Mascota mascota)
        {
            using (BDVeterinariaEntities BD = new BDVeterinariaEntities())
            {
                Mascota c = BD.Mascota.SingleOrDefault(b => b.IDMascota == mascota.IDMascota);
                if (c != null)
                {
                    c.IDMascota = mascota.IDMascota;
                    c.Nombre = mascota.Nombre;
                    c.IDDueño = mascota.IDDueño;
                    c.IDTipo = mascota.IDTipo;
                    c.IDRaza = mascota.IDRaza;
                    c.FechaNacimiento = mascota.FechaNacimiento;
                    c.FechaBaja = mascota.FechaBaja;
                    c.Motivo = mascota.Motivo;
                    c.Foto = mascota.Foto;
                    

                    return BD.SaveChanges();
                }
                else
                    return 0;
            }
        }

        public void cargacombomascota(ComboBox cmb, int IDCliente)
        {
            cmb.DataSource = LeerMascotasXIDDueño(IDCliente);
            cmb.DisplayMember = "Nombre";
            cmb.ValueMember = "IDMascota";
        }
    }
}
