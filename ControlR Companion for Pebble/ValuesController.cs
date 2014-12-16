using System.Collections.Generic;
using System.Web.Http;
using System.Windows.Forms;

namespace ControlR
{
    public class ValuesController : ApiController
    {
        // GET api/values 
        public IEnumerable<string> Get()
        {
            return new string[] { "Companion OK!" };
        }

        // GET api/values/5 
        public string Get(int id)
        {
            ControlR.SendCommand(id);
            return id.ToString();
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

    public static partial class PebbleButton
    {
        public const int BACK = 0;
        public const int UP = 1;
        public const int SELECT = 2;
        public const int DOWN = 3;
    }
}