using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DTO;

namespace DAO
{
    public class SpLoaiDao
    {
        public void Delete(SpLoai obj)
        {
            using (var db = new QLBH_WinDBContext())
            {
                db.SpLoais.Attach(obj);
                db.SpLoais.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<SpLoai> GetAll()
        {
            using (var db = new QLBH_WinDBContext())
            {
                return db.SpLoais.Include("Sps").ToList();
            }
        }

        public SpLoai GetById(int id)
        {
            using (var db = new QLBH_WinDBContext())
            {
                return db.SpLoais.Find(id);
            }
        }

        public SpLoai Insert(SpLoai obj)
        {
            using (var db = new QLBH_WinDBContext())
            {
                db.SpLoais.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(SpLoai obj)
        {
            using (var db = new QLBH_WinDBContext())
            {
                db.SpLoais.Attach(obj);
                db.Entry(obj).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}