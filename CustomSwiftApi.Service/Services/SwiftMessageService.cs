using CustomSwiftApi.Infrastructure.Contracts;
using CustomSwiftApi.Infrastructure.Models;
using CustomSwiftApi.Service.Contracts;

namespace CustomSwiftApi.Service.Services
{
    public class SwiftMessageService : ISwiftMessageService
    {
        private readonly IRepository<SwiftMessage> _repository;

        public SwiftMessageService(IRepository<SwiftMessage> repository)
        {
            _repository = repository;
        }


    }
}
