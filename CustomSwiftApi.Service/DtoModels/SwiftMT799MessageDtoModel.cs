using System.ComponentModel.DataAnnotations;
using static CustomSwiftApi.Service.Constants.DataConstants;
using static CustomSwiftApi.Infrastructure.ErrorMessages.ErrorMessage;

namespace CustomSwiftApi.Service.DtoModels
{
    /// <summary>
    ///  Swift MT799 message DTO model
    /// </summary>
    public class SwiftMT799MessageDtoModel
    {
        /// <summary>
        ///  Field 1: Basic Header Block
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [MaxLength(BasicHeaderBlockMaxLength, ErrorMessage = MaxLengthErrorMessage)]
        public required string BasicHeaderBlock { get; set; } = string.Empty;

        /// <summary>
        ///  Field 2: Application Header Block
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [MaxLength(ApplicationHeaderBlockMaxLength, ErrorMessage = MaxLengthErrorMessage)]
        public required string ApplicationHeaderBlock { get; set; } = string.Empty;

        /// <summary>
        ///  Field 20: Transaction Reference Number
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [MaxLength(TransactionReferenceNumberMaxLength, ErrorMessage = MaxLengthErrorMessage)]
        public required string TransactionReferenceNumber { get; set; } = string.Empty;

        /// <summary>
        ///  Field 21: Related Reference
        /// </summary>
        [MaxLength(RelatedReferenceMaxLength, ErrorMessage = MaxLengthErrorMessage)]
        public string? RelatedReference { get; set; }

        /// <summary>
        ///  Field 79: Narrative
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [MaxLength(NarrativeMaxLength, ErrorMessage = MaxLengthErrorMessage)]
        public required string Narrative { get; set; } = string.Empty;

        /// <summary>
        ///  Field MAC: Message Authentication Code
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [MaxLength(MACMaxLength, ErrorMessage = MaxLengthErrorMessage)]
        public required string MAC { get; set; } = string.Empty;

        /// <summary>
        ///  Field CHK: Checksum
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [MaxLength(CHKMaxLength, ErrorMessage = MaxLengthErrorMessage)]
        public required string CHK { get; set; } = string.Empty;
    }
}
