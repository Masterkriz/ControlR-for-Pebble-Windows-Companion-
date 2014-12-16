﻿using System;
using System.Runtime.InteropServices;

namespace ControlR
{
    public class Win32 
    {
        //Import the FindWindow API to find our window
        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        private static extern IntPtr FindWindowNative(string className, string windowName);

        //Import the SetForeground API to activate it
        [DllImport("User32.dll", EntryPoint = "SetForegroundWindow")]
        private static extern IntPtr SetForegroundWindowNative(IntPtr hWnd);

        public static IntPtr FindWindow(string className, string windowName)
        {
            return FindWindowNative(className, windowName);
        }

        public static IntPtr SetForegroundWindow(IntPtr hWnd)
        {
            return SetForegroundWindowNative(hWnd);
        }
    }

}
