using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul18.HW
{
    class Sender
    {
        Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        // Выполнить
        public void Run()
        {
            _command.Run();
        }

        // Отменить
        public void Cancel()
        {
            _command.Cancel();
        }
    }
}
