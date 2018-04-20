using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Bot.Connector;

namespace bot.server.Controllers
{
    [Route("api/[controller]")]
    public class MessagesController : Controller
    {
        [HttpPost]
        public async Task<OkResult> Post([FromBody]Activity activity)
        {
            var connector = new ConnectorClient(new Uri(activity.ServiceUrl));
            var reply = activity.CreateReply($"ezt kaptam: {activity.Text}");
            await connector.Conversations.ReplyToActivityAsync(reply);
            return Ok();
        }
    }
}
