using SimpleProjects.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _5_TicTacToe_Game
{
    public partial class frmXOgame : Form
    {

        private ePlayerTurn CurrentTurn = ePlayerTurn.Player1;
        private stGameStatus gamestatus;

        enum ePlayerTurn { Player1 = 1, Player2 = 2 };
        enum eWinner { Player1 = 1, Player2 = 2, Draw = 3, InProgress = 4 };

        struct stGameStatus
        {
            public eWinner Winner;
            public int PlayCount;
            public bool GameOver;
        };

        public frmXOgame()
        {
            InitializeComponent();
        }

        private void ResetButton(Button btn)
        {
            btn.Tag = "?";
            btn.Image = Resources.question_mark_96;
            btn.BackColor = Color.Transparent;
        }

        private void ResetGame()
        {
            ResetButton(button1);
            ResetButton(button2);
            ResetButton(button3);
            ResetButton(button4);
            ResetButton(button5);
            ResetButton(button6);
            ResetButton(button7);
            ResetButton(button8);
            ResetButton(button9);

            CurrentTurn = ePlayerTurn.Player1;
            lblTurnPlayer.Text = "Player 1";
            gamestatus.Winner = eWinner.InProgress;
            lblWinner.Text = "In Progress";
            gamestatus.PlayCount = 0;
            gamestatus.GameOver = false;
        }

        private bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                lblTurnPlayer.Text = "Game Over";
                gamestatus.GameOver = true;

                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                if (btn1.Tag.ToString() == "X")
                {
                    gamestatus.Winner = eWinner.Player1;
                    lblWinner.Text = "Player 1";

                    return true;
                }
                else
                {
                    gamestatus.Winner = eWinner.Player2;
                    lblWinner.Text = "Player 2";

                    return true;
                }

            }

            return false;
        }

        private void CheckWinner()
        {
            //checked rows
            //check Row1
            if (CheckValues(button1, button2, button3))
                return;

            //check Row2
            if (CheckValues(button4, button5, button6))
                return;

            //check Row3
            if (CheckValues(button7, button8, button9))
                return;

            //checked cols
            //check col1
            if (CheckValues(button1, button4, button7))
                return;

            //check col2
            if (CheckValues(button2, button5, button8))
                return;

            //check col3
            if (CheckValues(button3, button6, button9))
                return;

            //check Diagonal

            //check Diagonal1
            if (CheckValues(button1, button5, button9))
                return;

            //check Diagonal2
            if (CheckValues(button3, button5, button7))
                return;

        }

        private void PerformSelection(Button btn)
        {
            if (gamestatus.GameOver)
            {
                MessageBox.Show("game over");
                return;
            }



            if (btn.Tag.ToString() == "?")
            {
                if (CurrentTurn == ePlayerTurn.Player1)
                {
                    btn.Image = Resources.X;
                    btn.Tag = "X";
                    gamestatus.PlayCount++;

                    CurrentTurn = ePlayerTurn.Player2;
                    lblTurnPlayer.Text = "Player 2";

                    CheckWinner();
                }
                else
                {
                    btn.Image = Resources.O;
                    btn.Tag = "O";
                    gamestatus.PlayCount++;

                    CurrentTurn = ePlayerTurn.Player1;
                    lblTurnPlayer.Text = "Player 1";

                    CheckWinner();
                }
            }
            else
            {
                MessageBox.Show("wronge choice");
            }

            if (gamestatus.PlayCount == 9 && !gamestatus.GameOver)
            {
                gamestatus.GameOver = true;
                gamestatus.Winner = eWinner.Draw;
                lblTurnPlayer.Text = "Game Over";
                lblWinner.Text = "Draw";
            }

        }

        private void frmXOgame_Load(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void button_Click(object sender, EventArgs e)
        {
            PerformSelection((Button)sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
