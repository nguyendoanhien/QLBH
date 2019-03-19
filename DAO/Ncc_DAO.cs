#region

using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using DTO;

#endregion

namespace DAO
{
    public class Ncc_DAO
    {
        private static Ncc_DAO _instance;
        private static Ncc_DAO instance;
        private readonly QLBH_WinDBContext _db = new QLBH_WinDBContext();

        private List<Ncc> _ncc = new List<Ncc>();


        private readonly QLBH_WinDBContext db = new QLBH_WinDBContext();

        public static Ncc_DAO Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Ncc_DAO();
                return _instance;
            }
        }

        public void Delete(Ncc obj)
        {
            using (var db = new QLBH_WinDBContext())
            {
                db.Nccs.Attach(obj);
                db.Nccs.Remove(obj);
                db.SaveChanges();
            }
        }

        public bool Delete(int mancc)
        {
            var del = new Ncc();
            var data = new DataGridView();
            using (var db = new QLBH_WinDBContext())
            {
                try
                {
                    del = db.Nccs.Where(p => p.MaNcc.Equals(mancc)).SingleOrDefault();
                    db.Nccs.Attach(del);
                    db.Nccs.Remove(del);
                    db.SaveChanges();
                }
                catch
                {
                    return true;
                }
            }

            return false;
        }

        public bool Edit(int mancc, string tenncc)
        {
            var edit = new Ncc();
            using (var db = new QLBH_WinDBContext())
            {
                edit = db.Nccs.Where(p => p.MaNcc.Equals(mancc)).SingleOrDefault();
                edit.TenNcc = tenncc;

                db.Nccs.Attach(edit);
                db.Entry(edit).State = EntityState.Modified;
                db.SaveChanges();
            }

            return false;
        }

        public List<Ncc> GetAll()
        {
            using (var db = new QLBH_WinDBContext())
            {
                return db.Nccs.Include("Sps").ToList();
            }
        }

        public Ncc GetById(int id)
        {
            using (var db = new QLBH_WinDBContext())
            {
                return db.Nccs.Find(id);
            }
        }

        public Ncc Insert(Ncc obj)
        {
            using (var db = new QLBH_WinDBContext())
            {
                db.Nccs.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public bool Them(string tenncc)
        {
            var them = new Ncc();
            using (var db = new QLBH_WinDBContext())
            {
                try
                {
                    them.TenNcc = tenncc;
                    db.Nccs.Add(them);
                    db.SaveChanges();
                }
                catch
                {
                    return true;
                }
            }

            return false;
        }

        public void Update(Ncc obj)
        {
            using (var db = new QLBH_WinDBContext())
            {
                db.Nccs.Attach(obj);
                db.Entry(obj).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<Ncc> Xem()
        {
            return _db.Nccs.ToList();
        }

        public DataGridView Xem_Hang(DataGridView data)
        {
            data.DataSource = (from a in db.Nccs
                select new
                {
                    Mã_Nhà_Cung_Cấp = a.MaNcc,
                    Tên_Nhà_Cung_Cấp = a.TenNcc
                }).ToList();
            return data;
        }
    }
}