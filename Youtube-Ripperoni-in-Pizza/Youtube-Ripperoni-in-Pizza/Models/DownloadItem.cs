using System;
using System.IO;
using System.Threading;
using YoutubeExtractor;
namespace Youtube_Ripperoni_in_Pizza.Models
{
    internal class DownloadItem
    {
        public string ItemName { get; set; }

        public double Progress { get; set; }

        public VideoInfo VideoInfo { get; set; }

        public DownloadItem(VideoInfo video, bool audioOnly, string downloadPath)
        {
            this.ItemName = video.Title;
            this.VideoInfo = video;

            if(audioOnly) {
                Thread thread = new Thread(new ThreadStart(DownloadAudio));
                thread.SetApartmentState(ApartmentState.STA);
                thread.Name = "Thread_" + ItemName;
                thread.Start();
            }
            else {
                Thread thread = new Thread(new ThreadStart(DownloadVideo));
                thread.SetApartmentState(ApartmentState.STA);
                thread.Name = "Thread_" + ItemName;
                thread.Start();
            }
        }

        private void DownloadVideo()
        {
            if(VideoInfo.RequiresDecryption) {
                DownloadUrlResolver.DecryptDownloadUrl(VideoInfo);
            }

            VideoDownloader videoDownloader = new VideoDownloader(VideoInfo, Path.Combine("D:/Downloads", VideoInfo.Title + VideoInfo.VideoExtension));
            videoDownloader.DownloadProgressChanged += (sender, args) => Progress = Math.Round(args.ProgressPercentage, 1);
            videoDownloader.Execute();
        }

        private void DownloadAudio()
        {
            if(VideoInfo.RequiresDecryption) {
                DownloadUrlResolver.DecryptDownloadUrl(VideoInfo);
            }

            AudioDownloader audioDownloader = new AudioDownloader(VideoInfo, Path.Combine("D:/Downloads", VideoInfo.Title + VideoInfo.AudioExtension));
            audioDownloader.DownloadProgressChanged += (sender, args) => Progress = Math.Round(args.ProgressPercentage * 0.85);
            audioDownloader.AudioExtractionProgressChanged += (sender, args) => Progress = Math.Round(85 + args.ProgressPercentage * 0.15);
        }
    }
}