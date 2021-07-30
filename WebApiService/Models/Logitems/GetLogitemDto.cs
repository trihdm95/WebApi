using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WebApiService.Models.Logitems
{
    public class GetLogitemDto
    {
        public HttpStatusCode StatusCode { get; set; }
        public string StatusDescription { get; set; }
        public List<Logitem> Data { get; set; }
    }

    public class GetLogitemV2Dto
    {
        public HttpStatusCode StatusCode { get; set; }
        public string StatusDescription { get; set; }
        public List<GetDataV2Dto> Data { get; set; }
    }

    public partial class Logitem
    {
        public string PhieuXuat { get; set; }
        public string SoLenhXuat { get; set; }
        public string ChungTu { get; set; }
        public string MaKh { get; set; }
        public string NgayXuat { get; set; }
        public string SoXe { get; set; }
        public string NhaVTai { get; set; }
        public string TenNhaVTai { get; set; }
        public string DaiLy { get; set; }
        public string TenDaiLy { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string Seri { get; set; }
        public string SoLuong { get; set; }
        public string KhoServer { get; set; }
    }

    public partial class LogitemDto
    {
        public List<LogitemItem> reportData { get; set; }
        public string errorCode { get; set; }
        public string errorName { get; set; }
    }
    public partial class LogitemItem
    {
        public string phieu_xuat { get; set; }
        public string so_lenh_xuat { get; set; }
        public string chung_tu { get; set; }
        public string ma_kh { get; set; }
        public string ngay_xuat { get; set; }
        public string so_xe { get; set; }
        public string nha_vtai { get; set; }
        public string ten_nha_vtai { get; set; }
        public string dai_ly { get; set; }
        public string ten_dai_ly { get; set; }
        public string ma_hang { get; set; }
        public string ten_hang { get; set; }
        public string se_ri { get; set; }
        public string so_luong { get; set; }
        public string kho_server { get; set; }
    }

    public class PostBody
    {
        public List<string> chung_tu { get; set; }
    }

    public class CustAccRespone
    {
        public List<CustAccItem> d { get; set; }
    }

    public class CustAccItem
    {
        public string chung_tu { get; set; }
        public string ma_kh { get; set; }
    }
}
