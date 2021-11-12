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
    }
}
