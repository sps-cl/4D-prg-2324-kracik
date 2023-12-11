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

namespace WpfToDo
{
    public partial class ToDo : Window
    {
        public ToDo()
        {
            InitializeComponent();
            TodoDataGrid.ItemsSource = todos;
        }

        private List<TodoItem> todos = new List<TodoItem>();

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var name = Microsoft.VisualBasic.Interaction.InputBox("Zadejte název úkolu:", "Přidat úkol", "Nová úloha");
            var description = Microsoft.VisualBasic.Interaction.InputBox("Zadejte popis úkolu:", "Přidat úkol", "Popis nové úlohy");
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(description))
            {
                todos.Add(new TodoItem { Name = name, Description = description });
                TodoDataGrid.Items.Refresh();
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = TodoDataGrid.SelectedItem as TodoItem;
            if (selectedItem != null)
            {
                todos.Remove(selectedItem);
                TodoDataGrid.Items.Refresh();
                MessageBox.Show("Položka byla úspěšně odebrána.", "Úspěch", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Prosím vyberte položku, kterou chcete odebrat.", "Chyba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }

    public class TodoItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
