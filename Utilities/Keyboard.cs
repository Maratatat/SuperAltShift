using System.Runtime.InteropServices;

namespace SuperAltShift.Utilities
{
    public static class Keyboard
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        public static void Delay(int delay)
        {
            System.Threading.Thread.Sleep(delay);
        }

        public static async Task DelayAsync(int delay)
        {
            await System.Threading.Tasks.Task.Delay(delay);
        }

        public static void KeyDown(KEYCODE keycode)
        {
            keybd_event((byte)keycode, 0x0, 0, 0);
        }

        public static void KeyPress(KEYCODE keycode, int delay)
        {
            keybd_event((byte)keycode, 0x0, 0, 0);
            System.Threading.Thread.Sleep(delay);
            keybd_event((byte)keycode, 0x0, 2, 0);
        }

        public static void KeyUp(KEYCODE keycode)
        {
            keybd_event((byte)keycode, 0, 2, 0);
        }

        public static void Type(string message)
        {
            System.Windows.Forms.SendKeys.SendWait(message);
        }

        //helper 		
    }
}