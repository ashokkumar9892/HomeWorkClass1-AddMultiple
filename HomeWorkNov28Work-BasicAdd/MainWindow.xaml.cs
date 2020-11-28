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

namespace HomeWorkNov28Work_BasicAdd
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

        private void btnSum_Click(object sender, RoutedEventArgs e)
        {
            /// source right side and left destination.
            /// 

            lblResult.Content = Convert.ToInt32(txtFNo.Text) + Convert.ToInt32(txtSNo.Text);
        }

        private void btnMultiple_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = Convert.ToInt32(txtFNo.Text) * Convert.ToInt32(txtSNo.Text);
        }
    }
}
