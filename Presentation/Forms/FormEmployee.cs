using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Models;
using Domain.ValueObjects;

namespace Presentation.Forms
{
    public partial class FormEmployee : Form
    {
        private EmployeeModel employeeModel = new EmployeeModel();
        public FormEmployee()
        {
            InitializeComponent();
            PnlControls.Enabled = false;
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            ListEmployees();
        }

        private void ListEmployees()
        {
            try
            {
                DGVEmployee.DataSource = employeeModel.All();
            } catch(Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            employeeModel.number = TBNumber.Text;
            employeeModel.name = TBName.Text;
            employeeModel.email = TBEmail.Text;
            employeeModel.birthday = Convert.ToDateTime(DTPBirthay.Value);

            bool Valid = new Helps.DataValidation(employeeModel).Validate();
            if (Valid)
            {
                string Msg = employeeModel.SaveChanges();
                MessageBox.Show(Msg);
                ListEmployees();
                Clear();
            }
        }

        private void Clear()
        {
            PnlControls.Enabled = false;
            TBNumber.Clear();
            TBName.Clear();
            TBEmail.Clear();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            PnlControls.Enabled = true;
            employeeModel.State = EntityState.Added;
        }

        private void Edit()
        {
            if (DGVEmployee.SelectedRows.Count > 0)
            {
                PnlControls.Enabled = true;
                employeeModel.State = EntityState.Modified;
                employeeModel.id = Convert.ToInt32(DGVEmployee.CurrentRow.Cells[0].Value);
                TBNumber.Text = DGVEmployee.CurrentRow.Cells[1].Value.ToString();
                TBName.Text = DGVEmployee.CurrentRow.Cells[2].Value.ToString();
                TBEmail.Text = DGVEmployee.CurrentRow.Cells[3].Value.ToString();
                DTPBirthay.Value = Convert.ToDateTime(DGVEmployee.CurrentRow.Cells[4].Value);
            }
            else MessageBox.Show("Seleccione una fila");
        }

        private void BtnDestroy_Click(object sender, EventArgs e)
        {
            if (DGVEmployee.SelectedRows.Count > 0)
            {
                employeeModel.State = EntityState.Deleted;
                employeeModel.id = Convert.ToInt32(DGVEmployee.CurrentRow.Cells[0].Value);
                string Msg = employeeModel.SaveChanges();
                MessageBox.Show(Msg);
                ListEmployees();
            }
            else MessageBox.Show("Seleccione una fila");
        }

        private void TBFilter_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DGVEmployee.DataSource = employeeModel.Filter(TBFilter.Text);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void DGVEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit();
        }

        private void LKCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PnlControls.Enabled = false;
            employeeModel.State = EntityState.Added;
        }
    }
}
