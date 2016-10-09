using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.ComponentModel;

namespace AutoKeyPress
{
    public class WindowsInputController
    {

        // Get a handle to an application window.

        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        

        // Activate an application window.

        [DllImport("USER32.DLL")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        // Send a series of key presses to the Calculator application.

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern IntPtr GetForegroundWindow();


        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);


        public IntPtr GetForegroundWindowPtr()
        {
            return GetForegroundWindow();
        }

        public IntPtr FindWindowPtr(string lpClassName, string lpWindowName)
        {
           return FindWindow(lpClassName, lpWindowName);
        }

        public bool SetForegroundWindowPtr(IntPtr hWnd)
        {
            return SetForegroundWindow(hWnd);
        }

        //public bool SendMessageKeyPress(IntPtr hWnd, Key keyToSend)
        //{
        //    const int WM_KEYDOWN = 0x100;
        //    const int WM_SYSCOMMAND = 0x018;
        //    const int SC_CLOSE = 0x053;

        //    SendMessage(hWnd, WM_KEYDOWN , (int)keyToSend, (IntPtr)0);
        //}

    }
}
