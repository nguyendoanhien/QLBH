using System.Collections.Generic;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class PhieuHd_BUS
    {
        private static PhieuHd_DAO _instance;

        private PhieuHd_BUS()
        {
            _instance=new PhieuHd_DAO();
        }

  
        public static PhieuHd_DAO Instance
        {
            get
            {
                if (_instance == null) _instance = new PhieuHd_DAO();
                return _instance;
            }
            private set => _instance = value;
        }

        public static void Loadct(DataGridView data)
        {
            data.DataSource = PhieuHd_DAO.Instance.Load();
        }
        public bool Laphdct(int masp, int sl, int dg)
        {
            return PhieuHd_DAO.Instance.Laphdct(masp, sl, dg);
        }

        public bool Laphd()
        {
            return PhieuHd_DAO.Instance.Laphd();
        }

        public static void Delete(PhieuHd obj)
        {
            Instance.Delete(obj);
        }

        public static List<PhieuHd> GetAll()
        {
            return _instance.GetAll();
        }

        public static PhieuHd GetById(int id)
        {
            return _instance.GetById(id);
        }

        public static PhieuHd Insert(PhieuHd obj)
        {
            return Instance.Insert(obj);
        }

        public static void Update(PhieuHd obj)
        {
            Instance.Update(obj);
        }

    }
}