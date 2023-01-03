using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using math_game_4kids.GameLogic;

namespace math_game_4kids
{
    public partial class GameForm : Form
    {
        Game game;
        public GameForm(Difficulty difficulty)
        {
            game = new Game(difficulty);
            InitializeComponent();
            buttonIKnow.Enabled = true;
            buttonContinue.Visible = false;

        }

        private void showOperation()
        {

        }

        private void buttonIKnow_Click(object sender, EventArgs e)
        {

        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {

        }
    }
}
