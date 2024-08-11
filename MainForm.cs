using Microsoft.VisualBasic;
using SuperAltShift.Utilities;

namespace SuperAltShift
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            bool isInStartup = Startup.IsInStartup();
            autostartToolStripMenuItem.Checked = isInStartup;
        }



        private void Close_button_Click(object sender, EventArgs e)
        {
            Hide();
            TrayIcon.ShowBalloonTip(1000, "Super Alt Shift works", "App now works in systme tray", ToolTipIcon.Info);
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit.AddExited();
            Application.Exit();
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void autostartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (autostartToolStripMenuItem.Checked)
            {
                Startup.RemoveFromStartup();
            }
            else
            {
                Startup.RunOnStartup();
            }
            autostartToolStripMenuItem.Checked ^= true;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (!Exit.IsExited())
            {
                Hide();
            }
            Exit.RemoveExited();
        }
    }
}
