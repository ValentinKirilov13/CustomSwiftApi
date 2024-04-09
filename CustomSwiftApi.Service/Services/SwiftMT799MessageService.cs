using CustomSwiftApi.Infrastructure.Contracts;
using CustomSwiftApi.Infrastructure.Models;
using CustomSwiftApi.Service.Contracts;

namespace CustomSwiftApi.Service.Services
{
    public class SwiftMT799MessageService : ISwiftMT799MessageService
    {
        private readonly IRepository<SwiftMT799Message> _repository;

        public SwiftMT799MessageService(IRepository<SwiftMT799Message> repository)
        {
            _repository = repository;
        }


    }
}
