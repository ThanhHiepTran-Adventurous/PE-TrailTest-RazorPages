using CandidateManagement_TranThanhHiep.Repo.DataAccess;
using CandidateManagement_TranThanhHiep.Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement_TranThanhHiep.Repo.Repository;


public class HRAccountRepo : IHRAccountRepo
{
    private HRAccountContext hRAccountContext;
    public HRAccountRepo()
    {
        hRAccountContext = new HRAccountContext();
    }


    public IList<Hraccount> GetUserHraccounts()
    {
        return hRAccountContext.GetUser();
    }

    
}
    
