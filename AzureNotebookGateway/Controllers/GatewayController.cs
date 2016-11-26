using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace AzureNotebookGateway.Controllers
{
    public class GatewayController : ApiController
    {
        // GET api/values
        public async Task<HttpResponseMessage> Get([FromUri(Name ="q")]string url)
        {
            var cli = new HttpClient();
            var ba = await cli.GetByteArrayAsync(url);
            var hr = new HttpResponseMessage(HttpStatusCode.OK);
            // hr.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(@"image/jpeg");
            hr.Content = new ByteArrayContent(ba);
            /*            hr.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("image/jpeg");
                        hr.Content.Headers.ContentLength = ba.Length; */
            hr.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
            hr.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
            hr.Content.Headers.ContentDisposition.FileName = new Uri(url).LocalPath;
            return hr;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
