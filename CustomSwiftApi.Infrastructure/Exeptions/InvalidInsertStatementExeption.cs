namespace CustomSwiftApi.Infrastructure.Exeptions
{
    public class InvalidInsertStatementExeption : Exception
    {
        public InvalidInsertStatementExeption(string message) : base(message)
        {
        }
    }
}
