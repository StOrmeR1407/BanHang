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
            string query = "SELECT * FROM MATHANG";

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
                string itemID = selectedRow.Cells["mahang"].Value.ToString();
                string rowName = selectedRow.Cells["tenhang"].Value.ToString();
                string companyCode = selectedRow.Cells["macongty"].Value.ToString();
                string itemTypeCode = selectedRow.Cells["maloaihang"].Value.ToString();
                int quantity = int.Parse(selectedRow.Cells["soluong"].Value.ToString());
                string unitOfMeasure = selectedRow.Cells["donvitinh"].Value.ToString();
                int unitPrice = int.Parse(selectedRow.Cells["giahang"].Value.ToString());

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
    }
}
