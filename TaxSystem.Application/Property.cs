using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
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
                row.Location = info.Location;
                row.South = info.South;
                row.North = info.North;
                row.East = info.East;
                row.West = info.West;
                row.District = info.District;
                row.Longtitude = info.Longtitude;
                row.Lantitude = info.Lantitude;
                row.Block = info.Block;
                row.Parcel = info.Parcel;
                row.PropertyLevelId = info.PropertyLevelId;
                row.PropertyOwnerId = info.PropertyOwnerId;
                row.PaymentPeriodId = info.PaymentPeriodId;
                row.TaxAmount = info.TaxAmount;
                row.LicenseNumber = info.LicenseNumber;
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
        public static bool DeleteProperty(int id, bool status)
        {
            bool result = true;
            MainDbContext db = new MainDbContext();
            try
            {
                var row = db.PropertyInfo.SingleOrDefault(x => x.Id == id);
                row.IsDeleted = status;
                db.SaveChanges();
            }
            catch 
            {
                result = false;
            }
            finally { db.Dispose(); }
            return result;
        }
        public static List<PropertyInfo> GetProperties()
        {
            List<PropertyInfo> properties = new List<PropertyInfo>();
            MainDbContext db = new MainDbContext();
            try
            {
                properties = db.PropertyInfo
                    .Include("Owner")
                    .Include("Level")
                    .Include("PaymentPeriod")
                    .Where(x => !x.IsDeleted)
                    .Take(50)
                    .ToList();
            }
            catch 
            {
            }
            finally { db.Dispose(); }
            return properties;
        }
        public static List<PropertyInfo> GetDeletedProperties()
        {
            List<PropertyInfo> properties = new List<PropertyInfo>();
            MainDbContext db = new MainDbContext();
            try
            {
                properties = db.PropertyInfo
                    .Include("Owner")
                    .Include("Level")
                    .Include("PaymentPeriod")
                    .Where(x => x.IsDeleted)
                    .Take(50)
                    .ToList();
            }
            catch 
            {
            }
            finally { db.Dispose(); }
            return properties;
        }
        #endregion

        #region Curret Owner Phone Number Region
        public static bool AddCurrentOwner(CurrentOwners owner)
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
        public static List<CurrentOwners> GetCurrentOwners(int Owner)
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
