using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using DTO;

namespace DAO
{
    public class KhDao
    {
        public void Delete(Kh obj)
        {
            using (var db = new QLBH_WinDBContext())
            {
                db.Khs.Attach(obj);
                db.Khs.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<Kh> GetAll()

        {
            using (var db = new QLBH_WinDBContext())
            {
                return db.Khs.ToList();
            }
        }

        public Kh GetById(int id)
        {
            using (var db = new QLBH_WinDBContext())
            {
                return db.Khs.Find(id);
            }
        }

        public Kh Insert(Kh obj)
        {
            using (var db = new QLBH_WinDBContext())
            {
                db.Khs.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(Kh obj)
        {
            using (var db = new QLBH_WinDBContext())
            {
                db.Khs.Attach(obj);
                db.Entry(obj).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}