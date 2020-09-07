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
        private EmployeeModel employee = new EmployeeModel();
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
                DGVEmployee.DataSource = employee.All();
            } catch(Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void TBFilter_KeyDown(object sender, KeyEventArgs e)
        {
            DGVEmployee.DataSource = employee.Filter(TBFilter.Text);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //DGVEmployee.DataSource = employee.FindByNumber(TBFilter.Text);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            employee.number = TBNumber.Text;
            employee.name = TBName.Text;
            employee.email = TBEmail.Text;
            employee.birthday = Convert.ToDateTime(DTPBirthay.Value);

            bool Valid = new Helps.DataValidation(employee).Validate();
            if (Valid)
            {
                string Msg = employee.SaveChanges();
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
            employee.State = EntityState.Added;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (DGVEmployee.SelectedRows.Count > 0)
            {
                PnlControls.Enabled = true;
                employee.State = EntityState.Modified;
                employee.id = Convert.ToInt32(DGVEmployee.CurrentRow.Cells[0].Value);
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
                employee.State = EntityState.Deleted;
                employee.id = Convert.ToInt32(DGVEmployee.CurrentRow.Cells[0].Value);
                string Msg = employee.SaveChanges();
                MessageBox.Show(Msg);
                ListEmployees();
            }
            else MessageBox.Show("Seleccione una fila");
        }
    }
}
