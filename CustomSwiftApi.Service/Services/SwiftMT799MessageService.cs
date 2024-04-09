using CustomSwiftApi.Infrastructure.Contracts;
using CustomSwiftApi.Infrastructure.Exeptions;
using CustomSwiftApi.Infrastructure.Models;
using CustomSwiftApi.Service.Contracts;
using CustomSwiftApi.Service.DtoModels;

namespace CustomSwiftApi.Service.Services
{
    public class SwiftMT799MessageService : ISwiftMT799MessageService
    {
        private readonly IRepository<SwiftMT799Message> _repository;

        public SwiftMT799MessageService(IRepository<SwiftMT799Message> repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Transform the data from a transfer object into the corresponding model for the database, then proceed to insert it into the     database.
        /// </summary>
        /// <param name="dtoModel"></param>
        /// <returns></returns>
        /// <exception cref="InvalidAddMessageExeption"></exception>
        public async Task<bool> AddSwiftMT799MessageAsync(SwiftMT799MessageDtoModel dtoModel)
        {
            try
            {
                SwiftMT799Message model = new()
                {
                    BasicHeaderBlock = dtoModel.BasicHeaderBlock,
                    ApplicationHeaderBlock = dtoModel.ApplicationHeaderBlock,
                    TransactionReferenceNumber = dtoModel.TransactionReferenceNumber,
                    RelatedReference = dtoModel.RelatedReference,
                    Narrative = dtoModel.Narrative,
                    MAC = dtoModel.MAC,
                    CHK = dtoModel.CHK
                };

                return await _repository.InsertAsync(model);
            }
            catch (Exception ex)
            {
                throw new InvalidAddMessageExeption(ex.Message);
            }           
        }
    }
}
