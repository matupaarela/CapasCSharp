using Presentation.Forms.Maintenance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms.Maintenance
{
    public partial class FormMaintenance : Form
    {
        UCEmployee uCEmployee;
        private FormMaintenance()
        {
            InitializeComponent();
        }
        private static FormMaintenance Instancia = null;

        public static FormMaintenance GetForm()
        {
            if (Instancia == null)
            {
                Instancia = new FormMaintenance();
                Instancia.FormClosed += new FormClosedEventHandler(Reset);
            }
            return Instancia;
        }

        private static void Reset(object sender, FormClosedEventArgs e) { Instancia = null; }
        private void FormMaintenance_Load(object sender, EventArgs e)
        {
            uCEmployee = new UCEmployee();
            uCEmployee.Dock = DockStyle.Fill;
            TPEmployee.Controls.Add(uCEmployee);
        }
    }
}
