using Microsoft.AspNetCore.Mvc;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ConsumeNasaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApodController : ControllerBase
    {
        // GET: api/<ApodController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            List<string> list = new List<string>();
            var url = "https://api.nasa.gov/planetary/apod?api_key=TnQ1TVnGiMWZMH9Vk5e0O3nGTsinKSRFpSbgMhTK";

            var httpRequest = WebRequest.Create(url) as HttpWebRequest;


            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }

            return list;
        }

        // GET api/<ApodController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ApodController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ApodController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ApodController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
