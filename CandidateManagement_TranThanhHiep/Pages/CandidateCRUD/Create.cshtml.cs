using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CandidateManagement_TranThanhHiep.Repo.Models;
using CandidateManagement_TranThanhHiep.Repo.Repository;

namespace CandidateManagement_TranThanhHiep.Pages.CandidateCRUD
{
    public class CreateModel : PageModel
    {
        private ICandidateProfileRepo candidateProfileRepo;

        public IList<JobPosting> JobPostings { get; set; }

        [BindProperty]
        public string Msg { get; set; }

        public SelectList PostingIds { get; set; }

        [BindProperty]
        public CandidateProfile CandidateProfile { get; set; }

        public CreateModel()
        {
            candidateProfileRepo = new CandidateProfileRepo();
            JobPostings = candidateProfileRepo.getJobList();
            PostingIds = new SelectList(JobPostings, "PostingId", "JobPostingTitle");
        }

        public void OnGet()
        {
            
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public IActionResult OnPost()
        {
            ModelState.Clear();
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if(candidateProfileRepo.getCandidateProfileById(CandidateProfile.CandidateId) == null)
            {
                candidateProfileRepo.AddCandidate(CandidateProfile);
                return RedirectToPage("./Index");
            }else
            {
                Msg = "Candidate duplicate!";
                return Page();
            }
                       
        }
       
    }
}
