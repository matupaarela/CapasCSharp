using Common.Helpers;
using Domain.Models;
using Domain.ValueObjects;
using System;
using System.Windows.Forms;

namespace Presentation.Forms.Maintenance
{
    public partial class UCEmployee : UserControl
    {
        private EmployeeModel employeeModel = new EmployeeModel();
        private PositionModel positionModel = new PositionModel();
        public UCEmployee()
        {
            InitializeComponent();
        }

        private void UCEmployee_Load(object sender, EventArgs e)
        {
            Clear();
            All();
            FillCombos();
        }

        private void FillCombos()
        {
            CboPosition.DisplayMember = "Name";
            CboPosition.ValueMember = "Code";
            CboPosition.DataSource = positionModel.All();
        }

        private void All()
        {
            try
            {
                DGVEmployee.DataSource = employeeModel.All();
            }
            catch (Exception Ex)
            {
                PBLog.Save(this, Ex);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string RBState = "Inactivo";
            if (RBStateActive.Checked) RBState = "Activo";
            employeeModel.Username = TBDni.Text;
            employeeModel.Dni = TBDni.Text;
            employeeModel.FirstName = TBFirstName.Text;
            employeeModel.LastName = TBLastName.Text;
            employeeModel.Email = TBEmail.Text;
            employeeModel.Birthday = Convert.ToDateTime(DTPBirthay.Value);
            employeeModel.State = RBState;
            employeeModel.PositionCode = Convert.ToString(CboPosition.SelectedValue);

            bool Valid = new Helps.DataValidation(employeeModel).Validate();
            if (Valid)
            {
                string Msg = employeeModel.SaveChanges();
                MessageBox.Show(Msg);
                All();
                Clear();
            }
        }

        private void Clear()
        {
            employeeModel.EState = EntityState.Added;
            PnlControls.Enabled = false;
            TBDni.Clear();
            TBFirstName.Clear();
            TBEmail.Clear();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Clear();
            PnlControls.Enabled = true;
        }

        private void Edit()
        {
            if (DGVEmployee.SelectedRows.Count > 0)
            {
                PnlControls.Enabled = true;
                employeeModel.EState = EntityState.Modified;

                employeeModel.Username = Convert.ToString(DGVEmployee.CurrentRow.Cells["EmployeeUsername"].Value);

                TBUsername.Text = DGVEmployee.CurrentRow.Cells["EmployeeUsername"].Value.ToString();
                TBDni.Text = DGVEmployee.CurrentRow.Cells["EmployeeDni"].Value.ToString();
                TBFirstName.Text = DGVEmployee.CurrentRow.Cells["EmployeeFirstName"].Value.ToString();
                TBLastName.Text = DGVEmployee.CurrentRow.Cells["EmployeeLastName"].Value.ToString();
                TBEmail.Text = DGVEmployee.CurrentRow.Cells["EmployeeLastName"].Value.ToString();
                DTPBirthay.Value = Convert.ToDateTime(DGVEmployee.CurrentRow.Cells["EmployeeBirthday"].Value);
                if (DGVEmployee.CurrentRow.Cells["EmployeeState"].Value.Equals("Activo")) RBStateActive.Checked = true;
                else if (DGVEmployee.CurrentRow.Cells["EmployeeState"].Value.Equals("Inactivo")) RBStateInactive.Checked = true;
                CboPosition.SelectedValue = Convert.ToString(DGVEmployee.CurrentRow.Cells["EmployeePositionCode"].Value);
            }
            else MessageBox.Show("Seleccione una fila");
        }

        private void BtnDestroy_Click(object sender, EventArgs e)
        {
            if (DGVEmployee.SelectedRows.Count > 0)
            {
                employeeModel.EState = EntityState.Deleted;
                employeeModel.Username = Convert.ToString(DGVEmployee.CurrentRow.Cells["EmployeeUsername"].Value);
                string Msg = employeeModel.SaveChanges();
                MessageBox.Show(Msg);
                All();
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
                PBLog.Save(this, Ex);
            }
        }

        private void DGVEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit();
        }

        private void LKCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear();
        }
    }
}
