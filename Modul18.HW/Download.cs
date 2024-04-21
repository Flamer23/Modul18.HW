using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul18.HW
{
    class Download : Command
    {
        Receiver receiver;

        public Download(Receiver receiver)
        {
            this.receiver = receiver;
        }

        // Выполнить
        public override void Run()
        {
            Console.WriteLine("Команда отправлена");
            receiver.Download();
        }

        // Отменить
        public override void Cancel()
        { }
    }
}
