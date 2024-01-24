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
using WpfApp1.Controllers;
using WpfApp1.Model;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Core db= new Core();    
        public MainWindow()
        {


            InitializeComponent();
            Lx.ItemsSource = db.context.zak.ToList();
            ServisComboBox.ItemsSource = db.context.servis.ToList() ;
            ServisComboBox.SelectedValuePath = "id_servis";
            ServisComboBox.DisplayMemberPath = "vid";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ZakController newObj = new ZakController();
            newObj.AddZak(SeriaTextBox.Text, Convert.ToInt32( ServisComboBox.SelectedValue), Convert.ToInt32(PraiseTextBox.Text));
                
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SeriaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
