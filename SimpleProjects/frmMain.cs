using _3_PizzaProject;
using _4_testForms;
using _5_TicTacToe_Game;
using _6_ToDoList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleProjects
{
    public partial class frmMain : Form
    {
        Form PizzaForm;
        Form XOgameForm;
        Form ToDoListForm;
        Form SimpleFileExplorerForm;

        Form SimpleSiteVisitForm;
        Form PickColorForm;

        public frmMain()
        {
            InitializeComponent();
        }

        private void justOneFormObject<T>(ref Form form) where T : Form, new()
        {
            if (form == null || form.IsDisposed)
            {
                form = new T();
            }
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            justOneFormObject<frmPizza>(ref PizzaForm);

            PizzaForm.Show();
        }

        private void btnXOgame_Click(object sender, EventArgs e)
        {
            justOneFormObject<frmXOgame>(ref XOgameForm);

            XOgameForm.Show();
        }

        private void btnToDoList_Click(object sender, EventArgs e)
        {
            justOneFormObject<frmToDoList>(ref ToDoListForm);

            ToDoListForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            justOneFormObject<frmSimpleFileExplorer>(ref SimpleFileExplorerForm);

            SimpleFileExplorerForm.Show();

        }

        private void btnSimpleSiteVisit_Click(object sender, EventArgs e)
        {
            justOneFormObject<frmSimpleSiteVisit>(ref SimpleSiteVisitForm);

            SimpleSiteVisitForm.Show();
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            justOneFormObject<frmPickColor>(ref PickColorForm);

            PickColorForm.Show();
        }
    }
}
