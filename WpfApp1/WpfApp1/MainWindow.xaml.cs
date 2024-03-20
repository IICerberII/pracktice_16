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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal List<ToDo> strList { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            strList = new List<ToDo>();

            strList.Add(new ToDo("Приготовить покушать", "Нет описания", new DateTime(2024, 01, 15), (false)));
            strList.Add(new ToDo("Поработать", "Съездить на совещание в Москву", new DateTime(2024, 01, 20), (false)));
            strList.Add(new ToDo("Отдохнуть", "Съездить в отпуск в Сочи", new DateTime(2024, 02, 01), (false)));
            DataGridProduct.ItemsSource = strList;
            EndToDo();

        }


    private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Owner = this;
            window3.Show();
            EndToDo();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            strList.Remove((sender as Button).DataContext as ToDo);
            DataGridProduct.ItemsSource = null;
            DataGridProduct.ItemsSource = strList;
            
            EndToDo();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {


            ToDo selecteditem =(sender as CheckBox).DataContext as ToDo;
            if (selecteditem.Doing != true || selecteditem != null)
            {
                selecteditem.Doing = true;
                EndToDo();                
            }


        }

        private void CheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            ToDo selecteditem = (sender as CheckBox).DataContext as ToDo;
            if (selecteditem.Doing != true || selecteditem != null)
            {
                selecteditem.Doing = false;
                EndToDo();              
            }            


        }

        public void EndToDo()
        {
            ProgressBarView.Minimum = 0;
            int completed = 0;
            
                int totalTask = strList.Count;
                ProgressBarView.Maximum = totalTask;

                foreach (ToDo i in strList)
                {
                    if (i.Doing)
                    {
                        completed++;
                    }
                }

                ProgressBarView.Value = completed;
                TextProgressBar.Text = $"{completed}/{totalTask}";
            
        }
    }


}
