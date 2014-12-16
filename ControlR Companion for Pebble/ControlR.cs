using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace ControlR
{
    class ControlR
    {
        static bool StateOn = false;

        public static void SendCommand(int id)
        {
            TextBox t = null;
            //Focus the application
            Process[] Processes = Process.GetProcessesByName(Application.OpenForms["Form1"].Controls["txtApplication"].Text);
            IntPtr hWnd = IntPtr.Zero;
            foreach (Process p in Processes)
            {
                hWnd = p.Handle;
                break;
            }
            if (hWnd.ToInt32() > 0) //If found
            {
                //Win32.SetForegroundWindow(hWnd); //Activate it
            }

            switch (id)
            {
                case PebbleButton.BACK:
                    if (StateOn) {
                        t = Application.OpenForms["Form1"].Controls["txtBackOn"] as TextBox;
                    }
                    else {
                        t = Application.OpenForms["Form1"].Controls["txtBackOff"] as TextBox;
                    }
                    StateOn = !StateOn;
                    break;
                case PebbleButton.UP:
                    t = Application.OpenForms["Form1"].Controls["txtUp"] as TextBox;
                    break;
                case PebbleButton.SELECT:
                    t = Application.OpenForms["Form1"].Controls["txtSelect"] as TextBox;
                    break;
                case PebbleButton.DOWN:
                    t = Application.OpenForms["Form1"].Controls["txtDown"] as TextBox;
                    break;
                default:
                    break;
            }
            if (t != null) {
                SendKeys.SendWait(t.Text);
            }
        }
    }
}
