using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.DomainModel;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/candidate")]
    public class CandidateController : ApiController
    {
        [HttpGet]
        public ApplyForInterviewModel Get()
        {
            ApplyForInterviewModel obj = new ApplyForInterviewModel();
            obj.CandidateId = 1111;
            obj.InterviewHistory = new List<InterviewAttempt>{
                new InterviewAttempt{ InterviewDate = Convert.ToDateTime(System.DateTime.Now), InterviewComments = "Some comments", InterviewResult = InterviewResult.Rejected },
                new InterviewAttempt{ InterviewDate = Convert.ToDateTime(System.DateTime.Now), InterviewComments = "Some comments", InterviewResult = InterviewResult.Selected },
                new InterviewAttempt{ InterviewDate = Convert.ToDateTime(System.DateTime.Now), InterviewComments = "Some comments", InterviewResult = InterviewResult.OnHold }
            };
            return obj;
        }



        [HttpPost]
        [Route("apply")]
        public string ApplyNow(string name, string email)
        {
            return "Application placed successfully";
        }

    }
}
