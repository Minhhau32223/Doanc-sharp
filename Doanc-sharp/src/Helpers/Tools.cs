using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doanc_sharp.src.Helpers
{
    internal  class Tools
    {
        private Random random = new Random();

        // Sinh số ngẫu nhiên từ min đến max
        public  int GenerateRandomNumber(int min = 100000, int max = 999999)
        {
            return random.Next(min, max);
        }

        // Sinh số ngẫu nhiên không trùng trong database
        public int GenerateUniqueNumber(string tableName, string columnName)
        {
            DbConnection db = new DbConnection(); // Tạo mới trong hàm luôn, tránh null
            int number;
            bool isExist;

            do
            {
                number = GenerateRandomNumber();
                string query = $"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = {number}";
                DataTable dt = db.ExecuteQuery(query);

                isExist = dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0;
            }
            while (isExist);

            return number;
        }
        public bool IsNotEmpty(string text, string fieldName = "Trường")
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show($"{fieldName} không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Hàm kiểm tra ngày hợp lệ (ngày kết thúc phải sau ngày bắt đầu)
        public bool IsValidDateRange(DateTime startDate, DateTime endDate)
        {
            if (endDate <= startDate)
            {
                MessageBox.Show("Ngày trả phải lớn hơn ngày mượn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public bool IsPositiveInteger(string text)
        {
            return int.TryParse(text, out int value) && value > 0;
        }
        public  void ShowCenteredDialog(Form parent, Form child)
        {
            child.StartPosition = FormStartPosition.Manual;
            child.Location = new Point(
                parent.Location.X + (parent.Width - child.Width) / 2,
                parent.Location.Y + (parent.Height - child.Height) / 2
            );
            child.ShowDialog(parent);
        }
    }
}
