using ConsoleApp.DesignPatterns.Structural.Proxy.GoodExample.ThirdPartyVideoLib;

namespace ConsoleApp.DesignPatterns.Structural.Proxy.GoodExample;

public class YouTubeVideoProxy : Video
{
    private readonly string _videoId;
    private YouTubeVideo _youTubeVideo;

    public YouTubeVideoProxy(string videoId)
    {
        _videoId = videoId;
    }

    public void Render()
    {
        if (_youTubeVideo == null) _youTubeVideo = new YouTubeVideo(_videoId);

        _youTubeVideo.Render();
    }

    public string GetVideoId()
    {
        return _videoId;
    }
}