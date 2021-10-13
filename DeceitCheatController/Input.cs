using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DeceitCheatController
{

   public class Input
    {
        [DllImport("User32.dll")]
       internal static extern short GetAsyncKeyState(Keys ArrowKeys);







	}

}
