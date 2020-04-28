﻿using Prism.Unity;
using System.Windows;
using Microsoft.Practices.Unity;
using System;

namespace GS_Restaurant_Prism
{
    public class Bootstrapper : UnityBootstrapper
    {
        public override void Run(bool runWithDefaultConfiguration)
        {
            base.Run(runWithDefaultConfiguration);
        }

        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Views.Shell>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow = (Window)Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            Type module2Type = typeof(RestaurantModule.RestaurantModule);
            ModuleCatalog.AddModule
                (
                new Prism.Modularity.ModuleInfo
                {
                    ModuleName = module2Type.Name,
                    ModuleType = module2Type.AssemblyQualifiedName
                }
                );
        }
    }
}
