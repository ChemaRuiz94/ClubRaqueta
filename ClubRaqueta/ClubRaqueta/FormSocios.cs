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


        /*
         * Pinta la estructura inicial 
         * del DataGridView
         */
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

        /*
         * Rellena el DataGridView
         * con todos los socios
         */

        private void mostrar_socios_dgv()
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


        /*
         * Al hacer doble click en una fila
         * se rellenan automaticamente toodos los campos con los datos
         * del socio seleccionado 
         * 
         */
        private void dgv_socios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_dni.Text = (dgv_socios.SelectedRows[0].Cells["DNI"].Value.ToString());
            txt_nombre.Text = (dgv_socios.SelectedRows[0].Cells["NOMBRE"].Value.ToString());
            txt_ape.Text = (dgv_socios.SelectedRows[0].Cells["APELLIDOS"].Value.ToString());
            txt_domic.Text = (dgv_socios.SelectedRows[0].Cells["DOMICILIO"].Value.ToString());
            msk_txt_telef.Text = (dgv_socios.SelectedRows[0].Cells["TELEFONO"].Value.ToString());
            txt_email.Text = (dgv_socios.SelectedRows[0].Cells["EMAIL"].Value.ToString());
            msk_txt_ccc.Text = (dgv_socios.SelectedRows[0].Cells["CCC"].Value.ToString());
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            mostrar_socios_dgv();
        }


        /*
         * Boton para insertar socio en la BD
         */
        private void btn_insertar_Click(object sender, EventArgs e)
        {
            if (check_txt_campos())
            {
                //comprobamos que el dni no exista
                if (!check_socio_dni(txt_dni.Text.ToString()))
                {
                    using (clubraquetaEntities objBD = new clubraquetaEntities())
                    {
                        socios objSoc = new socios();
                        objSoc.DNI = txt_dni.Text.ToString().Trim();
                        objSoc.nombre = txt_nombre.Text.ToString().Trim();
                        objSoc.apellidos = txt_ape.Text.ToString().Trim();
                        objSoc.domicilio = txt_domic.Text.ToString().Trim();
                        objSoc.telefono = msk_txt_telef.Text.ToString().Trim();
                        objSoc.email = txt_email.Text.ToString().Trim();
                        objSoc.cuentaCorriente = msk_txt_ccc.Text.ToString().Trim();

                        //insertamos al socio
                        objBD.socios.Add(objSoc);
                        objBD.SaveChanges();

                        //refrescamos el dgv
                        mostrar_socios_dgv();
                        MessageBox.Show("Socio añadido");
                    }

                }
                else
                {
                    MessageBox.Show("El dni existe");
                }

            }
        }


        /**
         * Boton para modificar un socio
         */
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (check_txt_campos())
            {
                //comprobamos que el dni EXISTE
                if (check_socio_dni(txt_dni.Text.ToString()))
                {
                    using (clubraquetaEntities objBD = new clubraquetaEntities())
                    {
                        String dni = txt_dni.Text.ToString().Trim();
                        socios objSoc = objBD.socios.First(x => x.DNI.Equals(dni));
                        objSoc.DNI = txt_dni.Text.ToString();
                        objSoc.nombre = txt_nombre.Text.ToString();
                        objSoc.apellidos = txt_ape.Text.ToString();
                        objSoc.domicilio = txt_domic.Text.ToString();
                        objSoc.telefono = msk_txt_telef.Text.ToString();
                        objSoc.email = txt_email.Text.ToString();
                        objSoc.cuentaCorriente = msk_txt_ccc.Text.ToString();

                        objBD.SaveChanges();
                        MessageBox.Show("Socio modificado");
                        mostrar_socios_dgv();
                    }
                }
                else
                {
                    MessageBox.Show("DNI no existe");
                    //el dni no existe
                }
            }
        }

        /**
         * Boton para eliminar un socio
         * Comprueba que no tenga reservas
         * pide un mensaje de confirmacion
         */
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            String dni = txt_dni.Text.ToString();
            if (check_socio_dni(dni))
            {
                //comprobamos que el socio no tenga reservas
                if (!check_socio_reservas(dni))
                {
                    //mensaje de confirmacion
                    DialogResult d_result = MessageBox.Show("¿Desea eliminar a este socio?", "Eliminar Socio", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (d_result == DialogResult.Yes)
                    {
                        using (clubraquetaEntities objBD = new clubraquetaEntities())
                        {
                            socios socio = objBD.socios.Find(dni);
                            objBD.socios.Remove(socio);
                            //eliminamos el socio y guardamos
                            objBD.SaveChanges();
                            MessageBox.Show("Socio eliminado correctamente");

                            mostrar_socios_dgv();
                        }
                    }
                    
                }
                else
                {
                    //tiene reservas
                    MessageBox.Show("El Socio tiene reservas");
                }
            }
            else
            {
                //el socio no existe
                MessageBox.Show("Socio no existe");
            }
        }

        /*
         * Comprueba que los campos esten 
         * correctamente rellenos
         * devuelve true si es asi
         */
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

        /*
         * Comrpueba si el dni del socio existe en la BD
         * devuelve true si existe
         */
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
                    return true;
                }
            }
            //el dni no existe
            return false;
        }



        private bool check_socio_reservas(String dni)
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {

                var con = objBD.reservas.Any(x => x.socio.Equals(dni));

                if (con)
                {
                    //si tiene reservas devuelve true
                    return true;
                }
            }

            return false;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_dni.Text = "";
            txt_nombre.Text = "";
            txt_ape.Text = "";
            txt_domic.Text = "";
            msk_txt_telef.Text = "";
            txt_email.Text = "";
            msk_txt_ccc.Text = "";
        }
    }
}
