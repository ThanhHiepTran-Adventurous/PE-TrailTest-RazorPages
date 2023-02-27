using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement_TranThanhHiep.Repo.Models.ViewModels;

    public class EditCandidateViewModel
    {
       public string CandidateId { get; set; }
       public string Fullname { get; set; }
       public DateTime? Birthday { get; set; }
       public string ProfileShortDescription { get; set; }
       public string ProfileUrl { get; set; }
       public string PostingId { get; set; }
    }

