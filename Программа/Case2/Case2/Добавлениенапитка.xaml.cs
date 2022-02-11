using Microsoft.Win32;
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
using System.Data.SqlClient;
using System.IO;

namespace Case2
{
    /// <summary>
    /// Логика взаимодействия для Добавлениенапитка.xaml
    /// </summary>
    public partial class Добавлениенапитка : Window
    {
        VendingMachinesEntities1 x = new VendingMachinesEntities1();
        string imgLoc = "";

        public Добавлениенапитка()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.JPG;.PNG)|*.JPG;.PNG| All file (*.*)|*.*";
            ofd.ShowDialog();
            imgLoc = ofd.FileName.ToString();
            image1.Source = new BitmapImage(new Uri(imgLoc));
             tb3.Text = imgLoc;
           


        }



        private void Save_Click(object sender, RoutedEventArgs e)
        {
            
            Drinks drinks = new Drinks {  Name = textb1.Text, Image = tb3.Text, Cost = Convert.ToInt32(texb2.Text) };
            x.Drinks.Add(drinks);
            x.SaveChanges();
        }
    } 
}

