namespace Vistas.ViewUser
{
    partial class UserForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgwUsers = new System.Windows.Forms.DataGridView();
            this.btnEditUsers = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.textBoxSearchUsers = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSearchUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(279, 31);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Gestión de Usuarios";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgwUsers
            // 
            this.dgwUsers.AllowUserToAddRows = false;
            this.dgwUsers.AllowUserToDeleteRows = false;
            this.dgwUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgwUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwUsers.Location = new System.Drawing.Point(47, 180);
            this.dgwUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dgwUsers.MaximumSize = new System.Drawing.Size(972, 348);
            this.dgwUsers.MinimumSize = new System.Drawing.Size(932, 338);
            this.dgwUsers.Name = "dgwUsers";
            this.dgwUsers.ReadOnly = true;
            this.dgwUsers.RowHeadersVisible = false;
            this.dgwUsers.RowHeadersWidth = 30;
            this.dgwUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwUsers.Size = new System.Drawing.Size(932, 338);
            this.dgwUsers.TabIndex = 14;
            // 
            // btnEditUsers
            // 
            this.btnEditUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnEditUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditUsers.FlatAppearance.BorderSize = 0;
            this.btnEditUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.btnEditUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(69)))), ((int)(((byte)(176)))));
            this.btnEditUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.btnEditUsers.ForeColor = System.Drawing.Color.White;
            this.btnEditUsers.Location = new System.Drawing.Point(366, 548);
            this.btnEditUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditUsers.MaximumSize = new System.Drawing.Size(105, 38);
            this.btnEditUsers.MinimumSize = new System.Drawing.Size(100, 33);
            this.btnEditUsers.Name = "btnEditUsers";
            this.btnEditUsers.Size = new System.Drawing.Size(100, 33);
            this.btnEditUsers.TabIndex = 5;
            this.btnEditUsers.Text = "Editar ";
            this.btnEditUsers.UseVisualStyleBackColor = false;
            this.btnEditUsers.Click += new System.EventHandler(this.btnEditUsers_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.btnDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(69)))), ((int)(((byte)(176)))));
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(645, 548);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteUser.MaximumSize = new System.Drawing.Size(105, 38);
            this.btnDeleteUser.MinimumSize = new System.Drawing.Size(100, 33);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(100, 33);
            this.btnDeleteUser.TabIndex = 6;
            this.btnDeleteUser.Text = "Eliminar";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(69)))), ((int)(((byte)(176)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(514, 548);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsers.MaximumSize = new System.Drawing.Size(105, 38);
            this.btnUsers.MinimumSize = new System.Drawing.Size(100, 33);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(100, 33);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "Ver Todo";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // textBoxSearchUsers
            // 
            this.textBoxSearchUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchUsers.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearchUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.textBoxSearchUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxSearchUsers.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxSearchUsers.HintText = "Ingrese nombre de usuario";
            this.textBoxSearchUsers.isPassword = false;
            this.textBoxSearchUsers.LineFocusedColor = System.Drawing.Color.White;
            this.textBoxSearchUsers.LineIdleColor = System.Drawing.Color.White;
            this.textBoxSearchUsers.LineMouseHoverColor = System.Drawing.Color.White;
            this.textBoxSearchUsers.LineThickness = 3;
            this.textBoxSearchUsers.Location = new System.Drawing.Point(363, 99);
            this.textBoxSearchUsers.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchUsers.MaximumSize = new System.Drawing.Size(227, 27);
            this.textBoxSearchUsers.MinimumSize = new System.Drawing.Size(224, 24);
            this.textBoxSearchUsers.Name = "textBoxSearchUsers";
            this.textBoxSearchUsers.Size = new System.Drawing.Size(227, 24);
            this.textBoxSearchUsers.TabIndex = 1;
            this.textBoxSearchUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(334, 101);
            this.pictureBox3.MaximumSize = new System.Drawing.Size(31, 24);
            this.pictureBox3.MinimumSize = new System.Drawing.Size(28, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(315, 88);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(289, 49);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(286, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(289, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(69)))), ((int)(((byte)(176)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(240, 548);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.MaximumSize = new System.Drawing.Size(105, 38);
            this.btnInsert.MinimumSize = new System.Drawing.Size(100, 33);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 33);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Añadir";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSearchUsers
            // 
            this.btnSearchUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnSearchUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchUsers.FlatAppearance.BorderSize = 0;
            this.btnSearchUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.btnSearchUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(69)))), ((int)(((byte)(176)))));
            this.btnSearchUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.btnSearchUsers.ForeColor = System.Drawing.Color.White;
            this.btnSearchUsers.Location = new System.Drawing.Point(610, 94);
            this.btnSearchUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchUsers.MaximumSize = new System.Drawing.Size(105, 38);
            this.btnSearchUsers.MinimumSize = new System.Drawing.Size(100, 33);
            this.btnSearchUsers.Name = "btnSearchUsers";
            this.btnSearchUsers.Size = new System.Drawing.Size(105, 33);
            this.btnSearchUsers.TabIndex = 2;
            this.btnSearchUsers.Text = "Buscar";
            this.btnSearchUsers.UseVisualStyleBackColor = false;
            this.btnSearchUsers.Click += new System.EventHandler(this.btnSearchUsers_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 633);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.textBoxSearchUsers);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnEditUsers);
            this.Controls.Add(this.btnSearchUsers);
            this.Controls.Add(this.dgwUsers);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgwUsers;
        private System.Windows.Forms.Button btnEditUsers;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxSearchUsers;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSearchUsers;
    }
}