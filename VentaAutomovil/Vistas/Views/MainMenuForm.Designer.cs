namespace Vistas
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.maximizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.restaurar = new System.Windows.Forms.PictureBox();
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.pnlSubmenuSales = new System.Windows.Forms.Panel();
            this.iconBtnMangeSales = new FontAwesome.Sharp.IconButton();
            this.btnSales = new FontAwesome.Sharp.IconButton();
            this.iconBtnSales = new FontAwesome.Sharp.IconButton();
            this.pnlSubmenuVehicle = new System.Windows.Forms.Panel();
            this.iconBtnManageVehicle = new FontAwesome.Sharp.IconButton();
            this.iconBtnVehicle = new FontAwesome.Sharp.IconButton();
            this.pnlSubmenuCustomers = new System.Windows.Forms.Panel();
            this.iconBtnManageCustomers = new FontAwesome.Sharp.IconButton();
            this.iconBtnCustomers = new FontAwesome.Sharp.IconButton();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.pnlSubmenuUsers = new System.Windows.Forms.Panel();
            this.iconBtnManageUsers = new FontAwesome.Sharp.IconButton();
            this.iconBtnUsers = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLastName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).BeginInit();
            this.pnlSideMenu.SuspendLayout();
            this.pnlSubmenuSales.SuspendLayout();
            this.pnlSubmenuVehicle.SuspendLayout();
            this.pnlSubmenuCustomers.SuspendLayout();
            this.pnlSubmenuUsers.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.panel1.Controls.Add(this.minimizar);
            this.panel1.Controls.Add(this.maximizar);
            this.panel1.Controls.Add(this.Salir);
            this.panel1.Controls.Add(this.restaurar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 39);
            this.panel1.TabIndex = 2;
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(1161, 7);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(20, 20);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizar.TabIndex = 2;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.Location = new System.Drawing.Point(1187, 7);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(20, 20);
            this.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maximizar.TabIndex = 3;
            this.maximizar.TabStop = false;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(1213, 7);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(20, 20);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 0;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // restaurar
            // 
            this.restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restaurar.Image = ((System.Drawing.Image)(resources.GetObject("restaurar.Image")));
            this.restaurar.Location = new System.Drawing.Point(1187, 9);
            this.restaurar.Name = "restaurar";
            this.restaurar.Size = new System.Drawing.Size(20, 20);
            this.restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restaurar.TabIndex = 1;
            this.restaurar.TabStop = false;
            this.restaurar.Visible = false;
            this.restaurar.Click += new System.EventHandler(this.restaurar_Click);
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.AutoScroll = true;
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlSideMenu.Controls.Add(this.pnlSubmenuSales);
            this.pnlSideMenu.Controls.Add(this.iconBtnSales);
            this.pnlSideMenu.Controls.Add(this.pnlSubmenuVehicle);
            this.pnlSideMenu.Controls.Add(this.iconBtnVehicle);
            this.pnlSideMenu.Controls.Add(this.pnlSubmenuCustomers);
            this.pnlSideMenu.Controls.Add(this.iconBtnCustomers);
            this.pnlSideMenu.Controls.Add(this.iconButton8);
            this.pnlSideMenu.Controls.Add(this.pnlSubmenuUsers);
            this.pnlSideMenu.Controls.Add(this.iconBtnUsers);
            this.pnlSideMenu.Controls.Add(this.pnlLogo);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(215, 633);
            this.pnlSideMenu.TabIndex = 12;
            // 
            // pnlSubmenuSales
            // 
            this.pnlSubmenuSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.pnlSubmenuSales.Controls.Add(this.iconBtnMangeSales);
            this.pnlSubmenuSales.Controls.Add(this.btnSales);
            this.pnlSubmenuSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubmenuSales.ForeColor = System.Drawing.Color.Black;
            this.pnlSubmenuSales.Location = new System.Drawing.Point(0, 420);
            this.pnlSubmenuSales.Name = "pnlSubmenuSales";
            this.pnlSubmenuSales.Size = new System.Drawing.Size(215, 70);
            this.pnlSubmenuSales.TabIndex = 11;
            this.pnlSubmenuSales.Visible = false;
            // 
            // iconBtnMangeSales
            // 
            this.iconBtnMangeSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.iconBtnMangeSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnMangeSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnMangeSales.FlatAppearance.BorderSize = 0;
            this.iconBtnMangeSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.iconBtnMangeSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.iconBtnMangeSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnMangeSales.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnMangeSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.iconBtnMangeSales.ForeColor = System.Drawing.Color.White;
            this.iconBtnMangeSales.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.iconBtnMangeSales.IconColor = System.Drawing.Color.White;
            this.iconBtnMangeSales.IconSize = 17;
            this.iconBtnMangeSales.Location = new System.Drawing.Point(0, 34);
            this.iconBtnMangeSales.Name = "iconBtnMangeSales";
            this.iconBtnMangeSales.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.iconBtnMangeSales.Rotation = 0D;
            this.iconBtnMangeSales.Size = new System.Drawing.Size(215, 34);
            this.iconBtnMangeSales.TabIndex = 13;
            this.iconBtnMangeSales.Text = "Gestionar";
            this.iconBtnMangeSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnMangeSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnMangeSales.UseVisualStyleBackColor = false;
            this.iconBtnMangeSales.Click += new System.EventHandler(this.iconBtnMangeSales_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.btnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnSales.IconColor = System.Drawing.Color.White;
            this.btnSales.IconSize = 17;
            this.btnSales.Location = new System.Drawing.Point(0, 0);
            this.btnSales.Name = "btnSales";
            this.btnSales.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.btnSales.Rotation = 0D;
            this.btnSales.Size = new System.Drawing.Size(215, 34);
            this.btnSales.TabIndex = 12;
            this.btnSales.Text = "Ver Ventas";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // iconBtnSales
            // 
            this.iconBtnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnSales.FlatAppearance.BorderSize = 0;
            this.iconBtnSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.iconBtnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.iconBtnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnSales.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F);
            this.iconBtnSales.ForeColor = System.Drawing.Color.White;
            this.iconBtnSales.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconBtnSales.IconColor = System.Drawing.Color.White;
            this.iconBtnSales.IconSize = 20;
            this.iconBtnSales.Location = new System.Drawing.Point(0, 378);
            this.iconBtnSales.Name = "iconBtnSales";
            this.iconBtnSales.Rotation = 0D;
            this.iconBtnSales.Size = new System.Drawing.Size(215, 42);
            this.iconBtnSales.TabIndex = 10;
            this.iconBtnSales.Text = "Ventas";
            this.iconBtnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSales.UseVisualStyleBackColor = true;
            this.iconBtnSales.Click += new System.EventHandler(this.iconBtnSales_Click);
            // 
            // pnlSubmenuVehicle
            // 
            this.pnlSubmenuVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.pnlSubmenuVehicle.Controls.Add(this.iconBtnManageVehicle);
            this.pnlSubmenuVehicle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubmenuVehicle.Location = new System.Drawing.Point(0, 344);
            this.pnlSubmenuVehicle.Name = "pnlSubmenuVehicle";
            this.pnlSubmenuVehicle.Size = new System.Drawing.Size(215, 34);
            this.pnlSubmenuVehicle.TabIndex = 8;
            this.pnlSubmenuVehicle.Visible = false;
            // 
            // iconBtnManageVehicle
            // 
            this.iconBtnManageVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.iconBtnManageVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnManageVehicle.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnManageVehicle.FlatAppearance.BorderSize = 0;
            this.iconBtnManageVehicle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.iconBtnManageVehicle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.iconBtnManageVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnManageVehicle.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnManageVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.iconBtnManageVehicle.ForeColor = System.Drawing.Color.White;
            this.iconBtnManageVehicle.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.iconBtnManageVehicle.IconColor = System.Drawing.Color.White;
            this.iconBtnManageVehicle.IconSize = 17;
            this.iconBtnManageVehicle.Location = new System.Drawing.Point(0, 0);
            this.iconBtnManageVehicle.Name = "iconBtnManageVehicle";
            this.iconBtnManageVehicle.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.iconBtnManageVehicle.Rotation = 0D;
            this.iconBtnManageVehicle.Size = new System.Drawing.Size(215, 34);
            this.iconBtnManageVehicle.TabIndex = 9;
            this.iconBtnManageVehicle.Text = "Gestionar";
            this.iconBtnManageVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnManageVehicle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnManageVehicle.UseVisualStyleBackColor = false;
            this.iconBtnManageVehicle.Click += new System.EventHandler(this.iconBtnManageVehicle_Click);
            // 
            // iconBtnVehicle
            // 
            this.iconBtnVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnVehicle.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnVehicle.FlatAppearance.BorderSize = 0;
            this.iconBtnVehicle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.iconBtnVehicle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.iconBtnVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnVehicle.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F);
            this.iconBtnVehicle.ForeColor = System.Drawing.Color.White;
            this.iconBtnVehicle.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.iconBtnVehicle.IconColor = System.Drawing.Color.White;
            this.iconBtnVehicle.IconSize = 20;
            this.iconBtnVehicle.Location = new System.Drawing.Point(0, 302);
            this.iconBtnVehicle.Name = "iconBtnVehicle";
            this.iconBtnVehicle.Rotation = 0D;
            this.iconBtnVehicle.Size = new System.Drawing.Size(215, 42);
            this.iconBtnVehicle.TabIndex = 7;
            this.iconBtnVehicle.Text = "Vehiculos";
            this.iconBtnVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnVehicle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnVehicle.UseVisualStyleBackColor = true;
            this.iconBtnVehicle.Click += new System.EventHandler(this.iconBtnVehicle_Click);
            // 
            // pnlSubmenuCustomers
            // 
            this.pnlSubmenuCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.pnlSubmenuCustomers.Controls.Add(this.iconBtnManageCustomers);
            this.pnlSubmenuCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlSubmenuCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubmenuCustomers.Location = new System.Drawing.Point(0, 268);
            this.pnlSubmenuCustomers.Name = "pnlSubmenuCustomers";
            this.pnlSubmenuCustomers.Size = new System.Drawing.Size(215, 34);
            this.pnlSubmenuCustomers.TabIndex = 5;
            this.pnlSubmenuCustomers.Visible = false;
            // 
            // iconBtnManageCustomers
            // 
            this.iconBtnManageCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.iconBtnManageCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnManageCustomers.FlatAppearance.BorderSize = 0;
            this.iconBtnManageCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.iconBtnManageCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(69)))), ((int)(((byte)(176)))));
            this.iconBtnManageCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnManageCustomers.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnManageCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.iconBtnManageCustomers.ForeColor = System.Drawing.Color.White;
            this.iconBtnManageCustomers.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.iconBtnManageCustomers.IconColor = System.Drawing.Color.White;
            this.iconBtnManageCustomers.IconSize = 17;
            this.iconBtnManageCustomers.Location = new System.Drawing.Point(0, 0);
            this.iconBtnManageCustomers.Name = "iconBtnManageCustomers";
            this.iconBtnManageCustomers.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.iconBtnManageCustomers.Rotation = 0D;
            this.iconBtnManageCustomers.Size = new System.Drawing.Size(215, 34);
            this.iconBtnManageCustomers.TabIndex = 6;
            this.iconBtnManageCustomers.Text = "Gestionar";
            this.iconBtnManageCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnManageCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnManageCustomers.UseVisualStyleBackColor = false;
            this.iconBtnManageCustomers.Click += new System.EventHandler(this.iconBtnManageCustomers_Click);
            // 
            // iconBtnCustomers
            // 
            this.iconBtnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnCustomers.FlatAppearance.BorderSize = 0;
            this.iconBtnCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.iconBtnCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.iconBtnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnCustomers.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F);
            this.iconBtnCustomers.ForeColor = System.Drawing.Color.White;
            this.iconBtnCustomers.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.iconBtnCustomers.IconColor = System.Drawing.Color.White;
            this.iconBtnCustomers.IconSize = 20;
            this.iconBtnCustomers.Location = new System.Drawing.Point(0, 226);
            this.iconBtnCustomers.Name = "iconBtnCustomers";
            this.iconBtnCustomers.Rotation = 0D;
            this.iconBtnCustomers.Size = new System.Drawing.Size(215, 42);
            this.iconBtnCustomers.TabIndex = 4;
            this.iconBtnCustomers.Text = "Clientes";
            this.iconBtnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnCustomers.UseVisualStyleBackColor = true;
            this.iconBtnCustomers.Click += new System.EventHandler(this.iconBtnCustomers_Click);
            // 
            // iconButton8
            // 
            this.iconButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton8.FlatAppearance.BorderSize = 0;
            this.iconButton8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.iconButton8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton8.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F);
            this.iconButton8.ForeColor = System.Drawing.Color.White;
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton8.IconColor = System.Drawing.Color.White;
            this.iconButton8.IconSize = 20;
            this.iconButton8.Location = new System.Drawing.Point(0, 591);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Rotation = 0D;
            this.iconButton8.Size = new System.Drawing.Size(215, 42);
            this.iconButton8.TabIndex = 14;
            this.iconButton8.Text = "Salir";
            this.iconButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton8.UseVisualStyleBackColor = true;
            this.iconButton8.Click += new System.EventHandler(this.iconButton8_Click);
            // 
            // pnlSubmenuUsers
            // 
            this.pnlSubmenuUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.pnlSubmenuUsers.Controls.Add(this.iconBtnManageUsers);
            this.pnlSubmenuUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlSubmenuUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubmenuUsers.Location = new System.Drawing.Point(0, 192);
            this.pnlSubmenuUsers.Name = "pnlSubmenuUsers";
            this.pnlSubmenuUsers.Size = new System.Drawing.Size(215, 34);
            this.pnlSubmenuUsers.TabIndex = 2;
            this.pnlSubmenuUsers.Visible = false;
            // 
            // iconBtnManageUsers
            // 
            this.iconBtnManageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.iconBtnManageUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnManageUsers.FlatAppearance.BorderSize = 0;
            this.iconBtnManageUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.iconBtnManageUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.iconBtnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnManageUsers.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.iconBtnManageUsers.ForeColor = System.Drawing.Color.White;
            this.iconBtnManageUsers.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.iconBtnManageUsers.IconColor = System.Drawing.Color.White;
            this.iconBtnManageUsers.IconSize = 17;
            this.iconBtnManageUsers.Location = new System.Drawing.Point(0, 0);
            this.iconBtnManageUsers.Name = "iconBtnManageUsers";
            this.iconBtnManageUsers.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.iconBtnManageUsers.Rotation = 0D;
            this.iconBtnManageUsers.Size = new System.Drawing.Size(215, 34);
            this.iconBtnManageUsers.TabIndex = 3;
            this.iconBtnManageUsers.Text = "Gestionar";
            this.iconBtnManageUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnManageUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnManageUsers.UseVisualStyleBackColor = false;
            this.iconBtnManageUsers.Click += new System.EventHandler(this.iconBtnManageUsers_Click);
            // 
            // iconBtnUsers
            // 
            this.iconBtnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnUsers.FlatAppearance.BorderSize = 0;
            this.iconBtnUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.iconBtnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.iconBtnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnUsers.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F);
            this.iconBtnUsers.ForeColor = System.Drawing.Color.White;
            this.iconBtnUsers.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconBtnUsers.IconColor = System.Drawing.Color.White;
            this.iconBtnUsers.IconSize = 20;
            this.iconBtnUsers.Location = new System.Drawing.Point(0, 150);
            this.iconBtnUsers.Name = "iconBtnUsers";
            this.iconBtnUsers.Rotation = 0D;
            this.iconBtnUsers.Size = new System.Drawing.Size(215, 42);
            this.iconBtnUsers.TabIndex = 1;
            this.iconBtnUsers.Text = "Usuarios";
            this.iconBtnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnUsers.UseVisualStyleBackColor = true;
            this.iconBtnUsers.Click += new System.EventHandler(this.iconBtnUsers_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.lblLastName);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(215, 150);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.White;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(13, 115);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(62, 16);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Usuario";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.panel2.Controls.Add(this.pnlSideMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 633);
            this.panel2.TabIndex = 13;
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(218, 39);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1019, 633);
            this.pnlContainer.TabIndex = 2;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1237, 672);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1237, 672);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).EndInit();
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlSubmenuSales.ResumeLayout(false);
            this.pnlSubmenuVehicle.ResumeLayout(false);
            this.pnlSubmenuCustomers.ResumeLayout(false);
            this.pnlSubmenuUsers.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Panel pnlSubmenuSales;
        private FontAwesome.Sharp.IconButton iconBtnMangeSales;
        private FontAwesome.Sharp.IconButton btnSales;
        private FontAwesome.Sharp.IconButton iconBtnSales;
        private System.Windows.Forms.Panel pnlSubmenuVehicle;
        private FontAwesome.Sharp.IconButton iconBtnManageVehicle;
        private FontAwesome.Sharp.IconButton iconBtnVehicle;
        private System.Windows.Forms.Panel pnlSubmenuCustomers;
        private FontAwesome.Sharp.IconButton iconBtnManageCustomers;
        private FontAwesome.Sharp.IconButton iconBtnCustomers;
        private FontAwesome.Sharp.IconButton iconButton8;
        private System.Windows.Forms.Panel pnlSubmenuUsers;
        private FontAwesome.Sharp.IconButton iconBtnManageUsers;
        private FontAwesome.Sharp.IconButton iconBtnUsers;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.PictureBox maximizar;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox restaurar;
    }
}