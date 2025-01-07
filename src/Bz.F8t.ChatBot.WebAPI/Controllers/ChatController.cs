using Microsoft.AspNetCore.Mvc;

namespace Bz.F8t.ChatBot.WebAPI.Controllers;

public class ChatRequest
{
    public string Query { get; set; }
}

[Route("api/[controller]")]
[ApiController]
public class ChatController : ControllerBase
{
    [HttpPost]
    public async Task<string> AskAsync([FromBody] ChatRequest request)
    {
        return "Chatbot answer!";
    }
}
