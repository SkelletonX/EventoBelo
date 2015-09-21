using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Linq;

namespace EventoBelo
{
    class Globals
    {
        public static Form1 MainWindow;
        public static void UpdateLogs(string log)
        {
            string currentTime = "[" + DateTime.Now.ToLongTimeString() + "] ";
            Globals.MainWindow.logs.AppendText(currentTime + log + "\r\n");
        }
    }
}
