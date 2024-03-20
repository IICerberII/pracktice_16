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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            //dateToDo.SelectedDate = new DateTime(2024, 01, 10);
            //descriptionToDo.Text = "Описания нет";

            
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            GroupToDo.Visibility = Visibility.Visible;
        }
        private void CheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            GroupToDo.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e) { }

        /**private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.Owner.mainListBox.SelectedItem != null)
                {
                    var selecteditem = mainListBox.SelectedItem as ToDo;

                    if (selecteditem != null)
                    {
                        this.Owner.strList.Remove(selecteditem);

                        this.Owner.mainListBox.ItemsSource = null;
                        this.Owner.mainListBox.ItemsSource = strList;

                     }
            }
        }**/

        private void descriptionToDo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
