using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using messageBoardBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace messageBoardBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/Messages")]
    public class MessagesController : Controller
    {
        private static List<Message> lst = new List<Message>
        {
            new Message {Text = "hello", Owner = "John"},
            new Message {Text = "Hi", Owner = "Tim"}
        };

        public IEnumerable<Message> Get()
        {
            return lst;
        }

        [HttpPost]
        public void Post([FromBody] Message message)
        {
            lst.Add(message);
        }

    }
}