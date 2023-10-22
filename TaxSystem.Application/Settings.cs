using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxSystem.Domain.Entities;
using TaxSystem.Domain;
using System.Reflection.Emit;

namespace TaxSystem.Application
{
    public static class Settings
    {

        #region Property Level
        public static bool AddLevel(string levelName)
        {
            bool result = true;
            MainDbContext db = new MainDbContext();
            try
            {
                db.PropertyLevel.Add(new PropertyLevel() { LevelName = levelName });
                db.SaveChanges();
            }
            catch
            {
                result = false;
            }
            finally { db.Dispose(); }
            return result;
        }
        public static bool UpdateLevels(PropertyLevel level)
        {
            bool result = true;
            MainDbContext db = new MainDbContext();
            try
            {
                db.PropertyLevel.Add(level);
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
            { }
            finally { db.Dispose(); }
            return list;
        }
        #endregion

        #region Property Payment Period
        public static bool AddPaymentPeriod(string payName)
        {
            bool result = true;
            MainDbContext db = new MainDbContext();
            try
            {
                db.PaymentPeriods.Add(new PaymentPeriods() { TypeName = payName });
                db.SaveChanges();
            }
            catch
            {
                result = false;
            }
            finally { db.Dispose(); }
            return result;
        }
        public static bool UpdatePaymentPeriod(PaymentPeriods pay)
        {
            bool result = true;
            MainDbContext db = new MainDbContext();
            try
            {
                var item = db.PaymentPeriods.SingleOrDefault(p => p.Id == pay.Id);
                item.TypeName = pay.TypeName;
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
