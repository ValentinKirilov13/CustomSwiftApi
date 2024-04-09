namespace CustomSwiftApi.Infrastructure.Exeptions
{
    public class InvalidAddMessageExeption : Exception
    {
        public InvalidAddMessageExeption(string message) : base(message)
        {
        }
    }
}
