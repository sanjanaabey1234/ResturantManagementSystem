namespace WindowsFormsApp36
{
    partial class staffshorties
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtpn = new System.Windows.Forms.TextBox();
            this.txtsid = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtprosid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnaddfb = new System.Windows.Forms.Button();
            this.txtt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btndataaddview = new System.Windows.Forms.Button();
            this.txtpp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtpq = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView27 = new System.Windows.Forms.DataGridView();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.photoUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminshortiesesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESTURANTDATABASE2DataSet25 = new WindowsFormsApp36.RESTURANTDATABASE2DataSet25();
            this.staffsortiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESTURANTDATABASE2DataSet26 = new WindowsFormsApp36.RESTURANTDATABASE2DataSet26();
            this.adminshortiesesTableAdapter = new WindowsFormsApp36.RESTURANTDATABASE2DataSet25TableAdapters.adminshortiesesTableAdapter();
            this.staffsortiesTableAdapter = new WindowsFormsApp36.RESTURANTDATABASE2DataSet26TableAdapters.staffsortiesTableAdapter();
            this.dataGridView26 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpid11 = new System.Windows.Forms.TextBox();
            this.datadeleteview = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminshortiesesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESTURANTDATABASE2DataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsortiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESTURANTDATABASE2DataSet26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView26)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(635, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 303;
            this.label3.Text = "productid";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnclear.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(667, 550);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(128, 40);
            this.btnclear.TabIndex = 302;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.Black;
            this.btnsearch.Location = new System.Drawing.Point(667, 90);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(128, 36);
            this.btnsearch.TabIndex = 301;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtpn
            // 
            this.txtpn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtpn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpn.Location = new System.Drawing.Point(724, 143);
            this.txtpn.Multiline = true;
            this.txtpn.Name = "txtpn";
            this.txtpn.Size = new System.Drawing.Size(114, 52);
            this.txtpn.TabIndex = 300;
            // 
            // txtsid
            // 
            this.txtsid.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtsid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsid.Location = new System.Drawing.Point(724, 60);
            this.txtsid.Name = "txtsid";
            this.txtsid.Size = new System.Drawing.Size(114, 17);
            this.txtsid.TabIndex = 299;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(624, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 18);
            this.label16.TabIndex = 298;
            this.label16.Text = "productid";
            // 
            // txtprosid
            // 
            this.txtprosid.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtprosid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtprosid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprosid.Location = new System.Drawing.Point(724, 327);
            this.txtprosid.Multiline = true;
            this.txtprosid.Name = "txtprosid";
            this.txtprosid.Size = new System.Drawing.Size(114, 20);
            this.txtprosid.TabIndex = 297;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(635, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 36);
            this.label4.TabIndex = 296;
            this.label4.Text = "product\r\nname";
            // 
            // btnaddfb
            // 
            this.btnaddfb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnaddfb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddfb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddfb.ForeColor = System.Drawing.Color.Black;
            this.btnaddfb.Location = new System.Drawing.Point(667, 617);
            this.btnaddfb.Name = "btnaddfb";
            this.btnaddfb.Size = new System.Drawing.Size(128, 38);
            this.btnaddfb.TabIndex = 295;
            this.btnaddfb.Text = "add final bill";
            this.btnaddfb.UseVisualStyleBackColor = false;
            this.btnaddfb.Click += new System.EventHandler(this.btnaddfb_Click);
            // 
            // txtt
            // 
            this.txtt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtt.ForeColor = System.Drawing.Color.Black;
            this.txtt.Location = new System.Drawing.Point(724, 247);
            this.txtt.Multiline = true;
            this.txtt.Name = "txtt";
            this.txtt.Size = new System.Drawing.Size(114, 20);
            this.txtt.TabIndex = 294;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(652, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 18);
            this.label8.TabIndex = 293;
            this.label8.Text = "Total";
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btncalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalculate.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.ForeColor = System.Drawing.Color.Black;
            this.btncalculate.Location = new System.Drawing.Point(667, 283);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(128, 38);
            this.btncalculate.TabIndex = 292;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btndataaddview
            // 
            this.btndataaddview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btndataaddview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndataaddview.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndataaddview.ForeColor = System.Drawing.Color.Black;
            this.btndataaddview.Location = new System.Drawing.Point(638, 353);
            this.btndataaddview.Name = "btndataaddview";
            this.btndataaddview.Size = new System.Drawing.Size(183, 56);
            this.btndataaddview.TabIndex = 291;
            this.btndataaddview.Text = "data add View";
            this.btndataaddview.UseVisualStyleBackColor = false;
            this.btndataaddview.Click += new System.EventHandler(this.btndataaddview_Click);
            // 
            // txtpp
            // 
            this.txtpp.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtpp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpp.Location = new System.Drawing.Point(724, 201);
            this.txtpp.Name = "txtpp";
            this.txtpp.Size = new System.Drawing.Size(114, 17);
            this.txtpp.TabIndex = 290;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(651, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 18);
            this.label9.TabIndex = 289;
            this.label9.Text = "Price";
            // 
            // txtpq
            // 
            this.txtpq.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtpq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpq.ForeColor = System.Drawing.Color.Black;
            this.txtpq.Location = new System.Drawing.Point(724, 224);
            this.txtpq.Name = "txtpq";
            this.txtpq.Size = new System.Drawing.Size(114, 17);
            this.txtpq.TabIndex = 288;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(631, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 287;
            this.label10.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 284;
            this.label1.Text = "Shorties";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView27
            // 
            this.dataGridView27.AllowUserToAddRows = false;
            this.dataGridView27.AllowUserToDeleteRows = false;
            this.dataGridView27.AutoGenerateColumns = false;
            this.dataGridView27.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView27.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView27.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.productpriceDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn,
            this.photoUrlDataGridViewTextBoxColumn});
            this.dataGridView27.DataSource = this.adminshortiesesBindingSource;
            this.dataGridView27.Location = new System.Drawing.Point(12, 49);
            this.dataGridView27.Name = "dataGridView27";
            this.dataGridView27.RowTemplate.Height = 200;
            this.dataGridView27.Size = new System.Drawing.Size(570, 727);
            this.dataGridView27.TabIndex = 304;
            this.dataGridView27.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView27_CellContentClick);
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "productid";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.productidDataGridViewTextBoxColumn.HeaderText = "productid";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.Width = 80;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "productname";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productnameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.productnameDataGridViewTextBoxColumn.HeaderText = "productname";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.Width = 120;
            // 
            // productpriceDataGridViewTextBoxColumn
            // 
            this.productpriceDataGridViewTextBoxColumn.DataPropertyName = "productprice";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productpriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.productpriceDataGridViewTextBoxColumn.HeaderText = "productprice";
            this.productpriceDataGridViewTextBoxColumn.Name = "productpriceDataGridViewTextBoxColumn";
            this.productpriceDataGridViewTextBoxColumn.Width = 80;
            // 
            // photoDataGridViewImageColumn
            // 
            this.photoDataGridViewImageColumn.DataPropertyName = "Photo";
            this.photoDataGridViewImageColumn.HeaderText = "Photo";
            this.photoDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            this.photoDataGridViewImageColumn.Width = 250;
            // 
            // photoUrlDataGridViewTextBoxColumn
            // 
            this.photoUrlDataGridViewTextBoxColumn.DataPropertyName = "PhotoUrl";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photoUrlDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.photoUrlDataGridViewTextBoxColumn.HeaderText = "PhotoUrl";
            this.photoUrlDataGridViewTextBoxColumn.Name = "photoUrlDataGridViewTextBoxColumn";
            this.photoUrlDataGridViewTextBoxColumn.Visible = false;
            // 
            // adminshortiesesBindingSource
            // 
            this.adminshortiesesBindingSource.DataMember = "adminshortieses";
            this.adminshortiesesBindingSource.DataSource = this.rESTURANTDATABASE2DataSet25;
            // 
            // rESTURANTDATABASE2DataSet25
            // 
            this.rESTURANTDATABASE2DataSet25.DataSetName = "RESTURANTDATABASE2DataSet25";
            this.rESTURANTDATABASE2DataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffsortiesBindingSource
            // 
            this.staffsortiesBindingSource.DataMember = "staffsorties";
            this.staffsortiesBindingSource.DataSource = this.rESTURANTDATABASE2DataSet26;
            // 
            // rESTURANTDATABASE2DataSet26
            // 
            this.rESTURANTDATABASE2DataSet26.DataSetName = "RESTURANTDATABASE2DataSet26";
            this.rESTURANTDATABASE2DataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminshortiesesTableAdapter
            // 
            this.adminshortiesesTableAdapter.ClearBeforeFill = true;
            // 
            // staffsortiesTableAdapter
            // 
            this.staffsortiesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView26
            // 
            this.dataGridView26.AllowUserToAddRows = false;
            this.dataGridView26.AllowUserToDeleteRows = false;
            this.dataGridView26.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView26.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView26.Location = new System.Drawing.Point(863, 47);
            this.dataGridView26.Name = "dataGridView26";
            this.dataGridView26.Size = new System.Drawing.Size(511, 725);
            this.dataGridView26.TabIndex = 305;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(635, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 308;
            this.label2.Text = "productid";
            // 
            // txtpid11
            // 
            this.txtpid11.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtpid11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpid11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpid11.Location = new System.Drawing.Point(724, 431);
            this.txtpid11.Multiline = true;
            this.txtpid11.Name = "txtpid11";
            this.txtpid11.Size = new System.Drawing.Size(114, 20);
            this.txtpid11.TabIndex = 307;
            // 
            // datadeleteview
            // 
            this.datadeleteview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.datadeleteview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.datadeleteview.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datadeleteview.ForeColor = System.Drawing.Color.Black;
            this.datadeleteview.Location = new System.Drawing.Point(638, 470);
            this.datadeleteview.Name = "datadeleteview";
            this.datadeleteview.Size = new System.Drawing.Size(183, 55);
            this.datadeleteview.TabIndex = 306;
            this.datadeleteview.Text = "data delete View";
            this.datadeleteview.UseVisualStyleBackColor = false;
            this.datadeleteview.Click += new System.EventHandler(this.datadeleteview_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(1347, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 23);
            this.button3.TabIndex = 317;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 32);
            this.panel1.TabIndex = 318;
            // 
            // staffshorties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1386, 602);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpid11);
            this.Controls.Add(this.datadeleteview);
            this.Controls.Add(this.dataGridView26);
            this.Controls.Add(this.dataGridView27);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtpn);
            this.Controls.Add(this.txtsid);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtprosid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnaddfb);
            this.Controls.Add(this.txtt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.btndataaddview);
            this.Controls.Add(this.txtpp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtpq);
            this.Controls.Add(this.label10);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "staffshorties";
            this.Text = "staffshorties";
            this.Load += new System.EventHandler(this.staffshorties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminshortiesesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESTURANTDATABASE2DataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsortiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESTURANTDATABASE2DataSet26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView26)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtpn;
        private System.Windows.Forms.TextBox txtsid;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtprosid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnaddfb;
        private System.Windows.Forms.TextBox txtt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btndataaddview;
        private System.Windows.Forms.TextBox txtpp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtpq;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView27;
        private RESTURANTDATABASE2DataSet25 rESTURANTDATABASE2DataSet25;
        private System.Windows.Forms.BindingSource adminshortiesesBindingSource;
        private RESTURANTDATABASE2DataSet25TableAdapters.adminshortiesesTableAdapter adminshortiesesTableAdapter;
        private RESTURANTDATABASE2DataSet26 rESTURANTDATABASE2DataSet26;
        private System.Windows.Forms.BindingSource staffsortiesBindingSource;
        private RESTURANTDATABASE2DataSet26TableAdapters.staffsortiesTableAdapter staffsortiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView26;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpid11;
        private System.Windows.Forms.Button datadeleteview;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
    }
}