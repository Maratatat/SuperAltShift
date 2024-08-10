using Microsoft.VisualBasic;

namespace SuperAltShift
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }



        private void Close_button_MouseEnter(object sender, EventArgs e)
        {
            Close_button.BackColor = Color.FromArgb(244, 67, 54);
        }

        private void Close_button_MouseLeave(object sender, EventArgs e)
        {
            Close_button.BackColor = Color.FromArgb(45, 45, 45);
        }

        private void Sorce_Code_Button_Click(object sender, EventArgs e)
        {
            string? link = Sorce_Code_Button.Tag as string;
            if (!string.IsNullOrEmpty(link))
            {
                Interaction.Shell("cmd /c Start " + link, AppWinStyle.Hide);
            }
        }
    }
}
