namespace WindowsFormsApp36
{
    partial class staffdrinks
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView25 = new System.Windows.Forms.DataGridView();
            this.drinksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESTURANTDATABASE2DataSet12 = new WindowsFormsApp36.RESTURANTDATABASE2DataSet12();
            this.drinksTableAdapter = new WindowsFormsApp36.RESTURANTDATABASE2DataSet12TableAdapters.drinksTableAdapter();
            this.dataGridView20 = new System.Windows.Forms.DataGridView();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.photoUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admindrinkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESTURANTDATABASE2DataSet23 = new WindowsFormsApp36.RESTURANTDATABASE2DataSet23();
            this.admindrinkTableAdapter = new WindowsFormsApp36.RESTURANTDATABASE2DataSet23TableAdapters.admindrinkTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtpn11 = new System.Windows.Forms.TextBox();
            this.txtdid11 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtt11 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btndataaddview = new System.Windows.Forms.Button();
            this.txtpp11 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtpq11 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.datadeleteview = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpid11 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.txtproid11 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESTURANTDATABASE2DataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admindrinkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESTURANTDATABASE2DataSet23)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drinks";
            // 
            // dataGridView25
            // 
            this.dataGridView25.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView25.Location = new System.Drawing.Point(876, 49);
            this.dataGridView25.Name = "dataGridView25";
            this.dataGridView25.Size = new System.Drawing.Size(498, 727);
            this.dataGridView25.TabIndex = 250;
            // 
            // drinksBindingSource
            // 
            this.drinksBindingSource.DataMember = "drinks";
            this.drinksBindingSource.DataSource = this.rESTURANTDATABASE2DataSet12;
            // 
            // rESTURANTDATABASE2DataSet12
            // 
            this.rESTURANTDATABASE2DataSet12.DataSetName = "RESTURANTDATABASE2DataSet12";
            this.rESTURANTDATABASE2DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drinksTableAdapter
            // 
            this.drinksTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView20
            // 
            this.dataGridView20.AllowUserToAddRows = false;
            this.dataGridView20.AllowUserToDeleteRows = false;
            this.dataGridView20.AutoGenerateColumns = false;
            this.dataGridView20.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView20.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView20.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.productpriceDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn,
            this.photoUrlDataGridViewTextBoxColumn});
            this.dataGridView20.DataSource = this.admindrinkBindingSource;
            this.dataGridView20.Location = new System.Drawing.Point(12, 49);
            this.dataGridView20.Name = "dataGridView20";
            this.dataGridView20.RowTemplate.Height = 200;
            this.dataGridView20.Size = new System.Drawing.Size(582, 727);
            this.dataGridView20.TabIndex = 266;
            this.dataGridView20.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView20_CellContentClick_1);
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "productid";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.productidDataGridViewTextBoxColumn.HeaderText = "productid";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.Width = 85;
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
            this.productpriceDataGridViewTextBoxColumn.Width = 85;
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
            // admindrinkBindingSource
            // 
            this.admindrinkBindingSource.DataMember = "admindrink";
            this.admindrinkBindingSource.DataSource = this.rESTURANTDATABASE2DataSet23;
            // 
            // rESTURANTDATABASE2DataSet23
            // 
            this.rESTURANTDATABASE2DataSet23.DataSetName = "RESTURANTDATABASE2DataSet23";
            this.rESTURANTDATABASE2DataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // admindrinkTableAdapter
            // 
            this.admindrinkTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(621, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 283;
            this.label3.Text = "productid";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnclear.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.Black;
            this.btnclear.Location = new System.Drawing.Point(678, 518);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(128, 47);
            this.btnclear.TabIndex = 282;
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
            this.btnsearch.Location = new System.Drawing.Point(678, 73);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(128, 38);
            this.btnsearch.TabIndex = 281;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtpn11
            // 
            this.txtpn11.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtpn11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpn11.Location = new System.Drawing.Point(719, 117);
            this.txtpn11.Multiline = true;
            this.txtpn11.Name = "txtpn11";
            this.txtpn11.Size = new System.Drawing.Size(114, 52);
            this.txtpn11.TabIndex = 280;
            this.txtpn11.TextChanged += new System.EventHandler(this.txtpn11_TextChanged);
            // 
            // txtdid11
            // 
            this.txtdid11.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtdid11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdid11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdid11.Location = new System.Drawing.Point(719, 50);
            this.txtdid11.Name = "txtdid11";
            this.txtdid11.Size = new System.Drawing.Size(114, 17);
            this.txtdid11.TabIndex = 279;
            this.txtdid11.TextChanged += new System.EventHandler(this.txtdid11_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(620, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 18);
            this.label16.TabIndex = 278;
            this.label16.Text = "productid";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(620, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 36);
            this.label4.TabIndex = 276;
            this.label4.Text = "product\r\nname";
            // 
            // txtt11
            // 
            this.txtt11.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtt11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtt11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtt11.ForeColor = System.Drawing.Color.Black;
            this.txtt11.Location = new System.Drawing.Point(719, 221);
            this.txtt11.Name = "txtt11";
            this.txtt11.Size = new System.Drawing.Size(114, 17);
            this.txtt11.TabIndex = 274;
            this.txtt11.TextChanged += new System.EventHandler(this.txtt11_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(621, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 18);
            this.label8.TabIndex = 273;
            this.label8.Text = "Total";
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btncalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalculate.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.ForeColor = System.Drawing.Color.Black;
            this.btncalculate.Location = new System.Drawing.Point(678, 256);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(128, 37);
            this.btncalculate.TabIndex = 272;
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
            this.btndataaddview.Location = new System.Drawing.Point(651, 343);
            this.btndataaddview.Name = "btndataaddview";
            this.btndataaddview.Size = new System.Drawing.Size(182, 37);
            this.btndataaddview.TabIndex = 271;
            this.btndataaddview.Text = "data add View";
            this.btndataaddview.UseVisualStyleBackColor = false;
            this.btndataaddview.Click += new System.EventHandler(this.btndataaddview_Click);
            // 
            // txtpp11
            // 
            this.txtpp11.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtpp11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpp11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpp11.Location = new System.Drawing.Point(719, 175);
            this.txtpp11.Name = "txtpp11";
            this.txtpp11.Size = new System.Drawing.Size(114, 17);
            this.txtpp11.TabIndex = 270;
            this.txtpp11.TextChanged += new System.EventHandler(this.txtpp11_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(620, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 18);
            this.label9.TabIndex = 269;
            this.label9.Text = "Price";
            // 
            // txtpq11
            // 
            this.txtpq11.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtpq11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpq11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpq11.ForeColor = System.Drawing.Color.Black;
            this.txtpq11.Location = new System.Drawing.Point(719, 198);
            this.txtpq11.Name = "txtpq11";
            this.txtpq11.Size = new System.Drawing.Size(114, 17);
            this.txtpq11.TabIndex = 268;
            this.txtpq11.TextChanged += new System.EventHandler(this.txtpq11_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(620, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 267;
            this.label10.Text = "Quantity";
            // 
            // datadeleteview
            // 
            this.datadeleteview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.datadeleteview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.datadeleteview.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datadeleteview.ForeColor = System.Drawing.Color.Black;
            this.datadeleteview.Location = new System.Drawing.Point(651, 439);
            this.datadeleteview.Name = "datadeleteview";
            this.datadeleteview.Size = new System.Drawing.Size(182, 55);
            this.datadeleteview.TabIndex = 284;
            this.datadeleteview.Text = "data delete View";
            this.datadeleteview.UseVisualStyleBackColor = false;
            this.datadeleteview.Click += new System.EventHandler(this.datadeleteview_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(621, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 286;
            this.label2.Text = "productid";
            // 
            // txtpid11
            // 
            this.txtpid11.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtpid11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpid11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpid11.Location = new System.Drawing.Point(719, 397);
            this.txtpid11.Name = "txtpid11";
            this.txtpid11.Size = new System.Drawing.Size(114, 17);
            this.txtpid11.TabIndex = 285;
            this.txtpid11.TextChanged += new System.EventHandler(this.txtpid11_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 33);
            this.panel1.TabIndex = 288;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(1347, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 23);
            this.button3.TabIndex = 319;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtproid11
            // 
            this.txtproid11.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtproid11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtproid11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproid11.Location = new System.Drawing.Point(719, 308);
            this.txtproid11.Name = "txtproid11";
            this.txtproid11.Size = new System.Drawing.Size(114, 17);
            this.txtproid11.TabIndex = 277;
            this.txtproid11.TextChanged += new System.EventHandler(this.txtproid11_TextChanged);
            // 
            // staffdrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpid11);
            this.Controls.Add(this.datadeleteview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtpn11);
            this.Controls.Add(this.txtdid11);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtproid11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtt11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.btndataaddview);
            this.Controls.Add(this.txtpp11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtpq11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView20);
            this.Controls.Add(this.dataGridView25);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "staffdrinks";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.staffdrinks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESTURANTDATABASE2DataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admindrinkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESTURANTDATABASE2DataSet23)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView25;
        private RESTURANTDATABASE2DataSet12 rESTURANTDATABASE2DataSet12;
        private System.Windows.Forms.BindingSource drinksBindingSource;
        private RESTURANTDATABASE2DataSet12TableAdapters.drinksTableAdapter drinksTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView20;
        private RESTURANTDATABASE2DataSet23 rESTURANTDATABASE2DataSet23;
        private System.Windows.Forms.BindingSource admindrinkBindingSource;
        private RESTURANTDATABASE2DataSet23TableAdapters.admindrinkTableAdapter admindrinkTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtpn11;
        private System.Windows.Forms.TextBox txtdid11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtt11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btndataaddview;
        private System.Windows.Forms.TextBox txtpp11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtpq11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button datadeleteview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpid11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtproid11;
    }
}