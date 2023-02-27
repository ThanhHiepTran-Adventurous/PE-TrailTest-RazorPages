﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CandidateManagement_TranThanhHiep.Repo.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using CandidateManagement_TranThanhHiep.Repo.Repository;

namespace CandidateManagement_TranThanhHiep.Pages.CandidateCRUD
{
    public class DeleteModel : PageModel
    {

        private ICandidateProfileRepo candidateProfileRepo;

        private readonly ILogger<EditModel> _logger;

        public IList<JobPosting> JobPostings { get; set; }

        [BindProperty]
        public string Msg { get; set; }

        public SelectList PostingIds { get; set; }

        [BindProperty]
        public CandidateProfile CandidateProfile { get; set; }
        public DeleteModel()
        {
            candidateProfileRepo = new CandidateProfileRepo();
            JobPostings = candidateProfileRepo.getJobList();
            PostingIds = new SelectList(JobPostings, "PostingId", "JobPostingTitle");
         
        }


        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidateprofile = candidateProfileRepo.getCandidateProfileById(id);
            if (candidateprofile == null)
            {
                return NotFound();
            }
            CandidateProfile = candidateprofile;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                candidateProfileRepo.deleteCandidate(CandidateProfile.CandidateId);
                return RedirectToPage("./Index");
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Page();
            }
        }

    }
}


