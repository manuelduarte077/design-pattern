using ConsoleApp.DesignPatterns.Structural.Proxy.GoodExample.ThirdPartyVideoLib;

namespace ConsoleApp.DesignPatterns.Structural.Proxy.GoodExample;

public class VideoList
{
    private readonly Dictionary<string, Video> _videoList = new();


    public void Add(Video video)
    {
        _videoList.Add(video.GetVideoId(), video);
    }


    public void Watch(string videoId)
    {
        var video = _videoList[videoId];
        video.Render();
    }
}