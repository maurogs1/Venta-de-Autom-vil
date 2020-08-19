namespace Vistas
{
    partial class VehicleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radioBtnMarca = new System.Windows.Forms.RadioButton();
            this.radioBtnLinea = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grdVehicles = new System.Windows.Forms.DataGridView();
            this.btnRegisterVehicle = new System.Windows.Forms.Button();
            this.btnSeeAll = new System.Windows.Forms.Button();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.btnEditVehicle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // radioBtnMarca
            // 
            this.radioBtnMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnMarca.AutoSize = true;
            this.radioBtnMarca.Checked = true;
            this.radioBtnMarca.FlatAppearance.BorderSize = 0;
            this.radioBtnMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.radioBtnMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.radioBtnMarca.Location = new System.Drawing.Point(507, 135);
            this.radioBtnMarca.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnMarca.MaximumSize = new System.Drawing.Size(60, 19);
            this.radioBtnMarca.MinimumSize = new System.Drawing.Size(56, 19);
            this.radioBtnMarca.Name = "radioBtnMarca";
            this.radioBtnMarca.Size = new System.Drawing.Size(60, 19);
            this.radioBtnMarca.TabIndex = 39;
            this.radioBtnMarca.TabStop = true;
            this.radioBtnMarca.Text = "Marca";
            this.radioBtnMarca.UseVisualStyleBackColor = false;
            this.radioBtnMarca.CheckedChanged += new System.EventHandler(this.radioBtnMarca_CheckedChanged);
            // 
            // radioBtnLinea
            // 
            this.radioBtnLinea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnLinea.AutoSize = true;
            this.radioBtnLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.radioBtnLinea.Location = new System.Drawing.Point(425, 134);
            this.radioBtnLinea.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnLinea.MaximumSize = new System.Drawing.Size(59, 22);
            this.radioBtnLinea.MinimumSize = new System.Drawing.Size(56, 19);
            this.radioBtnLinea.Name = "radioBtnLinea";
            this.radioBtnLinea.Size = new System.Drawing.Size(56, 19);
            this.radioBtnLinea.TabIndex = 41;
            this.radioBtnLinea.Text = "Linea";
            this.radioBtnLinea.UseVisualStyleBackColor = true;
            this.radioBtnLinea.CheckedChanged += new System.EventHandler(this.radioBtnLinea_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(357, 45);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.MaximumSize = new System.Drawing.Size(293, 34);
            this.lblTitle.MinimumSize = new System.Drawing.Size(290, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(290, 31);
            this.lblTitle.TabIndex = 46;
            this.lblTitle.Text = "Gestión de Vehiculos";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grdVehicles
            // 
            this.grdVehicles.AllowUserToAddRows = false;
            this.grdVehicles.AllowUserToDeleteRows = false;
            this.grdVehicles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdVehicles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdVehicles.BackgroundColor = System.Drawing.Color.White;
            this.grdVehicles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdVehicles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdVehicles.DefaultCellStyle = dataGridViewCellStyle4;
            this.grdVehicles.Location = new System.Drawing.Point(47, 180);
            this.grdVehicles.Margin = new System.Windows.Forms.Padding(4);
            this.grdVehicles.MaximumSize = new System.Drawing.Size(972, 348);
            this.grdVehicles.MinimumSize = new System.Drawing.Size(932, 338);
            this.grdVehicles.Name = "grdVehicles";
            this.grdVehicles.ReadOnly = true;
            this.grdVehicles.RowHeadersVisible = false;
            this.grdVehicles.RowHeadersWidth = 60;
            this.grdVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVehicles.Size = new System.Drawing.Size(932, 338);
            this.grdVehicles.TabIndex = 47;
            // 
            // btnRegisterVehicle
            // 
            this.btnRegisterVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegisterVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnRegisterVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterVehicle.FlatAppearance.BorderSize = 0;
            this.btnRegisterVehicle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.btnRegisterVehicle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(69)))), ((int)(((byte)(176)))));
            this.btnRegisterVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegisterVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.btnRegisterVehicle.ForeColor = System.Drawing.Color.White;
            this.btnRegisterVehicle.Location = new System.Drawing.Point(240, 548);
            this.btnRegisterVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegisterVehicle.MaximumSize = new System.Drawing.Size(105, 38);
            this.btnRegisterVehicle.MinimumSize = new System.Drawing.Size(100, 33);
            this.btnRegisterVehicle.Name = "btnRegisterVehicle";
            this.btnRegisterVehicle.Size = new System.Drawing.Size(100, 33);
            this.btnRegisterVehicle.TabIndex = 48;
            this.btnRegisterVehicle.Text = "Añadir";
            this.btnRegisterVehicle.UseVisualStyleBackColor = false;
            this.btnRegisterVehicle.Click += new System.EventHandler(this.btnRegisterVehicle_Click);
            // 
            // btnSeeAll
            // 
            this.btnSeeAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeeAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnSeeAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeeAll.FlatAppearance.BorderSize = 0;
            this.btnSeeAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.btnSeeAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(69)))), ((int)(((byte)(176)))));
            this.btnSeeAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeeAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.btnSeeAll.ForeColor = System.Drawing.Color.White;
            this.btnSeeAll.Location = new System.Drawing.Point(514, 548);
            this.btnSeeAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeeAll.MaximumSize = new System.Drawing.Size(105, 38);
            this.btnSeeAll.MinimumSize = new System.Drawing.Size(100, 33);
            this.btnSeeAll.Name = "btnSeeAll";
            this.btnSeeAll.Size = new System.Drawing.Size(105, 33);
            this.btnSeeAll.TabIndex = 49;
            this.btnSeeAll.Text = "Ver Todo";
            this.btnSeeAll.UseVisualStyleBackColor = false;
            this.btnSeeAll.Click += new System.EventHandler(this.btnSeeAll_Click);
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnDeleteVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteVehicle.FlatAppearance.BorderSize = 0;
            this.btnDeleteVehicle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.btnDeleteVehicle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(69)))), ((int)(((byte)(176)))));
            this.btnDeleteVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.btnDeleteVehicle.ForeColor = System.Drawing.Color.White;
            this.btnDeleteVehicle.Location = new System.Drawing.Point(645, 548);
            this.btnDeleteVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteVehicle.MaximumSize = new System.Drawing.Size(105, 38);
            this.btnDeleteVehicle.MinimumSize = new System.Drawing.Size(100, 33);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(105, 33);
            this.btnDeleteVehicle.TabIndex = 51;
            this.btnDeleteVehicle.Text = "Eliminar";
            this.btnDeleteVehicle.UseVisualStyleBackColor = false;
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // btnEditVehicle
            // 
            this.btnEditVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnEditVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditVehicle.FlatAppearance.BorderSize = 0;
            this.btnEditVehicle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.btnEditVehicle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(69)))), ((int)(((byte)(176)))));
            this.btnEditVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.btnEditVehicle.ForeColor = System.Drawing.Color.White;
            this.btnEditVehicle.Location = new System.Drawing.Point(366, 548);
            this.btnEditVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditVehicle.MaximumSize = new System.Drawing.Size(105, 38);
            this.btnEditVehicle.MinimumSize = new System.Drawing.Size(100, 33);
            this.btnEditVehicle.Name = "btnEditVehicle";
            this.btnEditVehicle.Size = new System.Drawing.Size(100, 33);
            this.btnEditVehicle.TabIndex = 50;
            this.btnEditVehicle.Text = "Editar ";
            this.btnEditVehicle.UseVisualStyleBackColor = false;
            this.btnEditVehicle.Click += new System.EventHandler(this.btnEditVehicle_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(435, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MaximumSize = new System.Drawing.Size(125, 21);
            this.label1.MinimumSize = new System.Drawing.Size(122, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "Ver vehiculos por";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnPrint.IconColor = System.Drawing.Color.Black;
            this.btnPrint.IconSize = 20;
            this.btnPrint.Location = new System.Drawing.Point(815, 548);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Rotation = 0D;
            this.btnPrint.Size = new System.Drawing.Size(96, 35);
            this.btnPrint.TabIndex = 62;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 633);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioBtnMarca);
            this.Controls.Add(this.btnRegisterVehicle);
            this.Controls.Add(this.radioBtnLinea);
            this.Controls.Add(this.btnSeeAll);
            this.Controls.Add(this.btnDeleteVehicle);
            this.Controls.Add(this.btnEditVehicle);
            this.Controls.Add(this.grdVehicles);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(804, 558);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VehicleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.VehicleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdVehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioBtnMarca;
        private System.Windows.Forms.RadioButton radioBtnLinea;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView grdVehicles;
        private System.Windows.Forms.Button btnRegisterVehicle;
        private System.Windows.Forms.Button btnSeeAll;
        private System.Windows.Forms.Button btnDeleteVehicle;
        private System.Windows.Forms.Button btnEditVehicle;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnPrint;
        //private System.Windows.Forms.Label label2;
        //private FontAwesome.Sharp.IconButton iconButtonUpdate;
        //private FontAwesome.Sharp.IconButton btnPrint;
    }
}