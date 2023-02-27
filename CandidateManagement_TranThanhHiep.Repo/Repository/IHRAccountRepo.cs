using CandidateManagement_TranThanhHiep.Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement_TranThanhHiep.Repo.Repository;
    public interface IHRAccountRepo
    {
        IList<Hraccount> GetUserHraccounts();

        
    }

