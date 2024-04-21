using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul18.HW
{
    class GetInfo : Command
    {
        Receiver receiver;

        public GetInfo(Receiver receiver)
        {
            this.receiver = receiver;
        }

        // Выполнить
        public override void Run()
        {
            Console.WriteLine("Команда отправлена");
            receiver.GetInfo();
        }

        // Отменить
        public override void Cancel()
        { }
    }
}
