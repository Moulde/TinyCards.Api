using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCards.Api.Service;

namespace TinyCards.Api
{
    class Program
    {
        static void Main(string[] args)
        {
            TinyCardsService service = new TinyCardsService();
            var response = service.Login("username", "password").Result;
        }
    }
}
