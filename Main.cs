using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace BanHang
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void MainLoad(object sender, EventArgs e)
        {
            infohanghoa_pn.Visible = false;
            Optionitem_btn1.Visible = false;
            Cancel_btn1.Visible = false;
            infogiaodich_pn.Visible = false;
            Optionitem_btn2.Visible = false;
            Cancel_btn2.Visible = false;
            string connectionString = "Server=StOrmeR;Database=Banhang;Trusted_Connection=True;";
            string query = "Select mahang as [Mã hàng], tenhang as [Tên hàng], macongty as [Mã công ty], maloaihang as [Mã loại hàng],\r\nsoluong as [Số lượng], donvitinh as [Đơn vị tính], giahang as [Giá hàng] from MATHANG";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    HangHoa_table.DataSource = dataTable;
                }
            }

            string query1 = "Select sohoadon as [Số hoá đơn], mahang as [Mã hàng], soluong as [Số lượng], giaban as [Giá bán], mucgiamgia as [Mức giảm giá] from CHITIETDATHANG";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    GiaoDich_table.DataSource = dataTable;
                }
            }

            string query4 = "Select manhanvien as [Mã nhân viên], ho as [Họ], ten as [Tên], ngaysinh as [Ngày sinh], ngaylamviec as [Ngày làm việc], " +
                "diachi as [Địa chỉ], dienthoai as [Điện thoại], luongcoban as [Lương cơ bản], phucap as [Phụ cấp] from NHANVIEN";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query4, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    NhanVien_table.DataSource = dataTable;
                }
            }
        }

        private void HangHoa_table_SelectionChanged(object sender, EventArgs e)
        {
            if (HangHoa_table.SelectedRows.Count > 0)
            {
                infohanghoa_pn.Visible = true;
                DataGridViewRow selectedRow = HangHoa_table.SelectedRows[0];

                // Get the values from the selected row
                string itemID = selectedRow.Cells["Mã hàng"].Value.ToString();
                string rowName = selectedRow.Cells["Tên hàng"].Value.ToString();
                string companyCode = selectedRow.Cells["Mã công ty"].Value.ToString();
                string itemTypeCode = selectedRow.Cells["Mã loại hàng"].Value.ToString();
                int quantity = int.Parse(selectedRow.Cells["Số lượng"].Value.ToString());
                string unitOfMeasure = selectedRow.Cells["Đơn vị tính"].Value.ToString();
                int unitPrice = int.Parse(selectedRow.Cells["Giá hàng"].Value.ToString());

                // Update the textboxes with the values
                mahang_tb.Text = itemID;
                tenhang_tb.Text = rowName;
                macongty_tb.Text = companyCode;
                maloaihang_tb.Text = itemTypeCode;
                soluong_tb.Text = quantity.ToString();
                donvitinh_tb.Text = unitOfMeasure;
                giahang_tb.Text = unitPrice.ToString();
            }
        }

        private void Close_infohang_btn_Click(object sender, EventArgs e)
        {
            infohanghoa_pn.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Add_btn1_Click(object sender, EventArgs e)
        {
            Optionitem_btn1.Visible = true;
            Optionitem_btn1.Text = "Add";
            Cancel_btn1.Visible = true;
        }

        private void Modify_btn1_Click(object sender, EventArgs e)
        {
            Optionitem_btn1.Visible = true;
            Optionitem_btn1.Text = "Modify";
            Cancel_btn1.Visible = true;
        }

        private void Optionitem_btn1_Click(object sender, EventArgs e)
        {
            if(Optionitem_btn1.Text == "Add")
            {
                string connectionString = "Server=StOrmeR;Database=Banhang;Trusted_Connection=True;";
                string itemID = mahang_tb.Text;
                string rowName = tenhang_tb.Text;
                string companyCode = macongty_tb.Text;
                string itemTypeCode = maloaihang_tb.Text;
                int quantity = int.Parse(soluong_tb.Text);
                string unitOfMeasure = donvitinh_tb.Text;
                int unitPrice = int.Parse(giahang_tb.Text);

                string query = $"INSERT INTO MATHANG (mahang, tenhang, macongty, maloaihang, soluong, donvitinh, giahang) VALUES " +
                    $"('{itemID}', '{rowName}', '{companyCode}', '{itemTypeCode}', {quantity},'{unitOfMeasure}',{unitPrice})";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();

                    }
                }
            }
            else if(Optionitem_btn1.Text == "Modify")
            {
                if (HangHoa_table.SelectedRows.Count > 0)
                {
                    // Check if the input elements have data
                    if (!string.IsNullOrEmpty(mahang_tb.Text))
                    {
                        // Get the index of the selected row
                        int rowIndex = HangHoa_table.SelectedRows[0].Index;

                        // Retrieve the values from the input elements
                        string itemID = mahang_tb.Text;
                        string rowName = tenhang_tb.Text;
                        string companyCode = macongty_tb.Text;
                        string itemTypeCode = maloaihang_tb.Text;
                        int quantity = int.Parse(soluong_tb.Text);
                        string unitOfMeasure = donvitinh_tb.Text;
                        int unitPrice = int.Parse(giahang_tb.Text);

                        // Update the corresponding values in the selected row
                        HangHoa_table.Rows[rowIndex].Cells["Mã hàng"].Value = itemID;
                        HangHoa_table.Rows[rowIndex].Cells["Tên hàng"].Value = rowName;
                        HangHoa_table.Rows[rowIndex].Cells["Mã công ty"].Value = companyCode;
                        HangHoa_table.Rows[rowIndex].Cells["Mã loại hàng"].Value = itemTypeCode;
                        HangHoa_table.Rows[rowIndex].Cells["Số lượng"].Value = quantity;
                        HangHoa_table.Rows[rowIndex].Cells["Đơn vị tính"].Value = unitOfMeasure;
                        HangHoa_table.Rows[rowIndex].Cells["Giá hàng"].Value = unitPrice;

                        // Clear the input fields
                        mahang_tb.Text = "";
                        tenhang_tb.Text = "";
                        macongty_tb.Text = "";
                        maloaihang_tb.Text = "";
                        soluong_tb.Text = "";
                        donvitinh_tb.Text = "";
                        giahang_tb.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Please enter all the required information.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row in the DataGridView.");
                }
            }
        }

        private void Refresh_btn1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=StOrmeR;Database=Banhang;Trusted_Connection=True;";
            string query = "Select mahang as [Mã hàng], tenhang as [Tên hàng], macongty as [Mã công ty], maloaihang as [Mã loại hàng],\r\nsoluong as [Số lượng], donvitinh as [Đơn vị tính], giahang as [Giá hàng] from MATHANG";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    HangHoa_table.DataSource = dataTable;
                }
            }
        }

        private void Cancel_btn1_Click(object sender, EventArgs e)
        {           
            mahang_tb.Text = "";
            tenhang_tb.Text = "";
            macongty_tb.Text = "";
            maloaihang_tb.Text = "";
            soluong_tb.Text = "";
            donvitinh_tb.Text = "";
            giahang_tb.Text = "";
            infohanghoa_pn.Visible = false;
            Optionitem_btn1.Visible = false;
            Cancel_btn1.Visible = false;
        }

        private void Delete_btn1_Click(object sender, EventArgs e)
        {
            if (HangHoa_table.SelectedRows.Count > 0)
            {
                // Get the index of the selected row
                int rowIndex = HangHoa_table.SelectedRows[0].Index;

                // Get the primary key value from the selected row
                string primaryKeyValue = HangHoa_table.Rows[rowIndex].Cells["Mã hàng"].Value.ToString();

                // Delete the corresponding data from the database
                DeleteDataFromDatabase1(primaryKeyValue);

                // Remove the selected row from the DataGridView
                HangHoa_table.Rows.RemoveAt(rowIndex);
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.");
            }
        }
        private void DeleteDataFromDatabase1(string primaryKeyValue)
        {
            string connectionString = "Server=StOrmeR;Database=Banhang;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Create a SQL command to delete the row with the specified primary key
                string sql = "DELETE FROM MATHANG WHERE mahang = @PrimaryKeyValue";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Set the value of the primary key parameter
                    command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue);

                    // Execute the SQL command
                    command.ExecuteNonQuery();
                }
            }
        }

        private void GiaoDich_table_SelectionChanged(object sender, EventArgs e)
        {
            if (GiaoDich_table.SelectedRows.Count > 0)
            {
                infohanghoa_pn.Visible = true;
                DataGridViewRow selectedRow = GiaoDich_table.SelectedRows[0];

                // Get the values from the selected row
                string sohoadon = selectedRow.Cells["Số hoá đơn"].Value.ToString();
                string mahang = selectedRow.Cells["Mã hàng"].Value.ToString();
                string giaban = selectedRow.Cells["Giá bán"].Value.ToString();
                string soluong = selectedRow.Cells["Số lượng"].Value.ToString();              
                string mucgiamgia = selectedRow.Cells["Mức giảm giá"].Value.ToString();

                // Update the textboxes with the values
                sohoadon_tb2.Text = sohoadon;
                mahang_tb2.Text = mahang;
                giaban_tb2.Text = giaban;
                soluong_tb2.Text = soluong;
                mucgiamgia_tb2.Text = mucgiamgia;
            }
        }

        private void Search_btn1_Click(object sender, EventArgs e)
        {
            string searchtext = Search_tb1.Text;
            string connectionString = "Server=StOrmeR;Database=Banhang;Trusted_Connection=True;";
            string query = "Select mahang as [Mã hàng], tenhang as [Tên hàng], macongty as [Mã công ty], maloaihang as [Mã loại hàng],\r\nsoluong as [Số lượng], donvitinh as [Đơn vị tính], giahang as [Giá hàng] from MATHANG" +
                "where mahang = " + $"'{searchtext}'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    HangHoa_table.DataSource = dataTable;
                }
            }
        }

        private void Add_btn2_click(object sender, EventArgs e)
        {
            Optionitem_btn2.Visible = true;
            Optionitem_btn2.Text = "Add";
            Cancel_btn1.Visible = true;
        }

        private void Modify_btn2_Click(object sender, EventArgs e)
        {
            Optionitem_btn2.Visible = true;
            Optionitem_btn2.Text = "Modify";
            Cancel_btn1.Visible = true;
        }

        private void Optionitem_btn2_Click(object sender, EventArgs e)
        {
            if (Optionitem_btn2.Text == "Add")
            {
                string connectionString = "Server=StOrmeR;Database=Banhang;Trusted_Connection=True;";
                string sohoadon = sohoadon_tb2.Text;
                string mahang = mahang_tb2.Text;
                int giaban = int.Parse(giaban_tb2.Text);
                string soluong = soluong_tb2.Text;
                int mucgiamgia = int.Parse(mucgiamgia_tb2.Text);

                string query = $"INSERT INTO CHITIETDATHANG (sohoadon, mahang, giaban, soluong, mucgiamgia) VALUES " +
                    $"('{sohoadon}', '{mahang}', '{giaban}', '{soluong}', {mucgiamgia})";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();

                    }
                }
            }
            else if (Optionitem_btn2.Text == "Modify")
            {
                if (GiaoDich_table.SelectedRows.Count > 0)
                {
                    // Check if the input elements have data
                    if (!string.IsNullOrEmpty(sohoadon_tb2.Text))
                    {
                        // Get the index of the selected row
                        int rowIndex = GiaoDich_table.SelectedRows[0].Index;

                        // Retrieve the values from the input elements
                        string sohoadon = sohoadon_tb2.Text;
                        string mahang = mahang_tb2.Text;
                        int giaban = int.Parse(giaban_tb2.Text);
                        string soluong = soluong_tb2.Text;
                        int mucgiamgia = int.Parse(mucgiamgia_tb2.Text);

                        // Update the corresponding values in the selected row
                        GiaoDich_table.Rows[rowIndex].Cells["Số hoá đơn"].Value = sohoadon;
                        GiaoDich_table.Rows[rowIndex].Cells["Mã hàng"].Value = mahang;
                        GiaoDich_table.Rows[rowIndex].Cells["Giá bán"].Value = giaban;
                        GiaoDich_table.Rows[rowIndex].Cells["Số lượng"].Value = soluong;
                        GiaoDich_table.Rows[rowIndex].Cells["Mức giảm giá"].Value = mucgiamgia;

                        // Clear the input fields
                        sohoadon_tb2.Text = "";
                        mahang_tb2.Text = "";
                        giaban_tb2.Text = "";
                        soluong_tb2.Text = "";
                        mucgiamgia_tb2.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Please enter all the required information.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row in the DataGridView.");
                }
            }
        }

        private void Delete_btn2_Click(object sender, EventArgs e)
        {
            if (GiaoDich_table.SelectedRows.Count > 0)
            {
                // Get the index of the selected row
                int rowIndex = GiaoDich_table.SelectedRows[0].Index;

                // Get the primary key value from the selected row
                string primaryKeyValue = GiaoDich_table.Rows[rowIndex].Cells["Số hoá đơn"].Value.ToString();

                // Delete the corresponding data from the database
                DeleteDataFromDatabase2(primaryKeyValue);

                // Remove the selected row from the DataGridView
                GiaoDich_table.Rows.RemoveAt(rowIndex);
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.");
            }
        }

        private void DeleteDataFromDatabase2(string primaryKeyValue)
        {
            string connectionString = "Server=StOrmeR;Database=Banhang;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Create a SQL command to delete the row with the specified primary key
                string sql = "DELETE FROM CHITIETMATHANG WHERE sohoadon = @PrimaryKeyValue";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Set the value of the primary key parameter
                    command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue);

                    // Execute the SQL command
                    command.ExecuteNonQuery();
                }
            }
        }

        private void Cancel_btn2_Click(object sender, EventArgs e)
        {
            sohoadon_tb2.Text = "";
            mahang_tb2.Text = "";
            giaban_tb2.Text = "";
            soluong_tb2.Text = "";
            mucgiamgia_tb2.Text = "";
            infogiaodich_pn.Visible = false;
            Optionitem_btn2.Visible = false;
            Cancel_btn2.Visible = false;
        }

        private void Close_btn2_Click(object sender, EventArgs e)
        {
            infogiaodich_pn.Visible = false;
        }

        private void NhanVien_table_SelectionChanged(object sender, EventArgs e)
        {
            if (NhanVien_table.SelectedRows.Count > 0)
            {
                infonhanvien_pn.Visible = true;
                DataGridViewRow selectedRow = NhanVien_table.SelectedRows[0];

                // Get the values from the selected row
                string manhanvien = selectedRow.Cells["Mã nhân viên"].Value.ToString();
                string ho = selectedRow.Cells["Họ"].Value.ToString();
                string ten = selectedRow.Cells["Tên"].Value.ToString();
                DateTime ngaysinh = (DateTime)selectedRow.Cells["Ngày sinh"].Value;
                DateTime ngaylamviec = (DateTime)selectedRow.Cells["Ngày làm việc"].Value;
                string diachi = selectedRow.Cells["Địa chỉ"].Value.ToString();
                string dienthoai = selectedRow.Cells["Điện thoại"].Value.ToString();
                string luongcoban = selectedRow.Cells["Lương cơ bản"].Value.ToString();
                string phucap = selectedRow.Cells["Phụ cấp"].Value.ToString();

                // Update the textboxes with the values
                manhanvien_tb4.Text = manhanvien;
                ho_tb4.Text = ho;
                ten_tb4.Text = ten;
                ngaysinh_dtp.Value = ngaysinh;
                ngaylamviec_dtp.Value = ngaylamviec;
                diachi_tb4.Text = diachi;
                dienthoai_tb4.Text = dienthoai;
                luongcoban_tb4.Text = luongcoban;
                phucap_tb4.Text = phucap;
            }
        }
    }
}
