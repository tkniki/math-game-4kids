namespace math_game_4kids
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            nameBox.MaxLength = 20;
            buttonStart.Enabled = false;
            radioButton_Easy.Checked = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            GameLogic.Difficulty diff;
            if (radioButton_Easy.Checked)
            {
                diff = GameLogic.Difficulty.EASY;
            }
            else if (radioButton_Medium.Checked)
            {
                diff = GameLogic.Difficulty.MEDIUM;
            }
            else
            {
                diff = GameLogic.Difficulty.HARD;
            }

            GameForm gameForm = new GameForm(diff);
            gameForm.ShowDialog();
            this.Close();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            buttonStart.Enabled = !String.IsNullOrEmpty(nameBox.Text);
        }

        
    }
}