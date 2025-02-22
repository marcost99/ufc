using Enterprise.ApiWeb.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace Enterprise.ApiWeb.Controllers
{
    public class FighterController : ApiController
    {
        [System.Web.Http.HttpGet]
        public List<Fighter> Get()
        {
            var result = new List<Fighter>()
            {
                new Fighter() { Id = 1, Name = "Bruna Brasil", Weight = (decimal)56.00, Height = (decimal)1.68 },
                new Fighter() { Id = 2, Name = "Marina Rodriguez", Weight = (decimal)52.00, Height = (decimal)1.68 },
                new Fighter() { Id = 3, Name = "Alex Poatan", Weight = (decimal)93.00, Height = (decimal)1.93 },
                new Fighter() { Id = 4, Name = "Maurício Ruffy", Weight = (decimal)74.00, Height = (decimal)1.91 },
            };
            return result;
        }
    }
}
