﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace CtsService
{
	[RunInstaller(true)]
	public partial class ProjectInstaller : System.Configuration.Install.Installer
	{
	    ServiceInstaller serviceInstaller;
	    ServiceProcessInstaller processInstaller;

        public ProjectInstaller()
		{
		    InitializeComponent();
		    serviceInstaller = new ServiceInstaller();
		    processInstaller = new ServiceProcessInstaller();

		    processInstaller.Account = ServiceAccount.LocalSystem;
		    serviceInstaller.StartType = ServiceStartMode.Automatic;
		    serviceInstaller.ServiceName = "CtsService";
		    Installers.Add(processInstaller);
		    Installers.Add(serviceInstaller);
        }
	}
}
