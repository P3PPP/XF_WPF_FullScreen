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
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

namespace WpfFormsApp1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : FormsApplicationPage
	{
		public MainWindow()
		{
			InitializeComponent();
			Xamarin.Forms.Forms.Init();
			LoadApplication(new FormsApp());

			Visibility = Visibility.Collapsed;
			WindowStyle = WindowStyle.None;
			ResizeMode = ResizeMode.NoResize;
			WindowState = WindowState.Maximized;
			Topmost = true;
			Visibility = Visibility.Visible;
		}
	}
}
