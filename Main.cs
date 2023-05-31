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
            infohang_pn.Visible = false;
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

        private void HangHoa_table_SelectionChanged(object sender, EventArgs e)
        {
            if (HangHoa_table.SelectedRows.Count > 0)
            {
                infohang_pn.Visible = true;
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
            infohang_pn.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Add_btn1_Click(object sender, EventArgs e)
        {

        }

        private void GiaoDich_Click(object sender, EventArgs e)
        {

        }
    }
}
