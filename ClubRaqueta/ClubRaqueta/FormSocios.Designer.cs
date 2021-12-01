
namespace ClubRaqueta
{
    partial class FormSocios
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
            this.dgv_socios = new System.Windows.Forms.DataGridView();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ape = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_domic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.msk_txt_telef = new System.Windows.Forms.MaskedTextBox();
            this.msk_txt_ccc = new System.Windows.Forms.MaskedTextBox();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_socios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_socios
            // 
            this.dgv_socios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_socios.Location = new System.Drawing.Point(18, 503);
            this.dgv_socios.MultiSelect = false;
            this.dgv_socios.Name = "dgv_socios";
            this.dgv_socios.RowHeadersWidth = 51;
            this.dgv_socios.RowTemplate.Height = 24;
            this.dgv_socios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_socios.Size = new System.Drawing.Size(945, 178);
            this.dgv_socios.TabIndex = 0;
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(141, 40);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(262, 22);
            this.txt_dni.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(141, 84);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(467, 22);
            this.txt_nombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellidos:";
            // 
            // txt_ape
            // 
            this.txt_ape.Location = new System.Drawing.Point(141, 129);
            this.txt_ape.Name = "txt_ape";
            this.txt_ape.Size = new System.Drawing.Size(467, 22);
            this.txt_ape.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Domicilio:";
            // 
            // txt_domic
            // 
            this.txt_domic.Location = new System.Drawing.Point(141, 182);
            this.txt_domic.Name = "txt_domic";
            this.txt_domic.Size = new System.Drawing.Size(467, 22);
            this.txt_domic.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(141, 237);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(467, 22);
            this.txt_email.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "CCC:";
            // 
            // msk_txt_telef
            // 
            this.msk_txt_telef.Location = new System.Drawing.Point(141, 283);
            this.msk_txt_telef.Mask = "000-000-000";
            this.msk_txt_telef.Name = "msk_txt_telef";
            this.msk_txt_telef.Size = new System.Drawing.Size(222, 22);
            this.msk_txt_telef.TabIndex = 15;
            // 
            // msk_txt_ccc
            // 
            this.msk_txt_ccc.Location = new System.Drawing.Point(141, 326);
            this.msk_txt_ccc.Mask = "ES-00-0000-0000-00-0000000000 ";
            this.msk_txt_ccc.Name = "msk_txt_ccc";
            this.msk_txt_ccc.Size = new System.Drawing.Size(298, 22);
            this.msk_txt_ccc.TabIndex = 16;
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrar.ForeColor = System.Drawing.Color.Blue;
            this.btn_mostrar.Location = new System.Drawing.Point(351, 405);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(341, 52);
            this.btn_mostrar.TabIndex = 17;
            this.btn_mostrar.Text = "MOSTRAR SOCIOS";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            // 
            // btn_insertar
            // 
            this.btn_insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insertar.ForeColor = System.Drawing.Color.Blue;
            this.btn_insertar.Location = new System.Drawing.Point(697, 62);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(172, 50);
            this.btn_insertar.TabIndex = 18;
            this.btn_insertar.Text = "Insertar";
            this.btn_insertar.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(697, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 50);
            this.button3.TabIndex = 19;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(697, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 50);
            this.button4.TabIndex = 20;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FormSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(975, 715);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.msk_txt_ccc);
            this.Controls.Add(this.msk_txt_telef);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_domic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ape);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.dgv_socios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSocios";
            this.Text = "FormSocios";
            this.Load += new System.EventHandler(this.FormSocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_socios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_socios;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ape;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_domic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox msk_txt_telef;
        private System.Windows.Forms.MaskedTextBox msk_txt_ccc;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}