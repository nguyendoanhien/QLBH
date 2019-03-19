#region

using System.Linq;
using DTO;

#endregion

namespace DAO
{
    public class NvDao
    {
        public static bool NhanVien_KiemTraDangNhap(Nv obj)
        {
            var db = new QLBH_WinDBContext();
            return db.Nvs.Any(m => m.MaNv == obj.MaNv && m.Mk == obj.Mk);
        }
    }
}