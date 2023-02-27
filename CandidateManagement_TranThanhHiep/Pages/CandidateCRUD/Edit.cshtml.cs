﻿using CandidateManagement_TranThanhHiep.Repo.Models;
using CandidateManagement_TranThanhHiep.Repo.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CandidateManagement_TranThanhHiep.Pages.CandidateCRUD;

public class EditModel : PageModel
{

    private ICandidateProfileRepo candidateProfileRepo;

    private readonly ILogger<EditModel> _logger;

    public IList<JobPosting> JobPostings { get; set; }

    [BindProperty]
    public string Msg { get; set; }

    public SelectList PostingIds { get; set; }

    [BindProperty]
    public CandidateProfile CandidateProfile { get; set; }

    public EditModel(ILogger<EditModel> logger)
    {
        candidateProfileRepo = new CandidateProfileRepo();
        JobPostings = candidateProfileRepo.getJobList();
        PostingIds = new SelectList(JobPostings, "PostingId", "JobPostingTitle");
        _logger = logger;
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
            ModelState.Clear();
            if (!ModelState.IsValid)
            {
                //foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                //{
                //    // Xử lý thông báo lỗi tại đây
                //    Console.WriteLine(error);
                //}
                return Page();
            }
            candidateProfileRepo.updateCandidate(CandidateProfile);
            return RedirectToPage("./Index");
        }
        catch (Exception ex)
        {
            Msg = ex.Message;
            return Page();
        }
    }
}