namespace ConsoleApp.DesignPatterns.Structural.Adapter;

public class VideoEditor
{
    private readonly Video _video;

    public VideoEditor(Video video)
    {
        _video = video;
    }

    public void ApplyColor(Color color)
    {
        color.Apply(_video);
    }
}