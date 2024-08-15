using Microsoft.Win32;


namespace SuperAltShift.Utilities
{
    public class Exit
    {
        private const string ExitedStatusRegistryName = "ExitedStatus";
        public static bool AddExited()
        {
            return AddExited(Application.ProductName);
        }

       
        public static bool AddExited(string AppTitle)
        {
            RegistryKey rk;

            try
            {
                rk = Registry.CurrentUser.OpenSubKey(@"Software\"+AppTitle, true);
                if (rk == null) 
                {
                    rk = Registry.CurrentUser.CreateSubKey(@"Software\" + AppTitle);
                }
                rk.SetValue(ExitedStatusRegistryName, "True");
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

       
        public static bool RemoveExited()
        {
            return RemoveExited(Application.ProductName);
        }
        
        public static bool RemoveExited(string AppTitle)
        {
            RegistryKey rk;

            try
            {
                rk = Registry.CurrentUser.OpenSubKey(@"Software\" + AppTitle, true);
                if (rk == null) 
                {
                    return false;
                }
                rk.DeleteValue(ExitedStatusRegistryName);
                
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

       
        public static bool IsExited()
        {
            return IsExited(Application.ProductName);
        }

        
        public static bool IsExited(string AppTitle)
        {
            RegistryKey? rk;

            try
            {
                rk = Registry.CurrentUser.OpenSubKey(@"Software\" + AppTitle, true);
                if (rk == null)
                {
                    return false;
                }
                string? value = rk.GetValue(ExitedStatusRegistryName)?.ToString();
                if (value == "True")
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
            }

            return false;
        }
    }
}
