namespace CustomSwiftApi.Infrastructure.Models
{
    /// <summary>
    ///  Swift MT799 message database model
    /// </summary>
    public class SwiftMT799Message
    {
        /// <summary>
        ///  Field 1: Basic Header Block
        /// </summary>
        public required string BasicHeaderBlock { get; set; }

        /// <summary>
        ///  Field 2: Application Header Block
        /// </summary>
        public required string ApplicationHeaderBlock { get; set; }

        /// <summary>
        ///  Field 20: Transaction Reference Number
        /// </summary>
        public required string TransactionReferenceNumber { get; set; }

        /// <summary>
        ///  Field 21: Related Reference
        /// </summary>
        public string? RelatedReference { get; set; }

        /// <summary>
        ///  Field 79: Narrative
        /// </summary>
        public required string Narrative { get; set; }

        /// <summary>
        ///  Field MAC: Message Authentication Code
        /// </summary>
        public required string MAC {  get; set; }

        /// <summary>
        ///  Field CHK: Checksum
        /// </summary>
        public required string CHK { get; set; }
    }
}
