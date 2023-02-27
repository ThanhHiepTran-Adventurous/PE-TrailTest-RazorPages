 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CandidateManagement_TranThanhHiep.Repo.Models;
using CandidateManagement_TranThanhHiep.Repo.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CandidateManagement_TranThanhHiep.Pages.CandidateCRUD
{
    public class DetailsModel : PageModel
    {
        private ICandidateProfileRepo candidateProfileRepo;
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public CandidateProfile CandidateProfile { get; set; }

        public IList<JobPosting> JobPostings { get; set; }
        public SelectList PostingIds { get; set; }
        public DetailsModel()
        {
            candidateProfileRepo = new CandidateProfileRepo();
            JobPostings = candidateProfileRepo.getJobList();
            PostingIds = new SelectList(JobPostings, "PostingId", "JobPostingTitle");
            
        }



        public IActionResult OnGet(string id)
        {
            if (id == null || candidateProfileRepo.GetCandidateProfiles == null)
            {
                return NotFound();
            }

            var candidateprofile = candidateProfileRepo.getCandidateProfileById(id);
            if (candidateprofile == null)
            {
                return NotFound();
            }
            else
            {
                CandidateProfile = candidateprofile;
            }
            return Page();
        }
    }
}
