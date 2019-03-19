#region

using DAO;
using DTO;

#endregion

namespace BUS
{
    public class NvBus
    {
        public static bool NhanVien_KiemTraDangNhap(Nv obj)
        {
            return NvDao.NhanVien_KiemTraDangNhap(obj);
        }
    }
}