﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WPFConsoleLibrary;

namespace WCFConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(MathService));
            sh.Open();
            Console.WriteLine("Server started..");
            Console.WriteLine("Please enter to stop the server");
            Console.ReadLine();
            sh.Close();
        }
    }
}
