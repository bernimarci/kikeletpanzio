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
using System.Windows.Shapes;

namespace kikeletpanzio
{
    /// <summary>
    /// Interaction logic for Foglalas.xaml
    /// </summary>
    public partial class Foglalas : Window
    {
        public Foglalas()
        {
            InitializeComponent();

            CbxHanySzobatSzeretne.Items.Add("2");
            CbxHanySzobatSzeretne.Items.Add("3");
            CbxHanySzobatSzeretne.Items.Add("4");
            CbxGyerek.Items.Add("1");
            CbxGyerek.Items.Add("2");
            CbxGyerek.Items.Add("3");
            CbxGyerek.Items.Add("4");
            CbxFelnott.Items.Add("1");
            CbxFelnott.Items.Add("2");
            CbxFelnott.Items.Add("3");
            CbxFelnott.Items.Add("4");
        }

        private void BtnFoglalas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMegsem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
