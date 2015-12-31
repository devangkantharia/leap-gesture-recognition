﻿using LeapGestureRecognition.Model;
using LeapGestureRecognition.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LGR_Controls
{
	/// <summary>
	/// Interaction logic for GestureLibrary.xaml
	/// </summary>
	public partial class GestureLibrary : UserControl
	{
		private MainViewModel _mvm;

		public GestureLibrary()
		{
			InitializeComponent();
		}

		public GestureLibrary(MainViewModel mvm)
		{
			InitializeComponent();
			_mvm = mvm;
		}

		public void SetMvm(MainViewModel mvm) // Make property instead?
		{
			_mvm = mvm;
		}

		private void ViewGesture(object sender, RoutedEventArgs e)
		{
			var gesture = (LGR_StaticGesture)(e.Source as FrameworkElement).Tag;
			_mvm.DisplayGesture(gesture);
		}

		private void EditGesture(object sender, RoutedEventArgs e)
		{
			var gesture = (LGR_StaticGesture)(e.Source as FrameworkElement).Tag;
			_mvm.EditGesture(gesture);
		}

		private void DeleteGesture(object sender, RoutedEventArgs e)
		{
			var gesture = (LGR_StaticGesture)(e.Source as FrameworkElement).Tag;
			_mvm.DeleteGesture(gesture);
		}

		private void GestureMouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ClickCount >= 2) // Double click
			{
				var gesture = (LGR_StaticGesture)(sender as FrameworkElement).Tag;
				_mvm.EditGesture(gesture);
			}
		}
	}
}