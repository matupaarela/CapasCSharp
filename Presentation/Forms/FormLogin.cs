using Common.Helpers;
using Domain.Models;
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
    public partial class FormLogin : Form
    {
        EmployeeModel employeeModel = new EmployeeModel();
        public FormLogin()
        {
            InitializeComponent();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void Msg(string msg)
        {
            LblErrorMesssage.Text = msg;
            LblErrorMesssage.Visible = true;
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
            
        }
        private void Login()
        {
            try
            {
                if (TBUsername.Text != "")
                {
                    if (TBPassword.Text != "")
                    {
                        if (employeeModel.Login(TBUsername.Text, Helpers.SHA1(TBPassword.Text)))
                        {
                            FormMain Frm = new FormMain();
                            Frm.Show();
                            Hide();
                        }
                        else
                        {
                            Msg("Usuario y/o contraseña incorrecta. \npor favor vuelve a intentarlo.");
                            
                        }
                    }
                    else
                    {
                        Msg("Ingresa tu contraseña!");
                        TBPassword.Focus();
                    }
                }
                else
                {
                    Msg("Ingresa tu Usuario");
                    TBUsername.Focus();
                }
            }
            catch (Exception er)
            {
                PBLog.Save(this, er);
            }
        }
        private void TBUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) Login();
        }

        private void TBPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) Login();
        }

    }
}
