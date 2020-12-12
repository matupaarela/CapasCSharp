
namespace Presentation.Forms.Maintenance
{
    partial class UCEmployee
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnNew = new System.Windows.Forms.ToolStripButton();
            this.BtnSave = new System.Windows.Forms.ToolStripButton();
            this.BtnDestroy = new System.Windows.Forms.ToolStripButton();
            this.lbl1 = new System.Windows.Forms.ToolStripLabel();
            this.TBFilter = new System.Windows.Forms.ToolStripTextBox();
            this.PnlControls = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBStateInactive = new System.Windows.Forms.RadioButton();
            this.RBStateActive = new System.Windows.Forms.RadioButton();
            this.CboPosition = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TBLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LKCancel = new System.Windows.Forms.LinkLabel();
            this.DTPBirthay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVEmployee = new System.Windows.Forms.DataGridView();
            this.EmployeeUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeePosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeePositionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeEState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.PnlControls.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNew,
            this.BtnSave,
            this.BtnDestroy,
            this.lbl1,
            this.TBFilter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(663, 25);
            this.toolStrip1.TabIndex = 8;
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
            // PnlControls
            // 
            this.PnlControls.Controls.Add(this.groupBox1);
            this.PnlControls.Controls.Add(this.CboPosition);
            this.PnlControls.Controls.Add(this.label7);
            this.PnlControls.Controls.Add(this.TBLastName);
            this.PnlControls.Controls.Add(this.label6);
            this.PnlControls.Controls.Add(this.TBUsername);
            this.PnlControls.Controls.Add(this.label5);
            this.PnlControls.Controls.Add(this.LKCancel);
            this.PnlControls.Controls.Add(this.DTPBirthay);
            this.PnlControls.Controls.Add(this.label4);
            this.PnlControls.Controls.Add(this.TBEmail);
            this.PnlControls.Controls.Add(this.label3);
            this.PnlControls.Controls.Add(this.TBFirstName);
            this.PnlControls.Controls.Add(this.label2);
            this.PnlControls.Controls.Add(this.TBDni);
            this.PnlControls.Controls.Add(this.label1);
            this.PnlControls.Location = new System.Drawing.Point(0, 28);
            this.PnlControls.Name = "PnlControls";
            this.PnlControls.Size = new System.Drawing.Size(200, 368);
            this.PnlControls.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBStateInactive);
            this.groupBox1.Controls.Add(this.RBStateActive);
            this.groupBox1.Location = new System.Drawing.Point(15, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 48);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // RBStateInactive
            // 
            this.RBStateInactive.AutoSize = true;
            this.RBStateInactive.Location = new System.Drawing.Point(67, 19);
            this.RBStateInactive.Name = "RBStateInactive";
            this.RBStateInactive.Size = new System.Drawing.Size(63, 17);
            this.RBStateInactive.TabIndex = 10;
            this.RBStateInactive.TabStop = true;
            this.RBStateInactive.Text = "Inactivo";
            this.RBStateInactive.UseVisualStyleBackColor = true;
            // 
            // RBStateActive
            // 
            this.RBStateActive.AutoSize = true;
            this.RBStateActive.Location = new System.Drawing.Point(6, 19);
            this.RBStateActive.Name = "RBStateActive";
            this.RBStateActive.Size = new System.Drawing.Size(55, 17);
            this.RBStateActive.TabIndex = 9;
            this.RBStateActive.TabStop = true;
            this.RBStateActive.Text = "Activo";
            this.RBStateActive.UseVisualStyleBackColor = true;
            // 
            // CboPosition
            // 
            this.CboPosition.FormattingEnabled = true;
            this.CboPosition.Location = new System.Drawing.Point(15, 267);
            this.CboPosition.Name = "CboPosition";
            this.CboPosition.Size = new System.Drawing.Size(168, 21);
            this.CboPosition.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cargo";
            // 
            // TBLastName
            // 
            this.TBLastName.Location = new System.Drawing.Point(14, 150);
            this.TBLastName.Name = "TBLastName";
            this.TBLastName.Size = new System.Drawing.Size(169, 20);
            this.TBLastName.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Apellidos";
            // 
            // TBUsername
            // 
            this.TBUsername.Location = new System.Drawing.Point(14, 34);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.ReadOnly = true;
            this.TBUsername.Size = new System.Drawing.Size(169, 20);
            this.TBUsername.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Usuario";
            // 
            // LKCancel
            // 
            this.LKCancel.AutoSize = true;
            this.LKCancel.Location = new System.Drawing.Point(134, 18);
            this.LKCancel.Name = "LKCancel";
            this.LKCancel.Size = new System.Drawing.Size(49, 13);
            this.LKCancel.TabIndex = 14;
            this.LKCancel.TabStop = true;
            this.LKCancel.Text = "Cancelar";
            this.LKCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LKCancel_LinkClicked);
            // 
            // DTPBirthay
            // 
            this.DTPBirthay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPBirthay.Location = new System.Drawing.Point(15, 228);
            this.DTPBirthay.Name = "DTPBirthay";
            this.DTPBirthay.Size = new System.Drawing.Size(168, 20);
            this.DTPBirthay.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(14, 188);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(169, 20);
            this.TBEmail.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Correo";
            // 
            // TBFirstName
            // 
            this.TBFirstName.Location = new System.Drawing.Point(14, 112);
            this.TBFirstName.Name = "TBFirstName";
            this.TBFirstName.Size = new System.Drawing.Size(169, 20);
            this.TBFirstName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // TBDni
            // 
            this.TBDni.Location = new System.Drawing.Point(14, 73);
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(169, 20);
            this.TBDni.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DNI";
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
            this.EmployeeUsername,
            this.EmployeeDni,
            this.EmployeeFirstName,
            this.EmployeeLastName,
            this.EmployeeEmail,
            this.EmployeeBirthday,
            this.EmployeePosition,
            this.EmployeePositionCode,
            this.EmployeeState,
            this.EmployeeEState,
            this.EmployeeAge});
            this.DGVEmployee.Location = new System.Drawing.Point(206, 28);
            this.DGVEmployee.Name = "DGVEmployee";
            this.DGVEmployee.ReadOnly = true;
            this.DGVEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVEmployee.Size = new System.Drawing.Size(457, 368);
            this.DGVEmployee.TabIndex = 6;
            this.DGVEmployee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVEmployee_CellDoubleClick);
            // 
            // EmployeeUsername
            // 
            this.EmployeeUsername.DataPropertyName = "Username";
            this.EmployeeUsername.HeaderText = "Usuario";
            this.EmployeeUsername.Name = "EmployeeUsername";
            this.EmployeeUsername.ReadOnly = true;
            // 
            // EmployeeDni
            // 
            this.EmployeeDni.DataPropertyName = "Dni";
            this.EmployeeDni.HeaderText = "DNI";
            this.EmployeeDni.Name = "EmployeeDni";
            this.EmployeeDni.ReadOnly = true;
            // 
            // EmployeeFirstName
            // 
            this.EmployeeFirstName.DataPropertyName = "FirstName";
            this.EmployeeFirstName.HeaderText = "Nombre";
            this.EmployeeFirstName.Name = "EmployeeFirstName";
            this.EmployeeFirstName.ReadOnly = true;
            this.EmployeeFirstName.Width = 200;
            // 
            // EmployeeLastName
            // 
            this.EmployeeLastName.DataPropertyName = "LastName";
            this.EmployeeLastName.HeaderText = "Apellidos";
            this.EmployeeLastName.Name = "EmployeeLastName";
            this.EmployeeLastName.ReadOnly = true;
            // 
            // EmployeeEmail
            // 
            this.EmployeeEmail.DataPropertyName = "Email";
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
            // EmployeePosition
            // 
            this.EmployeePosition.DataPropertyName = "Position";
            this.EmployeePosition.HeaderText = "Cargo";
            this.EmployeePosition.Name = "EmployeePosition";
            this.EmployeePosition.ReadOnly = true;
            // 
            // EmployeePositionCode
            // 
            this.EmployeePositionCode.DataPropertyName = "PositionCode";
            this.EmployeePositionCode.HeaderText = "Cargo Codigo";
            this.EmployeePositionCode.Name = "EmployeePositionCode";
            this.EmployeePositionCode.ReadOnly = true;
            this.EmployeePositionCode.Visible = false;
            // 
            // EmployeeState
            // 
            this.EmployeeState.DataPropertyName = "State";
            this.EmployeeState.HeaderText = "Estado";
            this.EmployeeState.Name = "EmployeeState";
            this.EmployeeState.ReadOnly = true;
            // 
            // EmployeeEState
            // 
            this.EmployeeEState.DataPropertyName = "EState";
            this.EmployeeEState.HeaderText = "EState";
            this.EmployeeEState.Name = "EmployeeEState";
            this.EmployeeEState.ReadOnly = true;
            this.EmployeeEState.Visible = false;
            // 
            // EmployeeAge
            // 
            this.EmployeeAge.DataPropertyName = "Age";
            this.EmployeeAge.HeaderText = "Edad";
            this.EmployeeAge.Name = "EmployeeAge";
            this.EmployeeAge.ReadOnly = true;
            this.EmployeeAge.Width = 60;
            // 
            // UCEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.PnlControls);
            this.Controls.Add(this.DGVEmployee);
            this.Name = "UCEmployee";
            this.Size = new System.Drawing.Size(663, 396);
            this.Load += new System.EventHandler(this.UCEmployee_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.PnlControls.ResumeLayout(false);
            this.PnlControls.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnNew;
        private System.Windows.Forms.ToolStripButton BtnSave;
        private System.Windows.Forms.ToolStripButton BtnDestroy;
        private System.Windows.Forms.ToolStripLabel lbl1;
        private System.Windows.Forms.ToolStripTextBox TBFilter;
        private System.Windows.Forms.Panel PnlControls;
        private System.Windows.Forms.LinkLabel LKCancel;
        private System.Windows.Forms.DateTimePicker DTPBirthay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVEmployee;
        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboPosition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBStateInactive;
        private System.Windows.Forms.RadioButton RBStateActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeePosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeePositionCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeState;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeEState;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeAge;
    }
}
