using CustomSwiftApi.Service.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CustomSwiftApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SwiftMessageController : ControllerBase
    {
        private readonly ISwiftMessageService _swiftMessageService;

        public SwiftMessageController(ISwiftMessageService swiftMessageService)
        {
            _swiftMessageService = swiftMessageService;
        }
     
    }
}
