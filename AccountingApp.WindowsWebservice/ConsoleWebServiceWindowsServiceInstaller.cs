using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace AccountingApp.WindowsWebservice
{
    [RunInstaller(true)]
    public partial class ConsoleWebServiceWindowsServiceInstaller : System.Configuration.Install.Installer
    {
        public ConsoleWebServiceWindowsServiceInstaller()
        {
            InitializeComponent();
        }
    }
}

//instalacja:
//installutil "C:\Git\AccountingApp\AccountingApp.WCF\bin\Debug\AccountingApp.WCF.exe"

//dezinstalacja:
//installutil /u "C:\Git\AccountingApp\AccountingApp.WCF\bin\Debug\AccountingApp.WCF.exe"
