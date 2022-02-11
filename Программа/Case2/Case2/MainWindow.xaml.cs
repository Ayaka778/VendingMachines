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

namespace Case2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VendingMachinesEntities1 x = new VendingMachinesEntities1();
        
        public MainWindow()
        {
            InitializeComponent();
            lv1.ItemsSource = x.Drinks.ToList();

            var r = x.VendingMachineCoins.Single(w => w.Id == 1);
            var r2 = x.VendingMachineCoins.Single(w => w.Id == 2);
            var r3 = x.VendingMachineCoins.Single(w => w.Id == 3);
            var r4 = x.VendingMachineCoins.Single(w => w.Id == 5);

            //#1------------------------------------------
            if (r.IsActive != 1)
            {
                OneB.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF000000");
            }
            else
            {
                OneB.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF515151");
            }
            //#2------------------------------------------
            if (r2.IsActive != 1)
            {
                TwoB.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF000000");
            }
            else
            {
                TwoB.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF515151");
            }
            //#3------------------------------------------
            if (r3.IsActive != 1)
            {
                FiveB.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF000000");
            }
            else
            {
                FiveB.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF515151");
            }
            //#4------------------------------------------
            if (r4.IsActive != 1)
            {
                TenB.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF000000");
            }
            else
            {
                TenB.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF515151");
            }



        }




        private void OneB_Click(object sender, RoutedEventArgs e)
        {
            var r = x.VendingMachineCoins.Single(w => w.Id == 1);
            if (r.IsActive == 1)
            {
                int TB = Convert.ToInt32(tb1.Text);
            tb1.Text = Convert.ToString(TB + 1);
            }
            

          
        }

        private void TwoB_Click(object sender, RoutedEventArgs e)
        {
            var r2 = x.VendingMachineCoins.Single(w => w.Id == 2);
            if (r2.IsActive == 1)
            {
                int TB = Convert.ToInt32(tb1.Text);
                tb1.Text = Convert.ToString(TB + 2);
            }
           
        }

        private void FiveB_Click(object sender, RoutedEventArgs e)
        {
            var r3 = x.VendingMachineCoins.Single(w => w.Id == 3);
            if (r3.IsActive == 1)
            {
                int TB = Convert.ToInt32(tb1.Text);
                tb1.Text = Convert.ToString(TB + 5);
            }
            
        }

        private void TenB_Click(object sender, RoutedEventArgs e)
        {
            var r4 = x.VendingMachineCoins.Single(w => w.Id == 5);
            if (r4.IsActive == 1)
            {
                int TB = Convert.ToInt32(tb1.Text);
                tb1.Text = Convert.ToString(TB + 10);
            }
            
        }

        

        private void sdaha_Click(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.Show();
            Close();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lv1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
