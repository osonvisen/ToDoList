using System.Collections.ObjectModel;
using ToDoList.Models;

namespace ToDoList.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<ToDoItem> Items { get; } = new()
        {
            new ToDoItem { Text = "Lære Avalonia" },
            new ToDoItem { Text = "Teste liste" },
            new ToDoItem { Text = "Skrive ut elementer" },
            new ToDoItem { Text = "Feilsøke" }
        };

        public void RemoveItem(ToDoItem item)
        {
            Items.Remove(item);
        }

    };
}