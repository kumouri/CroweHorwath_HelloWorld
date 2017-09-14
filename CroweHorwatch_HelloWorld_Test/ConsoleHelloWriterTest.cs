using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CroweHorwath_HelloWorld;

namespace CroweHorwath_HelloWorld_Test
{
    [TestClass]
    public class ConsoleHelloWriterTest
    {
        [TestMethod]
        public void ValidateConsoleHelloWriterConsoleOutput()
        {
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            HelloWriter consoleHelloWriter = new ConsoleHelloWriter();
            consoleHelloWriter.SayHello();

            string expect = string.Format("Hello, world!{0}", Environment.NewLine);
            Assert.AreEqual<string>(expect, stringWriter.ToString());
        }
    }
}
