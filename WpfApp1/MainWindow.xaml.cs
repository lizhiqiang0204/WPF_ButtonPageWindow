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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNav_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            this.frmMain.Navigate(new Uri(btn.Tag.ToString() + ".xaml", UriKind.Relative));
            switch(btn.Name)
            {
                case "btnA":
                    Page1 page1 = new Page1();
                    this.frmMain.Content = page1;
                    page1.ParentWindow = this; 
                    break;
                case "btnB":
                    Page2 page2 = new Page2();
                    this.frmMain.Content = page2;
                    page2.ParentWindow = this;
                    break;
            }

        }

        public void CallFromChild(string name)
        {
            MessageBox.Show("Hello," + name + "!");
        }
    }
}
