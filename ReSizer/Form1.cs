using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ReSizer
{
    public partial class ReSizer : Form
    {
        // Define the FindWindow API function.
        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);
        // Define the SetWindowPos API function.
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, SetWindowPosFlags uFlags);
        // Define the SetWindowPosFlags enumeration.
        [Flags()]
        private enum SetWindowPosFlags : uint
        {
            SynchronousWindowPosition = 0x4000,
            DeferErase = 0x2000,
            DrawFrame = 0x0020,
            FrameChanged = 0x0020,
            HideWindow = 0x0080,
            DoNotActivate = 0x0010,
            DoNotCopyBits = 0x0100,
            IgnoreMove = 0x0002,
            DoNotChangeOwnerZOrder = 0x0200,
            DoNotRedraw = 0x0008,
            DoNotReposition = 0x0200,
            DoNotSendChangingEvent = 0x0400,
            IgnoreResize = 0x0001,
            IgnoreZOrder = 0x0004,
            ShowWindow = 0x0040,
        }

        public ReSizer()
        {
            InitializeComponent();
            ProcessToList();
            program.SelectedIndex = 0;
            size.SelectedIndex = 5;
        }



        private void ProcessToList()
        {
            foreach (Process process in Process.GetProcesses())
            {
                if(process.MainWindowTitle != "")
                    program.Items.Add(process.MainWindowTitle);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the target window's handle.
            IntPtr target_hwnd = FindWindowByCaption(IntPtr.Zero, program.SelectedItem.ToString());
            if (target_hwnd == IntPtr.Zero)
            {
                MessageBox.Show("Could not find a window with the title " + program.SelectedItem.ToString());
                return;
            }
            // Set the window's position.
            string[] WS = size.SelectedItem.ToString().Split('x');
            int width = int.Parse(WS[0]) +4;
            int height = int.Parse(WS[1]) +35;
            int x = (1980 - width) /2;
            int y = (1080 - height) /2;
            SetWindowPos(target_hwnd, IntPtr.Zero, x, y, width, height, 0);
        }
    }
}
