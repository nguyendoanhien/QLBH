#region

using System.Collections.Generic;
using System.Windows.Forms;
using DAO;
using DTO;

#endregion

namespace BUS
{
    public class Ncc_BUS
    {
        private static readonly Ncc_DAO Ncc;

        private static Ncc_BUS _instance;


        private static Ncc_BUS instance;


        static Ncc_BUS()
        {
            Ncc = new Ncc_DAO();
        }

        private Ncc_BUS()
        {
        }

        public static Ncc_BUS Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Ncc_BUS();
                return _instance;
            }
        }

        public static void Delete(Ncc obj)
        {
            Ncc.Delete(obj);
        }

        public void Edit(DataGridView data, int macc, string tenncc)
        {
            data.DataSource = Ncc_DAO.Instance.Edit(macc, tenncc);
        }

        public static List<Ncc> GetAll()
        {
            return Ncc.GetAll();
        }

        public static Ncc GetById(int id)
        {
            return Ncc.GetById(id);
        }

        public static Ncc Insert(Ncc obj)
        {
            return Ncc.Insert(obj);
        }

        public void Them(DataGridView data, string tenncc)
        {
            data.DataSource = Ncc_DAO.Instance.Them(tenncc);
        }

        public static void Update(Ncc obj)
        {
            Ncc.Update(obj);
        }

        public void Xem(DataGridView data)
        {
            data.DataSource = Ncc_DAO.Instance.Xem();
        }


        public void Xem_Hang(DataGridView data)
        {
            data.DataSource = Ncc_DAO.Instance.Xem_Hang(data).DataSource;
        }

        public bool Xoa(DataGridView data, int ma)
        {
            return Ncc_DAO.Instance.Delete(ma);
        }
    }
}