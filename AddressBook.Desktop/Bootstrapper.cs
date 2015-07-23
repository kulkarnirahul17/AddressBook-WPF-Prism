using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Prism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Microsoft.Practices.Prism.Modularity;

namespace AddressBook.Desktop
{
	public class Bootstrapper: UnityBootstrapper
	{
		protected override System.Windows.DependencyObject CreateShell()
		{
			return Container.TryResolve<Shell>();
		}

		protected override void InitializeShell()
		{
			base.InitializeShell();

			App.Current.MainWindow = (Window) this.Shell;
			App.Current.MainWindow.Show();
		}

		protected override IModuleCatalog CreateModuleCatalog()
		{
			return new ConfigurationModuleCatalog();
		}
	}
}
