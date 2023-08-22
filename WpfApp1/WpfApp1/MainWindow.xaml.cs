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
            int sisa, jml = 0, ulang, input = 0, k = 0, index = 0;
            if (txtInput.Text != "") input = Int32.Parse(txtInput.Text);
            List<int> list = new List<int>();
            var prima = "";
            var value = "";
            for (ulang = 1; ulang <= input; ulang++)
            {
                if (input % ulang == 0)
                {
                    list.Add(ulang);
                    index++;
                    k++;
                }
            }
            if (k == 2)
            {
                prima = "Bilangan prima ";
            } else
            {
                prima = "Bukan bilangan prima";
            }
            list.Reverse();
            foreach (int a in list)
            {
                value += a + "\n";
            }
            value += prima;
            txtOutput.Text = value;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            int input = 0, s, i, j;
            var hasil = "";
            if (txtInput.Text != "") input = Int32.Parse(txtInput2.Text);
            for (i = input; i >= 1; i--)
            {
                for (s = i; s < input; s++) hasil += " ";
                for (j = 1; j <= (2 * i - 1); j++) hasil += "* ";
                hasil += "\n";
            }
            txtOutput2.Text = hasil;
        }
    }
}
