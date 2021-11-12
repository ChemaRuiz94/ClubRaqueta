
namespace ClubRaqueta
{
    partial class FormPistas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idPistaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label ubicacionLabel;
            System.Windows.Forms.Label precioHoraLabel;
            System.Windows.Forms.Label fotoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPistas));
            this.dsClubRaqueta = new ClubRaqueta.dsClubRaqueta();
            this.pistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pistasTableAdapter = new ClubRaqueta.dsClubRaquetaTableAdapters.pistasTableAdapter();
            this.tableAdapterManager = new ClubRaqueta.dsClubRaquetaTableAdapters.TableAdapterManager();
            this.pistasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pistasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idPistaLabel1 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.ubicacionTextBox = new System.Windows.Forms.TextBox();
            this.precioHoraTextBox = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_change_foto = new System.Windows.Forms.Button();
            this.opfd_imagen_pistas = new System.Windows.Forms.OpenFileDialog();
            idPistaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ubicacionLabel = new System.Windows.Forms.Label();
            precioHoraLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsClubRaqueta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistasBindingNavigator)).BeginInit();
            this.pistasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // idPistaLabel
            // 
            idPistaLabel.AutoSize = true;
            idPistaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idPistaLabel.Location = new System.Drawing.Point(51, 80);
            idPistaLabel.Name = "idPistaLabel";
            idPistaLabel.Size = new System.Drawing.Size(67, 17);
            idPistaLabel.TabIndex = 1;
            idPistaLabel.Text = "id Pista:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(49, 125);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(69, 17);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // ubicacionLabel
            // 
            ubicacionLabel.AutoSize = true;
            ubicacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ubicacionLabel.Location = new System.Drawing.Point(49, 168);
            ubicacionLabel.Name = "ubicacionLabel";
            ubicacionLabel.Size = new System.Drawing.Size(84, 17);
            ubicacionLabel.TabIndex = 5;
            ubicacionLabel.Text = "Ubicacion:";
            // 
            // precioHoraLabel
            // 
            precioHoraLabel.AutoSize = true;
            precioHoraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioHoraLabel.Location = new System.Drawing.Point(35, 309);
            precioHoraLabel.Name = "precioHoraLabel";
            precioHoraLabel.Size = new System.Drawing.Size(99, 17);
            precioHoraLabel.TabIndex = 7;
            precioHoraLabel.Text = "Precio Hora:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fotoLabel.Location = new System.Drawing.Point(605, 112);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(0, 17);
            fotoLabel.TabIndex = 9;
            // 
            // dsClubRaqueta
            // 
            this.dsClubRaqueta.DataSetName = "dsClubRaqueta";
            this.dsClubRaqueta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pistasBindingSource
            // 
            this.pistasBindingSource.DataMember = "pistas";
            this.pistasBindingSource.DataSource = this.dsClubRaqueta;
            // 
            // pistasTableAdapter
            // 
            this.pistasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pistasTableAdapter = this.pistasTableAdapter;
            this.tableAdapterManager.reservasTableAdapter = null;
            this.tableAdapterManager.sociosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ClubRaqueta.dsClubRaquetaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pistasBindingNavigator
            // 
            this.pistasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pistasBindingNavigator.BindingSource = this.pistasBindingSource;
            this.pistasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pistasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pistasBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pistasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pistasBindingNavigatorSaveItem});
            this.pistasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pistasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pistasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pistasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pistasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pistasBindingNavigator.Name = "pistasBindingNavigator";
            this.pistasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pistasBindingNavigator.Size = new System.Drawing.Size(935, 31);
            this.pistasBindingNavigator.TabIndex = 0;
            this.pistasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // pistasBindingNavigatorSaveItem
            // 
            this.pistasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pistasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pistasBindingNavigatorSaveItem.Image")));
            this.pistasBindingNavigatorSaveItem.Name = "pistasBindingNavigatorSaveItem";
            this.pistasBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.pistasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.pistasBindingNavigatorSaveItem.Click += new System.EventHandler(this.pistasBindingNavigatorSaveItem_Click_1);
            // 
            // idPistaLabel1
            // 
            this.idPistaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pistasBindingSource, "idPista", true));
            this.idPistaLabel1.Location = new System.Drawing.Point(143, 80);
            this.idPistaLabel1.Name = "idPistaLabel1";
            this.idPistaLabel1.Size = new System.Drawing.Size(100, 23);
            this.idPistaLabel1.TabIndex = 2;
            this.idPistaLabel1.Text = "label1";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pistasBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(141, 122);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(316, 22);
            this.nombreTextBox.TabIndex = 4;
            // 
            // ubicacionTextBox
            // 
            this.ubicacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pistasBindingSource, "ubicacion", true));
            this.ubicacionTextBox.Location = new System.Drawing.Point(141, 165);
            this.ubicacionTextBox.Multiline = true;
            this.ubicacionTextBox.Name = "ubicacionTextBox";
            this.ubicacionTextBox.Size = new System.Drawing.Size(316, 114);
            this.ubicacionTextBox.TabIndex = 6;
            // 
            // precioHoraTextBox
            // 
            this.precioHoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pistasBindingSource, "precioHora", true));
            this.precioHoraTextBox.Location = new System.Drawing.Point(141, 309);
            this.precioHoraTextBox.Name = "precioHoraTextBox";
            this.precioHoraTextBox.Size = new System.Drawing.Size(100, 22);
            this.precioHoraTextBox.TabIndex = 8;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pistasBindingSource, "foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(504, 44);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(281, 282);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 10;
            this.fotoPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "euros";
            // 
            // btn_change_foto
            // 
            this.btn_change_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change_foto.Location = new System.Drawing.Point(589, 349);
            this.btn_change_foto.Name = "btn_change_foto";
            this.btn_change_foto.Size = new System.Drawing.Size(134, 40);
            this.btn_change_foto.TabIndex = 13;
            this.btn_change_foto.Text = "Nueva Foto";
            this.btn_change_foto.UseVisualStyleBackColor = true;
            this.btn_change_foto.Click += new System.EventHandler(this.btn_change_foto_Click);
            // 
            // opfd_imagen_pistas
            // 
            this.opfd_imagen_pistas.FileName = "openFileDialog1";
            // 
            // FormPistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 466);
            this.Controls.Add(this.btn_change_foto);
            this.Controls.Add(this.label1);
            this.Controls.Add(idPistaLabel);
            this.Controls.Add(this.idPistaLabel1);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(ubicacionLabel);
            this.Controls.Add(this.ubicacionTextBox);
            this.Controls.Add(precioHoraLabel);
            this.Controls.Add(this.precioHoraTextBox);
            this.Controls.Add(fotoLabel);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(this.pistasBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPistas";
            this.Text = "FormPistas";
            this.Load += new System.EventHandler(this.FormPistas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsClubRaqueta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistasBindingNavigator)).EndInit();
            this.pistasBindingNavigator.ResumeLayout(false);
            this.pistasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsClubRaqueta dsClubRaqueta;
        private System.Windows.Forms.BindingSource pistasBindingSource;
        private dsClubRaquetaTableAdapters.pistasTableAdapter pistasTableAdapter;
        private dsClubRaquetaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pistasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pistasBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idPistaLabel1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox ubicacionTextBox;
        private System.Windows.Forms.TextBox precioHoraTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_change_foto;
        private System.Windows.Forms.OpenFileDialog opfd_imagen_pistas;
    }
}