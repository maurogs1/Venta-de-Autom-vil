namespace Vistas
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearchCustomers = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSearchCostumers = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grdCostumers = new System.Windows.Forms.DataGridView();
            this.btnSeeAll = new System.Windows.Forms.Button();
            this.btnDeleteCustomers = new System.Windows.Forms.Button();
            this.btnEditCustomers = new System.Windows.Forms.Button();
            this.OrderLasName = new System.Windows.Forms.Button();
            this.btnAddCustomers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCostumers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchCustomers
            // 
            this.txtSearchCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchCustomers.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.txtSearchCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchCustomers.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearchCustomers.HintText = "Ingrese dni del cliente";
            this.txtSearchCustomers.isPassword = false;
            this.txtSearchCustomers.LineFocusedColor = System.Drawing.Color.White;
            this.txtSearchCustomers.LineIdleColor = System.Drawing.Color.White;
            this.txtSearchCustomers.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtSearchCustomers.LineThickness = 3;
            this.txtSearchCustomers.Location = new System.Drawing.Point(319, 99);
            this.txtSearchCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchCustomers.MaximumSize = new System.Drawing.Size(227, 27);
            this.txtSearchCustomers.MinimumSize = new System.Drawing.Size(224, 24);
            this.txtSearchCustomers.Name = "txtSearchCustomers";
            this.txtSearchCustomers.Size = new System.Drawing.Size(227, 24);
            this.txtSearchCustomers.TabIndex = 35;
            this.txtSearchCustomers.Text = "Ingrese nombre del cliente";
            this.txtSearchCustomers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(290, 101);
            this.pictureBox3.MaximumSize = new System.Drawing.Size(31, 24);
            this.pictureBox3.MinimumSize = new System.Drawing.Size(28, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(271, 88);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(289, 49);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(286, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(289, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // btnSearchCostumers
            // 
            this.btnSearchCostumers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchCostumers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnSearchCostumers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCostumers.FlatAppearance.BorderSize = 0;
            this.btnSearchCostumers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.btnSearchCostumers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(69)))), ((int)(((byte)(176)))));
            this.btnSearchCostumers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchCostumers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.btnSearchCostumers.ForeColor = System.Drawing.Color.White;
            this.btnSearchCostumers.Location = new System.Drawing.Point(566, 94);
            this.btnSearchCostumers.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchCostumers.MaximumSize = new System.Drawing.Size(105, 38);
            this.btnSearchCostumers.MinimumSize = new System.Drawing.Size(100, 33);
            this.btnSearchCostumers.Name = "btnSearchCostumers";
            this.btnSearchCostumers.Size = new System.Drawing.Size(105, 33);
            this.btnSearchCostumers.TabIndex = 36;
            this.btnSearchCostumers.Text = "Buscar";
            this.btnSearchCostumers.UseVisualStyleBackColor = false;
            this.btnSearchCostumers.Click += new System.EventHandler(this.btnSearchCostumers_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(357, 45);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 31);
            this.lblTitle.TabIndex = 37;
            this.lblTitle.Text = "Gestión de Clientes";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grdCostumers
            // 
            this.grdCostumers.AllowUserToAddRows = false;
            this.grdCostumers.AllowUserToDeleteRows = false;
            this.grdCostumers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCostumers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCostumers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdCostumers.BackgroundColor = System.Drawing.Color.White;
            this.grdCostumers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdCostumers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCostumers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdCostumers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCostumers.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdCostumers.Location = new System.Drawing.Point(47, 180);
            this.grdCostumers.Margin = new System.Windows.Forms.Padding(4);
            this.grdCostumers.MaximumSize = new System.Drawing.Size(972, 348);
            this.grdCostumers.MinimumSize = new System.Drawing.Size(932, 338);
            this.grdCostumers.Name = "grdCostumers";
            this.grdCostumers.ReadOnly = true;
            this.grdCostumers.RowHeadersVisible = false;
            this.grdCostumers.RowHeadersWidth = 30;
            this.grdCostumers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCostumers.Size = new System.Drawing.Size(932, 338);
            this.grdCostumers.TabIndex = 40;
            // 
            // btnSeeAll
            // 
            this.btnSeeAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSeeAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnSeeAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeeAll.FlatAppearance.BorderSize = 0;
            this.btnSeeAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.btnSeeAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(69)))), ((int)(((byte)(176)))));
            this.btnSeeAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeeAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.btnSeeAll.ForeColor = System.Drawing.Color.White;
            this.btnSeeAll.Location = new System.Drawing.Point(587, 549);
            this.btnSeeAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeeAll.MaximumSize = new System.Drawing.Size(105, 38);
            this.btnSeeAll.MinimumSize = new System.Drawing.Size(100, 33);
            this.btnSeeAll.Name = "btnSeeAll";
            this.btnSeeAll.Size = new System.Drawing.Size(100, 33);
            this.btnSeeAll.TabIndex = 42;
            this.btnSeeAll.Text = "Ver Todo";
            this.btnSeeAll.UseVisualStyleBackColor = false;
            this.btnSeeAll.Click += new System.EventHandler(this.btnSeeAll_Click);
            // 
            // btnDeleteCustomers
            // 
            this.btnDeleteCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnDeleteCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCustomers.FlatAppearance.BorderSize = 0;
            this.btnDeleteCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.btnDeleteCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(69)))), ((int)(((byte)(176)))));
            this.btnDeleteCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.btnDeleteCustomers.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCustomers.Location = new System.Drawing.Point(702, 549);
            this.btnDeleteCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCustomers.MaximumSize = new System.Drawing.Size(105, 38);
            this.btnDeleteCustomers.MinimumSize = new System.Drawing.Size(100, 33);
            this.btnDeleteCustomers.Name = "btnDeleteCustomers";
            this.btnDeleteCustomers.Size = new System.Drawing.Size(100, 33);
            this.btnDeleteCustomers.TabIndex = 44;
            this.btnDeleteCustomers.Text = "Eliminar";
            this.btnDeleteCustomers.UseVisualStyleBackColor = false;
            this.btnDeleteCustomers.Click += new System.EventHandler(this.btnDeleteCustomers_Click);
            // 
            // btnEditCustomers
            // 
            this.btnEditCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnEditCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCustomers.FlatAppearance.BorderSize = 0;
            this.btnEditCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.btnEditCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(69)))), ((int)(((byte)(176)))));
            this.btnEditCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.btnEditCustomers.ForeColor = System.Drawing.Color.White;
            this.btnEditCustomers.Location = new System.Drawing.Point(292, 549);
            this.btnEditCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditCustomers.MaximumSize = new System.Drawing.Size(105, 38);
            this.btnEditCustomers.MinimumSize = new System.Drawing.Size(100, 33);
            this.btnEditCustomers.Name = "btnEditCustomers";
            this.btnEditCustomers.Size = new System.Drawing.Size(100, 33);
            this.btnEditCustomers.TabIndex = 43;
            this.btnEditCustomers.Text = "Editar ";
            this.btnEditCustomers.UseVisualStyleBackColor = false;
            this.btnEditCustomers.Click += new System.EventHandler(this.btnEditCustomers_Click);
            // 
            // OrderLasName
            // 
            this.OrderLasName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OrderLasName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.OrderLasName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderLasName.FlatAppearance.BorderSize = 0;
            this.OrderLasName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.OrderLasName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(69)))), ((int)(((byte)(176)))));
            this.OrderLasName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OrderLasName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.OrderLasName.ForeColor = System.Drawing.Color.White;
            this.OrderLasName.Location = new System.Drawing.Point(407, 549);
            this.OrderLasName.Margin = new System.Windows.Forms.Padding(4);
            this.OrderLasName.MaximumSize = new System.Drawing.Size(168, 36);
            this.OrderLasName.MinimumSize = new System.Drawing.Size(165, 33);
            this.OrderLasName.Name = "OrderLasName";
            this.OrderLasName.Size = new System.Drawing.Size(165, 33);
            this.OrderLasName.TabIndex = 45;
            this.OrderLasName.Text = "Ordenar por apellido";
            this.OrderLasName.UseVisualStyleBackColor = false;
            this.OrderLasName.Click += new System.EventHandler(this.OrderLasName_Click);
            // 
            // btnAddCustomers
            // 
            this.btnAddCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnAddCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomers.FlatAppearance.BorderSize = 0;
            this.btnAddCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.btnAddCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(69)))), ((int)(((byte)(176)))));
            this.btnAddCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.btnAddCustomers.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomers.Location = new System.Drawing.Point(177, 549);
            this.btnAddCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCustomers.MaximumSize = new System.Drawing.Size(105, 38);
            this.btnAddCustomers.MinimumSize = new System.Drawing.Size(100, 33);
            this.btnAddCustomers.Name = "btnAddCustomers";
            this.btnAddCustomers.Size = new System.Drawing.Size(100, 33);
            this.btnAddCustomers.TabIndex = 41;
            this.btnAddCustomers.Text = "Añadir";
            this.btnAddCustomers.UseVisualStyleBackColor = false;
            this.btnAddCustomers.Click += new System.EventHandler(this.btnAddCustomers_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 633);
            this.Controls.Add(this.OrderLasName);
            this.Controls.Add(this.btnAddCustomers);
            this.Controls.Add(this.btnSeeAll);
            this.Controls.Add(this.btnDeleteCustomers);
            this.Controls.Add(this.btnEditCustomers);
            this.Controls.Add(this.grdCostumers);
            this.Controls.Add(this.txtSearchCustomers);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSearchCostumers);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCostumers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchCustomers;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSearchCostumers;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView grdCostumers;
        private System.Windows.Forms.Button btnSeeAll;
        private System.Windows.Forms.Button btnDeleteCustomers;
        private System.Windows.Forms.Button btnEditCustomers;
        private System.Windows.Forms.Button OrderLasName;
        private System.Windows.Forms.Button btnAddCustomers;
    }
}