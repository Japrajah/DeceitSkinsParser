using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DeceitCheatController
{
    static class Program
    {
        /// <summary>
        ///
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

     
        static async Task Main()
        {
            SkinList.skInfo = new List<SkinInfo>();
            Skinparser.GetListFromCvs();
            Task FormTask = Task.Run(() =>
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            });
  while (true)
            {

                Thread.Sleep(5000);
                Debug.WriteLine("Main Thread end");
                    Form fc = Application.OpenForms["Form1"];
                Debug.WriteLine(SkinList.skInfo.Count);
                if (fc == null)
                    break;

            }
          
        }
        
  ///
    }


}
