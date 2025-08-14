using ConsoleApp.DesignPatterns.Behavioral.Mediator.GoodExample.UIFramework;

namespace ConsoleApp.DesignPatterns.Behavioral.Mediator.GoodExample;

public class PostsDialogBox : DialogBox
{
    // fields for all ui components
    private readonly ListBox _postsListBox;
    private readonly Button _saveButton;
    private readonly TextBox _titleTextBox;

    public PostsDialogBox()
    {
        _postsListBox = new ListBox(this);
        _titleTextBox = new TextBox(this);
        _saveButton = new Button(this);
        _saveButton.SetEnabled(false); // initially disabled
    }

    public void SimulateUserInteraction()
    {
        _postsListBox.SetSelection("Post 2");
        _titleTextBox.SetText(""); // add this line
        Console.WriteLine("Title text box: " + _titleTextBox.GetText());
        Console.WriteLine("Button enabled: " + _saveButton.IsEnabled());
    }

    public override void Changed(UIControl uiControl)
    {
        if (uiControl == _postsListBox)
            handlePostChanged();
        else if (uiControl == _titleTextBox) handleTitleChanged();
    }

    private void handlePostChanged()
    {
        _titleTextBox.SetText(_postsListBox.GetSelection());
        _saveButton.SetEnabled(true);
    }

    private void handleTitleChanged()
    {
        var isTitleEmpty = _titleTextBox.GetText() == "";
        _saveButton.SetEnabled(!isTitleEmpty);
    }
}