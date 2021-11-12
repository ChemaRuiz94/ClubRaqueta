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
    public partial class FormPistas : Form
    {

        dsClubRaquetaTableAdapters.pistasTableAdapter tableAdapterPistas = new dsClubRaquetaTableAdapters.pistasTableAdapter();
        dsClubRaquetaTableAdapters.reservasTableAdapter tableAdapterReservas = new dsClubRaquetaTableAdapters.reservasTableAdapter();

        public FormPistas()
        {
            InitializeComponent();
        }

        private void pistasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pistasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsClubRaqueta);

        }

        private void pistasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pistasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsClubRaqueta);

        }

        private void FormPistas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsClubRaqueta.pistas' Puede moverla o quitarla según sea necesario.
            this.pistasTableAdapter.Fill(this.dsClubRaqueta.pistas);

        }

        private void btn_change_foto_Click(object sender, EventArgs e)
        {
            opfd_imagen_pistas.Filter = "image files |*.jpg;*.png;*.gif;*.ico;.*;";
            if (opfd_imagen_pistas.ShowDialog() == DialogResult.OK)
            {
                fotoPictureBox.Image = Image.FromFile(opfd_imagen_pistas.FileName);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult resp = new DialogResult();
            resp = MessageBox.Show("Seguro que quiere eliminar esta pista?", "Eliminar pista", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resp == DialogResult.OK) 
            {
                tableAdapterReservas.FillByReservaPista(dsClubRaqueta.reservas, int.Parse(idPistaLabel1.Text));

                if (dsClubRaqueta.reservas.Count > 0)
                {
                    MessageBox.Show("Esta pista está reservada. No se puede eliminar", "No se puede eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else 
                {
                    tableAdapterPistas.DeleteQueryByIdPista(int.Parse(idPistaLabel1.Text));

                    MessageBox.Show("Pista eliminada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    dsClubRaqueta.pistas.Clear();
                    dsClubRaqueta.reservas.Clear();

                    this.pistasTableAdapter.Fill(this.dsClubRaqueta.pistas);
                }
            }

        }
    }
}
