using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCoffee
{
    public class NguyenLieu
    {
        public int MaNguyenLieu { get; set; }
        public string TenNguyenLieu { get; set; }
        public string MoTa { get; set; }
        public string DonViChuan { get; set; }//Khi nhan them - lay ten nguyen lieu tao record trong bang don vi (lay id) - sau do insert nguyenlieu moi
        public double SoLuongTonKho { get; set; }//Rang buoc so luong ton >= so luong toi thieu
        public double TonkhoToiThieu { get; set; }
        public int TinhTrang { get; set; }
        public int MaNhaCungCap { get; set; }
    }
}
