using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.DomainModel
{
    class ApplyForInterviewModel
    {
        public int CandidateId { get; set; }
        public List<InterviewAttempt> InterviewHistory { get; set; }
    }

    public class InterviewAttempt
    {
        public DateTime InterviewDate { get; set; }
        public string InterviewComments { get; set; }
        public InterviewResult InterviewResult { get; set; }
    }
    public enum InterviewResult
    {
        Rejected = 0,
        Selected = 1,
        OnHold = 2
    }
}
