using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.DomainModel
{
    public class CandidateModel
    {
        public int CandidateId { get; set; }
        public string CandidateName { get; set; }
        public string Password { get; set; }
    }
}
