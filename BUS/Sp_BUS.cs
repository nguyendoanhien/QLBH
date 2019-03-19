using System.Collections.Generic;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class Sp_BUS
    {
        private static readonly SpDao Sp;
        private static Sp_BUS _instance;

        static Sp_BUS()
        {
            Sp = new SpDao();
        }

        public static Sp_BUS Instance
        {
            get
            {
                if (_instance == null) _instance = new Sp_BUS();
                return _instance;
            }
            private set => _instance = value;
        }

        public static void Delete(Sp obj)
        {
            Sp.Delete(obj);
        }

        public static List<Sp> GetAll()
        {
            return Sp.GetAll();
        }

        public static Sp GetById(int id)
        {
            return Sp.GetById(id);
        }

        public static Sp Insert(Sp obj)
        {
            return Sp.Insert(obj);
        }


        public void Sua(DataGridView data, int masp, string tensp, int maloaisp, int mancc, int dongia)
        {
            data.DataSource = SpDao.Instance.Sua(masp, tensp, maloaisp, mancc, dongia);
        }

        public void Them(DataGridView data, string tensp, int maloaisp, int mancc, int dongia)
        {
            data.DataSource = SpDao.Instance.Them(tensp, maloaisp, mancc, dongia);
        }

        public void Tim(DataGridView data, string name)
        {
            data.DataSource = SpDao.Instance.Tim(name).DataSource;
        }

        public void Timkiem(DataGridView data, string tensp)
        {
            data = SpDao.Instance.Timkiem(data, tensp);
        }

        public static void Update(Sp obj)
        {
            Sp.Update(obj);
        }

        public void Xem(DataGridView data)
        {
            data = SpDao.Instance.Xem(data);
        }

        public void Xem_Hang(DataGridView data)
        {
            data = SpDao.Instance.Xem_Hang(data);
        }

        public bool Xoa(DataGridView data, int masp)
        {
            return SpDao.Instance.Xoa(masp);
        }
    }
}