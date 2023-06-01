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
            Optionitem_btn1.Visible = false;
            Cancel_btn1.Visible = false;
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
                        string cbb = macongty_cbb1.SelectedItem.ToString();

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
    }
}
