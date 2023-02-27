using CandidateManagement_TranThanhHiep.Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement_TranThanhHiep.Repo.DataAccess;

    public class HRAccountContext
    {
    
    private CandidateManagementContext candidateManagementContext;
    
    public HRAccountContext()
    {
        candidateManagementContext = new CandidateManagementContext();
    }


    public IList<Hraccount> GetUser()
    {
        return candidateManagementContext.Hraccounts.ToList();
    }

}

