
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.languageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new WindowsFormsApp1.AppData();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.englishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.germanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frenchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.appData1 = new WindowsFormsApp1.AppData();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(686, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(60, 243);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 21);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // languageBindingSource1
            // 
            this.languageBindingSource1.DataMember = "Language";
            this.languageBindingSource1.DataSource = this.appDataBindingSource;
            // 
            // appDataBindingSource
            // 
            this.appDataBindingSource.DataSource = this.appData;
            this.appDataBindingSource.Position = 0;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.englishDataGridViewTextBoxColumn,
            this.germanDataGridViewTextBoxColumn,
            this.frenchDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.languageBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(60, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(728, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // englishDataGridViewTextBoxColumn
            // 
            this.englishDataGridViewTextBoxColumn.DataPropertyName = "English";
            this.englishDataGridViewTextBoxColumn.HeaderText = "English";
            this.englishDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.englishDataGridViewTextBoxColumn.Name = "englishDataGridViewTextBoxColumn";
            this.englishDataGridViewTextBoxColumn.Width = 125;
            // 
            // germanDataGridViewTextBoxColumn
            // 
            this.germanDataGridViewTextBoxColumn.DataPropertyName = "German";
            this.germanDataGridViewTextBoxColumn.HeaderText = "German";
            this.germanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.germanDataGridViewTextBoxColumn.Name = "germanDataGridViewTextBoxColumn";
            this.germanDataGridViewTextBoxColumn.Width = 125;
            // 
            // frenchDataGridViewTextBoxColumn
            // 
            this.frenchDataGridViewTextBoxColumn.DataPropertyName = "French";
            this.frenchDataGridViewTextBoxColumn.HeaderText = "French";
            this.frenchDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.frenchDataGridViewTextBoxColumn.Name = "frenchDataGridViewTextBoxColumn";
            this.frenchDataGridViewTextBoxColumn.Width = 125;
            // 
            // languageBindingSource
            // 
            this.languageBindingSource.DataMember = "Language";
            this.languageBindingSource.DataSource = this.appData;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(459, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // appData1
            // 
            this.appData1.DataSetName = "AppData";
            this.appData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Location = new System.Drawing.Point(238, 240);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(180, 120);
            this.dataLayoutControl1.TabIndex = 11;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(180, 120);
            this.Root.TextVisible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(171, 366);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource languageBindingSource;
        private AppData appData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn türkçeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource languageBindingSource1;
        private System.Windows.Forms.BindingSource appDataBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn englishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn germanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frenchDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private AppData appData1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}

