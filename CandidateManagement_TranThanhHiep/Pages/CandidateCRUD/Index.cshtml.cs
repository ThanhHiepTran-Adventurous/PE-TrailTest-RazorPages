using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CandidateManagement_TranThanhHiep.Repo.Models;
using CandidateManagement_TranThanhHiep.Repo.Repository;
using CandidateManagement_TranThanhHiep.Repo.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
namespace CandidateManagement_TranThanhHiep.Pages.CandidateCRUD;

public class IndexModel : PageModel
{
    private ICandidateProfileRepo candidateProfileRepo;

   // private readonly ICandidateService _candidateService;
    private CandidateProfileContext candidateProfileContext;
    private CandidateManagementContext candidateManagementContext = new CandidateManagementContext();

    private readonly ILogger<IndexModel> _logger;

    public IndexModel()
    {
        //_logger = logger;
        //    candidateProfileRepo = new CandidateProfileRepo();
        //  candidateProfileContext = new CandidateProfileContext();
      //  candidateManagementContext = _db;
        // _candidateService = candidateService;
    }

    [BindProperty]
    public string fullName { get; set; }

    [BindProperty]
    public DateTime birthDay { get; set; }

   

    [BindProperty]
    public string Msg { get; set; }


    [BindProperty]
    public List<CandidateProfile> CandidateProfile { get; set; }

    public int totalCandidate { get; set; }
    
    public int pageNo { get; set; }

    public int pageSize { get; set; }







    //public int CurrentPage { get; set; } = 1;


    //public int PageSize { get; set; } = 3;



    //public int TotalPages { get; set; }


    //public bool HasPreviousPage
    //{
    //    get { return (CurrentPage > 1); }
    //}

    //public bool HasNextPage
    //{
    //    get { return (CurrentPage < TotalPages); }
    //}

    //public int PreviousPage
    //{
    //    get { return (CurrentPage - 1); }
    //}

    //public int NextPage
    //{
    //    get { return (CurrentPage + 1); }
    //} 


    public void OnGet(int p = 1, int s = 3)
    {
        if (HttpContext.Session.GetString("email") == null)
        {
            Response.Redirect("/Login");
        }

        CandidateProfile = candidateManagementContext.CandidateProfiles.Skip((p -1) * s).Take(s).ToList();
        pageSize = s;
        totalCandidate = candidateManagementContext.CandidateProfiles.Count();
        pageNo = p;

        //if(page != null)
        //{
        //    CurrentPage = (int)page;
        //}


        //var data = await _candidateManagementContext.CandidateProfiles
        //   .OrderBy(c => c.CandidateId)
        //   .Skip((CurrentPage - 1) * PageSize)
        //   .Take(PageSize)
        //   .ToListAsync();

        //var count = await _candidateManagementContext.CandidateProfiles.CountAsync();

        //TotalPages = (int)Math.Ceiling(count/ (double)PageSize);

        //CandidateProfile = data;

        // CandidateProfile = candidateProfileRepo.GetCandidateProfiles();
    }


    //public IActionResult OnPostSearch()
    //{
    //    string search = Request.Form["txtSearch"];
    //    string type = Request.Form["type"];
    //    if (search != null && type.Equals("1"))
    //    {
    //        CandidateProfile = candidateProfileRepo.searchByFullName(search);
    //        return Page();
    //    }
    //    else if (search != null && type.Equals("2"))
    //    {
    //        CandidateProfile = candidateProfileRepo.searchByBirthDay(search);
    //        return Page();

    //    }
    //    CandidateProfile = candidateProfileRepo.GetCandidateProfiles();
    //    return Page();
    //}

}

