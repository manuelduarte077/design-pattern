namespace ConsoleApp.DesignPatterns.Structural.Proxy.BadExample.ThirdPartyVideoLib;

public class YouTubeVideo : Video
{
    private readonly string _videoId;


    public YouTubeVideo(string videoId)
    {
        _videoId = videoId;
        Download();
    }


    public void Render()
    {
        Console.WriteLine("Rendering video " + _videoId);
    }


    public string GetVideoId()
    {
        return _videoId;
    }


    private void Download()
    {
        Console.WriteLine("Downloading video with id " + _videoId + " from YouTube API");
    }
}