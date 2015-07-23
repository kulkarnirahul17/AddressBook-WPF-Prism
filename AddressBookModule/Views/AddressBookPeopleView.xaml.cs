﻿using AddressBook.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AddressBook.WindowsUI.Views
{
	/// <summary>
	/// Interaction logic for AddressBookPeopleView.xaml
	/// </summary>
	public partial class AddressBookPeopleView : UserControl, IView
	{
		public AddressBookPeopleView()
		{
			InitializeComponent();
		}

		IViewModel Infrastructure.IView.ViewModel
		{
			get
			{
				return (IViewModel)DataContext;
			}
			set
			{
				DataContext = value;
			}
		}

	}
}
