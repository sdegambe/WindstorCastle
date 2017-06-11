namespace CastleContainer
{
    public class FileReader : IReader
    {
        private int _counter;
        public string Read()
        {
            
            return "Read file";
            //return string.Format("Read file {0}", _counter++);
        }
    }
}