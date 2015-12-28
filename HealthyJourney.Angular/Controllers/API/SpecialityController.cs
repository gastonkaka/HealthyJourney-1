using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HealthyJourney.Domain.Entities;
using HealthyJourney.Service;

namespace HealthyJourney.Angular.Controllers.API
{
    [RoutePrefix("api")]
    public class SpecialityController : ApiController
    {

        // private HealthyJourneyContext ctx = new HealthyJourneyContext();
        private ISpecialityServices repo;


        public SpecialityController()
        {
            repo = new SpecialityServices();
        }


        [HttpGet]
        [Route("speciality")]
        public HttpResponseMessage GetSpecialities(HttpRequestMessage request)
        {
            var specialities = repo.GetAllSpecialities();

            return request.CreateResponse<Speciality[]>(HttpStatusCode.OK, specialities.ToArray());
        }

        [HttpGet]
        [Route("speciality/{Id}")]
        public HttpResponseMessage GetSpeciality(HttpRequestMessage request, int Id)
        {
            var specialities = repo.GetAllSpecialities();
            var speciality = specialities.FirstOrDefault<Speciality>(s => s.Id == Id);

            return request.CreateResponse<Speciality>(HttpStatusCode.OK, speciality);
        }
        [HttpGet]
        [Route("speciality/{Id}/providers")]
        public HttpResponseMessage GetProvidersBySpecialityId(HttpRequestMessage request, int Id)
        {
           // var speciality = repo.GetSpecialityById(Id);
            var providers = repo.GetAllInfosBySpecialityId(Id);
            return request.CreateResponse<InfosSpeciality[]>(HttpStatusCode.OK, providers.ToArray());
        }
        // POST: api/Speciality
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Speciality/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Speciality/5
        public void Delete(int id)
        {
        }
    }
}
