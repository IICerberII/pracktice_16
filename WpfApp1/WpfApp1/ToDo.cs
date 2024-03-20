using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    internal class ToDo
    {
        // Приватные поля для хранения данных
        private string title;
        private string description;
        private DateTime dueDate;
        private Boolean doing;

        public ToDo(string title, string description, DateTime dueDate, Boolean doing)
        {
            this.title = title;
            this.description = description;
            this.dueDate = dueDate;
            this.doing = doing;
        }

        // Публичные свойства для доступа к полям
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        public Boolean Doing 
        {
            get { return doing; }
            set { doing = value; }
        }
    }
}
