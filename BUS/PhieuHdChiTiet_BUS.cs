using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class PhieuHdChiTiet_BUS
    {
        private static PhieuHdChiTiet_DAO _instance= new PhieuHdChiTiet_DAO();

        private PhieuHdChiTiet_BUS()
        {
            _instance = new PhieuHdChiTiet_DAO();
        }


        public static void Delete(DTO.PhieuHdChiTiet obj)
        {
            _instance.Delete(obj);
        }

        public static List<PhieuHdChiTiet> GetAll()
        {
            return _instance.GetAll();
        }

        public static PhieuHdChiTiet GetById(int id)
        {
            return _instance.GetById(id);
        }

        public static PhieuHdChiTiet Insert(PhieuHdChiTiet obj)
        {
            return _instance.Insert(obj);
        }

        public static void Update(PhieuHdChiTiet obj)
        {
            _instance.Update(obj);
        }
    }
}
