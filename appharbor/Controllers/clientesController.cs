using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace appharbor.Controllers
{
    public class clientesController : ApiController
    {
        sapEntities dataserver = new sapEntities();

        [Route("api/clientes")]
        [HttpGet]
        public IEnumerable<OCRD_Select_Result> listarclientes() {
            
            return dataserver.OCRD_Select(null,null,null).AsEnumerable();
        }
        
    }
}
