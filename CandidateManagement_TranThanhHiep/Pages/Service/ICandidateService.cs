using CandidateManagement_TranThanhHiep.Repo.Models;

namespace CandidateManagement_TranThanhHiep.Pages.Service
{
    public interface ICandidateService
    {
        Task<List<CandidateProfile>> GetPaginatedResult(int currentPage, int pageSize = 10);
        Task<int> GetCount();
    }
}
