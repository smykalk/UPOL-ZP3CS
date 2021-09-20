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

namespace trojuhelnikTest
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Vypocti_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(tb_stranaA.Text);
            int b = int.Parse(tb_stranaB.Text);
            int c = int.Parse(tb_stranaC.Text);

            OverTrojuhelnik(a, b, c);
        }

        private void VypoctiObvod (int a, int b, int c)
        {
            int outcome = a + b + c;
            lbl_obvod_result.Content =  outcome; 
        }

        private void OverTrojuhelnik(int a, int b, int c)
        {
            if ((a + b > c) && (a + c > b) && (c + b > a))
            { 
                lbl_lzeSestrojit.Content = "Trojúhelník lze sestrojit.";
                VypoctiObvod(a, b, c);
            }
            else
            { 
                lbl_lzeSestrojit.Content = "Trojúhelník nelze sestrojit.";
                lbl_obvod_result.Content = "";
            }
        }

        
    }
}
