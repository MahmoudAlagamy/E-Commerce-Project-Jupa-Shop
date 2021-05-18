using AutoMapper;
using JupaShopGraduationProject.BL.Helper;
using JupaShopGraduationProject.BL.Interface;
using JupaShopGraduationProject.DAL.Database;
using JupaShopGraduationProject.DAL.Entities;
using JupaShopGraduationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JupaShopGraduationProject.BL.Repository
{
    public class MobilesRep : IMobilesRep
    {
        private readonly DbContainer db;
        private readonly IMapper mapper;

        public MobilesRep(DbContainer db, IMapper _mapper)
        {
            this.db = db;
            mapper = _mapper;
        }

        public void Add(MobilesVM mob)
        {
            var data = mapper.Map<Mobiles>(mob);

            //var path = "/wwwroot/Files/Photos/";
            data.ImageName = UploadeFileHelper.SaveFile(mob.ImageUrl, "Mobiles/");
            db.Mobiles.Add(data);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var deletedObject = db.Mobiles.Find(id);

            db.Mobiles.Remove(deletedObject);

            UploadeFileHelper.RemoveFile("Mobiles/", deletedObject.ImageName);
            db.SaveChanges();
        }

        public void Edit(MobilesVM mob)
        {
            var data = mapper.Map<Mobiles>(mob);
            db.Entry(data).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            db.SaveChanges();
        }

        public IQueryable<MobilesVM> Get()
        {
            IQueryable<MobilesVM> data = GetAllmobs();

            return data;
        }

        public MobilesVM GetById(int id)
        {
            MobilesVM data = GetMobilesById(id);
            // FirstOrDefault couse if not found id back null
            return data;
        }

        // Refactor
        private IQueryable<MobilesVM> GetAllmobs()
        {
            return db.Mobiles.Select(a => new MobilesVM
            {
                Id = a.Id,
                Prand = a.Prand,
                Details = a.Details,
                Price = a.Price,
                Descount = a.Descount,

                // Upload Files
                ImageName = a.ImageName

            });
        }

        private MobilesVM GetMobilesById(int id)
        {
            return db.Mobiles.Where(a => a.Id == id)
            .Select(a => new MobilesVM
            {
                Id = a.Id,
                Prand = a.Prand,
                Details = a.Details,
                Price = a.Price,
                Descount = a.Descount,

                // Upload Files
                ImageName = a.ImageName

            }).FirstOrDefault();
        }
    }
}
