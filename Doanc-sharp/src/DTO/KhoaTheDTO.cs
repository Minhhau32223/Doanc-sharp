using System;

namespace Doanc_sharp.src.DTO
{
    public class KhoaTheDTO
    {
        public int IdKhoaThe { get; set; }
        public int MaThanhVien { get; set; }
        public DateTime ThoiGianMoKhoa { get; set; }
        public int IsDelete { get; set; }

        public KhoaTheDTO()
        {
            IdKhoaThe = 0;
            MaThanhVien = 0;
            ThoiGianMoKhoa = DateTime.Now;
            IsDelete = 0;
        }

        public KhoaTheDTO(int idKhoaThe, int maThanhVien, DateTime thoiGianMoKhoa, int isDelete)
        {
            IdKhoaThe = idKhoaThe;
            MaThanhVien = maThanhVien;
            ThoiGianMoKhoa = thoiGianMoKhoa;
            IsDelete = isDelete;
        }
    }
} 