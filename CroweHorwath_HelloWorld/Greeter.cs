using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CroweHorwath_HelloWorld
{
    public class Greeter
    {
        private TextWriter _writer;

        public Greeter(TextWriter writer)
        {
            this._writer = writer;
        }

        public Greeter()
        {
            this._writer = System.Console.Out;
        }

        public void Greet()
        {
            this._writer.WriteLine("Hello, world!");
        }
    }
}
