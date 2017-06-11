using System;

namespace CastleContainer
{
    public class ServiceWriter : IWriter
    {
        public void Write(string something)
        {
            Console.WriteLine(something + " Service writer");
        }
    }
}