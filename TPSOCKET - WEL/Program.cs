using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPSocket.Properties;

namespace TPSocket
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // init form
            Communication mainForm = new Communication();

            // call form & show 
            Application.Run(mainForm);
        }
    }
}

