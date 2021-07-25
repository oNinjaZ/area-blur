using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;
using System.Drawing;
using System.Windows.Media;

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

		private void lol_MouseEnter(object sender, MouseEventArgs e)
		{
			lol.Opacity = 0.1;
		}

		private void lol_MouseLeave(object sender, MouseEventArgs e)
		{
			lol.Opacity = 1;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{

		}

		private bool findColor(string xMouse, string yMouse)
		{
			Bitmap bitmap
			return false;
		}

	}
}
