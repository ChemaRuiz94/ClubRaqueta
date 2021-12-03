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

        dsClubRaquetaTableAdapters.pistasTableAdapter tabPist = new dsClubRaquetaTableAdapters.pistasTableAdapter();
        dsClubRaquetaTableAdapters.reservasTableAdapter tabReser = new dsClubRaquetaTableAdapters.reservasTableAdapter();


        public FormPistas()
        {
            InitializeComponent();
        }

        private void FormPistas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsClubRaqueta.pistas' Puede moverla o quitarla según sea necesario.
            this.pistasTableAdapter.Fill(dsClubRaqueta.pistas);

        }

        /*
         * Modificacion del btnSaveItem del BindingNavigator
         * Una vez guardada la reserva, vuelve a habilitar los botones
         * de moveFirsItem y MovePreviousItem
         */
        private void pistasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            if (chekc_txt_campos()) 
            {
                this.Validate();
                this.pistasBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(dsClubRaqueta);

                MessageBox.Show("Pista guardada correctamente");
                bindingNavigatorMoveFirstItem.Enabled = true;
                bindingNavigatorMovePreviousItem.Enabled = true;
            }
                       
        }

        /*
         * Modificacion del btnSaveItem del BindingNavigator
         * Deshabilitar los botones de moveFirsItem y MovePreviousItem 
         * para evitar un Fallo del programa
         * si se pulsan mientras se esta añadiendo una nueva pista
         * 
         */
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
        }


        /*
         * Modificacion del btnDeleteItema del BindingNavigator
         * Comprueba si la pista esta reservada
         * Pide confirmacion antes de eliminar
         */
        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(idPistaLabel1.Text.ToString());
            if (!checck_pista_reservada(id))
            {
                DialogResult respuesta = MessageBox.Show("¿Deseas eliminarlas la pista?", "Eliminar Pista", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (respuesta == DialogResult.Yes)
                {
                    this.pistasTableAdapter.DeleteQueryByIdPista(id);
                    this.pistasTableAdapter.Fill(dsClubRaqueta.pistas);
                    MessageBox.Show("Pista eliminada correctamente");
                }

            }
            else
            {
                MessageBox.Show("No se puede eliminar una pista reservada");
            }

            bindingNavigatorMoveFirstItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;
        }

        /*
         * Comprueba si la pista tiene reservas
         * devuelve true si tiene alguna reserva
         */
        private bool checck_pista_reservada(int id)
        {

            tabReser.FillByIdPista(dsClubRaqueta.reservas, id);

            if (dsClubRaqueta.reservas.Count() > 0)
            {
                return true;
            }
            return false;
        }

        /*
         * Comprueba si los campos estan vacios
         */
        public bool chekc_txt_campos() 
        {
            if (nombreTextBox.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("El nombre está incompleto");
                return false;
            }
            if (ubicacionTextBox.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Ubicacioa está incompleto");
                return false;
            }
            if (precioHoraTextBox.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Introduce el precio por hora");
                return false;
            }
            return true;
        }


        /*
         * Boton para cambiar la foto de la pista
         */
        private void btn_change_foto_Click(object sender, EventArgs e)
        {
            opfd_imagen_pistas.Filter = "image files |*.jpg;*.png;*.gif;*.ico;.*;";
            if (opfd_imagen_pistas.ShowDialog() == DialogResult.OK)
            {
                fotoPictureBox.Image = Image.FromFile(opfd_imagen_pistas.FileName);
            }
        }



    }
}
