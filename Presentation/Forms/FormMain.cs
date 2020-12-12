using Common.Cache.Session;
using Presentation.Forms.Maintenance;
using Presentation.Forms.Voucher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Authorized();
        }
        private void Authorized()
        {
            switch (UserCache.PositionCode)
            {
                case Positions.Accounting:
                    MenuItemManager.Visible = false;
                    break;
                case Positions.Manager:
                    MenuItemManager.Visible = true;
                    break;
                case Positions.Admin:
                    break;
            }
        }
        private void ShowForm(Form Frm)
        {
            Cursor.Current = Cursors.WaitCursor;
            Frm.MdiParent = this;
            Frm.WindowState = FormWindowState.Maximized;
            Frm.BringToFront();
            Frm.Show();
            Cursor.Current = Cursors.Default;
        }
        //private void MenuItemChecked(ToolStripMenuItem item)
        //{
        //    if (item.CheckOnClick)
        //    {
        //        item.ForeColor = Color.Red;
        //        item.BackColor = Color.AliceBlue;
        //    }
        //}

        private void MaunMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripMenuItem item in ((ToolStrip)sender).Items)
            {
                if (item != e.ClickedItem)
                {
                    item.Checked = false;
                    //item.ForeColor = Color.Gray;
                    item.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                }
                else
                {
                    item.Checked = true;
                    item.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    //item.ForeColor = Color.Black;
                }
            }
        }

        private void MenuItemMaintenance_Click(object sender, EventArgs e)
        {
            FormMaintenance Frm = FormMaintenance.GetForm();
            ShowForm(Frm);
        }

        private void MenuItemVoucher_Click(object sender, EventArgs e)
        {
            FormVoucher Frm = FormVoucher.GetForm();
            ShowForm(Frm);
        }
    }
}
