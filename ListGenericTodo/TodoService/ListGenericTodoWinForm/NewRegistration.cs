using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoLibrary;
using TodoService;

namespace ListGenericTodoWinForm
{

    public partial class NewRegistration : Form
    {
        Form F;
        public NewRegistration()
        {
            InitializeComponent();
        }

        private void txt_title_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.Yellow;
        }

        private void txt_title_Leave(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.White;
        }

        private void cmb_situation_Enter(object sender, EventArgs e)
        {
            ComboBox CB = (ComboBox)sender;
            CB.BackColor = Color.Yellow;
        }

        private void cmb_situation_Leave(object sender, EventArgs e)
        {
            ComboBox CB = (ComboBox)sender;
            CB.BackColor = Color.White;
        }

        private void btn_newwReg_Click(object sender, EventArgs e)
        {
            Todoservice todoservice = new Todoservice();
            int result = todoservice.NewRegistration(new Todo()
            {
                ID = Guid.NewGuid(),
                Title = txt_title.Text,
                Briefdescription = txt_briefdesc.Text,
                Description = txt_descr.Text,
                StatusDescripton = cmb_situation.SelectedItem.ToString(),
                Importance = int.Parse(txt_importance.Text),
                Creationdate = DateTime.Now
            });
            if (result > 0)
            {
                MessageBox.Show("Successfully adding registration", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult dialogResult = MessageBox.Show("Would you like to continue adding a new registration?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (Control item in this.Controls)
                    {
                        if (item is TextBox)
                        {
                            ((TextBox)item).Text = string.Empty;
                        }
                    }
                }
                else
                {
                    F = Application.OpenForms["RegistrationList"];
                    if (F == null)
                    {
                        F = new RegistrationList();
                        F.MdiParent = Application.OpenForms["Form1"];
                        F.Show();
                        this.Close();
                    }
                    else
                    {
                        GroupBox List = (GroupBox)F.Controls["grp_list"];
                        DataGridView DrvList = (DataGridView)List.Controls["datagrid_list"];
                        List<Todo> CurrentList = todoservice.RegistrationList();
                        DrvList.DataSource = null;
                        DrvList.DataSource = CurrentList;
                        this.Close();

                    }
                }
            }
            else
                MessageBox.Show("Error occur to new registration operation", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
