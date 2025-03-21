namespace TaskForLogs
{
    partial class Employees
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
            this.gridEmployees = new System.Windows.Forms.DataGridView();
            this.grBxEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.btnCv = new System.Windows.Forms.Button();
            this.btnUploadİmag = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.richJobDetails = new System.Windows.Forms.RichTextBox();
            this.checkFemail = new System.Windows.Forms.CheckBox();
            this.checkMale = new System.Windows.Forms.CheckBox();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).BeginInit();
            this.grBxEmployeeDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridEmployees
            // 
            this.gridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmployees.Location = new System.Drawing.Point(12, 26);
            this.gridEmployees.Name = "gridEmployees";
            this.gridEmployees.Size = new System.Drawing.Size(474, 402);
            this.gridEmployees.TabIndex = 0;
            // 
            // grBxEmployeeDetails
            // 
            this.grBxEmployeeDetails.Controls.Add(this.btnCv);
            this.grBxEmployeeDetails.Controls.Add(this.btnUploadİmag);
            this.grBxEmployeeDetails.Controls.Add(this.btnDelete);
            this.grBxEmployeeDetails.Controls.Add(this.btnSave);
            this.grBxEmployeeDetails.Controls.Add(this.richJobDetails);
            this.grBxEmployeeDetails.Controls.Add(this.checkFemail);
            this.grBxEmployeeDetails.Controls.Add(this.checkMale);
            this.grBxEmployeeDetails.Controls.Add(this.dtDOB);
            this.grBxEmployeeDetails.Controls.Add(this.txtSurname);
            this.grBxEmployeeDetails.Controls.Add(this.txtName);
            this.grBxEmployeeDetails.Controls.Add(this.label5);
            this.grBxEmployeeDetails.Controls.Add(this.label4);
            this.grBxEmployeeDetails.Controls.Add(this.label3);
            this.grBxEmployeeDetails.Controls.Add(this.label2);
            this.grBxEmployeeDetails.Controls.Add(this.label1);
            this.grBxEmployeeDetails.Location = new System.Drawing.Point(503, 26);
            this.grBxEmployeeDetails.Name = "grBxEmployeeDetails";
            this.grBxEmployeeDetails.Size = new System.Drawing.Size(285, 402);
            this.grBxEmployeeDetails.TabIndex = 1;
            this.grBxEmployeeDetails.TabStop = false;
            this.grBxEmployeeDetails.Text = "Employee Details";
            // 
            // btnCv
            // 
            this.btnCv.Location = new System.Drawing.Point(74, 176);
            this.btnCv.Name = "btnCv";
            this.btnCv.Size = new System.Drawing.Size(173, 23);
            this.btnCv.TabIndex = 6;
            this.btnCv.Text = "Upload CV";
            this.btnCv.UseVisualStyleBackColor = true;
            this.btnCv.Click += new System.EventHandler(this.btnCv_Click);
            // 
            // btnUploadİmag
            // 
            this.btnUploadİmag.Location = new System.Drawing.Point(74, 147);
            this.btnUploadİmag.Name = "btnUploadİmag";
            this.btnUploadİmag.Size = new System.Drawing.Size(173, 23);
            this.btnUploadİmag.TabIndex = 6;
            this.btnUploadİmag.Text = "Upload  İmage";
            this.btnUploadİmag.UseVisualStyleBackColor = true;
            this.btnUploadİmag.Click += new System.EventHandler(this.btnUploadİmag_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(171, 338);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 42);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(70, 338);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 42);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // richJobDetails
            // 
            this.richJobDetails.Location = new System.Drawing.Point(72, 217);
            this.richJobDetails.Name = "richJobDetails";
            this.richJobDetails.Size = new System.Drawing.Size(175, 82);
            this.richJobDetails.TabIndex = 4;
            this.richJobDetails.Text = "";
            // 
            // checkFemail
            // 
            this.checkFemail.AutoSize = true;
            this.checkFemail.Location = new System.Drawing.Point(131, 123);
            this.checkFemail.Name = "checkFemail";
            this.checkFemail.Size = new System.Drawing.Size(56, 17);
            this.checkFemail.TabIndex = 3;
            this.checkFemail.Text = "Femail";
            this.checkFemail.UseVisualStyleBackColor = true;
            // 
            // checkMale
            // 
            this.checkMale.AutoSize = true;
            this.checkMale.Location = new System.Drawing.Point(74, 123);
            this.checkMale.Name = "checkMale";
            this.checkMale.Size = new System.Drawing.Size(51, 17);
            this.checkMale.TabIndex = 3;
            this.checkMale.Text = "Maile";
            this.checkMale.UseVisualStyleBackColor = true;
            // 
            // dtDOB
            // 
            this.dtDOB.Location = new System.Drawing.Point(74, 95);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(173, 20);
            this.dtDOB.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(74, 62);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(173, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(74, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 20);
            this.txtName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Job Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "DOB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grBxEmployeeDetails);
            this.Controls.Add(this.gridEmployees);
            this.Name = "Employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).EndInit();
            this.grBxEmployeeDetails.ResumeLayout(false);
            this.grBxEmployeeDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEmployees;
        private System.Windows.Forms.GroupBox grBxEmployeeDetails;
        private System.Windows.Forms.Button btnCv;
        private System.Windows.Forms.Button btnUploadİmag;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox richJobDetails;
        private System.Windows.Forms.CheckBox checkFemail;
        private System.Windows.Forms.CheckBox checkMale;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}