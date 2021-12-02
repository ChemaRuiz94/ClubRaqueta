
namespace ClubRaqueta
{
    partial class FormReservas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_socios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_dni_soc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.msk_txt_cuenta_corriente = new System.Windows.Forms.MaskedTextBox();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.msk_txt_telefono = new System.Windows.Forms.MaskedTextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_reservar = new System.Windows.Forms.Button();
            this.lbl_duracion = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.picBoxPista = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.numUpDownHora = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker_fecha = new System.Windows.Forms.DateTimePicker();
            this.cmb_pistas = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.dgv_reservas = new System.Windows.Forms.DataGridView();
            this.lbl_id_pista = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHora)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elige al socio:";
            // 
            // cmb_socios
            // 
            this.cmb_socios.FormattingEnabled = true;
            this.cmb_socios.Location = new System.Drawing.Point(144, 20);
            this.cmb_socios.Name = "cmb_socios";
            this.cmb_socios.Size = new System.Drawing.Size(209, 24);
            this.cmb_socios.TabIndex = 1;
            this.cmb_socios.SelectedIndexChanged += new System.EventHandler(this.cmb_socios_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI socio:";
            // 
            // lbl_dni_soc
            // 
            this.lbl_dni_soc.AutoSize = true;
            this.lbl_dni_soc.Location = new System.Drawing.Point(551, 27);
            this.lbl_dni_soc.Name = "lbl_dni_soc";
            this.lbl_dni_soc.Size = new System.Drawing.Size(0, 17);
            this.lbl_dni_soc.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.msk_txt_cuenta_corriente);
            this.panel1.Controls.Add(this.txt_apellidos);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.msk_txt_telefono);
            this.panel1.Controls.Add(this.txt_direccion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 189);
            this.panel1.TabIndex = 4;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(473, 118);
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(402, 22);
            this.txt_email.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "CCC:";
            // 
            // msk_txt_cuenta_corriente
            // 
            this.msk_txt_cuenta_corriente.Location = new System.Drawing.Point(473, 67);
            this.msk_txt_cuenta_corriente.Mask = "ES-00-0000-0000-00-0000000000 ";
            this.msk_txt_cuenta_corriente.Name = "msk_txt_cuenta_corriente";
            this.msk_txt_cuenta_corriente.ReadOnly = true;
            this.msk_txt_cuenta_corriente.Size = new System.Drawing.Size(402, 22);
            this.msk_txt_cuenta_corriente.TabIndex = 8;
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(473, 19);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.ReadOnly = true;
            this.txt_apellidos.Size = new System.Drawing.Size(402, 22);
            this.txt_apellidos.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Apellidos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Telefono:";
            // 
            // msk_txt_telefono
            // 
            this.msk_txt_telefono.Location = new System.Drawing.Point(106, 115);
            this.msk_txt_telefono.Mask = "000-000-000";
            this.msk_txt_telefono.Name = "msk_txt_telefono";
            this.msk_txt_telefono.ReadOnly = true;
            this.msk_txt_telefono.Size = new System.Drawing.Size(232, 22);
            this.msk_txt_telefono.TabIndex = 4;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(106, 67);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.ReadOnly = true;
            this.txt_direccion.Size = new System.Drawing.Size(232, 22);
            this.txt_direccion.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Direccion:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(106, 19);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(232, 22);
            this.txt_nombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.lbl_id_pista);
            this.panel2.Controls.Add(this.btn_reservar);
            this.panel2.Controls.Add(this.lbl_duracion);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.picBoxPista);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.numUpDownMin);
            this.panel2.Controls.Add(this.numUpDownHora);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.dateTimePicker_fecha);
            this.panel2.Controls.Add(this.cmb_pistas);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(12, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 195);
            this.panel2.TabIndex = 5;
            // 
            // btn_reservar
            // 
            this.btn_reservar.Enabled = false;
            this.btn_reservar.Location = new System.Drawing.Point(427, 132);
            this.btn_reservar.Name = "btn_reservar";
            this.btn_reservar.Size = new System.Drawing.Size(124, 41);
            this.btn_reservar.TabIndex = 13;
            this.btn_reservar.Text = "RESERVAR";
            this.btn_reservar.UseVisualStyleBackColor = true;
            this.btn_reservar.Click += new System.EventHandler(this.btn_reservar_Click);
            // 
            // lbl_duracion
            // 
            this.lbl_duracion.AutoSize = true;
            this.lbl_duracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_duracion.Location = new System.Drawing.Point(110, 165);
            this.lbl_duracion.Name = "lbl_duracion";
            this.lbl_duracion.Size = new System.Drawing.Size(0, 17);
            this.lbl_duracion.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Duracion:";
            // 
            // picBoxPista
            // 
            this.picBoxPista.Location = new System.Drawing.Point(589, 12);
            this.picBoxPista.Name = "picBoxPista";
            this.picBoxPista.Size = new System.Drawing.Size(286, 139);
            this.picBoxPista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPista.TabIndex = 10;
            this.picBoxPista.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(183, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Minutos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Hora inicio:";
            // 
            // numUpDownMin
            // 
            this.numUpDownMin.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUpDownMin.Location = new System.Drawing.Point(264, 135);
            this.numUpDownMin.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUpDownMin.Name = "numUpDownMin";
            this.numUpDownMin.Size = new System.Drawing.Size(43, 22);
            this.numUpDownMin.TabIndex = 7;
            // 
            // numUpDownHora
            // 
            this.numUpDownHora.Location = new System.Drawing.Point(111, 132);
            this.numUpDownHora.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.numUpDownHora.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numUpDownHora.Name = "numUpDownHora";
            this.numUpDownHora.Size = new System.Drawing.Size(43, 22);
            this.numUpDownHora.TabIndex = 6;
            this.numUpDownHora.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Fecha:";
            // 
            // dateTimePicker_fecha
            // 
            this.dateTimePicker_fecha.Checked = false;
            this.dateTimePicker_fecha.Location = new System.Drawing.Point(106, 78);
            this.dateTimePicker_fecha.Name = "dateTimePicker_fecha";
            this.dateTimePicker_fecha.Size = new System.Drawing.Size(269, 22);
            this.dateTimePicker_fecha.TabIndex = 4;
            this.dateTimePicker_fecha.ValueChanged += new System.EventHandler(this.dateTimePicker_fecha_ValueChanged);
            // 
            // cmb_pistas
            // 
            this.cmb_pistas.FormattingEnabled = true;
            this.cmb_pistas.Location = new System.Drawing.Point(106, 28);
            this.cmb_pistas.Name = "cmb_pistas";
            this.cmb_pistas.Size = new System.Drawing.Size(269, 24);
            this.cmb_pistas.TabIndex = 3;
            this.cmb_pistas.SelectedIndexChanged += new System.EventHandler(this.cmb_pistas_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Pista:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.btn_pagar);
            this.panel3.Controls.Add(this.dgv_reservas);
            this.panel3.Location = new System.Drawing.Point(13, 468);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(909, 254);
            this.panel3.TabIndex = 6;
            // 
            // btn_pagar
            // 
            this.btn_pagar.Enabled = false;
            this.btn_pagar.Location = new System.Drawing.Point(426, 191);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(124, 48);
            this.btn_pagar.TabIndex = 1;
            this.btn_pagar.Text = "PAGAR";
            this.btn_pagar.UseVisualStyleBackColor = true;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // dgv_reservas
            // 
            this.dgv_reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reservas.Location = new System.Drawing.Point(15, 12);
            this.dgv_reservas.MultiSelect = false;
            this.dgv_reservas.Name = "dgv_reservas";
            this.dgv_reservas.ReadOnly = true;
            this.dgv_reservas.RowHeadersWidth = 51;
            this.dgv_reservas.RowTemplate.Height = 24;
            this.dgv_reservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_reservas.Size = new System.Drawing.Size(879, 157);
            this.dgv_reservas.TabIndex = 0;
            this.dgv_reservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reservas_CellContentClick);
            // 
            // lbl_id_pista
            // 
            this.lbl_id_pista.AutoSize = true;
            this.lbl_id_pista.Location = new System.Drawing.Point(396, 34);
            this.lbl_id_pista.Name = "lbl_id_pista";
            this.lbl_id_pista.Size = new System.Drawing.Size(0, 17);
            this.lbl_id_pista.TabIndex = 14;
            // 
            // FormReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 757);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_dni_soc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_socios);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReservas";
            this.Text = "FormReservas";
            this.Load += new System.EventHandler(this.FormReservas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHora)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_socios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_dni_soc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msk_txt_telefono;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox msk_txt_cuenta_corriente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmb_pistas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fecha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numUpDownMin;
        private System.Windows.Forms.NumericUpDown numUpDownHora;
        private System.Windows.Forms.Label lbl_duracion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox picBoxPista;
        private System.Windows.Forms.Button btn_reservar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_reservas;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.Label lbl_id_pista;
    }
}