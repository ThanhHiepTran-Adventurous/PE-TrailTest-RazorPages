using CandidateManagement_TranThanhHiep.Repo.DataAccess;
using CandidateManagement_TranThanhHiep.Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement_TranThanhHiep.Repo.Repository
{
    public class CandidateProfileRepo : ICandidateProfileRepo
    {
        private CandidateProfileContext candidateProfileContext;

        public CandidateProfileRepo()
        {
            candidateProfileContext = new CandidateProfileContext();
        }

        public void AddCandidate(CandidateProfile candidateProfileRequest)
        {
            candidateProfileContext.AddCandidate(candidateProfileRequest);
        }

        public void deleteCandidate(string candidateId)
        {
            candidateProfileContext.deleteCandidate(candidateId);
        }

        public CandidateProfile FindCandidate(string id)
        {
          return candidateProfileContext.FindCandidate(id);
        }

        public CandidateProfile getCandidateProfileById(string id)
        {
            return candidateProfileContext.getCandidateById(id);
        }

        public List<CandidateProfile> GetCandidateProfiles()
        {
            return candidateProfileContext.GetCandidateProfiles();
        }

        public IList<CandidateProfile> getCandidatesPages(int pageSize, int pageIndex)
        {
            return candidateProfileContext.getCanidatePages(pageSize, pageIndex);
        }

        public IList<JobPosting> getJobList()
        {
            return candidateProfileContext.getJobList();
        }

        public int getTotalCandidatesPages()
        {
            return candidateProfileContext.getTotalCandidatePages();
        }

        public List<CandidateProfile> searchByBirthDay(string birthDay)
        {
            return candidateProfileContext.searchByBirthDay(birthDay);
        }

        public List<CandidateProfile> searchByFullName(string fullName)
        {
            return candidateProfileContext.searchByFullName(fullName);
        }

        public List<CandidateProfile> searchByFullNameAndBirthDay(string fullName, DateTime birthDay)
        {
            return candidateProfileContext.searchByFullNameAndBirthDay(fullName, birthDay);
        }

        public void UpdateCandidate(CandidateProfile candidateProfileRequest)
        {
            candidateProfileContext.UpdateCandidate(candidateProfileRequest);
        }

        public void updateCandidate(CandidateProfile candidateProfile)
        {
            candidateProfileContext.Update(candidateProfile);
        }

        List<CandidateProfile> ICandidateProfileRepo.getCandidatesPages(int pageSize, int pageIndex)
        {
            throw new NotImplementedException();
        }
    }
}
