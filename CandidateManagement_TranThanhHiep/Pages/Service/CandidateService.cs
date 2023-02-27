using CandidateManagement_TranThanhHiep.Repo.DataAccess;
using CandidateManagement_TranThanhHiep.Repo.Models;
using Newtonsoft.Json;
using IHostingEnvironment = Microsoft.Extensions.Hosting.IHostingEnvironment;

namespace CandidateManagement_TranThanhHiep.Pages.Service
{
    public class CandidateService : ICandidateService
    {

        private CandidateManagementContext candidateManagementContext;

        ///  private readonly IHostingEnvironment _hostingEnvironment;
        public CandidateService()
        {
            candidateManagementContext = new CandidateManagementContext();
        }
        public async Task<List<CandidateProfile>> GetPaginatedResult(int currentPage, int pageSize = 10)
        {
            var data = await GetData();
            return data.OrderBy(d => d.CandidateId).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }

        public async Task<int> GetCount()
        {
            var data = await GetData();
            return data.Count;
        }

        private async Task<List<CandidateProfile>> GetData()
        {
            return candidateManagementContext.CandidateProfiles.ToList();
        }
    }
}
