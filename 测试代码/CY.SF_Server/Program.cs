using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CY.FrameLib.Service;

namespace CY.SF_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            string server = System.Configuration.ConfigurationSettings.AppSettings["Server"];
            int port = Convert.ToInt32(System.Configuration.ConfigurationSettings.AppSettings["port"]);

            RegisterWCFService _rWcf = new RegisterWCFService(server, port);
            _rWcf.RunWCFService();

            Console.WriteLine("服务器已启动.");
            Console.ReadLine();

        }
    }
}
