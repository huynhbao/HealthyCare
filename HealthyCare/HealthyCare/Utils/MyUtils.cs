

using System.Runtime.InteropServices;

namespace HealthyCare.Utils
{
    public class MyUtils
    {
        public static readonly string doctorRoleID = "1";
        public static readonly string userRoleID = "3";
        public static readonly string EMAIL_FORMAT = "[a-zA-Z0-9]+[._a-zA-Z0-9!#$%&'*+-/=?^_`{|}~]*[a-zA-Z]*@[a-zA-Z0-9]{2,8}.[a-zA-Z.]{2,6}";
        public static readonly string PHONE_FORMAT = "^[0-9]+$";

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    }
}
