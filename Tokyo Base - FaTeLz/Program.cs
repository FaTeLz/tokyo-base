using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Memory;
using Utilities;
using Functions;
namespace Tokyo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MemoryFunctions MemFunctions = new MemoryFunctions("GTA5", "GTA5.exe");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(MemFunctions));
        }
        static void RunGameLoop(MemoryFunctions MemoryFunctions)
        {
            while (true)
            {
                if (MemoryFunctions.IsGameRunning())
                {
                }
            }
        }
    }
}