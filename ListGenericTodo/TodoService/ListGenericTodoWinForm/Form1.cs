using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoService;

namespace ListGenericTodoWinForm
{
    public partial class Form1 : Form
    {
        Form F;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region for timer 
            timer_.Interval = 10000; // timer will work everyr 10 seconds
            timer_.Tick += Timer__Tick;
            timer_.Start();
            #endregion

            #region for Buttons enabled 
            ButtonEnable(false);
            #endregion

            UserLogin.UserLogin usercontrol = new UserLogin.UserLogin();
            usercontrol.MdiParent = this;
            usercontrol.Show(); // before this we should close buttons 

            
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            lbl_timer.Text = DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss");
        }
        #region Button enabled  , private method we did
        private void ButtonEnable(bool control)
        {
            foreach (Control item in grpB_proceslist.Controls)
            {
                if (item is Button)
                {
                    ((Button)item).Enabled = false;
                }
            }
        }
        #endregion

        private void btn_closeapp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_newreg_Click(object sender, EventArgs e)
        {
            // if there is already open form , we should show 
            if (Application.OpenForms["NewRegistration"] != null)
            {
                F = Application.OpenForms["NewRegistration"];
                F.Focus();
            }
            else
            {
                F = new NewRegistration();
                F.MdiParent = this;
                F.Show();
            }
        }

        private void btn_listreg_Click(object sender, EventArgs e)
        {
            Todoservice todoservice = new Todoservice();
            if(todoservice.RegistrationControl() > 0)
            {
                RegistrationList registrationList = new RegistrationList();
                registrationList.MdiParent = this;
                registrationList.Show();
                this.Close();
            }
            else
                MessageBox.Show("No registration found to list","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
