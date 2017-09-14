using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHorwath_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeter consoleGreeter = new Greeter();
            consoleGreeter.Greet();

            HelloWriter consoleHelloWriter = new ConsoleHelloWriter();
            consoleHelloWriter.SayHello();

            int x = 0;
            x++;
        }
    }
}
