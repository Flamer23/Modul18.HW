using AngleSharp;
using System.Text;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Modul18.HW
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // создадим отправителя 
            var sender = new Sender();

            // создадим получателя 
            var receiver = new Receiver();

            // создадим команду 
            var getInfo = new GetInfo(receiver);

            // инициализация команды
            sender.SetCommand(getInfo);

            //  выполнение
            sender.Run();

            var download = new Download(receiver);

            // инициализация команды
            sender.SetCommand(download);

            //  выполнение
            sender.Run();
        }
    }
}
