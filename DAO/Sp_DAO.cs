using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using DTO;

namespace DAO
{
    public class SpDao : ISpDao
    {
        private static SpDao _instance;
        private readonly QLBH_WinDBContext _db = new QLBH_WinDBContext();

        public static SpDao Instance
        {
            get => _instance ?? (_instance = new SpDao());
            private set => _instance = value;
        }

        public List<Sp> GetAll()
        {
            using (var db = new QLBH_WinDBContext())
            {
                return db.Sps.ToList();
            }
        }

        public Sp GetById(int id)
        {
            using (var db = new QLBH_WinDBContext())
            {
                return db.Sps.Find(id);
            }
        }

        public Sp Insert(Sp obj)
        {
            using (var db = new QLBH_WinDBContext())
            {
                db.Sps.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(Sp obj)
        {
            using (var db = new QLBH_WinDBContext())
            {
                db.Sps.Attach(obj);
                db.Entry(obj).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(Sp obj)
        {
            using (var db = new QLBH_WinDBContext())
            {
                db.Sps.Attach(obj);
                db.Sps.Remove(obj);
                db.SaveChanges();
            }
        }

        public bool Sua(int masp, string tensp, int maloaisp, int mancc, int dongia)
        {
            using (var db = new QLBH_WinDBContext())
            {
                var sp = db.Sps.SingleOrDefault(p => p.MaSp.Equals(masp));
                sp.TenSp = tensp;
                sp.MaLoaiSp = maloaisp;
                sp.MaNcc = mancc;
                sp.DonGia = dongia;

                db.Sps.Attach(sp);
                db.Entry(sp).State = EntityState.Modified;
                db.SaveChanges();
            }

            return false;
        }

        public bool Them(string tensp, int maloaisp, int mancc, int dongia)
        {
            var them = new Sp();
            var data = new DataGridView();
            using (var db = new QLBH_WinDBContext())
            {
                try
                {
                    them.TenSp = tensp;
                    them.MaLoaiSp = maloaisp;
                    them.MaNcc = mancc;
                    them.DonGia = dongia;
                    db.Sps.Add(them);
                    db.SaveChanges();
                }
                catch
                {
                    return true;
                }
            }

            return false;
        }

        public DataGridView Tim(string name)
        {
            var data = new DataGridView
            {
                DataSource = from s in _db.Sps
                    where s.TenSp == name
                    select new {s}
                    into table
                    from g in _db.PhieuGiaoChiTiets
                    from n in _db.PhieuNhapChiTiets
                    from c in _db.Nccs
                    from l in _db.SpLoais
                    where c.MaNcc == table.s.MaNcc && l.MaLoaiSp == table.s.MaLoaiSp && g.MaSp == table.s.MaSp &&
                          n.MaSp == table.s.MaSp
                    select new
                    {
                        table.s.MaSp,
                        table.s.TenSp,
                        c.TenNcc,
                        l.TenLoaiSp,
                        table.s.DonGia,
                        SoLuong = n.SoLuong - g.SoLuong
                    }
            };
            return data;
        }

        public DataGridView Timkiem(DataGridView data, string tensp)
        {
            data.DataSource = (from a in _db.Sps
                from b in _db.SpLoais
                from c in _db.Nccs
                where a.TenSp == tensp && a.MaLoaiSp == b.MaLoaiSp && a.MaNcc == c.MaNcc
                select new
                {
                    Mã_Sản_Phẩm = a.MaSp,
                    Tên_Sản_Phẩm = a.TenSp,
                    Mã_Loại_Sản_Phẩm = b.MaLoaiSp,
                    Mã_NhaCC = c.MaNcc,
                    Hình_SP = a.HinhSp,
                    Đơn_Giá = a.DonGia
                }).ToList();
            return data;
        }

        public DataGridView Xem(DataGridView data)
        {
            data.DataSource = (from s in _db.Sps
                from c in _db.Nccs
                from l in _db.SpLoais
                where c.MaNcc == s.MaNcc && l.MaLoaiSp == s.MaLoaiSp
                orderby s.MaSp
                select new
                {
                    s.MaSp,
                    s.TenSp,
                    c.TenNcc,
                    l.TenLoaiSp,
                    s.DonGia,
                    SoLuong = s.SoLuongTonKho
                }).ToList();
            return data;
        }

        public DataGridView Xem_Hang(DataGridView data)
        {
            data.DataSource = (from a in _db.Sps
                from b in _db.SpLoais
                from c in _db.Nccs
                where a.MaLoaiSp == b.MaLoaiSp && a.MaNcc == c.MaNcc
                select new
                {
                    Mã_Sản_Phẩm = a.MaSp,
                    Tên_Sản_Phẩm = a.TenSp,
                    Mã_Loại_Sản_Phẩm = b.MaLoaiSp,
                    Mã_NhaCC = c.MaNcc,
                    Hình_SP = a.HinhSp,
                    Đơn_Giá = a.DonGia
                }).ToList();

            return data;
        }

        public bool Xoa(int masp)
        {
            var sp = new Sp();
            var data = new DataGridView();
            using (var db = new QLBH_WinDBContext())
            {
                try
                {
                    sp = db.Sps.SingleOrDefault(p => p.MaSp.Equals(masp));
                    db.Sps.Attach(sp);
                    db.Sps.Remove(sp);
                    db.SaveChanges();
                }
                catch
                {
                    return true;
                }
            }

            return false;
        }
    }
}