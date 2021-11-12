
namespace ClubRaqueta
{
    partial class tls_menu_salir
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tls_menu_admin = new System.Windows.Forms.ToolStripMenuItem();
            this.tls_menu_socios = new System.Windows.Forms.ToolStripMenuItem();
            this.tls_menu_pistas = new System.Windows.Forms.ToolStripMenuItem();
            this.tls_menu_reservas = new System.Windows.Forms.ToolStripMenuItem();
            this.tls_menu_informes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tls_menu_admin,
            this.tls_menu_reservas,
            this.tls_menu_informes,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(860, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tls_menu_admin
            // 
            this.tls_menu_admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tls_menu_socios,
            this.tls_menu_pistas});
            this.tls_menu_admin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tls_menu_admin.Name = "tls_menu_admin";
            this.tls_menu_admin.Size = new System.Drawing.Size(129, 24);
            this.tls_menu_admin.Text = "ADMINISTRAR";
            // 
            // tls_menu_socios
            // 
            this.tls_menu_socios.Name = "tls_menu_socios";
            this.tls_menu_socios.Size = new System.Drawing.Size(136, 26);
            this.tls_menu_socios.Text = "Socios";
            // 
            // tls_menu_pistas
            // 
            this.tls_menu_pistas.Name = "tls_menu_pistas";
            this.tls_menu_pistas.Size = new System.Drawing.Size(136, 26);
            this.tls_menu_pistas.Text = "Pistas";
            this.tls_menu_pistas.Click += new System.EventHandler(this.tls_menu_pistas_Click_1);
            // 
            // tls_menu_reservas
            // 
            this.tls_menu_reservas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tls_menu_reservas.Name = "tls_menu_reservas";
            this.tls_menu_reservas.Size = new System.Drawing.Size(95, 24);
            this.tls_menu_reservas.Text = "RESERVAS";
            // 
            // tls_menu_informes
            // 
            this.tls_menu_informes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tls_menu_informes.Name = "tls_menu_informes";
            this.tls_menu_informes.Size = new System.Drawing.Size(99, 24);
            this.tls_menu_informes.Text = "INFORMES";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 24);
            this.toolStripMenuItem1.Text = "SALIR";
            // 
            // tls_menu_salir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 466);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "tls_menu_salir";
            this.Text = "SALIR";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tls_menu_admin;
        private System.Windows.Forms.ToolStripMenuItem tls_menu_socios;
        private System.Windows.Forms.ToolStripMenuItem tls_menu_pistas;
        private System.Windows.Forms.ToolStripMenuItem tls_menu_reservas;
        private System.Windows.Forms.ToolStripMenuItem tls_menu_informes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

