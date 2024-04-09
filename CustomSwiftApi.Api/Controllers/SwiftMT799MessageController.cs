using CustomSwiftApi.Service.Contracts;
using CustomSwiftApi.Service.DtoModels;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Text.RegularExpressions;

namespace CustomSwiftApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SwiftMT799MessageController : ControllerBase
    {
        private readonly ISwiftMT799MessageService _swiftMT799MessageService;

        public SwiftMT799MessageController(ISwiftMT799MessageService SwiftMT799MessageService)
        {
            _swiftMT799MessageService = SwiftMT799MessageService;
        }

        /// <summary>
        /// Receive a file containing a SwiftMT799 message and then proceed to store its contents into the database.
        /// </summary>
        /// <param name="file"></param>
        /// <returns>Status code 200 and 400.</returns>
        [HttpPost()]
        [Route("UploadFile")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            try
            {
                if (file == null || file.Length == 0)
                {
                    return BadRequest("No file uploaded");
                }

                bool succeed = default;

                using (var reader = new StreamReader(file.OpenReadStream()))
                {
                    string fileContent = await reader.ReadToEndAsync();

                    string patternField1 = @"\{1:[^}]+\}";
                    string patternField2 = @"\{2:[^}]+\}";
                    string patternField20 = @"20:(?:(?!\n:).){16}";
                    string patternField21 = @"21:(?:(?!\n:).){14}";
                    string patternField79 = @"79:(?:(?!\n:).*\n)*";
                    string patternFieldMAC = @"\{MAC:[^}]+\}";
                    string patternFieldCHK = @"\{CHK:[^}]+\}";

                    SwiftMT799MessageDtoModel dtoModel = new()
                    {
                        BasicHeaderBlock = Regex.Match(fileContent, patternField1).Value.Trim('{', '}').Substring(2),
                        ApplicationHeaderBlock = Regex.Match(fileContent, patternField2).Value.Trim('{', '}').Substring(2),
                        TransactionReferenceNumber = Regex.Match(fileContent, patternField20).Value.Substring(3),
                        RelatedReference = Regex.Match(fileContent, patternField21).Value.Substring(3),
                        Narrative = Regex.Match(fileContent, patternField79).Value.Substring(3).Replace("\r\n", "")
                                      .Replace("  ", "").Replace("..", ".").Replace(" . ", "").Replace(",.", ", "),
                        MAC = Regex.Match(fileContent, patternFieldMAC).Value.Trim('{', '}').Substring(4),
                        CHK = Regex.Match(fileContent, patternFieldCHK).Value.Trim('{', '}').Substring(4),
                    };

                    if (!ModelState.IsValid)
                    {
                        return BadRequest("Invalid data");
                    }

                   
                    succeed = await _swiftMT799MessageService.AddSwiftMT799MessageAsync(dtoModel);

                    Log.Information("SwiftMT799 Message => {@dtoModel}", dtoModel);
                }

                return Ok(succeed);
            }
            catch (Exception ex)
            {
                Log.Error("Internal server error: {@exeption}",ex.Message);

                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
