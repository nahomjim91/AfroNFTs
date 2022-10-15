﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfroNFTs
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static mainPage main;

       [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //  Application.Run(new Form1());//calling sigin up
                //  Application.Run(new Login());//calling login
                main = new mainPage();
                Application.Run(main);
            }catch(NFTAppException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
