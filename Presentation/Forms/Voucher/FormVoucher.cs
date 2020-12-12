using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms.Voucher
{
    public partial class FormVoucher : Form
    {
        private FormVoucher()
        {
            InitializeComponent();
        }
        private static FormVoucher Instancia = null;

        public static FormVoucher GetForm()
        {
            if (Instancia == null)
            {
                Instancia = new FormVoucher();
                Instancia.FormClosed += new FormClosedEventHandler(Reset);
            }
            return Instancia;
        }

        private static void Reset(object sender, FormClosedEventArgs e) { Instancia = null; }
        private void FormVoucher_Load(object sender, EventArgs e)
        {

        }
    }
}
