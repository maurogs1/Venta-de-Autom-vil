namespace Vistas.Views
{
    partial class ListSalesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListSalesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.iconButtonFilterState = new FontAwesome.Sharp.IconButton();
            this.comboBoxStateFilter = new System.Windows.Forms.ComboBox();
            this.btnGetAll = new FontAwesome.Sharp.IconButton();
            this.dtpLastDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.cmbListSearch = new System.Windows.Forms.ComboBox();
            this.txtNumericSale = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCancelSale = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getUsersByRolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPrint = new FontAwesome.Sharp.IconButton();
            this.buttonFilterState = new System.Windows.Forms.Button();
            this.labelImportTotalAnuladas = new System.Windows.Forms.Label();
            this.cmbStateFilter = new System.Windows.Forms.ComboBox();
            this.labelImportTotalAcitve = new System.Windows.Forms.Label();
            this.labelImportTotal = new System.Windows.Forms.Label();
            this.labelCountAnuladas = new System.Windows.Forms.Label();
            this.labelCountAcitves = new System.Windows.Forms.Label();
            this.labelCountSales = new System.Windows.Forms.Label();
            this.buttonCancelSale = new System.Windows.Forms.Button();
            this.textNumericSales = new System.Windows.Forms.TextBox();
            this.lblSale = new System.Windows.Forms.Label();
            this.grdSales = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSeeAllSales = new System.Windows.Forms.Button();
            this.btnSearchFilter = new System.Windows.Forms.Button();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.comboBoxListSearch = new System.Windows.Forms.ComboBox();
            this.dateTimePickerLast = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFirst = new System.Windows.Forms.DateTimePicker();
            this.lblTitleFilter = new System.Windows.Forms.Label();
            this.labelTitleSale = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getUsersByRolBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSales)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSales.BackgroundColor = System.Drawing.Color.White;
            this.dgvSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSales.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSales.Location = new System.Drawing.Point(47, 180);
            this.dgvSales.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSales.MaximumSize = new System.Drawing.Size(972, 348);
            this.dgvSales.MinimumSize = new System.Drawing.Size(932, 338);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RowHeadersVisible = false;
            this.dgvSales.RowHeadersWidth = 30;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(932, 348);
            this.dgvSales.TabIndex = 15;
            // 
            // iconButtonFilterState
            // 
            this.iconButtonFilterState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.iconButtonFilterState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonFilterState.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonFilterState.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonFilterState.ForeColor = System.Drawing.Color.White;
            this.iconButtonFilterState.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButtonFilterState.IconColor = System.Drawing.Color.Black;
            this.iconButtonFilterState.IconSize = 18;
            this.iconButtonFilterState.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonFilterState.Location = new System.Drawing.Point(201, 110);
            this.iconButtonFilterState.Name = "iconButtonFilterState";
            this.iconButtonFilterState.Rotation = 0D;
            this.iconButtonFilterState.Size = new System.Drawing.Size(68, 23);
            this.iconButtonFilterState.TabIndex = 46;
            this.iconButtonFilterState.Text = "Filtrar";
            this.iconButtonFilterState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonFilterState.UseVisualStyleBackColor = false;
            // 
            // comboBoxStateFilter
            // 
            this.comboBoxStateFilter.FormattingEnabled = true;
            this.comboBoxStateFilter.Items.AddRange(new object[] {
            "Activa",
            "Anulado"});
            this.comboBoxStateFilter.Location = new System.Drawing.Point(74, 110);
            this.comboBoxStateFilter.Name = "comboBoxStateFilter";
            this.comboBoxStateFilter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStateFilter.TabIndex = 45;
            this.comboBoxStateFilter.Text = "Buscar Por Estado";
            // 
            // btnGetAll
            // 
            this.btnGetAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.btnGetAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetAll.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGetAll.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAll.ForeColor = System.Drawing.Color.White;
            this.btnGetAll.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnGetAll.IconColor = System.Drawing.Color.Black;
            this.btnGetAll.IconSize = 20;
            this.btnGetAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetAll.Location = new System.Drawing.Point(987, 454);
            this.btnGetAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Rotation = 0D;
            this.btnGetAll.Size = new System.Drawing.Size(93, 34);
            this.btnGetAll.TabIndex = 41;
            this.btnGetAll.Text = "Ver todo";
            this.btnGetAll.UseVisualStyleBackColor = false;
            // 
            // dtpLastDate
            // 
            this.dtpLastDate.Location = new System.Drawing.Point(4, 60);
            this.dtpLastDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpLastDate.Name = "dtpLastDate";
            this.dtpLastDate.Size = new System.Drawing.Size(233, 23);
            this.dtpLastDate.TabIndex = 6;
            this.dtpLastDate.Visible = false;
            this.dtpLastDate.Enter += new System.EventHandler(this.controlDateTimePicker);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.btnSearch.Enabled = false;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconSize = 20;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(987, 412);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Rotation = 0D;
            this.btnSearch.Size = new System.Drawing.Size(93, 34);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // cmbListSearch
            // 
            this.cmbListSearch.FormattingEnabled = true;
            this.cmbListSearch.Items.AddRange(new object[] {
            "Fecha",
            "Marca",
            "Vendedor",
            "Cliente"});
            this.cmbListSearch.Location = new System.Drawing.Point(987, 369);
            this.cmbListSearch.Margin = new System.Windows.Forms.Padding(4);
            this.cmbListSearch.Name = "cmbListSearch";
            this.cmbListSearch.Size = new System.Drawing.Size(93, 24);
            this.cmbListSearch.TabIndex = 3;
            this.cmbListSearch.SelectedIndexChanged += new System.EventHandler(this.cmbListSearch_SelectedIndexChanged);
            // 
            // txtNumericSale
            // 
            this.txtNumericSale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumericSale.BackColor = System.Drawing.Color.White;
            this.txtNumericSale.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumericSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.txtNumericSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumericSale.HintForeColor = System.Drawing.Color.Empty;
            this.txtNumericSale.HintText = "Ingrese numero de venta a  anular";
            this.txtNumericSale.isPassword = false;
            this.txtNumericSale.LineFocusedColor = System.Drawing.Color.White;
            this.txtNumericSale.LineIdleColor = System.Drawing.Color.White;
            this.txtNumericSale.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtNumericSale.LineThickness = 3;
            this.txtNumericSale.Location = new System.Drawing.Point(163, 21);
            this.txtNumericSale.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumericSale.MaximumSize = new System.Drawing.Size(227, 27);
            this.txtNumericSale.MinimumSize = new System.Drawing.Size(224, 24);
            this.txtNumericSale.Name = "txtNumericSale";
            this.txtNumericSale.Size = new System.Drawing.Size(224, 24);
            this.txtNumericSale.TabIndex = 37;
            this.txtNumericSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.pictureBox3.TabIndex = 33;
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
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // btnCancelSale
            // 
            this.btnCancelSale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnCancelSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelSale.FlatAppearance.BorderSize = 0;
            this.btnCancelSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.btnCancelSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(69)))), ((int)(((byte)(176)))));
            this.btnCancelSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.btnCancelSale.ForeColor = System.Drawing.Color.White;
            this.btnCancelSale.Location = new System.Drawing.Point(610, 94);
            this.btnCancelSale.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelSale.MaximumSize = new System.Drawing.Size(105, 38);
            this.btnCancelSale.MinimumSize = new System.Drawing.Size(100, 33);
            this.btnCancelSale.Name = "btnCancelSale";
            this.btnCancelSale.Size = new System.Drawing.Size(105, 33);
            this.btnCancelSale.TabIndex = 30;
            this.btnCancelSale.Text = "Anular Venta";
            this.btnCancelSale.UseVisualStyleBackColor = false;
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
            this.lblTitle.Size = new System.Drawing.Size(254, 31);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "Gestión de Ventas";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpLastDate);
            this.panel1.Location = new System.Drawing.Point(726, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 100);
            this.panel1.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.buttonFilterState);
            this.panel3.Controls.Add(this.labelImportTotalAnuladas);
            this.panel3.Controls.Add(this.cmbStateFilter);
            this.panel3.Controls.Add(this.labelImportTotalAcitve);
            this.panel3.Controls.Add(this.labelImportTotal);
            this.panel3.Controls.Add(this.labelCountAnuladas);
            this.panel3.Controls.Add(this.labelCountAcitves);
            this.panel3.Controls.Add(this.labelCountSales);
            this.panel3.Controls.Add(this.buttonCancelSale);
            this.panel3.Controls.Add(this.textNumericSales);
            this.panel3.Controls.Add(this.lblSale);
            this.panel3.Controls.Add(this.grdSales);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.labelTitleSale);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1298, 749);
            this.panel3.TabIndex = 45;
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
            this.btnPrint.Location = new System.Drawing.Point(979, 663);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Rotation = 0D;
            this.btnPrint.Size = new System.Drawing.Size(96, 35);
            this.btnPrint.TabIndex = 61;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // buttonFilterState
            // 
            this.buttonFilterState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilterState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.buttonFilterState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilterState.FlatAppearance.BorderSize = 0;
            this.buttonFilterState.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.buttonFilterState.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(69)))), ((int)(((byte)(176)))));
            this.buttonFilterState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFilterState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.buttonFilterState.ForeColor = System.Drawing.Color.White;
            this.buttonFilterState.Location = new System.Drawing.Point(944, 247);
            this.buttonFilterState.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFilterState.MaximumSize = new System.Drawing.Size(105, 38);
            this.buttonFilterState.MinimumSize = new System.Drawing.Size(100, 33);
            this.buttonFilterState.Name = "buttonFilterState";
            this.buttonFilterState.Size = new System.Drawing.Size(100, 33);
            this.buttonFilterState.TabIndex = 53;
            this.buttonFilterState.Text = "Aceptar";
            this.buttonFilterState.UseVisualStyleBackColor = false;
            this.buttonFilterState.Click += new System.EventHandler(this.buttonFilterState_Click);
            // 
            // labelImportTotalAnuladas
            // 
            this.labelImportTotalAnuladas.AutoSize = true;
            this.labelImportTotalAnuladas.Location = new System.Drawing.Point(627, 689);
            this.labelImportTotalAnuladas.Name = "labelImportTotalAnuladas";
            this.labelImportTotalAnuladas.Size = new System.Drawing.Size(16, 17);
            this.labelImportTotalAnuladas.TabIndex = 60;
            this.labelImportTotalAnuladas.Text = "0";
            // 
            // cmbStateFilter
            // 
            this.cmbStateFilter.FormattingEnabled = true;
            this.cmbStateFilter.Items.AddRange(new object[] {
            "Activa",
            "Anulado"});
            this.cmbStateFilter.Location = new System.Drawing.Point(745, 249);
            this.cmbStateFilter.Name = "cmbStateFilter";
            this.cmbStateFilter.Size = new System.Drawing.Size(172, 24);
            this.cmbStateFilter.TabIndex = 52;
            this.cmbStateFilter.Text = "Buscar Por Estado";
            // 
            // labelImportTotalAcitve
            // 
            this.labelImportTotalAcitve.AutoSize = true;
            this.labelImportTotalAcitve.Location = new System.Drawing.Point(627, 672);
            this.labelImportTotalAcitve.Name = "labelImportTotalAcitve";
            this.labelImportTotalAcitve.Size = new System.Drawing.Size(16, 17);
            this.labelImportTotalAcitve.TabIndex = 59;
            this.labelImportTotalAcitve.Text = "0";
            // 
            // labelImportTotal
            // 
            this.labelImportTotal.AutoSize = true;
            this.labelImportTotal.Location = new System.Drawing.Point(627, 653);
            this.labelImportTotal.Name = "labelImportTotal";
            this.labelImportTotal.Size = new System.Drawing.Size(16, 17);
            this.labelImportTotal.TabIndex = 58;
            this.labelImportTotal.Text = "0";
            // 
            // labelCountAnuladas
            // 
            this.labelCountAnuladas.AutoSize = true;
            this.labelCountAnuladas.Location = new System.Drawing.Point(149, 689);
            this.labelCountAnuladas.Name = "labelCountAnuladas";
            this.labelCountAnuladas.Size = new System.Drawing.Size(16, 17);
            this.labelCountAnuladas.TabIndex = 57;
            this.labelCountAnuladas.Text = "0";
            // 
            // labelCountAcitves
            // 
            this.labelCountAcitves.AutoSize = true;
            this.labelCountAcitves.Location = new System.Drawing.Point(149, 672);
            this.labelCountAcitves.Name = "labelCountAcitves";
            this.labelCountAcitves.Size = new System.Drawing.Size(16, 17);
            this.labelCountAcitves.TabIndex = 56;
            this.labelCountAcitves.Text = "0";
            // 
            // labelCountSales
            // 
            this.labelCountSales.AutoSize = true;
            this.labelCountSales.Location = new System.Drawing.Point(149, 653);
            this.labelCountSales.Name = "labelCountSales";
            this.labelCountSales.Size = new System.Drawing.Size(16, 17);
            this.labelCountSales.TabIndex = 55;
            this.labelCountSales.Text = "0";
            // 
            // buttonCancelSale
            // 
            this.buttonCancelSale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.buttonCancelSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelSale.FlatAppearance.BorderSize = 0;
            this.buttonCancelSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.buttonCancelSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(69)))), ((int)(((byte)(176)))));
            this.buttonCancelSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.buttonCancelSale.ForeColor = System.Drawing.Color.White;
            this.buttonCancelSale.Location = new System.Drawing.Point(346, 247);
            this.buttonCancelSale.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelSale.MaximumSize = new System.Drawing.Size(105, 38);
            this.buttonCancelSale.MinimumSize = new System.Drawing.Size(100, 33);
            this.buttonCancelSale.Name = "buttonCancelSale";
            this.buttonCancelSale.Size = new System.Drawing.Size(100, 33);
            this.buttonCancelSale.TabIndex = 54;
            this.buttonCancelSale.Text = "Anular";
            this.buttonCancelSale.UseVisualStyleBackColor = false;
            this.buttonCancelSale.Click += new System.EventHandler(this.buttonCancelSale_Click);
            // 
            // textNumericSales
            // 
            this.textNumericSales.Location = new System.Drawing.Point(219, 252);
            this.textNumericSales.Name = "textNumericSales";
            this.textNumericSales.Size = new System.Drawing.Size(106, 23);
            this.textNumericSales.TabIndex = 51;
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSale.Location = new System.Drawing.Point(134, 252);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(79, 16);
            this.lblSale.TabIndex = 50;
            this.lblSale.Text = "N° de Venta";
            this.lblSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grdSales
            // 
            this.grdSales.AllowUserToAddRows = false;
            this.grdSales.AllowUserToDeleteRows = false;
            this.grdSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdSales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdSales.BackgroundColor = System.Drawing.Color.White;
            this.grdSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdSales.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdSales.Location = new System.Drawing.Point(143, 288);
            this.grdSales.Margin = new System.Windows.Forms.Padding(4);
            this.grdSales.MaximumSize = new System.Drawing.Size(972, 348);
            this.grdSales.MinimumSize = new System.Drawing.Size(932, 338);
            this.grdSales.Name = "grdSales";
            this.grdSales.ReadOnly = true;
            this.grdSales.RowHeadersVisible = false;
            this.grdSales.RowHeadersWidth = 30;
            this.grdSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSales.Size = new System.Drawing.Size(932, 338);
            this.grdSales.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnSeeAllSales);
            this.panel2.Controls.Add(this.btnSearchFilter);
            this.panel2.Controls.Add(this.cmbClientes);
            this.panel2.Controls.Add(this.cmbVendedor);
            this.panel2.Controls.Add(this.cmbBrand);
            this.panel2.Controls.Add(this.comboBoxListSearch);
            this.panel2.Controls.Add(this.dateTimePickerLast);
            this.panel2.Controls.Add(this.dateTimePickerFirst);
            this.panel2.Controls.Add(this.lblTitleFilter);
            this.panel2.Location = new System.Drawing.Point(137, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 158);
            this.panel2.TabIndex = 48;
            // 
            // btnSeeAllSales
            // 
            this.btnSeeAllSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSeeAllSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnSeeAllSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeeAllSales.FlatAppearance.BorderSize = 0;
            this.btnSeeAllSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.btnSeeAllSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(69)))), ((int)(((byte)(176)))));
            this.btnSeeAllSales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeeAllSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.btnSeeAllSales.ForeColor = System.Drawing.Color.White;
            this.btnSeeAllSales.Location = new System.Drawing.Point(719, 115);
            this.btnSeeAllSales.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeeAllSales.MaximumSize = new System.Drawing.Size(105, 38);
            this.btnSeeAllSales.MinimumSize = new System.Drawing.Size(100, 33);
            this.btnSeeAllSales.Name = "btnSeeAllSales";
            this.btnSeeAllSales.Size = new System.Drawing.Size(100, 33);
            this.btnSeeAllSales.TabIndex = 51;
            this.btnSeeAllSales.Text = "Ver Todo";
            this.btnSeeAllSales.UseVisualStyleBackColor = false;
            this.btnSeeAllSales.Click += new System.EventHandler(this.btnSeeAllSales_Click);
            // 
            // btnSearchFilter
            // 
            this.btnSearchFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnSearchFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchFilter.FlatAppearance.BorderSize = 0;
            this.btnSearchFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(70)))), ((int)(((byte)(151)))));
            this.btnSearchFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(69)))), ((int)(((byte)(176)))));
            this.btnSearchFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F);
            this.btnSearchFilter.ForeColor = System.Drawing.Color.White;
            this.btnSearchFilter.Location = new System.Drawing.Point(719, 74);
            this.btnSearchFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchFilter.MaximumSize = new System.Drawing.Size(105, 38);
            this.btnSearchFilter.MinimumSize = new System.Drawing.Size(100, 33);
            this.btnSearchFilter.Name = "btnSearchFilter";
            this.btnSearchFilter.Size = new System.Drawing.Size(100, 33);
            this.btnSearchFilter.TabIndex = 50;
            this.btnSearchFilter.Text = "Buscar";
            this.btnSearchFilter.UseVisualStyleBackColor = false;
            this.btnSearchFilter.Click += new System.EventHandler(this.btnSearchFilter_Click);
            // 
            // cmbClientes
            // 
            this.cmbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(454, 83);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(172, 24);
            this.cmbClientes.TabIndex = 49;
            this.cmbClientes.Text = "Seleccione un cliente...";
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(262, 83);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(172, 24);
            this.cmbVendedor.TabIndex = 48;
            this.cmbVendedor.Text = "Seleccione vendedor...";
            // 
            // cmbBrand
            // 
            this.cmbBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Items.AddRange(new object[] {
            "Chevrolet",
            "Volkswagen",
            "Renault"});
            this.cmbBrand.Location = new System.Drawing.Point(66, 83);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(172, 24);
            this.cmbBrand.TabIndex = 47;
            this.cmbBrand.Text = "Seleccione marca...";
            // 
            // comboBoxListSearch
            // 
            this.comboBoxListSearch.FormattingEnabled = true;
            this.comboBoxListSearch.Items.AddRange(new object[] {
            "Fecha",
            "Marca",
            "Vendedor",
            "Cliente"});
            this.comboBoxListSearch.Location = new System.Drawing.Point(719, 37);
            this.comboBoxListSearch.Name = "comboBoxListSearch";
            this.comboBoxListSearch.Size = new System.Drawing.Size(133, 24);
            this.comboBoxListSearch.TabIndex = 46;
            this.comboBoxListSearch.SelectedIndexChanged += new System.EventHandler(this.cmbListSearch_SelectedIndexChanged);
            // 
            // dateTimePickerLast
            // 
            this.dateTimePickerLast.Location = new System.Drawing.Point(62, 33);
            this.dateTimePickerLast.Name = "dateTimePickerLast";
            this.dateTimePickerLast.Size = new System.Drawing.Size(176, 23);
            this.dateTimePickerLast.TabIndex = 45;
            // 
            // dateTimePickerFirst
            // 
            this.dateTimePickerFirst.Location = new System.Drawing.Point(262, 30);
            this.dateTimePickerFirst.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFirst.Name = "dateTimePickerFirst";
            this.dateTimePickerFirst.Size = new System.Drawing.Size(172, 23);
            this.dateTimePickerFirst.TabIndex = 44;
            this.dateTimePickerFirst.TabStop = false;
            // 
            // lblTitleFilter
            // 
            this.lblTitleFilter.AutoSize = true;
            this.lblTitleFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitleFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleFilter.Location = new System.Drawing.Point(0, 0);
            this.lblTitleFilter.Name = "lblTitleFilter";
            this.lblTitleFilter.Size = new System.Drawing.Size(59, 20);
            this.lblTitleFilter.TabIndex = 43;
            this.lblTitleFilter.Text = "Filtros";
            this.lblTitleFilter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTitleSale
            // 
            this.labelTitleSale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitleSale.AutoSize = true;
            this.labelTitleSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleSale.Location = new System.Drawing.Point(449, 39);
            this.labelTitleSale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitleSale.MaximumSize = new System.Drawing.Size(293, 34);
            this.labelTitleSale.MinimumSize = new System.Drawing.Size(290, 31);
            this.labelTitleSale.Name = "labelTitleSale";
            this.labelTitleSale.Size = new System.Drawing.Size(290, 31);
            this.labelTitleSale.TabIndex = 47;
            this.labelTitleSale.Text = "Ventas";
            this.labelTitleSale.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ListSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1298, 749);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.cmbListSearch);
            this.Controls.Add(this.txtNumericSale);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancelSale);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListSalesForm";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.ListSalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getUsersByRolBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSales)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpLastDate;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.ComboBox cmbListSearch;
       // private System.Windows.Forms.DateTimePicker dtpFirstDate;
        private FontAwesome.Sharp.IconButton btnGetAll;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.BindingSource getUsersByRolBindingSource;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNumericSale;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCancelSale;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNumeroDeVentas;
        private System.Windows.Forms.Label lblNumeroDeVentasAnuladas;
        private System.Windows.Forms.ComboBox comboBoxStateFilter;
        private FontAwesome.Sharp.IconButton iconButtonFilterState;
        private System.Windows.Forms.Label labelTitleSale;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitleFilter;
        private System.Windows.Forms.DateTimePicker dateTimePickerLast;
        private System.Windows.Forms.DateTimePicker dateTimePickerFirst;
        private System.Windows.Forms.DataGridView grdSales;
        private System.Windows.Forms.ComboBox comboBoxListSearch;
        public System.Windows.Forms.ComboBox cmbBrand;
        public System.Windows.Forms.ComboBox cmbVendedor;
        public System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Button btnSearchFilter;
        private System.Windows.Forms.Button btnSeeAllSales;
        private System.Windows.Forms.ComboBox cmbStateFilter;
        private System.Windows.Forms.Button buttonFilterState;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.TextBox textNumericSales;
        private System.Windows.Forms.Button buttonCancelSale;
        private System.Windows.Forms.Label labelCountSales;
        private System.Windows.Forms.Label labelCountAcitves;
        private System.Windows.Forms.Label labelCountAnuladas;
        private System.Windows.Forms.Label labelImportTotal;
        private System.Windows.Forms.Label labelImportTotalAcitve;
        private System.Windows.Forms.Label labelImportTotalAnuladas;
        private FontAwesome.Sharp.IconButton btnPrint;
        //private System.Windows.Forms.TextBox txtNumericSale;
        //private System.Windows.Forms.Button btnCancelSale;
        //private System.Windows.Forms.Label lblImporteTotal;
        //private System.Windows.Forms.Label lblNumeroDeVentasAnuladas;
        //private System.Windows.Forms.Label lblNumeroDeVentas;
    }
}