using System;

namespace CastleContainer
{
    public class Service2
    {
        private IReader _read;
        private IWriter _write;
        public void Read(IReader read)
        {
            _read = read;
            Console.WriteLine("setup reader");
        }

        public void Write(IWriter write)
        {
            _write = write;

            Console.WriteLine("setup writer");
           
        }

        public void TryRead()
        {
            Console.WriteLine(_read.Read());
        }

        public void TryWrite()
        {
            _write.Write("message from service 2");
        }
    }
}