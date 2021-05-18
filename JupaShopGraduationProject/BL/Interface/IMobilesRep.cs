using JupaShopGraduationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JupaShopGraduationProject.BL.Interface
{
    public interface IMobilesRep
    {
        IQueryable<MobilesVM> Get();
        MobilesVM GetById(int id);
        void Add(MobilesVM mob);
        void Edit(MobilesVM mob);
        void Delete(int id);
    }
}
