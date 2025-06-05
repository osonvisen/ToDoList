using System.ComponentModel;

namespace ToDoList.Models;

public class ToDoItem : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private string _text = "";
    public string Text 
    { get => _text;
        set
        {
            if (_text != value)
            {
                _text = value;
                OnPropertyChanged(nameof(Text));
            }
        }
    }

    private bool _isDone;

    public bool IsDone
    {
        get => _isDone;
        set
        {
            if (_isDone != value)
            {
                _isDone = value;
                OnPropertyChanged(nameof(IsDone));
            }
        }
    }
    
    private bool _isEditing;

    public bool IsEditing
    {
        get => _isEditing;
        set
        {
            if (_isEditing != value)
            {
                _isEditing = value;
                OnPropertyChanged(nameof(IsEditing));
            }
        }
    }
    
    public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}

// Vi bruker både set og get, fordi vi skal kunne gjøre endringer underveis.

// IsDone hvis huket av i CheckBox
// isEditing hvis man trykker på Rediger-knappen