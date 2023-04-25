/**
 * HelpData.cs
 * 
 * This file is the main entry point for the application.
 * 
 * Last Modifier: Fillip Cannard
 * Last Modified: 4/24/2023
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daedalus.Daedalus.Programs
{
    static class DaedalusProgram
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Knossos());
        }
    }
}
