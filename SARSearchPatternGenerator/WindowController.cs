using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SARSearchPatternGenerator
{
    /*
     *  This class has the sole purpose of being a Controller of the main Window. 
     */
    class WindowController
    {
        Window mainWindow;
        /*
         * Constructor for this WindowController class.  It starts running the main Window. 
         */
        public WindowController() {
            //This is what STARTS the main window.
            mainWindow = new Window();
            Application.Run(mainWindow);
        }
    }
}
