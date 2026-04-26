using System;

public interface IAudioPlayer
{
    void PlayAudio(string fileName);
}

public interface IVideoPlayer
{
    void PlayVideo(string fileName);
}

public interface IAudioRecorder
{
    void RecordAudio(string fileName);
}

public interface ILiveStreamer
{
    void StreamLive(string url);
}

public class AudioPlayer : IAudioPlayer
{
    public void PlayAudio(string fileName)
    {
        Console.WriteLine($"Playing audio: {fileName}");
    }
}

public class StreamingStudio : IAudioPlayer, IVideoPlayer, IAudioRecorder, ILiveStreamer
{
    public void PlayAudio(string fileName)
    {
        Console.WriteLine($"Playing audio: {fileName}");
    }

    public void PlayVideo(string fileName)
    {
        Console.WriteLine($"Playing video: {fileName}");
    }

    public void RecordAudio(string fileName)
    {
        Console.WriteLine($"Recording audio: {fileName}");
    }

    public void StreamLive(string url)
    {
        Console.WriteLine($"Streaming live to: {url}");
    }
}

class Program
{
    static void Main()
    {
        AudioPlayer audioPlayer = new AudioPlayer();
        audioPlayer.PlayAudio("song.mp3");

        StreamingStudio studio = new StreamingStudio();
        studio.PlayAudio("podcast.mp3");
        studio.PlayVideo("video.mp4");
        studio.RecordAudio("voice.wav");
        studio.StreamLive("https://stream.example.com/live");
    }
}
