﻿using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity.Configuration;
using Microsoft.Practices.Unity;
using System.Configuration;
using System.Windows;
using Microsoft.Practices.Prism.Modularity;

namespace PowerCreator.LiveClient.Desktop
{
    public partial class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return this.Container.Resolve<Shell>();
        }
        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(TestModule.TestModule));
        }
        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            UnityConfigurationSection configuration = (UnityConfigurationSection)ConfigurationManager.GetSection(UnityConfigurationSection.SectionName);
            configuration.Configure(Container, "defaultContainer");
        }
        protected override void InitializeShell()
        {
            base.InitializeShell();

            App.Current.MainWindow = (Window)this.Shell;
            App.Current.MainWindow.Show();
        }

    }
}
