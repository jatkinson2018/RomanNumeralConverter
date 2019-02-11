using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanNumeralsConverterWFA
{
    /* Changes for version 1.1:-
     * Enabled the enter key to be pressed instead of of using the button "Convert"
     */

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RomanNumeralConvertForm());
        }
    }
}
