using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserLibrary;
using UserServiceBll;

namespace UserLogin
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.LightYellow;
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.White;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // for clean code , we write like that
            string username = txt_username.Text;
            string password = txt_pass.Text;

            if (username != null && password != null)
            {
                // add reference , userservice , todo and user
                UserServicebll userservicebll = new UserServicebll();
                User userControl = userservicebll.UserControl(username, password);
                if (userControl != null)
                {
                    // if everything is okay , we will change buttons enable to true
                    Form mainForm = Application.OpenForms["Form1"];
                    Panel leftPanel = (Panel)mainForm.Controls["pnl_operations"];
                    GroupBox grpBox = (GroupBox)leftPanel.Controls["grpB_proceslist"];
                    foreach (Control item in grpBox.Controls)
                    {
                        if (item is Button)
                        {
                            item.Enabled = true;
                        }
                    }
                    MessageBox.Show($"Hello {userControl.UserName}");
                    this.Close();
                }
                else
                    MessageBox.Show("Wrong username or password", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Please enter your login information completely.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
