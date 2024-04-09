namespace CustomSwiftApi.Infrastructure.Exeptions
{
    public class InvalidInitializeDatabaseExeption : Exception
    {
        public InvalidInitializeDatabaseExeption(string message) : base(message)
        {
        }
    }
}
