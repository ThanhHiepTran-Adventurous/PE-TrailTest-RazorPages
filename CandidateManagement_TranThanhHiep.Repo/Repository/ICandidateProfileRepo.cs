using CandidateManagement_TranThanhHiep.Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement_TranThanhHiep.Repo.Repository;

    public interface ICandidateProfileRepo
    {
        List<CandidateProfile> GetCandidateProfiles();


        void AddCandidate(CandidateProfile candidateProfileRequest);


        CandidateProfile FindCandidate(string id);


        void UpdateCandidate(CandidateProfile candidateProfileRequest);

        List<CandidateProfile> searchByFullName(string fullName);

        List<CandidateProfile> searchByBirthDay(string birthDay);


        IList<JobPosting> getJobList();


        List<CandidateProfile> searchByFullNameAndBirthDay(string fullName, DateTime birthDay);


        void deleteCandidate(string candidateId);


        void updateCandidate(CandidateProfile candidateProfile);


        CandidateProfile getCandidateProfileById(string id);



        public List<CandidateProfile> getCandidatesPages(int pageSize, int pageIndex);

        public int getTotalCandidatesPages();
        
    }

