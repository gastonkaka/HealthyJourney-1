using HealthyJourney.Domain.Entities;
using HealthyJourney.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HealthyJourney.Angular.Controllers.API
{
    [RoutePrefix("api")]
    public class InfosController : ApiController
    {

        private UserServices repo;


        public InfosController()
        {
            repo = new UserServices();
        }

        [HttpGet]
        [Route("infos")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            var infos = repo.GetAllInfos();

          //  return request.CreateResponse<Infos[]>(HttpStatusCode.OK, infos.ToArray());
            return request.CreateResponse<Infos[]>(HttpStatusCode.OK, infos.ToArray());

        }

        [HttpGet]
        [Route("infos/{id}")]
        public HttpResponseMessage Get(string id,HttpRequestMessage request)
        {
            Infos infos = repo.GetById(id);
            return request.CreateResponse(HttpStatusCode.OK, infos);
        }

        [HttpPost]
        [Route("infos/create/{infos}")]
        public HttpResponseMessage Post([FromBody]Infos infos, HttpRequestMessage request)
        {
            repo.AddInfos(infos);

            return request.CreateResponse(HttpStatusCode.OK, new
            {
                infos = infos
            });

        }

        // PUT: api/Infos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Infos/5
        public void Delete(int id)
        {
        }
    }
}
