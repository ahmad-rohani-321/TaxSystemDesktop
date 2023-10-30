using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using TaxSystem.Domain;
using TaxSystem.Domain.Entities;

namespace TaxSystem.Application
{
    public static class Owners
    {
        #region Add or Edit
        public static bool AddOwner(Domain.Entities.Owners owner)
        {
            bool result = true;
            MainDbContext db = new MainDbContext();
            try
            {
                db.Owners.Add(owner);
                db.SaveChanges();
            }
            catch
            {
                result = false;
            }
            finally
            {
                db.Dispose();
            }
            return result;
        }
        public static bool EditOwner(Domain.Entities.Owners owners)
        {
            bool result = true;
            MainDbContext db = new MainDbContext();
            try
            {
                var row = db.Owners.SingleOrDefault(x => x.Id == owners.Id);
                row.FirstName = owners.FirstName;
                row.LastName = owners.LastName;
                row.FatherName = owners.FatherName;
                row.GrandFatherName = owners.GrandFatherName;
                row.NationalID = owners.NationalID;
                row.PageNo = owners.PageNo;
                row.JuldNo = owners.JuldNo;
                db.SaveChanges();
            }
            catch
            {
                result = false;
            }
            finally
            {
                db.Dispose();
            }
            return result;
        }
        public static bool ChangeDeleteStatus(int id, bool status)
        {
            bool result = true;
            MainDbContext db = new MainDbContext();
            try
            {
                db.Owners.SingleOrDefault(x => x.Id == id).IsDeleted = status;
                db.SaveChanges();
            }
            catch
            {
                result = false;
            }
            finally { db.Dispose(); }
            return result;
        }
        #endregion

        #region Selection
        public static List<Domain.Entities.Owners> GetAll()
        {
            List<Domain.Entities.Owners> list = new List<Domain.Entities.Owners>();
            MainDbContext db = new MainDbContext();
            try
            {
                list = db.Owners.Where(x => !x.IsDeleted).Take(50).ToList();
            }
            catch
            {
            }
            finally
            {
                db.Dispose();
            }
            return list;
        }

        public static List<Domain.Entities.Owners> GetAllDeletedOwners()
        {
            List<Domain.Entities.Owners> list = new List<Domain.Entities.Owners>();
            Domain.MainDbContext db = new MainDbContext();
            try
            {
                list = db.Owners.Where(x => x.IsDeleted).Take(50).ToList();
            }
            catch
            {
            }
            finally { db.Dispose(); }
            return list;
        }
        public static List<Domain.Entities.Owners> GetBySearch(string search)
        {
            List<Domain.Entities.Owners> ownerList = new List<Domain.Entities.Owners>();
            Domain.MainDbContext db = new MainDbContext();
            try
            {
                ownerList = db
                    .Owners
                    .Where(x => !x.IsDeleted && x.FirstName.Contains(search))
                    .Take(50)
                    .ToList();
            }
            catch
            {
            }
            finally { db.Dispose(); }
            return ownerList;
        }

        public static Domain.Entities.Owners GetByIdOrNationalId(string text)
        {
            Domain.Entities.Owners owner = new Domain.Entities.Owners();
            MainDbContext db = new MainDbContext();
            try
            {
                owner = db.Owners.FirstOrDefault(x => x.NationalID == text);
            }
            catch
            {
                owner = null;
            }
            finally { db.Dispose(); }
            return owner;
        }
        #endregion
    }
}