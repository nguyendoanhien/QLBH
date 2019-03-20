using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms.VisualStyles;
using DTO;

namespace DAO
{
    public class PhieuHd_DAO
    {
        private static PhieuHd_DAO _instance;
        private readonly QLBH_WinDBContext _db = new QLBH_WinDBContext();
        public static PhieuHd_DAO Instance
        {
            get
            {
                if (_instance == null) _instance = new PhieuHd_DAO();
                return _instance;
            }
            private set => _instance = value;
        }
        public bool Laphdct(int masp, int sl, int dg)
        {
            var phd = new PhieuHdChiTiet();
            var pTempt = new PhieuHd();
            pTempt = _db.PhieuHds.ToList().LastOrDefault();
            phd.MaPhieuHd = pTempt.MaPhieuHd;
            phd.MaSp = masp;
            phd.SoLuong = sl;
            phd.ThanhTien = sl * dg;
            _db.PhieuHdChiTiets.Add(phd);
            _db.SaveChanges();
            return true;
        }

        public bool Laphd()
        {
            DateTime n = DateTime.Now;
            var p = new PhieuHd();
            p.NgayLap = n;
            _db.PhieuHds.Add(p);
            _db.SaveChanges();
            return true;
        }

        public bool Suahd(int makh, int manv)
        {
            PhieuHd hd = new PhieuHd();
            try
            {
                hd.MaKh = makh;
                hd.MaNv = manv;
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<PhieuHdChiTiet> Load()
        {
            var pTempt = new PhieuHd();
            pTempt = _db.PhieuHds.ToList().LastOrDefault();
            return _db.PhieuHdChiTiets.Where(p => p.MaPhieuHd == pTempt.MaPhieuHd).ToList();
        }

        public List<PhieuHd> GetAll()
        {
            using (var db = new QLBH_WinDBContext())
            {
                return db.PhieuHds.ToList();
            }
        }

        public PhieuHd GetById(int id)
        {
            using (var db = new QLBH_WinDBContext())
            {
                return db.PhieuHds.Find(id);
            }
        }

        public PhieuHd Insert(PhieuHd obj)
        {
            using (var db = new QLBH_WinDBContext())
            {
                db.PhieuHds.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(PhieuHd obj)
        {
            using (var db = new QLBH_WinDBContext())
            {
                db.PhieuHds.Attach(obj);
                db.Entry(obj).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public static void Update111(PhieuHd obj)
        {
            using (var db = new QLBH_WinDBContext())
            {
                db.PhieuHds.Attach(obj);
                db.Entry(obj).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void Delete(PhieuHd obj)
        {
            using (var db = new QLBH_WinDBContext())
            {
                db.PhieuHds.Attach(obj);
                db.PhieuHds.Remove(obj);
                db.SaveChanges();
            }
        }

        public bool sua(int id, int makh, int manv, int ck, string tt)
        {
            try
            {
                PhieuHd hd = new PhieuHd();
                hd = _db.PhieuHds.Where(p => p.MaPhieuHd == id).SingleOrDefault();
                hd.MaKh = makh;
                hd.MaNv = manv;
                hd.PhanTramGiam = ck;
                hd.TienGiam = tt;
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}