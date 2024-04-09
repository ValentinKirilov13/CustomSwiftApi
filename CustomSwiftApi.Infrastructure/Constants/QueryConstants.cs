namespace CustomSwiftApi.Infrastructure.Constants
{
    public static class QueryConstants
    {
        public const string CreateTableSwiftMT799Messages =
            "CREATE TABLE IF NOT EXISTS SwiftMT799Messages (" +
            "    BasicHeaderBlock NVARCHAR(25) NOT NULL," +
            "    ApplicationHeaderBlock NVARCHAR(47) NOT NULL," +
            "    TransactionReferenceNumber NVARCHAR(16) NOT NULL," +
            "    RelatedReference NVARCHAR(16)," +
            "    Narrative NVARCHAR(1750) NOT NULL," +
            "    MAC NVARCHAR(8) NOT NULL," +
            "    CHK NVARCHAR(12) NOT NULL" +
            ");";

        public const string InsertDataInSwiftMT799Messages =
            "INSERT INTO SwiftMT799Messages " +
            "(BasicHeaderBlock, ApplicationHeaderBlock, TransactionReferenceNumber, RelatedReference, Narrative, MAC, CHK) " +
            "VALUES (@BasicHeaderBlock, @ApplicationHeaderBlock, @TransactionReferenceNumber, @RelatedReference, @Narrative, @MAC, @CHK)";
    }
}
