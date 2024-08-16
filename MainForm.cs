using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using SuperAltShift.Utilities;
using System.Runtime.InteropServices;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace SuperAltShift
{
    public partial class MainForm : Form
    {
        private bool _isExecuting = false;

        private const int HOTKEY_ID = 1;

        private const int MOD_ALT = 0x0001;

        private const int MOD_CONTROL = 0x0002;

        private const int MOD_SHIFT = 0x0004;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public MainForm()
        {
            InitializeComponent();
            bool isInStartup = Startup.IsInStartup();
            autostartToolStripMenuItem.Checked = isInStartup;

            RegisterHotKey(Handle, HOTKEY_ID, MOD_CONTROL | MOD_ALT | MOD_SHIFT, 0);
            FormClosing += (s, e) => UnregisterHotKey(Handle, HOTKEY_ID);
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

        private async Task ReplaceTextAsync()
        {
            if (_isExecuting) return;
            _isExecuting = true;
            IDataObject tmpClipboard = Clipboard.GetDataObject();

            Clipboard.Clear();

            await Keyboard.DelayAsync(35);

            //SendKeys.SendWait("^c");
            Keyboard.KeyUp(KEYCODE.VK_CONTROL);
            Keyboard.KeyUp(KEYCODE.VK_SHIFT);
            Keyboard.KeyUp(KEYCODE.VK_MENU);
            Keyboard.KeyDown(KEYCODE.VK_CONTROL);
            Keyboard.KeyDown(KEYCODE.VK_C);
            Keyboard.KeyUp(KEYCODE.VK_CONTROL);
            Keyboard.KeyUp(KEYCODE.VK_C);


            await Keyboard.DelayAsync(35);

            if (Clipboard.ContainsText())
            {
                string text = Clipboard.GetText();
                Clipboard.Clear();
                string correctedText = TextCorrecter.CorrectText(text);
                Clipboard.SetDataObject(correctedText, true);
                await Keyboard.DelayAsync(35);
                Keyboard.KeyUp(KEYCODE.VK_CONTROL);
                Keyboard.KeyUp(KEYCODE.VK_SHIFT);
                Keyboard.KeyUp(KEYCODE.VK_MENU);
                Keyboard.Type("^v");
            }
            Clipboard.SetDataObject(tmpClipboard);
            _isExecuting = false;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == HOTKEY_ID)
            {
                ReplaceTextAsync();
            }
            base.WndProc(ref m);//hello
        }


    }
}
