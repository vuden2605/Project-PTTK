using System.Data;
using Microsoft.Data.SqlClient;
using Project_PTTK.Model;
using Project_PTTK.DataAccess;

namespace Project_PTTK.Business
{
    public class LichThiBus
    {
        private readonly LichThiDAO _lichThiDAO;
        public LichThiBus (LichThiDAO lichThiDAO)
        {
            _lichThiDAO = lichThiDAO;
        }
        public void tangSoLuongTs(int maLichThi)
        {
            try
            {
                _lichThiDAO.TangSoLuongThiSinhDangKy(maLichThi);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tăng số lượng thí sinh đã đăng ký: ", ex);
            }
        }
    }
}
