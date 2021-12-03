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
    public partial class frm_principal : Form
    {
       
        FormReservas frmReserv = new FormReservas();
        public frm_principal()
        {
            InitializeComponent();
        }

        /*
         * Carga dentro de este formulario el formulario Reservas como hijo
         */
        private void frm_principal_Load(object sender, EventArgs e)
        {
            frmReserv.MdiParent = this;
            frmReserv.FormBorderStyle = FormBorderStyle.None;
            frmReserv.Dock = DockStyle.Fill;
            frmReserv.Show();
        }

        /*
         * Abre de forma Modal el formulario de de administracion de pistas
         * al cerrar ese formulario, se refresca el formulario reservas
         */
        private void tls_menu_pistas_Click_1(object sender, EventArgs e)
        {
            try
            {
                FormPistas frm_pistas = new FormPistas();
                
                if (frm_pistas.ShowDialog() == DialogResult.Cancel) 
                {
                    frmReserv.refrescar();
                }
            }catch (Exception E) 
            {
                Console.WriteLine(e);
            }
            
        }

       

        private void tls_menu_salir_Click(object sender, EventArgs e)
        {
            DialogResult resp = new DialogResult();
            resp = MessageBox.Show("¿Seguro que desea cerrar la aplicación?", "SALIR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resp == DialogResult.OK)
            {
                Application.Exit();
            }
        }


        /*
        * Abre de forma Modal el formulario de de administracion de socios
        * al cerrar ese formulario, se refresca el formulario reservas
        */
        private void tls_menu_socios_Click(object sender, EventArgs e)
        {
            try
            {
                FormSocios frm_soc = new FormSocios();
                
                if (frm_soc.ShowDialog() == DialogResult.Cancel)
                {
                   
                    frmReserv.refrescar();
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(e);
            }
        }

    }
}
