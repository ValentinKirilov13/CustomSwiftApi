using CustomSwiftApi.Service.DtoModels;

namespace CustomSwiftApi.Service.Contracts
{
    public interface ISwiftMT799MessageService
    {
        Task<bool> AddSwiftMT799MessageAsync(SwiftMT799MessageDtoModel dtoModel);
    }
}
