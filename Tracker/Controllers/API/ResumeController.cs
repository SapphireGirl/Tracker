using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tracker.Models;

namespace Tracker.Controllers.API
{
    public class ResumeController : ApiController
    {
        // GET: api/Resume
        [HttpGet]
        [Route("resumes")]
        public HttpResponseMessage GetResumes(HttpRequestMessage request)
        {
            var resumes = DataFactory.GetResumes();
            return request.CreateResponse<Resume[]>(HttpStatusCode.OK, resumes.ToArray());
        }

        // GET: api/Resume/5
        [HttpGet]
        [Route("resume/{resumeId}")]
        public HttpResponseMessage GetResume(HttpRequestMessage request, int resumeId)
        {
            var resumes = DataFactory.GetResumes();
            var resume = resumes.FirstOrDefault(item => item.ResumeId == resumeId);
            return request.CreateResponse<Resume>(HttpStatusCode.OK, resume);
        }

        [HttpGet]
        [Route("skills")]
        public HttpResponseMessage GetProducts(HttpRequestMessage request)
        {
            var products = DataFactory.GetSkillset();

            return request.CreateResponse<Skillset[]>(HttpStatusCode.OK, products.ToArray());
        }

        [HttpGet]
        [Route("skills/{skillsetId}")]
        public HttpResponseMessage GetProduct(HttpRequestMessage request, int productId)
        {
            var products = DataFactory.GetSkillset();
            var product = products.FirstOrDefault(item => item.SkillsetId == productId);

            return request.CreateResponse<Skillset>(HttpStatusCode.OK, product);
        }

        [HttpGet]
        [Route("skills")]
        public HttpResponseMessage GetSkills(HttpRequestMessage request)
        {
            var orders = DataFactory.GetSkillset();

            return request.CreateResponse<Skillset[]>(HttpStatusCode.OK, orders.ToArray());
        }

    }
}
