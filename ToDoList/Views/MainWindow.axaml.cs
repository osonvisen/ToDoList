using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using ToDoList.Models;
using ToDoList.ViewModels;

namespace ToDoList.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    // EventListener på Slett-knappen
    public void DeleteButton_Click(object? sender, RoutedEventArgs e)
    {
        if (sender is Button button &&
            button.DataContext is ToDoItem item &&
            DataContext is MainWindowViewModel vm)
        {
            vm.RemoveItem(item);
        }
    }
    
    // EventListener for Rediger-knappen
    public void EditButton_Click(object? sender, RoutedEventArgs e)
    {
        if (sender is Button button &&
            button.DataContext is ToDoItem item)
        {
            item.IsEditing = true;
        }
    }
    
    // EventListener for Lagre (endringer)-knappen
    public void SaveButton_Click(object? sender, RoutedEventArgs e)
    {
        if (sender is Button button &&
            button.DataContext is ToDoItem item)
        {
            item.IsEditing = false;
        }
    }
    
    // Eventlistener for Avbryt-knappen
    public void CancelButton_Click(object? sender, RoutedEventArgs e)
    {
        if (sender is Button button &&
            button.DataContext is ToDoItem item)
            {
                item.IsEditing = false;
            }
    }
}