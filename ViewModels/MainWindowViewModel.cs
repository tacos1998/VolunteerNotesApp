using ReactiveUI;
namespace VolunteerNotesApp.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase _contentViewModel;

    //this has a dependency on the ToDoListService

    public MainWindowViewModel()
    {
        _contentViewModel = new HomeViewModel();
    }
    
    public ViewModelBase ContentViewModel
    {
        get => _contentViewModel;
        private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
    }

    public void ViewNotes()
    {
        ContentViewModel = new NotesViewModel();
    }
}
