namespace WindowsFormsApp36
{
    partial class addmindrinks
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
            this.btndelete = new System.Windows.Forms.Button();
            this.txtpprice = new System.Windows.Forms.TextBox();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnbrowse4 = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtproductdid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtproductdprice = new System.Windows.Forms.TextBox();
            this.txtproductdname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.drinksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESTURANTDATABASE2DataSet11 = new WindowsFormsApp36.RESTURANTDATABASE2DataSet11();
            this.drinksTableAdapter = new WindowsFormsApp36.RESTURANTDATABASE2DataSet11TableAdapters.drinksTableAdapter();
            this.rESTURANTDATABASE2DataSet21 = new WindowsFormsApp36.RESTURANTDATABASE2DataSet21();
            this.admindrinksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admindrinksTableAdapter = new WindowsFormsApp36.RESTURANTDATABASE2DataSet21TableAdapters.admindrinksTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.admindrinkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESTURANTDATABASE2DataSet22 = new WindowsFormsApp36.RESTURANTDATABASE2DataSet22();
            this.admindrinkTableAdapter = new WindowsFormsApp36.RESTURANTDATABASE2DataSet22TableAdapters.admindrinkTableAdapter();
            this.txtprid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.photoUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESTURANTDATABASE2DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESTURANTDATABASE2DataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admindrinksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admindrinkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESTURANTDATABASE2DataSet22)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(831, 76);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 39);
            this.btndelete.TabIndex = 49;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtpprice
            // 
            this.txtpprice.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtpprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpprice.Location = new System.Drawing.Point(711, 231);
            this.txtpprice.Name = "txtpprice";
            this.txtpprice.Size = new System.Drawing.Size(126, 29);
            this.txtpprice.TabIndex = 48;
            // 
            // txtpname
            // 
            this.txtpname.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtpname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpname.Location = new System.Drawing.Point(711, 196);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(126, 29);
            this.txtpname.TabIndex = 47;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(762, 325);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 39);
            this.btnupdate.TabIndex = 46;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnbrowse4
            // 
            this.btnbrowse4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnbrowse4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowse4.Location = new System.Drawing.Point(762, 272);
            this.btnbrowse4.Name = "btnbrowse4";
            this.btnbrowse4.Size = new System.Drawing.Size(75, 37);
            this.btnbrowse4.TabIndex = 45;
            this.btnbrowse4.Text = "Browse";
            this.btnbrowse4.UseVisualStyleBackColor = false;
            this.btnbrowse4.Click += new System.EventHandler(this.btnbrowse4_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pictureBox8.Location = new System.Drawing.Point(639, 272);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(109, 92);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 44;
            this.pictureBox8.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(556, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 24);
            this.label10.TabIndex = 43;
            this.label10.Text = "photo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(556, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 24);
            this.label11.TabIndex = 42;
            this.label11.Text = "product price";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(556, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 24);
            this.label12.TabIndex = 41;
            this.label12.Text = "product name";
            // 
            // txtpid
            // 
            this.txtpid.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtpid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpid.Location = new System.Drawing.Point(711, 158);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(126, 29);
            this.txtpid.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(556, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 24);
            this.label9.TabIndex = 39;
            this.label9.Text = "product id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(659, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 24);
            this.label8.TabIndex = 38;
            this.label8.Text = "Update";
            // 
            // txtproductdid
            // 
            this.txtproductdid.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtproductdid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductdid.Location = new System.Drawing.Point(681, 82);
            this.txtproductdid.Name = "txtproductdid";
            this.txtproductdid.Size = new System.Drawing.Size(126, 29);
            this.txtproductdid.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(556, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 24);
            this.label7.TabIndex = 36;
            this.label7.Text = "product id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(659, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "Delete";
            // 
            // txtproductdprice
            // 
            this.txtproductdprice.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtproductdprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductdprice.Location = new System.Drawing.Point(170, 165);
            this.txtproductdprice.Name = "txtproductdprice";
            this.txtproductdprice.Size = new System.Drawing.Size(126, 29);
            this.txtproductdprice.TabIndex = 34;
            // 
            // txtproductdname
            // 
            this.txtproductdname.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtproductdname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductdname.Location = new System.Drawing.Point(170, 132);
            this.txtproductdname.Name = "txtproductdname";
            this.txtproductdname.Size = new System.Drawing.Size(126, 29);
            this.txtproductdname.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "Add";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(221, 259);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 39);
            this.btnsave.TabIndex = 31;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnbrowse
            // 
            this.btnbrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnbrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowse.Location = new System.Drawing.Point(221, 206);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(75, 37);
            this.btnbrowse.TabIndex = 30;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = false;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pictureBox7.Location = new System.Drawing.Point(98, 206);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(109, 92);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 29;
            this.pictureBox7.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "photo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "product price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "product name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Drinks";
            // 
            // drinksBindingSource
            // 
            this.drinksBindingSource.DataMember = "drinks";
            this.drinksBindingSource.DataSource = this.rESTURANTDATABASE2DataSet11;
            // 
            // rESTURANTDATABASE2DataSet11
            // 
            this.rESTURANTDATABASE2DataSet11.DataSetName = "RESTURANTDATABASE2DataSet11";
            this.rESTURANTDATABASE2DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drinksTableAdapter
            // 
            this.drinksTableAdapter.ClearBeforeFill = true;
            // 
            // rESTURANTDATABASE2DataSet21
            // 
            this.rESTURANTDATABASE2DataSet21.DataSetName = "RESTURANTDATABASE2DataSet21";
            this.rESTURANTDATABASE2DataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // admindrinksBindingSource
            // 
            this.admindrinksBindingSource.DataMember = "admindrinks";
            this.admindrinksBindingSource.DataSource = this.rESTURANTDATABASE2DataSet21;
            // 
            // admindrinksTableAdapter
            // 
            this.admindrinksTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.productpriceDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn,
            this.photoUrlDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.admindrinkBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(98, 370);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 200;
            this.dataGridView3.Size = new System.Drawing.Size(650, 398);
            this.dataGridView3.TabIndex = 50;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // admindrinkBindingSource
            // 
            this.admindrinkBindingSource.DataMember = "admindrink";
            this.admindrinkBindingSource.DataSource = this.rESTURANTDATABASE2DataSet22;
            // 
            // rESTURANTDATABASE2DataSet22
            // 
            this.rESTURANTDATABASE2DataSet22.DataSetName = "RESTURANTDATABASE2DataSet22";
            this.rESTURANTDATABASE2DataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // admindrinkTableAdapter
            // 
            this.admindrinkTableAdapter.ClearBeforeFill = true;
            // 
            // txtprid
            // 
            this.txtprid.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtprid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprid.Location = new System.Drawing.Point(170, 99);
            this.txtprid.Name = "txtprid";
            this.txtprid.Size = new System.Drawing.Size(126, 29);
            this.txtprid.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 24);
            this.label13.TabIndex = 51;
            this.label13.Text = "product id";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(894, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 23);
            this.button3.TabIndex = 318;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 30);
            this.panel1.TabIndex = 319;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "productid";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.productidDataGridViewTextBoxColumn.HeaderText = "productid";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.Width = 120;
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
            this.productpriceDataGridViewTextBoxColumn.Width = 120;
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
            // addmindrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(955, 602);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtprid);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtpprice);
            this.Controls.Add(this.txtpname);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnbrowse4);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtpid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtproductdid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtproductdprice);
            this.Controls.Add(this.txtproductdname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addmindrinks";
            this.Text = "addmindrinks";
            this.Load += new System.EventHandler(this.addmindrinks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESTURANTDATABASE2DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESTURANTDATABASE2DataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admindrinksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admindrinkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESTURANTDATABASE2DataSet22)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtpprice;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnbrowse4;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtproductdid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtproductdprice;
        private System.Windows.Forms.TextBox txtproductdname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RESTURANTDATABASE2DataSet11 rESTURANTDATABASE2DataSet11;
        private System.Windows.Forms.BindingSource drinksBindingSource;
        private RESTURANTDATABASE2DataSet11TableAdapters.drinksTableAdapter drinksTableAdapter;
        private RESTURANTDATABASE2DataSet21 rESTURANTDATABASE2DataSet21;
        private System.Windows.Forms.BindingSource admindrinksBindingSource;
        private RESTURANTDATABASE2DataSet21TableAdapters.admindrinksTableAdapter admindrinksTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private RESTURANTDATABASE2DataSet22 rESTURANTDATABASE2DataSet22;
        private System.Windows.Forms.BindingSource admindrinkBindingSource;
        private RESTURANTDATABASE2DataSet22TableAdapters.admindrinkTableAdapter admindrinkTableAdapter;
        private System.Windows.Forms.TextBox txtprid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoUrlDataGridViewTextBoxColumn;
    }
}