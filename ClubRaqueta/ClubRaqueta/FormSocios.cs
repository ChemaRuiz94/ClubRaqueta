using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubRaqueta
{
    public partial class FormSocios : Form
    {
        DataSet dataSet;

        public FormSocios()
        {
            InitializeComponent();
        }

        private void FormSocios_Load(object sender, EventArgs e)
        {
            this.dataSet = new DataSet();
            cargar_dgv();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                var consulta = from soc in objBD.socios
                               select new
                               {
                                   DNI = soc.DNI,
                                   NOMBRE = soc.nombre,
                                   APELLIDOS = soc.apellidos,
                                   DOMICILIO = soc.domicilio,
                                   TELEFONO = soc.telefono,
                                   EMAIL = soc.email,
                                   CCC = soc.cuentaCorriente
                               };
                dgv_socios.DataSource = consulta.ToList();
            }
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            if (check_txt_campos())
            {
                if (!check_socio_dni(txt_dni.Text.ToString()))
                {
                    MessageBox.Show("El dni existe");
                }
                else
                {
                    using (clubraquetaEntities objBD = new clubraquetaEntities()) 
                    {
                        socios objSoc = new socios();
                        objSoc.DNI = txt_dni.Text.ToString();
                        objSoc.nombre = txt_nombre.Text.ToString();
                        objSoc.apellidos = txt_ape.Text.ToString();
                        objSoc.domicilio = txt_domic.Text.ToString();
                        objSoc.telefono = msk_txt_telef.Text.ToString();
                        objSoc.email = txt_email.Text.ToString();
                        objSoc.cuentaCorriente = msk_txt_ccc.Text.ToString();

                        objBD.socios.Add(objSoc);
                        MessageBox.Show("Socio añadido");
                        objBD.SaveChanges();
                    }
                }
                
            }
        }

        private bool check_txt_campos()
        {
            if (txt_dni.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("El dni está incompleto");
                return false;
            }
            if (txt_nombre.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Introduce el nombre");
                return false;
            }
            if (txt_ape.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Introduce los apellidos");
                return false;
            }
            if (txt_domic.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Introduce el domicilio");
                return false;
            }
            if (txt_email.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Introduce el Email");
                return false;
            }
            if (string.IsNullOrEmpty(msk_txt_telef.Text) || !msk_txt_telef.MaskCompleted)
            {
                MessageBox.Show("El telefono está incompleto");
                return false;
            }
            if (string.IsNullOrEmpty(msk_txt_ccc.Text) || !msk_txt_ccc.MaskCompleted)
            {
                MessageBox.Show("La Cuenta Corriente está incompleta");
                return false;
            }
            return true;
        }

        private bool check_socio_dni(String dni)
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                var consulta = from soc in objBD.socios
                               where soc.DNI == dni
                               select soc;
                if (consulta.Count() > 0)
                {
                    //el dni ya existe
                    return false;
                }
            }
            //el dni no existe
            return true;
        }

       

        private void cargar_dgv()
        {
            this.dataSet.Reset();
            dataSet.Tables.Add(new DataTable("Socios"));
            dataSet.Tables[0].Columns.Add("DNI");
            dataSet.Tables[0].Columns.Add("NOMBRE");
            dataSet.Tables[0].Columns.Add("APELLIDOS");
            dataSet.Tables[0].Columns.Add("DOMICILIO");
            dataSet.Tables[0].Columns.Add("TELEFONO");
            dataSet.Tables[0].Columns.Add("EMAIL");
            dataSet.Tables[0].Columns.Add("CCC");
            dgv_socios.DataSource = this.dataSet.Tables[0];

          
        }

        private void dgv_socios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
