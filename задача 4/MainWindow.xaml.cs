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

namespace задача_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum .Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            double rateEvro = Convert.ToDouble(rate1.Text);
            double sumEvro = Convert.ToDouble(sum1.Text);
            double resEvro = rateEvro * sumEvro;
            resSum1.Text = resEvro.ToString();
        }

       

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateHryvnia = Convert.ToDouble(rate2.Text);
            double sumHryvnia = Convert.ToDouble(sum2.Text);
            double resHryvnia = rateHryvnia * sumHryvnia;
            resSum2.Text = resHryvnia.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDrama = Convert.ToDouble(rate3.Text);
            double sumDrama = Convert.ToDouble(sum3.Text);
            double resDrama = rateDrama * sumDrama;
            resSum3.Text = resDrama.ToString();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            double unitsInch = Convert.ToDouble(units.Text);
            double resInch = unitsInch /39.37 ;
            resUnits.Text = resInch.ToString();
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            double unitsFoot = Convert.ToDouble(units1.Text);
            double resFoot = unitsFoot /3.281;
            resUnits1.Text = resFoot.ToString();
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            double unitsMile = Convert.ToDouble(units2.Text);
            double resMile = unitsMile * 1609.34;
            resUnits2.Text = resMile.ToString();
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            double unitsVersts = Convert.ToDouble(units3.Text);
            double resVersts = unitsVersts* 1066.8;
            resUnits3.Text = resVersts.ToString();
        }
    }
}



