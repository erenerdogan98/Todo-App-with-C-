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
    public partial class RegistrationList : Form
    {
        Todoservice todoservice; // we sample this in initializecomponent by new
        public RegistrationList()
        {
            InitializeComponent();
            todoservice = new Todoservice();
        }

        private void RegistrationList_Load(object sender, EventArgs e)
        {
            grid_list.DataSource = AllList();
            grid_list.Columns["ID"].Visible = false;
        }
        private List<Todo> AllList()
        {
            return todoservice.RegistrationList();
        }

        private void btn_Alllist_Click(object sender, EventArgs e)
        {
            grid_list.DataSource = AllList();
            grid_list.Columns["ID"].Visible = false;
        }

        private void btn_completed_Click(object sender, EventArgs e)
        {
            grid_list.DataSource = AllList().Where(x => x.StatusDescripton == "Completed").ToList();
            grid_list.Columns["ID"].Visible = false;
        }

        private void btn_uncompleted_Click(object sender, EventArgs e)
        {
            grid_list.DataSource = AllList().Where(x => x.StatusDescripton == "Uncompleted").ToList();
            grid_list.Columns["ID"].Visible = false;
        }

        private void btn_Canceled_Click(object sender, EventArgs e)
        {
            grid_list.DataSource = AllList().Where(x => x.StatusDescripton == "Canceled").ToList();
            grid_list.Columns["ID"].Visible = false;
        }

        private void btn_waiting_Click(object sender, EventArgs e)
        {
            grid_list.DataSource = AllList().Where(x => x.StatusDescripton == "Waiting").ToList();
            grid_list.Columns["ID"].Visible = false;
        }
    }
}
