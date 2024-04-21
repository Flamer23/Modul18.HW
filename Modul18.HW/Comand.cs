using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul18.HW
{
    abstract class Command
    {
        public abstract void Run();
        public abstract void Cancel();
    }
}
