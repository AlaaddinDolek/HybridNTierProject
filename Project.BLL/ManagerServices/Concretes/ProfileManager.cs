using Project.BLL.ManagerServices.Abstracts;
using Project.DAL.Repositories.Concretes;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Concretes
{
    public class ProfileManager:BaseManager<AppUserProfile>,IProfileManager
    {
        ProfileRepository _pRep;
        public ProfileManager(ProfileRepository pRep):base(pRep)
        {
            _pRep = pRep;
        }
    }
}
