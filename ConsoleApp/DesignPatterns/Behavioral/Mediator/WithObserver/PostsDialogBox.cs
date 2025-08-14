using ConsoleApp.DesignPatterns.Behavioral.Mediator.WithObserver.UIFramework;

namespace ConsoleApp.DesignPatterns.Behavioral.Mediator.WithObserver;

// The Concrete Observer class
public class PostsDialogBox
{
    // declare fields for UI components
    private readonly ListBox _postsListBox;
    private readonly Button _saveButton;
    private readonly TextBox _titleTextBox;

    public PostsDialogBox()
    {
        // assign ui components
        _postsListBox = new ListBox();
        _titleTextBox = new TextBox();
        _saveButton = new Button();

        // add event handler methods to each ui component
        _postsListBox.AddEventHandler(PostSelected);
        _titleTextBox.AddEventHandler(TitleChanged);
    }

    public void SimulateUserInteraction()
    {
        _postsListBox.SetSelection("Post 2");
        // _titleTextBox.SetText("");
        Console.WriteLine("Title text box: " + _titleTextBox.GetText());
        Console.WriteLine("Button enabled: " + _saveButton.IsEnabled());
    }

    // event handler methods:
    private void PostSelected()
    {
        _titleTextBox.SetText(_postsListBox.GetSelection());
        _saveButton.SetEnabled(true);
    }

    private void TitleChanged()
    {
        var isTitleEmpty = _titleTextBox.GetText() == "";
        _saveButton.SetEnabled(!isTitleEmpty);
    }
}