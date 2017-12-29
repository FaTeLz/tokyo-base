using Utilities;
using Utilities.Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using SDK.Base;
using SDK.Player;
namespace Functions
{
    public class MemoryFunctions : Memory
    {
        public IntPtr WindowHandle;
        int WorldPTR;
        public MemoryFunctions(string exeName, string processName)
        {
            BaseAddress = GetBaseAddress("GTA5.exe");
            pHandle = GetProcessHandle();
        }
        public bool IsGameRunning()
        {
            Process[] process = Process.GetProcessesByName("GTA5");
            if (process.Length > 0)
            {
                string process_path = process[0].MainModule.FileName;
                WindowHandle = process[0].MainWindowHandle;
                FileInfo FileInfo = new FileInfo(process_path);
                if (FileInfo.Length == 60218776)
                    WorldPTR = SDK.Base.Base.WorldPTR_SOCIALCLUB;
                else
                    WorldPTR = SDK.Base.Base.WorldPTR_STEAM;
                return true;
            }
            else
                return false;
        }
        public void _SET_INVINCIBILTY(bool invincible)
        {
            if (invincible)
                WriteBytes(GetPointerAddress(BaseAddress + WorldPTR, 
                    Player.INVINCIBLE), new byte[] { 0x1, 0x69 });
            else
                WriteBytes(GetPointerAddress(BaseAddress + WorldPTR, 
                    Player.INVINCIBLE), new byte[] { 0x0, 0x69 });
        }
    }
}