using CustomSwiftApi.Service.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CustomSwiftApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SwiftMT799MessageController : ControllerBase
    {
        private readonly ISwiftMT799MessageService _SwiftMT799MessageService;

        public SwiftMT799MessageController(ISwiftMT799MessageService SwiftMT799MessageService)
        {
            _SwiftMT799MessageService = SwiftMT799MessageService;
        }
     
    }
}
