namespace MyEmployee
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
            this.emplnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empmiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.empfnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emplnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empfnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empmiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.cCEMPLOYEEDataSet = new MyEmployee.CCEMPLOYEEDataSet();
            this.employeeTableAdapter = new MyEmployee.CCEMPLOYEEDataSetTableAdapters.EmployeeTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCEMPLOYEEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // emplnameDataGridViewTextBoxColumn
            // 
            this.emplnameDataGridViewTextBoxColumn.DataPropertyName = "emp_lname";
            this.emplnameDataGridViewTextBoxColumn.HeaderText = "emp_lname";
            this.emplnameDataGridViewTextBoxColumn.Name = "emplnameDataGridViewTextBoxColumn";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(270, 367);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 46);
            this.button4.TabIndex = 31;
            this.button4.Text = ">";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(161, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 46);
            this.button3.TabIndex = 32;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "emp_id";
            this.empidDataGridViewTextBoxColumn.HeaderText = "emp_id";
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            // 
            // empmiDataGridViewTextBoxColumn
            // 
            this.empmiDataGridViewTextBoxColumn.DataPropertyName = "emp_mi";
            this.empmiDataGridViewTextBoxColumn.HeaderText = "emp_mi";
            this.empmiDataGridViewTextBoxColumn.Name = "empmiDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(575, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 41);
            this.button2.TabIndex = 29;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(375, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 41);
            this.button1.TabIndex = 30;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // empfnameDataGridViewTextBoxColumn
            // 
            this.empfnameDataGridViewTextBoxColumn.DataPropertyName = "emp_fname";
            this.empfnameDataGridViewTextBoxColumn.HeaderText = "emp_fname";
            this.empfnameDataGridViewTextBoxColumn.Name = "empfnameDataGridViewTextBoxColumn";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(95, 257);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(195, 34);
            this.textBox3.TabIndex = 27;
            this.textBox3.Text = "First Name";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(95, 199);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(195, 34);
            this.textBox2.TabIndex = 28;
            this.textBox2.Text = "Last Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(118, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 26);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "Employee ID #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(181, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 49);
            this.label1.TabIndex = 24;
            this.label1.Text = "Find an Employee";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(354, 257);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(195, 34);
            this.textBox4.TabIndex = 26;
            this.textBox4.Text = "Middle Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emplnameDataGridViewTextBoxColumn1,
            this.empfnameDataGridViewTextBoxColumn1,
            this.empmiDataGridViewTextBoxColumn1,
            this.empidDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.employeeBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(496, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(10, 10);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.Visible = false;
            // 
            // emplnameDataGridViewTextBoxColumn1
            // 
            this.emplnameDataGridViewTextBoxColumn1.DataPropertyName = "emp_lname";
            this.emplnameDataGridViewTextBoxColumn1.HeaderText = "emp_lname";
            this.emplnameDataGridViewTextBoxColumn1.Name = "emplnameDataGridViewTextBoxColumn1";
            // 
            // empfnameDataGridViewTextBoxColumn1
            // 
            this.empfnameDataGridViewTextBoxColumn1.DataPropertyName = "emp_fname";
            this.empfnameDataGridViewTextBoxColumn1.HeaderText = "emp_fname";
            this.empfnameDataGridViewTextBoxColumn1.Name = "empfnameDataGridViewTextBoxColumn1";
            // 
            // empmiDataGridViewTextBoxColumn1
            // 
            this.empmiDataGridViewTextBoxColumn1.DataPropertyName = "emp_mi";
            this.empmiDataGridViewTextBoxColumn1.HeaderText = "emp_mi";
            this.empmiDataGridViewTextBoxColumn1.Name = "empmiDataGridViewTextBoxColumn1";
            // 
            // empidDataGridViewTextBoxColumn1
            // 
            this.empidDataGridViewTextBoxColumn1.DataPropertyName = "emp_id";
            this.empidDataGridViewTextBoxColumn1.HeaderText = "emp_id";
            this.empidDataGridViewTextBoxColumn1.Name = "empidDataGridViewTextBoxColumn1";
            // 
            // employeeBindingSource3
            // 
            this.employeeBindingSource3.DataMember = "Employee";
            this.employeeBindingSource3.DataSource = this.cCEMPLOYEEDataSet;
            // 
            // cCEMPLOYEEDataSet
            // 
            this.cCEMPLOYEEDataSet.DataSetName = "CCEMPLOYEEDataSet";
            this.cCEMPLOYEEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCEMPLOYEEDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn emplnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empmiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empfnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CCEMPLOYEEDataSet cCEMPLOYEEDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource3;
        private CCEMPLOYEEDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn emplnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empfnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empmiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Timer timer1;
    }
}

