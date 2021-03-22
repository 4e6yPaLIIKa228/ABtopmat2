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

namespace ABtomat.windows
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    { 
        int summ;
        public Menu()
        {
           
            InitializeComponent();
        }

        private void Bt_Chuez_Click(object sender, RoutedEventArgs e) //Чизбургео
        {
            summ += 50;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Чизбургер\t\t\t\t\t\t 50 р.");
        }

        private void Bt_Hambyrger_Click(object sender, RoutedEventArgs e) //Гамбургер
        {
            summ += 120;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Гамбургер\t\t\t\t\t\t  120 р.");
        }

        private void Bt_Big_Mak_Click(object sender, RoutedEventArgs e) //Биг мак -100 р.
        {
           
            summ += 100;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Биг мак\t\t\t\t\t\t\t 100 р.");
        }

        private void Bt_Chefbyrger_Click(object sender, RoutedEventArgs e)// Шефбургер- 99 р.
        {
            summ += 99;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Шефбургер\t\t\t\t\t\t  99 р.");
        }

        private void Bt_File_FIsh_Click(object sender, RoutedEventArgs e)//Темный бургер
        {
            summ += 179;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Темный бургер\t\t\t\t\t\t  179 р.");
        }

        private void Bt_Makchiken_Click(object sender, RoutedEventArgs e)//Де люкс
        {
            summ += 124;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Де люкс\t\t\t\t\t\t\t 124 р.");
        }

        private void Bt_2Chuez_Click(object sender, RoutedEventArgs e)
        {
            summ += 106;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Двой ветчина и сыр\t\t\t\t 106 р.");
        }

        private void Bt_Cola_Mak_Click(object sender, RoutedEventArgs e)//Кола - 75
        {
            summ += 75;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Кола(М)\t\t\t\t\t\t\t 75 р.");
        }

        private void Bt_Cola_KFC_Click(object sender, RoutedEventArgs e)//Кола KFC - 75
        {
            summ += 75;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Кола(KFC)\t\t\t\t\t\t 75 р.");
        }

        private void Bt_Limonad_Click(object sender, RoutedEventArgs e)//Лимнонад  45
        {
            summ += 45;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Лимонад\t\t\t\t\t\t 45 р.");
        }

        private void Bt_Coffi_Click(object sender, RoutedEventArgs e)//Кофе  15
        {
            summ += 15;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Кофе(М)\t\t\t\t\t\t\t 15 р.");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = 1000;
            string f = "1234";
            if (summ >= a)
            {
                MessageBox.Show("Ведите пин - код ");

                if (f == "1234")
                {
                    
                    MessageBox.Show("Пин введнь правильно!");
                    
                }

            }
            MessageBox.Show("Спасибо за покупку!");
            MainWindow g = new MainWindow();
            
           // c.Close();
            g.Show();
        }

        private void Bt_Maclo_Click(object sender, RoutedEventArgs e)//Блин с маслом - 46 р.
        {
            summ += 46;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Блин с маслом\t\t\t\t\t\t 46 р.");
        }

        private void Bt_Ikra_Click(object sender, RoutedEventArgs e) //Блин с икрой -  225 р.
        {
            summ += 225;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Блин с икрой\t\t\t\t\t\t 225 р.");
        }

        private void Bt_Grib_Click(object sender, RoutedEventArgs e)//Илья Муровец -  181 р.
        {
            summ += 181;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Илья Муровец\t\t\t\t\t\t 181 р.");
        }

        private void Bt_Betchina_Click(object sender, RoutedEventArgs e) //Ветчина и сыр - 106 р.
        {
            summ += 106;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Билн ветчина и сыр\t\t\t\t\t 106 р.");
        }

        private void tbfin_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbfin.IsReadOnly = true;

        }
    }
}
