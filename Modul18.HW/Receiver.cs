using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Modul18.HW
{
    class Receiver
    {
        public async Task GetInfo()
        {
            YoutubeClient client = new YoutubeClient();

            Console.WriteLine("Введите ссылку на видео");
            string url = Console.ReadLine();

            try
            {
                Console.WriteLine(client.Videos.GetAsync(url).Result.Title);
                Console.WriteLine(client.Videos.GetAsync(url).Result.Description);
            }
            catch
            {
                Console.WriteLine("Неверная ссылка");
            }
        }

        public async Task Download()
        {
            Console.WriteLine("Введите ссылку на видео");
            string url = Console.ReadLine();

            try
            {
                string path = @"C:\Users\zuevi\source\repos\Modul18.HW\Modul18.HW\bin\Debug\net7.0";
                Console.WriteLine("Скачивание начато");

                var youtube = new YoutubeClient();
                var video = await youtube.Videos.GetAsync(url);
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);
                var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

                if (streamInfo != null)
                {
                    var fileName = $"{video.Title}.{streamInfo.Container}";
                    var filePath = Path.Combine(path, fileName);

                    await youtube.Videos.Streams.DownloadAsync(streamInfo, filePath);
                }
            }
            catch
            {
                Console.WriteLine("Неверная ссылка");
            }
        }
    }
}
