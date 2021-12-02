﻿using System;
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
        bool fech_correct = false;
        bool soc_pista_pagada = false;
        bool pista_disponible = false;
        int idPista = 0;
        TimeSpan hora;


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

            cargar_dgv();
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
            cargar_reservas_socio();
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
            lbl_id_pista.Text = (lista_id_pista[cmb_pistas.SelectedIndex].ToString());
            cargar_imagen_pista();
            if (!string.IsNullOrEmpty(txt_nombre.Text))
            {
                if (cmb_pistas.SelectedIndex!=-1) 
                {
                    btn_reservar.Enabled = true;
                    dateTimePicker_fecha.Enabled = true;
                    numUpDownHora.Enabled = true;
                    numUpDownMin.Enabled = true;

                    
                }
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
            var fech_actual = DateTime.Today;
            var fech_select = dateTimePicker_fecha.Value;


            if (fech_select.CompareTo(fech_actual) < 0)
            {
                MessageBox.Show("La fecha es anterior a la actual", "Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fech_correct = false;
            }
            else
            {
                fech_correct = true;
            }
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            check_pagar_reserva();
        }

        private void check_pagar_reserva()
        {
            //FALLO SI EL SOCIO NO TIENE NI UNA SOLA RESERVA

            //PAGAR AQUI
            int pist = int.Parse(dgv_reservas.SelectedRows[0].Cells["Pista"].Value.ToString());
            String horaOrig = dgv_reservas.SelectedRows[0].Cells["Hora"].Value.ToString();
            String fechaOrig = dgv_reservas.SelectedRows[0].Cells["Fecha"].Value.ToString();

            tabReser.UpdateReservaPago("Si",fechaOrig,horaOrig,pist);
            cargar_reservas_socio();
            

        }

        private void btn_reservar_Click(object sender, EventArgs e)
        {

            if (!check_reservas_sin_pagar()) 
            {
                MessageBox.Show("El socio debe el pago de una pista anterior", "Error al reservar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else 
            {
                check_pista_disponible();
                check_reservas();
            }
            
        }

        private void check_reservas()
        {
            if (soc_pista_pagada && pista_disponible)
            {
                DialogResult d_result = MessageBox.Show("¿Quieres alquilarla la pista?", "Alquilar Pista", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d_result == DialogResult.Yes)
                {

                    tabPist.FillByIdPista(ds.pistas, int.Parse(lista_id_pista[cmb_pistas.SelectedIndex].ToString()));

                    //Calculamos el precio
                    int precioHora = int.Parse(ds.pistas[0].precioHora.ToString());
                    decimal precio = (decimal)(precioHora * 1.5);

                    //Insertamos la reserva en la tabla
                    tabReser.InsertReserva(dateTimePicker_fecha.Value.ToString(), hora.ToString(), idPista, lbl_dni_soc.Text, precio);


                    cargar_reservas_socio();
                }
            }
        }


        //COMPRUEBA SI EL SOCIO TIENE RESERVAS SIN PAGAR
        private bool check_reservas_sin_pagar()
        {
            string id = lbl_dni_soc.Text.ToString();
            tabReser.FillByIdSocio(ds.reservas,id);
            for (int i = 0; i < ds.reservas.Count; i++)
            {
                if (ds.reservas[i].pagado.Equals("No"))
                {
                    soc_pista_pagada = false;
                    return false;
                }
                else
                {
                    soc_pista_pagada = true;
                }
            }
            soc_pista_pagada = true;
            return true;
        }

        //COMPRUEBA SI LA PISTA ESTA ALQUILADA ESE DIA
        private void check_pista_disponible()
        {
            string h = numUpDownHora.Value.ToString() + ":" + numUpDownMin.Value.ToString();
            hora = DateTime.Parse(h).TimeOfDay;
            idPista = int.Parse(lista_id_pista[cmb_pistas.SelectedIndex].ToString());

            this.tabReser.FillByPistaFechaReservada(ds.reservas, idPista, dateTimePicker_fecha.Value.ToString(), hora.ToString());
            if (ds.reservas.Count > 0)
            {
                MessageBox.Show("La pista ya tiene una reserva", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pista_disponible = false;
            }
            else
            {
                this.tabReser.FillByFecha(ds.reservas, idPista, dateTimePicker_fecha.Value.ToString());
                ArrayList reservas = new ArrayList(0);
                for (int i = 0; i < ds.reservas.Count; i++)
                {

                    TimeSpan horaBd = ds.reservas[i].hora;

                    if (!check_intervalo_hora(horaBd, hora))
                    {
                        reservas.Add(i);
                    }
                }
                if (reservas.Count > 0)
                {
                    MessageBox.Show("La pista ya esta ocupada a esa hora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pista_disponible = false;
                }
                else
                {
                    pista_disponible = true;
                }
            }

        }

        //COMPRUEBA EL INTERRVALO DE HORA
        private bool check_intervalo_hora(TimeSpan horaBD, TimeSpan horaReserva)
        {
            bool correcto;


            TimeSpan intervalo = horaReserva - horaBD;

            if ((Math.Abs(intervalo.Hours)) < 1)
            {
                correcto = false;
            }
            else if (Math.Abs(intervalo.Hours) >= 2)
            {
                correcto = true;
            }
            else if ((Math.Abs(intervalo.Minutes)) >= 30)
            {

                correcto = true;
            }
            else
            {
                correcto = false;
            }
            return correcto;

        }



        private void dgv_reservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String pagadoSeleccionada = dgv_reservas.SelectedRows[0].Cells["Pagado"].Value.ToString();
            if (pagadoSeleccionada.Equals("No"))
            {
                //pagar_reserva_pendiente = true;
                btn_pagar.Enabled = true;
                //btn_pagar.Visible = true;
            }
            else
            {
                //pagar_reserva_pendiente = false;
                btn_pagar.Enabled = false;
                //btn_pagar.Visible = false;
            }
        }

        private void lbl_dni_soc_TextChanged(object sender, EventArgs e)
        {
            if (lbl_id_pista.Text.ToString() != "") 
            {
                btn_reservar.Enabled = true;
            }
        }

        private void lbl_id_pista_TextChanged(object sender, EventArgs e)
        {
            if (lbl_dni_soc.Text.ToString() != "")
            {
                btn_reservar.Enabled = true;
            }
        }
    }
}
