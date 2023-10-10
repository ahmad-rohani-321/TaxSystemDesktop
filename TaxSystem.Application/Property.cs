using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using TaxSystem.Domain;
using TaxSystem.Domain.Entities;
namespace TaxSystem.Application
{
    public static class Property
    {
        #region PropertyRegion
        public static bool AddProperty(PropertyInfo info)
        {
            bool result = true;
            MainDbContext db = new MainDbContext();
            try
            {
                db.PropertyInfo.Add(info);
                db.SaveChanges();
            }
            catch 
            {
                result = false;
            }
            finally { db.Dispose(); }
            return result;
        }
        public static bool AddProperty(PropertyInfo info, CurrentOwners owner)
        {
            bool result = true;
            MainDbContext db = new MainDbContext();
            try
            {
                var addedInfo = db.PropertyInfo.Add(info);
                db.Database.ExecuteSqlCommand("UPDATE dbo.CurrentOwners SET IsCurrent = @BooleanValue", new SqlParameter("@BooleanValue", false));
                owner.PropertyOwnerId = addedInfo.Id;
                db.CurrentOwners.Add(owner);
                db.SaveChanges();
            }
            catch
            {
                result = false;
            }
            finally { db.Dispose(); }
            return result;
        }
        public static bool UpdateProperty(PropertyInfo info)
        {
            bool result = true;
            MainDbContext db = new MainDbContext();
            try
            {
                PropertyInfo row = db.PropertyInfo.SingleOrDefault(x => x.Id == info.Id);
                row = info;
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
        #endregion

        #region Curret Owner Phone Number Region
        public static bool AddCurrentOwnerPhone(CurrentOwners owner)
        {
            bool result = true;
            MainDbContext db = new MainDbContext();
            try
            {
                db.Database.ExecuteSqlCommand("UPDATE dbo.CurrentOwners SET IsCurrent = @BooleanValue", new SqlParameter("@BooleanValue", false));
                db.CurrentOwners.Add(owner);
                db.SaveChanges();
            }
            catch
            {
                result = false;
            }
            finally { db.Dispose(); }
            return result;
        }
        public static List<CurrentOwners> GetCurrentOwner(int Owner)
        {
            List<CurrentOwners> values = new List<CurrentOwners>();
            MainDbContext db = new MainDbContext();
            try
            {
                values = db.CurrentOwners.Where(x => x.PropertyOwnerId == Owner).ToList();
            }
            catch 
            {
            }
            finally { db.Dispose(); }
            return values;
        }
        #endregion
    }
}
