using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
   public class PhieuHdChiTiet_DAO
    {
        private static readonly PhieuHdChiTiet Kh;

        static PhieuHdChiTiet_DAO()
        {
            Kh = new PhieuHdChiTiet();
        }
        public List<PhieuHdChiTiet> GetAll()
        {
            using (var db = new QLBH_WinDBContext())
            {
                return db.PhieuHdChiTiets.ToList();
            }
        }

        public PhieuHdChiTiet GetById(int id)
        {
            using (var db = new QLBH_WinDBContext())
            {
                return db.PhieuHdChiTiets.Find(id);
            }
        }

        public PhieuHdChiTiet Insert(PhieuHdChiTiet obj)
        {
            using (var db = new QLBH_WinDBContext())
            {
                db.PhieuHdChiTiets.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(PhieuHdChiTiet obj)
        {
            using (var db = new QLBH_WinDBContext())
            {
                db.PhieuHdChiTiets.Attach(obj);
                db.Entry(obj).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(PhieuHdChiTiet obj)
        {
            using (var db = new QLBH_WinDBContext())
            {
                db.PhieuHdChiTiets.Attach(obj);
                db.PhieuHdChiTiets.Remove(obj);
                db.SaveChanges();
            }
        }
    }
}
