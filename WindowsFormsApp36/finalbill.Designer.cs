namespace WindowsFormsApp36
{
    partial class finalbill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addfinalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rESTURANTDATABASE2DataSet6 = new WindowsFormsApp36.RESTURANTDATABASE2DataSet6();
            this.rESTURANTDATABASE2DataSet5 = new WindowsFormsApp36.RESTURANTDATABASE2DataSet5();
            this.addfinalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addfinalTableAdapter = new WindowsFormsApp36.RESTURANTDATABASE2DataSet5TableAdapters.addfinalTableAdapter();
            this.addfinalTableAdapter1 = new WindowsFormsApp36.RESTURANTDATABASE2DataSet6TableAdapters.addfinalTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtproid = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView41 = new System.Windows.Forms.DataGridView();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalreportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESTURANTDATABASE2DataSet14 = new WindowsFormsApp36.RESTURANTDATABASE2DataSet14();
            this.finalreportTableAdapter = new WindowsFormsApp36.RESTURANTDATABASE2DataSet14TableAdapters.finalreportTableAdapter();
            this.btnclear = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addfinalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESTURANTDATABASE2DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESTURANTDATABASE2DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addfinalBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalreportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESTURANTDATABASE2DataSet14)).BeginInit();
            this.SuspendLayout();
            // 
            // addfinalBindingSource1
            // 
            this.addfinalBindingSource1.DataMember = "addfinal";
            this.addfinalBindingSource1.DataSource = this.rESTURANTDATABASE2DataSet6;
            // 
            // rESTURANTDATABASE2DataSet6
            // 
            this.rESTURANTDATABASE2DataSet6.DataSetName = "RESTURANTDATABASE2DataSet6";
            this.rESTURANTDATABASE2DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rESTURANTDATABASE2DataSet5
            // 
            this.rESTURANTDATABASE2DataSet5.DataSetName = "RESTURANTDATABASE2DataSet5";
            this.rESTURANTDATABASE2DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addfinalBindingSource
            // 
            this.addfinalBindingSource.DataMember = "addfinal";
            this.addfinalBindingSource.DataSource = this.rESTURANTDATABASE2DataSet5;
            // 
            // addfinalTableAdapter
            // 
            this.addfinalTableAdapter.ClearBeforeFill = true;
            // 
            // addfinalTableAdapter1
            // 
            this.addfinalTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Final Bill Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(736, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "delete";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(597, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "product id";
            // 
            // txtproid
            // 
            this.txtproid.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtproid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtproid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproid.ForeColor = System.Drawing.Color.Black;
            this.txtproid.Location = new System.Drawing.Point(712, 343);
            this.txtproid.Name = "txtproid";
            this.txtproid.Size = new System.Drawing.Size(124, 23);
            this.txtproid.TabIndex = 4;
            // 
            // btndelete
            // 
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Lime;
            this.btndelete.Location = new System.Drawing.Point(888, 334);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(91, 37);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 33);
            this.panel1.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(1096, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 23);
            this.button3.TabIndex = 318;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView41
            // 
            this.dataGridView41.AllowUserToAddRows = false;
            this.dataGridView41.AllowUserToDeleteRows = false;
            this.dataGridView41.AutoGenerateColumns = false;
            this.dataGridView41.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView41.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView41.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView41.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.productpriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView41.DataSource = this.finalreportBindingSource;
            this.dataGridView41.Location = new System.Drawing.Point(12, 50);
            this.dataGridView41.Name = "dataGridView41";
            this.dataGridView41.RowTemplate.Height = 50;
            this.dataGridView41.Size = new System.Drawing.Size(564, 416);
            this.dataGridView41.TabIndex = 10;
            this.dataGridView41.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "productid";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.productidDataGridViewTextBoxColumn.HeaderText = "productid";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.Width = 90;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "productname";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productnameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.productnameDataGridViewTextBoxColumn.HeaderText = "productname";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.Width = 170;
            // 
            // productpriceDataGridViewTextBoxColumn
            // 
            this.productpriceDataGridViewTextBoxColumn.DataPropertyName = "productprice";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productpriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.productpriceDataGridViewTextBoxColumn.HeaderText = "productprice";
            this.productpriceDataGridViewTextBoxColumn.Name = "productpriceDataGridViewTextBoxColumn";
            this.productpriceDataGridViewTextBoxColumn.Width = 90;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 90;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 90;
            // 
            // finalreportBindingSource
            // 
            this.finalreportBindingSource.DataMember = "finalreport";
            this.finalreportBindingSource.DataSource = this.rESTURANTDATABASE2DataSet14;
            // 
            // rESTURANTDATABASE2DataSet14
            // 
            this.rESTURANTDATABASE2DataSet14.DataSetName = "RESTURANTDATABASE2DataSet14";
            this.rESTURANTDATABASE2DataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // finalreportTableAdapter
            // 
            this.finalreportTableAdapter.ClearBeforeFill = true;
            // 
            // btnclear
            // 
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.Lime;
            this.btnclear.Location = new System.Drawing.Point(603, 422);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(91, 37);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // report
            // 
            this.report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.report.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report.ForeColor = System.Drawing.Color.Lime;
            this.report.Location = new System.Drawing.Point(728, 422);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(91, 37);
            this.report.TabIndex = 13;
            this.report.Text = "report";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // finalbill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1135, 658);
            this.Controls.Add(this.report);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.dataGridView41);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtproid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "finalbill";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addfinalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESTURANTDATABASE2DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESTURANTDATABASE2DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addfinalBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalreportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESTURANTDATABASE2DataSet14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RESTURANTDATABASE2DataSet5 rESTURANTDATABASE2DataSet5;
        private System.Windows.Forms.BindingSource addfinalBindingSource;
        private RESTURANTDATABASE2DataSet5TableAdapters.addfinalTableAdapter addfinalTableAdapter;
        private RESTURANTDATABASE2DataSet6 rESTURANTDATABASE2DataSet6;
        private System.Windows.Forms.BindingSource addfinalBindingSource1;
        private RESTURANTDATABASE2DataSet6TableAdapters.addfinalTableAdapter addfinalTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtproid;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView41;
        private RESTURANTDATABASE2DataSet14 rESTURANTDATABASE2DataSet14;
        private System.Windows.Forms.BindingSource finalreportBindingSource;
        private RESTURANTDATABASE2DataSet14TableAdapters.finalreportTableAdapter finalreportTableAdapter;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button report;
    }
}