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

   

        private void tls_menu_pistas_Click_1(object sender, EventArgs e)
        {
            FormPistas frm_pistas = new FormPistas();
            frm_pistas.ShowDialog();
            /*
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "FormPistas")
                {
                    DialogResult res = MessageBox.Show("¿Desea cerrar el formulario actual?", "¡ATENCION!", MessageBoxButtons.YesNo);

                    if (res == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();

                        FormPistas frm_pistas = new FormPistas();
                        frm_pistas.MdiParent = this;
                        frm_pistas.FormBorderStyle = FormBorderStyle.None;
                        frm_pistas.Dock = DockStyle.Fill;
                        frm_pistas.Show();
                    }
                }
            }
            else
            {

                FormPistas frm_pistas = new FormPistas();
                frm_pistas.MdiParent = this;
                frm_pistas.FormBorderStyle = FormBorderStyle.None;
                frm_pistas.Dock = DockStyle.Fill;
                frm_pistas.Show();
            }
            */
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

        private void tls_menu_reservas_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "FormReservas")
                {
                    DialogResult res = MessageBox.Show("¿Desea cerrar el formulario actual?", "¡ATENCION!", MessageBoxButtons.YesNo);

                    if (res == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();

                        FormReservas frm_reservas = new FormReservas();
                        frm_reservas.MdiParent = this;
                        frm_reservas.FormBorderStyle = FormBorderStyle.None;
                        frm_reservas.Dock = DockStyle.Fill;
                        frm_reservas.Show();
                    }
                }
            }
            else
            {

                FormReservas frm_reservas = new FormReservas();
                frm_reservas.MdiParent = this;
                frm_reservas.FormBorderStyle = FormBorderStyle.None;
                frm_reservas.Dock = DockStyle.Fill;
                frm_reservas.Show();
            }
        }

        private void tls_menu_socios_Click(object sender, EventArgs e)
        {
            FormSocios frm_soc = new FormSocios();
            frm_soc.ShowDialog();



            /*
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "FormSocios")
                {
                    DialogResult res = MessageBox.Show("¿Desea cerrar el formulario actual?", "¡ATENCION!", MessageBoxButtons.YesNo);

                    if (res == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();

                        FormSocios frm_soc = new FormSocios();
                        frm_soc.MdiParent = this;
                        frm_soc.FormBorderStyle = FormBorderStyle.None;
                        frm_soc.Dock = DockStyle.Fill;
                        frm_soc.Show();
                    }
                }
            }
            else
            {

                FormSocios frm_soc = new FormSocios();
                frm_soc.MdiParent = this;
                frm_soc.FormBorderStyle = FormBorderStyle.None;
                frm_soc.Dock = DockStyle.Fill;
                frm_soc.Show();
            }
            */
        }
    }
}
