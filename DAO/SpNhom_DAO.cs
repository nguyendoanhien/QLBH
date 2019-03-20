using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using DTO;

namespace DAO
{
    public class SpNhomDao : ISpNhomDao
    {
        public List<SpNhom> GetAll()
        {
            using (var db = new QLBH_WinDBContext())
            {
                return db.SpNhoms.ToList();
            }
        }

        public SpNhom GetById(int id)
        {
            using (var db = new QLBH_WinDBContext())
            {
                return db.SpNhoms.Find(id);
            }
        }

        public SpNhom Insert(SpNhom obj)
        {
            using (var db = new QLBH_WinDBContext())
            {
                db.SpNhoms.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(SpNhom obj)
        {
            using (var db = new QLBH_WinDBContext())
            {
                db.SpNhoms.Attach(obj);
                db.Entry(obj).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(SpNhom obj)
        {
            using (var db = new QLBH_WinDBContext())
            {
                db.SpNhoms.Attach(obj);
                db.SpNhoms.Remove(obj);
                db.SaveChanges();
            }
        }
    }
}