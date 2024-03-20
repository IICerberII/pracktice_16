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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();

            dateToDo.SelectedDate = new DateTime(2024, 01, 10);
            descriptionToDo.Text = "Описания нет";

        }

        private void descriptionToDo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string Name = titleToDo.Text;
            DateTime? selectedDate = dateToDo.SelectedDate;

            DateTime dueDate = selectedDate ?? DateTime.Now;
            string Description = descriptionToDo.Text;
            Boolean Doing = false;

            MainWindow window = (MainWindow)this.Owner;
            window.strList.Add(new ToDo(Name, Description, dueDate, Doing));

            window.DataGridProduct.ItemsSource = null;
            window.DataGridProduct.ItemsSource = window.strList;
            window.EndToDo();


            titleToDo.Text = "";
            dateToDo.SelectedDate = new DateTime(2024, 01, 10);
            descriptionToDo.Text = "Описания нет";
        }
    }
}
//(this.Owner as MainWindow)