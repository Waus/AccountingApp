﻿using AccountingApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingApp
{
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

            MainForm view = new MainForm();
            view.Visible = false;

            MainFormController controller = new MainFormController(view);
            controller.PrepareView(view);
            controller.PrepareConfigTab(view);
            Application.Run(view);
            //Application.Run(new MainForm());
        }
    }
}