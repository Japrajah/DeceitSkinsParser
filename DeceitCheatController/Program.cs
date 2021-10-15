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
    public class ThreadWork
    {
        public static void DoWork()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
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
            Thread thread1 = new Thread(ThreadWork.DoWork);
            thread1.SetApartmentState(ApartmentState.STA);
            thread1.Start();

           



  while (true)
            {

                Thread.Sleep(1000);
      
                    Form fc = Application.OpenForms["Form1"];
      
                if (fc == null)
                    break;

            }
          
        }
        
  ///
    }


}
