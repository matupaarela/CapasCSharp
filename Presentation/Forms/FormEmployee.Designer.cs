namespace Presentation.Forms
{
    partial class FormEmployee
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
            this.DGVEmployee = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlControls = new System.Windows.Forms.Panel();
            this.DTPBirthay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBNumber = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnNew = new System.Windows.Forms.ToolStripButton();
            this.BtnSave = new System.Windows.Forms.ToolStripButton();
            this.BtnDestroy = new System.Windows.Forms.ToolStripButton();
            this.lbl1 = new System.Windows.Forms.ToolStripLabel();
            this.TBFilter = new System.Windows.Forms.ToolStripTextBox();
            this.LKCancel = new System.Windows.Forms.LinkLabel();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployee)).BeginInit();
            this.PnlControls.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVEmployee
            // 
            this.DGVEmployee.AllowUserToAddRows = false;
            this.DGVEmployee.AllowUserToDeleteRows = false;
            this.DGVEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.EmployeeNumber,
            this.EmployeeName,
            this.EmployeeEmail,
            this.EmployeeBirthday,
            this.EmployeeAge});
            this.DGVEmployee.Location = new System.Drawing.Point(206, 28);
            this.DGVEmployee.Name = "DGVEmployee";
            this.DGVEmployee.ReadOnly = true;
            this.DGVEmployee.Size = new System.Drawing.Size(503, 203);
            this.DGVEmployee.TabIndex = 0;
            this.DGVEmployee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVEmployee_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DNI";
            // 
            // PnlControls
            // 
            this.PnlControls.Controls.Add(this.LKCancel);
            this.PnlControls.Controls.Add(this.DTPBirthay);
            this.PnlControls.Controls.Add(this.label4);
            this.PnlControls.Controls.Add(this.TBEmail);
            this.PnlControls.Controls.Add(this.label3);
            this.PnlControls.Controls.Add(this.TBName);
            this.PnlControls.Controls.Add(this.label2);
            this.PnlControls.Controls.Add(this.TBNumber);
            this.PnlControls.Controls.Add(this.label1);
            this.PnlControls.Location = new System.Drawing.Point(0, 28);
            this.PnlControls.Name = "PnlControls";
            this.PnlControls.Size = new System.Drawing.Size(200, 203);
            this.PnlControls.TabIndex = 4;
            // 
            // DTPBirthay
            // 
            this.DTPBirthay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPBirthay.Location = new System.Drawing.Point(15, 144);
            this.DTPBirthay.Name = "DTPBirthay";
            this.DTPBirthay.Size = new System.Drawing.Size(169, 20);
            this.DTPBirthay.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(14, 104);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(169, 20);
            this.TBEmail.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Correo";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(14, 65);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(169, 20);
            this.TBName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // TBNumber
            // 
            this.TBNumber.Location = new System.Drawing.Point(14, 26);
            this.TBNumber.Name = "TBNumber";
            this.TBNumber.Size = new System.Drawing.Size(169, 20);
            this.TBNumber.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNew,
            this.BtnSave,
            this.BtnDestroy,
            this.lbl1,
            this.TBFilter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(709, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnNew
            // 
            this.BtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnNew.Image = global::Presentation.Properties.Resources.add_file;
            this.BtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(23, 22);
            this.BtnNew.Text = "Nuevo";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSave.Image = global::Presentation.Properties.Resources.save;
            this.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(23, 22);
            this.BtnSave.Text = "Guardar";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDestroy
            // 
            this.BtnDestroy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDestroy.Image = global::Presentation.Properties.Resources.delete;
            this.BtnDestroy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDestroy.Name = "BtnDestroy";
            this.BtnDestroy.Size = new System.Drawing.Size(23, 22);
            this.BtnDestroy.Text = "Eliminar";
            this.BtnDestroy.Click += new System.EventHandler(this.BtnDestroy_Click);
            // 
            // lbl1
            // 
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(119, 22);
            this.lbl1.Text = "Buscar (por nombre):";
            // 
            // TBFilter
            // 
            this.TBFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBFilter.Name = "TBFilter";
            this.TBFilter.Size = new System.Drawing.Size(200, 25);
            this.TBFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBFilter_KeyUp);
            // 
            // LKCancel
            // 
            this.LKCancel.AutoSize = true;
            this.LKCancel.Location = new System.Drawing.Point(12, 179);
            this.LKCancel.Name = "LKCancel";
            this.LKCancel.Size = new System.Drawing.Size(49, 13);
            this.LKCancel.TabIndex = 14;
            this.LKCancel.TabStop = true;
            this.LKCancel.Text = "Cancelar";
            this.LKCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LKCancel_LinkClicked);
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "ID";
            this.EmployeeID.HeaderText = "ID";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            this.EmployeeID.Visible = false;
            // 
            // EmployeeNumber
            // 
            this.EmployeeNumber.DataPropertyName = "Number";
            this.EmployeeNumber.HeaderText = "Número";
            this.EmployeeNumber.Name = "EmployeeNumber";
            this.EmployeeNumber.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "Name";
            this.EmployeeName.HeaderText = "Nombre";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            this.EmployeeName.Width = 200;
            // 
            // EmployeeEmail
            // 
            this.EmployeeEmail.DataPropertyName = "EMail";
            this.EmployeeEmail.HeaderText = "Correo";
            this.EmployeeEmail.Name = "EmployeeEmail";
            this.EmployeeEmail.ReadOnly = true;
            // 
            // EmployeeBirthday
            // 
            this.EmployeeBirthday.DataPropertyName = "Birthday";
            this.EmployeeBirthday.HeaderText = "F. de Nacimiento";
            this.EmployeeBirthday.Name = "EmployeeBirthday";
            this.EmployeeBirthday.ReadOnly = true;
            // 
            // EmployeeAge
            // 
            this.EmployeeAge.DataPropertyName = "Age";
            this.EmployeeAge.HeaderText = "Edad";
            this.EmployeeAge.Name = "EmployeeAge";
            this.EmployeeAge.ReadOnly = true;
            this.EmployeeAge.Width = 60;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 235);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.PnlControls);
            this.Controls.Add(this.DGVEmployee);
            this.Name = "FormEmployee";
            this.Text = "FormEmployee";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployee)).EndInit();
            this.PnlControls.ResumeLayout(false);
            this.PnlControls.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlControls;
        private System.Windows.Forms.DateTimePicker DTPBirthay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBNumber;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnNew;
        private System.Windows.Forms.ToolStripButton BtnSave;
        private System.Windows.Forms.ToolStripButton BtnDestroy;
        private System.Windows.Forms.ToolStripLabel lbl1;
        private System.Windows.Forms.ToolStripTextBox TBFilter;
        private System.Windows.Forms.LinkLabel LKCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeAge;
    }
}