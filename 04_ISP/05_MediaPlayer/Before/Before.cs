using System;

public interface IMediaPlayer
{
    void PlayAudio(string fileName);
    void PlayVideo(string fileName);
    void RecordAudio(string fileName);
    void StreamLive(string url);
}

public class AudioPlayer : IMediaPlayer
{
    public void PlayAudio(string fileName)
    {
        Console.WriteLine($"Playing audio: {fileName}");
    }

    public void PlayVideo(string fileName)
    {
        throw new NotImplementedException();
    }

    public void RecordAudio(string fileName)
    {
        throw new NotImplementedException();
    }

    public void StreamLive(string url)
    {
        throw new NotImplementedException();
    }
}

class Program
{
    static void Main()
    {
        IMediaPlayer player = new AudioPlayer();
        player.PlayAudio("song.mp3");
    }
}
