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

namespace Xeploaihocluc
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

        private void btnthoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnreset_Click(object sender, RoutedEventArgs e)
        {
            txtxeploai.Clear();
            txt0.Clear();
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            txtdtb.Clear();
            txtnhap.Clear();
        }

        private void btnnhap_Click(object sender, RoutedEventArgs e)
        {
            float d0, d1, d2, d3, d4, d5;
            d0 = float.Parse(txt0.Text);
            d1 = float.Parse(txt1.Text);
            d2 = float.Parse(txt2.Text);
            d3 = float.Parse(txt3.Text);
            d4 = float.Parse(txt4.Text);
            d5 = (d0 + d1 + d2 + d3 + d4) / 5;
            txtdtb.Text = d5.ToString();
            if (d5 >= 9)
                txtxeploai.Text = txtnhap.Text + "\r\n Xếp loại: Xuấc Sắc";
            else if (d5>=8)
                txtxeploai.Text = txtnhap.Text + "\r\n Xếp loại: Giỏi";
            else if (d5 >= 6.5)
                txtxeploai.Text = txtnhap.Text + "\r\n Xếp loại: Khá";
            else if (d5 >= 5)
                txtxeploai.Text = txtnhap.Text + "\r\n Xếp loại: Trung Bình";
            else 
                txtxeploai.Text = txtnhap.Text + "\r\n Xếp loại: Yếu";
        }
    }
}
