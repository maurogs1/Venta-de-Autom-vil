namespace Vistas.Views.ViewVehicles
{
    partial class TypeOfVehicleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypeOfVehicleForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTypes = new System.Windows.Forms.DataGridView();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypes)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.ButtonText = "Aceptar";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdd.Iconimage")));
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 20D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(262, 37);
            this.btnAdd.MaximumSize = new System.Drawing.Size(90, 28);
            this.btnAdd.MinimumSize = new System.Drawing.Size(90, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(90, 28);
            this.btnAdd.TabIndex = 80;
            this.btnAdd.Text = "Aceptar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // dataGridViewTypes
            // 
            this.dataGridViewTypes.AllowUserToAddRows = false;
            this.dataGridViewTypes.AllowUserToDeleteRows = false;
            this.dataGridViewTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTypes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTypes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTypes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTypes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTypes.Location = new System.Drawing.Point(22, 80);
            this.dataGridViewTypes.MaximumSize = new System.Drawing.Size(226, 179);
            this.dataGridViewTypes.MinimumSize = new System.Drawing.Size(226, 179);
            this.dataGridViewTypes.Name = "dataGridViewTypes";
            this.dataGridViewTypes.ReadOnly = true;
            this.dataGridViewTypes.RowHeadersVisible = false;
            this.dataGridViewTypes.RowHeadersWidth = 30;
            this.dataGridViewTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTypes.Size = new System.Drawing.Size(226, 179);
            this.dataGridViewTypes.TabIndex = 81;
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
            // btnEliminar
            // 
            this.btnEliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.BorderRadius = 0;
            this.btnEliminar.ButtonText = "Eliminar";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Iconimage")));
            this.btnEliminar.Iconimage_right = null;
            this.btnEliminar.Iconimage_right_Selected = null;
            this.btnEliminar.Iconimage_Selected = null;
            this.btnEliminar.IconMarginLeft = 0;
            this.btnEliminar.IconMarginRight = 0;
            this.btnEliminar.IconRightVisible = true;
            this.btnEliminar.IconRightZoom = 0D;
            this.btnEliminar.IconVisible = true;
            this.btnEliminar.IconZoom = 20D;
            this.btnEliminar.IsTab = false;
            this.btnEliminar.Location = new System.Drawing.Point(262, 131);
            this.btnEliminar.MaximumSize = new System.Drawing.Size(90, 28);
            this.btnEliminar.MinimumSize = new System.Drawing.Size(90, 28);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnEliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminar.selected = false;
            this.btnEliminar.Size = new System.Drawing.Size(90, 28);
            this.btnEliminar.TabIndex = 83;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Textcolor = System.Drawing.Color.White;
            this.btnEliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Editar";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 20D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(262, 84);
            this.bunifuFlatButton1.MaximumSize = new System.Drawing.Size(90, 28);
            this.bunifuFlatButton1.MinimumSize = new System.Drawing.Size(90, 28);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(90, 28);
            this.bunifuFlatButton1.TabIndex = 82;
            this.bunifuFlatButton1.Text = "Editar";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.textDescripcion);
            this.panel2.Controls.Add(this.dataGridViewTypes);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.bunifuFlatButton1);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Location = new System.Drawing.Point(1, 52);
            this.panel2.MaximumSize = new System.Drawing.Size(366, 303);
            this.panel2.MinimumSize = new System.Drawing.Size(366, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 303);
            this.panel2.TabIndex = 85;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 53);
            this.panel1.TabIndex = 86;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            this.errorProvider1.RightToLeft = true;
            // 
            // TypeOfVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(368, 356);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TypeOfVehicleForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TypeOfVehicleForm";
            this.Load += new System.EventHandler(this.TypeOfVehicleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewTypes;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}