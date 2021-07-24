﻿using System;
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

namespace ぶれ範囲
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.LeftButton == MouseButtonState.Pressed)
			{
				this.DragMove();
			}
		}

		private void theBorder_MouseEnter(object sender, MouseEventArgs e)
		{
			lol.Background = Brushes.Transparent;
			theBorder.Opacity = 0.1;
		}

		private void theBorder_MouseLeave(object sender, MouseEventArgs e)
		{
			lol.Background = Brushes.Black;
			theBorder.Opacity = 1;
		}

		private void theBorder_PreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
		{
			var window = (Window)sender;
			window.Topmost = true;
		}
	}
}
