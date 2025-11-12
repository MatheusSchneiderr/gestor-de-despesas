using System.Web.Http;
using GestaodeDespesasAPI.Models;
using GestaodeDespesasAPI.Services;
using Newtonsoft.Json;

namespace GestaodeDespesasAPI.Controllers
{
    [RoutePrefix("api/despesas")]
    public class DespesasApiController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            var despesaService = new DespesaService();
            
            return Ok(JsonConvert.SerializeObject(despesaService.GetAll()));
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Post([FromBody] Despesa despesa)
        {
            var despesaService = new DespesaService();
            despesaService.Add(despesa);
            return Ok();
        }
        
    }
}