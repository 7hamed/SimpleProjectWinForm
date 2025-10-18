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

        private void btnPizza_Click(object sender, EventArgs e)
        {
            if (PizzaForm == null || PizzaForm.Disposing)
            {
                PizzaForm = new frmPizza();
            }

            PizzaForm.Show();
        }

        private void btnXOgame_Click(object sender, EventArgs e)
        {
            if (XOgameForm == null || XOgameForm.Disposing)
            {
                XOgameForm = new frmXOgame();
            }

            XOgameForm.Show();
        }

        private void btnToDoList_Click(object sender, EventArgs e)
        {
            if (ToDoListForm == null || ToDoListForm.Disposing)
            {
                ToDoListForm = new frmToDoList();
            }

            ToDoListForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SimpleFileExplorerForm == null || SimpleFileExplorerForm.Disposing)
            {
                SimpleFileExplorerForm = new frmSimpleFileExplorer();
            }

            SimpleFileExplorerForm.Show();

        }

        private void btnSimpleSiteVisit_Click(object sender, EventArgs e)
        {
            if (SimpleSiteVisitForm == null || SimpleSiteVisitForm.Disposing)
            {
                SimpleSiteVisitForm = new frmSimpleSiteVisit();
            }

            SimpleSiteVisitForm.Show();
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            if (PickColorForm == null || PickColorForm.Disposing)
            {
                PickColorForm = new frmPickColor();
            }

            PickColorForm.Show();
        }
    }
}
