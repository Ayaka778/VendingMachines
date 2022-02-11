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

namespace Case2
{
    /// <summary>
    /// Логика взаимодействия для Coin.xaml
    /// </summary>
    public partial class Coin : Window
    {

        VendingMachinesEntities1 x = new VendingMachinesEntities1();

        public Coin()
        {
            InitializeComponent();

            var r = x.VendingMachineCoins.Single(w => w.Id == 1);
            tb1.Text = Convert.ToString(r.Count);

            var r2 = x.VendingMachineCoins.Single(w => w.Id == 2);
            tb2.Text = Convert.ToString(r2.Count);

            var r3 = x.VendingMachineCoins.Single(w => w.Id == 3);
            tb3.Text = Convert.ToString(r3.Count);

            var r4 = x.VendingMachineCoins.Single(w => w.Id == 5);
            tb4.Text = Convert.ToString(r4.Count);
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {

            var r = x.VendingMachineCoins.Single(w => w.Id == 1);
            r.Count = Convert.ToInt32(tb1.Text);

            var r2 = x.VendingMachineCoins.Single(w => w.Id == 2);
            r2.Count = Convert.ToInt32(tb2.Text);

            var r3 = x.VendingMachineCoins.Single(w => w.Id == 3);
            r3.Count = Convert.ToInt32(tb3.Text);

            var r4 = x.VendingMachineCoins.Single(w => w.Id == 5);
            r4.Count = Convert.ToInt32(tb4.Text);
            x.SaveChanges();

            if (cb1.IsChecked == true)
            {
                r.IsActive = 0;
                x.SaveChanges();
            }
            else
            {
                r.IsActive = 1;
                x.SaveChanges();
            }
            //#2------------------------------------------
            if (cb2.IsChecked == true)
            {
                r2.IsActive = 0;
                x.SaveChanges();
            }
            else
            {
                r2.IsActive = 1;
                x.SaveChanges();
            }
            //#3------------------------------------------
            if (cb3.IsChecked == true)
            {
                r3.IsActive = 0;
                x.SaveChanges();
            }
            else
            {
                r3.IsActive = 1;
                x.SaveChanges();
            }
            //#4------------------------------------------
            if (cb4.IsChecked == true)
            {
                r4.IsActive = 0;
                x.SaveChanges();
            }
            else
            {
                r4.IsActive = 1;
                x.SaveChanges();
            }

            MessageBox.Show("Изменение внесены", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
