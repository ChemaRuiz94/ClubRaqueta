using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubRaqueta
{
    public partial class FormReservas : Form
    {
        dsClubRaquetaTableAdapters.sociosTableAdapter tabSoc = new dsClubRaquetaTableAdapters.sociosTableAdapter();
        dsClubRaquetaTableAdapters.pistasTableAdapter tabPist = new dsClubRaquetaTableAdapters.pistasTableAdapter();
        dsClubRaquetaTableAdapters.reservasTableAdapter tabReser = new dsClubRaquetaTableAdapters.reservasTableAdapter();
        dsClubRaqueta ds = new dsClubRaqueta();
        DataSet dataSet;
        public byte[] MyData { get; private set; }
        ArrayList lista_id_pista = new ArrayList(); 
        ArrayList lista_dni_soc = new ArrayList();
        ArrayList lista_reservas = new ArrayList();
        Boolean correcto = false;


        public FormReservas()
        {
            InitializeComponent();
            

        }

        private void FormReservas_Load(object sender, EventArgs e)
        {
            //cargamos el combo de socios
            cargar_cmb_socios();

            //cargamos el combo de pistas
            cargar_cmb_pistas();

            this.dataSet = new DataSet();

            //cargamos la fecha actual
            dateTimePicker_fecha.MinDate = DateTime.Today;
            dateTimePicker_fecha.Value = DateTime.Today;
        }

        private void cargar_cmb_socios() 
        {
            int i;
            ds.socios.Clear();
            cmb_socios.Items.Clear();
            tabSoc.Fill(ds.socios);

            for (i = 0; i < ds.socios.Count; i++)
            {
                cmb_socios.Items.Add(ds.socios[i].nombre);
                lista_dni_soc.Add(ds.socios[i].DNI.ToString());
            }
        }

        private void cmb_socios_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabSoc.Fill(ds.socios);

            //mostramos los datos del socio
            txt_nombre.Text = ds.socios[cmb_socios.SelectedIndex].nombre.ToString();
            txt_apellidos.Text = ds.socios[cmb_socios.SelectedIndex].apellidos.ToString();
            txt_direccion.Text = ds.socios[cmb_socios.SelectedIndex].domicilio.ToString();
            msk_txt_telefono.Text = ds.socios[cmb_socios.SelectedIndex].telefono.ToString();
            msk_txt_cuenta_corriente.Text = ds.socios[cmb_socios.SelectedIndex].cuentaCorriente.ToString();
            txt_email.Text = ds.socios[cmb_socios.SelectedIndex].email.ToString();
            lbl_dni_soc.Text = ds.socios[cmb_socios.SelectedIndex].DNI.ToString();

            //cargamos las resrvas que tenga el socio
        }

        private void cargar_cmb_pistas() 
        {
            tabPist.Fill(ds.pistas);

            for (int i = 0; i < ds.pistas.Count; i++)
            {
                cmb_pistas.Items.Add(ds.pistas[i].nombre);
                lista_id_pista.Add(ds.pistas[i].idPista);
            }
        }

        private void cmb_pistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargar_imagen_pista();
            if (!string.IsNullOrEmpty(txt_nombre.Text))
            {
                btn_reservar.Enabled = true;
                dateTimePicker_fecha.Enabled = true;
                numUpDownHora.Enabled = true;
                numUpDownMin.Enabled = true;
            }
        }

        private void cargar_imagen_pista()
        {
            int idPista = int.Parse(lista_id_pista[cmb_pistas.SelectedIndex].ToString());
            tabPist.FillByIdPista(ds.pistas, idPista);
            if (ds.pistas.Rows.Count > 0)
            {
                try
                {
                    DataRow myRow = ds.pistas.Rows[0];
                    MyData = (byte[])myRow["foto"];
                    MemoryStream stream = new MemoryStream(MyData);
                    picBoxPista.Image = Image.FromStream(stream);
                }
                catch (Exception e) 
                {
                    Console.WriteLine(e.ToString());
                }
            }

        }

        private void cargar_reservas_socio() 
        {
            this.dataSet.Reset();
            cargar_dgv();
            string dni_soc = lista_dni_soc[cmb_socios.SelectedIndex].ToString();
            tabReser.FillByIdSocio(ds.reservas, dni_soc);

            for (int i = 0; i < ds.reservas.Count; i++) 
            {
                dataSet.Tables[0].Rows.Add(ds.reservas[i].fecha.ToString("dd/MM/yyyy"));
                dgv_reservas.Rows[i].Cells["Hora"].Value = ds.reservas[i].hora;
                dgv_reservas.Rows[i].Cells["Pista"].Value = ds.reservas[i].pista;
                dgv_reservas.Rows[i].Cells["Pagado"].Value = ds.reservas[i].pagado;
                dgv_reservas.Rows[i].Cells["Euros"].Value = ds.reservas[i].cantidad;
                lista_reservas.Add(ds.reservas[i].idReserva);
            }

        }

        private void cargar_dgv() 
        {
            this.dataSet.Reset();
            dataSet.Tables.Add(new DataTable("Reserva"));
            dataSet.Tables[0].Columns.Add("Fecha");
            dataSet.Tables[0].Columns.Add("Hora");
            dataSet.Tables[0].Columns.Add("Pista");
            dataSet.Tables[0].Columns.Add("Pagado");
            dataSet.Tables[0].Columns.Add("Euros");
            dgv_reservas.DataSource = this.dataSet.Tables[0];
        }

        private void dateTimePicker_fecha_ValueChanged(object sender, EventArgs e)
        {
            var fechaActual = DateTime.Today;
            var fechaSelec = dateTimePicker_fecha.Value;
            

            if (fechaSelec.CompareTo(fechaActual) < 0)
            {
                MessageBox.Show("La fecha es anterior a la actual", "Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                correcto = false;
            }
            else
            {
                correcto = true;
            }
        }
    }
}
