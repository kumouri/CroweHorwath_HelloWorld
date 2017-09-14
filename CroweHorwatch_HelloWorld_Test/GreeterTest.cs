using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CroweHorwath_HelloWorld;

namespace CroweHorwath_HelloWorld_Test
{
    [TestClass]
    public class GreeterTest
    {
        [TestMethod]
        public void ValidateGreeterConsoleOutput()
        {
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            Greeter consoleGreeter = new Greeter();
            consoleGreeter.Greet();

            string expect = string.Format("Hello, world!{0}", Environment.NewLine);
            Assert.AreEqual<string>(expect, stringWriter.ToString());
        }
    }
}
