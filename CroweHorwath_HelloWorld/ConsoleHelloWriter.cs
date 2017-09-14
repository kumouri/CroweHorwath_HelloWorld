using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHorwath_HelloWorld
{
    public class ConsoleHelloWriter : HelloWriter
    {
        void HelloWriter.SayHello()
        {
            System.Console.WriteLine("Hello, world!");
        }
    }
}
