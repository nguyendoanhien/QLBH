using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DTO;

namespace DAO
{
    public class GioHangDao
    {
        public void Delete(GioHang obj)
        {
            using (var db = new QLBH_WinDBContext())
            {
                db.GioHangs.Attach(obj);
                db.GioHangs.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<GioHang> GetAll()
        {
            using (var db = new QLBH_WinDBContext())
            {
                return db.GioHangs.ToList();
            }
        }

        public GioHang GetById(int id)
        {
            using (var db = new QLBH_WinDBContext())
            {
                return db.GioHangs.Find(id);
            }
        }

        public GioHang Insert(GioHang obj)
        {
            using (var db = new QLBH_WinDBContext())
            {
                db.GioHangs.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(GioHang obj)
        {
            using (var db = new QLBH_WinDBContext())
            {
                db.GioHangs.Attach(obj);
                db.Entry(obj).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}