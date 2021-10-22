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

namespace WpfApp2
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void inCome_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void totolCalue_Click(object sender, RoutedEventArgs e)
        {
            float inComeTotal = float.Parse(inCome.Text)- float.Parse(outInCome.Text);
            float wantToPayTotal = float.Parse(wantToPay.Text)/ inComeTotal;
            int totaluse = (int)Math.Ceiling(wantToPayTotal);
            //MessageBox.Show(inComeTotal.ToString());
            MessageBox.Show("Done");
            dayUse.Text = totaluse.ToString();
        }
    }
}
