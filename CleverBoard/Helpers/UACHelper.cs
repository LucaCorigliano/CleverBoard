// Decompiled with JetBrains decompiler
// Type: CleverBoard.Helpers.MiscHelper
// Assembly: CleverBoard, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 10389722-1CF7-4B04-A1FD-449E5874D0E2
// Assembly location: G:\CleverBoard\CleverBoard.exe

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;

namespace CleverBoard.Helpers
{
    public static class UACHelper
    {
  

        public static bool IsVistaOrGreater()
        {
            return Environment.OSVersion.Version.Major > 5;
        }

        public static bool IsAdmin()
        {
            if (!IsVistaOrGreater())
                return true;
            return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
        }

        public static bool Elevate(string path, string arguments)
        {
            if (IsAdmin())
                return true;
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                UseShellExecute = true,
                WorkingDirectory = Application.StartupPath,
                Arguments = arguments,
                FileName = Application.ExecutablePath,
                Verb = "runas"
            };
            try
            {
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                
                return false;
            }
            Environment.Exit(0);
            return true;
        }
    }
}
