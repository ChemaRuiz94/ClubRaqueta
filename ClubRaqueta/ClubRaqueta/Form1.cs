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
        public frm_principal()
        {
            InitializeComponent();
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            FormReservas frm_reservas = new FormReservas();
            frm_reservas.MdiParent = this;
            frm_reservas.FormBorderStyle = FormBorderStyle.None;
            frm_reservas.Dock = DockStyle.Fill;
            frm_reservas.Show();
        }

        private void tls_menu_pistas_Click_1(object sender, EventArgs e)
        {
            FormPistas frm_pistas = new FormPistas();
            frm_pistas.ShowDialog();
            
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

        //private void tls_menu_reservas_Click(object sender, EventArgs e)
        //{

        //    FormReservas frm_reservas = new FormReservas();
        //    frm_reservas.MdiParent = this;
        //    frm_reservas.FormBorderStyle = FormBorderStyle.None;
        //    frm_reservas.Dock = DockStyle.Fill;
        //    frm_reservas.Show();

        //}

        private void tls_menu_socios_Click(object sender, EventArgs e)
        {
            FormSocios frm_soc = new FormSocios();
            frm_soc.ShowDialog();
        }

       
    }
}
