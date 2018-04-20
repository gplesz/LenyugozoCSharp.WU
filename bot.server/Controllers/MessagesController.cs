using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Bot.Connector;

namespace bot.server.Controllers
{
    [Route("api/[controller]")]
    public class MessagesController : Controller
    {
        [Authorize(Roles="Bot")]
        [HttpPost]
        public async Task<OkResult> Post([FromBody]Activity activity)
        {
            var appCredentials = new MicrosoftAppCredentials(
                "8fb3babb-5b6b-4265-a510-4391f38c13a2",
                "vlsxzRKBS49997+(-ccVMA%"                
            );

            var connector = new ConnectorClient(new Uri(activity.ServiceUrl), appCredentials);
            var reply = activity.CreateReply($"ezt kaptam: {activity.Text}");
            await connector.Conversations.ReplyToActivityAsync(reply);
            return Ok();
        }
    }
}
