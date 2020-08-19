namespace Vistas.Views.ViewVehicles
{
    partial class VehicleClassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleClassForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAcept = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.dataGridViewVehiclesClass = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiclesClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 53);
            this.panel1.TabIndex = 87;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(81, 13);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(208, 29);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Tipo de vehiculo";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnAcept);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.textDescripcion);
            this.panel2.Controls.Add(this.dataGridViewVehiclesClass);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.BtnDelete);
            this.panel2.Location = new System.Drawing.Point(1, 52);
            this.panel2.MaximumSize = new System.Drawing.Size(366, 303);
            this.panel2.MinimumSize = new System.Drawing.Size(366, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 303);
            this.panel2.TabIndex = 88;
            // 
            // btnAcept
            // 
            this.btnAcept.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnAcept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnAcept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAcept.BorderRadius = 0;
            this.btnAcept.ButtonText = "Aceptar";
            this.btnAcept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcept.DisabledColor = System.Drawing.Color.Gray;
            this.btnAcept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAcept.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAcept.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAcept.Iconimage")));
            this.btnAcept.Iconimage_right = null;
            this.btnAcept.Iconimage_right_Selected = null;
            this.btnAcept.Iconimage_Selected = null;
            this.btnAcept.IconMarginLeft = 0;
            this.btnAcept.IconMarginRight = 0;
            this.btnAcept.IconRightVisible = true;
            this.btnAcept.IconRightZoom = 0D;
            this.btnAcept.IconVisible = true;
            this.btnAcept.IconZoom = 20D;
            this.btnAcept.IsTab = false;
            this.btnAcept.Location = new System.Drawing.Point(262, 37);
            this.btnAcept.MaximumSize = new System.Drawing.Size(90, 28);
            this.btnAcept.MinimumSize = new System.Drawing.Size(90, 28);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnAcept.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnAcept.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAcept.selected = false;
            this.btnAcept.Size = new System.Drawing.Size(90, 28);
            this.btnAcept.TabIndex = 80;
            this.btnAcept.Text = "Aceptar";
            this.btnAcept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcept.Textcolor = System.Drawing.Color.White;
            this.btnAcept.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcept.Click += new System.EventHandler(this.btnAcept_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(76, 16);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(131, 17);
            this.bunifuCustomLabel1.TabIndex = 79;
            this.bunifuCustomLabel1.Text = "Ingrese descripcion";
            // 
            // textDescripcion
            // 
            this.textDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textDescripcion.Location = new System.Drawing.Point(51, 43);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(184, 14);
            this.textDescripcion.TabIndex = 77;
            this.textDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDescripcion_KeyPress);
            // 
            // dataGridViewVehiclesClass
            // 
            this.dataGridViewVehiclesClass.AllowUserToAddRows = false;
            this.dataGridViewVehiclesClass.AllowUserToDeleteRows = false;
            this.dataGridViewVehiclesClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewVehiclesClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVehiclesClass.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewVehiclesClass.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewVehiclesClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewVehiclesClass.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVehiclesClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewVehiclesClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVehiclesClass.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewVehiclesClass.Location = new System.Drawing.Point(22, 80);
            this.dataGridViewVehiclesClass.MaximumSize = new System.Drawing.Size(226, 179);
            this.dataGridViewVehiclesClass.MinimumSize = new System.Drawing.Size(226, 179);
            this.dataGridViewVehiclesClass.Name = "dataGridViewVehiclesClass";
            this.dataGridViewVehiclesClass.ReadOnly = true;
            this.dataGridViewVehiclesClass.RowHeadersVisible = false;
            this.dataGridViewVehiclesClass.RowHeadersWidth = 30;
            this.dataGridViewVehiclesClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVehiclesClass.Size = new System.Drawing.Size(226, 179);
            this.dataGridViewVehiclesClass.TabIndex = 81;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderRadius = 0;
            this.btnExit.ButtonText = "Salir";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledColor = System.Drawing.Color.Gray;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnExit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExit.Iconimage")));
            this.btnExit.Iconimage_right = null;
            this.btnExit.Iconimage_right_Selected = null;
            this.btnExit.Iconimage_Selected = null;
            this.btnExit.IconMarginLeft = 0;
            this.btnExit.IconMarginRight = 0;
            this.btnExit.IconRightVisible = true;
            this.btnExit.IconRightZoom = 0D;
            this.btnExit.IconVisible = true;
            this.btnExit.IconZoom = 20D;
            this.btnExit.IsTab = false;
            this.btnExit.Location = new System.Drawing.Point(262, 178);
            this.btnExit.MaximumSize = new System.Drawing.Size(90, 28);
            this.btnExit.MinimumSize = new System.Drawing.Size(90, 28);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnExit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(90, 28);
            this.btnExit.TabIndex = 84;
            this.btnExit.Text = "Salir";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Textcolor = System.Drawing.Color.White;
            this.btnExit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.BorderRadius = 0;
            this.btnEdit.ButtonText = "Editar";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledColor = System.Drawing.Color.Gray;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEdit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEdit.Iconimage")));
            this.btnEdit.Iconimage_right = null;
            this.btnEdit.Iconimage_right_Selected = null;
            this.btnEdit.Iconimage_Selected = null;
            this.btnEdit.IconMarginLeft = 0;
            this.btnEdit.IconMarginRight = 0;
            this.btnEdit.IconRightVisible = true;
            this.btnEdit.IconRightZoom = 0D;
            this.btnEdit.IconVisible = true;
            this.btnEdit.IconZoom = 20D;
            this.btnEdit.IsTab = false;
            this.btnEdit.Location = new System.Drawing.Point(262, 84);
            this.btnEdit.MaximumSize = new System.Drawing.Size(90, 28);
            this.btnEdit.MinimumSize = new System.Drawing.Size(90, 28);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(90, 28);
            this.btnEdit.TabIndex = 82;
            this.btnEdit.Text = "Editar";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Textcolor = System.Drawing.Color.White;
            this.btnEdit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDelete.BorderRadius = 0;
            this.BtnDelete.ButtonText = "Eliminar";
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Iconimage")));
            this.BtnDelete.Iconimage_right = null;
            this.BtnDelete.Iconimage_right_Selected = null;
            this.BtnDelete.Iconimage_Selected = null;
            this.BtnDelete.IconMarginLeft = 0;
            this.BtnDelete.IconMarginRight = 0;
            this.BtnDelete.IconRightVisible = true;
            this.BtnDelete.IconRightZoom = 0D;
            this.BtnDelete.IconVisible = true;
            this.BtnDelete.IconZoom = 20D;
            this.BtnDelete.IsTab = false;
            this.BtnDelete.Location = new System.Drawing.Point(262, 131);
            this.BtnDelete.MaximumSize = new System.Drawing.Size(90, 28);
            this.BtnDelete.MinimumSize = new System.Drawing.Size(90, 28);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.BtnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.BtnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnDelete.selected = false;
            this.BtnDelete.Size = new System.Drawing.Size(90, 28);
            this.BtnDelete.TabIndex = 83;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.Textcolor = System.Drawing.Color.White;
            this.BtnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            this.errorProvider1.RightToLeft = true;
            // 
            // VehicleClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(368, 356);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(368, 356);
            this.MinimumSize = new System.Drawing.Size(368, 356);
            this.Name = "VehicleClassForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VehicleClassForm";
            this.Load += new System.EventHandler(this.VehicleClassForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiclesClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnAcept;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.DataGridView dataGridViewVehiclesClass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private Bunifu.Framework.UI.BunifuFlatButton BtnDelete;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}