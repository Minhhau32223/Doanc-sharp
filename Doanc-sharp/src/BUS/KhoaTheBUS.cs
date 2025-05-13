using System;
using System.Collections.Generic;
using Doanc_sharp.src.DAO;
using Doanc_sharp.src.DTO;

namespace Doanc_sharp.src.BUS
{
    public class KhoaTheBUS
    {
        private KhoaTheDAO khoaTheDAO;

        public KhoaTheBUS()
        {
            khoaTheDAO = new KhoaTheDAO();
        }

        public List<KhoaTheDTO> GetAll()
        {
            try
            {
                return khoaTheDAO.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách khóa thẻ: " + ex.Message);
            }
        }

        public KhoaTheDTO GetById(int id)
        {
            try
            {
                return khoaTheDAO.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin khóa thẻ: " + ex.Message);
            }
        }

        public bool Insert(KhoaTheDTO khoaThe)
        {
            try
            {
                if(khoaThe == null)
                {
                    throw new Exception("Dữ liệu không hợp lệ");
                }
                // Kiểm tra dữ liệu đầu vào
                if (khoaThe.MaThanhVien <= 0)
                {
                    throw new Exception("Mã thành viên không hợp lệ");
                }

                return khoaTheDAO.Insert(khoaThe);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm khóa thẻ: " + ex.Message);
            }
        }

        public bool Update(KhoaTheDTO khoaThe)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (khoaThe.IdKhoaThe <= 0)
                {
                    throw new Exception("ID khóa thẻ không hợp lệ");
                }
                if (khoaThe.MaThanhVien <= 0)
                {
                    throw new Exception("Mã thành viên không hợp lệ");
                }

                return khoaTheDAO.Update(khoaThe);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật khóa thẻ: " + ex.Message);
            }
        }

        public bool Delete(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new Exception("ID khóa thẻ không hợp lệ");
                }

                return khoaTheDAO.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa khóa thẻ: " + ex.Message);
            }
        }
    }
} 