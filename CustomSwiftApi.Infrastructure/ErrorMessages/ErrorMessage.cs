namespace CustomSwiftApi.Infrastructure.ErrorMessages
{
    public static class ErrorMessage
    {
        public const string RequiredErrorMessage = "The field {0} is required!";
        public const string MaxLengthErrorMessage = "The field {0} must be with max {1} charachters length!";

        public const string InvalidInsertStatementErrorMessage = "Invalid insert opertaion in database";
        public const string InvalidInitializeDatabaseErrorMessage = "Invalid initialize database";        
    }
}
