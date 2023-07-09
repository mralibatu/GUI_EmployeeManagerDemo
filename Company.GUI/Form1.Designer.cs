namespace Company.GUI
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
            this.dgwEmployee = new System.Windows.Forms.DataGridView();
            this.gbxSeach = new System.Windows.Forms.GroupBox();
            this.tbxSearchLastName = new System.Windows.Forms.TextBox();
            this.lblSearchLastName = new System.Windows.Forms.Label();
            this.tbxSearchFirstName = new System.Windows.Forms.TextBox();
            this.lblSearchFirstName = new System.Windows.Forms.Label();
            this.gbxSeachWorkPosition = new System.Windows.Forms.GroupBox();
            this.lblWorkPosition = new System.Windows.Forms.Label();
            this.cbxWorkPositions = new System.Windows.Forms.ComboBox();
            this.gbxAddEmployee = new System.Windows.Forms.GroupBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.cbxAddEmployeeGender = new System.Windows.Forms.ComboBox();
            this.cbxAddEmployeeWorkPosition = new System.Windows.Forms.ComboBox();
            this.tbxAddEmployeeLastName = new System.Windows.Forms.TextBox();
            this.tbxAddEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.lblAddEmployeeGender = new System.Windows.Forms.Label();
            this.lblAddEmployeeWorkPosition = new System.Windows.Forms.Label();
            this.lblAddEmployeeLastName = new System.Windows.Forms.Label();
            this.lblAddEmployeeFirstName = new System.Windows.Forms.Label();
            this.gbxUpdateEmployee = new System.Windows.Forms.GroupBox();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.cbxUpdateEmployeeWorkPosition = new System.Windows.Forms.ComboBox();
            this.tbxUpdateEmployeeLastName = new System.Windows.Forms.TextBox();
            this.tbxUpdateEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.lblUpdateEmployeeWorkPosition = new System.Windows.Forms.Label();
            this.lblUpdateEmployeeLastName = new System.Windows.Forms.Label();
            this.lblUpdateEmployeeFirstName = new System.Windows.Forms.Label();
            this.gbxDeleteEmployee = new System.Windows.Forms.GroupBox();
            this.tbxDeleteEmployeeLastName = new System.Windows.Forms.TextBox();
            this.tbxDeleteEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.lblDeleteEmployeeLasttName = new System.Windows.Forms.Label();
            this.lblDeleteEmployeeFirstName = new System.Windows.Forms.Label();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployee)).BeginInit();
            this.gbxSeach.SuspendLayout();
            this.gbxSeachWorkPosition.SuspendLayout();
            this.gbxAddEmployee.SuspendLayout();
            this.gbxUpdateEmployee.SuspendLayout();
            this.gbxDeleteEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwEmployee
            // 
            this.dgwEmployee.AllowUserToAddRows = false;
            this.dgwEmployee.AllowUserToDeleteRows = false;
            this.dgwEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEmployee.Location = new System.Drawing.Point(12, 102);
            this.dgwEmployee.Name = "dgwEmployee";
            this.dgwEmployee.ReadOnly = true;
            this.dgwEmployee.Size = new System.Drawing.Size(1077, 323);
            this.dgwEmployee.TabIndex = 0;
            // 
            // gbxSeach
            // 
            this.gbxSeach.Controls.Add(this.tbxSearchLastName);
            this.gbxSeach.Controls.Add(this.lblSearchLastName);
            this.gbxSeach.Controls.Add(this.tbxSearchFirstName);
            this.gbxSeach.Controls.Add(this.lblSearchFirstName);
            this.gbxSeach.Location = new System.Drawing.Point(33, 12);
            this.gbxSeach.Name = "gbxSeach";
            this.gbxSeach.Size = new System.Drawing.Size(508, 66);
            this.gbxSeach.TabIndex = 1;
            this.gbxSeach.TabStop = false;
            this.gbxSeach.Text = "Search";
            // 
            // tbxSearchLastName
            // 
            this.tbxSearchLastName.Location = new System.Drawing.Point(327, 29);
            this.tbxSearchLastName.Name = "tbxSearchLastName";
            this.tbxSearchLastName.Size = new System.Drawing.Size(162, 20);
            this.tbxSearchLastName.TabIndex = 3;
            this.tbxSearchLastName.TextChanged += new System.EventHandler(this.tbxSearchLastName_TextChanged);
            // 
            // lblSearchLastName
            // 
            this.lblSearchLastName.AutoSize = true;
            this.lblSearchLastName.Location = new System.Drawing.Point(258, 32);
            this.lblSearchLastName.Name = "lblSearchLastName";
            this.lblSearchLastName.Size = new System.Drawing.Size(64, 13);
            this.lblSearchLastName.TabIndex = 2;
            this.lblSearchLastName.Text = "Last Name :";
            // 
            // tbxSearchFirstName
            // 
            this.tbxSearchFirstName.Location = new System.Drawing.Point(80, 29);
            this.tbxSearchFirstName.Name = "tbxSearchFirstName";
            this.tbxSearchFirstName.Size = new System.Drawing.Size(162, 20);
            this.tbxSearchFirstName.TabIndex = 1;
            this.tbxSearchFirstName.TextChanged += new System.EventHandler(this.tbxSearchFirstName_TextChanged);
            // 
            // lblSearchFirstName
            // 
            this.lblSearchFirstName.AutoSize = true;
            this.lblSearchFirstName.Location = new System.Drawing.Point(11, 32);
            this.lblSearchFirstName.Name = "lblSearchFirstName";
            this.lblSearchFirstName.Size = new System.Drawing.Size(63, 13);
            this.lblSearchFirstName.TabIndex = 0;
            this.lblSearchFirstName.Text = "First Name :";
            // 
            // gbxSeachWorkPosition
            // 
            this.gbxSeachWorkPosition.Controls.Add(this.lblWorkPosition);
            this.gbxSeachWorkPosition.Controls.Add(this.cbxWorkPositions);
            this.gbxSeachWorkPosition.Location = new System.Drawing.Point(547, 12);
            this.gbxSeachWorkPosition.Name = "gbxSeachWorkPosition";
            this.gbxSeachWorkPosition.Size = new System.Drawing.Size(524, 66);
            this.gbxSeachWorkPosition.TabIndex = 2;
            this.gbxSeachWorkPosition.TabStop = false;
            this.gbxSeachWorkPosition.Text = "Search by Work Position";
            // 
            // lblWorkPosition
            // 
            this.lblWorkPosition.AutoSize = true;
            this.lblWorkPosition.Location = new System.Drawing.Point(52, 32);
            this.lblWorkPosition.Name = "lblWorkPosition";
            this.lblWorkPosition.Size = new System.Drawing.Size(79, 13);
            this.lblWorkPosition.TabIndex = 1;
            this.lblWorkPosition.Text = "Work Position :";
            // 
            // cbxWorkPositions
            // 
            this.cbxWorkPositions.FormattingEnabled = true;
            this.cbxWorkPositions.Location = new System.Drawing.Point(137, 29);
            this.cbxWorkPositions.Name = "cbxWorkPositions";
            this.cbxWorkPositions.Size = new System.Drawing.Size(214, 21);
            this.cbxWorkPositions.TabIndex = 0;
            this.cbxWorkPositions.SelectedIndexChanged += new System.EventHandler(this.cbxWorkPositions_SelectedIndexChanged);
            // 
            // gbxAddEmployee
            // 
            this.gbxAddEmployee.Controls.Add(this.btnAddEmployee);
            this.gbxAddEmployee.Controls.Add(this.cbxAddEmployeeGender);
            this.gbxAddEmployee.Controls.Add(this.cbxAddEmployeeWorkPosition);
            this.gbxAddEmployee.Controls.Add(this.tbxAddEmployeeLastName);
            this.gbxAddEmployee.Controls.Add(this.tbxAddEmployeeFirstName);
            this.gbxAddEmployee.Controls.Add(this.lblAddEmployeeGender);
            this.gbxAddEmployee.Controls.Add(this.lblAddEmployeeWorkPosition);
            this.gbxAddEmployee.Controls.Add(this.lblAddEmployeeLastName);
            this.gbxAddEmployee.Controls.Add(this.lblAddEmployeeFirstName);
            this.gbxAddEmployee.Location = new System.Drawing.Point(12, 446);
            this.gbxAddEmployee.Name = "gbxAddEmployee";
            this.gbxAddEmployee.Size = new System.Drawing.Size(263, 194);
            this.gbxAddEmployee.TabIndex = 3;
            this.gbxAddEmployee.TabStop = false;
            this.gbxAddEmployee.Text = "Add Employee";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(177, 160);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnAddEmployee.TabIndex = 8;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // cbxAddEmployeeGender
            // 
            this.cbxAddEmployeeGender.FormattingEnabled = true;
            this.cbxAddEmployeeGender.Location = new System.Drawing.Point(88, 121);
            this.cbxAddEmployeeGender.Name = "cbxAddEmployeeGender";
            this.cbxAddEmployeeGender.Size = new System.Drawing.Size(148, 21);
            this.cbxAddEmployeeGender.TabIndex = 7;
            // 
            // cbxAddEmployeeWorkPosition
            // 
            this.cbxAddEmployeeWorkPosition.FormattingEnabled = true;
            this.cbxAddEmployeeWorkPosition.Location = new System.Drawing.Point(88, 94);
            this.cbxAddEmployeeWorkPosition.Name = "cbxAddEmployeeWorkPosition";
            this.cbxAddEmployeeWorkPosition.Size = new System.Drawing.Size(148, 21);
            this.cbxAddEmployeeWorkPosition.TabIndex = 6;
            // 
            // tbxAddEmployeeLastName
            // 
            this.tbxAddEmployeeLastName.Location = new System.Drawing.Point(88, 67);
            this.tbxAddEmployeeLastName.Name = "tbxAddEmployeeLastName";
            this.tbxAddEmployeeLastName.Size = new System.Drawing.Size(148, 20);
            this.tbxAddEmployeeLastName.TabIndex = 5;
            // 
            // tbxAddEmployeeFirstName
            // 
            this.tbxAddEmployeeFirstName.Location = new System.Drawing.Point(88, 38);
            this.tbxAddEmployeeFirstName.Name = "tbxAddEmployeeFirstName";
            this.tbxAddEmployeeFirstName.Size = new System.Drawing.Size(148, 20);
            this.tbxAddEmployeeFirstName.TabIndex = 4;
            // 
            // lblAddEmployeeGender
            // 
            this.lblAddEmployeeGender.AutoSize = true;
            this.lblAddEmployeeGender.Location = new System.Drawing.Point(34, 124);
            this.lblAddEmployeeGender.Name = "lblAddEmployeeGender";
            this.lblAddEmployeeGender.Size = new System.Drawing.Size(48, 13);
            this.lblAddEmployeeGender.TabIndex = 3;
            this.lblAddEmployeeGender.Text = "Gender :";
            // 
            // lblAddEmployeeWorkPosition
            // 
            this.lblAddEmployeeWorkPosition.AutoSize = true;
            this.lblAddEmployeeWorkPosition.Location = new System.Drawing.Point(3, 97);
            this.lblAddEmployeeWorkPosition.Name = "lblAddEmployeeWorkPosition";
            this.lblAddEmployeeWorkPosition.Size = new System.Drawing.Size(79, 13);
            this.lblAddEmployeeWorkPosition.TabIndex = 2;
            this.lblAddEmployeeWorkPosition.Text = "Work Position :";
            // 
            // lblAddEmployeeLastName
            // 
            this.lblAddEmployeeLastName.AutoSize = true;
            this.lblAddEmployeeLastName.Location = new System.Drawing.Point(18, 70);
            this.lblAddEmployeeLastName.Name = "lblAddEmployeeLastName";
            this.lblAddEmployeeLastName.Size = new System.Drawing.Size(64, 13);
            this.lblAddEmployeeLastName.TabIndex = 1;
            this.lblAddEmployeeLastName.Text = "Last Name :";
            // 
            // lblAddEmployeeFirstName
            // 
            this.lblAddEmployeeFirstName.AutoSize = true;
            this.lblAddEmployeeFirstName.Location = new System.Drawing.Point(19, 41);
            this.lblAddEmployeeFirstName.Name = "lblAddEmployeeFirstName";
            this.lblAddEmployeeFirstName.Size = new System.Drawing.Size(63, 13);
            this.lblAddEmployeeFirstName.TabIndex = 0;
            this.lblAddEmployeeFirstName.Text = "First Name :";
            // 
            // gbxUpdateEmployee
            // 
            this.gbxUpdateEmployee.Controls.Add(this.btnUpdateEmployee);
            this.gbxUpdateEmployee.Controls.Add(this.cbxUpdateEmployeeWorkPosition);
            this.gbxUpdateEmployee.Controls.Add(this.tbxUpdateEmployeeLastName);
            this.gbxUpdateEmployee.Controls.Add(this.tbxUpdateEmployeeFirstName);
            this.gbxUpdateEmployee.Controls.Add(this.lblUpdateEmployeeWorkPosition);
            this.gbxUpdateEmployee.Controls.Add(this.lblUpdateEmployeeLastName);
            this.gbxUpdateEmployee.Controls.Add(this.lblUpdateEmployeeFirstName);
            this.gbxUpdateEmployee.Location = new System.Drawing.Point(305, 446);
            this.gbxUpdateEmployee.Name = "gbxUpdateEmployee";
            this.gbxUpdateEmployee.Size = new System.Drawing.Size(263, 155);
            this.gbxUpdateEmployee.TabIndex = 4;
            this.gbxUpdateEmployee.TabStop = false;
            this.gbxUpdateEmployee.Text = "Update Employee";
            this.gbxUpdateEmployee.Enter += new System.EventHandler(this.gbxUpdateEmployee_Enter);
            this.gbxUpdateEmployee.Leave += new System.EventHandler(this.gbxUpdateEmployee_Leave);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(182, 124);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateEmployee.TabIndex = 8;
            this.btnUpdateEmployee.Text = "Update";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // cbxUpdateEmployeeWorkPosition
            // 
            this.cbxUpdateEmployeeWorkPosition.FormattingEnabled = true;
            this.cbxUpdateEmployeeWorkPosition.Location = new System.Drawing.Point(88, 94);
            this.cbxUpdateEmployeeWorkPosition.Name = "cbxUpdateEmployeeWorkPosition";
            this.cbxUpdateEmployeeWorkPosition.Size = new System.Drawing.Size(148, 21);
            this.cbxUpdateEmployeeWorkPosition.TabIndex = 6;
            // 
            // tbxUpdateEmployeeLastName
            // 
            this.tbxUpdateEmployeeLastName.Location = new System.Drawing.Point(88, 67);
            this.tbxUpdateEmployeeLastName.Name = "tbxUpdateEmployeeLastName";
            this.tbxUpdateEmployeeLastName.Size = new System.Drawing.Size(148, 20);
            this.tbxUpdateEmployeeLastName.TabIndex = 5;
            // 
            // tbxUpdateEmployeeFirstName
            // 
            this.tbxUpdateEmployeeFirstName.Location = new System.Drawing.Point(88, 38);
            this.tbxUpdateEmployeeFirstName.Name = "tbxUpdateEmployeeFirstName";
            this.tbxUpdateEmployeeFirstName.Size = new System.Drawing.Size(148, 20);
            this.tbxUpdateEmployeeFirstName.TabIndex = 4;
            // 
            // lblUpdateEmployeeWorkPosition
            // 
            this.lblUpdateEmployeeWorkPosition.AutoSize = true;
            this.lblUpdateEmployeeWorkPosition.Location = new System.Drawing.Point(3, 97);
            this.lblUpdateEmployeeWorkPosition.Name = "lblUpdateEmployeeWorkPosition";
            this.lblUpdateEmployeeWorkPosition.Size = new System.Drawing.Size(79, 13);
            this.lblUpdateEmployeeWorkPosition.TabIndex = 2;
            this.lblUpdateEmployeeWorkPosition.Text = "Work Position :";
            // 
            // lblUpdateEmployeeLastName
            // 
            this.lblUpdateEmployeeLastName.AutoSize = true;
            this.lblUpdateEmployeeLastName.Location = new System.Drawing.Point(18, 70);
            this.lblUpdateEmployeeLastName.Name = "lblUpdateEmployeeLastName";
            this.lblUpdateEmployeeLastName.Size = new System.Drawing.Size(64, 13);
            this.lblUpdateEmployeeLastName.TabIndex = 1;
            this.lblUpdateEmployeeLastName.Text = "Last Name :";
            // 
            // lblUpdateEmployeeFirstName
            // 
            this.lblUpdateEmployeeFirstName.AutoSize = true;
            this.lblUpdateEmployeeFirstName.Location = new System.Drawing.Point(19, 41);
            this.lblUpdateEmployeeFirstName.Name = "lblUpdateEmployeeFirstName";
            this.lblUpdateEmployeeFirstName.Size = new System.Drawing.Size(63, 13);
            this.lblUpdateEmployeeFirstName.TabIndex = 0;
            this.lblUpdateEmployeeFirstName.Text = "First Name :";
            // 
            // gbxDeleteEmployee
            // 
            this.gbxDeleteEmployee.Controls.Add(this.btnDeleteEmployee);
            this.gbxDeleteEmployee.Controls.Add(this.tbxDeleteEmployeeLastName);
            this.gbxDeleteEmployee.Controls.Add(this.tbxDeleteEmployeeFirstName);
            this.gbxDeleteEmployee.Controls.Add(this.lblDeleteEmployeeLasttName);
            this.gbxDeleteEmployee.Controls.Add(this.lblDeleteEmployeeFirstName);
            this.gbxDeleteEmployee.Location = new System.Drawing.Point(305, 607);
            this.gbxDeleteEmployee.Name = "gbxDeleteEmployee";
            this.gbxDeleteEmployee.Size = new System.Drawing.Size(263, 128);
            this.gbxDeleteEmployee.TabIndex = 9;
            this.gbxDeleteEmployee.TabStop = false;
            this.gbxDeleteEmployee.Text = "Delete Employee";
            this.gbxDeleteEmployee.Enter += new System.EventHandler(this.gbxDeleteEmployee_Enter);
            this.gbxDeleteEmployee.Leave += new System.EventHandler(this.gbxDeleteEmployee_Leave);
            // 
            // tbxDeleteEmployeeLastName
            // 
            this.tbxDeleteEmployeeLastName.Location = new System.Drawing.Point(88, 67);
            this.tbxDeleteEmployeeLastName.Name = "tbxDeleteEmployeeLastName";
            this.tbxDeleteEmployeeLastName.ReadOnly = true;
            this.tbxDeleteEmployeeLastName.Size = new System.Drawing.Size(148, 20);
            this.tbxDeleteEmployeeLastName.TabIndex = 5;
            // 
            // tbxDeleteEmployeeFirstName
            // 
            this.tbxDeleteEmployeeFirstName.Location = new System.Drawing.Point(88, 38);
            this.tbxDeleteEmployeeFirstName.Name = "tbxDeleteEmployeeFirstName";
            this.tbxDeleteEmployeeFirstName.ReadOnly = true;
            this.tbxDeleteEmployeeFirstName.Size = new System.Drawing.Size(148, 20);
            this.tbxDeleteEmployeeFirstName.TabIndex = 4;
            // 
            // lblDeleteEmployeeLasttName
            // 
            this.lblDeleteEmployeeLasttName.AutoSize = true;
            this.lblDeleteEmployeeLasttName.Location = new System.Drawing.Point(18, 70);
            this.lblDeleteEmployeeLasttName.Name = "lblDeleteEmployeeLasttName";
            this.lblDeleteEmployeeLasttName.Size = new System.Drawing.Size(64, 13);
            this.lblDeleteEmployeeLasttName.TabIndex = 1;
            this.lblDeleteEmployeeLasttName.Text = "Last Name :";
            // 
            // lblDeleteEmployeeFirstName
            // 
            this.lblDeleteEmployeeFirstName.AutoSize = true;
            this.lblDeleteEmployeeFirstName.Location = new System.Drawing.Point(19, 41);
            this.lblDeleteEmployeeFirstName.Name = "lblDeleteEmployeeFirstName";
            this.lblDeleteEmployeeFirstName.Size = new System.Drawing.Size(63, 13);
            this.lblDeleteEmployeeFirstName.TabIndex = 0;
            this.lblDeleteEmployeeFirstName.Text = "First Name :";
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(182, 99);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEmployee.TabIndex = 9;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 774);
            this.Controls.Add(this.gbxDeleteEmployee);
            this.Controls.Add(this.gbxUpdateEmployee);
            this.Controls.Add(this.gbxAddEmployee);
            this.Controls.Add(this.gbxSeachWorkPosition);
            this.Controls.Add(this.gbxSeach);
            this.Controls.Add(this.dgwEmployee);
            this.Name = "Form1";
            this.Text = "Employee Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployee)).EndInit();
            this.gbxSeach.ResumeLayout(false);
            this.gbxSeach.PerformLayout();
            this.gbxSeachWorkPosition.ResumeLayout(false);
            this.gbxSeachWorkPosition.PerformLayout();
            this.gbxAddEmployee.ResumeLayout(false);
            this.gbxAddEmployee.PerformLayout();
            this.gbxUpdateEmployee.ResumeLayout(false);
            this.gbxUpdateEmployee.PerformLayout();
            this.gbxDeleteEmployee.ResumeLayout(false);
            this.gbxDeleteEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwEmployee;
        private System.Windows.Forms.GroupBox gbxSeach;
        private System.Windows.Forms.GroupBox gbxSeachWorkPosition;
        private System.Windows.Forms.Label lblSearchFirstName;
        private System.Windows.Forms.TextBox tbxSearchFirstName;
        private System.Windows.Forms.ComboBox cbxWorkPositions;
        private System.Windows.Forms.Label lblWorkPosition;
        private System.Windows.Forms.TextBox tbxSearchLastName;
        private System.Windows.Forms.Label lblSearchLastName;
        private System.Windows.Forms.GroupBox gbxAddEmployee;
        private System.Windows.Forms.Label lblAddEmployeeWorkPosition;
        private System.Windows.Forms.Label lblAddEmployeeLastName;
        private System.Windows.Forms.Label lblAddEmployeeFirstName;
        private System.Windows.Forms.Label lblAddEmployeeGender;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ComboBox cbxAddEmployeeGender;
        private System.Windows.Forms.ComboBox cbxAddEmployeeWorkPosition;
        private System.Windows.Forms.TextBox tbxAddEmployeeLastName;
        private System.Windows.Forms.TextBox tbxAddEmployeeFirstName;
        private System.Windows.Forms.GroupBox gbxUpdateEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.ComboBox cbxUpdateEmployeeWorkPosition;
        private System.Windows.Forms.TextBox tbxUpdateEmployeeLastName;
        private System.Windows.Forms.TextBox tbxUpdateEmployeeFirstName;
        private System.Windows.Forms.Label lblUpdateEmployeeWorkPosition;
        private System.Windows.Forms.Label lblUpdateEmployeeLastName;
        private System.Windows.Forms.Label lblUpdateEmployeeFirstName;
        private System.Windows.Forms.GroupBox gbxDeleteEmployee;
        private System.Windows.Forms.TextBox tbxDeleteEmployeeLastName;
        private System.Windows.Forms.TextBox tbxDeleteEmployeeFirstName;
        private System.Windows.Forms.Label lblDeleteEmployeeLasttName;
        private System.Windows.Forms.Label lblDeleteEmployeeFirstName;
        private System.Windows.Forms.Button btnDeleteEmployee;
    }
}

