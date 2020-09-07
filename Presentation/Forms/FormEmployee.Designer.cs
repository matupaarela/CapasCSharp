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
            this.BtnDestroy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBFilter = new System.Windows.Forms.TextBox();
            this.PnlControls = new System.Windows.Forms.Panel();
            this.TBNumber = new System.Windows.Forms.TextBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TBName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DTPBirthay = new System.Windows.Forms.DateTimePicker();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployee)).BeginInit();
            this.PnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVEmployee
            // 
            this.DGVEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEmployee.Location = new System.Drawing.Point(12, 38);
            this.DGVEmployee.Name = "DGVEmployee";
            this.DGVEmployee.Size = new System.Drawing.Size(479, 177);
            this.DGVEmployee.TabIndex = 0;
            // 
            // BtnDestroy
            // 
            this.BtnDestroy.Location = new System.Drawing.Point(256, 231);
            this.BtnDestroy.Name = "BtnDestroy";
            this.BtnDestroy.Size = new System.Drawing.Size(75, 23);
            this.BtnDestroy.TabIndex = 7;
            this.BtnDestroy.Text = "Eliminar";
            this.BtnDestroy.UseVisualStyleBackColor = true;
            this.BtnDestroy.Click += new System.EventHandler(this.BtnDestroy_Click);
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
            // TBFilter
            // 
            this.TBFilter.Location = new System.Drawing.Point(12, 12);
            this.TBFilter.Name = "TBFilter";
            this.TBFilter.Size = new System.Drawing.Size(382, 20);
            this.TBFilter.TabIndex = 1;
            this.TBFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBFilter_KeyDown);
            // 
            // PnlControls
            // 
            this.PnlControls.Controls.Add(this.DTPBirthay);
            this.PnlControls.Controls.Add(this.label4);
            this.PnlControls.Controls.Add(this.TBEmail);
            this.PnlControls.Controls.Add(this.label3);
            this.PnlControls.Controls.Add(this.TBName);
            this.PnlControls.Controls.Add(this.label2);
            this.PnlControls.Controls.Add(this.BtnSave);
            this.PnlControls.Controls.Add(this.TBNumber);
            this.PnlControls.Controls.Add(this.label1);
            this.PnlControls.Location = new System.Drawing.Point(497, 12);
            this.PnlControls.Name = "PnlControls";
            this.PnlControls.Size = new System.Drawing.Size(200, 203);
            this.PnlControls.TabIndex = 4;
            // 
            // TBNumber
            // 
            this.TBNumber.Location = new System.Drawing.Point(14, 26);
            this.TBNumber.Name = "TBNumber";
            this.TBNumber.Size = new System.Drawing.Size(169, 20);
            this.TBNumber.TabIndex = 3;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(337, 231);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 8;
            this.BtnEdit.Text = "Editar";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(416, 231);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 9;
            this.BtnNew.Text = "Nuevo";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(14, 169);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(169, 23);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // DTPBirthay
            // 
            this.DTPBirthay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPBirthay.Location = new System.Drawing.Point(14, 143);
            this.DTPBirthay.Name = "DTPBirthay";
            this.DTPBirthay.Size = new System.Drawing.Size(169, 20);
            this.DTPBirthay.TabIndex = 5;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(400, 10);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(91, 23);
            this.BtnSearch.TabIndex = 8;
            this.BtnSearch.Text = "Buscar";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(762, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Inserciones Masivas: https://www.youtube.com/watch?v=fne9TMDlLN4&list=PLqjdFmR_Hd" +
    "QTHZN6FYll8PCQy37QZ2-Xq&index=3&ab_channel=RJCodeAdvance";
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 330);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.PnlControls);
            this.Controls.Add(this.BtnDestroy);
            this.Controls.Add(this.TBFilter);
            this.Controls.Add(this.DGVEmployee);
            this.Name = "FormEmployee";
            this.Text = "FormEmployee";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployee)).EndInit();
            this.PnlControls.ResumeLayout(false);
            this.PnlControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVEmployee;
        private System.Windows.Forms.Button BtnDestroy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBFilter;
        private System.Windows.Forms.Panel PnlControls;
        private System.Windows.Forms.DateTimePicker DTPBirthay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TBNumber;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label5;
    }
}