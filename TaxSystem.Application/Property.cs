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

        #region Property Level
        public static bool AddLevels()
        {
            bool result = true;
            MainDbContext db = new MainDbContext();
            try
            {
                var d = db.PropertyLevel.AddRange(
                    new List<Domain.Entities.PropertyLevel>()
                    {
                        new Domain.Entities.PropertyLevel()
                        {
                            Id = 1, LevelName = "لومړی درجه"
                        },
                        new Domain.Entities.PropertyLevel()
                        {
                            Id = 2, LevelName = "دوهمه درجه"
                        },
                        new Domain.Entities.PropertyLevel()
                        {
                            Id = 3, LevelName = "درېیمه درجه"
                        },
                        new Domain.Entities.PropertyLevel()
                        {
                            Id = 4, LevelName = "څلورمه درجه"
                        }
                    }
                    );
                db.SaveChanges();
            }
            catch 
            {
                result = false;
            }
            finally { db.Dispose(); }
            return result;
        }
        public static List<PropertyLevel> GetLevels()
        {
            List<PropertyLevel> list = new List<PropertyLevel>();
            MainDbContext db = new MainDbContext();
            try
            {
                list = db.PropertyLevel.ToList();
            }
            catch 
            {}
            finally { db.Dispose(); }
            return list;
        }
        #endregion

        #region Property Payment Period
        public static bool AddPaymentPeriods()
        {
            bool result = true;
            MainDbContext db = new MainDbContext();
            try
            {
                _ = db.PaymentPeriods.AddRange(
                    new List<PaymentPeriods>()
                    {
                        new PaymentPeriods()
                        {
                            Id= 1, TypeName = "کلني"
                        },
                        new PaymentPeriods()
                        {
                            Id= 2, TypeName = "ربعوار"
                        },
                        new PaymentPeriods()
                        {
                            Id= 3, TypeName = "میاشتنی"
                        }
                    }
                    );
                db.SaveChanges();
            }
            catch 
            {
                result = false;
            }
            finally { db.Dispose(); }
            return result;
        }
        public static List<PaymentPeriods> GetPaymentPeriods()
        {
            List<PaymentPeriods> periods = new List<PaymentPeriods>();
            MainDbContext db = new MainDbContext();
            try
            {
                periods = db.PaymentPeriods.ToList();
            }
            catch 
            {
            }
            finally { db.Dispose(); }
            return periods;
        }
        #endregion
    }
}
