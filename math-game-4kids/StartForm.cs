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

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            buttonStart.Enabled = !String.IsNullOrEmpty(nameBox.Text);
        }

        
    }
}